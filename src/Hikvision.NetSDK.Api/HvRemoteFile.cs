using System;
using System.Collections.Generic;
using System.Text;
using static Hikvision.NetSDK.Defines;

namespace Hikvision.NetSDK.Api
{
    public class HvRemoteFile
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Duration { get; set; }
        public long Size { get; set; }

        internal HvRemoteFile(NET_DVR_FIND_PICTURE_V50 findData)
        {
            this.Name = Encoding.Default.GetString(findData.sFileName);
            this.Date = findData.struTime.ToDateTime();
            this.Size = findData.dwFileSize;
        }

        internal HvRemoteFile(NET_DVR_FINDDATA_V30 findData)
        {
            this.Name = findData.sFileName;
            this.Date = findData.struStartTime.ToDateTime();
            this.Duration = (int)(findData.struStopTime.ToDateTime() - findData.struStartTime.ToDateTime()).TotalSeconds;
            this.Size = findData.dwFileSize;
        }

        public HvRemoteFile()
        {
        }
    }
}
