using System;
using static QuickNV.HikvisionNetSDK.Defines;
using static QuickNV.HikvisionNetSDK.Methods;

namespace QuickNV.HikvisionNetSDK.Api.Service
{
    public class VideoFileService
    {
        private HvSession session;
        internal VideoFileService(HvSession session)
        {
            this.session = session;
        }

        public void FindFile(int channelId, DateTime startTime, DateTime stopTime)
        {
            NET_DVR_PLAYCOND playcond = new NET_DVR_PLAYCOND()
            {
                dwChannel = (uint)channelId,
                struStartTime = startTime.ToNET_DVR_TIME(),
                struStopTime = stopTime.ToNET_DVR_TIME(),
            };
            int downloadHandle = Invoke(NET_DVR_GetFileByTime_V40(session.UserId, string.Empty, ref playcond));

        }

        public int StartDownloadFile(int channelId, DateTime startTime, DateTime stopTime, string destinationPath)
        {
            NET_DVR_PLAYCOND playcond = new NET_DVR_PLAYCOND()
            {
                dwChannel = (uint)channelId,
                struStartTime = startTime.ToNET_DVR_TIME(),
                struStopTime = stopTime.ToNET_DVR_TIME(),
            };
            int downloadHandle = Invoke(NET_DVR_GetFileByTime_V40(session.UserId, destinationPath, ref playcond));
            uint iOutValue = 0;
            Invoke(NET_DVR_PlayBackControl_V40(downloadHandle, NET_DVR_PLAYSTART, IntPtr.Zero, 0, IntPtr.Zero, ref iOutValue));
            return downloadHandle;
        }

        public virtual int StartDownloadFile(string remoteFile, string destinationPath)
        {
            int downloadHandle = Invoke(NET_DVR_GetFileByName(session.UserId, remoteFile, destinationPath));
            uint iOutValue = 0;
            Invoke(NET_DVR_PlayBackControl_V40(downloadHandle, NET_DVR_PLAYSTART, IntPtr.Zero, 0, IntPtr.Zero, ref iOutValue));
            return downloadHandle;
        }

        public int GetDownloadPosition(int fileHandle)=> Invoke(NET_DVR_GetDownloadPos(fileHandle));
        public void StopDownloadFile(int fileHandle)=> Invoke(NET_DVR_StopGetFile(fileHandle));
    }
}
