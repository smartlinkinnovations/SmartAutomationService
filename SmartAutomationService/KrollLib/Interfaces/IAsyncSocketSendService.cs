#region
using System;

#endregion

namespace Kroll.KxProto.Client
{
    public interface IAsyncSocketSendService
    {
        IAsyncResult SendMessageAsync(IAsyncSocketContext socketContext, byte[] messageBytes);
    }
}