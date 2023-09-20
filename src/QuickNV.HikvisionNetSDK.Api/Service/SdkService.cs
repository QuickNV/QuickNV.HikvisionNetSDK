using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using static QuickNV.HikvisionNetSDK.Defines;
using static QuickNV.HikvisionNetSDK.Methods;

namespace QuickNV.HikvisionNetSDK.Api.Service
{
    public class SdkService
    {
        private const int NET_SDK_LOCAL_CFG_TYPE_CHECK_DEV = 10;
        public bool SetConnectTime(uint waitTimeMilliseconds, uint tryTimes)
            => Invoke(NET_DVR_SetConnectTime(waitTimeMilliseconds, tryTimes)); // 2000 , 1
        public bool SetReconnect(uint interval, int enableRecon)
            => Invoke(NET_DVR_SetReconnect(interval, enableRecon)); // 10000 , 1
        public bool SetupLogs(HvLogLevel logLevel, string logDirectory, bool autoDelete)
            => Invoke(NET_DVR_SetLogToFile((int)logLevel, logDirectory, autoDelete));

        public NET_DVR_LOCAL_CHECK_DEV GetLocalCheckDev()
        {
            NET_DVR_LOCAL_CHECK_DEV config = default;
            var ptrSize = Marshal.SizeOf(config);
            IntPtr ptr = Marshal.AllocHGlobal(ptrSize);
            try
            {
                Invoke(NET_DVR_GetSDKLocalCfg(NET_SDK_LOCAL_CFG_TYPE_CHECK_DEV, ptr));
                config = Marshal.PtrToStructure<NET_DVR_LOCAL_CHECK_DEV>(ptr);
                return config;
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

        public void SetLocalCheckDev(NET_DVR_LOCAL_CHECK_DEV config)
        {
            IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(config));
            try
            {
                Marshal.StructureToPtr(config, ptr, false);
                Invoke(NET_DVR_SetSDKLocalCfg(NET_SDK_LOCAL_CFG_TYPE_CHECK_DEV, ptr));
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
    }
}
