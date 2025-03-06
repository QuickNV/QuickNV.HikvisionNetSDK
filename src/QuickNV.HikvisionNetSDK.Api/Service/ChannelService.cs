using QuickNV.HikvisionNetSDK.Api.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using static QuickNV.HikvisionNetSDK.Defines;
using static QuickNV.HikvisionNetSDK.Methods;

namespace QuickNV.HikvisionNetSDK.Api.Service
{
    public class ChannelService
    {
        private HvSession session;
        private int rtspPort;
        public IReadOnlyCollection<HvChannel> AnalogChannels { get; private set; }
        public IReadOnlyCollection<HvIpChannel> IpChannels { get; private set; }
        public IReadOnlyCollection<HvChannel> AllChannels { get; private set; }

        internal ChannelService(HvSession session, NET_DVR_DEVICEINFO_V30 deviceInfo)
        {
            this.session = session;
            RefreshChannelsInfo(deviceInfo);
            rtspPort = session.ConfigService.GetRtspPort();
        }

        private void RefreshChannelsInfo(NET_DVR_DEVICEINFO_V30 deviceInfo)
        {
            var allChannels = new List<HvChannel>();

            var dwAnalogChannelTotalNumber = deviceInfo.byChanNum;
            var analogChannels = new List<HvChannel>();
            for (var i = 0; i < dwAnalogChannelTotalNumber; i++)
            {
                var id = i + deviceInfo.byStartChan;
                var channel = new HvChannel(id);
                analogChannels.Add(channel);
                allChannels.Add(channel);
            }
            AnalogChannels = analogChannels;

            var ipChannels = new List<HvIpChannel>();
            uint dwDigitalChannelTotalNumber = deviceInfo.byIPChanNum + 256 * (uint)deviceInfo.byHighDChanNum;
            if (dwDigitalChannelTotalNumber > 0)
            {
                NET_DVR_IPPARACFG_V40 struIpParaCfgV40 = default;

                int dwSize = Marshal.SizeOf(struIpParaCfgV40);

                IntPtr ptrIpParaCfgV40 = Marshal.AllocHGlobal(dwSize);
                Marshal.StructureToPtr(struIpParaCfgV40, ptrIpParaCfgV40, false);

                uint dwReturn = 0;
                int iGroupNo = 0;

                var ipChannelsConfig = Invoke(NET_DVR_GetDVRConfig(
                    session.UserId,
                    NET_DVR_GET_IPPARACFG_V40,
                    iGroupNo,
                    ptrIpParaCfgV40,
                    (uint)dwSize,
                    ref dwReturn));
                if (ipChannelsConfig)
                {
                    // succ
                    struIpParaCfgV40 = Marshal.PtrToStructure<NET_DVR_IPPARACFG_V40>(ptrIpParaCfgV40);

                    byte byStreamType;
                    uint iDChanNum = 64;

                    if (dwDigitalChannelTotalNumber < 64)
                    {
                        //If the ip channels of device is less than 64,will get the real channel of device
                        iDChanNum = dwDigitalChannelTotalNumber;
                    }

                    for (int i = 0; i < iDChanNum; i++)
                    {
                        byStreamType = struIpParaCfgV40.struStreamMode[i].byGetStreamType;
                        var unionGetStream = struIpParaCfgV40.struStreamMode[i].uGetStream;

                        switch (byStreamType)
                        {
                            //At present NVR just support case 0-one way to get stream from device
                            case 0:
                                dwSize = Marshal.SizeOf(unionGetStream);
                                IntPtr ptrChanInfo = Marshal.AllocHGlobal(dwSize);
                                Marshal.StructureToPtr(unionGetStream, ptrChanInfo, false);
                                var struChanInfo = Marshal.PtrToStructure<NET_DVR_IPCHANINFO>(ptrChanInfo);
                                //List ip channels
                                if (struChanInfo.byIPID == 0)
                                    continue;
                                var channelId = i + (int)struIpParaCfgV40.dwStartDChan;
                                var channel = new HvIpChannel(
                                        channelId,
                                        i + 1,
                                        struChanInfo.byEnable != 0);
                                ipChannels.Add(channel);
                                allChannels.Add(channel);
                                Marshal.FreeHGlobal(ptrChanInfo);
                                break;

                            default:
                                break;
                        }
                    }
                }
                Marshal.FreeHGlobal(ptrIpParaCfgV40);
            }
            IpChannels = ipChannels;
            AllChannels = allChannels;
        }

