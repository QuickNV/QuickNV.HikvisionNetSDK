using System;
using System.Collections.Generic;
using System.Text;

namespace QuickNV.HikvisionNetSDK.Api
{
    public class HvIpChannel : HvChannel
    {
        private int rtspChannelId;
        public bool IsOnline { get; }
        public override int RtspChannelId => rtspChannelId;
        internal HvIpChannel(int id, int rtspChannelId, bool isOnline) : base(id)
        {
            IsOnline = isOnline;
            this.rtspChannelId = rtspChannelId;
        }
    }
}
