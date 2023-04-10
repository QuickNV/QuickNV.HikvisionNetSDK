using System.ComponentModel;

namespace Hikvision.NetSDK
{
    public enum Errors
    {
        [Description("没有错误")]
        NET_DVR_NOERROR = 0,
        [Description("用户名密码错误")]
        NET_DVR_PASSWORD_ERROR = 1,
        [Description("权限不足")]
        NET_DVR_NOENOUGHPRI = 2,
        [Description("没有初始化")]
        NET_DVR_NOINIT = 3,
        [Description("通道号错误")]
        NET_DVR_CHANNEL_ERROR = 4,
        [Description("连接到DVR的客户端个数超过最大")]
        NET_DVR_OVER_MAXLINK = 5,
        [Description("版本不匹配")]
        NET_DVR_VERSIONNOMATCH = 6,
        [Description("连接服务器失败")]
        NET_DVR_NETWORK_FAIL_CONNECT = 7,
        [Description("向服务器发送失败")]
        NET_DVR_NETWORK_SEND_ERROR = 8,
        [Description("从服务器接收数据失败")]
        NET_DVR_NETWORK_RECV_ERROR = 9,
        [Description("从服务器接收数据超时")]
        NET_DVR_NETWORK_RECV_TIMEOUT = 10,
        [Description("传送的数据有误")]
        NET_DVR_NETWORK_ERRORDATA = 11,
        [Description("调用次序错误")]
        NET_DVR_ORDER_ERROR = 12,
        [Description("无此权限")]
        NET_DVR_OPERNOPERMIT = 13,
        [Description("DVR命令执行超时")]
        NET_DVR_COMMANDTIMEOUT = 14,
        [Description("串口号错误")]
        NET_DVR_ERRORSERIALPORT = 15,
        [Description("报警端口错误")]
        NET_DVR_ERRORALARMPORT = 16,
        [Description("参数错误")]
        NET_DVR_PARAMETER_ERROR = 17,
        [Description("服务器通道处于错误状态")]
        NET_DVR_CHAN_EXCEPTION = 18,
        [Description("没有硬盘")]
        NET_DVR_NODISK = 19,
        [Description("硬盘号错误")]
        NET_DVR_ERRORDISKNUM = 20,
        [Description("服务器硬盘满")]
        NET_DVR_DISK_FULL = 21,
        [Description("服务器硬盘出错")]
        NET_DVR_DISK_ERROR = 22,
        [Description("服务器不支持")]
        NET_DVR_NOSUPPORT = 23,
        [Description("服务器忙")]
        NET_DVR_BUSY = 24,
        [Description("服务器修改不成功")]
        NET_DVR_MODIFY_FAIL = 25,
        [Description("密码输入格式不正确")]
        NET_DVR_PASSWORD_FORMAT_ERROR = 26,
        [Description("硬盘正在格式化，不能启动操作")]
        NET_DVR_DISK_FORMATING = 27,
        [Description("DVR资源不足")]
        NET_DVR_DVRNORESOURCE = 28,
        [Description("DVR操作失败")]
        NET_DVR_DVROPRATEFAILED = 29,
        [Description("打开PC声音失败")]
        NET_DVR_OPENHOSTSOUND_FAIL = 30,
        [Description("服务器语音对讲被占用")]
        NET_DVR_DVRVOICEOPENED = 31,
        [Description("时间输入不正确")]
        NET_DVR_TIMEINPUTERROR = 32,
        [Description("回放时服务器没有指定的文件")]
        NET_DVR_NOSPECFILE = 33,
        [Description("创建文件出错")]
        NET_DVR_CREATEFILE_ERROR = 34,
        [Description("打开文件出错")]
        NET_DVR_FILEOPENFAIL = 35,
        [Description("获取当前播放的时间出错")]
        NET_DVR_GETPLAYTIMEFAIL = 37,
        [Description("播放出错")]
        NET_DVR_PLAYFAIL = 38,
        [Description("文件格式不正确")]
        NET_DVR_FILEFORMAT_ERROR = 39,
        [Description("路径错误")]
        NET_DVR_DIR_ERROR = 40,
        [Description("资源分配错误")]
        NET_DVR_ALLOC_RESOURCE_ERROR = 41,
        [Description("声卡模式错误")]
        NET_DVR_AUDIO_MODE_ERROR = 42,
        [Description("缓冲区太小")]
        NET_DVR_NOENOUGH_BUF = 43,
        [Description("创建SOCKET出错")]
        NET_DVR_CREATESOCKET_ERROR = 44,
        [Description("设置SOCKET出错")]
        NET_DVR_SETSOCKET_ERROR = 45,
        [Description("个数达到最大")]
        NET_DVR_MAX_NUM = 46,
        [Description("用户不存在")]
        NET_DVR_USERNOTEXIST = 47,
        [Description("写FLASH出错")]
        NET_DVR_WRITEFLASHERROR = 48,
        [Description("DVR升级失败")]
        NET_DVR_UPGRADEFAIL = 49,
        [Description("解码卡已经初始化过")]
        NET_DVR_CARDHAVEINIT = 50,
        [Description("调用播放库中某个函数失败")]
        NET_DVR_PLAYERFAILED = 51,
        [Description("设备端用户数达到最大")]
        NET_DVR_MAX_USERNUM = 52,
        [Description("获得客户端的IP地址或物理地址失败")]
        NET_DVR_GETLOCALIPANDMACFAIL = 53,
        [Description("该通道没有编码")]
        NET_DVR_NOENCODEING = 54,
        [Description("IP地址不匹配")]
        NET_DVR_IPMISMATCH = 55,
        [Description("MAC地址不匹配")]
        NET_DVR_MACMISMATCH = 56,
        [Description("升级文件语言不匹配")]
        NET_DVR_UPGRADELANGMISMATCH = 57,
        [Description("播放器路数达到最大")]
        NET_DVR_MAX_PLAYERPORT = 58,
        [Description("备份设备中没有足够空间进行备份")]
        NET_DVR_NOSPACEBACKUP = 59,
        [Description("没有找到指定的备份设备")]
        NET_DVR_NODEVICEBACKUP = 60,
        [Description("图像素位数不符，限24色")]
        NET_DVR_PICTURE_BITS_ERROR = 61,
        [Description("图片高*宽超限， 限128*256")]
        NET_DVR_PICTURE_DIMENSION_ERROR = 62,
        [Description("图片大小超限，限100K")]
        NET_DVR_PICTURE_SIZ_ERROR = 63,
        [Description("载入当前目录下Player Sdk出错")]
        NET_DVR_LOADPLAYERSDKFAILED = 64,
        [Description("找不到Player Sdk中某个函数入口")]
        NET_DVR_LOADPLAYERSDKPROC_ERROR = 65,
        [Description("载入当前目录下DSsdk出错")]
        NET_DVR_LOADDSSDKFAILED = 66,
        [Description("找不到DsSdk中某个函数入口")]
        NET_DVR_LOADDSSDKPROC_ERROR = 67,
        [Description("调用硬解码库DsSdk中某个函数失败")]
        NET_DVR_DSSDK_ERROR = 68,
        [Description("声卡被独占")]
        NET_DVR_VOICEMONOPOLIZE = 69,
        [Description("加入多播组失败")]
        NET_DVR_JOINMULTICASTFAILED = 70,
        [Description("建立日志文件目录失败")]
        NET_DVR_CREATEDIR_ERROR = 71,
        [Description("绑定套接字失败")]
        NET_DVR_BINDSOCKET_ERROR = 72,
        [Description("socket连接中断，此错误通常是由于连接中断或目的地不可达")]
        NET_DVR_SOCKETCLOSE_ERROR = 73,
        [Description("注销时用户ID正在进行某操作")]
        NET_DVR_USERID_ISUSING = 74,
        [Description("监听失败")]
        NET_DVR_SOCKETLISTEN_ERROR = 75,
        [Description("程序异常")]
        NET_DVR_PROGRAM_EXCEPTION = 76,
        [Description("写文件失败")]
        NET_DVR_WRITEFILE_FAILED = 77,
        [Description("禁止格式化只读硬盘")]
        NET_DVR_FORMAT_READONLY = 78,
        [Description("用户配置结构中存在相同的用户名")]
        NET_DVR_WITHSAMEUSERNAME = 79,
        [Description("导入参数时设备型号不匹配")]
        NET_DVR_DEVICETYPE_ERROR = 80,
        [Description("导入参数时语言不匹配")]
        NET_DVR_LANGUAGE_ERROR = 81,
        [Description("导入参数时软件版本不匹配")]
        NET_DVR_PARAVERSION_ERROR = 82,
        [Description("加载高清IPC通讯库StreamTransClient.dll失败")]
        NET_DVR_RTSP_SDK_ERROR = 84,
        [Description("加载转码库失败")]
        NET_DVR_CONVERT_SDK_ERROR = 85,
        [Description("超出最大的ip接入通道数")]
        NET_DVR_IPC_COUNT_OVERFLOW = 86,
        [Description("no error")]
        NET_PLAYM4_NOERROR = 500,
        [Description("input parameter is invalid")]
        NET_PLAYM4_PARA_OVER = 501,
        [Description("The order of the function to be called is error")]
        NET_PLAYM4_ORDER_ERROR = 502,
        [Description("Create multimedia clock failed")]
        NET_PLAYM4_TIMER_ERROR = 503,
        [Description("Decode video data failed")]
        NET_PLAYM4_DEC_VIDEO_ERROR = 504,
        [Description("Decode audio data failed")]
        NET_PLAYM4_DEC_AUDIO_ERROR = 505,
        [Description("Allocate memory failed")]
        NET_PLAYM4_ALLOC_MEMORY_ERROR = 506,
        [Description("Open the file failed")]
        NET_PLAYM4_OPEN_FILE_ERROR = 507,
        [Description("Create thread or event failed")]
        NET_PLAYM4_CREATE_OBJ_ERROR = 508,
        [Description("Create DirectDraw object failed")]
        NET_PLAYM4_CREATE_DDRAW_ERROR = 509,
        [Description("failed when creating off-screen surface")]
        NET_PLAYM4_CREATE_OFFSCREEN_ERROR = 510,
        [Description("buffer is overflow")]
        NET_PLAYM4_BUF_OVER = 511,
        [Description("failed when creating audio device")]
        NET_PLAYM4_CREATE_SOUND_ERROR = 512,
        [Description("Set volume failed")]
        NET_PLAYM4_SET_VOLUME_ERROR = 513,
        [Description("The function only support play file")]
        NET_PLAYM4_SUPPORT_FILE_ONLY = 514,
        [Description("The function only support play stream")]
        NET_PLAYM4_SUPPORT_STREAM_ONLY = 515,
        [Description("System not support")]
        NET_PLAYM4_SYS_NOT_SUPPORT = 516,
        [Description("No file header")]
        NET_PLAYM4_FILEHEADER_UNKNOWN = 517,
        [Description("The version of decoder and encoder is not adapted")]
        NET_PLAYM4_VERSION_INCORRECT = 518,
        [Description("Initialize decoder failed")]
        NET_PALYM4_INIT_DECODER_ERROR = 519,
        [Description("The file data is unknown")]
        NET_PLAYM4_CHECK_FILE_ERROR = 520,
        [Description("Initialize multimedia clock failed")]
        NET_PLAYM4_INIT_TIMER_ERROR = 521,
        [Description("Blt failed")]
        NET_PLAYM4_BLT_ERROR = 522,
        [Description("Update failed")]
        NET_PLAYM4_UPDATE_ERROR = 523,
        [Description("openfile error, streamtype is multi")]
        NET_PLAYM4_OPEN_FILE_ERROR_MULTI = 524,
        [Description("openfile error, streamtype is video")]
        NET_PLAYM4_OPEN_FILE_ERROR_VIDEO = 525,
        [Description("JPEG compress error")]
        NET_PLAYM4_JPEG_COMPRESS_ERROR = 526,
        [Description("Don't support the version of this file")]
        NET_PLAYM4_EXTRACT_NOT_SUPPORT = 527,
        [Description("extract video data failed")]
        NET_PLAYM4_EXTRACT_DATA_ERROR = 528
    }
}
