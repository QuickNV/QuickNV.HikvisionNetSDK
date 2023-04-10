using Hikvision.NetSDK.Api.Service;
using System;
using System.Collections.Generic;
using System.Text;
using static Hikvision.NetSDK.Defines;
using static Hikvision.NetSDK.Methods;

namespace Hikvision.NetSDK.Api
{
    public class HvSession
    {
        public int UserId { get; }
        public Encoding Encoding { get; }

        private NET_DVR_DEVICEINFO_V30 deviceInfo;
        private HvSession(int userId, Encoding encoding, NET_DVR_DEVICEINFO_V30 deviceInfo)
        {
            UserId = userId;
            Encoding = encoding;
            this.deviceInfo = deviceInfo;
        }

        public static void Init() => Invoke(NET_DVR_Init());
        public static bool SetConnectTime(uint waitTimeMilliseconds, uint tryTimes)
            => Invoke(NET_DVR_SetConnectTime(waitTimeMilliseconds, tryTimes)); // 2000 , 1
        public static bool SetReconnect(uint interval, int enableRecon)
            => Invoke(NET_DVR_SetReconnect(interval, enableRecon)); // 10000 , 1
        public static bool SetupLogs(HvLogLevel logLevel, string logDirectory, bool autoDelete)
            => Invoke(NET_DVR_SetLogToFile((int)logLevel, logDirectory, autoDelete));

        public static HvSession Login(string host, int port, string username, string password, Encoding encoding)
        {

            NET_DVR_DEVICEINFO_V30 deviceInfo = default;
            var userId = Invoke(NET_DVR_Login_V30(host, port, username, password, ref deviceInfo));
            return new HvSession(userId, encoding, deviceInfo);
        }
        public static HvSession Login(string host, int port, string username, string password)
        {
            return Login(host, port, username, password, Encoding.Default);
        }

        public static void Cleanup() => Invoke(NET_DVR_Cleanup());
        public void Logout() => Invoke(NET_DVR_Logout_V30(UserId));


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
    }
}
