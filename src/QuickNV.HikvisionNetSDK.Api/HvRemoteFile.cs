using System;
using System.Collections.Generic;
using System.Text;
using static QuickNV.HikvisionNetSDK.Defines;

namespace QuickNV.HikvisionNetSDK.Api
{
    public class HvRemoteFile
    {
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime StopTime { get; set; }
        public long Size { get; set; }

        internal HvRemoteFile(NET_DVR_FIND_PICTURE_V50 findData)
        {
            Name = Encoding.Default.GetString(findData.sFileName);
            StartTime = findData.struTime.ToDateTime();
            Size = findData.dwFileSize;
        }

        internal HvRemoteFile(NET_DVR_FINDDATA_V30 findData)
        {
            Name = findData.sFileName;
            StartTime = findData.struStartTime.ToDateTime();
            StopTime = findData.struStopTime.ToDateTime();
            Size = findData.dwFileSize;
        }

        internal HvRemoteFile(NET_DVR_FINDDATA_V40 findData)
        {
            Name = findData.sFileName;
            StartTime = findData.struStartTime.ToDateTime();
            StopTime = findData.struStopTime.ToDateTime();
            Size = findData.dwFileSize;
        }

        public HvRemoteFile()
        {
        }
    }
}
