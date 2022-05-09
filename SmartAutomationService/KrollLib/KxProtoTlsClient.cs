#region
using System;
using System.IO;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Kroll.Common.KxProto.Messages;
using ProtoBuf;

#endregion

namespace Kroll.KxProto.Client
{
    public class KxProtoTlsClient : IKxProtoTlsClient
    {
        private readonly IAsyncSocketReceiveService mAsyncSocketReceiveService;
        private readonly IAsyncSocketSendService mAsyncSocketSendService;
        private readonly IFrameCodec mFrameCodec;

        //variables for socket handling
        private KxProtoSocketContext mSocketContext;
        private X509Certificate2 mClientCertificate;
        private bool mIsConnectionSuccessful;
        private Exception mSocketException;

        private MessageWrapper mRequestMessageWrapper;
        private MessageWrapper mResponseMessageWrapper;
        private readonly ManualResetEvent mConnectionTimeoutWaitHandle = new ManualResetEvent(false);
        private readonly ManualResetEvent mMessageTimeoutWaitHandle = new ManualResetEvent(false);


        public KxProtoTlsClient()
        {
            mFrameCodec = new KxProtoFrameCodec();
            mAsyncSocketSendService = new KxProtoAsyncSocketSendService(mFrameCodec);
            mAsyncSocketReceiveService = new KxProtoAsyncSocketReceiveService(mFrameCodec, ProcessMessageCallback);
        }

        public void Connect(string host, int port, string remoteCertificateName, X509Certificate2 clientCertificate, TimeSpan connectionTimeout, KxProtoMessageSerializationType serializationType)
        {
            if (string.IsNullOrEmpty(host)) throw new ArgumentNullException("host");
            if (port <= 0 || port > 65535) throw new ArgumentOutOfRangeException("port");
            if (clientCertificate == null) throw new ArgumentNullException("clientCertificate");
            if (!clientCertificate.HasPrivateKey) throw new ArgumentException("Client certificate requires a private key.", "clientCertificate");

            mClientCertificate = clientCertificate;

            try
            {
                Socket clientSocket = InternalConnect(host, port, connectionTimeout);

                var serializationService = CreateMessageSerializationService(serializationType);
                mSocketContext = new KxProtoSocketContext(clientSocket, this.mAsyncSocketReceiveService, this.mAsyncSocketSendService, serializationService);

                //we have to negotiate TLS
                SslStream secureStream = new SslStream(mSocketContext.Stream, false, RemoteCertificateValidationCallback, LocalCertificateSelectionCallback);
                mSocketContext.Stream = secureStream;

                //Authenticating TLS connection
                X509Certificate2Collection certificates = new X509Certificate2Collection();
                certificates.Add(mClientCertificate);

                secureStream.AuthenticateAsClient(remoteCertificateName, certificates, SslProtocols.None, false);

                if (secureStream.RemoteCertificate == null)
                {
                    mSocketContext.CloseSocket(false);
                    throw new ConnectionException("Remote server did not present a server certificate.");
                }

                if (secureStream.LocalCertificate != null)
                {
                    mSocketContext.MessageOriginator = GetCertificateCommonName(secureStream.LocalCertificate);
                }

                mAsyncSocketReceiveService.StartReceiving(mSocketContext);
            }
            catch
            {
                if (mSocketContext != null)
                {
                    mSocketContext.CloseSocket(false);
                    mSocketContext = null;
                }
                throw;
            }
        }

        public void Disconnect()
        {
            lock (mSocketContext)
            {
                mSocketContext.CloseSocket(true);
                mSocketContext = null;
            }
        }

        public bool IsConnected()
        {
            if (mSocketContext == null) return false;
            if (mSocketContext.Socket == null) return false;
            return mSocketContext.Socket.Connected;
        }