        public void RefreshChannelName(HvChannel channel)
        {
            NET_DVR_PICCFG_V30 config = default;
            var ptrSize = Marshal.SizeOf(config);
            IntPtr ptr = Marshal.AllocHGlobal(ptrSize);
            try
            {
                uint ret = 0;
                Invoke(NET_DVR_GetDVRConfig(session.UserId, NET_DVR_GET_PICCFG_V30, channel.Id, ptr, (uint)ptrSize, ref ret));
                config = Marshal.PtrToStructure<NET_DVR_PICCFG_V30>(ptr);
                channel.Name = StringUtils.ByteArray2String(config.sChanName, session.Encoding);
            }
            catch
            {
                throw;
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }
        }

        public void RefreshChannelsName()
        {
            foreach (var channel in AllChannels)
                RefreshChannelName(channel);
        }

        /// <summary>
        /// 云台控制
        /// </summary>
        /// <param name="channelId">通道号</param>
        /// <param name="ptzCommand">云台控制命令</param>
        /// <param name="isStop">云台停止动作或开始动作</param>
        /// <param name="speed">云台控制的速度，用户按不同解码器的速度控制值设置。取值范围[1,160]</param>
        public void PTZControl(int channelId, HvPTZCommand ptzCommand, bool isStop, uint speed)
        {
            uint dwStop = 0;
            if (isStop)
                dwStop = 1;
            Invoke(NET_DVR_PTZControlWithSpeed_Other(session.UserId, channelId, (uint)ptzCommand, dwStop, speed));
        }

        /// <summary>
        /// 获取通道实时视频流的RTSP地址
        /// </summary>
        /// <param name="channel">通道</param>
        /// <param name="streamType">视频流类型</param>
        /// <returns></returns>
        public string GetLiveRtspUrl(HvChannel channel, HvStreamType streamType)
        {
            return GetLiveRtspUrl(channel,streamType, HvRtspPathFormat.Streaming);
        }

        /// <summary>
        /// 获取通道实时视频流的RTSP地址
        /// </summary>
        /// <param name="channel">通道</param>
        /// <param name="streamType">视频流类型</param>
        /// <param name="pathFormat">路径格式</param>
        /// <returns></returns>
        public string GetLiveRtspUrl(HvChannel channel, HvStreamType streamType, HvRtspPathFormat pathFormat)
        {
            UriBuilder uriBuilder = new UriBuilder();
            uriBuilder.Scheme = "rtsp";
            uriBuilder.Host = session.Host;
            uriBuilder.Port = rtspPort;
            uriBuilder.UserName = session.UserName;
            uriBuilder.Password = session.Password;
            switch (pathFormat)
            {
                case HvRtspPathFormat.AvStream:
                    uriBuilder.Path = $"/h264/ch{channel.RtspChannelId}/{streamType.ToString().ToLower()}/av_stream";
                    break;
                case HvRtspPathFormat.Streaming:
                    uriBuilder.Path = $"/Streaming/Channels/{channel.RtspChannelId}0{(int)streamType}";
                    break;
            }
            return uriBuilder.ToString();
        }

        private string dateTime2Str(DateTime dateTime)
        {
            return $"{dateTime.ToString("yyyyMMdd")}t{dateTime.ToString("HHmmss")}z";
        }

        /// <summary>
        /// 获取通道回放视频流的RTSP地址
        /// </summary>
        /// <param name="channel">通道</param>
        /// <param name="streamType">视频流类型</param>
        /// <param name="startTime">开始时间</param>
        /// <param name="endTime">结束时间</param>
        /// <returns></returns>
        public string GetPlaybackRtspUrl(HvChannel channel, HvStreamType streamType, DateTime startTime, DateTime endTime)
        {
            UriBuilder uriBuilder = new UriBuilder();
            uriBuilder.Scheme = "rtsp";
            uriBuilder.Host = session.Host;
            uriBuilder.Port = rtspPort;
            uriBuilder.UserName = session.UserName;
            uriBuilder.Password = session.Password;
            uriBuilder.Path = $"/Streaming/tracks/{channel.RtspChannelId}0{(int)streamType}";
            uriBuilder.Query = $"starttime={dateTime2Str(startTime)}&endtime={dateTime2Str(endTime)}";
            return uriBuilder.ToString();
        }

        /// <summary>
        /// 获取预置位数量
        /// </summary>
        /// <param name="channelId">通道号</param>
        /// <returns></returns>
        public int GetPresetCount(int channelId)
        {
            uint bytesReturned = 0;

            NET_DVR_PRESET_INFO presetInfo = new NET_DVR_PRESET_INFO();
            int size = Marshal.SizeOf(typeof(NET_DVR_PRESET_INFO));
            IntPtr presetInfoPtr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(presetInfo, presetInfoPtr, false);

            Invoke(NET_DVR_GetDVRConfig(session.UserId, NET_DVR_GET_PRESETCFG, channelId, presetInfoPtr, (uint)size, ref bytesReturned));
            presetInfo = Marshal.PtrToStructure<NET_DVR_PRESET_INFO>(presetInfoPtr);
            Console.WriteLine(presetInfo.dwPresetNum);
            return Convert.ToInt32(presetInfo.dwPresetNum);
        }

