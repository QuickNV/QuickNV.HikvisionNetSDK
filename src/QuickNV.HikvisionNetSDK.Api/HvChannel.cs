using System;
using System.Collections.Generic;
using System.Text;

namespace QuickNV.HikvisionNetSDK.Api
{
    public class HvChannel
    {
        public int Id { get; }
        public string Name { get; internal set; }
        public virtual int RtspChannelId => Id;

        internal HvChannel(int id)
        {
            Id = id;
        }
    }
}
