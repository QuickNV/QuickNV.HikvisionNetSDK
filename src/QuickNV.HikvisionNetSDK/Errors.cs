using System.ComponentModel;

namespace QuickNV.HikvisionNetSDK
{
    /// <summary>
    /// 海康SDK错误代码枚举
    /// </summary>
    public enum Errors
    {
        /// <summary>
        /// 没有错误
        /// </summary>
        [Description("没有错误")]
        NET_DVR_NOERROR = 0,
        /// <summary>
        /// 用户名密码错误
        /// </summary>
        [Description("用户名密码错误")]
        NET_DVR_PASSWORD_ERROR = 1,
        /// <summary>
        /// 权限不足
        /// </summary>
        [Description("权限不足")]
        NET_DVR_NOENOUGHPRI = 2,
        /// <summary>
        /// 没有初始化
        /// </summary>
        [Description("没有初始化")]
        NET_DVR_NOINIT = 3,
        /// <summary>
        /// 通道号错误
        /// </summary>
        [Description("通道号错误")]
        NET_DVR_CHANNEL_ERROR = 4,
        /// <summary>
        /// 连接到DVR的客户端个数超过最大
        /// </summary>
        [Description("连接到DVR的客户端个数超过最大")]
        NET_DVR_OVER_MAXLINK = 5,
        /// <summary>
        /// 版本不匹配
        /// </summary>
        [Description("版本不匹配")]
        NET_DVR_VERSIONNOMATCH = 6,
        /// <summary>
        /// 连接服务器失败
        /// </summary>
        [Description("连接服务器失败")]
        NET_DVR_NETWORK_FAIL_CONNECT = 7,
        /// <summary>
        /// 向服务器发送失败
        /// </summary>
        [Description("向服务器发送失败")]
        NET_DVR_NETWORK_SEND_ERROR = 8,
        /// <summary>
        /// 从服务器接收数据失败
        /// </summary>
        [Description("从服务器接收数据失败")]
        NET_DVR_NETWORK_RECV_ERROR = 9,
        /// <summary>
        /// 从服务器接收数据超时
        /// </summary>
        [Description("从服务器接收数据超时")]
        NET_DVR_NETWORK_RECV_TIMEOUT = 10,
        /// <summary>
        /// 传送的数据有误
        /// </summary>
        [Description("传送的数据有误")]
        NET_DVR_NETWORK_ERRORDATA = 11,
        /// <summary>
        /// 调用次序错误
        /// </summary>
        [Description("调用次序错误")]
        NET_DVR_ORDER_ERROR = 12,
        /// <summary>
        /// 无此权限
        /// </summary>
        [Description("无此权限")]
        NET_DVR_OPERNOPERMIT = 13,
        /// <summary>
        /// DVR命令执行超时
        /// </summary>
        [Description("DVR命令执行超时")]
        NET_DVR_COMMANDTIMEOUT = 14,
        /// <summary>
        /// 串口号错误
        /// </summary>
        [Description("串口号错误")]
        NET_DVR_ERRORSERIALPORT = 15,
        /// <summary>
        /// 报警端口错误
        /// </summary>
        [Description("报警端口错误")]
        NET_DVR_ERRORALARMPORT = 16,
        /// <summary>
        /// 参数错误
        /// </summary>
        [Description("参数错误")]
        NET_DVR_PARAMETER_ERROR = 17,
        /// <summary>
        /// 服务器通道处于错误状态
        /// </summary>
        [Description("服务器通道处于错误状态")]
        NET_DVR_CHAN_EXCEPTION = 18,
        /// <summary>
        /// 没有硬盘
        /// </summary>
        [Description("没有硬盘")]
        NET_DVR_NODISK = 19,
        /// <summary>
        /// 硬盘号错误
        /// </summary>
        [Description("硬盘号错误")]
        NET_DVR_ERRORDISKNUM = 20,
        /// <summary>
        /// 服务器硬盘满
        /// </summary>
        [Description("服务器硬盘满")]
        NET_DVR_DISK_FULL = 21,
        /// <summary>
        /// 服务器硬盘出错
        /// </summary>
        [Description("服务器硬盘出错")]
        NET_DVR_DISK_ERROR = 22,
        /// <summary>
        /// 服务器不支持
        /// </summary>
        [Description("服务器不支持")]
        NET_DVR_NOSUPPORT = 23,
        /// <summary>
        /// 服务器忙
        /// </summary>
        [Description("服务器忙")]
        NET_DVR_BUSY = 24,
        /// <summary>
        /// 服务器修改不成功
        /// </summary>
        [Description("服务器修改不成功")]
        NET_DVR_MODIFY_FAIL = 25,
        /// <summary>
        /// 密码输入格式不正确
        /// </summary>
        [Description("密码输入格式不正确")]
        NET_DVR_PASSWORD_FORMAT_ERROR = 26,
        /// <summary>
        /// 硬盘正在格式化，不能启动操作
        /// </summary>
        [Description("硬盘正在格式化，不能启动操作")]
        NET_DVR_DISK_FORMATING = 27,
        /// <summary>
        /// DVR资源不足
        /// </summary>
        [Description("DVR资源不足")]
        NET_DVR_DVRNORESOURCE = 28,
        /// <summary>
        /// DVR操作失败
        /// </summary>
        [Description("DVR操作失败")]
        NET_DVR_DVROPRATEFAILED = 29,
        /// <summary>
        /// 打开PC声音失败
        /// </summary>
        [Description("打开PC声音失败")]
        NET_DVR_OPENHOSTSOUND_FAIL = 30,
        /// <summary>
        /// 服务器语音对讲被占用
        /// </summary>
        [Description("服务器语音对讲被占用")]
        NET_DVR_DVRVOICEOPENED = 31,
        /// <summary>
        /// 时间输入不正确
        /// </summary>
        [Description("时间输入不正确")]
        NET_DVR_TIMEINPUTERROR = 32,
        /// <summary>
        /// 回放时服务器没有指定的文件
        /// </summary>
        [Description("回放时服务器没有指定的文件")]
        NET_DVR_NOSPECFILE = 33,
        /// <summary>
        /// 创建文件出错
        /// </summary>
        [Description("创建文件出错")]
        NET_DVR_CREATEFILE_ERROR = 34,
        /// <summary>
        /// 打开文件出错
        /// </summary>
        [Description("打开文件出错")]
        NET_DVR_FILEOPENFAIL = 35,
        /// <summary>
        /// 上次的操作还没有完成
        /// </summary>
        [Description("上次的操作还没有完成")]
        NET_DVR_OPERNOTFINISH = 36,
        /// <summary>
        /// 获取当前播放的时间出错
        /// </summary>
        [Description("获取当前播放的时间出错")]
        NET_DVR_GETPLAYTIMEFAIL = 37,
        /// <summary>
        /// 播放出错
        /// </summary>
        [Description("播放出错")]
        NET_DVR_PLAYFAIL = 38,
        /// <summary>
        /// 文件格式不正确
        /// </summary>
        [Description("文件格式不正确")]
        NET_DVR_FILEFORMAT_ERROR = 39,
        /// <summary>
        /// 路径错误
        /// </summary>
        [Description("路径错误")]
        NET_DVR_DIR_ERROR = 40,
        /// <summary>
        /// 资源分配错误
        /// </summary>
        [Description("资源分配错误")]
        NET_DVR_ALLOC_RESOURCE_ERROR = 41,
        /// <summary>
        /// 声卡模式错误
        /// </summary>
        [Description("声卡模式错误")]
        NET_DVR_AUDIO_MODE_ERROR = 42,
        /// <summary>
        /// 缓冲区太小
        /// </summary>
        [Description("缓冲区太小")]
        NET_DVR_NOENOUGH_BUF = 43,
        /// <summary>
        /// 创建SOCKET出错
        /// </summary>
        [Description("创建SOCKET出错")]
        NET_DVR_CREATESOCKET_ERROR = 44,
        /// <summary>
        /// 设置SOCKET出错
        /// </summary>
        [Description("设置SOCKET出错")]
        NET_DVR_SETSOCKET_ERROR = 45,
        /// <summary>
        /// 个数达到最大
        /// </summary>
        [Description("个数达到最大")]
        NET_DVR_MAX_NUM = 46,
        /// <summary>
        /// 用户不存在
        /// </summary>
        [Description("用户不存在")]
        NET_DVR_USERNOTEXIST = 47,
        /// <summary>
        /// 写FLASH出错
        /// </summary>
        [Description("写FLASH出错")]
        NET_DVR_WRITEFLASHERROR = 48,
        /// <summary>
        /// DVR升级失败
        /// </summary>
        [Description("DVR升级失败")]
        NET_DVR_UPGRADEFAIL = 49,
        /// <summary>
        /// 解码卡已经初始化过
        /// </summary>
        [Description("解码卡已经初始化过")]
        NET_DVR_CARDHAVEINIT = 50,
        /// <summary>
        /// 调用播放库中某个函数失败
        /// </summary>
        [Description("调用播放库中某个函数失败")]
        NET_DVR_PLAYERFAILED = 51,
        /// <summary>
        /// 设备端用户数达到最大
        /// </summary>
        [Description("设备端用户数达到最大")]
        NET_DVR_MAX_USERNUM = 52,
        /// <summary>
        /// 获得客户端的IP地址或物理地址失败
        /// </summary>
        [Description("获得客户端的IP地址或物理地址失败")]
        NET_DVR_GETLOCALIPANDMACFAIL = 53,
        /// <summary>
        /// 该通道没有编码
        /// </summary>
        [Description("该通道没有编码")]
        NET_DVR_NOENCODEING = 54,
        /// <summary>
        /// IP地址不匹配
        /// </summary>
        [Description("IP地址不匹配")]
        NET_DVR_IPMISMATCH = 55,
        /// <summary>
        /// MAC地址不匹配
        /// </summary>
        [Description("MAC地址不匹配")]
        NET_DVR_MACMISMATCH = 56,
        /// <summary>
        /// 升级文件语言不匹配
        /// </summary>
        [Description("升级文件语言不匹配")]
        NET_DVR_UPGRADELANGMISMATCH = 57,
        /// <summary>
        /// 播放器路数达到最大
        /// </summary>
        [Description("播放器路数达到最大")]
        NET_DVR_MAX_PLAYERPORT = 58,
        /// <summary>
        /// 备份设备中没有足够空间进行备份
        /// </summary>
        [Description("备份设备中没有足够空间进行备份")]
        NET_DVR_NOSPACEBACKUP = 59,
        /// <summary>
        /// 没有找到指定的备份设备
        /// </summary>
        [Description("没有找到指定的备份设备")]
        NET_DVR_NODEVICEBACKUP = 60,
        /// <summary>
        /// 图像素位数不符，限24色
        /// </summary>
        [Description("图像素位数不符，限24色")]
        NET_DVR_PICTURE_BITS_ERROR = 61,
        /// <summary>
        /// 图片高*宽超限， 限128*256
        /// </summary>
        [Description("图片高*宽超限， 限128*256")]
        NET_DVR_PICTURE_DIMENSION_ERROR = 62,
        /// <summary>
        /// 图片大小超限，限100K
        /// </summary>
        [Description("图片大小超限，限100K")]
        NET_DVR_PICTURE_SIZ_ERROR = 63,
        /// <summary>
        /// 载入当前目录下Player Sdk出错
        /// </summary>
        [Description("载入当前目录下Player Sdk出错")]
        NET_DVR_LOADPLAYERSDKFAILED = 64,
        /// <summary>
        /// 找不到Player Sdk中某个函数入口
        /// </summary>
        [Description("找不到Player Sdk中某个函数入口")]
        NET_DVR_LOADPLAYERSDKPROC_ERROR = 65,
        /// <summary>
        /// 载入当前目录下DSsdk出错
        /// </summary>
        [Description("载入当前目录下DSsdk出错")]
        NET_DVR_LOADDSSDKFAILED = 66,
        /// <summary>
        /// 找不到DsSdk中某个函数入口
        /// </summary>
        [Description("找不到DsSdk中某个函数入口")]
        NET_DVR_LOADDSSDKPROC_ERROR = 67,
        /// <summary>
        /// 调用硬解码库DsSdk中某个函数失败
        /// </summary>
        [Description("调用硬解码库DsSdk中某个函数失败")]
        NET_DVR_DSSDK_ERROR = 68,
        /// <summary>
        /// 声卡被独占
        /// </summary>
        [Description("声卡被独占")]
        NET_DVR_VOICEMONOPOLIZE = 69,
        /// <summary>
        /// 加入多播组失败
        /// </summary>
        [Description("加入多播组失败")]
        NET_DVR_JOINMULTICASTFAILED = 70,
        /// <summary>
        /// 建立日志文件目录失败
        /// </summary>
        [Description("建立日志文件目录失败")]
        NET_DVR_CREATEDIR_ERROR = 71,
        /// <summary>
        /// 绑定套接字失败
        /// </summary>
        [Description("绑定套接字失败")]
        NET_DVR_BINDSOCKET_ERROR = 72,
        /// <summary>
        /// socket连接中断，此错误通常是由于连接中断或目的地不可达
        /// </summary>
        [Description("socket连接中断，此错误通常是由于连接中断或目的地不可达")]
        NET_DVR_SOCKETCLOSE_ERROR = 73,
        /// <summary>
        /// 注销时用户ID正在进行某操作
        /// </summary>
        [Description("注销时用户ID正在进行某操作")]
        NET_DVR_USERID_ISUSING = 74,
        /// <summary>
        /// 监听失败
        /// </summary>
        [Description("监听失败")]
        NET_DVR_SOCKETLISTEN_ERROR = 75,
        /// <summary>
        /// 程序异常
        /// </summary>
        [Description("程序异常")]
        NET_DVR_PROGRAM_EXCEPTION = 76,
        /// <summary>
        /// 写文件失败
        /// </summary>
        [Description("写文件失败")]
        NET_DVR_WRITEFILE_FAILED = 77,
        /// <summary>
        /// 禁止格式化只读硬盘
        /// </summary>
        [Description("禁止格式化只读硬盘")]
        NET_DVR_FORMAT_READONLY = 78,
        /// <summary>
        /// 用户配置结构中存在相同的用户名
        /// </summary>
        [Description("用户配置结构中存在相同的用户名")]
        NET_DVR_WITHSAMEUSERNAME = 79,
        /// <summary>
        /// 导入参数时设备型号不匹配
        /// </summary>
        [Description("导入参数时设备型号不匹配")]
        NET_DVR_DEVICETYPE_ERROR = 80,
        /// <summary>
        /// 导入参数时语言不匹配
        /// </summary>
        [Description("导入参数时语言不匹配")]
        NET_DVR_LANGUAGE_ERROR = 81,
        /// <summary>
        /// 导入参数时软件版本不匹配
        /// </summary>
        [Description("导入参数时软件版本不匹配")]
        NET_DVR_PARAVERSION_ERROR = 82,
        /// <summary>
        /// 预览时外接IP通道不在线
        /// </summary>
        [Description("预览时外接IP通道不在线")]
        NET_DVR_IPCHAN_NOTALIVE = 83,
        /// <summary>
        /// 加载高清IPC通讯库StreamTransClient.dll失败
        /// </summary>
        [Description("加载高清IPC通讯库StreamTransClient.dll失败")]
        NET_DVR_RTSP_SDK_ERROR = 84,
        /// <summary>
        /// 加载转码库失败
        /// </summary>
        [Description("加载转码库失败")]
        NET_DVR_CONVERT_SDK_ERROR = 85,
        /// <summary>
        /// 超出最大的ip接入通道数
        /// </summary>
        [Description("超出最大的ip接入通道数")]
        NET_DVR_IPC_COUNT_OVERFLOW = 86,
        [Description("")]
        NET_DVR_USER_LOCKED = 153,
        /// <summary>
        /// no error
        /// </summary>
        [Description("no error")]
        NET_PLAYM4_NOERROR = 500,
        /// <summary>
        /// input parameter is invalid
        /// </summary>
        [Description("input parameter is invalid")]
        NET_PLAYM4_PARA_OVER = 501,
        /// <summary>
        /// The order of the function to be called is error
        /// </summary>
        [Description("The order of the function to be called is error")]
        NET_PLAYM4_ORDER_ERROR = 502,
        /// <summary>
        /// Create multimedia clock failed
        /// </summary>
        [Description("Create multimedia clock failed")]
        NET_PLAYM4_TIMER_ERROR = 503,
        /// <summary>
        /// Decode video data failed
        /// </summary>
        [Description("Decode video data failed")]
        NET_PLAYM4_DEC_VIDEO_ERROR = 504,
        /// <summary>
        /// Decode audio data failed
        /// </summary>
        [Description("Decode audio data failed")]
        NET_PLAYM4_DEC_AUDIO_ERROR = 505,
        /// <summary>
        /// Allocate memory failed
        /// </summary>
        [Description("Allocate memory failed")]
        NET_PLAYM4_ALLOC_MEMORY_ERROR = 506,
        /// <summary>
        /// Open the file failed
        /// </summary>
        [Description("Open the file failed")]
        NET_PLAYM4_OPEN_FILE_ERROR = 507,
        /// <summary>
        /// Create thread or event failed
        /// </summary>
        [Description("Create thread or event failed")]
        NET_PLAYM4_CREATE_OBJ_ERROR = 508,
        /// <summary>
        /// Create DirectDraw object failed
        /// </summary>
        [Description("Create DirectDraw object failed")]
        NET_PLAYM4_CREATE_DDRAW_ERROR = 509,
        /// <summary>
        /// failed when creating off-screen surface
        /// </summary>
        [Description("failed when creating off-screen surface")]
        NET_PLAYM4_CREATE_OFFSCREEN_ERROR = 510,
        /// <summary>
        /// buffer is overflow
        /// </summary>
        [Description("buffer is overflow")]
        NET_PLAYM4_BUF_OVER = 511,
        /// <summary>
        /// failed when creating audio device
        /// </summary>
        [Description("failed when creating audio device")]
        NET_PLAYM4_CREATE_SOUND_ERROR = 512,
        /// <summary>
        /// Set volume failed
        /// </summary>
        [Description("Set volume failed")]
        NET_PLAYM4_SET_VOLUME_ERROR = 513,
        /// <summary>
        /// The function only support play file
        /// </summary>
        [Description("The function only support play file")]
        NET_PLAYM4_SUPPORT_FILE_ONLY = 514,
        /// <summary>
        /// The function only support play stream
        /// </summary>
        [Description("The function only support play stream")]
        NET_PLAYM4_SUPPORT_STREAM_ONLY = 515,
        /// <summary>
        /// System not support
        /// </summary>
        [Description("System not support")]
        NET_PLAYM4_SYS_NOT_SUPPORT = 516,
        /// <summary>
        /// No file header
        /// </summary>
        [Description("No file header")]
        NET_PLAYM4_FILEHEADER_UNKNOWN = 517,
        /// <summary>
        /// The version of decoder and encoder is not adapted
        /// </summary>
        [Description("The version of decoder and encoder is not adapted")]
        NET_PLAYM4_VERSION_INCORRECT = 518,
        /// <summary>
        /// Initialize decoder failed
        /// </summary>
        [Description("Initialize decoder failed")]
        NET_PALYM4_INIT_DECODER_ERROR = 519,
        /// <summary>
        /// The file data is unknown
        /// </summary>
        [Description("The file data is unknown")]
        NET_PLAYM4_CHECK_FILE_ERROR = 520,
        /// <summary>
        /// Initialize multimedia clock failed
        /// </summary>
        [Description("Initialize multimedia clock failed")]
        NET_PLAYM4_INIT_TIMER_ERROR = 521,
        /// <summary>
        /// Blt failed
        /// </summary>
        [Description("Blt failed")]
        NET_PLAYM4_BLT_ERROR = 522,
        /// <summary>
        /// Update failed
        /// </summary>
        [Description("Update failed")]
        NET_PLAYM4_UPDATE_ERROR = 523,
        /// <summary>
        /// openfile error, streamtype is multi
        /// </summary>
        [Description("openfile error, streamtype is multi")]
        NET_PLAYM4_OPEN_FILE_ERROR_MULTI = 524,
        /// <summary>
        /// openfile error, streamtype is video
        /// </summary>
        [Description("openfile error, streamtype is video")]
        NET_PLAYM4_OPEN_FILE_ERROR_VIDEO = 525,
        /// <summary>
        /// JPEG compress error
        /// </summary>
        [Description("JPEG compress error")]
        NET_PLAYM4_JPEG_COMPRESS_ERROR = 526,
        /// <summary>
        /// Don't support the version of this file
        /// </summary>
        [Description("Don't support the version of this file")]
        NET_PLAYM4_EXTRACT_NOT_SUPPORT = 527,
        /// <summary>
        /// extract video data failed
        /// </summary>
        [Description("extract video data failed")]
        NET_PLAYM4_EXTRACT_DATA_ERROR = 528
    }
}
