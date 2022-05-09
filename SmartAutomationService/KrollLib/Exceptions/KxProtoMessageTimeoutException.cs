﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Kroll.KxProto.Client
{
    public class KxProtoMessageTimeoutException: Exception
    {
        public KxProtoMessageTimeoutException() {}
        public KxProtoMessageTimeoutException(string message) : base(message) {}
        public KxProtoMessageTimeoutException(string message, Exception innerException) : base(message, innerException) {}
        protected KxProtoMessageTimeoutException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