        /// <summary>
        /// 设置当前位置为特定预置位
        /// </summary>
        /// <param name="channelId">通道号</param>
        /// <param name="presetNumber">预置位编码</param>
        /// <returns></returns>
        public void SetPreset(int channelId, ushort presetNumber)
        {
            Invoke(NET_DVR_PTZPreset_Other(session.UserId, channelId, SET_PRESET, presetNumber));
        }

        /// <summary>
        /// 修改特定预置位的名称
        /// </summary>
        /// <param name="channelId">通道号</param>
        /// <param name="presetNumber">预置位编码</param>
        /// <param name="presetName">预置位名称</param>
        public void ModifyPresetName(int channelId, ushort presetNumber, string presetName)
        {
            if (string.IsNullOrWhiteSpace(presetName))
            {
                presetName = $"预置点 {presetNumber}";
            }

            NET_DVR_PRESET_NAME structure = new NET_DVR_PRESET_NAME();
            int nSize = Marshal.SizeOf(structure);
            var bytes = new byte[32];
            var src = session.Encoding.GetBytes(presetName);
            var length = bytes.Length <= 32 ? src.Length : 32;
            Array.Copy(src, bytes, length);
            structure.dwSize = (uint)nSize;
            structure.wPresetNum = presetNumber;
            structure.byName = bytes;

            IntPtr ptr = Marshal.AllocHGlobal(nSize);
            Marshal.StructureToPtr(structure, ptr, false);
            try
            {
                Invoke(NET_DVR_SetDVRConfig(session.UserId, NET_DVR_SET_PRESET_NAME, channelId, ptr, (uint)nSize));
            }
            catch
            {
                throw;
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }
        }

        /// <summary>
        /// 设置当前位置为特定预置位编号及指定名称
        /// </summary>
        /// <param name="channelId">通道号</param>
        /// <param name="presetNumber">预置位编码</param>
        /// <param name="presetName">预置位名称</param>
        /// <returns></returns>
        public void SetPresetWithName(int channelId, ushort presetNumber, string presetName)
        {
            SetPreset(channelId, presetNumber);
            ModifyPresetName(channelId, presetNumber, presetName);
        }

        /// <summary>
        /// 转动到指定预置位
        /// </summary>
        /// <param name="channelId">通道号</param>
        /// <param name="presetNumber">预置位编码</param>
        public void GotoPreset(int channelId, ushort presetNumber)
        {
            Invoke(NET_DVR_PTZPreset_Other(session.UserId, channelId, GOTO_PRESET, presetNumber));
        }

        /// <summary>
        /// 清除指定预置位
        /// </summary>
        /// <param name="channelId">通道号</param>
        /// <param name="presetNumber">预置位编码</param>
        public void RemovePreset(int channelId, ushort presetNumber)
        {
            Invoke(NET_DVR_PTZPreset_Other(session.UserId, channelId, CLE_PRESET, presetNumber));
        }

