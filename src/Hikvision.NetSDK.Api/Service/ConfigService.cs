using Hikvision.NetSDK.Api.Utils;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using static Hikvision.NetSDK.Defines;
using static Hikvision.NetSDK.Methods;

namespace Hikvision.NetSDK.Api.Service
{
    public class ConfigService
    {
        private HvSession session;
        internal ConfigService(HvSession session)
        {
            this.session = session;
        }

        public DateTime GetTime()
        {
            NET_DVR_TIME m_struTimeCfg = default;
            uint dwReturn = 0;
            int nSize = Marshal.SizeOf(m_struTimeCfg);
            IntPtr ptrTimeCfg = Marshal.AllocHGlobal(nSize);
            try
            {
                Marshal.StructureToPtr(m_struTimeCfg, ptrTimeCfg, false);
                Invoke(NET_DVR_GetDVRConfig(session.UserId, NET_DVR_GET_TIMECFG, 1, ptrTimeCfg, (uint)nSize, ref dwReturn));
                m_struTimeCfg = Marshal.PtrToStructure<NET_DVR_TIME>(ptrTimeCfg);
                return m_struTimeCfg.ToDateTime();
            }
            catch
            {
                throw;
            }
            finally
            {
                Marshal.FreeHGlobal(ptrTimeCfg);
            }
        }

        public void SetTime(DateTime dateTime)
        {
            NET_DVR_TIME m_struTimeCfg = dateTime.ToNET_DVR_TIME();
            int nSize = Marshal.SizeOf(m_struTimeCfg);
            IntPtr ptrTimeCfg = Marshal.AllocHGlobal(nSize);
            try
            {
                Marshal.StructureToPtr(m_struTimeCfg, ptrTimeCfg, false);
                Invoke(NET_DVR_SetDVRConfig(session.UserId, NET_DVR_SET_TIMECFG, -1, ptrTimeCfg, (uint)nSize));
            }
            catch
            {
                throw;
            }
            finally
            {
                Marshal.FreeHGlobal(ptrTimeCfg);
            }
        }

        public HvNetworkConfig GetNetworkConfig()
        {
            NET_DVR_NETCFG_V30 m_struNetCfg = default;
            uint dwReturn = 0;
            int nSize = Marshal.SizeOf(m_struNetCfg);
            IntPtr ptrNetCfg = Marshal.AllocHGlobal(nSize);
            try
            {
                Marshal.StructureToPtr(m_struNetCfg, ptrNetCfg, false);

                Invoke(NET_DVR_GetDVRConfig(session.UserId, NET_DVR_GET_NETCFG_V30, -1, ptrNetCfg, (uint)nSize, ref dwReturn));
                m_struNetCfg = Marshal.PtrToStructure<NET_DVR_NETCFG_V30>(ptrNetCfg);

                HvNetworkConfig networkConfig = new HvNetworkConfig
                {
                    IPAddress = StringUtils.ByteArray2String(m_struNetCfg.struEtherNet[0].struDVRIP.sIpV4, session.Encoding),
                    GateWay = StringUtils.ByteArray2String(m_struNetCfg.struGatewayIpAddr.sIpV4, session.Encoding),
                    SubMask = StringUtils.ByteArray2String(m_struNetCfg.struEtherNet[0].struDVRIPMask.sIpV4, session.Encoding),
                    Dns = StringUtils.ByteArray2String(m_struNetCfg.struDnsServer1IpAddr.sIpV4, session.Encoding),
                    HostIP = StringUtils.ByteArray2String(m_struNetCfg.struAlarmHostIpAddr.sIpV4, session.Encoding),
                    AlarmHostIpPort = Convert.ToInt32(m_struNetCfg.wAlarmHostIpPort),
                    HttpPort = Convert.ToInt32(m_struNetCfg.wHttpPortNo),
                    DVRPort = Convert.ToInt32(m_struNetCfg.struEtherNet[0].wDVRPort),
                    DHCP = m_struNetCfg.byUseDhcp == 1,
                    PPPoE = m_struNetCfg.struPPPoE.dwPPPOE == 1,
                    PPPoEName = StringUtils.ByteArray2String(m_struNetCfg.struPPPoE.sPPPoEUser, session.Encoding),
                    PPPoEPassword = m_struNetCfg.struPPPoE.sPPPoEPassword
                };
                return networkConfig;
            }
            catch
            {
                throw;
            }
            finally
            {
                Marshal.FreeHGlobal(ptrNetCfg);
            }
        }


