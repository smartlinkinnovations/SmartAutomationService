#region
using System;

#endregion

namespace Kroll.KxProto.Client
{
    public class SocketClosedEventArgs : EventArgs
    {
        private readonly bool mUserInitiated;

        public SocketClosedEventArgs(bool userInitiated)
        {
            this.mUserInitiated = userInitiated;
        }

        public bool UserInitiated
        {
            get { return this.mUserInitiated; }
        }
    }
}