using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
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

        public HvRemoteFile[] FindFile(int channelId, DateTime startTime, DateTime stopTime)
        {
            NET_DVR_FILECOND_V40 findcond = new NET_DVR_FILECOND_V40()
            {
                lChannel = channelId,
                struStartTime = startTime.ToNET_DVR_TIME(),
                struStopTime = stopTime.ToNET_DVR_TIME(),
            };
            int iFindHandle = Invoke(NET_DVR_FindFile_V40(session.UserId, ref findcond));
            try
            {
                var fileList = new List<HvRemoteFile>();
                while (true)
                {
                    NET_DVR_FINDDATA_V40 findData = default;
                    var ret = Invoke(NET_DVR_FindNextFile_V40(iFindHandle, ref findData));

                    //没有更多的文件，查找结束
                    if (ret == NET_DVR_NOMOREFILE)
                        break;
                    //获取文件信息成功
                    if (ret == NET_DVR_FILE_SUCCESS)
                    {
                        fileList.Add(new HvRemoteFile(findData));
                        continue;
                    }
                    //未查找到文件
                    if (ret == NET_DVR_FILE_NOFIND)
                        break;
                    //正在查找请等待
                    if (ret == NET_DVR_ISFINDING)
                    {
                        Thread.Sleep(1000);
                        continue;
                    }
                    //查找文件时异常
                    if (ret == NET_DVR_FILE_EXCEPTION)
                    {
                        throw new IOException("NET_DVR_FindNextFile_V40 error,reason:" + NET_DVR_GetLastError());
                    }
                    throw new IOException($"NET_DVR_FindNextFile_V40 error,reason: Unknow return code:{ret}");
                }
                return fileList.ToArray();
            }
            catch
            {
                throw;
            }
            finally
            {
                NET_DVR_FindClose_V30(iFindHandle);
            }
        }

        public int StartDownloadFile(int channelId, DateTime startTime, DateTime stopTime, string destinationPath)
        {
            NET_DVR_PLAYCOND playcond = new NET_DVR_PLAYCOND()
            {
                dwChannel = (uint)channelId,
                struStartTime = startTime.ToNET_DVR_TIME(),
                struStopTime = stopTime.ToNET_DVR_TIME(),
            };
            int iPlayHandle = Invoke(NET_DVR_GetFileByTime_V40(session.UserId, destinationPath, ref playcond));
            uint iOutValue = 0;
            Invoke(NET_DVR_PlayBackControl_V40(iPlayHandle, NET_DVR_PLAYSTART, IntPtr.Zero, 0, IntPtr.Zero, ref iOutValue));
            return iPlayHandle;
        }

        public virtual int StartDownloadFile(string remoteFile, string destinationPath)
        {
            int iPlayHandle = Invoke(NET_DVR_GetFileByName(session.UserId, remoteFile, destinationPath));
            uint iOutValue = 0;
            Invoke(NET_DVR_PlayBackControl_V40(iPlayHandle, NET_DVR_PLAYSTART, IntPtr.Zero, 0, IntPtr.Zero, ref iOutValue));
            return iPlayHandle;
        }

        public int GetDownloadPosition(int fileHandle)=> Invoke(NET_DVR_GetDownloadPos(fileHandle));
        public void StopDownloadFile(int fileHandle)=> Invoke(NET_DVR_StopGetFile(fileHandle));
    }
}
