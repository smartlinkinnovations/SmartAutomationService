#region
using System;

#endregion

namespace Kroll.KxProto.Client
{
    public class KxProtoFrameCodec : IFrameCodec
    {
        #region IKxProtoFrameCodec Members
        public byte[] EncodeMessage(byte[] message)
        {
            Byte[] totalLengthBytes = BitConverter.GetBytes(message.Length);

            if (!BitConverter.IsLittleEndian)
            {
                Array.Reverse(totalLengthBytes);
            }

            Byte[] framedMessage = new byte[message.Length + this.FrameHeaderLength];

            //copy the message length into the response array
            Array.Copy(totalLengthBytes, 0, framedMessage, 0, FrameHeaderLength);

            //copy the response message into the buffer
            Array.Copy(message, 0, framedMessage, FrameHeaderLength, message.Length);

            return framedMessage;
        }

        public int GetMesssageLength(byte[] frameHeader)
        {
            //make sure the header is little endian.
            if (!BitConverter.IsLittleEndian)
            {
                Array.Reverse(frameHeader);
            }

            return BitConverter.ToInt32(frameHeader, 0);
        }

        public int FrameHeaderLength
        {
            get { return 4; }
        }

        public int MaximumMessageLength
        {
            get { return int.MaxValue - this.FrameHeaderLength; }
        }
        #endregion
    }
}