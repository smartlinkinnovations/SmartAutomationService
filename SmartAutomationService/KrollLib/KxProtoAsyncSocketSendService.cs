#region
using System;

#endregion

namespace Kroll.KxProto.Client
{
    public class KxProtoAsyncSocketSendService : IAsyncSocketSendService
    {
        private readonly IFrameCodec mFrameCodec;

        public KxProtoAsyncSocketSendService(IFrameCodec frameCodec)
        {
            this.mFrameCodec = frameCodec;
        }
        
        public IAsyncResult SendMessageAsync(IAsyncSocketContext socketContext, byte[] messageBytes)
        {
            if (socketContext == null) throw new ArgumentNullException("socketContext");
            if (messageBytes == null)
                throw new ArgumentNullException("messageBytes");

            byte[] bytesToSend = mFrameCodec.EncodeMessage(messageBytes);

            return socketContext.Stream.BeginWrite(bytesToSend, 0, bytesToSend.Length, SendMessageAsyncCallback, socketContext);
        }

        private void SendMessageAsyncCallback(IAsyncResult ar)
        {
            IAsyncSocketContext socketContext = null;
            try
            {
                //retrieve the socket context from the state
                socketContext = (IAsyncSocketContext) ar.AsyncState;

                socketContext.Stream.EndWrite(ar);
            }
            catch (Exception)
            {
                if (socketContext != null) socketContext.CloseSocket(false);
            }
        }
    }
}