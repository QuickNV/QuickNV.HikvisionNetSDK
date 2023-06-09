using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using static Hikvision.NetSDK.Defines;
using static Hikvision.NetSDK.Methods;

namespace Hikvision.NetSDK.Api.Service
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
                    struIpParaCfgV40 = (NET_DVR_IPPARACFG_V40)Marshal.PtrToStructure(
                        ptrIpParaCfgV40,
                        typeof(NET_DVR_IPPARACFG_V40));

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
                                var struChanInfo = (NET_DVR_IPCHANINFO)Marshal.PtrToStructure(
                                    ptrChanInfo,
                                    typeof(NET_DVR_IPCHANINFO));
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
                channel.Name = session.Encoding.GetString(config.sChanName).Trim('\0');
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

        public void PTZControl(int channelId, HvPTZCommand ptzCommand, bool isStop, uint speed)
        {
            uint dwStop = 0;
            if (isStop)
                dwStop = 1;
            Invoke(NET_DVR_PTZControlWithSpeed_Other(session.UserId, channelId, (uint)ptzCommand, dwStop, speed));
        }

        public string GetRtspUrl(HvChannel channel, HvStreamType streamType)
        {
            UriBuilder uriBuilder = new UriBuilder();
            uriBuilder.Scheme = "rtsp";
            uriBuilder.Host = session.Host;
            uriBuilder.Port = rtspPort;
            uriBuilder.UserName = session.UserName;
            uriBuilder.Password = session.Password;
            uriBuilder.Path = $"/Streaming/Channels/{channel.RtspChannelId}0{(int)streamType}";
            return uriBuilder.ToString();
        }
    }
}