        /// <summary>
        /// this function will send a message to the server and wait for a response.
        /// We use the MessageId field to determine if the incoming response matches the outgoing request.
        /// there is a requirement that the response message has the same MessageId as the corresponding request.
        /// the inbound message could be a valid response, or an error response.  
        /// You can simulate an error by blanking out the MessageName or many other fields in the request.
        /// 
        /// This implementation is naive.  It allows only a single active request-response and does not allow pipelining requests. 
        /// Pipelining is supported, as is multi-threading, however, the client will need to change so that it can match 
        /// requests and responses based on the messageId.
        /// </summary>
        /// <typeparam name="TRequestType">The type of request message being sent.</typeparam>
        /// <typeparam name="TResponseType">The expected type of response message being returned.</typeparam>
        /// <param name="request">The request message we want to send.</param>
        /// <param name="messageName">The name of the request message we want to send.  Typically this will match the request message's class name.</param>
        /// <param name="messageVersion">The version of the request message we want to send.  Use 1.0 if not sure.</param>
        /// <param name="timeout">The timeout duration we will wait for a response.</param>
        /// <returns>The response message returned</returns>
        public TResponseType SendMessageAndWait<TRequestType, TResponseType>(TRequestType request, string messageName, string messageVersion, TimeSpan timeout)
            where TRequestType : class
            where TResponseType : class
        {
            if (!IsConnected()) throw new ConnectionException("Client is not connected.");

            //reset the wait handle.  This is used so that we can wait for the response that corresponds to our request.
            mMessageTimeoutWaitHandle.Reset();

            //generate the message wrapper for this request.
            MessageWrapper requestMessageWrapper = new MessageWrapper();
            requestMessageWrapper.IsResponse = false;
            requestMessageWrapper.MessageId = Guid.NewGuid().ToString();
            requestMessageWrapper.MessageDateTimeUTC = KxProtoDateUtils.ConvertToKxProtoDateTime(DateTime.UtcNow);
            requestMessageWrapper.MessageOriginator = mSocketContext.MessageOriginator;
            requestMessageWrapper.MessageName = messageName;
            requestMessageWrapper.MessageVersion = messageVersion;
            requestMessageWrapper.MessageContent = mSocketContext.MessageSerialiationService.SerializeMessageContent(request);

            //now serialize the messageWrapper into bytes that we can send on the wire.
            Byte[] messageBytes = mSocketContext.MessageSerialiationService.SerializeMessageWrapper(requestMessageWrapper);

            //lock the socket context just incase some other thread wants to use it.
            lock (mSocketContext)
            {
                //set the request message so that we can match it up to our response.
                //since the response will be returned on a different thread (because our sockets are async).
                mRequestMessageWrapper = requestMessageWrapper;

                //send the message asynchronously.
                mAsyncSocketSendService.SendMessageAsync(mSocketContext, messageBytes);
            }

            try
            {
                //now wait for an incoming message.  Since our sockets are async, it will return on a different thread
                //in the callback function, so we have to wait for that thread to unlock the wait handle.                
                if (this.mMessageTimeoutWaitHandle.WaitOne(timeout))
                {
                    //if waitOne returns true, it means the other thread received a message and we can process the message.

                    //the other thread set the mResponseMessageWrapper variable, so read it.
                    MessageWrapper responseMessageWrapper = this.mResponseMessageWrapper;

                    //we have to check if the response message was an error, or if it was the expected response
                    //if it was an error, the message name will be ErrorResponse, and the MessageId will be the same as the request
                    //the messageId was already matched up in the receive callback handler, so we don't have to check again.
                    if (string.Equals(responseMessageWrapper.MessageName, "ErrorResponse", StringComparison.Ordinal))
                    {
                        //deserialize the error, and throw an exception with the details of the error.
                        //errors here are generally reserved for errors caused by messaging infrastructure, not errors specific to the interface.
                        //typically errors to the specific interface (such as cannot find patient, etc), are handled within the specific response
                        //message for that interface.
                        ErrorResponse errorResponse = mSocketContext.MessageSerialiationService.DeserializeMessageContent<ErrorResponse>(responseMessageWrapper.MessageContent);
                        throw new KxProtoMessageException(errorResponse.ErrorMessage, errorResponse.ErrorNumber);
                    }
                    else
                    {
                        //we got a real response message.  We can deserialize it and return it to the caller.
                        TResponseType response = mSocketContext.MessageSerialiationService.DeserializeMessageContent<TResponseType>(responseMessageWrapper.MessageContent);
                        return response;
                    }
                }
                else
                {
                    //if waitOne returns false, it means that we didn't get a response in time, and the wait timed out.
                    //the caller will need to handle this accordingly.
                    throw new KxProtoMessageTimeoutException();
                }
            }
            finally
            {
                this.mRequestMessageWrapper = null;
                this.mResponseMessageWrapper = null;
            }
        }

        public void SendOneWayMessage<TRequestType>(TRequestType request, string messageName, string messageVersion) where TRequestType : class
        {
            if (!IsConnected()) throw new ConnectionException("Client is not connected.");

            //in some cases, one-way messages are supported, such as a broadcast.  While the infrastructure supports it,
            //there are very few interfaces that use them.  In any case, this is how a one-way message is transmitted.

            MessageWrapper messageWrapper = new MessageWrapper();
            messageWrapper.IsResponse = false;
            messageWrapper.MessageId = Guid.NewGuid().ToString();
            messageWrapper.MessageDateTimeUTC = KxProtoDateUtils.ConvertToKxProtoDateTime(DateTime.UtcNow);
            messageWrapper.MessageOriginator = mSocketContext.MessageOriginator;
            messageWrapper.MessageName = messageName;
            messageWrapper.MessageVersion = messageVersion;
            messageWrapper.MessageContent = mSocketContext.MessageSerialiationService.SerializeMessageContent(request);

            Byte[] messageBytes = mSocketContext.MessageSerialiationService.SerializeMessageWrapper(messageWrapper);

            lock (mSocketContext)
            {
                mAsyncSocketSendService.SendMessageAsync(mSocketContext, messageBytes);
            }
        }

