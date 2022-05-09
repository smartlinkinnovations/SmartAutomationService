#region
using System;

#endregion

namespace Kroll.KxProto.Client
{
    public class KxProtoDateUtils 
    {
        private static readonly DateTime Epoch = new DateTime(1970, 1, 1);

        #region KxProtoDateUtils Members
        public static double ConvertToKxProtoDateTime(DateTime value)
        {
            TimeSpan diffFromEpoch = value.Subtract(Epoch);
            return diffFromEpoch.TotalDays;
        }

        public static DateTime ConvertToDateTime(double value)
        {
            return Epoch.AddDays(value);
        }
        #endregion
    }
}