using System;
using System.IO;
using static QuickNV.HikvisionNetSDK.Defines;
using static QuickNV.HikvisionNetSDK.Methods;

namespace QuickNV.HikvisionNetSDK.Api.Service
{
    /// <summary>
    /// 报警监听服务
    /// </summary>
    public class ListenAlarmService
    {
        private int? listenAlarmHandle;
        internal ListenAlarmService() { }

        /// <summary>
        /// 开始监听
        /// </summary>
        /// <param name="listenIpAddress">监听IP地址，传入null时监听全部IP地址</param>
        /// <param name="listenPort">监听端口，默认为7200</param>
        /// <param name="cbMessageCallback">报警消息回调</param>
        /// <exception cref="IOException"></exception>
        public void StartListen(string listenIpAddress, int listenPort, MSGCallBack cbMessageCallback)
        {
            if (listenAlarmHandle.HasValue)
                throw new IOException($"当前正在监听[句柄：{listenAlarmHandle}]，请停止监听后再试");
            //设置回调消息
            Invoke(NET_DVR_SetDVRMessageCallBack_V50(0, cbMessageCallback, IntPtr.Zero));
            //开始监听
            listenAlarmHandle = Invoke(NET_DVR_StartListen_V30(listenIpAddress, (ushort)listenPort, cbMessageCallback, IntPtr.Zero));
        }

        /// <summary>
        /// 停止监听
        /// </summary>
        /// <exception cref="IOException"></exception>
        public void StopListen()
        {
            if (listenAlarmHandle == null)
                throw new IOException($"当前没有监听，无法停止监听");
            //停止监听
            Invoke(NET_DVR_StopListen_V30(listenAlarmHandle.Value));
        }
    }
}