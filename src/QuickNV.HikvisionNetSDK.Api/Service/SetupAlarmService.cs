using System;
using System.IO;
using static QuickNV.HikvisionNetSDK.Defines;
using static QuickNV.HikvisionNetSDK.Methods;

namespace QuickNV.HikvisionNetSDK.Api.Service
{
    /// <summary>
    /// 报警布防服务
    /// </summary>
    public class SetupAlarmService
    {
        private HvSession session;
        private int? setupAlarmHandle;
        internal SetupAlarmService(HvSession session)
        {
            this.session = session;
        }

        /// <summary>
        /// 布防
        /// </summary>
        /// <param name="struSetupParam">布防参数</param>
        /// <param name="cbMessageCallback">报警消息回调</param>
        /// <exception cref="IOException"></exception>
        public void SetupAlarm(NET_DVR_SETUPALARM_PARAM struSetupParam, MSGCallBack cbMessageCallback)
        {
            if (setupAlarmHandle.HasValue)
                throw new IOException($"当前已经布防[句柄：{setupAlarmHandle}]，请撤销此布防后再试");
            //设置回调消息
            Invoke(NET_DVR_SetDVRMessageCallBack_V50(0, cbMessageCallback, IntPtr.Zero));
            //布防
            setupAlarmHandle = Invoke(NET_DVR_SetupAlarmChan_V41(session.UserId, ref struSetupParam));
        }

        /// <summary>
        /// 撤销布防
        /// </summary>
        public void CloseAlarm()
        {
            if (setupAlarmHandle == null)
                throw new IOException($"当前没有布防，无法撤销布防");
            //撤销布防上传通道
            Invoke(NET_DVR_CloseAlarmChan_V30(setupAlarmHandle.Value));
        }
    }
}