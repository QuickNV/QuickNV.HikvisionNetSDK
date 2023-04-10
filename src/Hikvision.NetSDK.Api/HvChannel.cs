using System;
using System.Collections.Generic;
using System.Text;

namespace Hikvision.NetSDK.Api
{
    public class HvChannel
    {
        public int Id { get; }
        public string Name { get; internal set; }

        internal HvChannel(int id)
        {
            Id = id;
        }
    }
}