        /// <summary>
        /// 获取NVR通道的预置位信息
        /// </summary>
        /// <param name="channelId">通道号</param>
        /// <param name="presetCount">预置位数量，默认为255</param>
        /// <param name="containOnlyValidPreset">是否仅反馈有效的预置位，默认是 true</param>
        /// <returns></returns>
        public HvPreset[] GetPresets(int channelId, int presetCount = 255, bool containOnlyValidPreset = true)
        {
            if (presetCount <= 0)
            {
                return Array.Empty<HvPreset>();
            }

            uint bytesReturned = 0;
            var presets = new HvPreset[presetCount];
            var presetCfg = new NET_DVR_PRESET_NAME[presetCount];
            int nSize = Marshal.SizeOf(typeof(NET_DVR_PRESET_NAME));
            int nOutBufSize = nSize * presetCount;
            IntPtr ptrPreSetCfg = Marshal.AllocHGlobal(nOutBufSize);

            try
            {
                int i;
                for (i = 0; i < presetCount; i++)
                {
                    Marshal.StructureToPtr(presetCfg[i], ptrPreSetCfg, false);
                }

                //获取参数成功

                if (Invoke(NET_DVR_GetDVRConfig(
                    session.UserId,
                    NET_DVR_GET_PRESET_NAME,
                    channelId, ptrPreSetCfg,
                    (uint)nOutBufSize,
                    ref bytesReturned)))
                {
                    for (i = 0; i < presetCount; i++)
                    {
                        // 在每次循环中，通过计算当前结构体的指针位置，将 ptrPreSetCfg 移动到正确的位置。然后使用 Marshal.PtrToStructure 方法将指针转换为结构体
                        var ptrCurrent = IntPtr.Add(ptrPreSetCfg, i * nSize);
                        presetCfg[i] = Marshal.PtrToStructure<NET_DVR_PRESET_NAME>(ptrCurrent);
                        if (presetCfg[i].byName != null)
                        {
                            var presetName = StringUtils.ByteArray2String(presetCfg[i].byName, session.Encoding);
                            var preset = new HvPreset(presetCfg[i].wPresetNum, presetName);
                            preset.PanPos = ConvertPtzPos(presetCfg[i].wPanPos);
                            preset.TiltPos = ConvertPtzPos(presetCfg[i].wTiltPos);
                            preset.ZoomPos = ConvertPtzPos(presetCfg[i].wZoomPos);

                            presets[i] = preset;
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                Marshal.FreeHGlobal(ptrPreSetCfg);
            }
            return containOnlyValidPreset ? presets.Where(x => x.IsSet).ToArray() : presets;
        }

        /// <summary>
        /// 获取球机Ptz参数
        /// </summary>
        /// <param name="channelId">通道号</param>
        /// <returns></returns>
        public HvPtzPosition GetPtzPosition(int channelId)
        {
            uint bytesReturned = 0;
            NET_DVR_PTZPOS ptzPos = default;
            int nSize = Marshal.SizeOf(ptzPos);
            IntPtr ptrPicCfg = Marshal.AllocHGlobal(nSize);
            Marshal.StructureToPtr(ptzPos, ptrPicCfg, false);
            try
            {
                Invoke(NET_DVR_GetDVRConfig(session.UserId, NET_DVR_GET_PTZPOS, channelId, ptrPicCfg, (uint)nSize, ref bytesReturned));
                ptzPos = (NET_DVR_PTZPOS)Marshal.PtrToStructure(ptrPicCfg, typeof(NET_DVR_PTZPOS));

                var panPos = ConvertPtzPos(ptzPos.wPanPos);
                var tiltPos = ConvertPtzPos(ptzPos.wTiltPos);
                var zoomPos = ConvertPtzPos(ptzPos.wZoomPos);

                return new HvPtzPosition(panPos, tiltPos, zoomPos);
            }
            catch
            {
                throw;
            }
            finally
            {
                Marshal.FreeHGlobal(ptrPicCfg);
            }
        }

        /// <summary>
        /// 等待摄像机停止转动
        /// </summary>
        /// <param name="channelId">通道号</param>
        /// <returns></returns>
        public async Task WaitUntilStopMovingAsync(int channelId)
        {
            uint bytesReturned = 0;
            NET_DVR_PTZPOS structure = new NET_DVR_PTZPOS();
            int nSize = Marshal.SizeOf(structure);
            IntPtr ptrPicCfg = Marshal.AllocHGlobal(nSize);
            Marshal.StructureToPtr(structure, ptrPicCfg, false);

            try
            {
                bool result = NET_DVR_GetDVRConfig(session.UserId, NET_DVR_GET_PTZPOS, channelId, ptrPicCfg, (uint)nSize, ref bytesReturned);
                structure = (NET_DVR_PTZPOS)Marshal.PtrToStructure(ptrPicCfg, typeof(NET_DVR_PTZPOS));
                var panPos = structure.wPanPos;
                var tiltPos = structure.wTiltPos;
                var zoomPos = structure.wZoomPos;

                bool isMoving = true;
                while (isMoving)
                {
                    await Task.Delay(100);

                    result = NET_DVR_GetDVRConfig(session.UserId, NET_DVR_GET_PTZPOS, channelId, ptrPicCfg, (uint)nSize, ref bytesReturned);
                    if (result)
                    {
                        structure = (NET_DVR_PTZPOS)Marshal.PtrToStructure(ptrPicCfg, typeof(NET_DVR_PTZPOS));
                        //只要坐标没变就代表没动
                        if (structure.wPanPos == panPos && structure.wTiltPos == tiltPos && structure.wZoomPos == zoomPos)
                        {
                            isMoving = false;
                        }
                        else
                        {
                            //设置当前位置为最新位置
                            panPos = structure.wPanPos;
                            tiltPos = structure.wTiltPos;
                            zoomPos = structure.wZoomPos;
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                Marshal.FreeHGlobal(ptrPicCfg);
            }
        }

        /// <summary>
        /// 将PTZPOS参数转化为实际值
        /// </summary>
        /// <param name="ptzPos">参数</param>
        /// <returns></returns>
        private double ConvertPtzPos(ushort ptzPos)
        {
            var temp = (ptzPos / 4096) * 1000 + ((ptzPos % 4096) / 256) * 100 + ((ptzPos % 256) / 16) * 10 + (ptzPos % 16);
            var result = temp / 10d % 360;
            return result;
        }
    }
}