        public HvDeviceConfig GetDeviceConfig()
        {
            NET_DVR_DEVICECFG_V40 m_struDeviceCfg = default;

            uint dwReturn = 0;
            int nSize = Marshal.SizeOf(m_struDeviceCfg);
            IntPtr ptrDeviceCfg = Marshal.AllocHGlobal(nSize);
            try
            {
                Marshal.StructureToPtr(m_struDeviceCfg, ptrDeviceCfg, false);

                Invoke(NET_DVR_GetDVRConfig(session.UserId, NET_DVR_GET_DEVICECFG_V40, -1, ptrDeviceCfg, (uint)nSize, ref dwReturn));

                m_struDeviceCfg = Marshal.PtrToStructure<NET_DVR_DEVICECFG_V40>(ptrDeviceCfg);

                uint iVer1 = (m_struDeviceCfg.dwSoftwareVersion >> 24) & 0xFF;
                uint iVer2 = (m_struDeviceCfg.dwSoftwareVersion >> 16) & 0xFF;
                uint iVer3 = m_struDeviceCfg.dwSoftwareVersion & 0xFFFF;
                uint iVer4 = (m_struDeviceCfg.dwSoftwareBuildDate >> 16) & 0xFFFF;
                uint iVer5 = (m_struDeviceCfg.dwSoftwareBuildDate >> 8) & 0xFF;
                uint iVer6 = m_struDeviceCfg.dwSoftwareBuildDate & 0xFF;

                var deviceConfig = new HvDeviceConfig
                {
                    Name = StringUtils.ByteArray2String(m_struDeviceCfg.sDVRName, session.Encoding),
                    TypeName = StringUtils.ByteArray2String(m_struDeviceCfg.byDevTypeName, session.Encoding),
                    AnalogChannel = Convert.ToInt32(m_struDeviceCfg.byChanNum),
                    IPChannel = Convert.ToInt32(m_struDeviceCfg.byIPChanNum + 256 * m_struDeviceCfg.byHighIPChanNum),
                    ZeroChannel = Convert.ToInt32(m_struDeviceCfg.byZeroChanNum),
                    NetworkPort = Convert.ToInt32(m_struDeviceCfg.byNetworkPortNum),
                    AlarmInPort = Convert.ToInt32(m_struDeviceCfg.byAlarmInPortNum),
                    AlarmOutPort = Convert.ToInt32(m_struDeviceCfg.byAlarmOutPortNum),
                    Serial = StringUtils.ByteArray2String(m_struDeviceCfg.sSerialNumber, session.Encoding),
                    Version = $"V{iVer1}.{iVer2}.{iVer3} Build {iVer4,0:D2}{iVer5,0:D2}{iVer6,0:D2}"
                };
                return deviceConfig;
            }
            catch
            {
                throw;
            }
            finally
            {
                Marshal.FreeHGlobal(ptrDeviceCfg);
            }
        }

        /// <summary>
        /// 获取第一块硬盘信息
        /// </summary>
        /// <returns></returns>
        public HvHdConfig GetHdConfig()
        {
            return GetHdConfigs().FirstOrDefault();
        }

        /// <summary>
        /// 获取全部硬盘信息
        /// </summary>
        /// <returns></returns>
        public HvHdConfig[] GetHdConfigs()
        {
            NET_DVR_HDCFG hdConfig = default;
            uint returned = 0;
            int sizeOfConfig = Marshal.SizeOf(hdConfig);
            IntPtr ptrDeviceCfg = Marshal.AllocHGlobal(sizeOfConfig);
            try
            {
                Marshal.StructureToPtr(hdConfig, ptrDeviceCfg, false);
                Invoke(NET_DVR_GetDVRConfig(
                    session.UserId,
                    NET_DVR_GET_HDCFG,
                    -1,
                    ptrDeviceCfg,
                    (uint)sizeOfConfig,
                    ref returned));

                hdConfig = Marshal.PtrToStructure<NET_DVR_HDCFG>(ptrDeviceCfg);
                var disks = hdConfig.struHDInfo
                    .Take((int)hdConfig.dwHDCount)
                    .Select(x => new HvHdConfig(x))
                    .ToArray();
                return disks;
            }
            catch
            {
                throw;
            }
            finally
            {
                Marshal.FreeHGlobal(ptrDeviceCfg);
            }
        }

        /// <summary>
        /// 获取RTSP端口
        /// </summary>
        /// <returns></returns>
        public int GetRtspPort()
        {
            NET_DVR_RTSPCFG rtspConfig = default;
            var ptrSize = Marshal.SizeOf(rtspConfig);
            NET_DVR_GetRtspConfig(session.UserId, 0, ref rtspConfig, (uint)ptrSize);
            return rtspConfig.wPort;
        }
    }
}
