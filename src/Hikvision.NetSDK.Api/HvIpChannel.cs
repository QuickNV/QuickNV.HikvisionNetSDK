using System;
using System.Collections.Generic;
using System.Text;

namespace Hikvision.NetSDK.Api
{
    public class HvIpChannel : HvChannel
    {
        public bool IsOnline { get; }
        internal HvIpChannel(int id, bool isOnline) : base(id)
        {
            IsOnline = isOnline;
        }
    }
}
