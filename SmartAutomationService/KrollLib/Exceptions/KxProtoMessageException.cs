#region
using System;

#endregion

namespace Kroll.KxProto.Client
{
    public class KxProtoMessageException : Exception
    {
        private readonly int mErrorNumber;

        public KxProtoMessageException(string message, int errorNumber) : base(message)
        {
            this.mErrorNumber = errorNumber;
        }

        public int ErrorNumber
        {
            get { return this.mErrorNumber; }
        }
    }
}