#region
using System;

#endregion

namespace Kroll.KxProto.Client
{
    public delegate bool ProcessMessageDelegate(KxProtoSocketContext socketContext, byte[] recordBytes);

    public class KxProtoAsyncSocketReceiveService : IAsyncSocketReceiveService
    {
        private readonly IFrameCodec mFrameCodec;
        private readonly ProcessMessageDelegate mProcessMessage;


        public KxProtoAsyncSocketReceiveService(IFrameCodec frameCodec, ProcessMessageDelegate processMessage)
        {
            if (frameCodec == null) throw new ArgumentNullException("frameCodec");
            if (processMessage == null) throw new ArgumentNullException("processMessage");

            this.mFrameCodec = frameCodec;
            this.mProcessMessage = processMessage;
        }

        public void StartReceiving<T>(T socketContext) where T : IAsyncSocketContext
        {
            socketContext.MessageLength = mFrameCodec.FrameHeaderLength;
            socketContext.SetBufferLength(mFrameCodec.FrameHeaderLength);
            socketContext.BytesRead = 0;
            //Waiting to receive next record...
            socketContext.Stream.BeginRead(socketContext.Buffer, 0, socketContext.Buffer.Length, this.ReadFrameHeaderCallback, socketContext);
        }

        #region Async Callbacks
        private void ReadFrameHeaderCallback(IAsyncResult ar)
        {
            IAsyncSocketContext socketContext = null;
            try
            {
                socketContext = (IAsyncSocketContext)ar.AsyncState;

                if (!socketContext.Socket.Connected)
                {
                    //Socket is not connected.  Cannot complete read.
                    socketContext.CloseSocket(false);
                    return;
                }

                int bytesRead = socketContext.Stream.EndRead(ar);
                socketContext.BytesRead += bytesRead;

                if (bytesRead == 0)
                {
                    //Zero bytes were read.  Closing the socket
                    socketContext.CloseSocket(false);
                }
                else if (socketContext.BytesRead < socketContext.MessageLength)
                {
                    //Read bytes to get record length.  Expecting more bytes.
                    //Waiting to receive more record length bytes."
                    socketContext.Stream.BeginRead(socketContext.Buffer, socketContext.BytesRead, socketContext.Buffer.Length - socketContext.BytesRead, this.ReadFrameHeaderCallback, socketContext);
                }
                else
                {
                    int messageLength = mFrameCodec.GetMesssageLength(socketContext.Buffer);

                    if (messageLength > mFrameCodec.MaximumMessageLength)
                    {
                        //Record length bytes in message exceeds the prescribed maximum record length of {1} bytes
                        socketContext.CloseSocket(false);
                    }
                    else if (messageLength < 0)
                    {
                        //Record length cannot be a negative value.
                        socketContext.CloseSocket(false);
                    }
                    else if (messageLength == 0)
                    {
                        //Read enough bytes for the record length.  Waiting to receive a new record.
                        socketContext.Stream.BeginRead(socketContext.Buffer, 0, socketContext.Buffer.Length, this.ReadFrameHeaderCallback, socketContext);
                    }
                    else
                    {
                        //Read enough bytes for the record length.  Waiting to receive record data
                        socketContext.MessageLength = messageLength;
                        socketContext.BytesRead = 0;
                        socketContext.SetBufferLength(messageLength);
                        socketContext.Stream.BeginRead(socketContext.Buffer, 0, socketContext.Buffer.Length, this.ReadRecordCallback, socketContext);
                    }
                }
            }
            catch (Exception)
            {
                if (socketContext != null) socketContext.CloseSocket(false);
            }
        }

        private void ReadRecordCallback(IAsyncResult ar)
        {
            IAsyncSocketContext socketContext = null;
            try
            {
                socketContext = (IAsyncSocketContext)ar.AsyncState;

                int num = socketContext.Stream.EndRead(ar);

                if (num == 0)
                {
                    //Zero bytes were read.  Closing the socket.
                    socketContext.CloseSocket(false);
                }
                else if (num < (socketContext.MessageLength - socketContext.BytesRead))
                {
                    socketContext.BytesRead += num;
                    //Message bytes were read.  More expected.
                    socketContext.Stream.BeginRead(socketContext.Buffer, socketContext.BytesRead, socketContext.Buffer.Length - socketContext.BytesRead, this.ReadRecordCallback, socketContext);
                }
                else
                {
                    //make a copy of the record 
                    //so that anything processing it doesn't mess up the buffer
                    //this also keeps it relatively safe so that we can reuse the buffer and the message processor won't have problems
                    byte[] message = new byte[socketContext.MessageLength];
                    Array.Copy(socketContext.Buffer, 0, message, 0, socketContext.MessageLength);

                    //process the record.  this is handled by the inheritor which later outsources it.
                    if (this.mProcessMessage((KxProtoSocketContext)socketContext, message))
                    {
                        //We are done processing the record.  We will now wait for a new record on the same socket.

                        this.StartReceiving(socketContext);
                    }
                    else
                    {
                        //Message processing failed.  Closing the socket.
                        socketContext.CloseSocket(false);
                    }
                }
            }
            catch (Exception)
            {
                if (socketContext != null) socketContext.CloseSocket(false);
            }
        }
        #endregion
    }
}