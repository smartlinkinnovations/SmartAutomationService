﻿namespace Kroll.KxProto.Client
{
    public interface IAsyncSocketReceiveService
    {
        void StartReceiving<T>(T socketContext) where T: IAsyncSocketContext;
    }
}