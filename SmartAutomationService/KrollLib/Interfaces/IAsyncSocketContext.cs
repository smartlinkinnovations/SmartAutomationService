#region
using System;
using System.IO;
using System.Net.Sockets;

#endregion

namespace Kroll.KxProto.Client
{
    public interface IAsyncSocketContext
    {
        Socket Socket { get; }
        Stream Stream { get; set; }
        void CloseSocket(bool userInitiated);
        event EventHandler<SocketClosedEventArgs> SocketClosed;

        byte[] Buffer { get; }
        int MessageLength { get; set; }
        int BytesRead { get; set; }
        void SetBufferLength(int length);

        string MessageOriginator { get; set; }

        IAsyncSocketReceiveService AsyncSocketReceiveService { get; }
        IAsyncSocketSendService AsyncSocketSendService { get; }

    }
}