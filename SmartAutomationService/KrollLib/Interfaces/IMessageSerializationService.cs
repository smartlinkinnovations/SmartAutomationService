#region
using System;
using Kroll.Common.KxProto.Messages;

#endregion

namespace Kroll.KxProto.Client
{
    public interface IMessageSerializationService
    {
        MessageWrapper DeserializeMessageWrapper(byte[] messageWrapperBytes);
        T DeserializeMessageContent<T>(byte[] messageContentBytes) where T : class;

        byte[] SerializeMessageWrapper(MessageWrapper messageWrapper);
        byte[] SerializeMessageContent<T>(T messageContent) where T : class;
    }
}