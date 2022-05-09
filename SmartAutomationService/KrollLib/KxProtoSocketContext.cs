#region
using System;
using System.IO;
using System.Net.Sockets;

#endregion

namespace Kroll.KxProto.Client
{
    public class KxProtoSocketContext : IAsyncSocketContext
    {
        private readonly Socket mSocket;
        private readonly IAsyncSocketReceiveService mAsyncAsyncSocketReceiveService;
        private readonly IAsyncSocketSendService mAsyncSocketSendService;
        private readonly IMessageSerializationService mMessageSerialiationService;

        private Stream mStream;
        private byte[] mBuffer;
        private int mBytesRead;
        private int mMessageLength;
        private string mMessageOriginator;
        private bool mIsDisposed;

        public KxProtoSocketContext(Socket socket, IAsyncSocketReceiveService asyncAsyncSocketReceiveService, IAsyncSocketSendService asyncSocketSendService, IMessageSerializationService messageSerialiationService)
        {
            this.mSocket = socket;
            this.mAsyncAsyncSocketReceiveService = asyncAsyncSocketReceiveService;
            this.mAsyncSocketSendService = asyncSocketSendService;
            this.mMessageSerialiationService = messageSerialiationService;
        }

        public Socket Socket
        {
            get { return this.mSocket; }
        }

        public Stream Stream
        {
            get
            {
                if (mStream == null)
                {
                    this.mStream = new NetworkStream(mSocket, true);
                }
                return this.mStream;
            }
            set { this.mStream = value; }
        }


        public IAsyncSocketReceiveService AsyncSocketReceiveService
        {
            get { return this.mAsyncAsyncSocketReceiveService; }
        }

        public IAsyncSocketSendService AsyncSocketSendService
        {
            get { return mAsyncSocketSendService; }
        }

        public byte[] Buffer
        {
            get { return this.mBuffer; }
        }

        public int MessageLength
        {
            get { return this.mMessageLength; }
            set { this.mMessageLength = value; }
        }

        public int BytesRead
        {
            get { return this.mBytesRead; }
            set { this.mBytesRead = value; }
        }

        public void SetBufferLength(int length)
        {
            mBuffer = new byte[length];
        }

        public string MessageOriginator
        {
            get { return mMessageOriginator; }
            set { mMessageOriginator = value; }
        }
        public IMessageSerializationService MessageSerialiationService
        {
            get { return this.mMessageSerialiationService; }
        }

        public void CloseSocket()
        {
            this.CloseSocket(false);
        }

        public void CloseSocket(bool userInitiated)
        {
            if (mIsDisposed)
                return;

            mIsDisposed = true;

            if (mSocket != null)
            {
                if (mStream != null)
                {
                    mStream.Close();
                    mStream = null;
                }

                if (mSocket.Connected)
                {
                    mSocket.LingerState.Enabled = false;
                    mSocket.Shutdown(SocketShutdown.Both);
                    mSocket.Close();
                }

                var eventHandler = SocketClosed;
                if (eventHandler != null)
                {
                    eventHandler(this, new SocketClosedEventArgs(userInitiated));
                }
            }
        }

        public event EventHandler<SocketClosedEventArgs> SocketClosed;
    }
}