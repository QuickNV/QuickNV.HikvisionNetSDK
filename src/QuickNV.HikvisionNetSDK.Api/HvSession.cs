using QuickNV.HikvisionNetSDK.Api.Service;
using System;
using System.Text;
using static QuickNV.HikvisionNetSDK.Defines;
using static QuickNV.HikvisionNetSDK.Methods;

namespace QuickNV.HikvisionNetSDK.Api
{
    public class HvSession : IDisposable
    {
        private static SdkService _SdkService;
        public static SdkService SdkService
        {
            get
            {
                if (_SdkService == null)
                {
                    _SdkService = new SdkService();
                }
                return _SdkService;
            }
        }

        public static void Init()
        {
            Invoke(NET_DVR_Init());
        }

        /// <summary>
        /// 设置报警布防的消息回调。多台设备对接时也只需要调用一次设置一个回调函数，不支持不同设备的事件在不同的回调函数里面返回
        /// </summary>
        /// <param name="cbMessageCallback">回调函数</param>
        /// <param name="iIndex">回调函数索引，取值范围：[0,15]</param>
        public static void SetMessageCallBack(MSGCallBack cbMessageCallback, int iIndex = 0)
        {
            //设置回调消息
            Invoke(NET_DVR_SetDVRMessageCallBack_V50(iIndex, cbMessageCallback, IntPtr.Zero));
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="host"></param>
        /// <param name="port"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static HvSession Login(string host, int port, string username, string password, Encoding encoding)
        {
            NET_DVR_DEVICEINFO_V30 deviceInfo = default;
            var userId = Invoke(NET_DVR_Login_V30(host, port, username, password, ref deviceInfo));
            var session = new HvSession(userId, encoding, deviceInfo)
            {
                Host = host,
                Port = port,
                UserName = username,
                Password = password
            };
            return session;
        }
        public static HvSession Login(string host, int port, string username, string password)
        {
            return Login(host, port, username, password, Encoding.Default);
        }
        public static void Cleanup() => Invoke(NET_DVR_Cleanup());

        public string Host { get; private set; }
        public int Port { get; private set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public int UserId { get; private set; }
        public bool IsOnline { get; private set; } = true;
        public Encoding Encoding { get; }
        private NET_DVR_DEVICEINFO_V30 deviceInfo;

        private HvSession(int userId, Encoding encoding, NET_DVR_DEVICEINFO_V30 deviceInfo)
        {
            UserId = userId;
            Encoding = encoding;
            this.deviceInfo = deviceInfo;
        }

        public void Logout()
        {
            if (!IsOnline)
                return;
            IsOnline = false;
            Invoke(NET_DVR_Logout_V30(UserId));
        }

        public void Dispose()
        {
            Logout();
        }

        private ChannelService _ChannelService;
        public ChannelService ChannelService
        {
            get
            {
                if (_ChannelService == null)
                    _ChannelService = new ChannelService(this, deviceInfo);
                return _ChannelService;
            }
        }

        private ConfigService _ConfigService;
        public ConfigService ConfigService
        {
            get
            {
                if (_ConfigService == null)
                    _ConfigService = new ConfigService(this);
                return _ConfigService;
            }
        }

        private PictureService _PictureService;
        public PictureService PictureService
        {
            get
            {
                if (_PictureService == null)
                    _PictureService = new PictureService(this);
                return _PictureService;
            }
        }

        private VideoFileService _VideoFileService;
        public VideoFileService VideoFileService
        {
            get
            {
                if (_VideoFileService == null)
                    _VideoFileService = new VideoFileService(this);
                return _VideoFileService;
            }
        }

        private SetupAlarmService _SetupAlarmService;
        /// <summary>
        /// 报警布防服务
        /// </summary>
        public SetupAlarmService SetupAlarmService
        {
            get
            {
                if (_SetupAlarmService == null)
                    _SetupAlarmService = new SetupAlarmService(this);
                return _SetupAlarmService;
            }
        }

        private static ListenAlarmService _ListenAlarmService;
        /// <summary>
        /// 报警监听服务
        /// </summary>
        public static ListenAlarmService ListenAlarmService
        {
            get
            {
                if (_ListenAlarmService == null)
                    _ListenAlarmService = new ListenAlarmService();
                return _ListenAlarmService;
            }
        }
    }
}
