﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Kroll.KxProto.Client
{
    public class ConnectionTimeoutException: Exception
    {
        public ConnectionTimeoutException() {}
        public ConnectionTimeoutException(string message) : base(message) {}
        public ConnectionTimeoutException(string message, Exception innerException) : base(message, innerException) {}
        protected ConnectionTimeoutException(SerializationInfo info, StreamingContext context) : base(info, context) {}
    }
}
