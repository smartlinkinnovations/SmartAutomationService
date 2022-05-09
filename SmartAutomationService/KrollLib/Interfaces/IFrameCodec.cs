﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Kroll.KxProto.Client
{
    public interface IFrameCodec
    {
        /// <summary>
        /// Returns the number of bytes the frame header uses.
        /// </summary>
        int FrameHeaderLength { get; }

        /// <summary>
        /// Gets the maximum length of the message.  This is the total length of the message excluding the frame header.
        /// </summary>
        int MaximumMessageLength { get; }

        /// <summary>
        /// Encodes the message by adding the frame header.
        /// </summary>
        /// <param name="message"></param>
        /// <returns>The message with the frame header.</returns>
        byte[] EncodeMessage(byte[] message);

        /// <summary>
        /// Returns the length of the message excluding the frame header.
        /// </summary>
        /// <param name="frameHeader">The bytes that represent the frame header.</param>
        /// <returns>Returns the length of the message excluding the frame header.</returns>
        int GetMesssageLength(byte[] frameHeader);
    }
}
