#region
using System;
using System.IO;
using Kroll.Common.KxProto.Messages;
using ProtoBuf;

#endregion

namespace Kroll.KxProto.Client
{
    public class KxProtoProtobufMessageSerializationService : IMessageSerializationService
    {
        public MessageWrapper DeserializeMessageWrapper(byte[] messageWrapperBytes)
        {
            using (MemoryStream ms = new MemoryStream(messageWrapperBytes))
            {
                return Serializer.Deserialize<MessageWrapper>(ms);
            }
        }

        public T DeserializeMessageContent<T>(byte[] messageContentBytes) where T : class
        {
            using (MemoryStream ms = new MemoryStream(messageContentBytes))
            {
                return Serializer.Deserialize<T>(ms);
            }
        }

        public byte[] SerializeMessageWrapper(MessageWrapper messageWrapper)
        {
            if (messageWrapper == null) throw new ArgumentNullException("messageWrapper");

            using (MemoryStream ms = new MemoryStream())
            {
                Serializer.NonGeneric.Serialize(ms, messageWrapper);
                return ms.ToArray();
            }
        }

        public byte[] SerializeMessageContent<T>(T messageContent) where T : class
        {
            if (messageContent == null) throw new ArgumentNullException("messageContent");

            using (MemoryStream ms = new MemoryStream())
            {
                Serializer.Serialize(ms, messageContent);
                return ms.ToArray();
            }
        }
    }
}