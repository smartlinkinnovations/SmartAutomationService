﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Kroll.KxProto.Client
{
    public class ConnectionException: Exception
    {
        public ConnectionException() {}
        public ConnectionException(string message) : base(message) {}
        public ConnectionException(string message, Exception innerException) : base(message, innerException) {}
        protected ConnectionException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