        /// <summary>
        /// Callback function that is invoked when we have an incoming message.
        /// </summary>
        /// <param name="socketContext">The socket context that received the message</param>
        /// <param name="recordBytes">The bytes in the incoming message.</param>
        /// <returns>True if we can process the message, false if we can't and want the socket to close.</returns>
        private bool ProcessMessageCallback(KxProtoSocketContext socketContext, byte[] recordBytes)
        {
            //this function is invoked ON A SEPARATE THREAD when a message is received.
            //what we want to do is compare the request with the response.

            //we should add some locking on mRequestMessageWrapper and mResponseMessageWrapper if we plan to multi-thread this client code.

            //don't do anything if we have a request that we can handle.
            //check the initial request, and if it is blank, we can't do anything with it.    
            MessageWrapper request = mRequestMessageWrapper;
            if (request == null) return true;

            //deserialize the inbound message wrapper.            
            MessageWrapper responseMessageWrapper = socketContext.MessageSerialiationService.DeserializeMessageWrapper(recordBytes);

            //check to see that the message we got back corresponds to the request.
            if (string.Equals(request.MessageId, responseMessageWrapper.MessageId, StringComparison.Ordinal))
            {
                //if it does, then set the message state and release the wait handle.
                mResponseMessageWrapper = responseMessageWrapper;
                this.mMessageTimeoutWaitHandle.Set();
            }

            return true;
        }

        private Socket InternalConnect(string host, int port, TimeSpan connectTimeout)
        {
            if (string.IsNullOrEmpty(host))
                throw new ArgumentNullException("host");

            this.mConnectionTimeoutWaitHandle.Reset();
            mSocketException = null;

            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            socket.BeginConnect(host, port, ConnectionCallBack, socket);

            if (mConnectionTimeoutWaitHandle.WaitOne(connectTimeout, false))
            {
                if (!mIsConnectionSuccessful)
                {
                    socket.Close();

                    if (mSocketException != null)
                    {
                        throw new ConnectionException(mSocketException.Message, mSocketException);
                    }
                    {
                        throw new ConnectionException("An error occurred while trying to connect.");
                    }
                }
            }
            else
            {
                socket.Close();
                throw new ConnectionTimeoutException(String.Format("The socket timed out while attempting to connect to {0}:{1}", host, port));
            }

            //Connected

            socket.Blocking = true;
            return socket;
        }

        private void ConnectionCallBack(IAsyncResult asyncResult)
        {
            try
            {
                mIsConnectionSuccessful = false;
                Socket socket = (Socket) asyncResult.AsyncState;

                socket.EndConnect(asyncResult);
                //the endconnect function should throw any exceptions that are lying around
                //from the connection
                mIsConnectionSuccessful = true;
            }
            catch (Exception ex)
            {
                mIsConnectionSuccessful = false;
                mSocketException = ex;
            }
            finally
            {
                this.mConnectionTimeoutWaitHandle.Set();
            }
        }

        public bool RemoteCertificateValidationCallback(
            Object sender,
            X509Certificate certificate,
            X509Chain chain,
            SslPolicyErrors sslPolicyErrors
            )
        {
            //do some basic validation on the remote certificate.  
            //it isn't extensive but we try.
            if (sslPolicyErrors == SslPolicyErrors.None)
                return true;

            if (sslPolicyErrors == SslPolicyErrors.RemoteCertificateChainErrors)
                return true;

            if ((sslPolicyErrors & SslPolicyErrors.RemoteCertificateNotAvailable) == SslPolicyErrors.RemoteCertificateNotAvailable)
                return false;

            if ((sslPolicyErrors & SslPolicyErrors.RemoteCertificateNameMismatch) == SslPolicyErrors.RemoteCertificateNameMismatch)
                return false;

            return true;
        }

        private X509Certificate LocalCertificateSelectionCallback(Object sender,
                                                                  string targetHost,
                                                                  X509CertificateCollection localCertificates,
                                                                  X509Certificate remoteCertificate,
                                                                  string[] acceptableIssuers)
        {
            //this callback is required to help us pick the client certificate.
            return mClientCertificate;
        }

        public string GetCertificateCommonName(X509Certificate certificate)
        {
            //this function gets the CN value from the certificate.  We use it to determine the MessageOriginator value in our messages.
            if (certificate == null) throw new ArgumentNullException("certificate");

            X500DistinguishedName dn = new X500DistinguishedName(certificate.Subject);
            string subject = dn.Decode(X500DistinguishedNameFlags.UseNewLines);

            if (string.IsNullOrEmpty(subject)) return null;

            string[] elements = subject.Split(new[] {'\r', '\n'}, StringSplitOptions.RemoveEmptyEntries);

            foreach (string element in elements)
            {
                if (element.StartsWith("CN=", StringComparison.InvariantCultureIgnoreCase))
                {
                    return element.Substring(3);
                }
            }
            return null;
        }

        private IMessageSerializationService CreateMessageSerializationService(KxProtoMessageSerializationType serializationType)
        {
            if (serializationType == KxProtoMessageSerializationType.KxProto)
            {
                //Protobuf is the default and preferred message serialization type
                return new KxProtoProtobufMessageSerializationService();
            }
            else
            {
                throw new NotSupportedException("KxProto message serialization type is not supported.");
            }
        }
    }
}