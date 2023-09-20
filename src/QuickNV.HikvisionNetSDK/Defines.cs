using System;
using System.Runtime.InteropServices;
namespace QuickNV.HikvisionNetSDK
{
	/// <summary>
	/// CHCNetSDK 的摘要说明。
	/// </summary>
    public class Defines
    {
        public Defines()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        
        //SDK类型
        public const int SDK_PLAYMPEG4 = 1;//播放库
        public const int SDK_HCNETSDK = 2;//网络库

        public const int NAME_LEN = 32;//用户名长度
        public const int PASSWD_LEN = 16;//密码长度
        public const int GUID_LEN = 16;      //GUID长度
        public const int DEV_TYPE_NAME_LEN = 24;      //设备类型名称长度
        public const int MAX_NAMELEN = 16;//DVR本地登陆名
        public const int MAX_RIGHT = 32;//设备支持的权限（1-12表示本地权限，13-32表示远程权限）
        public const int SERIALNO_LEN = 48;//序列号长度
        public const int MACADDR_LEN = 6;//mac地址长度
        public const int MAX_ETHERNET = 2;//设备可配以太网络
        public const int MAX_NETWORK_CARD = 4; //设备可配最大网卡数目
        public const int PATHNAME_LEN = 128;//路径长度

        public const int MAX_NUMBER_LEN = 32;	//号码最大长度
        public const int MAX_NAME_LEN = 128; //设备名称最大长度


        public const int MAX_TIMESEGMENT = 4;//8000设备最大时间段数
        public const int MAX_ICR_NUM = 8;   //抓拍机红外滤光片预置点数

        public const int MAX_SHELTERNUM = 4;//8000设备最大遮挡区域数
        public const int PHONENUMBER_LEN = 32;//pppoe拨号号码最大长度

        public const int MAX_DISKNUM = 16;//8000设备最大硬盘数
        public const int MAX_DISKNUM_V10 = 8;//1.2版本之前版本

        public const int MAX_WINDOW_V30 = 32;//9000设备本地显示最大播放窗口数
        public const int MAX_WINDOW = 16;//8000设备最大硬盘数
        public const int MAX_VGA_V30 = 4;//9000设备最大可接VGA数
        public const int MAX_VGA = 1;//8000设备最大可接VGA数

        public const int MAX_USERNUM_V30 = 32;//9000设备最大用户数
        public const int MAX_USERNUM = 16;//8000设备最大用户数
        public const int MAX_EXCEPTIONNUM_V30 = 32;//9000设备最大异常处理数
        public const int MAX_EXCEPTIONNUM = 16;//8000设备最大异常处理数
        public const int MAX_LINK = 6;//8000设备单通道最大视频流连接数
        public const int MAX_ITC_EXCEPTIONOUT = 32;//抓拍机最大报警输出

        public const int MAX_DECPOOLNUM = 4;//单路解码器每个解码通道最大可循环解码数
        public const int MAX_DECNUM = 4;//单路解码器的最大解码通道数（实际只有一个，其他三个保留）
        public const int MAX_TRANSPARENTNUM = 2;//单路解码器可配置最大透明通道数
        public const int MAX_CYCLE_CHAN = 16; //单路解码器最大轮循通道数
        public const int MAX_CYCLE_CHAN_V30 = 64;//最大轮询通道数（扩展）
        public const int MAX_DIRNAME_LENGTH = 80;//最大目录长度

        public const int MAX_STRINGNUM_V30 = 8;//9000设备最大OSD字符行数数
        public const int MAX_STRINGNUM = 4;//8000设备最大OSD字符行数数
        public const int MAX_STRINGNUM_EX = 8;//8000定制扩展
        public const int MAX_AUXOUT_V30 = 16;//9000设备最大辅助输出数
        public const int MAX_AUXOUT = 4;//8000设备最大辅助输出数
        public const int MAX_HD_GROUP = 16;//9000设备最大硬盘组数
        public const int MAX_NFS_DISK = 8; //8000设备最大NFS硬盘数

        public const int IW_ESSID_MAX_SIZE = 32;//WIFI的SSID号长度
        public const int IW_ENCODING_TOKEN_MAX = 32;//WIFI密锁最大字节数
        public const int WIFI_WEP_MAX_KEY_COUNT = 4;
        public const int WIFI_WEP_MAX_KEY_LENGTH = 33;
        public const int WIFI_WPA_PSK_MAX_KEY_LENGTH = 63;
        public const int WIFI_WPA_PSK_MIN_KEY_LENGTH = 8;
        public const int WIFI_MAX_AP_COUNT = 20;
        public const int MAX_SERIAL_NUM = 64;//最多支持的透明通道路数
        public const int MAX_DDNS_NUMS = 10;//9000设备最大可配ddns数
        public const int MAX_EMAIL_ADDR_LEN = 48;//最大email地址长度
        public const int MAX_EMAIL_PWD_LEN = 32;//最大email密码长度

        public const int MAXPROGRESS = 100;//回放时的最大百分率
        public const int MAX_SERIALNUM = 2;//8000设备支持的串口数 1-232， 2-485
        public const int CARDNUM_LEN = 20;//卡号长度
        public const int CARDNUM_LEN_OUT = 32; //外部结构体卡号长度
        public const int MAX_VIDEOOUT_V30 = 4;//9000设备的视频输出数
        public const int MAX_VIDEOOUT = 2;//8000设备的视频输出数

        public const int MAX_PRESET_V30 = 256;// 9000设备支持的云台预置点数
        public const int MAX_TRACK_V30 = 256;// 9000设备支持的花样扫描数
        public const int MAX_CRUISE_V30 = 256;// 9000设备支持的云台巡航数
        public const int MAX_PRESET = 128;// 8000设备支持的云台预置点数 
        public const int MAX_TRACK = 128;// 8000设备支持的花样扫描数
        public const int MAX_CRUISE = 128;// 8000设备支持的云台巡航数 

        public const int CRUISE_MAX_PRESET_NUMS = 32;// 一条巡航最多的巡航点 

        public const int MAX_SERIAL_PORT = 8;//9000设备支持232串口数
        public const int MAX_PREVIEW_MODE = 8;// 设备支持最大预览模式数目 1画面,4画面,9画面,16画面.... 
        public const int MAX_MATRIXOUT = 16;// 最大模拟矩阵输出个数 
        public const int LOG_INFO_LEN = 11840; // 日志附加信息 
        public const int DESC_LEN = 16;// 云台描述字符串长度 
        public const int PTZ_PROTOCOL_NUM = 200;// 9000最大支持的云台协议数 

        public const int MAX_AUDIO = 1;//8000语音对讲通道数
        public const int MAX_AUDIO_V30 = 2;//9000语音对讲通道数
        public const int MAX_CHANNUM = 16;//8000设备最大通道数
        public const int MAX_ALARMIN = 16;//8000设备最大报警输入数
        public const int MAX_ALARMOUT = 4;//8000设备最大报警输出数
        //9000 IPC接入
        public const int MAX_ANALOG_CHANNUM = 32;//最大32个模拟通道
        public const int MAX_ANALOG_ALARMOUT = 32; //最大32路模拟报警输出 
        public const int MAX_ANALOG_ALARMIN = 32;//最大32路模拟报警输入

        public const int MAX_IP_DEVICE = 32;//允许接入的最大IP设备数
        public const int MAX_IP_DEVICE_V40 = 64;//允许接入的最大IP设备数
        public const int MAX_IP_CHANNEL = 32;//允许加入的最多IP通道数
        public const int MAX_IP_ALARMIN = 128;//允许加入的最多报警输入数
        public const int MAX_IP_ALARMOUT = 64;//允许加入的最多报警输出数
        public const int MAX_IP_ALARMIN_V40 = 4096;    //允许加入的最多报警输入数
        public const int MAX_IP_ALARMOUT_V40 = 4096;    //允许加入的最多报警输出数

        public const int MAX_RECORD_FILE_NUM = 20;      // 每次删除或者刻录的最大文件数

        //SDK_V31 ATM
        public const int MAX_ATM_NUM = 1;
        public const int MAX_ACTION_TYPE = 12;
        public const int ATM_FRAMETYPE_NUM = 4;
        public const int MAX_ATM_PROTOCOL_NUM = 1025;
        public const int ATM_PROTOCOL_SORT = 4;
        public const int ATM_DESC_LEN = 32;
        // SDK_V31 ATM

        /* 最大支持的通道数 最大模拟加上最大IP支持 */
        public const int MAX_CHANNUM_V30 = MAX_ANALOG_CHANNUM + MAX_IP_CHANNEL;//64
        public const int MAX_ALARMOUT_V30 = MAX_ANALOG_ALARMOUT + MAX_IP_ALARMOUT;//96
        public const int MAX_ALARMIN_V30 = MAX_ANALOG_ALARMIN + MAX_IP_ALARMIN;//160

        public const int MAX_CHANNUM_V40 = 512;
        public const int MAX_ALARMOUT_V40 = MAX_IP_ALARMOUT_V40 + MAX_ANALOG_ALARMOUT;//4128
        public const int MAX_ALARMIN_V40 = MAX_IP_ALARMIN_V40 + MAX_ANALOG_ALARMOUT;//4128
        public const int MAX_MULTI_AREA_NUM = 24;

        public const int MAX_HUMAN_PICTURE_NUM = 10;   //最大照片数
        public const int MAX_HUMAN_BIRTHDATE_LEN = 10;

        public const int MAX_LAYERNUMS = 32;

        public const int MAX_ROIDETECT_NUM = 8;    //支持的ROI区域数
        public const int MAX_LANERECT_NUM   =     5;    //最大车牌识别区域数
        public const int MAX_FORTIFY_NUM   =      10;   //最大布防个数
        public const int MAX_INTERVAL_NUM  =      4;    //最大时间间隔个数
        public const int MAX_CHJC_NUM     =       3;    //最大车辆省份简称字符个数
        public const int MAX_VL_NUM        =      5;    //最大虚拟线圈个数
        public const int MAX_DRIVECHAN_NUM =      16;   //最大车道数
        public const int MAX_COIL_NUM      =      3;    //最大线圈个数
        public const int MAX_SIGNALLIGHT_NUM =    6;   //最大信号灯个数
        public const int LEN_32				=	32;
        public const int LEN_31				=	31; 
        public const int MAX_CABINET_COUNT  =     8;    //最大支持机柜数量
        public const int MAX_ID_LEN         =     48;
        public const int MAX_PARKNO_LEN    =      16;
        public const int MAX_ALARMREASON_LEN =    32;
        public const int MAX_UPGRADE_INFO_LEN=    48; //获取升级文件匹配信息(模糊升级)
        public const int MAX_CUSTOMDIR_LEN  =     32; //自定义目录长度

        public const int MAX_TRANSPARENT_CHAN_NUM  =    4;   //每个串口允许建立的最大透明通道数
        public const int MAX_TRANSPARENT_ACCESS_NUM =   4;   //每个监听端口允许接入的最大主机数

        //ITS
        public const int MAX_PARKING_STATUS  =     8;    //车位状态 0代表无车，1代表有车，2代表压线(优先级最高), 3特殊车位 
        public const int MAX_PARKING_NUM	   =      4;    //一个通道最大4个车位 (从左到右车位 数组0～3)

        public const int MAX_ITS_SCENE_NUM    =    16;   //最大场景数量
        public const int MAX_SCENE_TIMESEG_NUM =   16;   //最大场景时间段数量
        public const int MAX_IVMS_IP_CHANNEL  =    128;  //最大IP通道数
        public const int DEVICE_ID_LEN      =      48;   //设备编号长度
        public const int MONITORSITE_ID_LEN  =     48;   //监测点编号长度
        public const int MAX_AUXAREA_NUM       =   16;   //辅助区域最大数目
        public const int MAX_SLAVE_CHANNEL_NUM =   16;   //最大从通道数量

        public const int MAX_SCH_TASKS_NUM = 10;

        public const int MAX_SERVERID_LEN   =         64; //最大服务器ID的长度
        public const int MAX_SERVERDOMAIN_LEN =       128; //服务器域名最大长度
        public const int MAX_AUTHENTICATEID_LEN =     64; //认证ID最大长度
        public const int MAX_AUTHENTICATEPASSWD_LEN = 32; //认证密码最大长度
        public const int MAX_SERVERNAME_LEN =         64; //最大服务器用户名 
        public const int MAX_COMPRESSIONID_LEN =      64; //编码ID的最大长度
        public const int MAX_SIPSERVER_ADDRESS_LEN =  128; //SIP服务器地址支持域名和IP地址
        //压线报警
        public const int MAX_PlATE_NO_LEN =        32;   //车牌号码最大长度 2013-09-27
        public const int UPNP_PORT_NUM	=		12;	  //upnp端口映射端口数目

        
        public const int MAX_LOCAL_ADDR_LEN	= 96;		//SOCKS最大本地网段个数
        public const int MAX_COUNTRY_NAME_LEN = 4;		//国家简写名称长度

        public const int THERMOMETRY_ALARMRULE_NUM = 40; //热成像报警规则数

        public const int ACS_CARD_NO_LEN = 32; //门禁卡号长度    
        public const int MAX_ID_NUM_LEN = 32;  //最大身份证号长度
        public const int MAX_ID_NAME_LEN = 128;   //最大姓名长度
        public const int MAX_ID_ADDR_LEN = 280;   //最大住址长度
        public const int MAX_ID_ISSUING_AUTHORITY_LEN = 128; //最大签发机关长度

        public const int MAX_CARD_RIGHT_PLAN_NUM        = 4;   //卡权限最大计划个数
        public const int MAX_GROUP_NUM_128              = 128; //最大群组数
        public const int MAX_CARD_READER_NUM            = 64;  //最大读卡器数
        public const int MAX_SNEAK_PATH_NODE            = 8;   //最大后续读卡器数
        public const int MAX_MULTI_DOOR_INTERLOCK_GROUP = 8;   //最大多门互锁组数
        public const int MAX_INTER_LOCK_DOOR_NUM        = 8;   //一个多门互锁组中最大互锁门数
        public const int MAX_CASE_SENSOR_NUM            = 8;  //最大case sensor触发器数
        public const int MAX_DOOR_NUM_256               = 256; //最大门数
        public const int MAX_READER_ROUTE_NUM           = 16;  //最大刷卡循序路径 
        public const int MAX_FINGER_PRINT_NUM           = 10;  //最大指纹个数
        public const int MAX_CARD_READER_NUM_512        = 512; //最大读卡器数
        public const int NET_SDK_MULTI_CARD_GROUP_NUM_20 = 20;   //单门最大多重卡组数
        public const int CARD_PASSWORD_LEN              = 8;   //卡密码长度
        public const int MAX_DOOR_CODE_LEN              = 8; //房间代码长度
        public const int MAX_LOCK_CODE_LEN              = 8; //锁代码长度

        public const int MAX_NOTICE_NUMBER_LEN     = 32;   //公告编号最大长度
        public const int MAX_NOTICE_THEME_LEN      = 64;   //公告主题最大长度
        public const int MAX_NOTICE_DETAIL_LEN     = 1024; //公告详情最大长度
        public const int MAX_NOTICE_PIC_NUM        = 6;    //公告信息最大图片数量
        public const int MAX_DEV_NUMBER_LEN        = 32;   //设备编号最大长度
        public const int LOCK_NAME_LEN = 32;  //锁名称

        public const int GROUP_NAME_LEN          = 32;  //群组名称长度
        public const int GROUP_COMBINATION_NUM   = 8;   //群组组合数
        public const int MULTI_CARD_GROUP_NUM = 4;   //单门最大多重卡组数

        public const int NET_SDK_EMPLOYEE_NO_LEN = 32;  //工号长度
        public const int NET_SDK_UUID_LEN        = 36;  //UUID长度
        public const int NET_SDK_EHOME_KEY_LEN = 32;  //EHome Key长度

        public const int NET_DEV_NAME_LEN       = 64;  //设备名称长度
        public const int NET_DEV_TYPE_NAME_LEN  = 64; //设备类型名称长度

        public const int VCA_MAX_POLYGON_POINT_NUM = 10;//检测区域最多支持10个点的多边形
        public const int MAX_RULE_NUM = 8;//最多规则条数
        public const int MAX_TARGET_NUM = 30;//最多目标个数
        public const int MAX_CALIB_PT = 6;//最大标定点个数
        public const int MIN_CALIB_PT = 4;//最小标定点个数
        public const int MAX_TIMESEGMENT_2 = 2;//最大时间段数
        public const int MAX_LICENSE_LEN = 16;//车牌号最大长度
        public const int MAX_PLATE_NUM = 3;//车牌个数
        public const int MAX_MASK_REGION_NUM = 4;//最多四个屏蔽区域
        public const int MAX_SEGMENT_NUM = 6;//摄像机标定最大样本线数目
        public const int MIN_SEGMENT_NUM = 3;//摄像机标定最小样本线数目  
        public const int MAX_CATEGORY_LEN = 8;       //车牌附加信息最大字符
        public const int SERIAL_NO_LEN = 16;      //泊车位编号
        public const int ILLEGAL_LEN = 32;      //违法代码长度

        //码流连接方式
        public const int NORMALCONNECT = 1;
        public const int MEDIACONNECT = 2;

        //设备型号(大类)
        public const int HCDVR = 1;
        public const int MEDVR = 2;
        public const int PCDVR = 3;
        public const int HC_9000 = 4;
        public const int HF_I = 5;
        public const int PCNVR = 6;
        public const int HC_76NVR = 8;

        //NVR类型
        public const int DS8000HC_NVR = 0;
        public const int DS9000HC_NVR = 1;
        public const int DS8000ME_NVR = 2;

        /*******************全局错误码 begin**********************/
        public const int NET_DVR_NOERROR = 0;//没有错误
        public const int NET_DVR_PASSWORD_ERROR = 1;//用户名密码错误
        public const int NET_DVR_NOENOUGHPRI = 2;//权限不足
        public const int NET_DVR_NOINIT = 3;//没有初始化
        public const int NET_DVR_CHANNEL_ERROR = 4;//通道号错误
        public const int NET_DVR_OVER_MAXLINK = 5;//连接到DVR的客户端个数超过最大
        public const int NET_DVR_VERSIONNOMATCH = 6;//版本不匹配
        public const int NET_DVR_NETWORK_FAIL_CONNECT = 7;//连接服务器失败
        public const int NET_DVR_NETWORK_SEND_ERROR = 8;//向服务器发送失败
        public const int NET_DVR_NETWORK_RECV_ERROR = 9;//从服务器接收数据失败
        public const int NET_DVR_NETWORK_RECV_TIMEOUT = 10;//从服务器接收数据超时
        public const int NET_DVR_NETWORK_ERRORDATA = 11;//传送的数据有误
        public const int NET_DVR_ORDER_ERROR = 12;//调用次序错误
        public const int NET_DVR_OPERNOPERMIT = 13;//无此权限
        public const int NET_DVR_COMMANDTIMEOUT = 14;//DVR命令执行超时
        public const int NET_DVR_ERRORSERIALPORT = 15;//串口号错误
        public const int NET_DVR_ERRORALARMPORT = 16;//报警端口错误
        public const int NET_DVR_PARAMETER_ERROR = 17;//参数错误
        public const int NET_DVR_CHAN_EXCEPTION = 18;//服务器通道处于错误状态
        public const int NET_DVR_NODISK = 19;//没有硬盘
        public const int NET_DVR_ERRORDISKNUM = 20;//硬盘号错误
        public const int NET_DVR_DISK_FULL = 21;//服务器硬盘满
        public const int NET_DVR_DISK_ERROR = 22;//服务器硬盘出错
        public const int NET_DVR_NOSUPPORT = 23;//服务器不支持
        public const int NET_DVR_BUSY = 24;//服务器忙
        public const int NET_DVR_MODIFY_FAIL = 25;//服务器修改不成功
        public const int NET_DVR_PASSWORD_FORMAT_ERROR = 26;//密码输入格式不正确
        public const int NET_DVR_DISK_FORMATING = 27;//硬盘正在格式化，不能启动操作
        public const int NET_DVR_DVRNORESOURCE = 28;//DVR资源不足
        public const int NET_DVR_DVROPRATEFAILED = 29;//DVR操作失败
        public const int NET_DVR_OPENHOSTSOUND_FAIL = 30;//打开PC声音失败
        public const int NET_DVR_DVRVOICEOPENED = 31;//服务器语音对讲被占用
        public const int NET_DVR_TIMEINPUTERROR = 32;//时间输入不正确
        public const int NET_DVR_NOSPECFILE = 33;//回放时服务器没有指定的文件
        public const int NET_DVR_CREATEFILE_ERROR = 34;//创建文件出错
        public const int NET_DVR_FILEOPENFAIL = 35;//打开文件出错
        public const int NET_DVR_OPERNOTFINISH = 36; //上次的操作还没有完成
        public const int NET_DVR_GETPLAYTIMEFAIL = 37;//获取当前播放的时间出错
        public const int NET_DVR_PLAYFAIL = 38;//播放出错
        public const int NET_DVR_FILEFORMAT_ERROR = 39;//文件格式不正确
        public const int NET_DVR_DIR_ERROR = 40;//路径错误
        public const int NET_DVR_ALLOC_RESOURCE_ERROR = 41;//资源分配错误
        public const int NET_DVR_AUDIO_MODE_ERROR = 42;//声卡模式错误
        public const int NET_DVR_NOENOUGH_BUF = 43;//缓冲区太小
        public const int NET_DVR_CREATESOCKET_ERROR = 44;//创建SOCKET出错
        public const int NET_DVR_SETSOCKET_ERROR = 45;//设置SOCKET出错
        public const int NET_DVR_MAX_NUM = 46;//个数达到最大
        public const int NET_DVR_USERNOTEXIST = 47;//用户不存在
        public const int NET_DVR_WRITEFLASHERROR = 48;//写FLASH出错
        public const int NET_DVR_UPGRADEFAIL = 49;//DVR升级失败
        public const int NET_DVR_CARDHAVEINIT = 50;//解码卡已经初始化过
        public const int NET_DVR_PLAYERFAILED = 51;//调用播放库中某个函数失败
        public const int NET_DVR_MAX_USERNUM = 52;//设备端用户数达到最大
        public const int NET_DVR_GETLOCALIPANDMACFAIL = 53;//获得客户端的IP地址或物理地址失败
        public const int NET_DVR_NOENCODEING = 54;//该通道没有编码
        public const int NET_DVR_IPMISMATCH = 55;//IP地址不匹配
        public const int NET_DVR_MACMISMATCH = 56;//MAC地址不匹配
        public const int NET_DVR_UPGRADELANGMISMATCH = 57;//升级文件语言不匹配
        public const int NET_DVR_MAX_PLAYERPORT = 58;//播放器路数达到最大
        public const int NET_DVR_NOSPACEBACKUP = 59;//备份设备中没有足够空间进行备份
        public const int NET_DVR_NODEVICEBACKUP = 60;//没有找到指定的备份设备
        public const int NET_DVR_PICTURE_BITS_ERROR = 61;//图像素位数不符，限24色
        public const int NET_DVR_PICTURE_DIMENSION_ERROR = 62;//图片高*宽超限， 限128*256
        public const int NET_DVR_PICTURE_SIZ_ERROR = 63;//图片大小超限，限100K
        public const int NET_DVR_LOADPLAYERSDKFAILED = 64;//载入当前目录下Player Sdk出错
        public const int NET_DVR_LOADPLAYERSDKPROC_ERROR = 65;//找不到Player Sdk中某个函数入口
        public const int NET_DVR_LOADDSSDKFAILED = 66;//载入当前目录下DSsdk出错
        public const int NET_DVR_LOADDSSDKPROC_ERROR = 67;//找不到DsSdk中某个函数入口
        public const int NET_DVR_DSSDK_ERROR = 68;//调用硬解码库DsSdk中某个函数失败
        public const int NET_DVR_VOICEMONOPOLIZE = 69;//声卡被独占
        public const int NET_DVR_JOINMULTICASTFAILED = 70;//加入多播组失败
        public const int NET_DVR_CREATEDIR_ERROR = 71;//建立日志文件目录失败
        public const int NET_DVR_BINDSOCKET_ERROR = 72;//绑定套接字失败
        public const int NET_DVR_SOCKETCLOSE_ERROR = 73;//socket连接中断，此错误通常是由于连接中断或目的地不可达
        public const int NET_DVR_USERID_ISUSING = 74;//注销时用户ID正在进行某操作
        public const int NET_DVR_SOCKETLISTEN_ERROR = 75;//监听失败
        public const int NET_DVR_PROGRAM_EXCEPTION = 76;//程序异常
        public const int NET_DVR_WRITEFILE_FAILED = 77;//写文件失败
        public const int NET_DVR_FORMAT_READONLY = 78;//禁止格式化只读硬盘
        public const int NET_DVR_WITHSAMEUSERNAME = 79;//用户配置结构中存在相同的用户名
        public const int NET_DVR_DEVICETYPE_ERROR = 80;//导入参数时设备型号不匹配
        public const int NET_DVR_LANGUAGE_ERROR = 81;//导入参数时语言不匹配
        public const int NET_DVR_PARAVERSION_ERROR = 82;//导入参数时软件版本不匹配
        public const int NET_DVR_IPCHAN_NOTALIVE = 83; //预览时外接IP通道不在线
        public const int NET_DVR_RTSP_SDK_ERROR = 84;//加载高清IPC通讯库StreamTransClient.dll失败
        public const int NET_DVR_CONVERT_SDK_ERROR = 85;//加载转码库失败
        public const int NET_DVR_IPC_COUNT_OVERFLOW = 86;//超出最大的ip接入通道数
        public const int NET_DVR_USER_LOCKED = 153;

        public const int NET_PLAYM4_NOERROR = 500;//no error
        public const int NET_PLAYM4_PARA_OVER = 501;//input parameter is invalid
        public const int NET_PLAYM4_ORDER_ERROR = 502;//The order of the function to be called is error
        public const int NET_PLAYM4_TIMER_ERROR = 503;//Create multimedia clock failed
        public const int NET_PLAYM4_DEC_VIDEO_ERROR = 504;//Decode video data failed
        public const int NET_PLAYM4_DEC_AUDIO_ERROR = 505;//Decode audio data failed
        public const int NET_PLAYM4_ALLOC_MEMORY_ERROR = 506;//Allocate memory failed
        public const int NET_PLAYM4_OPEN_FILE_ERROR = 507;//Open the file failed
        public const int NET_PLAYM4_CREATE_OBJ_ERROR = 508;//Create thread or event failed
        public const int NET_PLAYM4_CREATE_DDRAW_ERROR = 509;//Create DirectDraw object failed
        public const int NET_PLAYM4_CREATE_OFFSCREEN_ERROR = 510;//failed when creating off-screen surface
        public const int NET_PLAYM4_BUF_OVER = 511;//buffer is overflow
        public const int NET_PLAYM4_CREATE_SOUND_ERROR = 512;//failed when creating audio device
        public const int NET_PLAYM4_SET_VOLUME_ERROR = 513;//Set volume failed
        public const int NET_PLAYM4_SUPPORT_FILE_ONLY = 514;//The function only support play file
        public const int NET_PLAYM4_SUPPORT_STREAM_ONLY = 515;//The function only support play stream
        public const int NET_PLAYM4_SYS_NOT_SUPPORT = 516;//System not support
        public const int NET_PLAYM4_FILEHEADER_UNKNOWN = 517;//No file header
        public const int NET_PLAYM4_VERSION_INCORRECT = 518;//The version of decoder and encoder is not adapted
        public const int NET_PALYM4_INIT_DECODER_ERROR = 519;//Initialize decoder failed
        public const int NET_PLAYM4_CHECK_FILE_ERROR = 520;//The file data is unknown
        public const int NET_PLAYM4_INIT_TIMER_ERROR = 521;//Initialize multimedia clock failed
        public const int NET_PLAYM4_BLT_ERROR = 522;//Blt failed
        public const int NET_PLAYM4_UPDATE_ERROR = 523;//Update failed
        public const int NET_PLAYM4_OPEN_FILE_ERROR_MULTI = 524;//openfile error, streamtype is multi
        public const int NET_PLAYM4_OPEN_FILE_ERROR_VIDEO = 525;//openfile error, streamtype is video
        public const int NET_PLAYM4_JPEG_COMPRESS_ERROR = 526;//JPEG compress error
        public const int NET_PLAYM4_EXTRACT_NOT_SUPPORT = 527;//Don't support the version of this file
        public const int NET_PLAYM4_EXTRACT_DATA_ERROR = 528;//extract video data failed
        /*******************全局错误码 end**********************/

        /*************************************************
        NET_DVR_IsSupport()返回值
        1－9位分别表示以下信息（位与是TRUE)表示支持；
        **************************************************/
        public const int NET_DVR_SUPPORT_DDRAW = 1;//支持DIRECTDRAW，如果不支持，则播放器不能工作
        public const int NET_DVR_SUPPORT_BLT = 2;//显卡支持BLT操作，如果不支持，则播放器不能工作
        public const int NET_DVR_SUPPORT_BLTFOURCC = 4;//显卡BLT支持颜色转换，如果不支持，播放器会用软件方法作RGB转换
        public const int NET_DVR_SUPPORT_BLTSHRINKX = 8;//显卡BLT支持X轴缩小；如果不支持，系统会用软件方法转换
        public const int NET_DVR_SUPPORT_BLTSHRINKY = 16;//显卡BLT支持Y轴缩小；如果不支持，系统会用软件方法转换
        public const int NET_DVR_SUPPORT_BLTSTRETCHX = 32;//显卡BLT支持X轴放大；如果不支持，系统会用软件方法转换
        public const int NET_DVR_SUPPORT_BLTSTRETCHY = 64;//显卡BLT支持Y轴放大；如果不支持，系统会用软件方法转换
        public const int NET_DVR_SUPPORT_SSE = 128;//CPU支持SSE指令，Intel Pentium3以上支持SSE指令
        public const int NET_DVR_SUPPORT_MMX = 256;//CPU支持MMX指令集，Intel Pentium3以上支持SSE指令

        /**********************云台控制命令 begin*************************/
        public const int LIGHT_PWRON = 2;// 接通灯光电源
        public const int WIPER_PWRON = 3;// 接通雨刷开关 
        public const int FAN_PWRON = 4;// 接通风扇开关
        public const int HEATER_PWRON = 5;// 接通加热器开关
        public const int AUX_PWRON1 = 6;// 接通辅助设备开关
        public const int AUX_PWRON2 = 7;// 接通辅助设备开关 
        public const int SET_PRESET = 8;// 设置预置点 
        public const int CLE_PRESET = 9;// 清除预置点 

        public const int ZOOM_IN = 11;// 焦距以速度SS变大(倍率变大)
        public const int ZOOM_OUT = 12;// 焦距以速度SS变小(倍率变小)
        public const int FOCUS_NEAR = 13;// 焦点以速度SS前调 
        public const int FOCUS_FAR = 14;// 焦点以速度SS后调
        public const int IRIS_OPEN = 15;// 光圈以速度SS扩大
        public const int IRIS_CLOSE = 16;// 光圈以速度SS缩小 

        public const int TILT_UP = 21;/* 云台以SS的速度上仰 */
        public const int TILT_DOWN = 22;/* 云台以SS的速度下俯 */
        public const int PAN_LEFT = 23;/* 云台以SS的速度左转 */
        public const int PAN_RIGHT = 24;/* 云台以SS的速度右转 */
        public const int UP_LEFT = 25;/* 云台以SS的速度上仰和左转 */
        public const int UP_RIGHT = 26;/* 云台以SS的速度上仰和右转 */
        public const int DOWN_LEFT = 27;/* 云台以SS的速度下俯和左转 */
        public const int DOWN_RIGHT = 28;/* 云台以SS的速度下俯和右转 */
        public const int PAN_AUTO = 29;/* 云台以SS的速度左右自动扫描 */

        public const int FILL_PRE_SEQ = 30;/* 将预置点加入巡航序列 */
        public const int SET_SEQ_DWELL = 31;/* 设置巡航点停顿时间 */
        public const int SET_SEQ_SPEED = 32;/* 设置巡航速度 */
        public const int CLE_PRE_SEQ = 33;/* 将预置点从巡航序列中删除 */
        public const int STA_MEM_CRUISE = 34;/* 开始记录轨迹 */
        public const int STO_MEM_CRUISE = 35;/* 停止记录轨迹 */
        public const int RUN_CRUISE = 36;/* 开始轨迹 */
        public const int RUN_SEQ = 37;/* 开始巡航 */
        public const int STOP_SEQ = 38;/* 停止巡航 */
        public const int GOTO_PRESET = 39;/* 快球转到预置点 */
        /**********************云台控制命令 end*************************/

        /*************************************************
        回放时播放控制命令宏定义 
        NET_DVR_PlayBackControl
        NET_DVR_PlayControlLocDisplay
        NET_DVR_DecPlayBackCtrl的宏定义
        具体支持查看函数说明和代码
        **************************************************/
        public const int NET_DVR_PLAYSTART = 1;//开始播放
        public const int NET_DVR_PLAYSTOP = 2;//停止播放
        public const int NET_DVR_PLAYPAUSE = 3;//暂停播放
        public const int NET_DVR_PLAYRESTART = 4;//恢复播放
        public const int NET_DVR_PLAYFAST = 5;//快放
        public const int NET_DVR_PLAYSLOW = 6;//慢放
        public const int NET_DVR_PLAYNORMAL = 7;//正常速度
        public const int NET_DVR_PLAYFRAME = 8;//单帧放
        public const int NET_DVR_PLAYSTARTAUDIO = 9;//打开声音
        public const int NET_DVR_PLAYSTOPAUDIO = 10;//关闭声音
        public const int NET_DVR_PLAYAUDIOVOLUME = 11;//调节音量
        public const int NET_DVR_PLAYSETPOS = 12;//改变文件回放的进度
        public const int NET_DVR_PLAYGETPOS = 13;//获取文件回放的进度
        public const int NET_DVR_PLAYGETTIME = 14;//获取当前已经播放的时间(按文件回放的时候有效)
        public const int NET_DVR_PLAYGETFRAME = 15;//获取当前已经播放的帧数(按文件回放的时候有效)
        public const int NET_DVR_GETTOTALFRAMES = 16;//获取当前播放文件总的帧数(按文件回放的时候有效)
        public const int NET_DVR_GETTOTALTIME = 17;//获取当前播放文件总的时间(按文件回放的时候有效)
        public const int NET_DVR_THROWBFRAME = 20;//丢B帧
        public const int NET_DVR_SETSPEED = 24;//设置码流速度
        public const int NET_DVR_KEEPALIVE = 25;//保持与设备的心跳(如果回调阻塞，建议2秒发送一次)
        public const int NET_DVR_PLAYSETTIME = 26;//按绝对时间定位
        public const int NET_DVR_PLAYGETTOTALLEN = 27;//获取按时间回放对应时间段内的所有文件的总长度
        public const int NET_DVR_PLAY_FORWARD = 29;//倒放切换为正放
        public const int NET_DVR_PLAY_REVERSE = 30;//正放切换为倒放
        public const int NET_DVR_SET_TRANS_TYPE = 32;//设置转封装类型
        public const int NET_DVR_PLAY_CONVERT = 33;//正放切换为倒放

        //远程按键定义如下：
        /* key value send to CONFIG program */
        public const int KEY_CODE_1 = 1;
        public const int KEY_CODE_2 = 2;
        public const int KEY_CODE_3 = 3;
        public const int KEY_CODE_4 = 4;
        public const int KEY_CODE_5 = 5;
        public const int KEY_CODE_6 = 6;
        public const int KEY_CODE_7 = 7;
        public const int KEY_CODE_8 = 8;
        public const int KEY_CODE_9 = 9;
        public const int KEY_CODE_0 = 10;
        public const int KEY_CODE_POWER = 11;
        public const int KEY_CODE_MENU = 12;
        public const int KEY_CODE_ENTER = 13;
        public const int KEY_CODE_CANCEL = 14;
        public const int KEY_CODE_UP = 15;
        public const int KEY_CODE_DOWN = 16;
        public const int KEY_CODE_LEFT = 17;
        public const int KEY_CODE_RIGHT = 18;
        public const int KEY_CODE_EDIT = 19;
        public const int KEY_CODE_ADD = 20;
        public const int KEY_CODE_MINUS = 21;
        public const int KEY_CODE_PLAY = 22;
        public const int KEY_CODE_REC = 23;
        public const int KEY_CODE_PAN = 24;
        public const int KEY_CODE_M = 25;
        public const int KEY_CODE_A = 26;
        public const int KEY_CODE_F1 = 27;
        public const int KEY_CODE_F2 = 28;

        /* for PTZ control */
        public const int KEY_PTZ_UP_START = KEY_CODE_UP;
        public const int KEY_PTZ_UP_STOP = 32;

        public const int KEY_PTZ_DOWN_START = KEY_CODE_DOWN;
        public const int KEY_PTZ_DOWN_STOP = 33;


        public const int KEY_PTZ_LEFT_START = KEY_CODE_LEFT;
        public const int KEY_PTZ_LEFT_STOP = 34;

        public const int KEY_PTZ_RIGHT_START = KEY_CODE_RIGHT;
        public const int KEY_PTZ_RIGHT_STOP = 35;

        public const int KEY_PTZ_AP1_START = KEY_CODE_EDIT;/* 光圈+ */
        public const int KEY_PTZ_AP1_STOP = 36;

        public const int KEY_PTZ_AP2_START = KEY_CODE_PAN;/* 光圈- */
        public const int KEY_PTZ_AP2_STOP = 37;

        public const int KEY_PTZ_FOCUS1_START = KEY_CODE_A;/* 聚焦+ */
        public const int KEY_PTZ_FOCUS1_STOP = 38;

        public const int KEY_PTZ_FOCUS2_START = KEY_CODE_M;/* 聚焦- */
        public const int KEY_PTZ_FOCUS2_STOP = 39;

        public const int KEY_PTZ_B1_START = 40;/* 变倍+ */
        public const int KEY_PTZ_B1_STOP = 41;

        public const int KEY_PTZ_B2_START = 42;/* 变倍- */
        public const int KEY_PTZ_B2_STOP = 43;

        //9000新增
        public const int KEY_CODE_11 = 44;
        public const int KEY_CODE_12 = 45;
        public const int KEY_CODE_13 = 46;
        public const int KEY_CODE_14 = 47;
        public const int KEY_CODE_15 = 48;
        public const int KEY_CODE_16 = 49;

        /*************************参数配置命令 begin*******************************/
        //用于NET_DVR_SetDVRConfig和NET_DVR_GetDVRConfig,注意其对应的配置结构
        public const int NET_DVR_GET_DEVICECFG = 100;//获取设备参数
        public const int NET_DVR_SET_DEVICECFG = 101;//设置设备参数
        public const int NET_DVR_GET_NETCFG = 102;//获取网络参数
        public const int NET_DVR_SET_NETCFG = 103;//设置网络参数
        public const int NET_DVR_GET_PICCFG = 104;//获取图象参数
        public const int NET_DVR_SET_PICCFG = 105;//设置图象参数
        public const int NET_DVR_GET_COMPRESSCFG = 106;//获取压缩参数
        public const int NET_DVR_SET_COMPRESSCFG = 107;//设置压缩参数
        public const int NET_DVR_GET_RECORDCFG = 108;//获取录像时间参数
        public const int NET_DVR_SET_RECORDCFG = 109;//设置录像时间参数
        public const int NET_DVR_GET_DECODERCFG = 110;//获取解码器参数
        public const int NET_DVR_SET_DECODERCFG = 111;//设置解码器参数
        public const int NET_DVR_GET_RS232CFG = 112;//获取232串口参数
        public const int NET_DVR_SET_RS232CFG = 113;//设置232串口参数
        public const int NET_DVR_GET_ALARMINCFG = 114;//获取报警输入参数
        public const int NET_DVR_SET_ALARMINCFG = 115;//设置报警输入参数
        public const int NET_DVR_GET_ALARMOUTCFG = 116;//获取报警输出参数
        public const int NET_DVR_SET_ALARMOUTCFG = 117;//设置报警输出参数
        public const int NET_DVR_GET_TIMECFG = 118;//获取DVR时间
        public const int NET_DVR_SET_TIMECFG = 119;//设置DVR时间
        public const int NET_DVR_GET_PREVIEWCFG = 120;//获取预览参数
        public const int NET_DVR_SET_PREVIEWCFG = 121;//设置预览参数
        public const int NET_DVR_GET_VIDEOOUTCFG = 122;//获取视频输出参数
        public const int NET_DVR_SET_VIDEOOUTCFG = 123;//设置视频输出参数
        public const int NET_DVR_GET_USERCFG = 124;//获取用户参数
        public const int NET_DVR_SET_USERCFG = 125;//设置用户参数
        public const int NET_DVR_GET_EXCEPTIONCFG = 126;//获取异常参数
        public const int NET_DVR_SET_EXCEPTIONCFG = 127;//设置异常参数
        public const int NET_DVR_GET_ZONEANDDST = 128;//获取时区和夏时制参数
        public const int NET_DVR_SET_ZONEANDDST = 129;//设置时区和夏时制参数
        public const int NET_DVR_GET_SHOWSTRING = 130;//获取叠加字符参数
        public const int NET_DVR_SET_SHOWSTRING = 131;//设置叠加字符参数
        public const int NET_DVR_GET_EVENTCOMPCFG = 132;//获取事件触发录像参数
        public const int NET_DVR_SET_EVENTCOMPCFG = 133;//设置事件触发录像参数

        public const int NET_DVR_GET_AUXOUTCFG = 140;//获取报警触发辅助输出设置(HS设备辅助输出2006-02-28)
        public const int NET_DVR_SET_AUXOUTCFG = 141;//设置报警触发辅助输出设置(HS设备辅助输出2006-02-28)
        public const int NET_DVR_GET_PREVIEWCFG_AUX = 142;//获取-s系列双输出预览参数(-s系列双输出2006-04-13)
        public const int NET_DVR_SET_PREVIEWCFG_AUX = 143;//设置-s系列双输出预览参数(-s系列双输出2006-04-13)

        public const int NET_DVR_GET_PICCFG_EX = 200;//获取图象参数(SDK_V14扩展命令)
        public const int NET_DVR_SET_PICCFG_EX = 201;//设置图象参数(SDK_V14扩展命令)
        public const int NET_DVR_GET_USERCFG_EX = 202;//获取用户参数(SDK_V15扩展命令)
        public const int NET_DVR_SET_USERCFG_EX = 203;//设置用户参数(SDK_V15扩展命令)
        public const int NET_DVR_GET_COMPRESSCFG_EX = 204;//获取压缩参数(SDK_V15扩展命令2006-05-15)
        public const int NET_DVR_SET_COMPRESSCFG_EX = 205;//设置压缩参数(SDK_V15扩展命令2006-05-15)

        public const int NET_DVR_GET_NETAPPCFG = 222;//获取网络应用参数 NTP/DDNS/EMAIL
        public const int NET_DVR_SET_NETAPPCFG = 223;//设置网络应用参数 NTP/DDNS/EMAIL
        public const int NET_DVR_GET_NTPCFG = 224;//获取网络应用参数 NTP
        public const int NET_DVR_SET_NTPCFG = 225;//设置网络应用参数 NTP
        public const int NET_DVR_GET_DDNSCFG = 226;//获取网络应用参数 DDNS
        public const int NET_DVR_SET_DDNSCFG = 227;//设置网络应用参数 DDNS
        //对应NET_DVR_EMAILPARA
        public const int NET_DVR_GET_EMAILCFG = 228;//获取网络应用参数 EMAIL
        public const int NET_DVR_SET_EMAILCFG = 229;//设置网络应用参数 EMAIL

        public const int NET_DVR_GET_NFSCFG = 230;/* NFS disk config */
        public const int NET_DVR_SET_NFSCFG = 231;/* NFS disk config */

        public const int NET_DVR_GET_SHOWSTRING_EX = 238;//获取叠加字符参数扩展(支持8条字符)
        public const int NET_DVR_SET_SHOWSTRING_EX = 239;//设置叠加字符参数扩展(支持8条字符)
        public const int NET_DVR_GET_NETCFG_OTHER = 244;//获取网络参数
        public const int NET_DVR_SET_NETCFG_OTHER = 245;//设置网络参数

        //对应NET_DVR_EMAILCFG结构
        public const int NET_DVR_GET_EMAILPARACFG = 250;//Get EMAIL parameters
        public const int NET_DVR_SET_EMAILPARACFG = 251;//Setup EMAIL parameters

        public const int NET_DVR_GET_DDNSCFG_EX = 274;//获取扩展DDNS参数
        public const int NET_DVR_SET_DDNSCFG_EX = 275;//设置扩展DDNS参数

        public const int NET_DVR_SET_PTZPOS = 292;//云台设置PTZ位置
        public const int NET_DVR_GET_PTZPOS = 293;//云台获取PTZ位置
        public const int NET_DVR_GET_PTZSCOPE = 294;//云台获取PTZ范围

        public const int NET_DVR_GET_AP_INFO_LIST = 305;//获取无线网络资源参数
        public const int NET_DVR_SET_WIFI_CFG = 306;//设置IP监控设备无线参数
        public const int NET_DVR_GET_WIFI_CFG = 307;//获取IP监控设备无线参数
        public const int NET_DVR_SET_WIFI_WORKMODE = 308;//设置IP监控设备网口工作模式参数
        public const int NET_DVR_GET_WIFI_WORKMODE = 309;//获取IP监控设备网口工作模式参数 
        public const int NET_DVR_GET_WIFI_STATUS = 310;	//获取设备当前wifi连接状态

        /***************************智能服务器 begin *****************************/
        //智能设备类型
        public const int DS6001_HF_B = 60;//异常行为识别：DS6001-HF/B
        public const int DS6001_HF_P = 61;//车牌识别：DS6001-HF/P
        public const int DS6002_HF_B = 62;//双机跟踪：DS6002-HF/B
        public const int DS6101_HF_B = 63;//异常行为识别：DS6101-HF/B
        public const int IDS52XX = 64;//智能分析仪IVMS
        public const int DS9000_IVS = 65;//9000系列智能DVR
        public const int DS8004_AHL_A = 66;//智能ATM, DS8004AHL-S/A
        public const int DS6101_HF_P = 67;//车牌识别：DS6101-HF/P

        //能力获取命令
        public const int VCA_DEV_ABILITY = 256;//设备智能分析的总能力
        public const int VCA_CHAN_ABILITY = 272;//异常行为识别能力
        public const int MATRIXDECODER_ABILITY = 512;//多路解码器显示、解码能力
        //获取/设置大接口参数配置命令
        //车牌识别（NET_VCA_PLATE_CFG）
        public const int NET_DVR_SET_PLATECFG = 150;//设置车牌识别参数
        public const int NET_DVR_GET_PLATECFG = 151;//获取车牌识别参数
        //行为对应（NET_VCA_RULECFG）
        public const int NET_DVR_SET_RULECFG = 152;//设置异常行为识别规则
        public const int NET_DVR_GET_RULECFG = 153;//获取异常行为识别规则

        //双摄像机标定参数（NET_DVR_LF_CFG）
        public const int NET_DVR_SET_LF_CFG = 160;//设置双摄像机的配置参数
        public const int NET_DVR_GET_LF_CFG = 161;//获取双摄像机的配置参数

        //智能分析仪取流配置结构
        public const int NET_DVR_SET_IVMS_STREAMCFG = 162;//设置智能分析仪取流参数
        public const int NET_DVR_GET_IVMS_STREAMCFG = 163;//获取智能分析仪取流参数

        //智能控制参数结构
        public const int NET_DVR_SET_VCA_CTRLCFG = 164;//设置智能控制参数
        public const int NET_DVR_GET_VCA_CTRLCFG = 165;//获取智能控制参数

        //屏蔽区域NET_VCA_MASK_REGION_LIST
        public const int NET_DVR_SET_VCA_MASK_REGION = 166;//设置屏蔽区域参数
        public const int NET_DVR_GET_VCA_MASK_REGION = 167;//获取屏蔽区域参数

        //ATM进入区域 NET_VCA_ENTER_REGION
        public const int NET_DVR_SET_VCA_ENTER_REGION = 168;//设置进入区域参数
        public const int NET_DVR_GET_VCA_ENTER_REGION = 169;//获取进入区域参数

        //标定线配置NET_VCA_LINE_SEGMENT_LIST
        public const int NET_DVR_SET_VCA_LINE_SEGMENT = 170;//设置标定线
        public const int NET_DVR_GET_VCA_LINE_SEGMENT = 171;//获取标定线

        // ivms屏蔽区域NET_IVMS_MASK_REGION_LIST
        public const int NET_DVR_SET_IVMS_MASK_REGION = 172;//设置IVMS屏蔽区域参数
        public const int NET_DVR_GET_IVMS_MASK_REGION = 173;//获取IVMS屏蔽区域参数
        // ivms进入检测区域NET_IVMS_ENTER_REGION
        public const int NET_DVR_SET_IVMS_ENTER_REGION = 174;//设置IVMS进入区域参数
        public const int NET_DVR_GET_IVMS_ENTER_REGION = 175;//获取IVMS进入区域参数

        public const int NET_DVR_SET_IVMS_BEHAVIORCFG = 176;//设置智能分析仪行为规则参数
        public const int NET_DVR_GET_IVMS_BEHAVIORCFG = 177;//获取智能分析仪行为规则参数

        // IVMS 回放检索
        public const int NET_DVR_IVMS_SET_SEARCHCFG = 178;//设置IVMS回放检索参数
        public const int NET_DVR_IVMS_GET_SEARCHCFG = 179;//获取IVMS回放检索参数     

        /***************************DS9000新增命令(_V30) begin *****************************/
        //网络(NET_DVR_NETCFG_V30结构)
        public const int NET_DVR_GET_NETCFG_V30 = 1000;//获取网络参数
        public const int NET_DVR_SET_NETCFG_V30 = 1001;//设置网络参数

        //图象(NET_DVR_PICCFG_V30结构)
        public const int NET_DVR_GET_PICCFG_V30 = 1002;//获取图象参数
        public const int NET_DVR_SET_PICCFG_V30 = 1003;//设置图象参数

        //图象(NET_DVR_PICCFG_V40结构)
        public const int NET_DVR_GET_PICCFG_V40 = 6179;//获取图象参数V40扩展
        public const int NET_DVR_SET_PICCFG_V40 = 6180;//设置图象参数V40扩展

        //录像时间(NET_DVR_RECORD_V30结构)
        public const int NET_DVR_GET_RECORDCFG_V30 = 1004;//获取录像参数
        public const int NET_DVR_SET_RECORDCFG_V30 = 1005;//设置录像参数
        
        public const int NET_DVR_GET_RECORDCFG_V40 = 1008; //获取录像参数(扩展)
        public const int NET_DVR_SET_RECORDCFG_V40 = 1009; //设置录像参数(扩展)

        //用户(NET_DVR_USER_V30结构)
        public const int NET_DVR_GET_USERCFG_V30 = 1006;//获取用户参数
        public const int NET_DVR_SET_USERCFG_V30 = 1007;//设置用户参数

        //9000DDNS参数配置(NET_DVR_DDNSPARA_V30结构)
        public const int NET_DVR_GET_DDNSCFG_V30 = 1010;//获取DDNS(9000扩展)
        public const int NET_DVR_SET_DDNSCFG_V30 = 1011;//设置DDNS(9000扩展)

        //EMAIL功能(NET_DVR_EMAILCFG_V30结构)
        public const int NET_DVR_GET_EMAILCFG_V30 = 1012;//获取EMAIL参数 
        public const int NET_DVR_SET_EMAILCFG_V30 = 1013;//设置EMAIL参数 

        //巡航参数 (NET_DVR_CRUISE_PARA结构)
        public const int NET_DVR_GET_CRUISE = 1020;
        public const int NET_DVR_SET_CRUISE = 1021;

        //报警输入结构参数 (NET_DVR_ALARMINCFG_V30结构)
        public const int NET_DVR_GET_ALARMINCFG_V30 = 1024;
        public const int NET_DVR_SET_ALARMINCFG_V30 = 1025;

        //报警输出结构参数 (NET_DVR_ALARMOUTCFG_V30结构)
        public const int NET_DVR_GET_ALARMOUTCFG_V30 = 1026;
        public const int NET_DVR_SET_ALARMOUTCFG_V30 = 1027;

        //视频输出结构参数 (NET_DVR_VIDEOOUT_V30结构)
        public const int NET_DVR_GET_VIDEOOUTCFG_V30 = 1028;
        public const int NET_DVR_SET_VIDEOOUTCFG_V30 = 1029;

        //叠加字符结构参数 (NET_DVR_SHOWSTRING_V30结构)
        public const int NET_DVR_GET_SHOWSTRING_V30 = 1030;
        public const int NET_DVR_SET_SHOWSTRING_V30 = 1031;

        //异常结构参数 (NET_DVR_EXCEPTION_V30结构)
        public const int NET_DVR_GET_EXCEPTIONCFG_V30 = 1034;
        public const int NET_DVR_SET_EXCEPTIONCFG_V30 = 1035;

        //串口232结构参数 (NET_DVR_RS232CFG_V30结构)
        public const int NET_DVR_GET_RS232CFG_V30 = 1036;
        public const int NET_DVR_SET_RS232CFG_V30 = 1037;

        //网络硬盘接入结构参数 (NET_DVR_NET_DISKCFG结构)
        public const int NET_DVR_GET_NET_DISKCFG = 1038;//网络硬盘接入获取
        public const int NET_DVR_SET_NET_DISKCFG = 1039;//网络硬盘接入设置

        //压缩参数 (NET_DVR_COMPRESSIONCFG_V30结构)
        public const int NET_DVR_GET_COMPRESSCFG_V30 = 1040;
        public const int NET_DVR_SET_COMPRESSCFG_V30 = 1041;

        //获取485解码器参数 (NET_DVR_DECODERCFG_V30结构)
        public const int NET_DVR_GET_DECODERCFG_V30 = 1042;//获取解码器参数
        public const int NET_DVR_SET_DECODERCFG_V30 = 1043;//设置解码器参数

        //获取预览参数 (NET_DVR_PREVIEWCFG_V30结构)
        public const int NET_DVR_GET_PREVIEWCFG_V30 = 1044;//获取预览参数
        public const int NET_DVR_SET_PREVIEWCFG_V30 = 1045;//设置预览参数

        //辅助预览参数 (NET_DVR_PREVIEWCFG_AUX_V30结构)
        public const int NET_DVR_GET_PREVIEWCFG_AUX_V30 = 1046;//获取辅助预览参数
        public const int NET_DVR_SET_PREVIEWCFG_AUX_V30 = 1047;//设置辅助预览参数

        //IP接入配置参数 （NET_DVR_IPPARACFG结构）
        public const int NET_DVR_GET_IPPARACFG = 1048; //获取IP接入配置信息 
        public const int NET_DVR_SET_IPPARACFG = 1049;//设置IP接入配置信息

        //IP接入配置参数 （NET_DVR_IPPARACFG_V40结构）
        public const int NET_DVR_GET_IPPARACFG_V40 = 1062; //获取IP接入配置信息 
        public const int NET_DVR_SET_IPPARACFG_V40 = 1063;//设置IP接入配置信息

        //IP报警输入接入配置参数 （NET_DVR_IPALARMINCFG结构）
        public const int NET_DVR_GET_IPALARMINCFG = 1050; //获取IP报警输入接入配置信息 
        public const int NET_DVR_SET_IPALARMINCFG = 1051; //设置IP报警输入接入配置信息

        //IP报警输出接入配置参数 （NET_DVR_IPALARMOUTCFG结构）
        public const int NET_DVR_GET_IPALARMOUTCFG = 1052;//获取IP报警输出接入配置信息 
        public const int NET_DVR_SET_IPALARMOUTCFG = 1053;//设置IP报警输出接入配置信息

        //硬盘管理的参数获取 (NET_DVR_HDCFG结构)
        public const int NET_DVR_GET_HDCFG = 1054;//获取硬盘管理配置参数
        public const int NET_DVR_SET_HDCFG = 1055;//设置硬盘管理配置参数

        //盘组管理的参数获取 (NET_DVR_HDGROUP_CFG结构)
        public const int NET_DVR_GET_HDGROUP_CFG = 1056;//获取盘组管理配置参数
        public const int NET_DVR_SET_HDGROUP_CFG = 1057;//设置盘组管理配置参数

        //设备编码类型配置(NET_DVR_COMPRESSION_AUDIO结构)
        public const int NET_DVR_GET_COMPRESSCFG_AUD = 1058;//获取设备语音对讲编码参数
        public const int NET_DVR_SET_COMPRESSCFG_AUD = 1059;//设置设备语音对讲编码参数

        //IP接入配置参数 （NET_DVR_IPPARACFG_V31结构）
        public const int NET_DVR_GET_IPPARACFG_V31 = 1060;//获取IP接入配置信息 
        public const int NET_DVR_SET_IPPARACFG_V31 = 1061; //设置IP接入配置信息

        //设备参数配置 （NET_DVR_DEVICECFG_V40结构）
        public const int NET_DVR_GET_DEVICECFG_V40 = 1100;//获取设备参数
        public const int NET_DVR_SET_DEVICECFG_V40 = 1101;//设置设备参数

        //多网卡配置(NET_DVR_NETCFG_MULTI结构)
        public const int NET_DVR_GET_NETCFG_MULTI = 1161;
        public const int NET_DVR_SET_NETCFG_MULTI = 1162;

        //BONDING网卡(NET_DVR_NETWORK_BONDING结构)
        public const int NET_DVR_GET_NETWORK_BONDING = 1254;
        public const int NET_DVR_SET_NETWORK_BONDING = 1255;


        //人脸比对库配置
        public const int NET_DVR_GET_FACELIB_TRIGGER = 3962;   //获取人脸比对库的联动配置
        public const int NET_DVR_SET_FACELIB_TRIGGER = 3963;   //设置人脸比对库的联动配置
        public const int NET_DVR_GET_FACELIB_SCHEDULE = 3977; //获取人脸比对库的布防时间配置
        public const int NET_DVR_SET_FACELIB_SCHEDULE = 3978; //设置人脸比对库的布防时间配置

        //NAT映射配置参数 （NET_DVR_NAT_CFG结构）
        public const int NET_DVR_GET_NAT_CFG = 6111;    //获取NAT映射参数
        public const int NET_DVR_SET_NAT_CFG = 6112;    //设置NAT映射参数  

        //电视墙
        public const int NET_DVR_SET_WINCFG = 1202;//窗口参数设置
        public const int NET_DVR_MATRIX_BIGSCREENCFG_GET = 1140; //获取大屏拼接参数
        public const int NET_DVR_MATRIX_BIGSCREENCFG_SET = 1141; //设置大屏拼接参数

        public const int NET_DVR_MATRIX_WALL_GET = 9002;  //获取电视墙中屏幕参数
        public const int NET_DVR_MATRIX_WALL_SET = 9001;  //设置电视墙中屏幕参数

        public const int NET_DVR_WALLWIN_GET = 9003;  //获取电视墙窗口参数
        public const int NET_DVR_WALLWIN_SET = 9004;  //设置电视墙窗口参数

        public const int NET_DVR_WALLWINPARAM_SET = 9005;  //获取电视墙窗口相关参数
        public const int NET_DVR_WALLWINPARAM_GET = 9006;  //设置电视墙窗口相关参数

        public const int NET_DVR_SWITCH_WIN_TOP = 9017;  //窗口置顶
        public const int NET_DVR_SWITCH_WIN_BOTTOM = 9018;  //窗口置底

        public const int NET_DVR_GET_VIDEOWALLDISPLAYPOSITION = 1734;//获取显示输出位置参数
        public const int NET_DVR_SET_VIDEOWALLDISPLAYPOSITION = 1733;//设置显示输出位置参数

        public const int NET_DVR_GET_VIDEOWALLDISPLAYNO = 1732;  //获取设备显示输出号

        public const int NET_DVR_GET_VIDEOWALLWINDOWPOSITION = 1735; //获取电视墙窗口参数
        public const int NET_DVR_SET_VIDEOWALLWINDOWPOSITION = 1736; //设置电视墙窗口参数

        public const int NET_DVR_GET_CHAN_RELATION = 9209;     //获取编码通道关联资源参数
        public const int NET_DVR_SET_CHAN_RELATION = 9210;     //设置编码通道关联资源参数
        public const int NET_DVR_GET_ALL_CHAN_RELATION = 9211; //获取所有编码通道关联资源参数

        public const int NET_DVR_GET_VW_SCENE_PARAM = 1746; //获取电视墙场景模式参数
        public const int NET_DVR_SET_VW_SCENE_PARAM = 1747; //设置电视墙场景模式参数

        public const int NET_DVR_GET_OUTPUT_PIC_WIN_CFG = 9202;    //获取输出口图片窗口参数
        public const int NET_DVR_SET_OUTPUT_PIC_WIN_CFG = 9203;    //设置输出口图片窗口参数

        public const int NET_DVR_GET_OUTPUT_OSD_CFG = 9206;    //获取输出口OSD参数
        public const int NET_DVR_SET_OUTPUT_OSD_CFG = 9207;    //设置输出口OSD参数

        public const int NET_DVR_SCENE_CONTROL = 1744; //场景控制


        public const int NET_DVR_GET_CARD = 2560;
        public const int NET_DVR_SET_CARD = 2561;
        public const int NET_DVR_DEL_CARD = 2562;
        public const int NET_DVR_GET_FINGERPRINT = 2563;
        public const int NET_DVR_SET_FINGERPRINT = 2564;
        public const int NET_DVR_DEL_FINGERPRINT = 2565;
        public const int NET_DVR_GET_FACE = 2566;
        public const int NET_DVR_SET_FACE = 2567;

        public const int NET_DVR_DEL_FACE_PARAM_CFG = 2509;      //delete face param configure
        public const int NET_DVR_CAPTURE_FACE_INFO = 2510;       //capture face information

        //预置点名称获取与设置
        public const int NET_DVR_GET_PRESET_NAME = 3383;  //获取预置点名称
        public const int NET_DVR_SET_PRESET_NAME = 3382;  //设置预置点名称

        public const int NET_DVR_GET_PRESETCFG = 3224;  //获取预置点参数
        public const int NET_DVR_GET_PRESET_NUM = 3226;  //获取预置点个数

        public const int NET_VCA_GET_RULECFG_V41 = 5011; //获取异常行为识别参数
        public const int NET_VCA_SET_RULECFG_V41 = 5012; //设置异常行为识别参数

        public const int NET_DVR_GET_TRAVERSE_PLANE_DETECTION = 3360; //获取越界侦测配置
        public const int NET_DVR_SET_TRAVERSE_PLANE_DETECTION = 3361; //设置越界侦测配置

        public const int NET_DVR_GET_THERMOMETRY_ALARMRULE = 3627; //获取预置点测温报警规则配置
        public const int NET_DVR_SET_THERMOMETRY_ALARMRULE = 3628; //设置预置点测温报警规则配置     
        public const int NET_DVR_GET_THERMOMETRY_TRIGGER = 3632; //获取测温联动配置
        public const int NET_DVR_SET_THERMOMETRY_TRIGGER = 3633; //设置测温联动配置

        public const int NET_DVR_SET_MANUALTHERM_BASICPARAM = 6716;  //设置手动测温基本参数
        public const int NET_DVR_GET_MANUALTHERM_BASICPARAM = 6717;  //获取手动测温基本参数

        public const int NET_DVR_SET_MANUALTHERM = 6708; //设置手动测温数据设置

        public const int NET_DVR_GET_MULTI_STREAM_COMPRESSIONCFG = 3216; //远程获取多码流压缩参数
        public const int NET_DVR_SET_MULTI_STREAM_COMPRESSIONCFG = 3217; //远程设置多码流压缩参数 

        public const int NET_DVR_VIDEO_CALL_SIGNAL_PROCESS = 16032;  //可视话对讲信令处理

        public const int NET_DVR_ARM_ALARMHOST_SUBSYSTEM = 2036;//按布防类型对子系统布防
        
        public const int NET_DVR_GET_MULTI_CARD_CFG_V50 = 2515;    //获取多重卡参数V50
        public const int NET_DVR_SET_MULTI_CARD_CFG_V50  = 2516;    //设置多重卡参数V50

        public const int NET_DVR_BARRIERGATE_CTRL = 3128; //道闸控制

        public const int NET_DVR_INQUEST_GET_CDW_STATUS = 6350;  //获取审讯机刻录状态-长连接

        public const int NET_DVR_GET_REALTIME_THERMOMETRY = 3629;    //实时温度检测

        public const int NET_DVR_GET_ACS_EVENT = 2514;//设备事件获取

        public const int NET_SDK_GET_NEXT_STATUS_SUCCESS = 1000;
        public const int NET_SDK_GET_NEXT_STATUS_NEED_WAIT = 1001;
        public const int NET_SDK_GET_NEXT_STATUS_FINISH = 1002;
        public const int NET_SDK_GET_NEXT_STATUS_FAILED = 1003;
        /*************************参数配置命令 end*******************************/


        /************************DVR日志 begin***************************/
        /* 报警 */
        //主类型
        public const int MAJOR_ALARM = 1;
        //次类型
        public const int MINOR_ALARM_IN = 1;/* 报警输入 */
        public const int MINOR_ALARM_OUT = 2;/* 报警输出 */
        public const int MINOR_MOTDET_START = 3; /* 移动侦测报警开始 */
        public const int MINOR_MOTDET_STOP = 4; /* 移动侦测报警结束 */
        public const int MINOR_HIDE_ALARM_START = 5;/* 遮挡报警开始 */
        public const int MINOR_HIDE_ALARM_STOP = 6;/* 遮挡报警结束 */
        public const int MINOR_VCA_ALARM_START = 7;/*智能报警开始*/
        public const int MINOR_VCA_ALARM_STOP = 8;/*智能报警停止*/

        /* 异常 */
        //主类型
        public const int MAJOR_EXCEPTION = 2;
        //次类型
        public const int MINOR_VI_LOST = 33;/* 视频信号丢失 */
        public const int MINOR_ILLEGAL_ACCESS = 34;/* 非法访问 */
        public const int MINOR_HD_FULL = 35;/* 硬盘满 */
        public const int MINOR_HD_ERROR = 36;/* 硬盘错误 */
        public const int MINOR_DCD_LOST = 37;/* MODEM 掉线(保留不使用) */
        public const int MINOR_IP_CONFLICT = 38;/* IP地址冲突 */
        public const int MINOR_NET_BROKEN = 39;/* 网络断开*/
        public const int MINOR_REC_ERROR = 40;/* 录像出错 */
        public const int MINOR_IPC_NO_LINK = 41;/* IPC连接异常 */
        public const int MINOR_VI_EXCEPTION = 42;/* 视频输入异常(只针对模拟通道) */
        public const int MINOR_IPC_IP_CONFLICT = 43;/*ipc ip 地址 冲突*/

        //视频综合平台
        public const int MINOR_FANABNORMAL = 49;/* 视频综合平台：风扇状态异常 */
        public const int MINOR_FANRESUME = 50;/* 视频综合平台：风扇状态恢复正常 */
        public const int MINOR_SUBSYSTEM_ABNORMALREBOOT = 51;/* 视频综合平台：6467异常重启 */
        public const int MINOR_MATRIX_STARTBUZZER = 52;/* 视频综合平台：dm6467异常，启动蜂鸣器 */

        /* 操作 */
        //主类型
        public const int MAJOR_OPERATION = 3;
        //次类型
        public const int MINOR_START_DVR = 65;/* 开机 */
        public const int MINOR_STOP_DVR = 66;/* 关机 */
        public const int MINOR_STOP_ABNORMAL = 67;/* 异常关机 */
        public const int MINOR_REBOOT_DVR = 68;/*本地重启设备*/

        public const int MINOR_LOCAL_LOGIN = 80;/* 本地登陆 */
        public const int MINOR_LOCAL_LOGOUT = 81;/* 本地注销登陆 */
        public const int MINOR_LOCAL_CFG_PARM = 82;/* 本地配置参数 */
        public const int MINOR_LOCAL_PLAYBYFILE = 83;/* 本地按文件回放或下载 */
        public const int MINOR_LOCAL_PLAYBYTIME = 84;/* 本地按时间回放或下载*/
        public const int MINOR_LOCAL_START_REC = 85;/* 本地开始录像 */
        public const int MINOR_LOCAL_STOP_REC = 86;/* 本地停止录像 */
        public const int MINOR_LOCAL_PTZCTRL = 87;/* 本地云台控制 */
        public const int MINOR_LOCAL_PREVIEW = 88;/* 本地预览 (保留不使用)*/
        public const int MINOR_LOCAL_MODIFY_TIME = 89;/* 本地修改时间(保留不使用) */
        public const int MINOR_LOCAL_UPGRADE = 90;/* 本地升级 */
        public const int MINOR_LOCAL_RECFILE_OUTPUT = 91;/* 本地备份录象文件 */
        public const int MINOR_LOCAL_FORMAT_HDD = 92;/* 本地初始化硬盘 */
        public const int MINOR_LOCAL_CFGFILE_OUTPUT = 93;/* 导出本地配置文件 */
        public const int MINOR_LOCAL_CFGFILE_INPUT = 94;/* 导入本地配置文件 */
        public const int MINOR_LOCAL_COPYFILE = 95;/* 本地备份文件 */
        public const int MINOR_LOCAL_LOCKFILE = 96;/* 本地锁定录像文件 */
        public const int MINOR_LOCAL_UNLOCKFILE = 97;/* 本地解锁录像文件 */
        public const int MINOR_LOCAL_DVR_ALARM = 98;/* 本地手动清除和触发报警*/
        public const int MINOR_IPC_ADD = 99;/* 本地添加IPC */
        public const int MINOR_IPC_DEL = 100;/* 本地删除IPC */
        public const int MINOR_IPC_SET = 101;/* 本地设置IPC */
        public const int MINOR_LOCAL_START_BACKUP = 102;/* 本地开始备份 */
        public const int MINOR_LOCAL_STOP_BACKUP = 103;/* 本地停止备份*/
        public const int MINOR_LOCAL_COPYFILE_START_TIME = 104;/* 本地备份开始时间*/
        public const int MINOR_LOCAL_COPYFILE_END_TIME = 105;/* 本地备份结束时间*/
        public const int MINOR_LOCAL_ADD_NAS = 106;/*本地添加网络硬盘*/
        public const int MINOR_LOCAL_DEL_NAS = 107;/* 本地删除nas盘*/
        public const int MINOR_LOCAL_SET_NAS = 108;/* 本地设置nas盘*/

        public const int MINOR_REMOTE_LOGIN = 112;/* 远程登录 */
        public const int MINOR_REMOTE_LOGOUT = 113;/* 远程注销登陆 */
        public const int MINOR_REMOTE_START_REC = 114;/* 远程开始录像 */
        public const int MINOR_REMOTE_STOP_REC = 115;/* 远程停止录像 */
        public const int MINOR_START_TRANS_CHAN = 116;/* 开始透明传输 */
        public const int MINOR_STOP_TRANS_CHAN = 117;/* 停止透明传输 */
        public const int MINOR_REMOTE_GET_PARM = 118;/* 远程获取参数 */
        public const int MINOR_REMOTE_CFG_PARM = 119;/* 远程配置参数 */
        public const int MINOR_REMOTE_GET_STATUS = 120;/* 远程获取状态 */
        public const int MINOR_REMOTE_ARM = 121;/* 远程布防 */
        public const int MINOR_REMOTE_DISARM = 122;/* 远程撤防 */
        public const int MINOR_REMOTE_REBOOT = 123;/* 远程重启 */
        public const int MINOR_START_VT = 124;/* 开始语音对讲 */
        public const int MINOR_STOP_VT = 125;/* 停止语音对讲 */
        public const int MINOR_REMOTE_UPGRADE = 126;/* 远程升级 */
        public const int MINOR_REMOTE_PLAYBYFILE = 127;/* 远程按文件回放 */
        public const int MINOR_REMOTE_PLAYBYTIME = 128;/* 远程按时间回放 */
        public const int MINOR_REMOTE_PTZCTRL = 129;/* 远程云台控制 */
        public const int MINOR_REMOTE_FORMAT_HDD = 130;/* 远程格式化硬盘 */
        public const int MINOR_REMOTE_STOP = 131;/* 远程关机 */
        public const int MINOR_REMOTE_LOCKFILE = 132;/* 远程锁定文件 */
        public const int MINOR_REMOTE_UNLOCKFILE = 133;/* 远程解锁文件 */
        public const int MINOR_REMOTE_CFGFILE_OUTPUT = 134;/* 远程导出配置文件 */
        public const int MINOR_REMOTE_CFGFILE_INTPUT = 135;/* 远程导入配置文件 */
        public const int MINOR_REMOTE_RECFILE_OUTPUT = 136;/* 远程导出录象文件 */
        public const int MINOR_REMOTE_DVR_ALARM = 137;/* 远程手动清除和触发报警*/
        public const int MINOR_REMOTE_IPC_ADD = 138;/* 远程添加IPC */
        public const int MINOR_REMOTE_IPC_DEL = 139;/* 远程删除IPC */
        public const int MINOR_REMOTE_IPC_SET = 140;/* 远程设置IPC */
        public const int MINOR_REBOOT_VCA_LIB = 141;/*重启智能库*/
        public const int MINOR_REMOTE_ADD_NAS = 142;/* 远程添加nas盘*/
        public const int MINOR_REMOTE_DEL_NAS = 143;/* 远程删除nas盘*/
        public const int MINOR_REMOTE_SET_NAS = 144;/* 远程设置nas盘*/

        //2009-12-16 增加视频综合平台日志类型
        public const int MINOR_SUBSYSTEMREBOOT = 160;/*视频综合平台：dm6467 正常重启*/
        public const int MINOR_MATRIX_STARTTRANSFERVIDEO = 161;	/*视频综合平台：矩阵切换开始传输图像*/
        public const int MINOR_MATRIX_STOPTRANSFERVIDEO = 162;	/*视频综合平台：矩阵切换停止传输图像*/
        public const int MINOR_REMOTE_SET_ALLSUBSYSTEM = 163;	/*视频综合平台：设置所有6467子系统信息*/
        public const int MINOR_REMOTE_GET_ALLSUBSYSTEM = 164;	/*视频综合平台：获取所有6467子系统信息*/
        public const int MINOR_REMOTE_SET_PLANARRAY = 165;	/*视频综合平台：设置计划轮询组*/
        public const int MINOR_REMOTE_GET_PLANARRAY = 166;	/*视频综合平台：获取计划轮询组*/
        public const int MINOR_MATRIX_STARTTRANSFERAUDIO = 167;	/*视频综合平台：矩阵切换开始传输音频*/
        public const int MINOR_MATRIX_STOPRANSFERAUDIO = 168;	/*视频综合平台：矩阵切换停止传输音频*/
        public const int MINOR_LOGON_CODESPITTER = 169;	/*视频综合平台：登陆码分器*/
        public const int MINOR_LOGOFF_CODESPITTER = 170;	/*视频综合平台：退出码分器*/

        //2010-12-16 报警板日志
        public const int MINOR_REMOTE_BYPASS             = 0xd0;    /* 远程旁路*/
        public const int MINOR_REMOTE_UNBYPASS           = 0xd1;    /* 远程旁路恢复*/
        public const int MINOR_REMOTE_SET_ALARMIN_CFG    = 0xd2;    /* 远程设置报警输入参数*/
        public const int MINOR_REMOTE_GET_ALARMIN_CFG    = 0xd3;    /* 远程获取报警输入参数*/
        public const int MINOR_REMOTE_SET_ALARMOUT_CFG   = 0xd4;    /* 远程设置报警输出参数*/
        public const int MINOR_REMOTE_GET_ALARMOUT_CFG   = 0xd5;    /* 远程获取报警输出参数*/
        public const int MINOR_REMOTE_ALARMOUT_OPEN_MAN  = 0xd6;    /* 远程手动开启报警输出*/
        public const int MINOR_REMOTE_ALARMOUT_CLOSE_MAN = 0xd7;    /* 远程手动关闭报警输出*/
        public const int MINOR_REMOTE_ALARM_ENABLE_CFG   = 0xd8;    /* 远程设置报警主机的RS485串口使能状态*/
        public const int MINOR_DBDATA_OUTPUT             = 0xd9;    /* 导出数据库记录 */
        public const int MINOR_DBDATA_INPUT              = 0xda;    /* 导入数据库记录 */
        public const int MINOR_MU_SWITCH                 = 0xdb;    /* 级联切换 */
        public const int MINOR_MU_PTZ                    = 0xdc;    /* 级联PTZ控制 */
        public const int MINOR_DELETE_LOGO               = 0xdd;    /* 删除logo */
        public const int MINOR_REMOTE_INQUEST_DEL_FILE   = 0xde;       /*远程删除文件*/

        /*日志附加信息*/
        //主类型
        public const int MAJOR_INFORMATION = 4;/*附加信息*/
        //次类型
        public const int MINOR_HDD_INFO = 161;/*硬盘信息*/
        public const int MINOR_SMART_INFO = 162;/*SMART信息*/
        public const int MINOR_REC_START = 163;/*开始录像*/
        public const int MINOR_REC_STOP = 164;/*停止录像*/
        public const int MINOR_REC_OVERDUE = 165;/*过期录像删除*/
        public const int MINOR_LINK_START = 166;//连接前端设备
        public const int MINOR_LINK_STOP = 167;//断开前端设备　
        public const int MINOR_NET_DISK_INFO = 168;//网络硬盘信息

        //当日志的主类型为MAJOR_OPERATION=03，次类型为MINOR_LOCAL_CFG_PARM=0x52或者MINOR_REMOTE_GET_PARM=0x76或者MINOR_REMOTE_CFG_PARM=0x77时，dwParaType:参数类型有效，其含义如下：
        public const int PARA_VIDEOOUT = 1;
        public const int PARA_IMAGE = 2;
        public const int PARA_ENCODE = 4;
        public const int PARA_NETWORK = 8;
        public const int PARA_ALARM = 16;
        public const int PARA_EXCEPTION = 32;
        public const int PARA_DECODER = 64;/*解码器*/
        public const int PARA_RS232 = 128;
        public const int PARA_PREVIEW = 256;
        public const int PARA_SECURITY = 512;
        public const int PARA_DATETIME = 1024;
        public const int PARA_FRAMETYPE = 2048;/*帧格式*/
        //vca
        public const int PARA_VCA_RULE = 4096;//行为规则
        /************************DVR日志 End***************************/


        /*******************查找文件和日志函数返回值*************************/
        public const int NET_DVR_FILE_SUCCESS = 1000;//获得文件信息
        public const int NET_DVR_FILE_NOFIND = 1001;//没有文件
        public const int NET_DVR_ISFINDING = 1002;//正在查找文件
        public const int NET_DVR_NOMOREFILE = 1003;//查找文件时没有更多的文件
        public const int NET_DVR_FILE_EXCEPTION = 1004;//查找文件时异常

        /*********************回调函数类型 begin************************/
        public const int COMM_ALARM = 0x1100;//8000报警信息主动上传，对应NET_DVR_ALARMINFO
        public const int COMM_ALARM_RULE = 0x1102;//异常行为识别报警信息，对应NET_VCA_RULE_ALARM
        public const int COMM_ALARM_PDC = 0x1103;//人流量统计报警上传，对应NET_DVR_PDC_ALRAM_INFO
        public const int COMM_ALARM_ALARMHOST = 0x1105;//网络报警主机报警上传，对应NET_DVR_ALARMHOST_ALARMINFO
        public const int COMM_ALARM_FACE = 0x1106;//人脸检测识别报警信息，对应NET_DVR_FACEDETECT_ALARM
        public const int COMM_RULE_INFO_UPLOAD = 0x1107;  // 事件数据信息上传
        public const int COMM_ALARM_AID = 0x1110;  //交通事件报警信息
        public const int COMM_ALARM_TPS = 0x1111;  //交通参数统计报警信息
        public const int COMM_UPLOAD_FACESNAP_RESULT = 0x1112;  //人脸识别结果上传
        public const int COMM_ALARM_FACE_DETECTION = 0x4010; //人脸侦测报警信息
        public const int COMM_ALARM_TFS = 0x1113;  //交通取证报警信息
        public const int COMM_ALARM_TPS_V41 = 0x1114;  //交通参数统计报警信息扩展
        public const int COMM_ALARM_AID_V41 = 0x1115;  //交通事件报警信息扩展
        public const int COMM_ALARM_VQD_EX = 0x1116;	 //视频质量诊断报警
        public const int COMM_SENSOR_VALUE_UPLOAD = 0x1120;  //模拟量数据实时上传
        public const int COMM_SENSOR_ALARM = 0x1121;  //模拟量报警上传
        public const int COMM_SWITCH_ALARM = 0x1122;	 //开关量报警
        public const int COMM_ALARMHOST_EXCEPTION = 0x1123; //报警主机故障报警
        public const int COMM_ALARMHOST_OPERATEEVENT_ALARM = 0x1124;  //操作事件报警上传
        public const int COMM_ALARMHOST_SAFETYCABINSTATE = 0x1125;	 //防护舱状态
        public const int COMM_ALARMHOST_ALARMOUTSTATUS = 0x1126;	 //报警输出口/警号状态
        public const int COMM_ALARMHOST_CID_ALARM = 0x1127;	 //CID报告报警上传
        public const int COMM_ALARMHOST_EXTERNAL_DEVICE_ALARM = 0x1128;	 //报警主机外接设备报警上传
        public const int COMM_ALARMHOST_DATA_UPLOAD = 0x1129;	 //报警数据上传
        public const int COMM_UPLOAD_VIDEO_INTERCOM_EVENT = 0x1132;  //可视对讲事件记录上传
        public const int COMM_ALARM_AUDIOEXCEPTION = 0x1150;	 //声音报警信息
        public const int COMM_ALARM_DEFOCUS = 0x1151;	 //虚焦报警信息
        public const int COMM_ALARM_BUTTON_DOWN_EXCEPTION = 0x1152;	 //按钮按下报警信息
        public const int COMM_ALARM_ALARMGPS = 0x1202; //GPS报警信息上传
        public const int COMM_TRADEINFO = 0x1500;  //ATMDVR主动上传交易信息
        public const int COMM_UPLOAD_PLATE_RESULT = 0x2800;	 //上传车牌信息
        public const int COMM_ITC_STATUS_DETECT_RESULT = 0x2810;  //实时状态检测结果上传(智能高清IPC)
        public const int COMM_IPC_AUXALARM_RESULT = 0x2820;  //PIR报警、无线报警、呼救报警上传
        public const int COMM_UPLOAD_PICTUREINFO = 0x2900;	 //上传图片信息
        public const int COMM_SNAP_MATCH_ALARM = 0x2902;  //禁止名单比对结果上传
        public const int COMM_ITS_PLATE_RESULT = 0x3050;  //终端图片上传
        public const int COMM_ITS_TRAFFIC_COLLECT = 0x3051;  //终端统计数据上传
        public const int COMM_ITS_GATE_VEHICLE = 0x3052;  //出入口车辆抓拍数据上传
        public const int COMM_ITS_GATE_FACE = 0x3053; //出入口人脸抓拍数据上传
        public const int COMM_ITS_GATE_COSTITEM = 0x3054;  //出入口过车收费明细 2013-11-19
        public const int COMM_ITS_GATE_HANDOVER = 0x3055; //出入口交接班数据 2013-11-19
        public const int COMM_ITS_PARK_VEHICLE = 0x3056;  //停车场数据上传
        public const int COMM_ITS_BLOCKLIST_ALARM = 0x3057;  //禁止名单报警上传
        public const int COMM_ALARM_TPS_REAL_TIME = 0x3081;  //TPS实时过车数据上传
        public const int COMM_ALARM_TPS_STATISTICS = 0x3082;  //TPS统计过车数据上传
        public const int COMM_ALARM_V30 = 0x4000;	 //9000报警信息主动上传
        public const int COMM_IPCCFG = 0x4001;	 //9000设备IPC接入配置改变报警信息主动上传
        public const int COMM_IPCCFG_V31 = 0x4002;	 //9000设备IPC接入配置改变报警信息主动上传扩展 9000_1.1
        public const int COMM_IPCCFG_V40 = 0x4003; // IVMS 2000 编码服务器 NVR IPC接入配置改变时报警信息上传
        public const int COMM_ALARM_DEVICE = 0x4004;  //设备报警内容，由于通道值大于256而扩展
        public const int COMM_ALARM_CVR = 0x4005;  //CVR 2.0.X外部报警类型
        public const int COMM_ALARM_HOT_SPARE = 0x4006;  //热备异常报警（N+1模式异常报警）
        public const int COMM_ALARM_V40 = 0x4007;	//移动侦测，视频丢失，遮挡，IO信号量等报警信息主动上传，报警数据为可变长
        public const int COMM_UPLOAD_HEATMAP_RESULT = 0x4008; //热度图报警上传

        public const int COMM_ITS_ROAD_EXCEPTION = 0x4500;	 //路口设备异常报警
        public const int COMM_ITS_EXTERNAL_CONTROL_ALARM = 0x4520;  //外控报警
        public const int COMM_FIREDETECTION_ALARM = 0x4991;  //火点检测报警
        public const int COMM_SCREEN_ALARM = 0x5000;  //多屏控制器报警类型
        public const int COMM_DVCS_STATE_ALARM = 0x5001;  //分布式大屏控制器报警上传
        public const int COMM_ALARM_VQD = 0x6000;  //VQD主动报警上传 
        public const int COMM_PUSH_UPDATE_RECORD_INFO = 0x6001;  //推模式录像信息上传
        public const int COMM_DIAGNOSIS_UPLOAD = 0x5100;  //诊断服务器VQD报警上传
        public const int COMM_ALARM_ACS = 0x5002;  //门禁主机报警
        public const int COMM_ID_INFO_ALARM = 0x5200;  //身份证信息上传
        public const int COMM_PASSNUM_INFO_ALARM = 0x5201;  //通行人数上报
        public const int COMM_ISAPI_ALARM = 0x6009;

        public const int COMM_THERMOMETRY_ALARM = 0x5212; //温度报警信息

        public const int COMM_UPLOAD_AIOP_VIDEO         =  0x4021; //设备支持AI开放平台接入，上传视频检测数据
        public const int COMM_UPLOAD_AIOP_PICTURE       =  0x4022; //设备支持AI开放平台接入，上传图片检测数据
        public const int COMM_UPLOAD_AIOP_POLLING_SNAP = 0x4023; //设备支持AI开放平台接入，上传轮巡抓图图片检测数据 对应的结构体(NET_AIOP_POLLING_SNAP_HEAD)
        public const int COMM_UPLOAD_AIOP_POLLING_VIDEO = 0x4024; //设备支持AI开放平台接入，上传轮巡视频检测数据 对应的结构体(NET_AIOP_POLLING_VIDEO_HEAD)

		

		public const int NET_DVR_JSON_CONFIG = 2550;
        public const int NET_DVR_FACE_DATA_RECORD = 2551;
        public const int NET_DVR_FACE_DATA_SEARCH = 2552;
        public const int NET_DVR_FACE_DATA_MODIFY = 2553;
		
		public const int NET_DVR_REMOTECONTROL_GATEWAY      =      16009;  //远程开锁
		
		



        // 用户调用SendwithRecv接口时，接口返回的状态
        public enum NET_SDK_SENDWITHRECV_STATUS
        {
            NET_SDK_CONFIG_STATUS_SUCCESS = 1000,    // 成功读取到数据，客户端处理完本次数据后需要再次调用NET_DVR_SendWithRecvRemoteConfig获取下一条数据
            NET_SDK_CONFIG_STATUS_NEEDWAIT,          // 配置等待，客户端可重新NET_DVR_SendWithRecvRemoteConfig
            NET_SDK_CONFIG_STATUS_FINISH,            // 数据全部取完，此时客户端可调用NET_DVR_StopRemoteConfig结束
            NET_SDK_CONFIG_STATUS_FAILED,            // 配置失败，客户端可重新NET_DVR_SendWithRecvRemoteConfig
            NET_SDK_CONFIG_STATUS_EXCEPTION,         // 配置异常，此时客户端可调用NET_DVR_StopRemoteConfig结束
        }
		
		
		

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_JSON_DATA_CFG
        {
            public uint dwSize;                    //size of NET_DVR_JSON_DATA_CFG
            public IntPtr lpJsonData;                //Json data
            public uint dwJsonDataSize;            //Json data size
            public IntPtr lpPicData;                //picture data
            public uint dwPicDataSize;            //picture data size
            public uint dwInfraredFacePicSize;            //infrared picture data size
            public IntPtr lpInfraredFacePicBuffer;                //infrared picture data
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 248)]
            public byte[] byRes;  //reserve
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CAPTURE_FACE_COND
        {
            public int dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public void init()
            {
                byRes = new byte[128];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CAPTURE_FACE_CFG
        {
            public int dwSize;
            public int dwFaceTemplate1Size;//人脸模板1数据大小，等于0时，代表无人脸模板1数据
            public IntPtr pFaceTemplate1Buffer;//人脸模板1数据缓存（不大于2.5k）
            public int dwFaceTemplate2Size;//人脸模板2数据大小，等于0时，代表无人脸模板2数据
            public IntPtr pFaceTemplate2Buffer; //人脸模板2数据缓存（不大于2.5K）
            public int dwFacePicSize;//人脸图片数据大小，等于0时，代表无人脸图片数据;
            public IntPtr pFacePicBuffer;//人脸图片数据缓存;
            public byte byFaceQuality1;//人脸质量，范围1-100
            public byte byFaceQuality2;//人脸质量，范围1-100
            public byte byCaptureProgress;    //采集进度，目前只有两种进度值：0-未采集到人脸，100-采集到人脸（只有在进度为100时，才解析人脸信息）
            public byte byRes1;
            public int dwInfraredFacePicSize;   //红外人脸图片数据大小，等于0时，代表无人脸图片数据
            public IntPtr pInfraredFacePicBuffer;      //红外人脸图片数据缓存
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 116, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public void init()
            {
                byRes = new byte[116];
            }
        }


        public const int ERROR_MSG_LEN = 32;
        public const int MAX_FINGER_PRINT_LEN = 768;
        public const int NET_DVR_CAPTURE_FINGERPRINT_INFO = 2504;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FINGERPRINT_STATUS
        {
            public int dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = ACS_CARD_NO_LEN)]
            public byte[] byCardNo;
            public byte byCardReaderRecvStatus;//指纹读卡器状态，按字节表示，0-失败，1-成功，2-该指纹模组不在线，3-重试或指纹质量差，4-内存已满，5-已存在该指纹，6-已存在该指纹ID，7-非法指纹ID，8-该指纹模组无需配置
            public byte byFingerPrintID;//手指编号，有效值范围为1-10
            public byte byFingerType;//指纹类型  0-普通指纹，1-胁迫指纹
            public byte byRecvStatus;//主机错误状态：0-成功，1-手指编号错误，2-指纹类型错误，3-卡号错误（卡号规格不符合设备要求），4-指纹未关联工号或卡号（工号或卡号字段为空），5-工号不存在，6-指纹数据长度为0，7-读卡器编号错误，8-工号错误
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = ERROR_MSG_LEN)]
            public byte[] byErrorMsg;//下发错误信息，当byCardReaderRecvStatus为5时，表示已存在指纹对应的卡号
            public int dwCardReaderNo;//当byCardReaderRecvStatus为5时，表示已存在指纹对应的指纹读卡器编号，可用于下发错误返回。0时表示无错误信息
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20)]
            public byte[] byRes;
            public void init()
            {
                byCardNo = new byte[ACS_CARD_NO_LEN];
                byErrorMsg = new byte[ERROR_MSG_LEN];

                byRes = new byte[20];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FINGERPRINT_RECORD
        {
            public int dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = ACS_CARD_NO_LEN)]
            public byte[] byCardNo; //指纹关联的卡号
            public int dwFingerPrintLen; //指纹数据长度
            public int dwEnableReaderNo;//需要下发指纹的读卡器编号
            public byte byFingerPrintID;//手指编号，有效值范围为1-10
            public byte byFingerType;//指纹类型  0-普通指纹，1-胁迫指纹
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 30)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_FINGER_PRINT_LEN)]
            public byte[] byFingerData;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 96)]
            public byte[] byRes;
            public void init()
            {
                byCardNo = new byte[ACS_CARD_NO_LEN];
                byRes1 = new byte[30];
                byFingerData = new byte[MAX_FINGER_PRINT_LEN];
                byRes = new byte[96];
            }
        }


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FINGER_PRINT_INFO_CTRL_V50_ByCardNo
        {
            public int dwSize;
            public byte byMode;  //删除方式，0-按卡号（人员ID）方式删除，1-按读卡器删除
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] byRes1;
            public NET_DVR_FINGER_PRINT_BYCARD_V50 struProcessMode;//处理方式
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] byRes;
            public void init()
            {
                byRes1 = new byte[3];
                byRes = new byte[64];
                struProcessMode.init();
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FINGER_PRINT_BYCARD_V50
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = ACS_CARD_NO_LEN)]
            public byte[] byCardNo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CARD_READER_NUM_512)]
            public byte[] byEnableCardReader;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_FINGER_PRINT_NUM)]
            public byte[] byFingerPrintID;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NET_SDK_EMPLOYEE_NO_LEN)]
            public byte[] byEmployeeNo;
            public void init()
            {
                byCardNo = new byte[ACS_CARD_NO_LEN];
                byEnableCardReader = new byte[MAX_CARD_READER_NUM_512];
                byFingerPrintID = new byte[MAX_FINGER_PRINT_NUM];
                byRes1 = new byte[2];
                byEmployeeNo = new byte[NET_SDK_EMPLOYEE_NO_LEN];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FINGER_PRINT_INFO_STATUS_V50
        {
            public int dwSize;
            public int dwCardReaderNo;
            public byte byStatus;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 63)]
            public byte[] byRes;
            public void init()
            {
                byRes = new byte[63];
            }
        }




        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CAPTURE_FINGERPRINT_COND
        {
            public int dwSize;
            public byte byFingerPrintPicType;    //图片类型：0-无意义
            public byte byFingerNo;              //手指编号，范围1-10
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 126)]
            public byte[] byRes;

            public void init()
            {
                byRes = new byte[126];
            }
        }


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CAPTURE_FINGERPRINT_CFG
        {
            public int dwSize;
            public int dwFingerPrintDataSize;    //指纹数据大小
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_FINGER_PRINT_LEN)]
            public byte[] byFingerData;        //指纹数据内容
            public int dwFingerPrintPicSize;    //指纹图片大小，等于0时，代表无指纹图片数据
            public IntPtr pFingerPrintPicBuffer;       //指纹图片缓存
            public byte byFingerNo;              //手指编号，范围1-10
            public byte byFingerPrintQuality;    //指纹质量，范围1-100
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 62)]
            public byte[] byRes;

            public void init()
            {
                byFingerData = new byte[MAX_FINGER_PRINT_LEN];
                byRes = new byte[62];
            }
        }




		//Network Configure Structure(V50)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NETCFG_V50
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ETHERNET, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ETHERNET_V30[] struEtherNet;        //Network Port
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPADDR[] struRes1;                            /*reserve*/
            public NET_DVR_IPADDR struAlarmHostIpAddr;                    /* IP address of remote management host */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                                        /* reserve */
            public ushort wAlarmHostIpPort;                                /* Port of remote management Host */
            public byte byUseDhcp;                                      /* Whether to enable the DHCP 0xff- invalid 0- enabled 1- not enabled */
            public byte byIPv6Mode;                                        //IPv6 allocation, 0- routing announcement, 1- manually, 2- enable DHCP allocation 
            public NET_DVR_IPADDR struDnsServer1IpAddr;                    /* IP address of the domain name server 1  */
            public NET_DVR_IPADDR struDnsServer2IpAddr;                    /* IP address of the domain name server 2  */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byIpResolver;                    /* IP parse server domain name or IP address */
            public ushort wIpResolverPort;                                /* Parsing IP server port number */
            public ushort wHttpPortNo;                                    /* HTTP port number  */
            public NET_DVR_IPADDR struMulticastIpAddr;                    /* Multicast group address */
            public NET_DVR_IPADDR struGatewayIpAddr;                        /* Gateway address  */
            public NET_DVR_PPPOECFG struPPPoE;
            public byte byEnablePrivateMulticastDiscovery;                //Private multicast search, 0- default, 1- enabled, 2 - disabled 
            public byte byEnableOnvifMulticastDiscovery;                //Onvif multicast search, 0- default, 1- enabled, 2 - disabled 
            public ushort wAlarmHost2IpPort;                                /* Alarm host 2 port */
            public NET_DVR_IPADDR struAlarmHost2IpAddr;                    /* Alarm host 2 IP addresses */
            public byte byEnableDNS; //DNS Enabled, 0-close,1-open 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 599, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public void Init()
            {
                struEtherNet = new NET_DVR_ETHERNET_V30[MAX_ETHERNET];
                struRes1 = new NET_DVR_IPADDR[2];
                struAlarmHostIpAddr = new NET_DVR_IPADDR();
                struAlarmHost2IpAddr = new NET_DVR_IPADDR();
                struDnsServer1IpAddr = new NET_DVR_IPADDR();
                struDnsServer2IpAddr = new NET_DVR_IPADDR();
                byIpResolver = new byte[MAX_DOMAIN_NAME];
                struMulticastIpAddr = new NET_DVR_IPADDR();
                struGatewayIpAddr = new NET_DVR_IPADDR();
                struPPPoE = new NET_DVR_PPPOECFG();
                byRes = new byte[599];
            }
        }
		
		public const int MAX_CENTERNUM = 4;
		
		[StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMHOST_NETCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CENTERNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ALARMHOST_NETPARAM[] struNetCenter;      
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[]    byRes1;
        }
		
		
		[StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMHOST_ABILITY
        {
            public  uint      dwSize;                      // 结构体大小
            public  ushort    wTotalAlarmInNum;         // 报警输入口总数(防区),包括级联
            public  ushort    wLocalAlarmInNum;         // 本地报警输入口
            public  ushort    wExpandAlarmInNum;        // 可扩展的报警输入口
            public  ushort    wTotalAlarmOutNum;        // 报警输出口总数 （设备支持的总数）
            public  ushort    wLocalAlarmOutNum;        // 本地报警输出口个数
            public  ushort    wExpandAlarmOutNum;       // 可扩展的报警输出口
            public  ushort    wTotalRs485Num;           // 报警输出口总数 （设备支持的总数）
            public  ushort    wLocalRs485Num;           // 本地485口数
            public  ushort    wExpandRs485Num;          // 可扩展的485口数
            public  ushort    wFullDuplexRs485Num;    // 全双工的485口数
            public  ushort    wTotalSensorNum;          // 模拟量最大个数 (设备支持的总数)
            public  ushort    wLocalSensorNum;        // 本地模拟量个数
            public  ushort    wExpandSensorNum;         // 可扩展的模拟量个数
            public  ushort    wAudioOutNum;                //语音输出个数
            public  ushort    wGatewayNum;            //门禁个数
            public  ushort    wElectroLockNum;            //电锁个数
            public  ushort    wSirenNum;                 // 主机警号数目
            public  ushort    wSubSystemNum;            // 可划分子系统数目
            public  ushort    wNetUserNum;            // 网络用户数
            public  ushort    wKeyboardNum;           // 键盘数
            public  ushort    wOperatorUserNum;           // 操作用户数
            public byte    bySupportDetector;//是否支持常开、常闭探测器，1-支持，0-不支持
            public byte    bySupportSensitivity;//是否支持防区灵敏度，1-支持，0-不支持
            public byte    bySupportArrayBypass;//是否支持组旁路，1-支持，0-不支持
            public byte    bySupportAlarmInDelay;//是否支持防区延迟,1-支持，0-不支持
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[]    bySupportAlarmInType;//支持的防区类型,数组0:即时防区,1-24小时防区,2-延时防区 ,3-内部防区，4-钥匙防区 5-火警防区 6-周界防区 7-24小时无声防区 8-24小时辅助防区，9-24小时震动防区,10-门禁紧急开门防区，11-门禁紧急关门防区15-无
            public byte    byTelNum;        //支持电话个数
            public byte    byCenterGroupNum;    //中心组个数
            public byte    byGPRSNum;        //GPRS中心数，最多4个
            public byte    byNetNum;        //网络中心数，最多4个
            public byte    byAudioNum;        //音频个数
            public byte    by3GNum;        //3G模块个数
            public byte    byAnalogVideoChanNum;        //模拟视频通道个数
            public byte    byDigitalVideoChanNum;        //数字视频通道个数
            public byte    bySubSystemArmType;        //子系统布防类型，0-表示不支持，1-表示支持。bit0-普通布防（注：网络小主机只支持普通布防，在能力集中加这个字段的时候网络小主机已经发布，所以网络小主机中该字段为0，所以用0表示支持，1表示不支持。对外接口中SDK内部会做兼容），bit1-即时布防，bit2-留守布防。    
            public byte    byPublicSubSystemNum;    //公共子系统个数
            
            public uint    dwSupport1;    //按位表示，结果非0表示支持，0表示不支持
            public uint    dwSubSystemEvent;        //子系统事件，按位表示，0表示不支持，非0表示支持,bit0-进入延时，bit1-退出延时，bit2-布防，bit3-撤防，bit4-报警，bit5-消除报警记忆
            public uint    dwOverallEvent;            //全局事件，按位表示，0表示不支持，非0表示支持，bit0-交流电掉电，bit1-电池电压低，bit2-电话线掉线，bit3-有线网络异常，bit4-无线网络异常，bit5-硬盘故障,bit6-3G/4G信号异常, bit7-（模块链接）第三方主机掉线,bit8-WIFI通信故障，bit9-RF信号干扰故障
            public uint    dwFaultType;            //设备支持的故障类型，bit0-交流电断电，bit1-蓄电池欠压，bit2-主机防拆开，bit3-电话线掉线，bit4-主键盘掉线，bit5-网络故障，bit6-无线异常，bit7-扩展总线异常，bit8-硬盘异常    
            
            public byte    byPublicSubsystemAssociateSubsystemNum;    //公共子系统可关联的子系统个数
            public byte    byOverallKeyboard;    //全局键盘个数
            public ushort    wSafetyCabinSupport; //防护舱控制器能力，按位表示，结果非0表示支持，0表示不支持    
           
            public byte   by485SlotNum;        //485虚拟槽位号
            public byte   bySubSystemAttributeAbility;  // 值恒为1，禁止1号子系统关闭使能
            
            public ushort    wKeyboardAddrNum;      // 键盘地址数
            public byte      byAlarmLampNum;         //警灯数目
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 117, ArraySubType = UnmanagedType.I1)]
            public byte[]    byRes;            //  保留字节
            public void Init()
            {
                bySupportAlarmInType = new byte[16];
                byRes = new byte[117];
            }
        }
		
		public const int ALARMHOST_ABILITY = 0x500;
		
		[StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMHOST_NETCFG_V50
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CENTERNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ALARMHOST_NETPARAM_V50[]   struNetCenter;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[]        byRes1;
            public void Init()
            {
                struNetCenter = new NET_DVR_ALARMHOST_NETPARAM_V50[MAX_CENTERNUM];
                byRes1 = new byte[128];
            }
        }

		[StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMHOST_NETPARAM_V50
        {
            public uint     dwSize;
            public NET_DVR_IPADDR  struIP;
            public ushort    wPort;
            public byte      byAddressType;    //0 - 无意义, 1 - ipv4/ipv6地址，2 - 域名
            public byte      byEnable; //使能，0-不启用，1-启用
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[]    byDomainName; //域名，GPRS参数配置、网络参数配置时该字段均有效
            public byte      byReportProtocol;        //1-private 2-NAL2300, 3-Ehome
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = ACCOUNTNUM_LEN_32, ArraySubType = UnmanagedType.I1)]
            public byte[]   byDevID; //协议为NAL2300时有效
            public byte     byProtocolVersion;            //EHome协议版本，0-无意义,1–v2.0，2–v4.0，3-v5.0
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[]    byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NET_SDK_EHOME_KEY_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[]    byEHomeKey;            //EHome Key（用于EHome 5.0版本）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 28, ArraySubType = UnmanagedType.I1)]
            public byte[]    byRes2; //GPRS的域名解析是在固定的服务器上进行的，所以不需要给解析服务器的信息预留一些字段
            public void Init()
            {
                struIP = new NET_DVR_IPADDR();
                byDomainName = new byte[MAX_DOMAIN_NAME];
                byDevID   = new byte[ACCOUNTNUM_LEN_32];
                byRes1 = new byte[3];
                byEHomeKey = new byte[NET_SDK_EHOME_KEY_LEN];
                byRes2 = new byte[28];
            }
         }
		
		public const int NET_DVR_SET_ALARMHOST_NETCFG_V50 = 2225;    //Set Net info V50
        public const int NET_DVR_GET_ALARMHOST_NETCFG_V50 = 2224;    //Get Net infoV50
		
		public const int MAX_AUDIO_V40 = 8;
		
		[StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SIMPLE_DAYTIME
        {
            public byte byHour; //hour
            public byte byMinute; //minute
            public byte bySecond; //second
            public byte byRes;
        }
		
		
		public const int NET_DVR_GET_NETCFG_V50 = 1015;    //Get network parameter configuration (V50) 
        public const int NET_DVR_SET_NETCFG_V50 = 1016;    //Set network parameter configuration (V50) 


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INDEX
        {
            public uint iIndex;
            public void Init()
            {
                iIndex = 1;
            }
        }

        public struct NET_DVR_INBUFF
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.U4)]
            public uint[] StatusList;
            public void Init()
            {
                StatusList = new uint[16];
            }
        }


		[StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMHOST_REPORT_CENTER_CFG_V40
        {
             public uint  dwSize;
             public byte  byValid;
             public byte  byDataType;            //1-All alarm data 2-not alarm data 3-all data,4-zone report,5-not zone report
             [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
             public byte[]  byRes;
             [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.Struct)]
             public byte[]  byChanAlarmMode;//alarm channels, 1-T1,2-T2, 3-N1, 4-N2,5-G1, 6-G2 ,7-N3, 8-N4
             [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.Struct)]
             public byte[]  byDealFailCenter; //send to these centers while send fail 0-not choose,1-choose
             [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 512, ArraySubType = UnmanagedType.Struct)]
             public byte[]   byZoneReport;    //zone report type,0-not upload,1-upload 
             [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.Struct)]
             public byte[]  byNonZoneReport; //not zone report, 0-not upload,1-upload byNonZoneReport[0]-soft zone report byNonZoneReport[1]-system status report byNonZoneReport[2]-cancel report byNonZoneReport[3]-test report byNonZoneReport[4]-arm report byNonZoneReport[5]-disarm report byNonZoneReport[6]-duress report byNonZoneReport[7]-alarm recovery report byNonZoneReport[8]-bypass report byNonZoneReport[9]-bypass restore report,byNonZoneReport[10]-detector connect status report(online/offline),byNonZoneReport[11]-detector power status report(normal/low);bit12-video alarm report
             [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.Struct)]
             public byte[]  byAlarmNetCard;    //network card center,0-primary card_1,1-primary card_2,2-extend card_1,3-extend card_2
             [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 252, ArraySubType = UnmanagedType.Struct)]
             public byte[]  byRes2;
             public void Init()
             { 
                 byRes  = new byte[2];
                 byChanAlarmMode = new byte[4];
                 byDealFailCenter = new byte[16];
                 byZoneReport = new byte[512];
                 byNonZoneReport = new byte[32];
                 byAlarmNetCard = new byte[4];
                 byRes2 = new byte[252];
             }
        }
		
		public const int DOOR_NAME_LEN = 32;//door name len 
        public const int STRESS_PASSWORD_LEN = 8;//stress password len
        public const int SUPER_PASSWORD_LEN = 8;//super password len
        public const int UNLOCK_PASSWORD_LEN = 8;
        public const int MAX_DOOR_NUM = 32;
        public const int MAX_GROUP_NUM = 32;
        public const int LOCAL_CONTROLLER_NAME_LEN = 32;
		
		[StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DOOR_CFG
        {
            public uint dwSize;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = DOOR_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDoorName;//door name
            public byte byMagneticType;//magnetic type, 0-always close 1-always open
            public byte byOpenButtonType;//open button type,  0-always close 1-always open
            public byte byOpenDuration;//open duration time, 1-255s(ladder control relay action time)
            public byte byDisabledOpenDuration;//disable open duration , 1-255s  
            public byte byMagneticAlarmTimeout;//magnetic alarm time out , 0-255s,0 means not to alarm
            public byte byEnableDoorLock;//whether to enable door lock, 0-disable, 1-enable
            public byte byEnableLeaderCard;//whether to enable leader card , 0-disable, 1-enable
            public byte byLeaderCardMode;//First card mode, 0 - first card function is not enabled, and 1 - the first card normally open mode, 2 - the first card authorization mode (using this field, the byEnableLeaderCard is invalid ) 
            public uint dwLeaderCardOpenDuration;//leader card open duration 1-1440min
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = STRESS_PASSWORD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byStressPassword;//stress ppassword
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = SUPER_PASSWORD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] bySuperPassword; //super password
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = UNLOCK_PASSWORD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byUnlockPassword;
            public byte byUseLocalController; //Read-only, whether the connection on the local controller, 0 - no, 1 - yes
            public byte byRes1;
            public ushort wLocalControllerID; //Read-only, on-site controller serial number, 1-64, 0 on behalf of unregistered 
            public ushort wLocalControllerDoorNumber; //Read-only, on-site controller door number, 1-4, 0 represents the unregistered 
            public ushort wLocalControllerStatus; //Read-only, on-site controller online status: 0 - offline, 1 - online, 2 - loop of RS485 serial port 1 on 1, 3 - loop of RS485 serial port 2 on 2, 4 - loop of RS485 serial port 1, 5 - loop of RS485 serial port 2, 6 - loop 3 of RS485 serial port 1, 7 - the loop on the RS485 serial port on the 3 4 2, 8 - loop on the RS485 serial port 1, 9 - loop 4 of RS485 serial port 2 (read-only) 
            public byte byLockInputCheck; //Whether to enable the door input detection (1 public byte, 0 is not enabled, 1 is enabled, is not enabled by default) 
            public byte byLockInputType; //Door lock input type 
            public byte byDoorTerminalMode; //Gate terminal working mode 
            public byte byOpenButton; //Whether to enable the open button 
            public byte byLadderControlDelayTime; //ladder control delay time,1-255min
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 43, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;

            public void Init()
            { 
                byDoorName = new byte[DOOR_NAME_LEN];
                byStressPassword = new byte[STRESS_PASSWORD_LEN];
                bySuperPassword = new byte[SUPER_PASSWORD_LEN];
                byUnlockPassword = new byte[UNLOCK_PASSWORD_LEN];
                byRes2 = new byte[43];
            }
        }
		
		public const int NET_DVR_GET_DOOR_CFG = 2108; //get door parameter
        public const int NET_DVR_SET_DOOR_CFG = 2109; //set door parameter
		
		
		public const int NET_DVR_SET_ALARMHOST_REPORT_CENTER_V40 = 2065;   // set data report mode v30

		
		
		
		
		
		
		
		
		
		

        /*************操作异常类型(消息方式, 回调方式(保留))****************/
        public const int EXCEPTION_EXCHANGE = 32768;//用户交互时异常
        public const int EXCEPTION_AUDIOEXCHANGE = 32769;//语音对讲异常
        public const int EXCEPTION_ALARM = 32770;//报警异常
        public const int EXCEPTION_PREVIEW = 32771;//网络预览异常
        public const int EXCEPTION_SERIAL = 32772;//透明通道异常
        public const int EXCEPTION_RECONNECT = 32773;//预览时重连
        public const int EXCEPTION_ALARMRECONNECT = 32774;//报警时重连
        public const int EXCEPTION_SERIALRECONNECT = 32775;//透明通道重连
        public const int EXCEPTION_PLAYBACK = 32784;//回放异常
        public const int EXCEPTION_DISKFMT = 32785;//硬盘格式化

        /********************预览回调函数*********************/
        public const int NET_DVR_SYSHEAD = 1;//系统头数据
        public const int NET_DVR_STREAMDATA = 2;//视频流数据（包括复合流和音视频分开的视频流数据）
        public const int NET_DVR_AUDIOSTREAMDATA = 3;//音频流数据
        public const int NET_DVR_STD_VIDEODATA = 4;//标准视频流数据
        public const int NET_DVR_STD_AUDIODATA = 5;//标准音频流数据

        //回调预览中的状态和消息
        public const int NET_DVR_REALPLAYEXCEPTION = 111;//预览异常
        public const int NET_DVR_REALPLAYNETCLOSE = 112;//预览时连接断开
        public const int NET_DVR_REALPLAY5SNODATA = 113;//预览5s没有收到数据
        public const int NET_DVR_REALPLAYRECONNECT = 114;//预览重连

        /********************回放回调函数*********************/
        public const int NET_DVR_PLAYBACKOVER = 101;//回放数据播放完毕
        public const int NET_DVR_PLAYBACKEXCEPTION = 102;//回放异常
        public const int NET_DVR_PLAYBACKNETCLOSE = 103;//回放时候连接断开
        public const int NET_DVR_PLAYBACK5SNODATA = 104;//回放5s没有收到数据

        /*********************回调函数类型 end************************/
        //设备型号(DVR类型)
        /* 设备类型 */
        public const int DVR = 1;/*对尚未定义的dvr类型返回NETRET_DVR*/
        public const int ATMDVR = 2;/*atm dvr*/
        public const int DVS = 3;/*DVS*/
        public const int DEC = 4;/* 6001D */
        public const int ENC_DEC = 5;/* 6001F */
        public const int DVR_HC = 6;/*8000HC*/
        public const int DVR_HT = 7;/*8000HT*/
        public const int DVR_HF = 8;/*8000HF*/
        public const int DVR_HS = 9;/* 8000HS DVR(no audio) */
        public const int DVR_HTS = 10; /* 8016HTS DVR(no audio) */
        public const int DVR_HB = 11; /* HB DVR(SATA HD) */
        public const int DVR_HCS = 12; /* 8000HCS DVR */
        public const int DVS_A = 13; /* 带ATA硬盘的DVS */
        public const int DVR_HC_S = 14; /* 8000HC-S */
        public const int DVR_HT_S = 15;/* 8000HT-S */
        public const int DVR_HF_S = 16;/* 8000HF-S */
        public const int DVR_HS_S = 17; /* 8000HS-S */
        public const int ATMDVR_S = 18;/* ATM-S */
        public const int LOWCOST_DVR = 19;/*7000H系列*/
        public const int DEC_MAT = 20; /*多路解码器*/
        public const int DVR_MOBILE = 21;/* mobile DVR */
        public const int DVR_HD_S = 22;   /* 8000HD-S */
        public const int DVR_HD_SL = 23;/* 8000HD-SL */
        public const int DVR_HC_SL = 24;/* 8000HC-SL */
        public const int DVR_HS_ST = 25;/* 8000HS_ST */
        public const int DVS_HW = 26; /* 6000HW */
        public const int DS630X_D = 27; /* 多路解码器 */
        public const int IPCAM = 30;/*IP 摄像机*/
        public const int MEGA_IPCAM = 31;/*X52MF系列,752MF,852MF*/
        public const int IPCAM_X62MF = 32;/*X62MF系列可接入9000设备,762MF,862MF*/
        public const int IPDOME = 40; /*IP 标清球机*/
        public const int IPDOME_MEGA200 = 41;/*IP 200万高清球机*/
        public const int IPDOME_MEGA130 = 42;/*IP 130万高清球机*/
        public const int IPMOD = 50;/*IP 模块*/
        public const int DS71XX_H = 71;/* DS71XXH_S */
        public const int DS72XX_H_S = 72;/* DS72XXH_S */
        public const int DS73XX_H_S = 73;/* DS73XXH_S */
        public const int DS76XX_H_S = 76;/* DS76XX_H_S */
        public const int DS81XX_HS_S = 81;/* DS81XX_HS_S */
        public const int DS81XX_HL_S = 82;/* DS81XX_HL_S */
        public const int DS81XX_HC_S = 83;/* DS81XX_HC_S */
        public const int DS81XX_HD_S = 84;/* DS81XX_HD_S */
        public const int DS81XX_HE_S = 85;/* DS81XX_HE_S */
        public const int DS81XX_HF_S = 86;/* DS81XX_HF_S */
        public const int DS81XX_AH_S = 87;/* DS81XX_AH_S */
        public const int DS81XX_AHF_S = 88;/* DS81XX_AHF_S */
        public const int DS90XX_HF_S = 90;  /*DS90XX_HF_S*/
        public const int DS91XX_HF_S = 91;  /*DS91XX_HF_S*/
        public const int DS91XX_HD_S = 92; /*91XXHD-S(MD)*/
        /**********************设备类型 end***********************/

        /**********************能力集类型 begin***********************/
        public const int DEVICE_SOFTHARDWARE_ABILITY = 0x001;
        public const int DEVICE_NETWORK_ABILITY = 0x002;
        public const int DEVICE_ENCODE_ALL_ABILITY_V20 = 0x008;
        public const int IPC_FRONT_PARAMETER_V20 = 0x009;
        public const int DEVICE_RAID_ABILITY = 0x007;
        public const int DEVICE_ALARM_ABILITY = 0x00a;
        public const int DEVICE_DYNCHAN_ABILITY = 0x00b;
        public const int DEVICE_USER_ABILITY = 0x00c;
        public const int DEVICE_NETAPP_ABILITY = 0x00d;
        public const int DEVICE_VIDEOPIC_ABILITY = 0x00e;
        public const int DEVICE_JPEG_CAP_ABILITY = 0x00f;
        public const int DEVICE_SERIAL_ABILITY = 0x010;
        public const int DEVICE_ABILITY_INFO = 0x011;
        /**********************能力集类型 end***********************/

        /*************************************************
        门禁事件类型
        **************************************************/
        #region acs event upload

        /* Alarm */
        // Main Type
        //public const int MAJOR_ALARM = 0x1;
        // Hypo- Type
        public const int MINOR_ALARMIN_SHORT_CIRCUIT = 0x400; // region short circuit 
        public const int MINOR_ALARMIN_BROKEN_CIRCUIT = 0x401; // region broken circuit
        public const int MINOR_ALARMIN_EXCEPTION = 0x402; // region exception 
        public const int MINOR_ALARMIN_RESUME = 0x403; // region resume 
        public const int MINOR_HOST_DESMANTLE_ALARM = 0x404; // host desmantle alarm
        public const int MINOR_HOST_DESMANTLE_RESUME = 0x405; //  host desmantle resume
        public const int MINOR_CARD_READER_DESMANTLE_ALARM = 0x406; // card reader desmantle alarm 
        public const int MINOR_CARD_READER_DESMANTLE_RESUME = 0x407; // card reader desmantle resume
        public const int MINOR_CASE_SENSOR_ALARM = 0x408; // case sensor alarm 
        public const int MINOR_CASE_SENSOR_RESUME = 0x409; // case sensor resume 
        public const int MINOR_STRESS_ALARM = 0x40a; // stress alarm 
        public const int MINOR_OFFLINE_ECENT_NEARLY_FULL = 0x40b; // offline ecent nearly full 
        public const int MINOR_CARD_MAX_AUTHENTICATE_FAIL = 0x40c; // card max authenticate fall 
        public const int MINOR_SD_CARD_FULL = 0x40d; // SD card is full
        public const int MINOR_LINKAGE_CAPTURE_PIC = 0x40e; // lingage capture picture
        public const int MINOR_SECURITY_MODULE_DESMANTLE_ALARM = 0x40f;  //Door control security module desmantle alarm
        public const int MINOR_SECURITY_MODULE_DESMANTLE_RESUME = 0x410;  //Door control security module desmantle resume
        public const int MINOR_POS_START_ALARM = 0x411; // POS Start
        public const int MINOR_POS_END_ALARM = 0x412; // POS end
        public const int MINOR_FACE_IMAGE_QUALITY_LOW = 0x413; // face image quality low
        public const int MINOR_FINGE_RPRINT_QUALITY_LOW = 0x414; // finger print quality low
        public const int MINOR_FIRE_IMPORT_SHORT_CIRCUIT = 0x415; // Fire import short circuit
        public const int MINOR_FIRE_IMPORT_BROKEN_CIRCUIT = 0x416; // Fire import broken circuit
        public const int MINOR_FIRE_IMPORT_RESUME = 0x417; // Fire import resume
        public const int MINOR_FIRE_BUTTON_TRIGGER = 0x418; // fire button trigger
        public const int MINOR_FIRE_BUTTON_RESUME = 0x419; // fire button resume
        public const int MINOR_MAINTENANCE_BUTTON_TRIGGER = 0x41a; // maintenance button trigger
        public const int MINOR_MAINTENANCE_BUTTON_RESUME = 0x41b; // maintenance button resume
        public const int MINOR_EMERGENCY_BUTTON_TRIGGER = 0x41c; // emergency button trigger
        public const int MINOR_EMERGENCY_BUTTON_RESUME = 0x41d; // emergency button resume
        public const int MINOR_DISTRACT_CONTROLLER_ALARM = 0x41e; // distract controller alarm
        public const int MINOR_DISTRACT_CONTROLLER_RESUME = 0x41f; // distract controller resume
        public const int MINOR_CHANNEL_CONTROLLER_DESMANTLE_ALARM = 0x422; //channel controller desmantle alarm
        public const int MINOR_CHANNEL_CONTROLLER_DESMANTLE_RESUME = 0x423; //channel controller desmantle resume
        public const int MINOR_CHANNEL_CONTROLLER_FIRE_IMPORT_ALARM = 0x424; //channel controller fire import alarm
        public const int MINOR_CHANNEL_CONTROLLER_FIRE_IMPORT_RESUME = 0x425;  //channel controller fire import resume
        public const int MINOR_PRINTER_OUT_OF_PAPER = 0x440;  //printer no paper
        public const int MINOR_LEGAL_EVENT_NEARLY_FULL = 0x442;  //Legal event nearly full

        /* Exception*/
        // Main Type
        //public const int MAJOR_EXCEPTION = 0x2;
        // Hypo- Type

        //public const int MINOR_NET_BROKEN = 0x27; // Network disconnected 
        public const int MINOR_RS485_DEVICE_ABNORMAL = 0x3a; // RS485 connect status exception
        public const int MINOR_RS485_DEVICE_REVERT = 0x3b; // RS485 connect status exception recovery

        public const int MINOR_DEV_POWER_ON = 0x400; // device power on
        public const int MINOR_DEV_POWER_OFF = 0x401; // device power off
        public const int MINOR_WATCH_DOG_RESET = 0x402; // watch dog reset 
        public const int MINOR_LOW_BATTERY = 0x403; // low battery 
        public const int MINOR_BATTERY_RESUME = 0x404; // battery resume
        public const int MINOR_AC_OFF = 0x405; // AC off
        public const int MINOR_AC_RESUME = 0x406; // AC resume 
        public const int MINOR_NET_RESUME = 0x407; // Net resume
        public const int MINOR_FLASH_ABNORMAL = 0x408; // FLASH abnormal 
        public const int MINOR_CARD_READER_OFFLINE = 0x409; // card reader offline 
        public const int MINOR_CARD_READER_RESUME = 0x40a; // card reader resume 
        public const int MINOR_INDICATOR_LIGHT_OFF = 0x40b; // Indicator Light Off
        public const int MINOR_INDICATOR_LIGHT_RESUME = 0x40c; // Indicator Light Resume
        public const int MINOR_CHANNEL_CONTROLLER_OFF = 0x40d; // channel controller off
        public const int MINOR_CHANNEL_CONTROLLER_RESUME = 0x40e; // channel controller resume
        public const int MINOR_SECURITY_MODULE_OFF = 0x40f; // Door control security module off
        public const int MINOR_SECURITY_MODULE_RESUME = 0x410; // Door control security module resume
        public const int MINOR_BATTERY_ELECTRIC_LOW = 0x411; // battery electric low
        public const int MINOR_BATTERY_ELECTRIC_RESUME = 0x412; // battery electric resume
        public const int MINOR_LOCAL_CONTROL_NET_BROKEN = 0x413; // Local control net broken
        public const int MINOR_LOCAL_CONTROL_NET_RSUME = 0x414; // Local control net resume
        public const int MINOR_MASTER_RS485_LOOPNODE_BROKEN = 0x415; // Master RS485 loop node broken
        public const int MINOR_MASTER_RS485_LOOPNODE_RESUME = 0x416; // Master RS485 loop node resume
        public const int MINOR_LOCAL_CONTROL_OFFLINE = 0x417; // Local control offline
        public const int MINOR_LOCAL_CONTROL_RESUME = 0x418; // Local control resume
        public const int MINOR_LOCAL_DOWNSIDE_RS485_LOOPNODE_BROKEN = 0x419; // Local downside RS485 loop node broken
        public const int MINOR_LOCAL_DOWNSIDE_RS485_LOOPNODE_RESUME = 0x41a; // Local downside RS485 loop node resume
        public const int MINOR_DISTRACT_CONTROLLER_ONLINE = 0x41b; // distract controller online
        public const int MINOR_DISTRACT_CONTROLLER_OFFLINE = 0x41c; // distract controller offline
        public const int MINOR_ID_CARD_READER_NOT_CONNECT = 0x41d; // Id card reader not connected(intelligent dedicated)
        public const int MINOR_ID_CARD_READER_RESUME = 0x41e; //Id card reader connection restored(intelligent dedicated)
        public const int MINOR_FINGER_PRINT_MODULE_NOT_CONNECT = 0x41f; // fingerprint module is not connected(intelligent dedicated)
        public const int MINOR_FINGER_PRINT_MODULE_RESUME = 0x420; // The fingerprint module connection restored(intelligent dedicated)
        public const int MINOR_CAMERA_NOT_CONNECT = 0x421; // Camera not connected
        public const int MINOR_CAMERA_RESUME = 0x422; // Camera connection restored
        public const int MINOR_COM_NOT_CONNECT = 0x423; // COM not connected
        public const int MINOR_COM_RESUME = 0x424;// COM connection restored
        public const int MINOR_DEVICE_NOT_AUTHORIZE = 0x425; // device are not authorized
        public const int MINOR_PEOPLE_AND_ID_CARD_DEVICE_ONLINE = 0x426; // people and ID card device online
        public const int MINOR_PEOPLE_AND_ID_CARD_DEVICE_OFFLINE = 0x427;// people and ID card device offline
        public const int MINOR_LOCAL_LOGIN_LOCK = 0x428; // local login lock
        public const int MINOR_LOCAL_LOGIN_UNLOCK = 0x429; //local login unlock
        public const int MINOR_SUBMARINEBACK_COMM_BREAK = 0x42a;  //submarineback communicate break
        public const int MINOR_SUBMARINEBACK_COMM_RESUME = 0x42b;  //submarineback communicate resume
        public const int MINOR_MOTOR_SENSOR_EXCEPTION = 0x42c;  //motor sensor exception
        public const int MINOR_CAN_BUS_EXCEPTION = 0x42d;  //can bus exception
        public const int MINOR_CAN_BUS_RESUME = 0x42e;  //can bus resume
        public const int MINOR_GATE_TEMPERATURE_OVERRUN = 0x42f; //gate temperature over run
        public const int MINOR_IR_EMITTER_EXCEPTION = 0x430; //IR emitter exception
        public const int MINOR_IR_EMITTER_RESUME = 0x431;  //IR emitter resume
        public const int MINOR_LAMP_BOARD_COMM_EXCEPTION = 0x432;  //lamp board communicate exception
        public const int MINOR_LAMP_BOARD_COMM_RESUME = 0x433;  //lamp board communicate resume
        public const int MINOR_IR_ADAPTOR_COMM_EXCEPTION = 0x434; //IR adaptor communicate exception
        public const int MINOR_IR_ADAPTOR_COMM_RESUME = 0x435;  //IR adaptor communicate resume
        public const int MINOR_PRINTER_ONLINE = 0x436; //printer online
        public const int MINOR_PRINTER_OFFLINE = 0x437; //printer offline
        public const int MINOR_4G_MOUDLE_ONLINE = 0x438; //4G module online
        public const int MINOR_4G_MOUDLE_OFFLINE = 0x439; //4G module offline


        /* Operation  */
        // Main Type
        //public const int MAJOR_OPERATION = 0x3;

        // Hypo- Type
        //public const int MINOR_LOCAL_UPGRADE = 0x5a; // Upgrade  (local)
        //public const int MINOR_REMOTE_LOGIN = 0x70; // Login  (remote)
        //public const int MINOR_REMOTE_LOGOUT = 0x71; // Logout   (remote)
        //public const int MINOR_REMOTE_ARM = 0x79; // On guard   (remote)
        //public const int MINOR_REMOTE_DISARM = 0x7a; // Disarm   (remote)
        //public const int MINOR_REMOTE_REBOOT = 0x7b; // Reboot   (remote)
        //public const int MINOR_REMOTE_UPGRADE = 0x7e; // upgrade  (remote)
        //public const int MINOR_REMOTE_CFGFILE_OUTPUT = 0x86; // Export Configuration   (remote) 
        //public const int MINOR_REMOTE_CFGFILE_INTPUT = 0x87; // Import Configuration  (remote) 
        //public const int MINOR_REMOTE_ALARMOUT_OPEN_MAN = 0xd6; // remote mamual open alarmout 
        //public const int MINOR_REMOTE_ALARMOUT_CLOSE_MAN = 0xd7; // remote mamual close alarmout 

        public const int MINOR_REMOTE_OPEN_DOOR = 0x400; // remote open door 
        public const int MINOR_REMOTE_CLOSE_DOOR = 0x401; // remote close door (controlled) 
        public const int MINOR_REMOTE_ALWAYS_OPEN = 0x402; // remote always open door (free) 
        public const int MINOR_REMOTE_ALWAYS_CLOSE = 0x403; // remote always close door (forbiden)
        public const int MINOR_REMOTE_CHECK_TIME = 0x404; // remote check time 
        public const int MINOR_NTP_CHECK_TIME = 0x405; // ntp check time 
        public const int MINOR_REMOTE_CLEAR_CARD = 0x406; // remote clear card 
        public const int MINOR_REMOTE_RESTORE_CFG = 0x407; // remote restore configure 
        public const int MINOR_ALARMIN_ARM = 0x408; // alarm in arm 
        public const int MINOR_ALARMIN_DISARM = 0x409; // alarm in disarm 
        public const int MINOR_LOCAL_RESTORE_CFG = 0x40a; // local configure restore 
        public const int MINOR_REMOTE_CAPTURE_PIC = 0x40b; // remote capture picture 
        public const int MINOR_MOD_NET_REPORT_CFG = 0x40c; // modify net report cfg 
        public const int MINOR_MOD_GPRS_REPORT_PARAM = 0x40d; // modify GPRS report param 
        public const int MINOR_MOD_REPORT_GROUP_PARAM = 0x40e; // modify report group param 
        public const int MINOR_UNLOCK_PASSWORD_OPEN_DOOR = 0x40f; // unlock password open door 
        public const int MINOR_AUTO_RENUMBER = 0x410; // auto renumber 
        public const int MINOR_AUTO_COMPLEMENT_NUMBER = 0x411; // auto complement number 
        public const int MINOR_NORMAL_CFGFILE_INPUT = 0x412; // normal cfg file input 
        public const int MINOR_NORMAL_CFGFILE_OUTTPUT = 0x413; // normal cfg file output 
        public const int MINOR_CARD_RIGHT_INPUT = 0x414; // card right input 
        public const int MINOR_CARD_RIGHT_OUTTPUT = 0x415; // card right output 
        public const int MINOR_LOCAL_USB_UPGRADE = 0x416; // local USB upgrade 
        public const int MINOR_REMOTE_VISITOR_CALL_LADDER = 0x417; // visitor call ladder 
        public const int MINOR_REMOTE_HOUSEHOLD_CALL_LADDER = 0x418; // household call ladder 
        public const int MINOR_REMOTE_ACTUAL_GUARD = 0x419;  //remote actual guard
        public const int MINOR_REMOTE_ACTUAL_UNGUARD = 0x41a;  //remote actual unguard
        public const int MINOR_REMOTE_CONTROL_NOT_CODE_OPER_FAILED = 0x41b; //remote control not code operate failed
        public const int MINOR_REMOTE_CONTROL_CLOSE_DOOR = 0x41c; //remote control close door
        public const int MINOR_REMOTE_CONTROL_OPEN_DOOR = 0x41d; //remote control open door
        public const int MINOR_REMOTE_CONTROL_ALWAYS_OPEN_DOOR = 0x41e; //remote control always open door

        /* Additional Log Info*/
        // Main Type
        public const int MAJOR_EVENT = 0x5;/*event*/
        // Hypo- Type
        public const int MINOR_LEGAL_CARD_PASS = 0x01; // legal card pass
        public const int MINOR_CARD_AND_PSW_PASS = 0x02; // swipe and password pass
        public const int MINOR_CARD_AND_PSW_FAIL = 0x03; // swipe and password fail
        public const int MINOR_CARD_AND_PSW_TIMEOUT = 0x04; // swipe and password timeout
        public const int MINOR_CARD_AND_PSW_OVER_TIME = 0x05; // swipe and password over time
        public const int MINOR_CARD_NO_RIGHT = 0x06; // card no right 
        public const int MINOR_CARD_INVALID_PERIOD = 0x07; // invalid period 
        public const int MINOR_CARD_OUT_OF_DATE = 0x08; // card out of date
        public const int MINOR_INVALID_CARD = 0x09; // invalid card 
        public const int MINOR_ANTI_SNEAK_FAIL = 0x0a; // anti sneak fail 
        public const int MINOR_INTERLOCK_DOOR_NOT_CLOSE = 0x0b; // interlock door doesn't close
        public const int MINOR_NOT_BELONG_MULTI_GROUP = 0x0c; // card no belong multi group 
        public const int MINOR_INVALID_MULTI_VERIFY_PERIOD = 0x0d; // invalid multi verify period 
        public const int MINOR_MULTI_VERIFY_SUPER_RIGHT_FAIL = 0x0e; // have no super right in multi verify mode 
        public const int MINOR_MULTI_VERIFY_REMOTE_RIGHT_FAIL = 0x0f; // have no remote right in multi verify mode 
        public const int MINOR_MULTI_VERIFY_SUCCESS = 0x10; // success in multi verify mode 
        public const int MINOR_LEADER_CARD_OPEN_BEGIN = 0x11; // leader card begin to open
        public const int MINOR_LEADER_CARD_OPEN_END = 0x12; // leader card end to open 
        public const int MINOR_ALWAYS_OPEN_BEGIN = 0x13; // always open begin
        public const int MINOR_ALWAYS_OPEN_END = 0x14; // always open end
        public const int MINOR_LOCK_OPEN = 0x15; // lock open
        public const int MINOR_LOCK_CLOSE = 0x16; // lock close
        public const int MINOR_DOOR_BUTTON_PRESS = 0x17; // press door open button 
        public const int MINOR_DOOR_BUTTON_RELEASE = 0x18; // release door open button 
        public const int MINOR_DOOR_OPEN_NORMAL = 0x19; // door open normal 
        public const int MINOR_DOOR_CLOSE_NORMAL = 0x1a; // door close normal 
        public const int MINOR_DOOR_OPEN_ABNORMAL = 0x1b; // open door abnormal 
        public const int MINOR_DOOR_OPEN_TIMEOUT = 0x1c; // open door timeout 
        public const int MINOR_ALARMOUT_ON = 0x1d; // alarm out turn on 
        public const int MINOR_ALARMOUT_OFF = 0x1e; // alarm out turn off 
        public const int MINOR_ALWAYS_CLOSE_BEGIN = 0x1f; // always close begin 
        public const int MINOR_ALWAYS_CLOSE_END = 0x20; // always close end 
        public const int MINOR_MULTI_VERIFY_NEED_REMOTE_OPEN = 0x21; // need remote open in multi verify mode 
        public const int MINOR_MULTI_VERIFY_SUPERPASSWD_VERIFY_SUCCESS = 0x22; // superpasswd verify success in multi verify mode 
        public const int MINOR_MULTI_VERIFY_REPEAT_VERIFY = 0x23; // repeat verify in multi verify mode 
        public const int MINOR_MULTI_VERIFY_TIMEOUT = 0x24; // timeout in multi verify mode 
        public const int MINOR_DOORBELL_RINGING = 0x25; // doorbell ringing 
        public const int MINOR_FINGERPRINT_COMPARE_PASS = 0x26; // fingerprint compare pass 
        public const int MINOR_FINGERPRINT_COMPARE_FAIL = 0x27; // fingerprint compare fail 
        public const int MINOR_CARD_FINGERPRINT_VERIFY_PASS = 0x28; // card and fingerprint verify pass 
        public const int MINOR_CARD_FINGERPRINT_VERIFY_FAIL = 0x29; // card and fingerprint verify fail 
        public const int MINOR_CARD_FINGERPRINT_VERIFY_TIMEOUT = 0x2a; // card and fingerprint verify timeout 
        public const int MINOR_CARD_FINGERPRINT_PASSWD_VERIFY_PASS = 0x2b; // card and fingerprint and passwd verify pass 
        public const int MINOR_CARD_FINGERPRINT_PASSWD_VERIFY_FAIL = 0x2c; // card and fingerprint and passwd verify fail 
        public const int MINOR_CARD_FINGERPRINT_PASSWD_VERIFY_TIMEOUT = 0x2d; // card and fingerprint and passwd verify timeout 
        public const int MINOR_FINGERPRINT_PASSWD_VERIFY_PASS = 0x2e; // fingerprint and passwd verify pass 
        public const int MINOR_FINGERPRINT_PASSWD_VERIFY_FAIL = 0x2f; // fingerprint and passwd verify fail 
        public const int MINOR_FINGERPRINT_PASSWD_VERIFY_TIMEOUT = 0x30; // fingerprint and passwd verify timeout 
        public const int MINOR_FINGERPRINT_INEXISTENCE = 0x31; // fingerprint inexistence 
        public const int MINOR_CARD_PLATFORM_VERIFY = 0x32; // card platform verify 
        public const int MINOR_CALL_CENTER = 0x33; // call center 
        public const int MINOR_FIRE_RELAY_TURN_ON_DOOR_ALWAYS_OPEN = 0x34; // fire relay turn on door always open 
        public const int MINOR_FIRE_RELAY_RECOVER_DOOR_RECOVER_NORMAL = 0x35; // fire relay recover door recover normal 
        public const int MINOR_FACE_AND_FP_VERIFY_PASS = 0x36; // face and finger print verify pass 
        public const int MINOR_FACE_AND_FP_VERIFY_FAIL = 0x37; // face and finger print verify fail 
        public const int MINOR_FACE_AND_FP_VERIFY_TIMEOUT = 0x38; // face and finger print verify timeout 
        public const int MINOR_FACE_AND_PW_VERIFY_PASS = 0x39; // face and password verify pass 
        public const int MINOR_FACE_AND_PW_VERIFY_FAIL = 0x3a; // face and password verify fail 
        public const int MINOR_FACE_AND_PW_VERIFY_TIMEOUT = 0x3b; // face and password verify timeout 
        public const int MINOR_FACE_AND_CARD_VERIFY_PASS = 0x3c; // face and card verify pass 
        public const int MINOR_FACE_AND_CARD_VERIFY_FAIL = 0x3d; // face and card verify fail 
        public const int MINOR_FACE_AND_CARD_VERIFY_TIMEOUT = 0x3e; // face and card verify timeout 
        public const int MINOR_FACE_AND_PW_AND_FP_VERIFY_PASS = 0x3f; // face and password and finger print verify pass 
        public const int MINOR_FACE_AND_PW_AND_FP_VERIFY_FAIL = 0x40; // face and password and finger print verify fail 
        public const int MINOR_FACE_AND_PW_AND_FP_VERIFY_TIMEOUT = 0x41; // face and password and finger print verify timeout 
        public const int MINOR_FACE_CARD_AND_FP_VERIFY_PASS = 0x42; // face and card and finger print verify pass 
        public const int MINOR_FACE_CARD_AND_FP_VERIFY_FAIL = 0x43; // face and card and finger print verify fail 
        public const int MINOR_FACE_CARD_AND_FP_VERIFY_TIMEOUT = 0x44; // face and card and finger print verify timeout 
        public const int MINOR_EMPLOYEENO_AND_FP_VERIFY_PASS = 0x45; // employee and finger print verify pass 
        public const int MINOR_EMPLOYEENO_AND_FP_VERIFY_FAIL = 0x46; // employee and finger print verify fail 
        public const int MINOR_EMPLOYEENO_AND_FP_VERIFY_TIMEOUT = 0x47; // employee and finger print verify timeout 
        public const int MINOR_EMPLOYEENO_AND_FP_AND_PW_VERIFY_PASS = 0x48; // employee and finger print and password verify pass 
        public const int MINOR_EMPLOYEENO_AND_FP_AND_PW_VERIFY_FAIL = 0x49; // employee and finger print and password verify fail 
        public const int MINOR_EMPLOYEENO_AND_FP_AND_PW_VERIFY_TIMEOUT = 0x4a; // employee and finger print and password verify timeout
        public const int MINOR_FACE_VERIFY_PASS = 0x4b; // face verify pass 
        public const int MINOR_FACE_VERIFY_FAIL = 0x4c; // face verify fail 
        public const int MINOR_EMPLOYEENO_AND_FACE_VERIFY_PASS = 0x4d; // employee no and face verify pass 
        public const int MINOR_EMPLOYEENO_AND_FACE_VERIFY_FAIL = 0x4e; // employee no and face verify fail 
        public const int MINOR_EMPLOYEENO_AND_FACE_VERIFY_TIMEOUT = 0x4f; // employee no and face verify time out 
        public const int MINOR_FACE_RECOGNIZE_FAIL = 0x50; // face recognize fail 
        public const int MINOR_FIRSTCARD_AUTHORIZE_BEGIN = 0x51; // first card authorize begin 
        public const int MINOR_FIRSTCARD_AUTHORIZE_END = 0x52; // first card authorize end 
        public const int MINOR_DOORLOCK_INPUT_SHORT_CIRCUIT = 0x53; // door lock input short circuit 
        public const int MINOR_DOORLOCK_INPUT_BROKEN_CIRCUIT = 0x54; // door lock input broken circuit 
        public const int MINOR_DOORLOCK_INPUT_EXCEPTION = 0x55; // door lock input exception 
        public const int MINOR_DOORCONTACT_INPUT_SHORT_CIRCUIT = 0x56; // door contact input short circuit 
        public const int MINOR_DOORCONTACT_INPUT_BROKEN_CIRCUIT = 0x57; // door contact input broken circuit 
        public const int MINOR_DOORCONTACT_INPUT_EXCEPTION = 0x58; // door contact input exception 
        public const int MINOR_OPENBUTTON_INPUT_SHORT_CIRCUIT = 0x59; // open button input short circuit 
        public const int MINOR_OPENBUTTON_INPUT_BROKEN_CIRCUIT = 0x5a; // open button input broken circuit 
        public const int MINOR_OPENBUTTON_INPUT_EXCEPTION = 0x5b; // open button input exception 
        public const int MINOR_DOORLOCK_OPEN_EXCEPTION = 0x5c; // door lock open exception 
        public const int MINOR_DOORLOCK_OPEN_TIMEOUT = 0x5d; // door lock open timeout 
        public const int MINOR_FIRSTCARD_OPEN_WITHOUT_AUTHORIZE = 0x5e; // first card open without authorize 
        public const int MINOR_CALL_LADDER_RELAY_BREAK = 0x5f; // call ladder relay break 
        public const int MINOR_CALL_LADDER_RELAY_CLOSE = 0x60; // call ladder relay close 
        public const int MINOR_AUTO_KEY_RELAY_BREAK = 0x61; // auto key relay break 
        public const int MINOR_AUTO_KEY_RELAY_CLOSE = 0x62; // auto key relay close 
        public const int MINOR_KEY_CONTROL_RELAY_BREAK = 0x63; // key control relay break 
        public const int MINOR_KEY_CONTROL_RELAY_CLOSE = 0x64; // key control relay close 
        public const int MINOR_EMPLOYEENO_AND_PW_PASS = 0x65; // minor employee no and password pass 
        public const int MINOR_EMPLOYEENO_AND_PW_FAIL = 0x66; // minor employee no and password fail 
        public const int MINOR_EMPLOYEENO_AND_PW_TIMEOUT = 0x67; // minor employee no and password timeout 
        public const int MINOR_HUMAN_DETECT_FAIL = 0x68; // human detect fail 
        public const int MINOR_PEOPLE_AND_ID_CARD_COMPARE_PASS = 0x69; // the comparison with people and id card success 
        public const int MINOR_PEOPLE_AND_ID_CARD_COMPARE_FAIL = 0x70; // the comparison with people and id card failed 
        public const int MINOR_CERTIFICATE_BLOCKLIST = 0x71; // block list 
        public const int MINOR_LEGAL_MESSAGE = 0x72; // legal message 
        public const int MINOR_ILLEGAL_MESSAGE = 0x73; // illegal messag 
        public const int MINOR_MAC_DETECT = 0x74; // mac detect 
        public const int MINOR_DOOR_OPEN_OR_DORMANT_FAIL = 0x75; //door open or dormant fail
        public const int MINOR_AUTH_PLAN_DORMANT_FAIL = 0x76;  //auth plan dormant fail
        public const int MINOR_CARD_ENCRYPT_VERIFY_FAIL = 0x77; //card encrypt verify fail
        public const int MINOR_SUBMARINEBACK_REPLY_FAIL = 0x78;  //submarineback reply fail
        public const int MINOR_DOOR_OPEN_OR_DORMANT_OPEN_FAIL = 0x82;  //door open or dormant open fail
        public const int MINOR_DOOR_OPEN_OR_DORMANT_LINKAGE_OPEN_FAIL = 0x84; //door open or dormant linkage open fail
        public const int MINOR_TRAILING = 0x85;  //trailing
        public const int MINOR_HEART_BEAT = 0x83;  //heart beat event
        public const int MINOR_REVERSE_ACCESS = 0x86; //reverse access
        public const int MINOR_FORCE_ACCESS = 0x87; //force access
        public const int MINOR_CLIMBING_OVER_GATE = 0x88; //climbing over gate
        public const int MINOR_PASSING_TIMEOUT = 0x89;  //passing timeout
        public const int MINOR_INTRUSION_ALARM = 0x8a;  //intrusion alarm
        public const int MINOR_FREE_GATE_PASS_NOT_AUTH = 0x8b; //free gate pass not auth
        public const int MINOR_DROP_ARM_BLOCK = 0x8c; //drop arm block
        public const int MINOR_DROP_ARM_BLOCK_RESUME = 0x8d;  //drop arm block resume
        public const int MINOR_LOCAL_FACE_MODELING_FAIL = 0x8e;  //device upgrade with module failed
        public const int MINOR_STAY_EVENT = 0x8f;  //stay event
        public const int MINOR_PASSWORD_MISMATCH = 0x97;  //password mismatch
        public const int MINOR_EMPLOYEE_NO_NOT_EXIST = 0x98;  //employee no not exist
        public const int MINOR_COMBINED_VERIFY_PASS = 0x99;  //combined verify pass
        public const int MINOR_COMBINED_VERIFY_TIMEOUT = 0x9a;  //combined verify timeout
        public const int MINOR_VERIFY_MODE_MISMATCH = 0x9b;  //verify mode mismatch
        #endregion

        /*************************************************
        参数配置结构、参数(其中_V30为9000新增)
        **************************************************/
        //校时结构参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TIME
        {
            public int dwYear;
            public int dwMonth;
            public int dwDay;
            public int dwHour;
            public int dwMinute;
            public int dwSecond;
        }

        //时间参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TIME_V30
        {
            public ushort wYear;
            public byte byMonth;
            public byte byDay;
            public byte byHour;
            public byte byMinute;
            public byte bySecond;
            public byte byRes;
            public ushort wMilliSec;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TIME_EX
        {
            public ushort wYear;
            public byte byMonth;
            public byte byDay;
            public byte byHour;
            public byte byMinute;
            public byte bySecond;
            public byte byRes;
        }

        //时间段(子结构)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCHEDTIME
        {
            public byte byStartHour;//开始时间
            public byte byStartMin;//开始时间
            public byte byStopHour;//结束时间
            public byte byStopMin;//结束时间
        }

        /*设备报警和异常处理方式*/
        public const int NOACTION = 0x0;/*无响应*/
        public const int WARNONMONITOR = 0x1;/*监视器上警告*/
        public const int WARNONAUDIOOUT = 0x2;/*声音警告*/
        public const int UPTOCENTER = 0x4;/*上传中心*/
        public const int TRIGGERALARMOUT = 0x8;/*触发报警输出*/
        public const int TRIGGERCATPIC = 0x10;/*触发抓图并上传E-mail*/
        public const int SEND_PIC_FTP = 0x200;  /*抓图并上传ftp*/        

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_STRUCTHEAD
        {
            public ushort wLength;  //结构长度
            public byte byVersion;	/*高低4位分别代表高低版本，后续根据版本和长度进行扩展，不同的版本的长度进行限制*/
            public byte byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HANDLEEXCEPTION_V41
        {
            public uint dwHandleType;/*处理方式,处理方式的"或"结果*/
            /*0x00: 无响应*/
            /*0x01: 监视器上警告*/
            /*0x02: 声音警告*/
            /*0x04: 上传中心*/
            /*0x08: 触发报警输出*/
            /*0x10: 触发JPRG抓图并上传Email*/
            /*0x20: 无线声光报警器联动*/
            /*0x40: 联动电子地图(目前只有PCNVR支持)*/
            /*0x200: 抓图并上传FTP*/ 
            public uint dwMaxRelAlarmOutChanNum; //触发的报警输出通道数（只读）最大支持数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRelAlarmOut; //触发报警通道      
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           //保留
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HANDLEEXCEPTION_V40
        {
            public uint dwHandleType;/*处理方式,处理方式的"或"结果*/
            /*0x00: 无响应*/
            /*0x01: 监视器上警告*/
            /*0x02: 声音警告*/
            /*0x04: 上传中心*/
            /*0x08: 触发报警输出*/
            /*0x10: 触发JPRG抓图并上传Email*/
            /*0x20: 无线声光报警器联动*/
            /*0x40: 联动电子地图(目前只有PCNVR支持)*/
            /*0x200: 抓图并上传FTP*/ 
            public uint dwMaxRelAlarmOutChanNum; //触发的报警输出通道数（只读）最大支持数
            public uint dwRelAlarmOutChanNum; //触发的报警输出通道数 实际支持数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRelAlarmOut; //触发报警通道      
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           //保留
        }

        //报警和异常处理结构(子结构)(多处使用)(9000扩展)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HANDLEEXCEPTION_V30
        {
            public uint dwHandleType;/*处理方式,处理方式的"或"结果*/
            /*0x00: 无响应*/
            /*0x01: 监视器上警告*/
            /*0x02: 声音警告*/
            /*0x04: 上传中心*/
            /*0x08: 触发报警输出*/
            /*0x10: 触发JPRG抓图并上传Email*/
            /*0x20: 无线声光报警器联动*/
            /*0x40: 联动电子地图(目前只有PCNVR支持)*/
            /*0x200: 抓图并上传FTP*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelAlarmOut;//报警触发的输出通道,报警触发的输出,为1表示触发该输出
        }

        //报警和异常处理结构(子结构)(多处使用)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HANDLEEXCEPTION
        {
            public uint dwHandleType;/*处理方式,处理方式的"或"结果*/
            /*0x00: 无响应*/
            /*0x01: 监视器上警告*/
            /*0x02: 声音警告*/
            /*0x04: 上传中心*/
            /*0x08: 触发报警输出*/
            /*0x10: Jpeg抓图并上传EMail*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelAlarmOut;//报警触发的输出通道,报警触发的输出,为1表示触发该输出
        }

        //DVR设备参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEVICECFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDVRName;//DVR名称
            public uint dwDVRID;//DVR ID,用于遥控器 //V1.4(0-99), V1.5(0-255)
            public uint dwRecycleRecord;//是否循环录像,0:不是; 1:是
            //以下不可更改
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;//序列号
            public uint dwSoftwareVersion;//软件版本号,高16位是主版本,低16位是次版本
            public uint dwSoftwareBuildDate;//软件生成日期,0xYYYYMMDD
            public uint dwDSPSoftwareVersion;//DSP软件版本,高16位是主版本,低16位是次版本
            public uint dwDSPSoftwareBuildDate;// DSP软件生成日期,0xYYYYMMDD
            public uint dwPanelVersion;// 前面板版本,高16位是主版本,低16位是次版本
            public uint dwHardwareVersion;// 硬件版本,高16位是主版本,低16位是次版本
            public byte byAlarmInPortNum;//DVR报警输入个数
            public byte byAlarmOutPortNum;//DVR报警输出个数
            public byte byRS232Num;//DVR 232串口个数
            public byte byRS485Num;//DVR 485串口个数
            public byte byNetworkPortNum;//网络口个数
            public byte byDiskCtrlNum;//DVR 硬盘控制器个数
            public byte byDiskNum;//DVR 硬盘个数
            public byte byDVRType;//DVR类型, 1:DVR 2:ATM DVR 3:DVS ......
            public byte byChanNum;//DVR 通道个数
            public byte byStartChan;//起始通道号,例如DVS-1,DVR - 1
            public byte byDecordChans;//DVR 解码路数
            public byte byVGANum;//VGA口的个数
            public byte byUSBNum;//USB口的个数
            public byte byAuxoutNum;//辅口的个数
            public byte byAudioNum;//语音口的个数
            public byte byIPChanNum;//最大数字通道数
        }

        /*IP地址*/
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_IPADDR
        {

            /// char[16]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] sIpV4;

            /// BYTE[128]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byIPv6;

            public void Init()
            {
				sIpV4 = new byte[16];
                byIPv6 = new byte[128];
            }
        }

        /*网络数据结构(子结构)(9000扩展)*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ETHERNET_V30
        {
            public NET_DVR_IPADDR struDVRIP;//DVR IP地址
            public NET_DVR_IPADDR struDVRIPMask;//DVR IP地址掩码
            public uint dwNetInterface;//网络接口：1-10MBase-T；2-10MBase-T全双工；3-100MBase-TX；4-100M全双工；5-10M/100M/1000M自适应；6-1000M全双工
            public ushort wDVRPort;//端口号
            public ushort wMTU;//增加MTU设置，默认1500。
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;// 物理地址
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

		[StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMHOST_NETPARAM
        {
            public uint dwSize;
            public NET_DVR_IPADDR struIP;
            public ushort wPort;
            public byte byAddressType;    //0 - 无意义, 1 - ipv4/ipv6地址，2 - 域名
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byDomainName;
            public byte byReportProtocol;        //1-private 2-NAL2300, 3-Ehome
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = ACCOUNTNUM_LEN_32, ArraySubType = UnmanagedType.I1)]
            public byte[] byDevID; //协议为NAL2300时有效
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //GPRS的域名解析是在固定的服务器上进行的，所以不需要给解析服务器的信息预留一些字段
        }
		
		
		
        /*网络数据结构(子结构)*/
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_ETHERNET
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDVRIP;//DVR IP地址
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDVRIPMask;//DVR IP地址掩码
            public uint dwNetInterface;//网络接口 1-10MBase-T 2-10MBase-T全双工 3-100MBase-TX 4-100M全双工 5-10M/100M自适应
            public ushort wDVRPort;//端口号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;//服务器的物理地址
        }

        //pppoe结构
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_PPPOECFG
        {
            public uint dwPPPOE;//0-不启用,1-启用
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPPPoEUser;//PPPoE用户名
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PASSWD_LEN)]
            public string sPPPoEPassword;// PPPoE密码
            public NET_DVR_IPADDR struPPPoEIP;//PPPoE IP地址
        }

        //网络配置结构(9000扩展)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NETCFG_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ETHERNET, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ETHERNET_V30[] struEtherNet;//以太网口
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPADDR[] struRes1;/*保留*/
            public NET_DVR_IPADDR struAlarmHostIpAddr;/* 报警主机IP地址 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public ushort wAlarmHostIpPort;
            public byte byUseDhcp;
            public byte byRes3;
            public NET_DVR_IPADDR struDnsServer1IpAddr;/* 域名服务器1的IP地址 */
            public NET_DVR_IPADDR struDnsServer2IpAddr;/* 域名服务器2的IP地址 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byIpResolver;
            public ushort wIpResolverPort;
            public ushort wHttpPortNo;
            public NET_DVR_IPADDR struMulticastIpAddr;/* 多播组地址 */
            public NET_DVR_IPADDR struGatewayIpAddr;/* 网关地址 */
            public NET_DVR_PPPOECFG struPPPoE;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //单个网卡配置信息结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ETHERNET_MULTI
        {
            public NET_DVR_IPADDR struDVRIP;
            public NET_DVR_IPADDR struDVRIPMask;
            public uint dwNetInterface;
            public byte byCardType;  //网卡类型，0-普通网卡，1-内网网卡，2-外网网卡
            public byte byRes1;
            public ushort wMTU;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public byte byUseDhcp;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
            public NET_DVR_IPADDR struGatewayIpAddr;
            public NET_DVR_IPADDR struDnsServer1IpAddr;
            public NET_DVR_IPADDR struDnsServer2IpAddr;
        }

        //多网卡网络配置结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NETCFG_MULTI
        {
            public uint dwSize;
            public byte byDefaultRoute;
            public byte byNetworkCardNum;
            public byte byWorkMode;   //0-普通多网卡模式，1-内外网隔离模式
            public byte byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NETWORK_CARD, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ETHERNET_MULTI[] struEtherNet;//以太网口
            public NET_DVR_IPADDR struManageHost1IpAddr;
            public NET_DVR_IPADDR struManageHost2IpAddr;
            public NET_DVR_IPADDR struAlarmHostIpAddr;
            public ushort wManageHost1Port;
            public ushort wManageHost2Port;
            public ushort wAlarmHostIpPort;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byIpResolver;
            public ushort wIpResolverPort;
            public ushort wDvrPort;
            public ushort wHttpPortNo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public NET_DVR_IPADDR struMulticastIpAddr;/* 多播组地址 */
            public NET_DVR_PPPOECFG struPPPoE;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }

        //网络配置结构
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_NETCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ETHERNET, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ETHERNET[] struEtherNet;/* 以太网口 */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sManageHostIP;//远程管理主机地址
            public ushort wManageHostPort;//远程管理主机端口号
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sIPServerIP;//IPServer服务器地址
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sMultiCastIP;//多播组地址
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sGatewayIP;//网关地址
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sNFSIP;//NFS主机IP地址
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PATHNAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sNFSDirectory;//NFS目录
            public uint dwPPPOE;//0-不启用,1-启用
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPPPoEUser;//PPPoE用户名
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PASSWD_LEN)]
            public string sPPPoEPassword;// PPPoE密码
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sPPPoEIP;//PPPoE IP地址(只读)
            public ushort wHttpPort;//HTTP端口号
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_SIP_CFG
        {
            public uint dwSize;
            public byte byEnableAutoLogin;    //使能自动注册，0-不使能，1-使能
            public byte byLoginStatus;  //注册状态，0-未注册，1-已注册，此参数只能获取
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_IPADDR stuServerIP;  //SIP服务器IP
            public ushort wServerPort;    //SIP服务器端口
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byUserName;  //注册用户名
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPassWord; //注册密码
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NUMBER_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalNo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDispalyName; //设备显示名称
            public ushort wLocalPort;     //本地端口
            public byte byLoginCycle;   //注册周期，1-99分钟
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 129, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //IP可视对讲分机配置
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_IP_VIEW_DEVCFG
        {
            public uint dwSize;
            public byte byDefaultRing; //默认铃音，范围1-6
            public byte byRingVolume;  //铃音音量，范围0-9
            public byte byInputVolume; //输入音量值，范围0-6
            public byte byOutputVolume; //输出音量值，范围0-9	
            public ushort wRtpPort;  //Rtp端口
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwPreviewDelayTime; //预览延时配置，0-30秒
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }
        
        //Ip可视对讲音频相关参数配置
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_IP_VIEW_AUDIO_CFG
        {
            public uint dwSize;	
            public byte byAudioEncPri1; //音频编码优先级1，0-OggVorbis，1-G711_U，2-G711_A， 5-MPEG2,6-G726，7-AAC
            public byte byAudioEncPri2; //音频编码优先级2，当sip服务器不支持音频编码1时会使用音频编码2，0-OggVorbis，1-G711_U，2-G711_A， 5-MPEG2,6-G726，7-AAC
            public ushort wAudioPacketLen1; //音频编码1数据包长度
            public ushort wAudioPacketLen2; //音频编码2数据包长度
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        
        //IP分机呼叫对讲参数配置结构体
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_IP_VIEW_CALL_CFG
        {
            public uint dwSize ;
            public byte byEnableAutoResponse; //使能自动应答,0-不使能，1-使能
            public byte byAudoResponseTime; //自动应答时间，0-30秒
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byEnableAlarmNumber1; //启动报警号码1，0-不启动，1-启动
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NUMBER_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmNumber1; //呼叫号码1
            public byte byEnableAlarmNumber2; //启动报警号码2，0-不启动，1-启动
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NUMBER_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmNumber2; //呼叫号码2，呼叫号码1失败会尝试呼叫号码2
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 72, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes4;
        }
        
        //通道图象结构
        //移动侦测(子结构)(按组方式扩展)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_RECORDCHAN
        {    
            public uint dwMaxRecordChanNum;   //设备支持的最大关联录像通道数-只读
            public uint dwCurRecordChanNum;   //当前实际已配置的关联录像通道数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.U4)]
            public uint dwRelRecordChan;	 /* 实际触发录像通道，按值表示,采用紧凑型排列，从下标0 - MAX_CHANNUM_V30-1有效，如果中间遇到0xffffffff,则后续无效*/  
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;          //保留
        }             

        //通道图象结构
        //移动侦测(子结构)(9000扩展)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MOTION_V30
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 96*64, ArraySubType = UnmanagedType.I1)]
            public byte[] byMotionScope;/*侦测区域,0-96位,表示64行,共有96*64个小宏块,为1表示是移动侦测区域,0-表示不是*/
            public byte byMotionSensitive;/*移动侦测灵敏度, 0 - 5,越高越灵敏,oxff关闭*/
            public byte byEnableHandleMotion;/* 是否处理移动侦测 0－否 1－是*/
            public byte byEnableDisplay;/* 启用移动侦测高亮显示：0- 否，1- 是 */
            public byte reservedData;
            public NET_DVR_HANDLEEXCEPTION_V30 struMotionHandleType;/* 处理方式 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;/*布防时间*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;/* 报警触发的录象通道*/
        }

        //移动侦测(子结构)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MOTION
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 396, ArraySubType = UnmanagedType.I1)]
            public byte[] byMotionScope;/*侦测区域,共有22*18个小宏块,为1表示改宏块是移动侦测区域,0-表示不是*/
            public byte byMotionSensitive;/*移动侦测灵敏度, 0 - 5,越高越灵敏,0xff关闭*/
            public byte byEnableHandleMotion;/* 是否处理移动侦测 */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 2)]
            public string reservedData;
            public NET_DVR_HANDLEEXCEPTION strMotionHandleType;/* 处理方式 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//布防时间
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;//报警触发的录象通道,为1表示触发该通道
        }

        //遮挡报警(子结构)(9000扩展)  区域大小704*576
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HIDEALARM_V30
        {
            public uint dwEnableHideAlarm;/* 是否启动遮挡报警 ,0-否,1-低灵敏度 2-中灵敏度 3-高灵敏度*/
            public ushort wHideAlarmAreaTopLeftX;/* 遮挡区域的x坐标 */
            public ushort wHideAlarmAreaTopLeftY;/* 遮挡区域的y坐标 */
            public ushort wHideAlarmAreaWidth;/* 遮挡区域的宽 */
            public ushort wHideAlarmAreaHeight;/*遮挡区域的高*/
            public NET_DVR_HANDLEEXCEPTION_V30 strHideAlarmHandleType;	/* 处理方式 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//布防时间
        }

        //遮挡报警(子结构)  区域大小704*576
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HIDEALARM
        {
            public uint dwEnableHideAlarm;/* 是否启动遮挡报警 ,0-否,1-低灵敏度 2-中灵敏度 3-高灵敏度*/
            public ushort wHideAlarmAreaTopLeftX;/* 遮挡区域的x坐标 */
            public ushort wHideAlarmAreaTopLeftY;/* 遮挡区域的y坐标 */
            public ushort wHideAlarmAreaWidth;/* 遮挡区域的宽 */
            public ushort wHideAlarmAreaHeight;/*遮挡区域的高*/
            public NET_DVR_HANDLEEXCEPTION strHideAlarmHandleType;/* 处理方式 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//布防时间
        }

        //信号丢失报警(子结构)(9000扩展)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VILOST_V30
        {
            public byte byEnableHandleVILost;/* 是否处理信号丢失报警 */
            public NET_DVR_HANDLEEXCEPTION_V30 strVILostHandleType;/* 处理方式 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 56, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//布防时间
        }

        //信号丢失报警(子结构)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VILOST
        {
            public byte byEnableHandleVILost;/* 是否处理信号丢失报警 */
            public NET_DVR_HANDLEEXCEPTION strVILostHandleType;/* 处理方式 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//布防时间
        }

        //遮挡区域(子结构)
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct NET_DVR_SHELTER
        {
            public ushort wHideAreaTopLeftX;/* 遮挡区域的x坐标 */
            public ushort wHideAreaTopLeftY;/* 遮挡区域的y坐标 */
            public ushort wHideAreaWidth;/* 遮挡区域的宽 */
            public ushort wHideAreaHeight;/*遮挡区域的高*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COLOR
        {
            public byte byBrightness;/*亮度,0-255*/
            public byte byContrast;/*对比度,0-255*/
            public byte bySaturation;/*饱和度,0-255*/
            public byte byHue;/*色调,0-255*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_RGB_COLOR
        {
            public byte byRed;	 //RGB颜色三分量中的红色
            public byte byGreen; //RGB颜色三分量中的绿色
            public byte byBlue;	//RGB颜色三分量中的蓝色
            public byte byRes;	//保留
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_DAYTIME
        {
            public byte byHour;//0~24
            public byte byMinute;//0~60
            public byte bySecond;//0~60
            public byte byRes;
            public ushort wMilliSecond; //0~1000
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_SCHEDULE_DAYTIME
        {
            public NET_DVR_DAYTIME struStartTime; //开始时间
            public NET_DVR_DAYTIME struStopTime; //结束时间
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_DNMODE
        {
            public byte byObjectSize;//占比参数(0~100)
            public byte byMotionSensitive; /*移动侦测灵敏度, 0 - 5,越高越灵敏,0xff关闭*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MOTION_MULTI_AREAPARAM
        {
            public byte byAreaNo;//区域编号(IPC- 1~8)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_VCA_RECT struRect;//单个区域的坐标信息(矩形) size = 16;
	        public NET_DVR_DNMODE  struDayNightDisable;//关闭模式
            public NET_DVR_DNMODE  struDayModeParam;//白天模式
            public NET_DVR_DNMODE  struNightModeParam;//夜晚模式
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MOTION_MULTI_AREA
        {
            public byte byDayNightCtrl;//日夜控制 0~关闭,1~自动切换,2~定时切换(默认关闭)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_SCHEDULE_DAYTIME struScheduleTime;//切换时间  16
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_MULTI_AREA_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MOTION_MULTI_AREAPARAM[] struMotionMultiAreaParam;//最大支持24个区域
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MOTION_SINGLE_AREA
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64*96, ArraySubType = UnmanagedType.I1)]
            public byte[]byMotionScope;		/*侦测区域,0-96位,表示64行,共有96*64个小宏块,目前有效的是22*18,为1表示是移动侦测区域,0-表示不是*/
            public byte byMotionSensitive;			/*移动侦测灵敏度, 0 - 5,越高越灵敏,0xff关闭*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }


        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MOTION_MODE_PARAM
        {
            public NET_DVR_MOTION_SINGLE_AREA  struMotionSingleArea; //普通模式下的单区域设
            public NET_DVR_MOTION_MULTI_AREA struMotionMultiArea; //专家模式下的多区域设置	
        }

        //移动侦测
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MOTION_V40
        {	
            public NET_DVR_MOTION_MODE_PARAM struMotionMode; //(5.1.0新增)
            public byte byEnableHandleMotion;		/* 是否处理移动侦测 0－否 1－是*/ 
            public byte byEnableDisplay;	/*启用移动侦测高亮显示，0-否，1-是*/
            public byte byConfigurationMode; //0~普通,1~专家(5.1.0新增)
            public byte byRes1; //保留字节
            /* 异常处理方式 */
            public uint dwHandleType;        //异常处理,异常处理方式的"或"结果  
            /*0x00: 无响应*/
            /*0x01: 监视器上警告*/
            /*0x02: 声音警告*/
            /*0x04: 上传中心*/
            /*0x08: 触发报警输出*/
            /*0x10: 触发JPRG抓图并上传Email*/
            /*0x20: 无线声光报警器联动*/
            /*0x40: 联动电子地图(目前只有PCNVR支持)*/
            /*0x200: 抓图并上传FTP*/ 
            public uint dwMaxRelAlarmOutChanNum ; //触发的报警输出通道数（只读）最大支持数量
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRelAlarmOut; //实际触发的报警输出号，按值表示,采用紧凑型排列，从下标0 - dwRelAlarmOut -1有效，如果中间遇到0xffffffff,则后续无效
	        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS*MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime; /*布防时间*/
            /*触发的录像通道*/
            public uint dwMaxRecordChanNum;   //设备支持的最大关联录像通道数-只读
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRelRecordChan;	 /* 实际触发录像通道，按值表示,采用紧凑型排列，从下标0 - dwRelRecordChan -1有效，如果中间遇到0xffffffff,则后续无效*/  
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //保留字节
        }

        //遮挡报警
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_HIDEALARM_V40
        {
            public uint dwEnableHideAlarm;  /* 是否启动遮挡报警，0-否，1-低灵敏度，2-中灵敏度，3-高灵敏度*/
            public ushort wHideAlarmAreaTopLeftX;			/* 遮挡区域的x坐标 */
            public ushort wHideAlarmAreaTopLeftY;			/* 遮挡区域的y坐标 */
            public ushort wHideAlarmAreaWidth;				/* 遮挡区域的宽 */
            public ushort wHideAlarmAreaHeight;				/*遮挡区域的高*/ 
            /* 信号丢失触发报警输出 */	
            public uint dwHandleType;        //异常处理,异常处理方式的"或"结果  
            /*0x00: 无响应*/
            /*0x01: 监视器上警告*/
            /*0x02: 声音警告*/
            /*0x04: 上传中心*/
            /*0x08: 触发报警输出*/
            /*0x10: 触发JPRG抓图并上传Email*/
            /*0x20: 无线声光报警器联动*/
            /*0x40: 联动电子地图(目前只有PCNVR支持)*/
            /*0x200: 抓图并上传FTP*/ 
            public uint dwMaxRelAlarmOutChanNum ; //触发的报警输出通道数（只读）最大支持数量
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRelAlarmOut; /*触发报警输出号，按值表示,采用紧凑型排列，从下标0 - dwRelAlarmOut -1有效，如果中间遇到0xffffffff,则后续无效*/  	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS*MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime; /*布防时间*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //保留
        } 

        //信号丢失报警
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_VILOST_V40
        {
            public uint dwEnableVILostAlarm;				/* 是否启动信号丢失报警 ,0-否,1-是*/	 
            /* 信号丢失触发报警输出 */	
            public uint dwHandleType;        //异常处理,异常处理方式的"或"结果     
            /*0x00: 无响应*/    
            /*0x01: 监视器上警告*/    
            /*0x02: 声音警告*/    
            /*0x04: 上传中心*/    
            /*0x08: 触发报警输出*/    
            /*0x10: 触发JPRG抓图并上传Email*/    
            /*0x20: 无线声光报警器联动*/    
            /*0x40: 联动电子地图(目前只有PCNVR支持)*/    
            /*0x200: 抓图并上传FTP*/ 
            public uint dwMaxRelAlarmOutChanNum ; //触发的报警输出通道数（只读）最大支持数量
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRelAlarmOut; /*触发报警输出号，按值表示,采用紧凑型排列，从下标0 - dwRelAlarmOut -1有效，如果中间遇到0xffffffff,则后续无效*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS*MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime; /*布防时间*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //保留
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_VICOLOR
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_COLOR[]	  struColor;/*图象参数(第一个有效，其他三个保留)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[]  struHandleTime;/*处理时间段(保留)*/
        }

        //通道图象结构(V40扩展)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_PICCFG_V40
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sChanName; 
            public uint dwVideoFormat;	/* 只读 视频制式 1-NTSC 2-PAL  */
            public NET_DVR_VICOLOR struViColor;//	图像参数按时间段设置
	        //显示通道名
            public uint dwShowChanName; // 预览的图象上是否显示通道名称,0-不显示,1-显示
            public ushort wShowNameTopLeftX;				/* 通道名称显示位置的x坐标 */
            public ushort wShowNameTopLeftY;				/* 通道名称显示位置的y坐标 */
	        //隐私遮挡
            public uint dwEnableHide;		/* 是否启动遮挡 ,0-否,1-是*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SHELTERNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SHELTER[] struShelter;
            //OSD
            public uint dwShowOsd;// 预览的图象上是否显示OSD,0-不显示,1-显示
            public ushort wOSDTopLeftX;				/* OSD的x坐标 */
            public ushort wOSDTopLeftY;				/* OSD的y坐标 */
            public byte byOSDType;					/* OSD类型(主要是年月日格式) */
            /* 0: XXXX-XX-XX 年月日 */
            /* 1: XX-XX-XXXX 月日年 */
            /* 2: XXXX年XX月XX日 */
            /* 3: XX月XX日XXXX年 */
            /* 4: XX-XX-XXXX 日月年*/
            /* 5: XX日XX月XXXX年 */
            /*6: xx/xx/xxxx(月/日/年) */
            /*7: xxxx/xx/xx(年/月/日) */
            /*8: xx/xx/xxxx(日/月/年)*/
            public byte byDispWeek;				/* 是否显示星期 */
            public byte byOSDAttrib;				/* OSD属性:透明，闪烁 */
            /* 0: 不显示OSD */
            /* 1: 透明，闪烁 */
            /* 2: 透明，不闪烁 */
            /* 3: 不透明，闪烁 */
            /* 4: 不透明，不闪烁 */	
            public byte byHourOSDType;				/* OSD小时制:0-24小时制,1-12小时制 */
            public byte byFontSize;      //16*16(中)/8*16(英)，1-32*32(中)/16*32(英)，2-64*64(中)/32*64(英) FOR 91系列HD-SDI高清DVR
            public byte byOSDColorType;	 //0-默认（黑白）；1-自定义
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_VILOST_V40 struVILost;  //视频信号丢失报警（支持组）
            public NET_DVR_VILOST_V40 struAULost;  /*音频信号丢失报警（支持组）*/
            public NET_DVR_MOTION_V40 struMotion;  //移动侦测报警（支持组）
            public NET_DVR_HIDEALARM_V40 struHideAlarm;  //遮挡报警（支持组）
            public NET_DVR_RGB_COLOR struOsdColor;//OSD颜色
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //通道图象结构(9000扩展)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_PICCFG_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sChanName;
            public uint dwVideoFormat;/* 只读 视频制式 1-NTSC 2-PAL*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byReservedData;/*保留*/
            //显示通道名
            public uint dwShowChanName;// 预览的图象上是否显示通道名称,0-不显示,1-显示 区域大小704*576
            public ushort wShowNameTopLeftX;/* 通道名称显示位置的x坐标 */
            public ushort wShowNameTopLeftY;/* 通道名称显示位置的y坐标 */
            //视频信号丢失报警
            public NET_DVR_VILOST_V30 struVILost;
            public NET_DVR_VILOST_V30 struRes;/*保留*/
            //移动侦测
            public NET_DVR_MOTION_V30 struMotion;
            //遮挡报警
            public NET_DVR_HIDEALARM_V30 struHideAlarm;
            //遮挡  区域大小704*576
            public uint dwEnableHide;/* 是否启动遮挡 ,0-否,1-是*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SHELTERNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SHELTER[] struShelter;
            //OSD
            public uint dwShowOsd;// 预览的图象上是否显示OSD,0-不显示,1-显示 区域大小704*576
            public ushort wOSDTopLeftX;/* OSD的x坐标 */
            public ushort wOSDTopLeftY;/* OSD的y坐标 */
            public byte byOSDType;/* OSD类型(主要是年月日格式) */
            /* 0: XXXX-XX-XX 年月日 */
            /* 1: XX-XX-XXXX 月日年 */
            /* 2: XXXX年XX月XX日 */
            /* 3: XX月XX日XXXX年 */
            /* 4: XX-XX-XXXX 日月年*/
            /* 5: XX日XX月XXXX年 */
            public byte byDispWeek;/* 是否显示星期 */
            public byte byOSDAttrib;/* OSD属性:透明，闪烁 */
            /* 0: 不显示OSD */
            /* 1: 透明,闪烁 */
            /* 2: 透明,不闪烁 */
            /* 3: 闪烁,不透明 */
            /* 4: 不透明,不闪烁 */
            public byte byHourOSDType;/* OSD小时制:0-24小时制,1-12小时制 */
            public byte byFontSize;//字体大小，16*16(中)/8*16(英)，1-32*32(中)/16*32(英)，2-64*64(中)/32*64(英)  3-48*48(中)/24*48(英) 0xff-自适应(adaptive)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //通道图象结构SDK_V14扩展
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PICCFG_EX
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sChanName;
            public uint dwVideoFormat;/* 只读 视频制式 1-NTSC 2-PAL*/
            public byte byBrightness;/*亮度,0-255*/
            public byte byContrast;/*对比度,0-255*/
            public byte bySaturation;/*饱和度,0-255 */
            public byte byHue;/*色调,0-255*/
            //显示通道名
            public uint dwShowChanName;// 预览的图象上是否显示通道名称,0-不显示,1-显示 区域大小704*576
            public ushort wShowNameTopLeftX;/* 通道名称显示位置的x坐标 */
            public ushort wShowNameTopLeftY;/* 通道名称显示位置的y坐标 */
            //信号丢失报警
            public NET_DVR_VILOST struVILost;
            //移动侦测
            public NET_DVR_MOTION struMotion;
            //遮挡报警
            public NET_DVR_HIDEALARM struHideAlarm;
            //遮挡  区域大小704*576
            public uint dwEnableHide;/* 是否启动遮挡 ,0-否,1-是*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SHELTERNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SHELTER[] struShelter;
            //OSD
            public uint dwShowOsd;// 预览的图象上是否显示OSD,0-不显示,1-显示 区域大小704*576
            public ushort wOSDTopLeftX;/* OSD的x坐标 */
            public ushort wOSDTopLeftY;/* OSD的y坐标 */
            public byte byOSDType;/* OSD类型(主要是年月日格式) */
            /* 0: XXXX-XX-XX 年月日 */
            /* 1: XX-XX-XXXX 月日年 */
            /* 2: XXXX年XX月XX日 */
            /* 3: XX月XX日XXXX年 */
            /* 4: XX-XX-XXXX 日月年*/
            /* 5: XX日XX月XXXX年 */
            public byte byDispWeek;/* 是否显示星期 */
            public byte byOSDAttrib;/* OSD属性:透明，闪烁 */
            /* 0: 不显示OSD */
            /* 1: 透明,闪烁 */
            /* 2: 透明,不闪烁 */
            /* 3: 闪烁,不透明 */
            /* 4: 不透明,不闪烁 */
            public byte byHourOsdType;/* OSD小时制:0-24小时制,1-12小时制 */
        }

        //通道图象结构(SDK_V13及之前版本)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PICCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sChanName;
            public uint dwVideoFormat;/* 只读 视频制式 1-NTSC 2-PAL*/
            public byte byBrightness;/*亮度,0-255*/
            public byte byContrast;/*对比度,0-255*/
            public byte bySaturation;/*饱和度,0-255 */
            public byte byHue;/*色调,0-255*/
            //显示通道名
            public uint dwShowChanName;// 预览的图象上是否显示通道名称,0-不显示,1-显示 区域大小704*576
            public ushort wShowNameTopLeftX;/* 通道名称显示位置的x坐标 */
            public ushort wShowNameTopLeftY;/* 通道名称显示位置的y坐标 */
            //信号丢失报警
            public NET_DVR_VILOST struVILost;
            //移动侦测
            public NET_DVR_MOTION struMotion;
            //遮挡报警
            public NET_DVR_HIDEALARM struHideAlarm;
            //遮挡  区域大小704*576
            public uint dwEnableHide;/* 是否启动遮挡 ,0-否,1-是*/
            public ushort wHideAreaTopLeftX;/* 遮挡区域的x坐标 */
            public ushort wHideAreaTopLeftY;/* 遮挡区域的y坐标 */
            public ushort wHideAreaWidth;/* 遮挡区域的宽 */
            public ushort wHideAreaHeight;/*遮挡区域的高*/
            //OSD
            public uint dwShowOsd;// 预览的图象上是否显示OSD,0-不显示,1-显示 区域大小704*576
            public ushort wOSDTopLeftX;/* OSD的x坐标 */
            public ushort wOSDTopLeftY;/* OSD的y坐标 */
            public byte byOSDType;/* OSD类型(主要是年月日格式) */
            /* 0: XXXX-XX-XX 年月日 */
            /* 1: XX-XX-XXXX 月日年 */
            /* 2: XXXX年XX月XX日 */
            /* 3: XX月XX日XXXX年 */
            /* 4: XX-XX-XXXX 日月年*/
            /* 5: XX日XX月XXXX年 */
            public byte byDispWeek;/* 是否显示星期 */
            public byte byOSDAttrib;/* OSD属性:透明，闪烁 */
            /* 0: 不显示OSD */
            /* 1: 透明,闪烁 */
            /* 2: 透明,不闪烁 */
            /* 3: 闪烁,不透明 */
            /* 4: 不透明,不闪烁 */
            public byte reservedData2;
        }
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MULTI_STREAM_COMPRESSIONCFG_COND
        {
            public uint dwSize;
            public NET_DVR_STREAM_INFO struStreamInfo;
            public uint dwStreamType; //码流类型，0-主码流，1-子码流，2-事件类型，3-码流3，……（自定义码流类型需通过GET /ISAPI/Streaming/channels/<ID>/customStream获取当前通道已经添加的所有自定义码流ID。自定义码流为6~10，其索引值就是6~10）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MULTI_STREAM_COMPRESSIONCFG
        {
            public uint dwSize;
            public uint dwStreamType;        //码流类型，0-主码流，1-子码流，2-事件类型，3-码流3，……
            public NET_DVR_COMPRESSION_INFO_V30 struStreamPara;        //码流压缩参数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 80, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //码流压缩参数(子结构)(9000扩展)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSION_INFO_V30
        {
            public byte byStreamType;//码流类型 0-视频流, 1-复合流, 表示事件压缩参数时最高位表示是否启用压缩参数
            public byte byResolution;//分辨率0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF 5（保留）16-VGA（640*480） 17-UXGA（1600*1200） 18-SVGA （800*600）19-HD720p（1280*720）20-XVGA  21-HD900p
            public byte byBitrateType;//码率类型 0:变码率, 1:定码率
            public byte byPicQuality;//图象质量 0-最好 1-次好 2-较好 3-一般 4-较差 5-差
            public uint dwVideoBitrate;//视频码率 0-保留 1-16K 2-32K 3-48k 4-64K 5-80K 6-96K 7-128K 8-160k 9-192K 10-224K 11-256K 12-320K
            // 13-384K 14-448K 15-512K 16-640K 17-768K 18-896K 19-1024K 20-1280K 21-1536K 22-1792K 23-2048K
            //最高位(31位)置成1表示是自定义码流, 0-30位表示码流值。
            public uint dwVideoFrameRate;//帧率 0-全部; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20; V2.0版本中新加14-15; 15-18; 16-22;
            public ushort wIntervalFrameI;//I帧间隔
            //2006-08-11 增加单P帧的配置接口，可以改善实时流延时问题
            public byte byIntervalBPFrame;//0-BBP帧; 1-BP帧; 2-单P帧
            public byte byres1; //保留
            public byte byVideoEncType;//视频编码类型 0 hik264;1标准h264; 2标准mpeg4;
            public byte byAudioEncType; //音频编码类型 0－OggVorbis
            public byte byVideoEncComplexity; //视频编码复杂度，0-低，1-中，2高,0xfe:自动，和源一致
            public byte byEnableSvc; //0 - 不启用SVC功能；1- 启用SVC功能
            public byte byFormatType; //封装类型，1-裸流，2-RTP封装，3-PS封装，4-TS封装，5-私有，6-FLV，7-ASF，8-3GP,9-RTP+PS（国标：GB28181），0xff-无效
            public byte byAudioBitRate; //音频码率0-默认，1-8Kbps, 2- 16Kbps, 3-32Kbps，4-64Kbps，5-128Kbps，6-192Kbps；(IPC5.1.0默认4-64Kbps)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byres;//这里保留音频的压缩参数
        }

        //通道压缩参数(9000扩展)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSIONCFG_V30
        {
            public uint dwSize;
            public NET_DVR_COMPRESSION_INFO_V30 struNormHighRecordPara;//录像 对应8000的普通
            public NET_DVR_COMPRESSION_INFO_V30 struRes;//保留 char reserveData[28];
            public NET_DVR_COMPRESSION_INFO_V30 struEventRecordPara;//事件触发压缩参数
            public NET_DVR_COMPRESSION_INFO_V30 struNetPara;//网传(子码流)
        }

        //码流压缩参数(子结构)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSION_INFO
        {
            public byte byStreamType;//码流类型0-视频流,1-复合流,表示压缩参数时最高位表示是否启用压缩参数
            public byte byResolution;//分辨率0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF, 5-2QCIF(352X144)(车载专用)
            public byte byBitrateType;//码率类型0:变码率，1:定码率
            public byte byPicQuality;//图象质量 0-最好 1-次好 2-较好 3-一般 4-较差 5-差
            public uint dwVideoBitrate; //视频码率 0-保留 1-16K(保留) 2-32K 3-48k 4-64K 5-80K 6-96K 7-128K 8-160k 9-192K 10-224K 11-256K 12-320K
            // 13-384K 14-448K 15-512K 16-640K 17-768K 18-896K 19-1024K 20-1280K 21-1536K 22-1792K 23-2048K
            //最高位(31位)置成1表示是自定义码流, 0-30位表示码流值(MIN-32K MAX-8192K)。
            public uint dwVideoFrameRate;//帧率 0-全部; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20;
        }

        //通道压缩参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSIONCFG
        {
            public uint dwSize;
            public NET_DVR_COMPRESSION_INFO struRecordPara;//录像/事件触发录像
            public NET_DVR_COMPRESSION_INFO struNetPara;//网传/保留
        }

        //码流压缩参数(子结构)(扩展) 增加I帧间隔
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSION_INFO_EX
        {
            public byte byStreamType;//码流类型0-视频流, 1-复合流
            public byte byResolution;//分辨率0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF, 5-2QCIF(352X144)(车载专用)
            public byte byBitrateType;//码率类型0:变码率，1:定码率
            public byte byPicQuality;//图象质量 0-最好 1-次好 2-较好 3-一般 4-较差 5-差
            public uint dwVideoBitrate;//视频码率 0-保留 1-16K(保留) 2-32K 3-48k 4-64K 5-80K 6-96K 7-128K 8-160k 9-192K 10-224K 11-256K 12-320K
            // 13-384K 14-448K 15-512K 16-640K 17-768K 18-896K 19-1024K 20-1280K 21-1536K 22-1792K 23-2048K
            //最高位(31位)置成1表示是自定义码流, 0-30位表示码流值(MIN-32K MAX-8192K)。
            public uint dwVideoFrameRate;//帧率 0-全部; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20, //V2.0增加14-15, 15-18, 16-22;
            public ushort wIntervalFrameI;//I帧间隔
            //2006-08-11 增加单P帧的配置接口，可以改善实时流延时问题
            public byte byIntervalBPFrame;//0-BBP帧; 1-BP帧; 2-单P帧
            public byte byRes;
        }

        //通道压缩参数(扩展)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSIONCFG_EX
        {
            public uint dwSize;
            public NET_DVR_COMPRESSION_INFO_EX struRecordPara;//录像
            public NET_DVR_COMPRESSION_INFO_EX struNetPara;//网传
        }

        //时间段录像参数配置(子结构)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_RECORDSCHED
        {
            public NET_DVR_SCHEDTIME struRecordTime;
            public byte byRecordType;//0:定时录像，1:移动侦测，2:报警录像，3:动测|报警，4:动测&报警, 5:命令触发, 6: 智能录像
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 3)]
            public string reservedData;
        }

        //全天录像参数配置(子结构)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECORDDAY
        {
            public ushort wAllDayRecord;/* 是否全天录像 0-否 1-是*/
            public byte byRecordType;/* 录象类型 0:定时录像，1:移动侦测，2:报警录像，3:动测|报警，4:动测&报警 5:命令触发, 6: 智能录像*/
            public byte reservedData;
        }
        
        //时间段录像参数配置(子结构)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECORDSCHED_V40
        {
            public NET_DVR_SCHEDTIME  struRecordTime;
            /*录像类型，0:定时录像，1:移动侦测，2:报警录像，3:动测|报警，4:动测&报警 5:命令触发, 
            6-智能报警录像，10-PIR报警，11-无线报警，12-呼救报警，13-全部事件,14-智能交通事件, 
            15-越界侦测,16-区域入侵,17-声音异常,18-场景变更侦测,
            19-智能侦测(越界侦测|区域入侵|人脸侦测|声音异常|场景变更侦测),20－人脸侦测,21-POS录像,
            22-进入区域侦测, 23-离开区域侦测,24-徘徊侦测,25-人员聚集侦测,26-快速运动侦测,27-停车侦测,
            28-物品遗留侦测,29-物品拿取侦测,30-火点检测，31-防破坏检测,32-打架斗殴事件(司法),33-起身事件(司法), 34-瞌睡事件(司法)
            35-船只检测, 36-测温预警，37-测温报警，38-温差报警，39-离线测温报警,40-防区报警，41-紧急求助,42-业务咨询,43-起身检测,44-折线攀高,45-如厕超时，46-人脸抓拍，47-非法摆摊,48-目标抓拍,
            49-剧烈运动，50离岗检测，51-起立，52人数变化 */
            public byte byRecordType; 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 31, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

         //全天录像参数配置(子结构)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECORDDAY_V40
        {
            public byte byAllDayRecord; /* 是否全天录像 0-否 1-是*/
                         /*录像类型，0:定时录像，1:移动侦测，2:报警录像，3:动测|报警，4:动测&报警 5:命令触发, 
                         6-智能报警录像，10-PIR报警，11-无线报警，12-呼救报警，13-全部事件,14-智能交通事件, 
                         15-越界侦测,16-区域入侵,17-声音异常,18-场景变更侦测,
                         19-智能侦测(越界侦测|区域入侵|人脸侦测|声音异常|场景变更侦测),20－人脸侦测,21-POS录像,
                         22-进入区域侦测, 23-离开区域侦测,24-徘徊侦测,25-人员聚集侦测,26-快速运动侦测,27-停车侦测,
                         28-物品遗留侦测,29-物品拿取侦测,30-火点检测，31-防破坏检测,32-打架斗殴事件(司法),33-起身事件(司法), 34-瞌睡事件(司法)
                         35-船只检测, 36-测温预警，37-测温报警，38-温差报警，39-离线测温报警,40-防区报警，41-紧急求助,42-业务咨询,43-起身检测,44-折线攀高,45-如厕超时,46-人脸抓拍,47-非法摆摊,48-目标抓拍,
                         49-剧烈运动，50离岗检测，51-起立，52人数变化*/
            public byte byRecordType; 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 62, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECORD_V40
        {
            public uint dwSize;
            public uint dwRecord;                          /*是否录像 0-否 1-是*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_RECORDDAY_V40[] struRecAllDay;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_RECORDSCHED_V40[] struRecordSched;
            public uint dwRecordTime;                    /* 录象延时长度 0-5秒， 1-10秒， 2-30秒， 3-1分钟， 4-2分钟， 5-5分钟， 6-10分钟*/
            public uint dwPreRecordTime;                /* 预录时间 0-不预录 1-5秒 2-10秒 3-15秒 4-20秒 5-25秒 6-30秒 7-0xffffffff(尽可能预录) */
            public uint dwRecorderDuration;                /* 录像保存的最长时间 */
            public byte byRedundancyRec;    /*是否冗余录像,重要数据双备份：0/1*/
            public byte byAudioRec;        /*录像时复合流编码时是否记录音频数据：国外有此法规*/
            public byte byStreamType;  // 0-主码流，1-子码流，2-主子码流同时 3-三码流
            public byte byPassbackRecord;  // 0:不回传录像 1：回传录像
            public ushort wLockDuration;  // 录像锁定时长，单位小时 0表示不锁定，0xffff表示永久锁定，录像段的时长大于锁定的持续时长的录像，将不会锁定
            public byte byRecordBackup;  // 0:录像不存档 1：录像存档
            public byte bySVCLevel;    //SVC抽帧类型：0-不抽，1-抽二分之一 2-抽四分之三
            public byte byRecordManage;   //录像调度，0-启用， 1-不启用; 启用时进行定时录像；不启用时不进行定时录像，但是录像计划仍在使用，比如移动侦测，回传都还在按这条录像计划进行
            public byte byExtraSaveAudio;//音频单独存储
            /*开启智能录像功能后，算法库是自动启用智能录像算法，其功能为若录像中无目标出现，会降低码率、帧率，而目标出现时又恢复全码率及帧率，从而达到减少资源消耗的目的*/
            public byte byIntelligentRecord;//是否开启智能录像功能 0-否 1-是
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 125, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //通道录像参数配置(9000扩展)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECORD_V30
        {
            public uint dwSize;
            public uint dwRecord;/*是否录像 0-否 1-是*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_RECORDDAY[] struRecAllDay;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_RECORDSCHED[] struRecordSched;
            public uint dwRecordTime;/* 录象延时长度 0-5秒， 1-20秒， 2-30秒， 3-1分钟， 4-2分钟， 5-5分钟， 6-10分钟*/
            public uint dwPreRecordTime;/* 预录时间 0-不预录 1-5秒 2-10秒 3-15秒 4-20秒 5-25秒 6-30秒 7-0xffffffff(尽可能预录) */
            public uint dwRecorderDuration;/* 录像保存的最长时间 */
            public byte byRedundancyRec;/*是否冗余录像,重要数据双备份：0/1*/
            public byte byAudioRec;/*录像时复合流编码时是否记录音频数据：国外有此法规*/
            public byte byStreamType;  // 0:主码流 1：子码流
            public byte byPassbackRecord;  // 0:不回传录像 1：回传录像
            public ushort wLockDuration;  // 录像锁定时长，单位小时 0表示不锁定，0xffff表示永久锁定，录像段的时长大于锁定的持续时长的录像，将不会锁定
            public byte byRecordBackup;  // 0:录像不存档 1：录像存档
            public byte bySVCLevel;	//SVC抽帧类型：0-不抽，1-抽二分之一 2-抽四分之三
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byReserve;
        }

        //通道录像参数配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECORD
        {
            public uint dwSize;
            public uint dwRecord;/*是否录像 0-否 1-是*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_RECORDDAY[] struRecAllDay;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_RECORDSCHED[] struRecordSched;
            public uint dwRecordTime;/* 录象时间长度 */
            public uint dwPreRecordTime;/* 预录时间 0-不预录 1-5秒 2-10秒 3-15秒 4-20秒 5-25秒 6-30秒 7-0xffffffff(尽可能预录) */
        }

        //云台协议表结构配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PTZ_PROTOCOL
        {
            public uint dwType;/*解码器类型值，从1开始连续递增*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDescribe;/*解码器的描述符，和8000中的一致*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PTZCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PTZ_PROTOCOL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PTZ_PROTOCOL[] struPtz;/*最大200中PTZ协议*/
            public uint dwPtzNum;/*有效的ptz协议数目，从0开始(即计算时加1)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        /***************************云台类型(end)******************************/

        //通道解码器(云台)参数配置(9000扩展)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODERCFG_V30
        {
            public uint dwSize;
            public uint dwBaudRate;//波特率(bps)，0－50，1－75，2－110，3－150，4－300，5－600，6－1200，7－2400，8－4800，9－9600，10－19200， 11－38400，12－57600，13－76800，14－115.2k;
            public byte byDataBit;// 数据有几位 0－5位，1－6位，2－7位，3－8位;
            public byte byStopBit;// 停止位 0－1位，1－2位
            public byte byParity;// 校验 0－无校验，1－奇校验，2－偶校验;
            public byte byFlowcontrol;// 0－无，1－软流控,2-硬流控
            public ushort wDecoderType;//解码器类型, 从0开始，对应ptz协议列表
            public ushort wDecoderAddress;/*解码器地址:0 - 255*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PRESET_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] bySetPreset;/* 预置点是否设置,0-没有设置,1-设置*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CRUISE_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] bySetCruise;/* 巡航是否设置: 0-没有设置,1-设置 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TRACK_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] bySetTrack;/* 轨迹是否设置,0-没有设置,1-设置*/
        }

        //通道解码器(云台)参数配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODERCFG
        {
            public uint dwSize;
            public uint dwBaudRate; //波特率(bps)，0－50，1－75，2－110，3－150，4－300，5－600，6－1200，7－2400，8－4800，9－9600，10－19200， 11－38400，12－57600，13－76800，14－115.2k;
            public byte byDataBit; // 数据有几位 0－5位，1－6位，2－7位，3－8位;
            public byte byStopBit;// 停止位 0－1位，1－2位;
            public byte byParity; // 校验 0－无校验，1－奇校验，2－偶校验;
            public byte byFlowcontrol;// 0－无，1－软流控,2-硬流控
            public ushort wDecoderType;//解码器类型, 0－YouLi，1－LiLin-1016，2－LiLin-820，3－Pelco-p，4－DM DynaColor，5－HD600，6－JC-4116，7－Pelco-d WX，8－Pelco-d PICO
            public ushort wDecoderAddress;/*解码器地址:0 - 255*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PRESET, ArraySubType = UnmanagedType.I1)]
            public byte[] bySetPreset;/* 预置点是否设置,0-没有设置,1-设置*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CRUISE, ArraySubType = UnmanagedType.I1)]
            public byte[] bySetCruise;/* 巡航是否设置: 0-没有设置,1-设置 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TRACK, ArraySubType = UnmanagedType.I1)]
            public byte[] bySetTrack;/* 轨迹是否设置,0-没有设置,1-设置*/
        }

        //ppp参数配置(子结构)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_PPPCFG_V30
        {
            public NET_DVR_IPADDR struRemoteIP;//远端IP地址
            public NET_DVR_IPADDR struLocalIP;//本地IP地址
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sLocalIPMask;//本地IP地址掩码
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUsername;/* 用户名 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* 密码 */
            public byte byPPPMode;//PPP模式, 0－主动，1－被动
            public byte byRedial;//是否回拨 ：0-否,1-是
            public byte byRedialMode;//回拨模式,0-由拨入者指定,1-预置回拨号码
            public byte byDataEncrypt;//数据加密,0-否,1-是
            public uint dwMTU;//MTU
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PHONENUMBER_LEN)]
            public string sTelephoneNumber;//电话号码
        }

        //ppp参数配置(子结构)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_PPPCFG
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sRemoteIP;//远端IP地址
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sLocalIP;//本地IP地址
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sLocalIPMask;//本地IP地址掩码
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUsername;/* 用户名 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* 密码 */
            public byte byPPPMode;//PPP模式, 0－主动，1－被动
            public byte byRedial;//是否回拨 ：0-否,1-是
            public byte byRedialMode;//回拨模式,0-由拨入者指定,1-预置回拨号码
            public byte byDataEncrypt;//数据加密,0-否,1-是
            public uint dwMTU;//MTU
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PHONENUMBER_LEN)]
            public string sTelephoneNumber;//电话号码
        }

        //RS232串口参数配置(9000扩展)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SINGLE_RS232
        {
            public uint dwBaudRate;/*波特率(bps)，0－50，1－75，2－110，3－150，4－300，5－600，6－1200，7－2400，8－4800，9－9600，10－19200， 11－38400，12－57600，13－76800，14－115.2k;*/
            public byte byDataBit;/* 数据有几位 0－5位，1－6位，2－7位，3－8位 */
            public byte byStopBit;/* 停止位 0－1位，1－2位 */
            public byte byParity;/* 校验 0－无校验，1－奇校验，2－偶校验 */
            public byte byFlowcontrol;/* 0－无，1－软流控,2-硬流控 */
            public uint dwWorkMode; /* 工作模式，0－232串口用于PPP拨号，1－232串口用于参数控制，2－透明通道 */
        }

        //RS232串口参数配置(9000扩展)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RS232CFG_V30
        {
            public uint dwSize;
            public NET_DVR_SINGLE_RS232 struRs232;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 84, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_PPPCFG_V30 struPPPConfig;
        }

        //RS232串口参数配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RS232CFG
        {
            public uint dwSize;
            public uint dwBaudRate;//波特率(bps)，0－50，1－75，2－110，3－150，4－300，5－600，6－1200，7－2400，8－4800，9－9600，10－19200， 11－38400，12－57600，13－76800，14－115.2k;
            public byte byDataBit;// 数据有几位 0－5位，1－6位，2－7位，3－8位;
            public byte byStopBit;// 停止位 0－1位，1－2位;
            public byte byParity;// 校验 0－无校验，1－奇校验，2－偶校验;
            public byte byFlowcontrol;// 0－无，1－软流控,2-硬流控
            public uint dwWorkMode;// 工作模式，0－窄带传输(232串口用于PPP拨号)，1－控制台(232串口用于参数控制)，2－透明通道
            public NET_DVR_PPPCFG struPPPConfig;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PRESETCHAN_INFO
        {
            public uint dwEnablePresetChan;	/*启用预置点的通道*/
            public uint dwPresetPointNo;		/*调用预置点通道对应的预置点序号, 0xfffffff表示不调用预置点。*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CRUISECHAN_INFO
        {
            public uint dwEnableCruiseChan;	/*启用巡航的通道*/
            public uint dwCruiseNo;		/*巡航通道对应的巡航编号, 0xfffffff表示无效*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PTZTRACKCHAN_INFO
        {
            public uint dwEnablePtzTrackChan;	/*启用花样扫描的通道*/
            public uint dwPtzTrackNo;		/*花样扫描通道对应的编号, 0xfffffff表示无效*/
        }

        //报警输入参数配置(256路NVR扩展)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINCFG_V40
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAlarmInName;	/* 名称 */
            public byte byAlarmType;	            //报警器类型,0：常开,1：常闭
            public byte byAlarmInHandle;	        /* 是否处理 0-不处理 1-处理*/
            public byte byChannel;                 // 报警输入触发智能识别通道
            public byte byRes1;                    //保留			
            public uint dwHandleType;        //异常处理,异常处理方式的"或"结果   
            /*0x00: 无响应*/
            /*0x01: 监视器上警告*/
            /*0x02: 声音警告*/
            /*0x04: 上传中心*/
            /*0x08: 触发报警输出*/
            /*0x10: 触发JPRG抓图并上传Email*/
            /*0x20: 无线声光报警器联动*/
            /*0x40: 联动电子地图(目前只有PCNVR支持)*/
            /*0x200: 抓图并上传FTP*/ 
            public uint dwMaxRelAlarmOutChanNum ; //触发的报警输出通道数（只读）最大支持数量
            public uint dwRelAlarmOutChanNum; //触发的报警输出通道数 实际支持数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRelAlarmOut; //触发报警通道
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//布防时间
            /*触发的录像通道*/
            public uint dwMaxRecordChanNum;   //设备支持的最大关联录像通道数-只读
            public uint dwCurRecordChanNum;    //当前实际已配置的关联录像通道数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRelRecordChan;	 /* 实际触发录像通道，按值表示,采用紧凑型排列，从下标0 - dwCurRecordChanNum -1有效，如果中间遇到0xffffffff,则后续无效*/ 
            public uint dwMaxEnablePtzCtrlNun; //最大可启用的云台控制总数(只读)
            public uint dwEnablePresetChanNum;  //当前已启用预置点的数目
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PRESETCHAN_INFO[] struPresetChanInfo; //启用的预置点信息
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 516, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;					/*保留*/
            public uint dwEnableCruiseChanNum;  //当前已启用巡航的通道数目
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CRUISECHAN_INFO[] struCruiseChanInfo; //启用巡航功能通道的信息
            public uint dwEnablePtzTrackChanNum;  //当前已启用巡航的通道数目
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PTZTRACKCHAN_INFO[] struPtzTrackInfo; //调用花样扫描的通道信息
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //报警输入参数配置(9000扩展)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINCFG_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAlarmInName;/* 名称 */
            public byte byAlarmType; //报警器类型,0：常开,1：常闭
            public byte byAlarmInHandle; /* 是否处理 0-不处理 1-处理*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_HANDLEEXCEPTION_V30 struAlarmHandleType;/* 处理方式 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//布防时间
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;//报警触发的录象通道,为1表示触发该通道
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byEnablePreset;/* 是否调用预置点 0-否,1-是*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byPresetNo;/* 调用的云台预置点序号,一个报警输入可以调用多个通道的云台预置点, 0xff表示不调用预置点。*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 192, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;/*保留*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byEnableCruise;/* 是否调用巡航 0-否,1-是*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byCruiseNo;/* 巡航 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byEnablePtzTrack;/* 是否调用轨迹 0-否,1-是*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byPTZTrack;/* 调用的云台的轨迹序号 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_IO_ALARM
        {
            public uint	dwAlarmInputNo;		//发生报警的报警输入通道号，一次只有一个
            public uint	dwTrigerAlarmOutNum;	/*触发的报警输出个数，用于后面计算变长数据部分中所有触发的报警输出通道号，四字节表示一个*/
            public uint	dwTrigerRecordChanNum;	/*触发的录像通道个数，用于后面计算变长数据部分中所有触发的录像通道号，四字节表示一个*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 116, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_ALARM_CHANNEL
        {
            public uint	dwAlarmChanNum;	/*发生报警通道数据个数，用于后面计算变长数据部分中所有发生的报警通道号，四字节表示一个*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_ALARM_HD
        {
            public uint	dwAlarmHardDiskNum;	/*发生报警的硬盘数据长度，用于后面计算变长数据部分中所有发生报警的硬盘号，四节表示一个*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct UNION_ALARMINFO_FIXED
        {
            [FieldOffset(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byUnionLen;         
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALRAM_FIXED_HEADER
        {
            public uint dwAlarmType;              /*0-信号量报警,1-硬盘满,2-信号丢失，3－移动侦测，4－硬盘未格式化,5-写硬盘出错,6-遮挡报警，7-制式不匹配, 8-非法访问，9-视频信号异常，10-录像异常，11-智能场景变化，12-阵列异常，13-前端/录像分辨率不匹配*/
            public NET_DVR_TIME_EX struAlarmTime;	//发生报警的时间
            public UNION_ALARMINFO_FIXED uStruAlarm;
        }

       [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINFO_V40
       {
            public NET_DVR_ALRAM_FIXED_HEADER struAlarmFixedHeader;	//报警固定部分
            public IntPtr pAlarmData;	//报警可变部分内容
       }

        //报警输入参数配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAlarmInName;/* 名称 */
            public byte byAlarmType;//报警器类型,0：常开,1：常闭
            public byte byAlarmInHandle;/* 是否处理 0-不处理 1-处理*/
            public byte byChannel;     // 报警输入触发智能识别通道
            public byte byRes;                     
            public NET_DVR_HANDLEEXCEPTION struAlarmHandleType;/* 处理方式 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//布防时间
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;//报警触发的录象通道,为1表示触发该通道
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byEnablePreset;/* 是否调用预置点 0-否,1-是*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byPresetNo;/* 调用的云台预置点序号,一个报警输入可以调用多个通道的云台预置点, 0xff表示不调用预置点。*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byEnableCruise;/* 是否调用巡航 0-否,1-是*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byCruiseNo;/* 巡航 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byEnablePtzTrack;/* 是否调用轨迹 0-否,1-是*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byPTZTrack;/* 调用的云台的轨迹序号 */
        }

        //模拟报警输入参数配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ANALOG_ALARMINCFG
        {
            public uint dwSize;
            public byte	byEnableAlarmHandle; //处理报警输入
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmInName; //模拟报警输入名称
            public ushort wAlarmInUpper; //模拟输入电压上限，实际值乘10，范围0~360
            public ushort wAlarmInLower; //模拟输入电压下限，实际值乘10，范围0~360 
            public NET_DVR_HANDLEEXCEPTION_V30 struAlarmHandleType;	/* 处理方式 */ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//布防时间
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan; //被触发的录像通道
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //上传报警信息(9000扩展)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINFO_V30
        {
            public uint dwAlarmType;/*0-信号量报警,1-硬盘满,2-信号丢失,3－移动侦测,4－硬盘未格式化,5-读写硬盘出错,6-遮挡报警,7-制式不匹配, 8-非法访问, 0xa-GPS定位信息(车载定制)*/
            public uint dwAlarmInputNumber;/*报警输入端口*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmOutputNumber;/*触发的输出端口，为1表示对应输出*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmRelateChannel;/*触发的录像通道，为1表示对应录像, dwAlarmRelateChannel[0]对应第1个通道*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byChannel;/*dwAlarmType为2或3,6时，表示哪个通道，dwChannel[0]对应第1个通道*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byDiskNumber;/*dwAlarmType为1,4,5时,表示哪个硬盘, dwDiskNumber[0]对应第1个硬盘*/
            public void Init()
            {
                dwAlarmType = 0;
                dwAlarmInputNumber = 0;
                byAlarmRelateChannel = new byte[MAX_CHANNUM_V30];
                byChannel = new byte[MAX_CHANNUM_V30];
                byAlarmOutputNumber = new byte[MAX_ALARMOUT_V30];
                byDiskNumber = new byte[MAX_DISKNUM_V30];
                for (int i = 0; i < MAX_CHANNUM_V30; i++)
                {
                    byAlarmRelateChannel[i] = Convert.ToByte(0);
                    byChannel[i] = Convert.ToByte(0);
                }
                for (int i = 0; i < MAX_ALARMOUT_V30; i++)
                {
                    byAlarmOutputNumber[i] = Convert.ToByte(0);
                }
                for (int i = 0; i < MAX_DISKNUM_V30; i++)
                {
                    byDiskNumber[i] = Convert.ToByte(0);
                }
            }
            public void Reset()
            {
                dwAlarmType = 0;
                dwAlarmInputNumber = 0;

                for (int i = 0; i < MAX_CHANNUM_V30; i++)
                {
                    byAlarmRelateChannel[i] = Convert.ToByte(0);
                    byChannel[i] = Convert.ToByte(0);
                }
                for (int i = 0; i < MAX_ALARMOUT_V30; i++)
                {
                    byAlarmOutputNumber[i] = Convert.ToByte(0);
                }
                for (int i = 0; i < MAX_DISKNUM_V30; i++)
                {
                    byDiskNumber[i] = Convert.ToByte(0);
                }
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARM_HOT_SPARE
        {
            public uint dwSize;   //结构体
            public uint dwExceptionCase;   //报警原因   0-网络异常
            public NET_DVR_IPADDR  struDeviceIP;    //产生异常的设备IP地址
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;         //保留
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINFO
        {
            public int dwAlarmType;/*0-信号量报警,1-硬盘满,2-信号丢失,3－移动侦测,4－硬盘未格式化,5-读写硬盘出错,6-遮挡报警,7-制式不匹配, 8-非法访问, 9-串口状态, 0xa-GPS定位信息(车载定制)*/
            public int dwAlarmInputNumber;/*报警输入端口, 当报警类型为9时该变量表示串口状态0表示正常， -1表示错误*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT, ArraySubType = UnmanagedType.U4)]
            public int[] dwAlarmOutputNumber;/*触发的输出端口，哪一位为1表示对应哪一个输出*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.U4)]
            public int[] dwAlarmRelateChannel;/*触发的录像通道，哪一位为1表示对应哪一路录像, dwAlarmRelateChannel[0]对应第1个通道*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.U4)]
            public int[] dwChannel;/*dwAlarmType为2或3,6时，表示哪个通道，dwChannel[0]位对应第1个通道*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM, ArraySubType = UnmanagedType.U4)]
            public int[] dwDiskNumber;/*dwAlarmType为1,4,5时,表示哪个硬盘, dwDiskNumber[0]位对应第1个硬盘*/
            public void Init()
            {
                dwAlarmType = 0;
                dwAlarmInputNumber = 0;
                dwAlarmOutputNumber = new int[MAX_ALARMOUT];
                dwAlarmRelateChannel = new int[MAX_CHANNUM];
                dwChannel = new int[MAX_CHANNUM];
                dwDiskNumber = new int[MAX_DISKNUM];
                for (int i = 0; i < MAX_ALARMOUT; i++)
                {
                    dwAlarmOutputNumber[i] = 0;
                }
                for (int i = 0; i < MAX_CHANNUM; i++)
                {
                    dwAlarmRelateChannel[i] = 0;
                    dwChannel[i] = 0;
                }
                for (int i = 0; i < MAX_DISKNUM; i++)
                {
                    dwDiskNumber[i] = 0;
                }
            }
            public void Reset()
            {
                dwAlarmType = 0;
                dwAlarmInputNumber = 0;

                for (int i = 0; i < MAX_ALARMOUT; i++)
                {
                    dwAlarmOutputNumber[i] = 0;
                }
                for (int i = 0; i < MAX_CHANNUM; i++)
                {
                    dwAlarmRelateChannel[i] = 0;
                    dwChannel[i] = 0;
                }
                for (int i = 0; i < MAX_DISKNUM; i++)
                {
                    dwDiskNumber[i] = 0;
                }
            }
        }


        //////////////////////////////////////////////////////////////////////////////////////
        //IPC接入参数配置
        /* IP设备结构 */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPDEVINFO
        {
            public uint dwEnable;/* 该IP设备是否启用 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* 用户名 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword; /* 密码 */
            public NET_DVR_IPADDR struIP;/* IP地址 */
            public ushort wDVRPort;/* 端口号 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;/* 保留 */

            public void Init()
            {
                sUserName = new byte[NAME_LEN];
                sPassword = new byte[PASSWD_LEN];
                byRes = new byte[34];
            }
        }

        //ipc接入设备信息扩展，支持ip设备的域名添加
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPDEVINFO_V31
        {
            public byte byEnable;//该IP设备是否有效
            public byte byProType;
            public byte byEnableQuickAdd;
            public byte byRes1;//保留字段，置0
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;//用户名
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;//密码
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byDomain;//设备域名
            public NET_DVR_IPADDR struIP;//IP地址
            public ushort wDVRPort;// 端口号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;//保留字段，置0

            public void Init()
            {
                sUserName = new byte[NAME_LEN];
                sPassword = new byte[PASSWD_LEN];
                byDomain = new byte[MAX_DOMAIN_NAME];
                byRes2 = new byte[34];
            }
        }

        /* IP通道匹配参数 */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPCHANINFO
        {
            public byte byEnable;/* 该通道是否在线 */
            public byte byIPID;/* IP设备ID 取值1- MAX_IP_DEVICE */
            public byte byChannel;/* 通道号 */
            public byte byIPIDHigh; // IP设备ID的高8位
            public byte byTransProtocol;//传输协议类型0-TCP/auto(具体有设备决定)，1-UDP 2-多播 3-仅TCP 4-auto
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 31, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//保留,置0
            public void Init()
            {
                byRes = new byte[31];
            }
        }

        /* IP接入配置结构 */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPPARACFG
        {
            public uint dwSize;/* 结构大小 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_DEVICE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPDEVINFO[] struIPDevInfo;/* IP设备 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnalogChanEnable; /* 模拟通道是否启用，从低到高表示1-32通道，0表示无效 1有效 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_CHANNEL, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPCHANINFO[] struIPChanInfo;/* IP通道 */

            public void Init()
            {
                int i = 0;
                struIPDevInfo = new NET_DVR_IPDEVINFO[MAX_IP_DEVICE];

                for (i = 0; i < MAX_IP_DEVICE; i++)
                {
                    struIPDevInfo[i].Init();
                }
                byAnalogChanEnable = new byte[MAX_ANALOG_CHANNUM];
                struIPChanInfo = new NET_DVR_IPCHANINFO[MAX_IP_CHANNEL];
                for (i = 0; i < MAX_IP_CHANNEL; i++)
                {
                    struIPChanInfo[i].Init();
                }
            }
        }

        /* 扩展IP接入配置结构 */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPPARACFG_V31
        {
            public uint dwSize;/* 结构大小 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_DEVICE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPDEVINFO_V31[] struIPDevInfo; /* IP设备 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnalogChanEnable; /* 模拟通道是否启用，从低到高表示1-32通道，0表示无效 1有效 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_CHANNEL, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPCHANINFO[] struIPChanInfo;/* IP通道 */

            public void Init()
            {
                int i = 0;
                struIPDevInfo = new NET_DVR_IPDEVINFO_V31[MAX_IP_DEVICE];

                for (i = 0; i < MAX_IP_DEVICE; i++)
                {
                    struIPDevInfo[i].Init();
                }
                byAnalogChanEnable = new byte[MAX_ANALOG_CHANNUM];
                struIPChanInfo = new NET_DVR_IPCHANINFO[MAX_IP_CHANNEL];
                for (i = 0; i < MAX_IP_CHANNEL; i++)
                {
                    struIPChanInfo[i].Init();
                }
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPSERVER_STREAM
        {
            public byte  byEnable;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[]  byRes;
            public NET_DVR_IPADDR struIPServer;
            public ushort  wPort;
            public ushort  wDvrNameLen;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[]  byDVRName;
            public ushort  wDVRSerialLen;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U2)]
            public ushort[]  byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[]  byDVRSerialNumber;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[]  byUserName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[]  byPassWord;
            public byte  byChannel;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[]  byRes2;
            public void Init()
            {
                byRes = new byte[3];
                byDVRName = new byte[NAME_LEN];
                byRes1 = new ushort[2];
                byDVRSerialNumber = new byte[SERIALNO_LEN];
                byUserName = new byte[NAME_LEN];
                byPassWord = new byte[PASSWD_LEN];
                byRes2 = new byte[11];
            }
        }

        /*流媒体服务器基本配置*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_STREAM_MEDIA_SERVER_CFG
        {
            public byte byValid;/*是否启用流媒体服务器取流,0表示无效，非0表示有效*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_IPADDR struDevIP;
            public ushort wDevPort;/*流媒体服务器端口*/
            public byte byTransmitType;/*传输协议类型 0-TCP，1-UDP*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 69, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }
        //设备通道信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEV_CHAN_INFO
        {
            public NET_DVR_IPADDR struIP;		    //DVR IP地址
            public ushort wDVRPort;			 	//端口号
            public byte byChannel;				//通道号
            public byte byTransProtocol;		//传输协议类型0-TCP，1-UDP
            public byte byTransMode;			//传输码流模式 0－主码流 1－子码流
            public byte byFactoryType;			/*前端设备厂家类型,通过接口获取*/
            public byte byDeviceType; //设备类型(视频综合平台智能板使用)，1-解码器（此时根据视频综合平台能力集中byVcaSupportChanMode字段来决定是使用解码通道还是显示通道），2-编码器
            public byte byDispChan;//显示通道号,智能配置使用
            public byte bySubDispChan;//显示通道子通道号，智能配置时使用
            public byte byResolution;	//; 1-CIF 2-4CIF 3-720P 4-1080P 5-500w大屏控制器使用，大屏控制器会根据该参数分配解码资源
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byDomain;	//设备域名
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;	//监控主机登陆帐号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;	//监控主机密码
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PU_STREAM_CFG
        {
            public uint dwSize;
            public NET_DVR_STREAM_MEDIA_SERVER_CFG struStreamMediaSvrCfg;
            public NET_DVR_DEV_CHAN_INFO struDevChanInfo;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DDNS_STREAM_CFG
        {
            public byte byEnable;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_IPADDR struStreamServer;
            public ushort wStreamServerPort;
            public byte byStreamServerTransmitType;
            public byte byRes2;
            public NET_DVR_IPADDR struIPServer;
            public ushort wIPServerPort;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDVRName;
            public ushort wDVRNameLen;
            public ushort wDVRSerialLen;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDVRSerialNumber;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassWord;
            public ushort wDVRPort;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes4;
            public byte byChannel;
            public byte byTransProtocol;
            public byte byTransMode;
            public byte byFactoryType;
            public void Init()
            {
                byRes1 = new byte[3];
                byRes3 = new byte[2];
                sDVRName = new byte[NAME_LEN];
                sDVRSerialNumber = new byte[SERIALNO_LEN];
                sUserName = new byte[NAME_LEN];
                sPassWord = new byte[PASSWD_LEN];
                byRes4 = new byte[2];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PU_STREAM_URL
        {
            public byte byEnable;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 240, ArraySubType = UnmanagedType.I1)]
            public byte[] strURL;
            public byte byTransPortocol;
            public ushort wIPID;
            public byte byChannel;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public void Init()
            {
                strURL = new byte[240];
                byRes = new byte[7];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HKDDNS_STREAM
        {
            public byte byEnable;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byDDNSDomain;
            public ushort wPort;
            public ushort wAliasLen;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlias;
            public ushort wDVRSerialLen;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDVRSerialNumber;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byUserName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPassWord;
            public byte byChannel;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public void Init()
            {
                byRes = new byte[3];
                byDDNSDomain = new byte[64];
                byAlias = new byte[NAME_LEN];
                byRes1 = new byte[2];
                byDVRSerialNumber = new byte[SERIALNO_LEN];
                byUserName = new byte[NAME_LEN];
                byPassWord = new byte[PASSWD_LEN];
                byRes2 = new byte[11];
            }
        }

        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPCHANINFO_V40
        {
            public byte byEnable;				/* 该通道是否在线 */
            public byte byRes1;
            public ushort wIPID;                  //IP设备ID
            public uint dwChannel;				//通道号
            public byte byTransProtocol;		//传输协议类型0-TCP，1-UDP
            public byte byTransMode;			//传输码流模式 0－主码流 1－子码流
            public byte byFactoryType;			/*前端设备厂家类型,通过接口获取*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 241, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct NET_DVR_GET_STREAM_UNION
        {
            [FieldOffset(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 492, ArraySubType = UnmanagedType.I1)]
            public byte[] byUnion;
            public void Init()
            {
                byUnion = new byte[492];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_STREAM_MODE
        {
            public byte byGetStreamType;/*取流方式：0- 直接从设备取流；1- 从流媒体取流；2- 通过IPServer获得IP地址后取流；
                                          * 3- 通过IPServer找到设备，再通过流媒体取设备的流； 4- 通过流媒体由URL去取流；
                                          * 5- 通过hiDDNS域名连接设备然后从设备取流 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[]  byRes;
            public NET_DVR_GET_STREAM_UNION uGetStream;
            public void Init()
            {
                byGetStreamType = 0;
                byRes = new byte[3];
                //uGetStream.Init();
            }
        }

        /* V40扩展IP接入配置结构 */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPPARACFG_V40
        {
            public uint dwSize;/* 结构大小 */
            public uint dwGroupNum;
            public uint dwAChanNum;
            public uint dwDChanNum;
            public uint dwStartDChan;

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnalogChanEnable; /* 模拟通道是否启用，从低到高表示1-32通道，0表示无效 1有效 */

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_DEVICE_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPDEVINFO_V31[] struIPDevInfo; /* IP设备 */

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_STREAM_MODE[] struStreamMode;/* IP通道 */

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; /* 模拟通道是否启用，从低到高表示1-32通道，0表示无效 1有效 */
        }

        //为CVR扩展的报警类型
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINFO_DEV
        {
            public uint dwAlarmType;  //0-编码器(通道)信号量报警；1-私有卷二损坏；2- NVR服务退出；
	        //3-编码器状态异常；4-系统时钟异常；5-录像卷剩余容量过低；
	        //6-编码器(通道)移动侦测报警；7-编码器(通道)遮挡报警。
            public NET_DVR_TIME   struTime;     //报警时间
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;    //保留
            public uint dwNumber;     //数目
            public IntPtr pNO;  //dwNumber个WORD; 每个WORD表示一个通道号，或者磁盘号, 无效时为0
        }

        /* 报警输出参数 */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMOUTINFO
        {
            public byte byIPID;/* IP设备ID取值1- MAX_IP_DEVICE */
            public byte byAlarmOut;/* 报警输出号 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;/* 保留 */

            public void Init()
            {
                byRes = new byte[18];
            }
        }

        /* IP报警输出配置结构 */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMOUTCFG
        {
            public uint dwSize; /* 结构大小 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMOUT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMOUTINFO[] struIPAlarmOutInfo;/* IP报警输出 */

            public void Init()
            {
                struIPAlarmOutInfo = new NET_DVR_IPALARMOUTINFO[MAX_IP_ALARMOUT];
                for (int i = 0; i < MAX_IP_ALARMOUT; i++)
                {
                    struIPAlarmOutInfo[i].Init();
                }
            }
        }
        /* IP报警输出参数 */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMOUTINFO_V40
        {
            public uint dwIPID;					/* IP设备ID */
            public uint dwAlarmOut;				/* IP设备ID对应的报警输出号 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;				/* 保留 */
        }

        /*IP报警输出*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMOUTCFG_V40
        {
            public uint dwSize;  //结构体长度
            public uint dwCurIPAlarmOutNum;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMOUT_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMOUTINFO_V40[] struIPAlarmOutInfo;/*IP报警输出*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /* 报警输入参数 */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMININFO
        {
            public byte byIPID;/* IP设备ID取值1- MAX_IP_DEVICE */
            public byte byAlarmIn;/* 报警输入号 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;/* 保留 */
        }

        /* IP报警输入配置结构 */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMINCFG
        {
            public uint dwSize;/* 结构大小 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMIN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMININFO[] struIPAlarmInInfo;/* IP报警输入 */
        }
        /* IP报警输入参数 */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMININFO_V40
        {
            public uint dwIPID;					/* IP设备ID */
            public uint dwAlarmIn;				/* IP设备ID对应的报警输入号 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;				/* 保留 */
        }
         /*IP报警输入资源*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMINCFG_V40
        {
            public uint dwSize;  //结构体长度
            public uint dwCurIPAlarmInNum;  //当前报警输入口数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMIN_V40, ArraySubType = UnmanagedType.I1)]
            public NET_DVR_IPALARMININFO_V40[] struIPAlarmInInfo;/* IP报警输入*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ipc alarm info
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMINFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_DEVICE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPDEVINFO[] struIPDevInfo; /* IP设备 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnalogChanEnable; /* 模拟通道是否启用，0-未启用 1-启用 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_CHANNEL, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPCHANINFO[] struIPChanInfo;/* IP通道 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMIN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMININFO[] struIPAlarmInInfo;/* IP报警输入 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMOUT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMOUTINFO[] struIPAlarmOutInfo;/* IP报警输出 */
        }

        //ipc配置改变报警信息扩展 9000_1.1
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMINFO_V31
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_DEVICE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPDEVINFO_V31[] struIPDevInfo; /* IP设备 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnalogChanEnable;/* 模拟通道是否启用，0-未启用 1-启用 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_CHANNEL, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPCHANINFO[] struIPChanInfo;/* IP通道 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMIN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMININFO[] struIPAlarmInInfo; /* IP报警输入 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMOUT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMOUTINFO[] struIPAlarmOutInfo;/* IP报警输出 */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMINFO_V40
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_DEVICE_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPDEVINFO_V31[] struIPDevInfo;           // IP设备
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnalogChanEnable;           /* 模拟通道是否启用，0-未启用 1-启用 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPCHANINFO[] struIPChanInfo;	        /* IP通道 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMIN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMININFO[] struIPAlarmInInfo;    /* IP报警输入 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMOUT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMOUTINFO[] struIPAlarmOutInfo; /* IP报警输出 */   
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                          // 保留字节
        }

        public enum HD_STAT
        {
            HD_STAT_OK = 0,/* 正常 */
            HD_STAT_UNFORMATTED = 1,/* 未格式化 */
            HD_STAT_ERROR = 2,/* 错误 */
            HD_STAT_SMART_FAILED = 3,/* SMART状态 */
            HD_STAT_MISMATCH = 4,/* 不匹配 */
            HD_STAT_IDLE = 5, /* 休眠*/
            NET_HD_STAT_OFFLINE = 6,/*网络盘处于未连接状态 */
            HD_RIADVD_EXPAND = 7,    /* 虚拟磁盘可扩容 */
            HD_STAT_REPARING = 10,   /* 硬盘正在修复(9000 2.0) */
            HD_STAT_FORMATING = 11,   /* 硬盘正在格式化(9000 2.0) */ 
        }

        //本地硬盘信息配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SINGLE_HD
        {
            public uint dwHDNo;/*硬盘号, 取值0~MAX_DISKNUM_V30-1*/
            public uint dwCapacity;/*硬盘容量(不可设置)*/
            public uint dwFreeSpace;/*硬盘剩余空间(不可设置)*/
            public uint dwHdStatus;/*硬盘状态(不可设置) HD_STAT*/
            public byte byHDAttr;/*0-默认, 1-冗余; 2-只读*/
            public byte byHDType;/*0-本地硬盘,1-ESATA硬盘,2-NAS硬盘*/
            public byte byDiskDriver;   // 值 代表其ASCII字符 
            public byte byRes1;
            public uint dwHdGroup; /*属于哪个盘组 1-MAX_HD_GROUP*/
            public byte byRecycling;   // 是否循环利用 0：不循环利用，1：循环利用
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public uint dwStorageType;    //按位表示 0-不支持 非0-支持
							// dwStorageType & 0x1 表示是否是普通录像专用存储盘     
							// dwStorageType & 0x2  表示是否是抽帧录像专用存储盘
							// dwStorageType & 0x4 表示是否是图片录像专用存储盘

            public uint dwPictureCapacity; //硬盘图片容量(不可设置)，单位:MB
            public uint dwFreePictureSpace; //剩余图片空间(不可设置)，单位:MB
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 104, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HDCFG
        {
            public uint dwSize;
            public uint dwHDCount;/*硬盘数(不可设置)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SINGLE_HD[] struHDInfo;//硬盘相关操作都需要重启才能生效；
        }

        //本地盘组信息配置扩展
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SINGLE_HDGROUP_V40
        {
            public uint dwHDGroupNo;       /*盘组号(不可设置) 1-MAX_HD_GROUP*/    
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRelRecordChan;  //触发的录像通道，按值表示，遇到0xffffffff时后续视为无效    
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;				/* 保留 */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HDGROUP_CFG_V40
        {
            public uint dwSize;                //结构体大小
            public uint dwMaxHDGroupNum; 		  //设备支持的最大盘组数-只读
            public uint dwCurHDGroupNum;       /*当前配置的盘组数*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HD_GROUP, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SINGLE_HDGROUP_V40[] struHDGroupAttr; //硬盘相关操作都需要重启才能生效；
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //保留
        }

        //本地盘组信息配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SINGLE_HDGROUP
        {
            public uint dwHDGroupNo;/*盘组号(不可设置) 1-MAX_HD_GROUP*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byHDGroupChans;/*盘组对应的录像通道, 0-表示该通道不录象到该盘组，1-表示录象到该盘组*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HDGROUP_CFG
        {
            public uint dwSize;
            public uint dwHDGroupCount;/*盘组总数(不可设置)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HD_GROUP, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SINGLE_HDGROUP[] struHDGroupAttr;//硬盘相关操作都需要重启才能生效
        }

        //配置缩放参数的结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCALECFG
        {
            public uint dwSize;
            public uint dwMajorScale;/* 主显示 0-不缩放，1-缩放*/
            public uint dwMinorScale;/* 辅显示 0-不缩放，1-缩放*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;
        }

        //DVR报警输出(9000扩展)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMOUTCFG_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAlarmOutName;/* 名称 */
            public uint dwAlarmOutDelay;/* 输出保持时间(-1为无限，手动关闭) */
            //0-5秒,1-10秒,2-30秒,3-1分钟,4-2分钟,5-5分钟,6-10分钟,7-手动
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmOutTime;/* 报警输出激活时间段 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //DVR报警输出
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMOUTCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAlarmOutName;/* 名称 */
            public uint dwAlarmOutDelay;/* 输出保持时间(-1为无限，手动关闭) */
            //0-5秒,1-10秒,2-30秒,3-1分钟,4-2分钟,5-5分钟,6-10分钟,7-手动
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmOutTime;/* 报警输出激活时间段 */
        }

        //DVR本地预览参数(9000扩展)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PREVIEWCFG_V30
        {
            public uint dwSize;
            public byte byPreviewNumber;//预览数目,0-1画面,1-4画面,2-9画面,3-16画面,0xff:最大画面
            public byte byEnableAudio;//是否声音预览,0-不预览,1-预览
            public ushort wSwitchTime;//切换时间,0-不切换,1-5s,2-10s,3-20s,4-30s,5-60s,6-120s,7-300s
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PREVIEW_MODE * MAX_WINDOW_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] bySwitchSeq;//切换顺序,如果lSwitchSeq[i]为 0xff表示不用
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //DVR本地预览参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PREVIEWCFG
        {
            public uint dwSize;
            public byte byPreviewNumber;//预览数目,0-1画面,1-4画面,2-9画面,3-16画面,0xff:最大画面
            public byte byEnableAudio;//是否声音预览,0-不预览,1-预览
            public ushort wSwitchTime;//切换时间,0-不切换,1-5s,2-10s,3-20s,4-30s,5-60s,6-120s,7-300s
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOW, ArraySubType = UnmanagedType.I1)]
            public byte[] bySwitchSeq;//切换顺序,如果lSwitchSeq[i]为 0xff表示不用
        }

        //DVR视频输出
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VGAPARA
        {
            public ushort wResolution;/* 分辨率 */
            public ushort wFreq;/* 刷新频率 */
            public uint dwBrightness;/* 亮度 */
        }

        //MATRIX输出参数结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIXPARA_V30
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_CHANNUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wOrder;/* 预览顺序, 0xff表示相应的窗口不预览 */
            public ushort wSwitchTime;// 预览切换时间 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIXPARA
        {
            public ushort wDisplayLogo;/* 显示视频通道号 */
            public ushort wDisplayOsd;/* 显示时间 */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VOOUT
        {
            public byte byVideoFormat;/* 输出制式,0-PAL,1-NTSC */
            public byte byMenuAlphaValue;/* 菜单与背景图象对比度 */
            public ushort wScreenSaveTime;/* 屏幕保护时间 0-从不,1-1分钟,2-2分钟,3-5分钟,4-10分钟,5-20分钟,6-30分钟 */
            public ushort wVOffset;/* 视频输出偏移 */
            public ushort wBrightness;/* 视频输出亮度 */
            public byte byStartMode;/* 启动后视频输出模式(0:菜单,1:预览)*/
            public byte byEnableScaler;/* 是否启动缩放 (0-不启动, 1-启动)*/
        }

        //DVR视频输出(9000扩展)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEOOUT_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VIDEOOUT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_VOOUT[] struVOOut;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VGA_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_VGAPARA[] struVGAPara;/* VGA参数 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_MATRIXOUT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIXPARA_V30[] struMatrixPara;/* MATRIX参数 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //DVR视频输出
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEOOUT
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VIDEOOUT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_VOOUT[] struVOOut;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VGA, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_VGAPARA[] struVGAPara;	/* VGA参数 */
            public NET_DVR_MATRIXPARA struMatrixPara;/* MATRIX参数 */
        }

        //单用户参数(子结构)(扩展)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_USER_INFO_V40
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;			/* 用户名只能用16字节 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;			/* 密码 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalRight;	/* 本地权限 */
            /*数组0: 本地控制云台*/
            /*数组1: 本地手动录象*/
            /*数组2: 本地回放*/
            /*数组3: 本地设置参数*/
            /*数组4: 本地查看状态、日志*/
            /*数组5: 本地高级操作(升级，格式化，重启，关机)*/
            /*数组6: 本地查看参数 */
            /*数组7: 本地管理模拟和IP camera */
            /*数组8: 本地备份 */
            /*数组9: 本地关机/重启 */    
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.I1)]
            public byte[] byRemoteRight;/* 远程权限 */	
            /*数组0: 远程控制云台*/
            /*数组1: 远程手动录象*/
            /*数组2: 远程回放 */
            /*数组3: 远程设置参数*/
            /*数组4: 远程查看状态、日志*/
            /*数组5: 远程高级操作(升级，格式化，重启，关机)*/
            /*数组6: 远程发起语音对讲*/
            /*数组7: 远程预览*/
            /*数组8: 远程请求报警上传、报警输出*/
            /*数组9: 远程控制，本地输出*/
            /*数组10: 远程控制串口*/
            /*数组11: 远程查看参数 */
            /*数组12: 远程管理模拟和IP camera */
            /*数组13: 远程关机/重启 */	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwNetPreviewRight;			/* 远程可以预览的通道，从前往后顺序排列，遇到0xffffffff后续均为无效*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalRecordRight;			/* 本地可以录像的通道，从前往后顺序排列，遇到0xffffffff后续均为无效*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwNetRecordRight;			/* 远程可以录像的通道，从前往后顺序排列，遇到0xffffffff后续均为无效*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalPlaybackRight;			/* 本地可以回放的通道，从前往后顺序排列，遇到0xffffffff后续均为无效*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwNetPlaybackRight;			/* 远程可以回放的通道，从前往后顺序排列，遇到0xffffffff后续均为无效*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalPTZRight;				/* 本地可以PTZ的通道，从前往后顺序排列，遇到0xffffffff后续均为无效*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwNetPTZRight;				/* 远程可以PTZ的通道，从前往后顺序排列，遇到0xffffffff后续均为无效*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalBackupRight;			/* 本地备份权限通道，从前往后顺序排列，遇到0xffffffff后续均为无效*/
            public NET_DVR_IPADDR	struUserIP;				/* 用户IP地址(为0时表示允许任何地址) */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;	/* 物理地址 */
            public byte byPriority;				/* 优先级，0xff-无，0--低，1--中，2--高 */
                                    /* 无……表示不支持优先级的设置
                                    低……默认权限:包括本地和远程回放,本地和远程查看日志和状态,本地和远程关机/重启
                                    中……包括本地和远程控制云台,本地和远程手动录像,本地和远程回放,语音对讲和远程预览、本地备份,本地/远程关机/重启
                                    高……管理员 */
            public byte byAlarmOnRight;         // 报警输入口布防权限 1-有权限，0-无权限
            public byte byAlarmOffRight;         // 报警输入口撤防权限 1-有权限，0-无权限
            public byte byBypassRight;           // 报警输入口旁路权限 1-有权限，0-无权限 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 118, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;	
        }

        //单用户参数(子结构)(9000扩展)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_USER_INFO_V30
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* 用户名 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* 密码 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalRight;/* 本地权限 */
            /*数组0: 本地控制云台*/
            /*数组1: 本地手动录象*/
            /*数组2: 本地回放*/
            /*数组3: 本地设置参数*/
            /*数组4: 本地查看状态、日志*/
            /*数组5: 本地高级操作(升级，格式化，重启，关机)*/
            /*数组6: 本地查看参数 */
            /*数组7: 本地管理模拟和IP camera */
            /*数组8: 本地备份 */
            /*数组9: 本地关机/重启 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.I1)]
            public byte[] byRemoteRight;/* 远程权限 */
            /*数组0: 远程控制云台*/
            /*数组1: 远程手动录象*/
            /*数组2: 远程回放 */
            /*数组3: 远程设置参数*/
            /*数组4: 远程查看状态、日志*/
            /*数组5: 远程高级操作(升级，格式化，重启，关机)*/
            /*数组6: 远程发起语音对讲*/
            /*数组7: 远程预览*/
            /*数组8: 远程请求报警上传、报警输出*/
            /*数组9: 远程控制，本地输出*/
            /*数组10: 远程控制串口*/
            /*数组11: 远程查看参数 */
            /*数组12: 远程管理模拟和IP camera */
            /*数组13: 远程关机/重启 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byNetPreviewRight;/* 远程可以预览的通道 0-有权限，1-无权限*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalPlaybackRight;/* 本地可以回放的通道 0-有权限，1-无权限*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byNetPlaybackRight;/* 远程可以回放的通道 0-有权限，1-无权限*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalRecordRight;/* 本地可以录像的通道 0-有权限，1-无权限*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byNetRecordRight;/* 远程可以录像的通道 0-有权限，1-无权限*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalPTZRight;/* 本地可以PTZ的通道 0-有权限，1-无权限*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byNetPTZRight;/* 远程可以PTZ的通道 0-有权限，1-无权限*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalBackupRight;/* 本地备份权限通道 0-有权限，1-无权限*/
            public NET_DVR_IPADDR struUserIP;/* 用户IP地址(为0时表示允许任何地址) */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;/* 物理地址 */
            public byte byPriority;/* 优先级，0xff-无，0--低，1--中，2--高 */
            /*
            无……表示不支持优先级的设置
            低……默认权限:包括本地和远程回放,本地和远程查看日志和状态,本地和远程关机/重启
            中……包括本地和远程控制云台,本地和远程手动录像,本地和远程回放,语音对讲和远程预览
                  本地备份,本地/远程关机/重启
            高……管理员
            */
            public byte byAlarmOnRight;         // 报警输入口布防权限
            public byte byAlarmOffRight;        // 报警输入口撤防权限
            public byte byBypassRight;          // 报警输入口旁路权限
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //单用户参数(SDK_V15扩展)(子结构)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_USER_INFO_EX
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* 用户名 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* 密码 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalRight;/* 权限 */
            /*数组0: 本地控制云台*/
            /*数组1: 本地手动录象*/
            /*数组2: 本地回放*/
            /*数组3: 本地设置参数*/
            /*数组4: 本地查看状态、日志*/
            /*数组5: 本地高级操作(升级，格式化，重启，关机)*/
            public uint dwLocalPlaybackRight;/* 本地可以回放的通道 bit0 -- channel 1*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRemoteRight;/* 权限 */
            /*数组0: 远程控制云台*/
            /*数组1: 远程手动录象*/
            /*数组2: 远程回放 */
            /*数组3: 远程设置参数*/
            /*数组4: 远程查看状态、日志*/
            /*数组5: 远程高级操作(升级，格式化，重启，关机)*/
            /*数组6: 远程发起语音对讲*/
            /*数组7: 远程预览*/
            /*数组8: 远程请求报警上传、报警输出*/
            /*数组9: 远程控制，本地输出*/
            /*数组10: 远程控制串口*/
            public uint dwNetPreviewRight;/* 远程可以预览的通道 bit0 -- channel 1*/
            public uint dwNetPlaybackRight;/* 远程可以回放的通道 bit0 -- channel 1*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sUserIP;/* 用户IP地址(为0时表示允许任何地址) */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;/* 物理地址 */
        }

        //单用户参数(子结构)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_USER_INFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* 用户名 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* 密码 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalRight;/* 权限 */
            /*数组0: 本地控制云台*/
            /*数组1: 本地手动录象*/
            /*数组2: 本地回放*/
            /*数组3: 本地设置参数*/
            /*数组4: 本地查看状态、日志*/
            /*数组5: 本地高级操作(升级，格式化，重启，关机)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRemoteRight;/* 权限 */
            /*数组0: 远程控制云台*/
            /*数组1: 远程手动录象*/
            /*数组2: 远程回放 */
            /*数组3: 远程设置参数*/
            /*数组4: 远程查看状态、日志*/
            /*数组5: 远程高级操作(升级，格式化，重启，关机)*/
            /*数组6: 远程发起语音对讲*/
            /*数组7: 远程预览*/
            /*数组8: 远程请求报警上传、报警输出*/
            /*数组9: 远程控制，本地输出*/
            /*数组10: 远程控制串口*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sUserIP;/* 用户IP地址(为0时表示允许任何地址) */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;/* 物理地址 */
        }
        
        //单用户参数(子结构)(扩展)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_USER_INFO_V51
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;            /* 用户名只能用16字节 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;            /* 密码 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalRight;    /* 本地权限 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.I1)]
            public byte[] byRemoteRight;/* 远程权限 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwNetPreviewRight;            /* 远程可以预览的通道，从前往后顺序排列，遇到0xffffffff后续均为无效*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalRecordRight;            /* 本地可以录像的通道，从前往后顺序排列，遇到0xffffffff后续均为无效*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwNetRecordRight;            /* 远程可以录像的通道，从前往后顺序排列，遇到0xffffffff后续均为无效*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalPlaybackRight;            /* 本地可以回放的通道，从前往后顺序排列，遇到0xffffffff后续均为无效*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwNetPlaybackRight;            /* 远程可以回放的通道，从前往后顺序排列，遇到0xffffffff后续均为无效*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalPTZRight;                /* 本地可以PTZ的通道，从前往后顺序排列，遇到0xffffffff后续均为无效*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwNetPTZRight;                /* 远程可以PTZ的通道，从前往后顺序排列，遇到0xffffffff后续均为无效*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalBackupRight;            /* 本地备份权限通道，从前往后顺序排列，遇到0xffffffff后续均为无效*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalPreviewRight;		/* 本地预览权限通道，从前往后顺序排列，遇到0xffffffff后续均为无效*/
            public NET_DVR_IPADDR struUserIP;                /* 用户IP地址(为0时表示允许任何地址) */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;    /* 物理地址 */
            public byte byPriority;                /* 优先级，0xff-无，0--低，1--中，2--高 */
            public byte byAlarmOnRight;         // 报警输入口布防权限 1-有权限，0-无权限
            public byte byAlarmOffRight;         // 报警输入口撤防权限 1-有权限，0-无权限
            public byte byBypassRight;           // 报警输入口旁路权限 1-有权限，0-无权限 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;               //四字节对齐
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.I1)]
            public byte[] byPublishRight;  //信息发布专有权限
            public uint dwPasswordValidity;   //密码有效期,仅管理员用户可以修改,单位：天，填0表示永久生效
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byKeypadPassword;    //键盘密码
            public byte byUserOperateType;    //用户操作类型，1-网络用户，2-键盘用户，3-网络用户+键盘用户
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 1007, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
       }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_USER_V51
        {
            public uint dwSize;  //结构体大小
            public uint dwMaxUserNum; //设备支持的最大用户数-只读
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_USERNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_USER_INFO_V51[] struUser;  /* 用户参数 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sloginPassword;          /* 登陆密码确认 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 240, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //保留
        }

        //DVR用户参数(扩展)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_USER_V40
        {
            public uint dwSize;  //结构体大小
            public uint dwMaxUserNum; //设备支持的最大用户数-只读
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_USERNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_USER_INFO_V40[] struUser;  /* 用户参数 */
        }

        //DVR用户参数(9000扩展)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_USER_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_USERNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_USER_INFO_V30[] struUser;
        }

        //DVR用户参数(SDK_V15扩展)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_USER_EX
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_USERNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_USER_INFO_EX[] struUser;
        }

        //DVR用户参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_USER
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_USERNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_USER_INFO[] struUser;
        }

        //异常参数配置扩展结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EXCEPTION_V40
        {
            public uint dwSize ;             //结构体大小
            public uint dwMaxGroupNum ;    //设备支持的最大组数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EXCEPTIONNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_HANDLEEXCEPTION_V41[] struExceptionHandle;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;          //保留
        } 

        //DVR异常参数(9000扩展)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EXCEPTION_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EXCEPTIONNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_HANDLEEXCEPTION_V30[] struExceptionHandleType;
            /*数组0-盘满,1- 硬盘出错,2-网线断,3-局域网内IP 地址冲突, 4-非法访问, 5-输入/输出视频制式不匹配, 6-视频信号异常, 7-录像异常*/
        }

        //DVR异常参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EXCEPTION
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EXCEPTIONNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_HANDLEEXCEPTION[] struExceptionHandleType;
            /*数组0-盘满,1- 硬盘出错,2-网线断,3-局域网内IP 地址冲突,4-非法访问, 5-输入/输出视频制式不匹配, 6-视频信号异常*/
        }

        //通道状态(9000扩展)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CHANNELSTATE_V30
        {
            public byte byRecordStatic;//通道是否在录像,0-不录像,1-录像
            public byte bySignalStatic;//连接的信号状态,0-正常,1-信号丢失
            public byte byHardwareStatic;//通道硬件状态,0-正常,1-异常,例如DSP死掉
            public byte byRes1;//保留
            public uint dwBitRate;//实际码率
            public uint dwLinkNum;//客户端连接的个数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LINK, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPADDR[] struClientIP;//客户端的IP地址
            public uint dwIPLinkNum;//如果该通道为IP接入，那么表示IP接入当前的连接数
            public byte byExceedMaxLink;		// 是否超出了单路6路连接数 0 - 未超出, 1-超出
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwChannelNo;    //当前的通道号，0xffffffff表示无效

            public void Init()
            {
                struClientIP = new NET_DVR_IPADDR[MAX_LINK];

                for (int i = 0; i < MAX_LINK; i++)
                {
                    struClientIP[i].Init();
                }
                byRes = new byte[12];
            }
        }

        //通道状态
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CHANNELSTATE
        {
            public byte byRecordStatic;//通道是否在录像,0-不录像,1-录像
            public byte bySignalStatic;//连接的信号状态,0-正常,1-信号丢失
            public byte byHardwareStatic;//通道硬件状态,0-正常,1-异常,例如DSP死掉
            public byte reservedData;//保留
            public uint dwBitRate;//实际码率
            public uint dwLinkNum;//客户端连接的个数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LINK, ArraySubType = UnmanagedType.U4)]
            public uint[] dwClientIP;//客户端的IP地址
        }

        //硬盘状态
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISKSTATE
        {
            public uint dwVolume;//硬盘的容量
            public uint dwFreeSpace;//硬盘的剩余空间
            public uint dwHardDiskStatic;//硬盘的状态,0-活动,1-休眠,2-不正常
        }

        //设备工作状态扩展结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WORKSTATE_V40
        { 
            public uint dwSize ;            //结构体大小
            public uint dwDeviceStatic; 	 //设备的状态,0-正常,1-CPU占用率太高,超过85%,2-硬件错误,例如串口死掉
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DISKSTATE[]  struHardDiskStatic;   //硬盘状态,一次最多只能获取33个硬盘信息
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CHANNELSTATE_V30[] struChanStatic;//通道的状态，从前往后顺序排列
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwHasAlarmInStatic; //有报警的报警输入口，按值表示，按下标值顺序排列，值为0xffffffff时当前及后续值无效
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwHasAlarmOutStatic; //有报警输出的报警输出口，按值表示，按下标值顺序排列，值为0xffffffff时当前及后续值无效
            public uint dwLocalDisplay;			//本地显示状态,0-正常,1-不正常
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AUDIO_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAudioInChanStatus;		//按位表示语音通道的状态 0-未使用，1-使用中，第0位表示第1个语音通道
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 126, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; 				//保留
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_GETWORKSTATE_COND
        {
            public uint dwSize ;  //结构体长度
            public byte byFindHardByCond; /*0-查找全部磁盘(但一次最多只能查找33个)，此时dwFindHardStatusNum无效*/
            public byte byFindChanByCond ;  /*0-查找全部通道，此时dwFindChanNum无效*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//保留	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM_V30, ArraySubType = UnmanagedType.U4)]
            public uint[] dwFindHardStatus ; /*要查找的硬盘号，按值表示，该值采用顺序排列， 遇到0xffffffff则认为后续无效 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwFindChanNo; /*要查找的通道号，按值表示，该值采用顺序排列， 遇到0xffffffff则认为后续无效 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //保留
        }

        //DVR工作状态(9000扩展)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WORKSTATE_V30
        {
            public uint dwDeviceStatic;//设备的状态,0-正常,1-CPU占用率太高,超过85%,2-硬件错误,例如串口死掉
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DISKSTATE[] struHardDiskStatic;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CHANNELSTATE_V30[] struChanStatic;//通道的状态
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmInStatic;//报警端口的状态,0-没有报警,1-有报警
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmOutStatic;//报警输出端口的状态,0-没有输出,1-有报警输出
            public uint dwLocalDisplay;//本地显示状态,0-正常,1-不正常
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AUDIO_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAudioChanStatus;//表示语音通道的状态 0-未使用，1-使用中, 0xff无效
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void Init()
            {
                struHardDiskStatic = new NET_DVR_DISKSTATE[MAX_DISKNUM_V30];
                struChanStatic = new NET_DVR_CHANNELSTATE_V30[MAX_CHANNUM_V30];
                for (int i = 0; i < MAX_CHANNUM_V30; i++)
                {
                    struChanStatic[i].Init();
                }
                byAlarmInStatic = new byte[MAX_ALARMOUT_V30];
                byAlarmOutStatic = new byte[MAX_ALARMOUT_V30];
                byAudioChanStatus = new byte[MAX_AUDIO_V30];
                byRes = new byte[10];
            }
        }

        //DVR工作状态
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WORKSTATE
        {
            public uint dwDeviceStatic;//设备的状态,0-正常,1-CPU占用率太高,超过85%,2-硬件错误,例如串口死掉
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DISKSTATE[] struHardDiskStatic;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CHANNELSTATE[] struChanStatic;//通道的状态
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmInStatic;//报警端口的状态,0-没有报警,1-有报警
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmOutStatic;//报警输出端口的状态,0-没有输出,1-有报警输出
            public uint dwLocalDisplay;//本地显示状态,0-正常,1-不正常

            public void Init()
            {
                struHardDiskStatic = new NET_DVR_DISKSTATE[MAX_DISKNUM];
                struChanStatic = new NET_DVR_CHANNELSTATE[MAX_CHANNUM];
                byAlarmInStatic = new byte[MAX_ALARMIN];
                byAlarmOutStatic = new byte[MAX_ALARMOUT];
            }
        }        

        //日志信息(9000扩展)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_LOG_V30
        {
            public NET_DVR_TIME strLogTime;
            public uint dwMajorType;//主类型 1-报警; 2-异常; 3-操作; 0xff-全部
            public uint dwMinorType;//次类型 0-全部;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPanelUser;//操作面板的用户名
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sNetUser;//网络操作的用户名
            public NET_DVR_IPADDR struRemoteHostAddr;//远程主机地址
            public uint dwParaType;//参数类型
            public uint dwChannel;//通道号
            public uint dwDiskNumber;//硬盘号
            public uint dwAlarmInPort;//报警输入端口
            public uint dwAlarmOutPort;//报警输出端口
            public uint dwInfoLen;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = LOG_INFO_LEN)]
            public string sInfo;
        }

        //日志信息
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_LOG
        {
            public NET_DVR_TIME strLogTime;
            public uint dwMajorType;//主类型 1-报警; 2-异常; 3-操作; 0xff-全部
            public uint dwMinorType;//次类型 0-全部;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPanelUser;//操作面板的用户名
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sNetUser;//网络操作的用户名
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sRemoteHostAddr;//远程主机地址
            public uint dwParaType;//参数类型
            public uint dwChannel;//通道号
            public uint dwDiskNumber;//硬盘号
            public uint dwAlarmInPort;//报警输入端口
            public uint dwAlarmOutPort;//报警输出端口
        }

        /************************动环报警管理主机日志查找 begin************************************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMHOST_SEARCH_LOG_PARAM
        {
            public ushort wMajorType;		// 主类型
            public ushort wMinorType;		// 次类型 
            public NET_DVR_TIME    struStartTime;	// 开始时间 
            public NET_DVR_TIME    struEndTime;	// 结束时间
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// 保留字节
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMHOST_LOG_RET
        {
            public NET_DVR_TIME	struLogTime;                //  日志时间
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;     // 操作用户
            public NET_DVR_IPADDR	struIPAddr;                 // 操作IP地址
            public ushort wMajorType;                 // 主类型 
            public ushort wMinorType;                 // 次类型
            public ushort wParam;	                    // 操作参数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwInfoLen;	                // 描述信息长度
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = LOG_INFO_LEN)]
            public string sInfo;       // 描述信息
        }
        /*************************动环报警管理主机日志查找 end***********************************************/

        //报警输出状态(9000扩展)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMOUTSTATUS_V30
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] Output;

            public void Init()
            {
                Output = new byte[MAX_ALARMOUT_V30];
            }
        }

        //报警输出状态
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMOUTSTATUS
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] Output;
        }        

        //ATM专用
        /****************************ATM(begin)***************************/
        public const int NCR = 0;
        public const int DIEBOLD = 1;
        public const int WINCOR_NIXDORF = 2;
        public const int SIEMENS = 3;
        public const int OLIVETTI = 4;
        public const int FUJITSU = 5;
        public const int HITACHI = 6;
        public const int SMI = 7;
        public const int IBM = 8;
        public const int BULL = 9;
        public const int YiHua = 10;
        public const int LiDe = 11;
        public const int GDYT = 12;
        public const int Mini_Banl = 13;
        public const int GuangLi = 14;
        public const int DongXin = 15;
        public const int ChenTong = 16;
        public const int NanTian = 17;
        public const int XiaoXing = 18;
        public const int GZYY = 19;
        public const int QHTLT = 20;
        public const int DRS918 = 21;
        public const int KALATEL = 22;
        public const int NCR_2 = 23;
        public const int NXS = 24;

        //交易信息
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_TRADEINFO
        {
            public ushort m_Year;
            public ushort m_Month;
            public ushort m_Day;
            public ushort m_Hour;
            public ushort m_Minute;
            public ushort m_Second;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] DeviceName;//设备名称
            public uint dwChannelNumer;//通道号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] CardNumber;//卡号
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 12)]
            public string cTradeType;//交易类型
            public uint dwCash;//交易金额
        }

        /*帧格式*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FRAMETYPECODE
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] code;/* 代码 */
        }
        
        //ATM参数
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_FRAMEFORMAT
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sATMIP;/* ATM IP地址 */
            public uint dwATMType;/* ATM类型 */
            public uint dwInputMode;/* 输入方式	0-网络侦听 1-网络接收 2-串口直接输入 3-串口ATM命令输入*/
            public uint dwFrameSignBeginPos;/* 报文标志位的起始位置*/
            public uint dwFrameSignLength;/* 报文标志位的长度 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byFrameSignContent;/* 报文标志位的内容 */
            public uint dwCardLengthInfoBeginPos;/* 卡号长度信息的起始位置 */
            public uint dwCardLengthInfoLength;/* 卡号长度信息的长度 */
            public uint dwCardNumberInfoBeginPos;/* 卡号信息的起始位置 */
            public uint dwCardNumberInfoLength;/* 卡号信息的长度 */
            public uint dwBusinessTypeBeginPos;/* 交易类型的起始位置 */
            public uint dwBusinessTypeLength;/* 交易类型的长度 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_FRAMETYPECODE[] frameTypeCode;/* 类型 */
        }

        //SDK_V31 ATM
        /*过滤设置*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FILTER
        {
            public byte byEnable;/*0,不启用;1,启用*/
            public byte byMode;/*0,ASCII;1,HEX*/
            public byte byFrameBeginPos;// 报文标志位的起始位置     
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byFilterText;/*过滤字符串*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*起始标识设置*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IDENTIFICAT
        {
            public byte byStartMode;/*0,ASCII;1,HEX*/
            public byte byEndMode;/*0,ASCII;1,HEX*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_FRAMETYPECODE struStartCode;/*起始字符*/
            public NET_DVR_FRAMETYPECODE struEndCode;/*结束字符*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }

        /*报文信息位置*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PACKAGE_LOCATION
        {
            public byte byOffsetMode;/*0,token;1,fix*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwOffsetPos;/*mode为1的时候使用*/
            public NET_DVR_FRAMETYPECODE struTokenCode;/*标志位*/
            public byte byMultiplierValue;/*标志位多少次出现*/
            public byte byEternOffset;/*附加的偏移量*/
            public byte byCodeMode;/*0,ASCII;1,HEX*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*报文信息长度*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PACKAGE_LENGTH
        {
            public byte byLengthMode;/*长度类型，0,variable;1,fix;2,get from package(设置卡号长度使用)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwFixLength;/*mode为1的时候使用*/
            public uint dwMaxLength;
            public uint dwMinLength;
            public byte byEndMode;/*终结符0,ASCII;1,HEX*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public NET_DVR_FRAMETYPECODE struEndCode;/*终结符*/
            public uint dwLengthPos;/*lengthMode为2的时候使用，卡号长度在报文中的位置*/
            public uint dwLengthLen;/*lengthMode为2的时候使用，卡号长度的长度*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }

        /*OSD 叠加的位置*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OSD_POSITION
        {
            public byte byPositionMode;/*叠加风格，共2种；0，不显示；1，Custom*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwPos_x;/*x坐标，positionmode为Custom时使用*/
            public uint dwPos_y;/*y坐标，positionmode为Custom时使用*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*日期显示格式*/
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_DATE_FORMAT
        {
            public byte byItem1;/*Month,0.mm;1.mmm;2.mmmm*/
            public byte byItem2;/*Day,0.dd;*/
            public byte byItem3;/*Year,0.yy;1.yyyy*/
            public byte byDateForm;/*0~5，3个item的排列组合*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 4)]
            public string chSeprator;/*分隔符*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 4)]
            public string chDisplaySeprator;/*显示分隔符*/
            public byte byDisplayForm;/*0~5，3个item的排列组合*///lili mode by lili
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 27, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        /*时间显示格式*/
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVRT_TIME_FORMAT
        {
            public byte byTimeForm;/*1. HH MM SS;0. HH MM*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byHourMode;/*0,12;1,24*/ //lili mode
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 4)]
            public string chSeprator;/*报文分隔符，暂时没用*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 4)]
            public string chDisplaySeprator;/*显示分隔符*/
            public byte byDisplayForm;/*0~5，3个item的排列组合*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
            public byte byDisplayHourMode;/*0,12;1,24*/ //lili mode
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 19, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes4;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OVERLAY_CHANNEL
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byChannel;/*叠加的通道*/
            public uint dwDelayTime;/*叠加延时时间*/
            public byte byEnableDelayTime;/*是否启用叠加延时，在无退卡命令时启用*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_PACKAGE_ACTION
        {
            public NET_DVR_PACKAGE_LOCATION struPackageLocation;
            public NET_DVR_OSD_POSITION struOsdPosition;
            public NET_DVR_FRAMETYPECODE struActionCode;/*交易类型等对应的码*/
            public NET_DVR_FRAMETYPECODE struPreCode;/*叠加字符前的字符*/
            public byte byActionCodeMode;/*交易类型等对应的码0,ASCII;1,HEX*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_PACKAGE_DATE
        {
            public NET_DVR_PACKAGE_LOCATION struPackageLocation;
            public NET_DVR_DATE_FORMAT struDateForm;
            public NET_DVR_OSD_POSITION struOsdPosition;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_PACKAGE_TIME
        {
            public NET_DVR_PACKAGE_LOCATION location;
            public NET_DVRT_TIME_FORMAT struTimeForm;
            public NET_DVR_OSD_POSITION struOsdPosition;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_PACKAGE_OTHERS
        {
            public NET_DVR_PACKAGE_LOCATION struPackageLocation;
            public NET_DVR_PACKAGE_LENGTH struPackageLength;
            public NET_DVR_OSD_POSITION struOsdPosition;
            public NET_DVR_FRAMETYPECODE struPreCode;/*叠加字符前的字符*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        //用户自定义协议
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_USER_DEFINE_PROTOCOL
        {
            public NET_DVR_IDENTIFICAT        struIdentification;  //报文标志
            public NET_DVR_FILTER             struFilter; //数据包过滤设置
            public NET_DVR_ATM_PACKAGE_OTHERS struCardNoPara; //叠加卡号设置
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ACTION_TYPE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ATM_PACKAGE_ACTION[] struTradeActionPara; //叠加交易行为设置 0-9 依次对应InCard OutCard OverLay SetTime GetStatus Query WithDraw Deposit ChanPass Transfer
            public NET_DVR_ATM_PACKAGE_OTHERS struAmountPara; //叠加交易金额设置
            public NET_DVR_ATM_PACKAGE_OTHERS struSerialNoPara; //叠加交易序号设置
            public NET_DVR_OVERLAY_CHANNEL    struOverlayChan; //叠加通道设置
            public NET_DVR_ATM_PACKAGE_DATE   struRes1; //叠加日期，保留
            public NET_DVR_ATM_PACKAGE_TIME   struRes2; //叠加时间，保留
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;        //保留
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_FRAMEFORMAT_V30
        {		
            public uint dwSize;                 //结构大小
            public byte byEnable;				/*是否启用0,不启用;1,启用*/
            public byte byInputMode;			/**输入方式:0-网络监听、1网络协议、2-串口监听、3-串口协议*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;              //保留字节 
            public NET_DVR_IPADDR struAtmIp;				/*ATM 机IP 网络监听时使用 */
            public ushort wAtmPort;				/* 网络协议方式时是使用*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;              // 保留字节
            public uint dwAtmType;				/*ATM协议类型，从NET_DVR_ATM_PROTOCOL结构中获取，如果类型为自定义时使用用户自定义协议*/
            public NET_DVR_ATM_USER_DEFINE_PROTOCOL  struAtmUserDefineProtocol; //用户自定义协议，当ATM类型为自定时需要使用该定义
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }

        //协议信息数据结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_PROTO_TYPE
        {
            public uint dwAtmType; //ATM协议类型，同时作为索引序号 ATM 配置中的dwAtmType 自定义时为1025
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = ATM_DESC_LEN)]
            public string chDesc; //ATM协议简单描述
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_ATM_PROTO_LIST
        {
            public uint dwAtmProtoNum;/*协议列表的个数*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ATM_PROTOCOL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ATM_PROTO_TYPE[] struAtmProtoType;/*协议列表信息*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_PROTOCOL
        {
            public uint dwSize;
            public NET_DVR_ATM_PROTO_LIST struNetListenList;     // 网络监听协议描述
            public NET_DVR_ATM_PROTO_LIST struSerialListenList; //串口监听协议描述
            public NET_DVR_ATM_PROTO_LIST struNetProtoList;     //网络协议描述
            public NET_DVR_ATM_PROTO_LIST struSerialProtoList;   //串口协议描述
            public NET_DVR_ATM_PROTO_TYPE struCustomProto;      //自定义协议            
        }

        /*****************************DS-6001D/F(begin)***************************/
        //DS-6001D Decoder
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODERINFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byEncoderIP;//解码设备连接的服务器IP
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byEncoderUser;//解码设备连接的服务器的用户名
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byEncoderPasswd;//解码设备连接的服务器的密码
            public byte bySendMode;//解码设备连接服务器的连接模式
            public byte byEncoderChannel;//解码设备连接的服务器的通道号
            public ushort wEncoderPort;//解码设备连接的服务器的端口号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] reservedData;//保留
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODERSTATE
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byEncoderIP;//解码设备连接的服务器IP
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byEncoderUser;//解码设备连接的服务器的用户名
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byEncoderPasswd;//解码设备连接的服务器的密码
            public byte byEncoderChannel;//解码设备连接的服务器的通道号
            public byte bySendMode;//解码设备连接的服务器的连接模式
            public ushort wEncoderPort;//解码设备连接的服务器的端口号
            public uint dwConnectState;//解码设备连接服务器的状态
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] reservedData;//保留
        }

        /*解码设备控制码定义*/
        public const int NET_DEC_STARTDEC = 1;
        public const int NET_DEC_STOPDEC = 2;
        public const int NET_DEC_STOPCYCLE = 3;
        public const int NET_DEC_CONTINUECYCLE = 4;

        /*连接的通道配置*/
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_DECCHANINFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDVRIP;/* DVR IP地址 */
            public ushort wDVRPort;/* 端口号 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* 用户名 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* 密码 */
            public byte byChannel;/* 通道号 */
            public byte byLinkMode;/* 连接模式 */
            public byte byLinkType;/* 连接类型 0－主码流 1－子码流 */
        }

        /*每个解码通道的配置*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECINFO
        {
            public byte byPoolChans;/*每路解码通道上的循环通道数量, 最多4通道 0表示没有解码*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DECPOOLNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DECCHANINFO[] struchanConInfo;
            public byte byEnablePoll;/*是否轮巡 0-否 1-是*/
            public byte byPoolTime;/*轮巡时间 0-保留 1-10秒 2-15秒 3-20秒 4-30秒 5-45秒 6-1分钟 7-2分钟 8-5分钟 */
        }

        /*整个设备解码配置*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECCFG
        {
            public uint dwSize;
            public uint dwDecChanNum;/*解码通道的数量*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DECNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DECINFO[] struDecInfo;
        }

        //2005-08-01
        /* 解码设备透明通道设置 */
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_PORTINFO
        {
            public uint dwEnableTransPort;/* 是否启动透明通道 0－不启用 1－启用*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDecoderIP;/* DVR IP地址 */
            public ushort wDecoderPort;/* 端口号 */
            public ushort wDVRTransPort;/* 配置前端DVR是从485/232输出，1表示232串口,2表示485串口 */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 4)]
            public string cReserve;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PORTCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TRANSPARENTNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PORTINFO[] struTransPortInfo;/* 数组0表示232 数组1表示485 */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]               
        public struct bytime
        {
            public uint dwChannel;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/*请求视频用户名*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* 密码 */
            public NET_DVR_TIME struStartTime;/* 按时间回放的开始时间 */
            public NET_DVR_TIME struStopTime;/* 按时间回放的结束时间 */
        }

        /* 控制网络文件回放 */
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_PLAYREMOTEFILE
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDecoderIP;/* DVR IP地址 */
            public ushort wDecoderPort;/* 端口号 */
            public ushort wLoadMode;/* 回放下载模式 1－按名字 2－按时间 */

            [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct mode_size
            {
                [FieldOffsetAttribute(0)]
                [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
                public byte[] byRes;

                /*[FieldOffsetAttribute(0)]
                [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]             
                public byte[] byFile;/* 回放的文件名 */
                /*[FieldOffsetAttribute(0)]
                public bytime bytime;
                * */
            }
        }



        /*当前设备解码连接状态*/
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_DECCHANSTATUS
        {
            public uint dwWorkType;/*工作方式：1：轮巡、2：动态连接解码、3：文件回放下载 4：按时间回放下载*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDVRIP;/*连接的设备ip*/
            public ushort wDVRPort;/*连接端口号*/
            public byte byChannel;/* 通道号 */
            public byte byLinkMode;/* 连接模式 */
            public uint dwLinkType;/*连接类型 0－主码流 1－子码流*/

            [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct objectInfo
            {
                [StructLayoutAttribute(LayoutKind.Sequential)]
                public struct userInfo
                {
                    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
                    public byte[] sUserName;/*请求视频用户名*/
                    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
                    public byte[] sPassword;/* 密码 */
                    [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 52)]
                    public string cReserve;
                }

                [StructLayoutAttribute(LayoutKind.Sequential)]
                public struct fileInfo
                {
                    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
                    public byte[] fileName;
                }
                [StructLayoutAttribute(LayoutKind.Sequential)]
                public struct timeInfo
                {
                    public uint dwChannel;
                    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
                    public byte[] sUserName;/*请求视频用户名*/
                    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
                    public byte[] sPassword;/* 密码 */
                    public NET_DVR_TIME struStartTime;/* 按时间回放的开始时间 */
                    public NET_DVR_TIME struStopTime;/* 按时间回放的结束时间 */
                }
            }
        }


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECSTATUS
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DECNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DECCHANSTATUS[] struTransPortInfo;
        }
        /*****************************DS-6001D/F(end)***************************/

        //单字符参数(子结构)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_SHOWSTRINGINFO
        {
            public ushort wShowString;// 预览的图象上是否显示字符,0-不显示,1-显示 区域大小704*576,单个字符的大小为32*32
            public ushort wStringSize;/* 该行字符的长度，不能大于44个字符 */
            public ushort wShowStringTopLeftX;/* 字符显示位置的x坐标 */
            public ushort wShowStringTopLeftY;/* 字符名称显示位置的y坐标 */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 44)]
            public string sString;/* 要显示的字符内容 */
        }

        //叠加字符(9000扩展)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SHOWSTRING_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_STRINGNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SHOWSTRINGINFO[] struStringInfo;/* 要显示的字符内容 */
        }

        //叠加字符扩展(8条字符)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SHOWSTRING_EX
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_STRINGNUM_EX, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SHOWSTRINGINFO[] struStringInfo;/* 要显示的字符内容 */
        }

        //叠加字符
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SHOWSTRING
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_STRINGNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SHOWSTRINGINFO[] struStringInfo;/* 要显示的字符内容 */
        }

        /****************************DS9000新增结构(begin)******************************/
        /*EMAIL参数结构*/
        //与原结构体有差异
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct struReceiver
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sName;/* 收件人姓名 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EMAIL_ADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAddress;/* 收件人地址 */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EMAILCFG_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAccount;/* 账号*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EMAIL_PWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/*密码 */

            [StructLayoutAttribute(LayoutKind.Sequential)]
            public struct struSender
            {
                [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
                public byte[] sName;/* 发件人姓名 */
                [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EMAIL_ADDR_LEN, ArraySubType = UnmanagedType.I1)]
                public byte[] sAddress;/* 发件人地址 */
            }

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EMAIL_ADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSmtpServer;/* smtp服务器 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EMAIL_ADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPop3Server;/* pop3服务器 */

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.Struct)]
            public struReceiver[] struStringInfo;/* 最多可以设置3个收件人 */

            public byte byAttachment;/* 是否带附件 */
            public byte bySmtpServerVerify;/* 发送服务器要求身份验证 */
            public byte byMailInterval;/* mail interval */
            public byte byEnableSSL;//ssl是否启用9000_1.1
            public ushort wSmtpPort;//gmail的465，普通的为25  
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 74, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//保留
        }

        /*DVR实现巡航数据结构*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CRUISE_PARA
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CRUISE_MAX_PRESET_NUMS, ArraySubType = UnmanagedType.I1)]
            public byte[] byPresetNo;/* 预置点号 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CRUISE_MAX_PRESET_NUMS, ArraySubType = UnmanagedType.I1)]
            public byte[] byCruiseSpeed;/* 巡航速度 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CRUISE_MAX_PRESET_NUMS, ArraySubType = UnmanagedType.U2)]
            public ushort[] wDwellTime;/* 停留时间 */
            public byte byEnableThisCruise;/* 是否启用 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }
        /****************************DS9000新增结构(end)******************************/     
        //时间点
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TIMEPOINT
        {
            public uint dwMonth;//月 0-11表示1-12个月
            public uint dwWeekNo;//第几周 0－第1周 1－第2周 2－第3周 3－第4周 4－最后一周
            public uint dwWeekDate;//星期几 0－星期日 1－星期一 2－星期二 3－星期三 4－星期四 5－星期五 6－星期六
            public uint dwHour;//小时	开始时间0－23 结束时间1－23
            public uint dwMin;//分	0－59
        }

        //夏令时参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ZONEANDDST
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//保留
            public uint dwEnableDST;//是否启用夏时制 0－不启用 1－启用
            public byte byDSTBias;//夏令时偏移值，30min, 60min, 90min, 120min, 以分钟计，传递原始数值
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public NET_DVR_TIMEPOINT struBeginPoint;//夏时制开始时间
            public NET_DVR_TIMEPOINT struEndPoint;//夏时制停止时间
        }

        //图片质量
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_JPEGPARA
        {
            /*注意：当图像压缩分辨率为VGA时，支持0=CIF, 1=QCIF, 2=D1抓图，
	        当分辨率为3=UXGA(1600x1200), 4=SVGA(800x600), 5=HD720p(1280x720),6=VGA,7=XVGA, 8=HD900p
	        仅支持当前分辨率的抓图*/
            public ushort wPicSize;/* 0=CIF, 1=QCIF, 2=D1 3=UXGA(1600x1200), 4=SVGA(800x600), 5=HD720p(1280x720),6=VGA*/
            public ushort wPicQuality;/* 图片质量系数 0-最好 1-较好 2-一般 */
        }

        /* aux video out parameter */
        //辅助输出参数配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AUXOUTCFG
        {
            public uint dwSize;
            public uint dwAlarmOutChan;/* 选择报警弹出大报警通道切换时间：1画面的输出通道: 0:主输出/1:辅1/2:辅2/3:辅3/4:辅4 */
            public uint dwAlarmChanSwitchTime;/* :1秒 - 10:10秒 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AUXOUT, ArraySubType = UnmanagedType.U4)]
            public uint[] dwAuxSwitchTime;/* 辅助输出切换时间: 0-不切换,1-5s,2-10s,3-20s,4-30s,5-60s,6-120s,7-300s */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AUXOUT * MAX_WINDOW, ArraySubType = UnmanagedType.I1)]
            public byte[] byAuxOrder;/* 辅助输出预览顺序, 0xff表示相应的窗口不预览 */
        }

        //ntp
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NTPPARA
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sNTPServer;/* Domain Name or IP addr of NTP server */
            public ushort wInterval;/* adjust time interval(hours) */
            public byte byEnableNTP;/* enable NPT client 0-no，1-yes*/
            public byte cTimeDifferenceH;/* 与国际标准时间的 小时偏移-12 ... +13 */
            public byte cTimeDifferenceM;/* 与国际标准时间的 分钟偏移0, 30, 45*/
            public byte res1;
            public ushort wNtpPort; /* ntp server port 9000新增 设备默认为123*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] res2;
        }

        //ddns
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DDNSPARA
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUsername;/* DDNS账号用户名/密码 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sDomainName; /* 域名 */
            public byte byEnableDDNS;/*是否应用 0-否，1-是*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DDNSPARA_EX
        {
            public byte byHostIndex;/* 0-Hikvision DNS 1－Dyndns 2－PeanutHull(花生壳)*/
            public byte byEnableDDNS;/*是否应用DDNS 0-否，1-是*/
            public ushort wDDNSPort;/* DDNS端口号 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUsername;/* DDNS用户名*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* DDNS密码 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] sDomainName;/* 设备配备的域名地址 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] sServerName;/* DDNS 对应的服务器地址，可以是IP地址或域名 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //9000扩展
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct struDDNS
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUsername;/* DDNS账号用户名*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* 密码 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] sDomainName;/* 设备配备的域名地址 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] sServerName;/* DDNS协议对应的服务器地址，可以是IP地址或域名 */
            public ushort wDDNSPort;/* 端口号 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DDNSPARA_V30
        {
            public byte byEnableDDNS;
            public byte byHostIndex;/* 0-Hikvision DNS(保留) 1－Dyndns 2－PeanutHull(花生壳)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DDNS_NUMS, ArraySubType = UnmanagedType.Struct)]
            public struDDNS[] struDDNS;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //email
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EMAILPARA
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sUsername;/* 邮件账号/密码 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sSmtpServer;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sPop3Server;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sMailAddr;/* email */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sEventMailAddr1;/* 上传报警/异常等的email */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sEventMailAddr2;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        //网络参数配置
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_NETAPPCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDNSIp; /* DNS服务器地址 */
            public NET_DVR_NTPPARA struNtpClientParam;/* NTP参数 */
            public NET_DVR_DDNSPARA struDDNSClientParam;/* DDNS参数 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 464, ArraySubType = UnmanagedType.I1)]
            public byte[] res;/* 保留 */
        }

        //nfs结构配置
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_SINGLE_NFS
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sNfsHostIPAddr;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PATHNAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sNfsDirectory;

            public void Init()
            {
                this.sNfsDirectory = new byte[PATHNAME_LEN];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NFSCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NFS_DISK, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SINGLE_NFS[] struNfsDiskParam;

            public void Init()
            {
                this.struNfsDiskParam = new NET_DVR_SINGLE_NFS[MAX_NFS_DISK];

                for (int i = 0; i < MAX_NFS_DISK; i++)
                {
                    struNfsDiskParam[i].Init();
                }
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ISCSI_CFG
        {   
            public uint dwSize;                   // 结构大小
            public ushort wVrmPort;                  // VRM 监听端口
            public byte byEnable;                  // 是否启用 ISCSI存储
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 69, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                 // 保留字节
            public NET_DVR_IPADDR struVrmAddr;          // VRM ip地址 16位
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string chNvtIndexCode;        //nvt index Code 
        }

        //巡航点配置(HIK IP快球专用)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CRUISE_POINT
        {
            public byte PresetNum;//预置点
            public byte Dwell;//停留时间
            public byte Speed;//速度
            public byte Reserve;//保留

            public void Init()
            {
                PresetNum = 0;
                Dwell = 0;
                Speed = 0;
                Reserve = 0;
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CRUISE_RET
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CRUISE_POINT[] struCruisePoint;//最大支持32个巡航点

            public void Init()
            {
                struCruisePoint = new NET_DVR_CRUISE_POINT[32];
                for (int i = 0; i < 32; i++)
                {
                    struCruisePoint[i].Init();
                }
            }
        }

        /************************************多路解码器(begin)***************************************/
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_NETCFG_OTHER
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sFirstDNSIP;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sSecondDNSIP;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MATRIX_DECINFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDVRIP;/* DVR IP地址 */
            public ushort wDVRPort;/* 端口号 */
            public byte byChannel;/* 通道号 */
            public byte byTransProtocol;/* 传输协议类型 0-TCP, 1-UDP */
            public byte byTransMode;/* 传输码流模式 0－主码流 1－子码流*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* 监控主机登陆帐号 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* 监控主机密码 */
        }

        //启动/停止动态解码
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_DYNAMIC_DEC
        {
            public uint dwSize;
            public NET_DVR_MATRIX_DECINFO struDecChanInfo;/* 动态解码通道信息 */
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MATRIX_DEC_CHAN_STATUS
        {
            public uint dwSize;
            public uint dwIsLinked;/* 解码通道状态 0－休眠 1－正在连接 2－已连接 3-正在解码 */
            public uint dwStreamCpRate;/* Stream copy rate, X kbits/second */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string cRes;/* 保留 */
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MATRIX_DEC_CHAN_INFO
        {
            public uint dwSize;
            public NET_DVR_MATRIX_DECINFO struDecChanInfo;/* 解码通道信息 */
            public uint dwDecState;/* 0-动态解码 1－循环解码 2－按时间回放 3－按文件回放 */
            public NET_DVR_TIME StartTime;/* 按时间回放开始时间 */
            public NET_DVR_TIME StopTime;/* 按时间回放停止时间 */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string sFileName;/* 按文件回放文件名 */
        }

        //连接的通道配置 2007-11-05
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_DECCHANINFO
        {
            public uint dwEnable;/* 是否启用 0－否 1－启用*/
            public NET_DVR_MATRIX_DECINFO struDecChanInfo;/* 轮循解码通道信息 */
        }

        //2007-11-05 新增每个解码通道的配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_LOOP_DECINFO
        {
            public uint dwSize;
            public uint dwPoolTime;/*轮巡时间 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CYCLE_CHAN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_DECCHANINFO[] struchanConInfo;
        }

        //2007-12-22
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct TTY_CONFIG
        {
            public byte baudrate;/* 波特率 */
            public byte databits;/* 数据位 */
            public byte stopbits;/* 停止位 */
            public byte parity;/* 奇偶校验位 */
            public byte flowcontrol;/* 流控 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MATRIX_TRAN_CHAN_INFO
        {
            public byte byTranChanEnable;/* 当前透明通道是否打开 0：关闭 1：打开 */
            /*
             *	多路解码器本地有1个485串口，1个232串口都可以作为透明通道,设备号分配如下：
             *	0 RS485
             *	1 RS232 Console
             */
            public byte byLocalSerialDevice;/* Local serial device */
            /*
	         *	远程串口输出还是两个,一个RS232，一个RS485
	         *	1表示232串口
	         *	2表示485串口
	         */
            public byte byRemoteSerialDevice;/* Remote output serial device */
            public byte res1;/* 保留 */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sRemoteDevIP;/* Remote Device IP */
            public ushort wRemoteDevPort;/* Remote Net Communication Port */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] res2;/* 保留 */
            public TTY_CONFIG RemoteSerialDevCfg;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_TRAN_CHAN_CONFIG
        {
            public uint dwSize;
            public byte by232IsDualChan;/* 设置哪路232透明通道是全双工的 取值1到MAX_SERIAL_NUM */
            public byte by485IsDualChan;/* 设置哪路485透明通道是全双工的 取值1到MAX_SERIAL_NUM */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] res;/* 保留 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SERIAL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_TRAN_CHAN_INFO[] struTranInfo;/*同时支持建立MAX_SERIAL_NUM个透明通道*/
        }

        //2007-12-24 Merry Christmas Eve...
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MATRIX_DEC_REMOTE_PLAY
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDVRIP;/* DVR IP地址 */
            public ushort wDVRPort;/* 端口号 */
            public byte byChannel;/* 通道号 */
            public byte byReserve;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* 用户名 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* 密码 */
            public uint dwPlayMode;/* 0－按文件 1－按时间*/
            public NET_DVR_TIME StartTime;
            public NET_DVR_TIME StopTime;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string sFileName;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_DEC_REMOTE_PLAY_CONTROL
        {
            public uint dwSize;
            public uint dwPlayCmd;/* 播放命令 见文件播放命令*/
            public uint dwCmdParam;/* 播放命令参数 */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_DEC_REMOTE_PLAY_STATUS
        {
            public uint dwSize;
            public uint dwCurMediaFileLen;/* 当前播放的媒体文件长度 */
            public uint dwCurMediaFilePosition;/* 当前播放文件的播放位置 */
            public uint dwCurMediaFileDuration;/* 当前播放文件的总时间 */
            public uint dwCurPlayTime;/* 当前已经播放的时间 */
            public uint dwCurMediaFIleFrames;/* 当前播放文件的总帧数 */
            public uint dwCurDataType;/* 当前传输的数据类型，19-文件头，20-流数据， 21-播放结束标志 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 72, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        //2009-4-11 added by likui 多路解码器new
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_PASSIVEMODE
        {
            public ushort wTransProtol;//传输协议，0-TCP, 1-UDP, 2-MCAST
            public ushort wPassivePort;//UDP端口, TCP时默认
            public NET_DVR_IPADDR struMcastIP;
              public byte byStreamType;/* 数据播放模式:REAL_TIME_STREAM(1)实时流,RECORD_STREAM(2)文件流 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }       

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_TRAN_CHAN_INFO_V30
        {
            public byte byTranChanEnable;/* 当前透明通道是否打开 0：关闭 1：打开 */
            /*
	         *	多路解码器本地有1个485串口，1个232串口都可以作为透明通道,设备号分配如下：
	         *	0 RS485
	         *	1 RS232 Console
	         */
            public byte byLocalSerialDevice;/* Local serial device */
            /*
	         *	远程串口输出还是两个,一个RS232，一个RS485
	         *	1表示232串口
	         *	2表示485串口
	         */
            public byte byRemoteSerialDevice;/* Remote output serial device */
            public byte byRes1;/* 保留 */
            public NET_DVR_IPADDR struRemoteDevIP;/* Remote Device IP */
            public ushort wRemoteDevPort;/* Remote Net Communication Port */
            public byte byIsEstablished;/* 透明通道建立成功标志，0-没有成功，1-建立成功 */
            public byte byRes2;/* 保留 */
            public TTY_CONFIG RemoteSerialDevCfg;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byUsername;/* 32BYTES */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPassword;/* 16BYTES */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_TRAN_CHAN_CONFIG_V30
        {
            public uint dwSize;
            public byte by232IsDualChan;/* 设置哪路232透明通道是全双工的 取值1到MAX_SERIAL_NUM */
            public byte by485IsDualChan;/* 设置哪路485透明通道是全双工的 取值1到MAX_SERIAL_NUM */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] vyRes;/* 保留 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SERIAL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_TRAN_CHAN_INFO[] struTranInfo;/*同时支持建立MAX_SERIAL_NUM个透明通道*/
        }        

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_CHAN_INFO_V30
        {
            public uint dwEnable;/* 是否启用 0－否 1－启用*/
            public NET_DVR_STREAM_MEDIA_SERVER_CFG streamMediaServerCfg;
            public NET_DVR_DEV_CHAN_INFO struDevChanInfo;/* 轮循解码通道信息 */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_LOOP_DECINFO_V30
        {
            public uint dwSize;
            public uint dwPoolTime;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CYCLE_CHAN_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_CHAN_INFO_V30[] struchanConInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MATRIX_DEC_CHAN_INFO_V30
        {
            public uint dwSize;
            public NET_DVR_STREAM_MEDIA_SERVER_CFG streamMediaServerCfg;/*流媒体服务器配置*/
            public NET_DVR_DEV_CHAN_INFO struDevChanInfo;/* 解码通道信息 */
            public uint dwDecState;/* 0-动态解码 1－循环解码 2－按时间回放 3－按文件回放 */
            public NET_DVR_TIME StartTime;/* 按时间回放开始时间 */
            public NET_DVR_TIME StopTime;/* 按时间回放停止时间 */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string sFileName;/* 按文件回放文件名 */
            public uint dwGetStreamMode;/*取流模式:1-主动，2-被动*/
            public NET_DVR_MATRIX_PASSIVEMODE struPassiveMode;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*流媒体服务器基本配置*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_STREAM_MEDIA_SERVER
        {
            public byte byValid;/*是否启用流媒体服务器取流,0表示无效，非0表示有效*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_DOMAIN_NAME)]
            public string byAddress;/* 设备IP地址或者域名 */
            public ushort wDevPort;/*流媒体服务器端口*/
            public byte byTransmitType;/*传输协议类型 0-TCP，1-UDP*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //设备通道信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEV_CHAN_INFO_EX
        {
            public byte byChanType;		        //通道类型：0-普通通道，1-零通道，2-流ID，3-本地输入源
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = STREAM_ID_LEN)]
            public string byStreamId;/* 流ID，通道类型 byChanType 为 2 时有效 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwChannel;//通道类型 byChanType为 0、1、3 时有效（如果通道类型为本地输入源，该参数值表示本地输入源索引）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_DOMAIN_NAME)]
            public string byAddress;/* 设备IP地址或者域名 */
            public ushort wDVRPort;			 	//端口号
            public byte byChannel;				//该参数无效，通道号见dwChannel 
            public byte byTransProtocol;		//传输协议类型0-TCP，1-UDP
            public byte byTransMode;			//传输码流模式 0－主码流 1－子码流
            public byte byFactoryType;			/*前端设备厂家类型,通过接口获取*/
            public byte byDeviceType; //设备类型(视频综合平台智能板使用)，1-解码器（此时根据视频综合平台能力集中byVcaSupportChanMode字段来决定是使用解码通道还是显示通道），2-编码器
            public byte byDispChan;//显示通道号,智能配置使用
            public byte bySubDispChan;//显示通道子通道号，智能配置时使用
            public byte byResolution;	//; 1-CIF 2-4CIF 3-720P 4-1080P 5-500w大屏控制器使用，大屏控制器会根据该参数分配解码资源
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = NAME_LEN)]
            public string sUserName;  	        //监控主机登陆帐号
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PASSWD_LEN)]
            public string sPassword;  	        //监控主机密码
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_DEC_STREAM_DEV_EX
        {
            public NET_DVR_STREAM_MEDIA_SERVER struStreamMediaSvrCfg;/*流媒体服务器配置*/
            public NET_DVR_DEV_CHAN_INFO_EX struDevChanInfo;/* 解码通道信息 */
        }

        //动态域名参数配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEV_DDNS_INFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_DOMAIN_NAME)]
            public string byDevAddress;         //设备域名(IPServer或hiDDNS时可填设备序列号或者别名) 
            public byte byTransProtocol;		//传输协议类型：0- TCP，1- UDP，2- 多播
            public byte byTransMode;			//传输码流模式 0－主码流 1－子码流
            public byte byDdnsType;			    //域名服务器类型：0- IPServer，1- Dyndns，2- PeanutHull(花生壳)，3- NO-IP，4- hiDDNS
            public byte byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_DOMAIN_NAME)]
            public string byDdnsAddress;        //DDNS服务器地址
            public ushort wDdnsPort;			//DDNS服务器端口号
            public byte byChanType;		        //通道类型：0-普通通道，1-零通道，2-流ID
            public byte byFactoryType;			//前端设备厂家类型,通过接口NET_DVR_GetIPCProtoList获取
            public uint dwChannel;				//通道号
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = STREAM_ID_LEN)]
            public string byStreamId;           // 流ID，通道类型 byChanType 为 2 时有效
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = NAME_LEN)]
            public string sUserName;  	        //监控主机登陆帐号
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PASSWD_LEN)]
            public string sPassword;  	        //监控主机密码
            public ushort wDevPort;			 	//设备端口号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //动态域名取流配置
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_DEC_DDNS_DEV
        {
            public NET_DVR_DEV_DDNS_INFO struDdnsInfo;/*流媒体服务器配置*/
            public NET_DVR_STREAM_MEDIA_SERVER struMediaServer;/* 解码通道信息 */
        }

        //取流模式配置联合体
        [StructLayout(LayoutKind.Explicit)]
        public struct NET_DVR_DEC_STREAM_MODE
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 300, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //联合体大小
            public void Init()
            {
                byRes = new byte[300];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MATRIX_DEC_CHAN_INFO_V41
        {
            public uint dwSize;
            public byte byStreamMode;/*取流模式：0- 无效，1- 通过IP或域名取流，2- 通过URL取流，3- 通过动态域名解析向设备取流*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_DEC_STREAM_MODE uDecStreamMode;/*取流信息*/
            public uint dwPlayMode;/*解码状态：0-动态解码，1－循环解码，2－按时间回放，3－按文件回放*/
            public NET_DVR_TIME StartTime;/* 按时间回放开始时间 */
            public NET_DVR_TIME StopTime;/* 按时间回放停止时间 */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string sFileName;/* 按文件回放文件名 */
            public uint dwGetStreamMode;/*取流模式:1-主动，2-被动*/
            public NET_DVR_MATRIX_PASSIVEMODE struPassiveMode;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        public const int MAX_RESOLUTIONNUM = 64; //支持的最大分辨率数目

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_ABILITY
        {
            public uint dwSize;
            public byte byDecNums;
            public byte byStartChan;
            public byte byVGANums;
            public byte byBNCNums;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8*12, ArraySubType = UnmanagedType.I1)]
            public byte[] byVGAWindowMode;/*VGA支持的窗口模式*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byBNCWindowMode;/*BNC支持的窗口模式*/
            public byte byDspNums;   
            public byte byHDMINums;//HDMI显示通道个数（从25开始）
            public byte byDVINums;//DVI显示通道个数（从29开始）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 13, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RESOLUTIONNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] bySupportResolution;//按照上面的枚举定义,一个字节代表一个分辨率是//否支持，1：支持，0：不支持
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4*8, ArraySubType = UnmanagedType.I1)]
            public byte[] byHDMIWindowMode;//HDMI支持的窗口模式
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4*8, ArraySubType = UnmanagedType.I1)]
            public byte[] byDVIWindowMode;//DVI支持的窗口模式
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //上传logo结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISP_LOGOCFG
        {
            public uint dwCorordinateX;//图片显示区域X坐标
            public uint dwCorordinateY;//图片显示区域Y坐标
            public ushort wPicWidth; //图片宽
            public ushort wPicHeight; //图片高
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byFlash;//是否闪烁1-闪烁，0-不闪烁
            public byte byTranslucent;//是否半透明1-半透明，0-不半透明
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;//保留
            public uint dwLogoSize;//LOGO大小，包括BMP的文件头
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PICTURECFG
        {
            public uint dwSize;        //大小
            public byte byUseType;    //1-底图，2-GIF图片，3-CAD图片 4-输出口图片
            public byte bySequence;//序号  
            public byte byOverlayEnabled; //图片叠加使能，是否在上传图片包含图片叠加参数 1-包含叠加参数，0-不包含
            public byte byRes;
            public NET_DVR_BASEMAP_CFG struBasemapCfg;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPicName;//图片名称
            public uint dwVideoWall;       //墙号（1字节墙号+1字节通道输出+2字节窗口号）
            public byte byFlash; //图片闪烁使能，1-闪烁，0-不闪烁
            public byte byTranslucent; //图片半透明使能，1-半透明，0-不半透明
            public byte byShowEnabled; //图片显示使能，1-显示，0-隐藏
            public byte byPictureType; //图片类型，1-bmp，2-jpg，3-png，……
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OUTPUT_PIC_CFG
        {
            public uint dwSize;
            public uint dwOutputPicNo;  //图片序号
            public byte byEnable; //logo是否显示，1-显示，0-隐藏
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;    
            public NET_DVR_RECTCFG_EX struRect;//logo位置，输出口范围总大小为1920*1920
            public byte byFlash;  //是否闪烁1-闪烁，0-不闪烁
            public byte byTranslucent; //是否半透明1-半透明，0-不半透明
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                //保留
            public uint dwOutputPicWinNo; //输出口图片窗口号（1字节设备号+1字节输出口号+2字节输出口图片窗口号）,获取全部时有效
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 28, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }

        public const int MAX_OSD_LEN =  64;  //输出口OSD长度
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OUTPUT_OSD_CFG
        {
            public uint dwSize;
            public byte byEnable; //OSD是否显示，0-不显示，1-显示
            public byte byFontSize; //字体大小，1-大，2-中，3-小
            public byte byOSDColor; //OSD颜色配置，0-默认， 1-黑，2-白，3-红，4-绿，5-蓝
            public byte byRes1;    
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_OSD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byOsdContent; //OSD内容
            public NET_DVR_RECTCFG_EX struRect;//OSD位置，输出口范围总大小为1920*1920
            public uint dwOsdWinNo; //输出口OSD窗口号（1字节设备号+1字节输出口号+2字节OSD窗口号），获取所有时有效
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                //保留
        }

        /*编码类型*/
        public const int NET_DVR_ENCODER_UNKOWN = 0;/*未知编码格式*/
        public const int NET_DVR_ENCODER_H264 = 1;/*HIK 264*/
        public const int NET_DVR_ENCODER_S264 = 2;/*Standard H264*/
        public const int NET_DVR_ENCODER_MPEG4 = 3;/*MPEG4*/
        public const int NET_DVR_ORIGINALSTREAM = 4;/*Original Stream*/
        public const int NET_DVR_PICTURE = 5;//*Picture*/
        public const int NET_DVR_ENCODER_MJPEG = 6;
        public const int NET_DVR_ECONDER_MPEG2 = 7;
        /* 打包格式 */
        public const int NET_DVR_STREAM_TYPE_UNKOWN = 0;/*未知打包格式*/
        public const int NET_DVR_STREAM_TYPE_HIKPRIVT = 1; /*海康自定义打包格式*/
        public const int NET_DVR_STREAM_TYPE_TS = 7;/* TS打包 */
        public const int NET_DVR_STREAM_TYPE_PS = 8;/* PS打包 */
        public const int NET_DVR_STREAM_TYPE_RTP = 9;/* RTP打包 */

        /*解码通道状态*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_CHAN_STATUS
        {
            public byte byDecodeStatus;/*当前状态:0:未启动，1：启动解码*/
            public byte byStreamType;/*码流类型*/
            public byte byPacketType;/*打包方式*/
            public byte byRecvBufUsage;/*接收缓冲使用率*/
            public byte byDecBufUsage;/*解码缓冲使用率*/
            public byte byFpsDecV;/*视频解码帧率*/
            public byte byFpsDecA;/*音频解码帧率*/
            public byte byCpuLoad;/*DSP CPU使用率*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwDecodedV;/*解码的视频帧*/
            public uint dwDecodedA;/*解码的音频帧*/
            public ushort wImgW;/*解码器当前的图像大小,宽*/
            public ushort wImgH; //高
            public byte byVideoFormat;/*视频制式:0-NON,NTSC--1,PAL--2*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public uint dwDecChan; /*获取全部解码通道状态时有效，设置时可填0*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }

        /*显示通道状态*/
        public const int NET_DVR_MAX_DISPREGION = 16;         /*每个显示通道最多可以显示的窗口*/
        //VGA分辨率，目前能用的是：VGA_THS8200_MODE_XGA_60HZ、VGA_THS8200_MODE_SXGA_60HZ、
        //
        public enum VGA_MODE
        {
            /*VGA*/
            VGA_NOT_AVALIABLE,
            VGA_THS8200_MODE_SVGA_60HZ,    //(800*600)
            VGA_THS8200_MODE_SVGA_75HZ,    //(800*600)
            VGA_THS8200_MODE_XGA_60HZ,     //(1024*768)
            VGA_THS8200_MODE_XGA_75HZ,     //(1024*768)
            VGA_THS8200_MODE_SXGA_60HZ,    //(1280*1024)
            VGA_THS8200_MODE_720P_60HZ,    //(1280*720)
            VGA_THS8200_MODE_1080I_60HZ,   //(1920*1080)
            VGA_THS8200_MODE_1080P_30HZ,   //(1920*1080)
            VGA_THS8200_MODE_UXGA_30HZ,    //(1600*1200)
            /*HDMI*/
            HDMI_SII9134_MODE_XGA_60HZ,	   //(1024*768)
            HDMI_SII9134_MODE_SXGA_60HZ,   //(1280*1024)
            HDMI_SII9134_MODE_SXGA2_60HZ,  //(1280*960)
            HDMI_SII9134_MODE_720P_60HZ,   //(1280*720)	
            HDMI_SII9134_MODE_720P_50HZ,   //(1280*720)		
            HDMI_SII9134_MODE_1080I_60HZ,  //(1920*1080)
            HDMI_SII9134_MODE_1080I_50HZ,  //(1920*1080)	
            HDMI_SII9134_MODE_1080P_25HZ,  //(1920*1080)
            HDMI_SII9134_MODE_1080P_30HZ,  //(1920*1080)
            HDMI_SII9134_MODE_1080P_50HZ,  //(1920*1080)
            HDMI_SII9134_MODE_1080P_60HZ,  //(1920*1080)
            HDMI_SII9134_MODE_UXGA_60HZ,   //(1600*1200)
            /*DVI*/
            DVI_SII9134_MODE_XGA_60HZ,	   //(1024*768)
            DVI_SII9134_MODE_SXGA_60HZ,	   //(1280*1024)
            DVI_SII9134_MODE_SXGA2_60HZ,   //(1280*960)
            DVI_SII9134_MODE_720P_60HZ,	   //(1280*720)	
            DVI_SII9134_MODE_720P_50HZ,    //(1280*720)		
            DVI_SII9134_MODE_1080I_60HZ,   //(1920*1080)
            DVI_SII9134_MODE_1080I_50HZ,   //(1920*1080)
            DVI_SII9134_MODE_1080P_25HZ,   //(1920*1080)
            DVI_SII9134_MODE_1080P_30HZ,   //(1920*1080)
            DVI_SII9134_MODE_1080P_50HZ,   //(1920*1080)
            DVI_SII9134_MODE_1080P_60HZ,   //(1920*1080)
            DVI_SII9134_MODE_UXGA_60HZ,     //(1600*1200)
            VGA_DECSVR_MODE_SXGA2_60HZ,
            HDMI_DECSVR_MODE_1080P_24HZ,
            DVI_DECSVR_MODE_1080P_24HZ,
            YPbPr_DECSVR_MODE_720P_60HZ,
            YPbPr_DECSVR_MODE_1080I_60HZ
        }

        //低帧率定义
        public const int LOW_DEC_FPS_1_2 = 51;
        public const int LOW_DEC_FPS_1_4 = 52;
        public const int LOW_DEC_FPS_1_8 = 53;
        public const int LOW_DEC_FPS_1_16 = 54;

        /*视频制式标准*/
        public enum VIDEO_STANDARD
        {
            VS_NON = 0,
            VS_NTSC = 1,
            VS_PAL = 2,
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct UNION_VIDEOPLATFORM
        {
            /*各个子窗口对应解码通道所对应的解码子系统的槽位号(对于视频综合平台中解码子系统有效)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecoderId;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct UNION_NOTVIDEOPLATFORM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VGA_DISP_CHAN_CFG
        {
            public uint dwSize;
            public byte byAudio;/*音频是否开启,0-否，1-是*/
            public byte byAudioWindowIdx;/*音频开启子窗口*/
            public byte byVgaResolution;/*VGA的分辨率*/
            public byte byVedioFormat;/*视频制式，1:NTSC,2:PAL,0-NON*/
            public uint dwWindowMode;/*画面模式，从能力集里获取，目前支持1,2,4,9,16*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecChan;/*各个子窗口关联的解码通道*/
            public byte byEnlargeStatus;          /*是否处于放大状态，0：不放大，1：放大*/
            public byte byEnlargeSubWindowIndex;//放大的子窗口号
	        [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct struDiff
            {
                [FieldOffsetAttribute(0)]
                [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
                 public byte[] byRes;
            }
            public byte byUnionType;/*区分共用体，0-视频综合平台内部解码器显示通道配置，1-其他解码器显示通道配置*/
            public byte byScale; /*显示模式，0---真实显示，1---缩放显示( 针对BNC )*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISP_CHAN_STATUS
        {
            public byte byDispStatus;/*显示状态：0：未显示，1：启动显示*/
            public byte byBVGA; /*VGA/BNC*/
            public byte byVideoFormat;/*视频制式:1:NTSC,2:PAL,0-NON*/
            public byte byWindowMode;/*当前画面模式*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecChan;/*各个子窗口关联的解码通道*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NET_DVR_MAX_DISPREGION, ArraySubType = UnmanagedType.I1)]
            public byte[] byFpsDisp;/*每个子画面的显示帧率*/
            public byte byScreenMode;			//屏幕模式0-普通 1-大屏
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 31, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        public const int MAX_DECODECHANNUM = 32;//多路解码器最大解码通道数
        public const int MAX_DISPCHANNUM = 24;//多路解码器最大显示通道数

        /*解码器设备状态*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODER_WORK_STATUS
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DECODECHANNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_CHAN_STATUS[] struDecChanStatus;/*解码通道状态*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISPCHANNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DISP_CHAN_STATUS[] struDispChanStatus;/*显示通道状态*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_ALARMIN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmInStatus;/*报警输入状态*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_ALARMOUT, ArraySubType = UnmanagedType.I1)]
            public byte[] byAalarmOutStatus;/*报警输出状态*/
            public byte byAudioInChanStatus;/*语音对讲状态*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 127, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //2009-12-1 增加被动解码播放控制
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PASSIVEDECODE_CONTROL
        {
            public uint dwSize;
            public uint dwPlayCmd;		/* 播放命令 见文件播放命令*/
            public uint dwCmdParam;		/* 播放命令参数 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//Reverse
        }

        public const int PASSIVE_DEC_PAUSE = 1;	/*被动解码暂停(仅文件流有效)*/
        public const int PASSIVE_DEC_RESUME = 2;	/*恢复被动解码(仅文件流有效)*/
        public const int PASSIVE_DEC_FAST = 3;   /*快速被动解码(仅文件流有效)*/
        public const int PASSIVE_DEC_SLOW = 4;   /*慢速被动解码(仅文件流有效)*/
        public const int PASSIVE_DEC_NORMAL = 5;   /*正常被动解码(仅文件流有效)*/
        public const int PASSIVE_DEC_ONEBYONE =	6;  /*被动解码单帧播放(保留)*/
        public const int PASSIVE_DEC_AUDIO_ON = 7;   /*音频开启*/
        public const int PASSIVE_DEC_AUDIO_OFF = 8; 	 /*音频关闭*/
        public const int PASSIVE_DEC_RESETBUFFER = 9;    /*清空缓冲区*/

        //2009-12-16 增加控制解码器解码通道缩放
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_DECCHAN_CONTROL
        {        
            public uint dwSize;
            public byte byDecChanScaleStatus;/*解码通道显示缩放控制,1表示缩放显示，0表示真实显示*/
            public byte byDecodeDelay;//解码延时，0-默认，1-实时性好，2-实时性较好，3-实时性中，流畅性中，4-流畅性较好，5-流畅性好，0xff-自动调整   
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 66, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;	
        }
        /************************************多路解码器(end)***************************************/

        /************************************视频综合平台(begin)***************************************/
        public const int MAX_SUBSYSTEM_NUM = 80;   //一个矩阵系统中最多子系统数量
        public const int MAX_SUBSYSTEM_NUM_V40 = 120;   //一个矩阵系统中最多子系统数量
        public const int MAX_SERIALLEN = 36;  //最大序列号长度
        public const int MAX_LOOPPLANNUM = 16;  //最大计划切换组
        public const int DECODE_TIMESEGMENT = 4;     //计划解码每天时间段数

        public const int MAX_DOMAIN_NAME = 64;  /* 最大域名长度 */
        public const int MAX_DISKNUM_V30 = 33; //9000设备最大硬盘数/* 最多33个硬盘(包括16个内置SATA硬盘、1个eSATA硬盘和16个NFS盘) */
        public const int MAX_DAYS = 7;       //每周天数
        public const int MAX_DISPNUM_V41 = 32;
        public const int MAX_WINDOWS_NUM = 12;
        public const int MAX_VOUTNUM = 32;
        public const int MAX_SUPPORT_RES = 32;
        public const int MAX_BIGSCREENNUM = 100;

        public const int VIDEOPLATFORM_ABILITY = 0x210; //视频综合平台能力集
        public const int MATRIXDECODER_ABILITY_V41 = 0x260; //解码器能力集      

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SUBSYSTEMINFO
        {
            public byte bySubSystemType;//子系统类型，1-解码用子系统，2-编码用子系统，0-NULL（此参数只能获取）
            public byte byChan;//子系统通道数（此参数只能获取）
            public byte byLoginType;//注册类型，1-直连，2-DNS，3-花生壳
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_IPADDR struSubSystemIP;/*IP地址（可修改）*/
            public ushort wSubSystemPort;//子系统端口号（可修改）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public NET_DVR_IPADDR struSubSystemIPMask;//子网掩码
            public NET_DVR_IPADDR struGatewayIpAddr;	/* 网关地址*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* 用户名 （此参数只能获取）*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/*密码（此参数只能获取）*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_DOMAIN_NAME)]
            public string sDomainName;//域名(可修改)
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_DOMAIN_NAME)]
            public string sDnsAddress;/*DNS域名或IP地址*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;//序列号（此参数只能获取）
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALLSUBSYSTEMINFO
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SUBSYSTEM_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SUBSYSTEMINFO[] struSubSystemInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LOOPPLAN_SUBCFG
        {
            public uint dwSize;
            public uint dwPoolTime; /*轮询间隔，单位：秒*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CYCLE_CHAN_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_CHAN_INFO_V30[] struChanConInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]            
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMMODECFG
        {
            public uint dwSize;
            public byte byAlarmMode;//报警触发类型，1-轮询，2-保持 
            public ushort wLoopTime;//轮询时间, 单位：秒 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)] 
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CODESPLITTERINFO
        {
            public uint dwSize;
            public NET_DVR_IPADDR struIP;/*码分器IP地址*/
            public ushort wPort;//码分器端口号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]             
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)] 
            public byte[] sUserName;/* 用户名 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)] 
            public byte[] sPassword;/*密码 */
            public byte byChan;//码分器485号
            public byte by485Port;//485口地址      
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ASSOCIATECFG
        {
            public byte byAssociateType;//关联类型，1-报警
            public ushort wAlarmDelay;//报警延时，0－5秒；1－10秒；2－30秒；3－1分钟；4－2分钟；5－5分钟；6－10分钟；
            public byte byAlarmNum;//报警号，具体的值由应用赋，相同的报警赋相同的值
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)] 
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DYNAMICDECODE
        {
            public uint dwSize;
            public NET_DVR_ASSOCIATECFG struAssociateCfg;//触发动态解码关联结构
            public NET_DVR_PU_STREAM_CFG struPuStreamCfg;//动态解码结构
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)] 
            public byte[] byRes;
        }
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODESCHED
        {
            public NET_DVR_SCHEDTIME struSchedTime;
            public byte byDecodeType;/*0-无，1-轮询解码，2-动态解码*/
            public byte byLoopGroup;//轮询组号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)] 
            public byte[] byRes;
            public NET_DVR_PU_STREAM_CFG struDynamicDec;//动态解码
        }
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLANDECODE
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * DECODE_TIMESEGMENT, ArraySubType = UnmanagedType.I1)] 
            public NET_DVR_DECODESCHED[] struDecodeSched;//周一作为开始，和9000一致
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)] 
            public byte[] byres;
        }
        /************************************视频综合平台(end)***************************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEOPLATFORM_ABILITY
        {
            public uint dwSize;
            public byte byCodeSubSystemNums;//编码子系统数量
            public byte byDecodeSubSystemNums;//解码子系统数量
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I1)]
            public byte[] byWindowMode; /*显示通道支持的窗口模式*/
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I1)]
            public byte[] byRes;
        }

        

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SUBSYSTEM_ABILITY
        {
            /*子系统类型，1-解码用子系统，2-编码用子系统，3-级联输出子系统，4-级联输入子系统，5-码分器子系统，6-报警主机子系统，7-智能子系统，8-V6解码子系统，9-V6子系统，0-NULL（此参数只能获取）*/
            public byte bySubSystemType;
            public byte byChanNum;//子系统通道数
            public byte byStartChan;//子系统起始通道数
            public byte bySlotNum;//槽位号 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public struDecoderSystemAbility _struAbility;
        }
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct struDecoderSystemAbility
        {
            public byte byVGANums;//VGA显示通道个数（从1开始）
            public byte byBNCNums;//BNC显示通道个数（从9开始）
            public byte byHDMINums;//HDMI显示通道个数（从25开始）
            public byte byDVINums;//DVI显示通道个数（从29开始）

            public byte byLayerNums;//大屏拼接中，做主屏时所支持图层数
            public byte bySpartan;//畅显功能，0-不支持，1-支持
            public byte byDecType; //解码子系统类型，0-普通型,1-增强型(普通型分屏时前4窗口需使用自身资源，增强型无此限制，增强型最多可被其他子系统借16路D1解码资源
            //增强型被大屏关联为子屏后资源可被借用，普通型则不能被借用)
            public byte byOutputSwitch;//是否支持HDMI/DVI互相切换，0-不支持，1-支持
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 39, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byDecoderType; //解码板类型  0-普通解码板 1-万能解码板
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 152, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct struAbility
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 200, ArraySubType = UnmanagedType.I1)]
            //  [FieldOffsetAttribute(0)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEOPLATFORM_ABILITY_V40
        {
            public uint dwSize;
            public byte byCodeSubSystemNums;
            public byte byDecodeSubSystemNums;//解码子系统数量
            public byte bySupportNat;//是否支持NAT，0-不支持，1-支持
            public byte byInputSubSystemNums;//级联输入子系统数量
            public byte byOutputSubSystemNums;//级联输出子系统数量
            public byte byCodeSpitterSubSystemNums;//码分子系统数量
            public byte byAlarmHostSubSystemNums;//报警子系统数量
            public byte bySupportBigScreenNum;//所支持最多组成大屏的个数
            public byte byVCASubSystemNums;//智能子系统数量
            public byte byV6SubSystemNums;//V6子系统数量
            public byte byV6DecoderSubSystemNums;//V6解码子系统数量
            public byte bySupportBigScreenX;/*大屏拼接的模式：m×n*/
            public byte bySupportBigScreenY;
            public byte bySupportSceneNums;//支持场景模式的个数
            public byte byVcaSupportChanMode;//智能支持的通道使用模式，0-使用解码通道，1-使用显示通道及子通道号
            public byte bySupportScreenNums;//所支持的大屏的屏幕最大个数
            public byte bySupportLayerNums;//所支持的图层数，0xff-无效
            public byte byNotSupportPreview;//是否支持预览,1-不支持，0-支持
            public byte byNotSupportStorage;//是否支持存储,1-不支持，0-支持
            public byte byUploadLogoMode;//上传logo模式，0-上传给解码通道，1-上传给显示通道
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SUBSYSTEM_NUM_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SUBSYSTEM_ABILITY[] struSubSystemAbility;
            public byte by485Nums;//485串口个数
            public byte by232Nums;//232串口个数
            public byte bySerieStartChan;//起始通道
            public byte byScreenMode;//大屏模式，0-主屏由客户端分配，1-主屏由设备端分配
            public byte byDevVersion;//设备版本，0-B10/B11/B12，1-B20
            public byte bySupportBaseMapNums;//所支持的底图数，底图号从1开始
            public ushort wBaseLengthX;//每个屏大小的基准值，B20使用
            public ushort wBaseLengthY;
            public byte bySupportPictureTrans;  //是否支持图片回显，0-不支持，1-支持	
            public byte bySupportPreAllocDec;   //是否支持智能解码资源预分配，0-不支持，1-支持
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 628, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }       

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SINGLESCREENCFG
        {
            public byte byScreenSeq;//屏幕序号，0xff表示不用此屏,64-T解码器第一个表示主屏
            public byte bySubSystemNum;//解码子系统槽位号,解码器此值没有用
            public byte byDispNum;//解码子系统上对应显示通道号，64-T解码器中该值表示解码器的显示通道号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BIGSCREENCFG
        {
            public uint dwSize;
            public byte byEnable;//大屏拼接使能，0-不使能，1-使能
            public byte byModeX;/*大屏拼接模式*/
            public byte byModeY;
            public byte byMainDecodeSystem;//综合平台的解码板中该值表示主屏槽位号，64-T解码器中该值表示解码通道号
            public byte byMainDecoderDispChan;//主屏所用显示通道号，1.1netra版本新增，netra解码器有两个显示通道，都能够作为主屏。64-T中该值无效
            public byte byVideoStandard;      //大屏每个子屏制式相同 1:NTSC,2:PAL
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwResolution;         //大屏每个子屏分辨率相同
            //大屏拼接从屏幕信息
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_BIGSCREENNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SINGLESCREENCFG[] struFollowSingleScreen;
            //起始坐标必须为基准坐标的整数倍
            public ushort wBigScreenX; //大屏在电视墙中起始X坐标
            public ushort wBigScreenY; //大屏在电视墙中起始Y坐标
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;

            public void Init()
            {
                byRes1 = new byte[2];
                struFollowSingleScreen = new NET_DVR_SINGLESCREENCFG[MAX_BIGSCREENNUM];
                byRes2 = new byte[12];
            }
        }       

        /************************************视频综合平台(end)***************************************/
        
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_EMAILCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sUserName;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sPassWord;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sFromName;/* Sender *///字符串中的第一个字符和最后一个字符不能是"@",并且字符串中要有"@"字符
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 48)]
            public string sFromAddr;/* Sender address */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sToName1;/* Receiver1 */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sToName2;/* Receiver2 */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 48)]
            public string sToAddr1;/* Receiver address1 */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 48)]
            public string sToAddr2;/* Receiver address2 */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sEmailServer;/* Email server address */
            public byte byServerType;/* Email server type: 0-SMTP, 1-POP, 2-IMTP…*/
            public byte byUseAuthen;/* Email server authentication method: 1-enable, 0-disable */
            public byte byAttachment;/* enable attachment */
            public byte byMailinterval;/* mail interval 0-2s, 1-3s, 2-4s. 3-5s*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSIONCFG_NEW
        {
            public uint dwSize;
            public NET_DVR_COMPRESSION_INFO_EX struLowCompression;//定时录像
            public NET_DVR_COMPRESSION_INFO_EX struEventCompression;//事件触发录像
        }

        //云台预置点信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PRESET_NAME
        {
            public uint dwSize;
            public ushort wPresetNum;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byName;
            public ushort wPanPos;
            public ushort wTiltPos;
            public ushort wZoomPos;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 58, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //预置位信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PRESET_INFO
        {
            public uint dwSize; //结构体大小
            public uint dwPresetNum;  //预置点个数
            public uint dwGroupNum;  //组数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //保留
        }

        //球机位置信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PTZPOS
        {
            public ushort wAction;//获取时该字段无效
            public ushort wPanPos;//水平参数
            public ushort wTiltPos;//垂直参数
            public ushort wZoomPos;//变倍参数
        }

        //球机范围信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PTZSCOPE
        {
            public ushort wPanPosMin;//水平参数min
            public ushort wPanPosMax;//水平参数max
            public ushort wTiltPosMin;//垂直参数min
            public ushort wTiltPosMax;//垂直参数max
            public ushort wZoomPosMin;//变倍参数min
            public ushort wZoomPosMax;//变倍参数max
        }

        //rtsp配置 ipcamera专用
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RTSPCFG
        {
            public uint dwSize;//长度
            public ushort wPort;//rtsp服务器侦听端口
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 54, ArraySubType = UnmanagedType.I1)]
            public byte[] byReserve;//预留
        }

        /********************************接口参数结构(begin)*********************************/

        //NET_DVR_Login()参数结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEVICEINFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;//序列号
            public byte byAlarmInPortNum;//DVR报警输入个数
            public byte byAlarmOutPortNum;//DVR报警输出个数
            public byte byDiskNum;//DVR硬盘个数
            public byte byDVRType;//DVR类型, 1:DVR 2:ATM DVR 3:DVS ......
            public byte byChanNum;//DVR 通道个数
            public byte byStartChan;//起始通道号,例如DVS-1,DVR - 1
        }

        //NET_DVR_Login_V30()参数结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEVICEINFO_V30
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;  //序列号
            public byte byAlarmInPortNum;		        //报警输入个数
            public byte byAlarmOutPortNum;		        //报警输出个数
            public byte byDiskNum;				    //硬盘个数
            public byte byDVRType;				    //设备类型, 1:DVR 2:ATM DVR 3:DVS ......
            public byte byChanNum;				    //模拟通道个数
            public byte byStartChan;			        //起始通道号,例如DVS-1,DVR - 1
            public byte byAudioChanNum;                //语音通道数
            public byte byIPChanNum;					//最大数字通道个数，低位  
            public byte byZeroChanNum;			//零通道编码个数 //2010-01-16
            public byte byMainProto;			//主码流传输协议类型 0-private, 1-rtsp,2-同时支持private和rtsp
            public byte bySubProto;				//子码流传输协议类型0-private, 1-rtsp,2-同时支持private和rtsp
            public byte bySupport;        //能力，位与结果为0表示不支持，1表示支持，
            //bySupport & 0x1, 表示是否支持智能搜索
            //bySupport & 0x2, 表示是否支持备份
            //bySupport & 0x4, 表示是否支持压缩参数能力获取
            //bySupport & 0x8, 表示是否支持多网卡
            //bySupport & 0x10, 表示支持远程SADP
            //bySupport & 0x20, 表示支持Raid卡功能
            //bySupport & 0x40, 表示支持IPSAN 目录查找
	        //bySupport & 0x80, 表示支持rtp over rtsp
            public byte bySupport1;        // 能力集扩充，位与结果为0表示不支持，1表示支持
	        //bySupport1 & 0x1, 表示是否支持snmp v30
	        //bySupport1 & 0x2, 支持区分回放和下载
	        //bySupport1 & 0x4, 是否支持布防优先级	
	        //bySupport1 & 0x8, 智能设备是否支持布防时间段扩展
	        //bySupport1 & 0x10, 表示是否支持多磁盘数（超过33个）
	        //bySupport1 & 0x20, 表示是否支持rtsp over http	
	        //bySupport1 & 0x80, 表示是否支持车牌新报警信息2012-9-28, 且还表示是否支持NET_DVR_IPPARACFG_V40结构体
            public byte bySupport2; /*能力，位与结果为0表示不支持，非0表示支持							
							bySupport2 & 0x1, 表示解码器是否支持通过URL取流解码
							bySupport2 & 0x2,  表示支持FTPV40
							bySupport2 & 0x4,  表示支持ANR
							bySupport2 & 0x8,  表示支持CCD的通道参数配置
							bySupport2 & 0x10,  表示支持布防报警回传信息（仅支持抓拍机报警 新老报警结构）
							bySupport2 & 0x20,  表示是否支持单独获取设备状态子项
							bySupport2 & 0x40,  表示是否是码流加密设备*/
            public ushort wDevType;              //设备型号
            public byte bySupport3; //能力集扩展，位与结果为0表示不支持，1表示支持
							//bySupport3 & 0x1, 表示是否多码流
							// bySupport3 & 0x4 表示支持按组配置， 具体包含 通道图像参数、报警输入参数、IP报警输入、输出接入参数、
                            // 用户参数、设备工作状态、JPEG抓图、定时和时间抓图、硬盘盘组管理 
							//bySupport3 & 0x8为1 表示支持使用TCP预览、UDP预览、多播预览中的"延时预览"字段来请求延时预览（后续都将使用这种方式请求延时预览）。而当bySupport3 & 0x8为0时，将使用 "私有延时预览"协议。
							//bySupport3 & 0x10 表示支持"获取报警主机主要状态（V40）"。
							//bySupport3 & 0x20 表示是否支持通过DDNS域名解析取流

            public byte byMultiStreamProto;//是否支持多码流,按位表示,0-不支持,1-支持,bit1-码流3,bit2-码流4,bit7-主码流，bit-8子码流
            public byte byStartDChan;		//起始数字通道号,0表示无效
            public byte byStartDTalkChan;	//起始数字对讲通道号，区别于模拟对讲通道号，0表示无效
            public byte byHighDChanNum;		//数字通道个数，高位
            public byte bySupport4;
            public byte byLanguageType;// 支持语种能力,按位表示,每一位0-不支持,1-支持  
						//  byLanguageType 等于0 表示 老设备
						//  byLanguageType & 0x1表示支持中文
						//  byLanguageType & 0x2表示支持英文
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;		//保留
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct NET_DVR_DEVICEINFO_V40
        {
            public NET_DVR_DEVICEINFO_V30 struDeviceV30;
            public byte bySupportLock;        //设备支持锁定功能，该字段由SDK根据设备返回值来赋值的。bySupportLock为1时，dwSurplusLockTime和byRetryLoginTime有效
            public byte byRetryLoginTime;	    //剩余可尝试登陆的次数，用户名，密码错误时，此参数有效
            public byte byPasswordLevel;      //admin密码安全等级0-无效，1-默认密码，2-有效密码,3-风险较高的密码。当用户的密码为出厂默认密码（12345）或者风险较高的密码时，上层客户端需要提示用户更改密码。      
            public byte byProxyType;//代理类型，0-不使用代理, 1-使用socks5代理, 2-使用EHome代理
            public uint dwSurplusLockTime;	//剩余时间，单位秒，用户锁定时，此参数有效
            public byte byCharEncodeType;     //字符编码类型（SDK所有接口返回的字符串编码类型，透传接口除外）：0- 无字符编码信息(老设备)，1- GB2312(简体中文)，2- GBK，3- BIG5(繁体中文)，4- Shift_JIS(日文)，5- EUC-KR(韩文)，6- UTF-8，7- ISO8859-1，8- ISO8859-2，9- ISO8859-3，…，依次类推，21- ISO8859-15(西欧) 
            public byte bySupportDev5;//支持v50版本的设备参数获取，设备名称和设备类型名称长度扩展为64字节
            public byte bySupport;  //能力集扩展，位与结果：0- 不支持，1- 支持
            // bySupport & 0x1:  保留
            // bySupport & 0x2:  0-不支持变化上报 1-支持变化上报
            public byte byLoginMode; //登录模式 0-Private登录 1-ISAPI登录
            public int dwOEMCode;
            public int iResidualValidity;   //该用户密码剩余有效天数，单位：天，返回负值，表示密码已经超期使用，例如“-3表示密码已经超期使用3天”
            public byte byResidualValidity; // iResidualValidity字段是否有效，0-无效，1-有效
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 243, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        public const int NET_DVR_DEV_ADDRESS_MAX_LEN = 129;
        public const int NET_DVR_LOGIN_USERNAME_MAX_LEN = 64;
        public const int NET_DVR_LOGIN_PASSWD_MAX_LEN = 64;

        public delegate void LOGINRESULTCALLBACK(int lUserID, int dwResult, IntPtr lpDeviceInfo, IntPtr pUser);

        [StructLayout(LayoutKind.Sequential)]
        public struct NET_DVR_USER_LOGIN_INFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NET_DVR_DEV_ADDRESS_MAX_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDeviceAddress;
            public byte byUseTransport;
            public ushort wPort;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NET_DVR_LOGIN_USERNAME_MAX_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NET_DVR_LOGIN_PASSWD_MAX_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;
            public LOGINRESULTCALLBACK cbLoginResult;
            public IntPtr pUser;
            public bool bUseAsynLogin;
            public byte byProxyType; //0:不使用代理，1：使用标准代理，2：使用EHome代理
            public byte byUseUTCTime;    //0-不进行转换，默认,1-接口上输入输出全部使用UTC时间,SDK完成UTC时间与设备时区的转换,2-接口上输入输出全部使用平台本地时间，SDK完成平台本地时间与设备时区的转换
            public byte byLoginMode; //0-Private, 1-ISAPI, 2-自适应
            public byte byHttps;    //0-不适用tls，1-使用tls 2-自适应
            public int iProxyID;    //代理服务器序号，添加代理服务器信息时，相对应的服务器数组下表值
            public byte byVerifyMode;  //认证方式，0-不认证，1-双向认证，2-单向认证；认证仅在使用TLS的时候生效;    
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 119, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }

        //sdk网络环境枚举变量，用于远程升级
        public enum SDK_NETWORK_ENVIRONMENT
        {
            LOCAL_AREA_NETWORK = 0,
            WIDE_AREA_NETWORK,
        }

        //显示模式
        public enum DISPLAY_MODE
        {
            NORMALMODE = 0,
            OVERLAYMODE
        }

        //发送模式
        public enum SEND_MODE
        {
            PTOPTCPMODE = 0,
            PTOPUDPMODE,
            MULTIMODE,
            RTPMODE,
            RESERVEDMODE
        }

        //抓图模式
        public enum CAPTURE_MODE
        {
            BMP_MODE = 0,		//BMP模式
            JPEG_MODE = 1		//JPEG模式 
        }

        //实时声音模式
        public enum REALSOUND_MODE
        {
            MONOPOLIZE_MODE = 1,//独占模式
            SHARE_MODE = 2		//共享模式
        }

        public struct NET_DVR_CLIENTINFO
        {
            public Int32 lChannel;//通道号
            public Int32 lLinkMode;//最高位(31)为0表示主码流，为1表示子码流，0－30位表示码流连接方式: 0：TCP方式,1：UDP方式,2：多播方式,3 - RTP方式，4-音视频分开(TCP)
            public IntPtr hPlayWnd;//播放窗口的句柄,为NULL表示不播放图象
            public string sMultiCastIP;//多播组地址
        }

        //SDK状态信息(9000新增)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SDKSTATE
        {
            public uint dwTotalLoginNum;//当前login用户数
            public uint dwTotalRealPlayNum;//当前realplay路数
            public uint dwTotalPlayBackNum;//当前回放或下载路数
            public uint dwTotalAlarmChanNum;//当前建立报警通道路数
            public uint dwTotalFormatNum;//当前硬盘格式化路数
            public uint dwTotalFileSearchNum;//当前日志或文件搜索路数
            public uint dwTotalLogSearchNum;//当前日志或文件搜索路数
            public uint dwTotalSerialNum;//当前透明通道路数
            public uint dwTotalUpgradeNum;//当前升级路数
            public uint dwTotalVoiceComNum;//当前语音转发路数
            public uint dwTotalBroadCastNum;//当前语音广播路数
            public uint dwTotalListenNum;	    //当前网络监听路数
            public uint dwEmailTestNum;       //当前邮件计数路数
            public uint dwBackupNum;          // 当前文件备份路数
            public uint dwTotalInquestUploadNum; //当前审讯上传路数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;
        }

        //SDK功能支持信息(9000新增)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SDKABL
        {
            public uint dwMaxLoginNum;//最大login用户数 MAX_LOGIN_USERS
            public uint dwMaxRealPlayNum;//最大realplay路数 WATCH_NUM
            public uint dwMaxPlayBackNum;//最大回放或下载路数 WATCH_NUM
            public uint dwMaxAlarmChanNum;//最大建立报警通道路数 ALARM_NUM
            public uint dwMaxFormatNum;//最大硬盘格式化路数 SERVER_NUM
            public uint dwMaxFileSearchNum;//最大文件搜索路数 SERVER_NUM
            public uint dwMaxLogSearchNum;//最大日志搜索路数 SERVER_NUM
            public uint dwMaxSerialNum;//最大透明通道路数 SERVER_NUM
            public uint dwMaxUpgradeNum;//最大升级路数 SERVER_NUM
            public uint dwMaxVoiceComNum;//最大语音转发路数 SERVER_NUM
            public uint dwMaxBroadCastNum;//最大语音广播路数 MAX_CASTNUM
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;
        }

        //报警设备信息
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_ALARMER
        {
            public byte byUserIDValid;/* userid是否有效 0-无效，1-有效 */
            public byte bySerialValid;/* 序列号是否有效 0-无效，1-有效 */
            public byte byVersionValid;/* 版本号是否有效 0-无效，1-有效 */
            public byte byDeviceNameValid;/* 设备名字是否有效 0-无效，1-有效 */
            public byte byMacAddrValid; /* MAC地址是否有效 0-无效，1-有效 */
            public byte byLinkPortValid;/* login端口是否有效 0-无效，1-有效 */
            public byte byDeviceIPValid;/* 设备IP是否有效 0-无效，1-有效 */
            public byte bySocketIPValid;/* socket ip是否有效 0-无效，1-有效 */
            public int lUserID; /* NET_DVR_Login()返回值, 布防时有效 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;/* 序列号 */
            public uint dwDeviceVersion;/* 版本信息 高16位表示主版本，低16位表示次版本*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDeviceName;/* 设备名字 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMacAddr;/* MAC地址 */
            public ushort wLinkPort; /* link port */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] sDeviceIP;/* IP地址 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] sSocketIP;/* 报警主动上传时的socket IP地址 */
            public byte byIpProtocol; /* Ip协议 0-IPV4, 1-IPV6 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //硬解码显示区域参数(子结构)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISPLAY_PARA
        {
            public int bToScreen;
            public int bToVideoOut;
            public int nLeft;
            public int nTop;
            public int nWidth;
            public int nHeight;
            public int nReserved;
        }

        //硬解码预览参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CARDINFO
        {
            public int lChannel;//通道号
            public int lLinkMode;//最高位(31)为0表示主码流，为1表示子，0－30位表示码流连接方式:0：TCP方式,1：UDP方式,2：多播方式,3 - RTP方式，4-电话线，5－128k宽带，6－256k宽带，7－384k宽带，8－512k宽带；
            [MarshalAsAttribute(UnmanagedType.LPStr)]
            public string sMultiCastIP;
            public NET_DVR_DISPLAY_PARA struDisplayPara;
        }

        //录象文件参数
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_FIND_DATA
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sFileName;//文件名
            public NET_DVR_TIME struStartTime;//文件的开始时间
            public NET_DVR_TIME struStopTime;//文件的结束时间
            public uint dwFileSize;//文件的大小
        }

        //录象文件参数(9000)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_FINDDATA_V30
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sFileName;//文件名
            public NET_DVR_TIME struStartTime;//文件的开始时间
            public NET_DVR_TIME struStopTime;//文件的结束时间
            public uint dwFileSize;//文件的大小
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sCardNum;
            public byte byLocked;//9000设备支持,1表示此文件已经被锁定,0表示正常的文件
            public byte byFileType;  //文件类型:0－定时录像,1-移动侦测 ，2－报警触发，
            //3-报警|移动侦测 4-报警&移动侦测 5-命令触发 6-手动录像,7－震动报警，8-环境报警，9-智能报警，10-PIR报警，11-无线报警，12-呼救报警,14-智能交通事件
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //录象文件参数(cvr)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_FINDDATA_V40
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sFileName;//文件名
            public NET_DVR_TIME struStartTime;//文件的开始时间
            public NET_DVR_TIME struStopTime;//文件的结束时间
            public uint dwFileSize;//文件的大小
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sCardNum;
            public byte byLocked;//9000设备支持,1表示此文件已经被锁定,0表示正常的文件
            public byte byFileType;  //文件类型:0－定时录像,1-移动侦测 ，2－报警触发，
	        //3-报警|移动侦测 4-报警&移动侦测 5-命令触发 6-手动录像,7－震动报警，8-环境报警，9-智能报警，10-PIR报警，11-无线报警，12-呼救报警,14-智能交通事件
            public byte byQuickSearch; //0:普通查询结果，1：快速（日历）查询结果
            public byte byRes;
            public uint dwFileIndex; //文件索引号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;	
        }

        //录象文件参数(带卡号)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_FINDDATA_CARD
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sFileName;//文件名
            public NET_DVR_TIME struStartTime;//文件的开始时间
            public NET_DVR_TIME struStopTime;//文件的结束时间
            public uint dwFileSize;//文件的大小
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sCardNum;
        }

        //录象文件查找条件结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FILECOND
        {
            public int lChannel;//通道号
            public uint dwFileType;//录象文件类型0xff－全部，0－定时录像,1-移动侦测 ，2－报警触发，
            //3-报警|移动侦测 4-报警&移动侦测 5-命令触发 6-手动录像
            public uint dwIsLocked;//是否锁定 0-正常文件,1-锁定文件, 0xff表示所有文件
            public uint dwUseCardNo;//是否使用卡号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] sCardNumber;//卡号
            public NET_DVR_TIME struStartTime;//开始时间
            public NET_DVR_TIME struStopTime;//结束时间
        }

        //云台区域选择放大缩小(HIK 快球专用)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POINT_FRAME
        {
            public int xTop;//方框起始点的x坐标
            public int yTop;//方框结束点的y坐标
            public int xBottom;//方框结束点的x坐标
            public int yBottom;//方框结束点的y坐标
            public int bCounter;//保留
        }

        //语音对讲参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSION_AUDIO
        {
            public byte byAudioEncType;//音频编码类型 0-G722; 1-G711
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byres;//这里保留音频的压缩参数 
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AUDIOENC_INFO
        {
            public uint in_frame_size;                /* 输入一帧数据大小(BYTES)，由GetInfoParam函数返回         */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.U4)]
            public int[] reserved;                 /* 保留 */
        }

        // 音频编码
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AUDIOENC_PROCESS_PARAM
        {
            public IntPtr in_buf;                      /* 输入buf */
            public IntPtr out_buf;                     /* 输出buf */
            public uint out_frame_size;               /* 编码一帧后的BYTE数 */
            public int g726enc_reset;                /* 重置开关 */
            public int g711_type;                    /* g711编码类型,0 - U law, 1- A law */
            public int enc_mode;                     /* 音频编码模式，AMR编码配置 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.U4)]
            public int[] reserved;                 /* 保留 */
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_AP_INFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = IW_ESSID_MAX_SIZE)]
            public string sSsid;
            public uint dwMode;/* 0 mange 模式;1 ad-hoc模式，参见NICMODE */
            public uint dwSecurity;  /*0 不加密；1 wep加密；2 wpa-psk;3 wpa-Enterprise，参见WIFISECURITY*/
            public uint dwChannel;/*1-11表示11个通道*/
            public uint dwSignalStrength;/*0-100信号由最弱变为最强*/
            public uint dwSpeed;/*速率,单位是0.01mbps*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AP_INFO_LIST
        {
            public uint dwSize;
            public uint dwCount;/*无线AP数量，不超过20*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = WIFI_MAX_AP_COUNT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_AP_INFO[] struApInfo;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_WIFIETHERNET
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sIpAddress;/*IP地址*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sIpMask;/*掩码*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;/*物理地址，只用来显示*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] bRes;
            public uint dwEnableDhcp;/*是否启动dhcp  0不启动 1启动*/
            public uint dwAutoDns;/*如果启动dhcp是否自动获取dns,0不自动获取 1自动获取；对于有线如果启动dhcp目前自动获取dns*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sFirstDns; /*第一个dns域名*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sSecondDns;/*第二个dns域名*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sGatewayIpAddr;/* 网关地址*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] bRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct UNION_EAP_TTLS
        {
            public byte byEapolVersion; //EAPOL版本，0-版本1，1-版本2
            public byte byAuthType; //内部认证方式，0-PAP，1-MSCHAPV2
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnonyIdentity; //匿名身份
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byUserName; //用户名
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPassword; //密码
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        } //WPA-enterprise/WPA2-enterpris模式适用

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct UNION_EAP_PEAP
        {
            public byte byEapolVersion; //EAPOL版本，0-版本1，1-版本2
            public byte byAuthType; //内部认证方式，0-GTC，1-MD5，2-MSCHAPV2
            public byte byPeapVersion; //PEAP版本，0-版本0，1-版本1
            public byte byPeapLabel; //PEAP标签，0-老标签，1-新标签
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnonyIdentity; //匿名身份
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byUserName; //用户名
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPassword; //密码
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        } //WPA-enterprise/WPA2-enterpris模式适用

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct UNION_EAP_TLS
        {
            public byte byEapolVersion; //EAPOL版本，0-版本1，1-版本2
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byIdentity; //身份
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPrivateKeyPswd; //私钥密码
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 76, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct WIFI_AUTH_PARAM
        {
            [FieldOffsetAttribute(0)]
            public UNION_EAP_TTLS EAP_TTLS;//WPA-enterprise/WPA2-enterpris模式适用
			
            [FieldOffsetAttribute(0)]
            public UNION_EAP_PEAP EAP_PEAP; //WPA-enterprise/WPA2-enterpris模式适用

			[FieldOffsetAttribute(0)]
            public UNION_EAP_TLS EAP_TLS; 
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct UNION_WEP
        {
            public uint dwAuthentication;/*0 -开放式 1-共享式*/
            public uint dwKeyLength;/* 0 -64位；1- 128位；2-152位*/
            public uint dwKeyType;/*0 16进制;1 ASCI */
            public uint dwActive;/*0 索引：0---3表示用哪一个密钥*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = WIFI_WEP_MAX_KEY_COUNT * WIFI_WEP_MAX_KEY_LENGTH)]
            public string sKeyInfo;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct UNION_WPA_PSK
        {
            public uint dwKeyLength;/*8-63个ASCII字符*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = WIFI_WPA_PSK_MAX_KEY_LENGTH)]
            public string sKeyInfo;
            public byte byEncryptType;/*WPA/WPA2模式下加密类型,0-AES, 1-TKIP*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct UNION_WPA_WPA2
        {
            public byte byEncryptType;  /*加密类型,0-AES, 1-TKIP*/
            public byte byAuthType; //认证类型，0-EAP_TTLS,1-EAP_PEAP,2-EAP_TLS
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public WIFI_AUTH_PARAM auth_param;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_WIFI_CFG_EX
        {
            public NET_DVR_WIFIETHERNET struEtherNet;/*wifi网口*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = IW_ESSID_MAX_SIZE)]
            public string sEssid;/*SSID*/
            public uint dwMode;/* 0 mange 模式;1 ad-hoc模式，参见*/
            public uint dwSecurity;/*0 不加密；1 wep加密；2 wpa-psk; */
            [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct key
            {
                [FieldOffsetAttribute(0)]
                public UNION_WEP wep;

                [FieldOffsetAttribute(0)]
                public UNION_WPA_PSK wpa_psk;

                [FieldOffsetAttribute(0)]
                public UNION_WPA_WPA2 wpa_wpa2;//WPA-enterprise/WPA2-enterpris模式适用
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WIFI_CFG
        {
            public uint dwSize;
            public NET_DVR_WIFI_CFG_EX struWifiCfg;
        }

        //wifi连接状态
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WIFI_CONNECT_STATUS
        {
            public uint dwSize;
            public byte byCurStatus;	//1-已连接，2-未连接，3-正在连接
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;		//保留
            public uint dwErrorCode;	// byCurStatus = 2时有效,1-用户名或密码错误,2-无此路由器,3-未知错误
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 244, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WIFI_WORKMODE
        {
            public uint dwSize;
            public uint dwNetworkInterfaceMode;/*0 自动切换模式　1 有线模式*/
        }

        //智能控制信息
        public const int MAX_VCA_CHAN = 16;//最大智能通道数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_CTRLINFO
        {
            public byte byVCAEnable;//是否开启智能
            public byte byVCAType;//智能能力类型，VCA_CHAN_ABILITY_TYPE 
            public byte byStreamWithVCA;//码流中是否带智能信息
            public byte byMode;//模式，VCA_CHAN_MODE_TYPE ,atm能力的时候需要配置
            public byte byControlType;   //控制类型，按位表示，0-否，1-是
            // byControlType &1 是否启用抓拍功能
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//保留，设置为0 
        }

        //智能控制信息结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_CTRLCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VCA_CHAN, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_CTRLINFO[] struCtrlInfo;//控制信息,数组0对应设备的起始通道
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //智能设备能力集
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_DEV_ABILITY
        {
            public uint dwSize;//结构长度
            public byte byVCAChanNum;//智能通道个数
            public byte byPlateChanNum;//车牌通道个数
            public byte byBBaseChanNum;//行为基本版个数
            public byte byBAdvanceChanNum;//行为高级版个数
            public byte byBFullChanNum;//行为完整版个数
            public byte byATMChanNum;//智能ATM个数
            public byte byPDCChanNum;         //人数统计通道个数
            public byte byITSChanNum;         //交通事件通道个数
            public byte byBPrisonChanNum;     //行为监狱版(监舍)通道个数
            public byte byFSnapChanNum;       //人脸抓拍通道个数
            public byte byFSnapRecogChanNum;  //人脸抓拍和识别通道个数
            public byte byFRetrievalChanNum;  //人脸后检索个数
            public byte bySupport;            //能力，位与结果为0表示不支持，1表示支持
            //bySupport & 0x1，表示是否支持智能跟踪 2012-3-22
            //bySupport & 0x2，表示是否支持128路取流扩展2012-12-27
            public byte byFRecogChanNum;      //人脸识别通道个数
            public byte byBPPerimeterChanNum; //行为监狱版(周界)通道个数
            public byte byTPSChanNum;         //交通诱导通道个数
            public byte byTFSChanNum;         //道路违章取证通道个数
            public byte byFSnapBFullChanNum;  //人脸抓拍和异常行为识别通道个数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 22, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //异常行为识别能力类型
        public enum VCA_ABILITY_TYPE:uint
        {
            TRAVERSE_PLANE_ABILITY = 0x01,       //穿越警戒面
            ENTER_AREA_ABILITY = 0x02,       //进入区域
            EXIT_AREA_ABILITY = 0x04,       //离开区域
            INTRUSION_ABILITY = 0x08,       //入侵
            LOITER_ABILITY = 0x10,       //徘徊
            LEFT_TAKE_ABILITY = 0x20,       //物品遗留拿取
            PARKING_ABILITY = 0x40,       //停车
            RUN_ABILITY = 0x80,       //快速移动
            HIGH_DENSITY_ABILITY = 0x100,      //人员聚集
            LF_TRACK_ABILITY = 0x200,      //球机跟踪
            VIOLENT_MOTION_ABILITY = 0x400,      //剧烈运动检测
            REACH_HIGHT_ABILITY = 0x800,      //攀高检测
            GET_UP_ABILITY = 0x1000,     //起身检测
            LEFT_ABILITY = 0x2000,     //物品遗留
            TAKE_ABILITY = 0x4000,     //物品拿取
            LEAVE_POSITION = 0x8000,     //离岗
            TRAIL_ABILITY = 0x10000,    //尾随 
            KEY_PERSON_GET_UP_ABILITY = 0x20000,    //重点人员起身检测
            FALL_DOWN_ABILITY = 0x80000,    //倒地
            AUDIO_ABNORMAL_ABILITY = 0x100000,   //声强突变
            ADV_REACH_HEIGHT_ABILITY = 0x200000,   //折线攀高
            TOILET_TARRY_ABILITY = 0x400000,   //如厕超时
            YARD_TARRY_ABILITY = 0x800000,   //放风场滞留
            ADV_TRAVERSE_PLANE_ABILITY = 0x1000000,  //折线警戒面
            HUMAN_ENTER_ABILITY = 0x10000000, //人靠近ATM ,只在ATM_PANEL模式下支持
            OVER_TIME_ABILITY = 0x20000000, //操作超时,只在ATM_PANEL模式下支持
            STICK_UP_ABILITY = 0x40000000, //贴纸条
            INSTALL_SCANNER_ABILITY = 0x80000000  //安装读卡器
        }

        //智能通道类型
        public enum VCA_CHAN_ABILITY_TYPE
        {
            VCA_BEHAVIOR_BASE = 1,          //异常行为识别基本版
            VCA_BEHAVIOR_ADVANCE = 2,          //异常行为识别高级版
            VCA_BEHAVIOR_FULL = 3,          //异常行为识别完整版
            VCA_PLATE = 4,          //车牌能力
            VCA_ATM = 5,          //ATM能力
            VCA_PDC = 6,          //人流量统计
            VCA_ITS = 7,          //智能 交通事件
            VCA_BEHAVIOR_PRISON = 8,          //异常行为识别监狱版(监舍) 
            VCA_FACE_SNAP = 9,           //人脸抓拍能力
            VCA_FACE_SNAPRECOG = 10,          //人脸抓拍和识别能力
            VCA_FACE_RETRIEVAL = 11,          //人脸后检索能力
            VCA_FACE_RECOG = 12,          //人脸识别能力
            VCA_BEHAVIOR_PRISON_PERIMETER = 13, // 异常行为识别监狱版 (周界)
            VCA_TPS = 14,          //交通诱导
            VCA_TFS = 15,          //道路违章取证
            VCA_BEHAVIOR_FACESNAP = 16           //人脸抓拍和异常行为识别能力
        }

        //智能ATM模式类型(ATM能力特有)
        public enum VCA_CHAN_MODE_TYPE
        {
            VCA_ATM_PANEL = 0,//ATM面板
            VCA_ATM_SURROUND = 1,//ATM环境
            VCA_ATM_FACE = 2	//ATM人脸
        }
        public enum TFS_CHAN_MODE_TYPE
        {
            TFS_CITYROAD = 0,  //TFS 城市道路
            TFS_FREEWAY = 1   //TFS 高速道路
        }

        //异常行为识别场景模式
        public enum BEHAVIOR_SCENE_MODE_TYPE
        {
            BEHAVIOR_SCENE_DEFAULT = 0, //系统默认
            BEHAVIOR_SCENE_WALL = 1,    //围墙
            BEHAVIOR_SCENE_INDOOR = 2   //室内
        }

        //通道能力输入参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_CHAN_IN_PARAM
        {
            public byte byVCAType;//VCA_CHAN_ABILITY_TYPE枚举值
            public byte byMode;//模式，VCA_CHAN_MODE_TYPE ,atm能力的时候需要配置
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//保留，设置为0 
        }

        //行为能力集结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BEHAVIOR_ABILITY
        {
            public uint dwSize;//结构长度
            public uint dwAbilityType;//支持的能力类型，按位表示，见VCA_ABILITY_TYPE定义
            public byte byMaxRuleNum;//最大规则数
            public byte byMaxTargetNum;//最大目标数
            public byte bySupport;		// 支持的功能类型   按位表示  
            // bySupport & 0x01 支持标定功能
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //保留，设置为0
        }

        // 交通能力集结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ITS_ABILITY
        {
            public uint dwSize;             // 结构体大小
            public uint dwAbilityType;      // 支持的能力列表  参照ITS_ABILITY_TYPE
            public byte byMaxRuleNum;	 	//最大规则数
            public byte byMaxTargetNum; 	//最大目标数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		    // 保留
        }
        /***********************************end*******************************************/

        /************************************智能参数结构*********************************/
        //智能共用结构
        //坐标值归一化,浮点数值为当前画面的百分比大小, 精度为小数点后三位
        //点坐标结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_POINT
        {
            public float fX;// X轴坐标, 0.001~1
            public float fY;//Y轴坐标, 0.001~1
        }

        //区域框结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RECT
        {
            public float fX;//边界框左上角点的X轴坐标, 0.001~1
            public float fY;//边界框左上角点的Y轴坐标, 0.001~1
            public float fWidth;//边界框的宽度, 0.001~1
            public float fHeight;//边界框的高度, 0.001~1
        }

        //异常行为识别事件类型
        public enum VCA_EVENT_TYPE : uint
        {
            VCA_TRAVERSE_PLANE = 0x1,        //穿越警戒面
            VCA_ENTER_AREA = 0x2,        //目标进入区域,支持区域规则
            VCA_EXIT_AREA = 0x4,        //目标离开区域,支持区域规则
            VCA_INTRUSION = 0x8,        //周界入侵,支持区域规则
            VCA_LOITER = 0x10,       //徘徊,支持区域规则
            VCA_LEFT_TAKE = 0x20,       //物品遗留拿取,支持区域规则
            VCA_PARKING = 0x40,       //停车,支持区域规则
            VCA_RUN = 0x80,       //快速移动,支持区域规则
            VCA_HIGH_DENSITY = 0x100,      //区域内人员聚集,支持区域规则
            VCA_VIOLENT_MOTION = 0x200,		 //剧烈运动检测
            VCA_REACH_HIGHT = 0x400,		 //攀高检测
            VCA_GET_UP = 0x800,	     //起身检测
            VCA_LEFT = 0x1000,     //物品遗留
            VCA_TAKE = 0x2000,     //物品拿取
            VCA_LEAVE_POSITION = 0x4000,     //离岗
            VCA_TRAIL = 0x8000,     //尾随
            VCA_KEY_PERSON_GET_UP = 0x10000,    //重点人员起身检测
            VCA_FALL_DOWN = 0x80000,    //倒地检测
            VCA_AUDIO_ABNORMAL = 0x100000,   //声强突变检测
            VCA_ADV_REACH_HEIGHT = 0x200000,   //折线攀高
            VCA_TOILET_TARRY = 0x400000,   //如厕超时
            VCA_YARD_TARRY = 0x800000,   //放风场滞留
            VCA_ADV_TRAVERSE_PLANE = 0x1000000,  //折线警戒面
            VCA_HUMAN_ENTER = 0x10000000, //人靠近ATM           只在ATM_PANEL模式下支持
            VCA_OVER_TIME = 0x20000000, //操作超时            只在ATM_PANEL模式下支持
            VCA_STICK_UP = 0x40000000, //贴纸条,支持区域规则
            VCA_INSTALL_SCANNER = 0x80000000  //安装读卡器,支持区域规则
        }

        //异常行为识别事件类型扩展
        public enum VCA_RULE_EVENT_TYPE_EX : ushort
        {
            ENUM_VCA_EVENT_TRAVERSE_PLANE = 1,   //穿越警戒面
            ENUM_VCA_EVENT_ENTER_AREA = 2,   //目标进入区域,支持区域规则
            ENUM_VCA_EVENT_EXIT_AREA = 3,   //目标离开区域,支持区域规则
            ENUM_VCA_EVENT_INTRUSION = 4,   //周界入侵,支持区域规则
            ENUM_VCA_EVENT_LOITER = 5,   //徘徊,支持区域规则
            ENUM_VCA_EVENT_LEFT_TAKE = 6,   //物品遗留拿取,支持区域规则
            ENUM_VCA_EVENT_PARKING = 7,   //停车,支持区域规则
            ENUM_VCA_EVENT_RUN = 8,   //快速移动,支持区域规则
            ENUM_VCA_EVENT_HIGH_DENSITY = 9,   //区域内人员聚集,支持区域规则
            ENUM_VCA_EVENT_VIOLENT_MOTION = 10,  //剧烈运动检测
            ENUM_VCA_EVENT_REACH_HIGHT = 11,  //攀高检测
            ENUM_VCA_EVENT_GET_UP = 12,  //起身检测
            ENUM_VCA_EVENT_LEFT = 13,  //物品遗留
            ENUM_VCA_EVENT_TAKE = 14,  //物品拿取
            ENUM_VCA_EVENT_LEAVE_POSITION = 15,  //离岗
            ENUM_VCA_EVENT_TRAIL = 16,  //尾随
            ENUM_VCA_EVENT_KEY_PERSON_GET_UP = 17,  //重点人员起身检测
            ENUM_VCA_EVENT_FALL_DOWN = 20,  //倒地检测
            ENUM_VCA_EVENT_AUDIO_ABNORMAL = 21,  //声强突变检测
            ENUM_VCA_EVENT_ADV_REACH_HEIGHT = 22,  //折线攀高
            ENUM_VCA_EVENT_TOILET_TARRY = 23,  //如厕超时
            ENUM_VCA_EVENT_YARD_TARRY = 24,  //放风场滞留
            ENUM_VCA_EVENT_ADV_TRAVERSE_PLANE = 25,  //折线警戒面
            ENUM_VCA_EVENT_HUMAN_ENTER = 29,  //人靠近ATM,只在ATM_PANEL模式下支持   
            ENUM_VCA_EVENT_OVER_TIME = 30,  //操作超时,只在ATM_PANEL模式下支持
            ENUM_VCA_EVENT_STICK_UP = 31,  //贴纸条,支持区域规则
            ENUM_VCA_EVENT_INSTALL_SCANNER = 32   //安装读卡器,支持区域规则
        }

        //警戒面穿越方向类型
        public enum VCA_CROSS_DIRECTION
        {
            VCA_BOTH_DIRECTION,// 双向 
            VCA_LEFT_GO_RIGHT,// 由左至右 
            VCA_RIGHT_GO_LEFT,// 由右至左 
        }

        //线结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_LINE
        {
            public NET_VCA_POINT struStart;//起点 
            public NET_VCA_POINT struEnd; //终点

            //             public void init()
            //             {
            //                 struStart = new NET_VCA_POINT();
            //                 struEnd = new NET_VCA_POINT();
            //             }
        }

        //该结构会导致xaml界面出不来！！！！！！！！！？？问题暂时还没有找到  
        //暂时屏蔽结构先
        //多边型结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_POLYGON
        {
            /// DWORD->unsigned int
            public uint dwPointNum;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = VCA_MAX_POLYGON_POINT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_POINT[] struPos;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_TRAVERSE_PLANE
        {
            public NET_VCA_LINE struPlaneBottom;//警戒面底边
            public uint dwCrossDirection;//穿越方向: 0-双向，1-从左到右，2-从右到左
            public byte bySensitivity;//灵敏度，取值范围：[1,5] （对于Smart IPC，取值范围为[1,100]） 
            public byte byPlaneHeight;//警戒面高度
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 38, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;

            //             public void init()
            //             {
            //                 struPlaneBottom = new NET_VCA_LINE();
            //                 struPlaneBottom.init();
            //                 byRes2 = new byte[38];
            //             }
        }

        //进入/离开区域参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_AREA
        {
            public NET_VCA_POLYGON struRegion;//区域范围
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //根据报警延迟时间来标识报警中带图片，报警间隔和IO报警一致，1秒发送一个。
        //入侵参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_INTRUSION
        {
            public NET_VCA_POLYGON struRegion;//区域范围
            public ushort wDuration;//报警延迟时间: 1-120秒，建议5秒，判断是有效报警的时间
            public byte bySensitivity;        //灵敏度参数，范围[1-100]
            public byte byRate;               //占比：区域内所有未报警目标尺寸目标占区域面积的比重，归一化为－；
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //徘徊参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_LOITER
        {
            public NET_VCA_POLYGON struRegion;//区域范围
            public ushort wDuration;//触发徘徊报警的持续时间：1-120秒，建议10秒
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //丢包/捡包参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_TAKE_LEFT
        {
            public NET_VCA_POLYGON struRegion;//区域范围
            public ushort wDuration;//触发丢包/捡包报警的持续时间：1-120秒，建议10秒
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //停车参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_PARKING
        {
            public NET_VCA_POLYGON struRegion;//区域范围
            public ushort wDuration;//触发停车报警持续时间：1-120秒，建议10秒
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //奔跑参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RUN
        {
            public NET_VCA_POLYGON struRegion;//区域范围
            public float fRunDistance;//人奔跑最大距离, 范围: [0.1, 1.00]
            public byte byRes1;             // 保留字节
            public byte byMode;             // 0 像素模式  1 实际模式
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //人员聚集参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_HIGH_DENSITY
        {
            public NET_VCA_POLYGON struRegion;//区域范围
            public float fDensity;//密度比率, 范围: [0.1, 1.0]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public ushort wDuration;      // 触发人员聚集参数报警阈值 20-360s
        }

        //剧烈运动参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_VIOLENT_MOTION
        {
            public NET_VCA_POLYGON struRegion;//区域范围
            public ushort wDuration;           //触发剧烈运动报警阈值：1-50秒
            public byte bySensitivity;       //灵敏度参数，范围[1,5]
            public byte byMode;              //0-纯视频模式，1-音视频联合模式，2-纯音频模式
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;            //保留
        }

        //攀高参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_REACH_HIGHT
        {
            public NET_VCA_LINE struVcaLine;   //攀高警戒面
            public ushort wDuration; //触发攀高报警阈值：1-120秒
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           // 保留字节
        }

        //起床参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_GET_UP
        {
            public NET_VCA_POLYGON struRegion; //区域范围
            public ushort wDuration;	        //触发起床报警阈值1-100 秒
            public byte byMode;             //起身检测模式,0-大床通铺模式,1-高低铺模式,2-大床通铺坐立起身模式
            public byte bySensitivity;      //灵敏度参数，范围[1,10]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		    //保留字节
        }

        //物品遗留
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_LEFT
        {
            public NET_VCA_POLYGON struRegion; // 区域范围
            public ushort wDuration;       // 触发物品遗留报警阈值 10-100秒
            public byte bySensitivity;   // 灵敏度参数，范围[1,5] 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;        // 保留字节
        }

        // 物品拿取
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_TAKE
        {
            public NET_VCA_POLYGON struRegion;     // 区域范围
            public ushort wDuration;      // 触发物品拿取报警阈值10-100秒
            public byte bySensitivity;  // 灵敏度参数，范围[1,5] 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;       // 保留字节
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_OVER_TIME
        {
            public NET_VCA_POLYGON struRegion;    // 区域范围
            public ushort wDuration;  // 操作报警时间阈值 4s-60000s
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   // 保留字节
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_HUMAN_ENTER
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;			//保留字节
        }

        //贴纸条参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_STICK_UP
        {
            public NET_VCA_POLYGON struRegion;//区域范围
            public ushort wDuration;//报警持续时间：10-60秒，建议10秒
            public byte bySensitivity;//灵敏度参数，范围[1,5]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //读卡器参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SCANNER
        {
            public NET_VCA_POLYGON struRegion;//区域范围
            public ushort wDuration;//读卡持续时间：10-60秒
            public byte bySensitivity;//灵敏度参数，范围[1,5]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //离岗事件
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_LEAVE_POSITION
        {
            public NET_VCA_POLYGON struRegion; //区域范围
            public ushort wLeaveDelay;  //无人报警时间，单位：s，取值1-1800
            public ushort wStaticDelay; //睡觉报警时间，单位：s，取值1-1800
            public byte byMode;       //模式，0-离岗事件，1-睡岗事件，2-离岗睡岗事件
            public byte byPersonType; //值岗人数类型，0-单人值岗，1-双人值岗
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     //保留
        }

        //尾随参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_TRAIL
        {
            public NET_VCA_POLYGON struRegion;//区域范围
            public ushort wRes;      /* 保留 */
            public byte bySensitivity;       /* 灵敏度参数，范围[1,5] */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //倒地参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FALL_DOWN
        {
            public NET_VCA_POLYGON struRegion;//区域范围
            public ushort wDuration;      /* 触发事件阈值 1-60s*/
            public byte bySensitivity;       /* 灵敏度参数，范围[1,5] */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //声强突变参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_AUDIO_ABNORMAL
        {
            public ushort wDecibel;       //声音强度
            public byte bySensitivity;  //灵敏度参数，范围[1,5] 
            public byte byAudioMode;    //声音检测模式，0-灵敏度检测，1-分贝阈值检测，2-灵敏度与分贝阈值检测 
            public byte byEnable;       //使能，是否开启
            public byte byThreshold;    //声音阈值[0,100]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 54, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      //保留   
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AUDIO_EXCEPTION
        {
            public uint dwSize;
            public byte byEnableAudioInException;  //使能，是否开启
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_VCA_AUDIO_ABNORMAL struAudioAbnormal;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmSched; //布防时间
            public NET_DVR_HANDLEEXCEPTION_V40 struHandleException;  //异常处理方式
            public uint dwMaxRelRecordChanNum;  //报警触发的录象通道 数（只读）最大支持数量
            public uint dwRelRecordChanNum;     //报警触发的录象通道 数 实际支持的数量
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.U4)]
            public uint[] byRelRecordChan;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_TOILET_TARRY
        {
            public NET_VCA_POLYGON struRegion;//区域范围
            public ushort wDelay;        //如厕超时时间[1,3600]，单位：秒
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_YARD_TARRY
        {
            public NET_VCA_POLYGON struRegion;//区域范围
            public ushort wDelay;        //放风场滞留时间[1,120]，单位：秒
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_ADV_REACH_HEIGHT
        {
            public NET_VCA_POLYGON struRegion; //攀高折线
            public uint dwCrossDirection;   //跨越方向(详见VCA_CROSS_DIRECTION): 0-双向，1-从左到右2-从右到左
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		    // 保留字节
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_ADV_TRAVERSE_PLANE
        {
            public NET_VCA_POLYGON struRegion; //警戒面折线
            public uint dwCrossDirection;   //跨越方向(详见VCA_CROSS_DIRECTION): 0-双向，1-从左到右2-从右到左
            public byte bySensitivity;      //灵敏度参数，范围[1,5] 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		    //保留字节
        }

        //警戒事件参数
        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_VCA_EVENT_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.U4)]
            public uint[] uLen;//参数

            //[FieldOffsetAttribute(0)]
            //public NET_VCA_TRAVERSE_PLANE struTraversePlane;//穿越警戒面参数 
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_AREA struArea;//进入/离开区域参数
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_INTRUSION struIntrusion;//入侵参数
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_LOITER struLoiter;//徘徊参数
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_TAKE_LEFT struTakeTeft;//丢包/捡包参数
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_PARKING struParking;//停车参数
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_RUN struRun;//奔跑参数
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_HIGH_DENSITY struHighDensity;//人员聚集参数  
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_VIOLENT_MOTION struViolentMotion;	//剧烈运动
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_REACH_HIGHT struReachHight;      //攀高
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_GET_UP struGetUp;           //起床
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_LEFT struLeft;            //物品遗留
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_TAKE struTake;            // 物品拿取
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_HUMAN_ENTER struHumanEnter;      //人员进入
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_OVER_TIME struOvertime;        //操作超时
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_STICK_UP struStickUp;//贴纸条
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_SCANNER struScanner;//读卡器参数
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_LEAVE_POSITION struLeavePos;        //离岗参数
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_TRAIL struTrail;           //尾随参数
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_FALL_DOWN struFallDown;        //倒地参数
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_AUDIO_ABNORMAL struAudioAbnormal;   //声强突变
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_ADV_REACH_HEIGHT struReachHeight;     //折线攀高参数
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_TOILET_TARRY struToiletTarry;     //如厕超时参数
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_YARD_TARRY struYardTarry;       //放风场滞留参数
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_ADV_TRAVERSE_PLANE struAdvTraversePlane;//折线警戒面参数            
        }

        // 尺寸过滤器类型
        public enum SIZE_FILTER_MODE
        {
            IMAGE_PIX_MODE,//根据像素大小设置
            REAL_WORLD_MODE,//根据实际大小设置
            DEFAULT_MODE 	// 默认模式
        }

        //尺寸过滤器
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SIZE_FILTER
        {
            public byte byActive;//是否激活尺寸过滤器 0-否 非0-是
            public byte byMode;//过滤器模式SIZE_FILTER_MODE
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//保留，置0
            public NET_VCA_RECT struMiniRect;//最小目标框,全0表示不设置
            public NET_VCA_RECT struMaxRect;//最大目标框,全0表示不设置
        }

        //警戒规则结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_ONE_RULE
        {
            public byte byActive;//是否激活规则,0-否,非0-是
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//保留，设置为0字段
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;//规则名称
            public VCA_EVENT_TYPE dwEventType;//异常行为识别事件类型
            public NET_VCA_EVENT_UNION uEventParam;//异常行为识别事件参数
            public NET_VCA_SIZE_FILTER struSizeFilter;//尺寸过滤器
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_2, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//布防时间
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;//处理方式 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;//报警触发的录象通道,为1表示触发该通道
        }

        //异常行为识别配置结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RULECFG
        {
            public uint dwSize;//结构长度
            public byte byPicProType;//报警时图片处理方式 0-不处理 非0-上传
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_JPEGPARA struPictureParam;//图片规格结构
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RULE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_ONE_RULE[] struRule;//规则数组
        }

        //尺寸过滤策略
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FILTER_STRATEGY
        {
            public byte byStrategy;      //尺寸过滤策略 0 - 不启用 1-高度和宽度过滤,2-面积过滤
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;       //保留
        }

        //规则触发参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RULE_TRIGGER_PARAM
        {
            public byte byTriggerMode;   //规则的触发方式，0- 不启用，1- 轨迹点 2- 目标面积 
            public byte byTriggerPoint;  //触发点，触发方式为轨迹点时有效 0- 中,1-上,2-下
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;       //保留
            public float fTriggerArea;    //触发目标面积百分比 [0,100]，触发方式为目标面积时有效
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;       //保留
        }

        //警戒规则结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_ONE_RULE_V41
        {
            public byte byActive; //是否激活规则,0-否,非0-是
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  //保留，设置为0字段
            public ushort wEventTypeEx; //行为事件类型扩展，用于代替字段dwEventType，参考VCA_RULE_EVENT_TYPE_EX
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName; //规则名称
            public uint dwEventType;	//行为事件类型，保留是为了兼容，后续建议使用wEventTypeEx获取事件类型
            public NET_VCA_EVENT_UNION uEventParam; //异常行为识别事件参数
            public NET_VCA_SIZE_FILTER struSizeFilter;  //尺寸过滤器
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//布防时间
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	//处理方式 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan; //报警触发的录象通道,为1表示触发该通道
            public ushort wAlarmDelay; //智能报警延时，0-5s,1-10,2-30s,3-60s,4-120s,5-300s,6-600s
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //保留
            public NET_VCA_FILTER_STRATEGY struFilterStrategy; //尺寸过滤策略
            public NET_VCA_RULE_TRIGGER_PARAM struTriggerParam;   //规则触发参数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //异常行为识别配置结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RULECFG_V41
        {
            public uint dwSize;			//结构长度
            public byte byPicProType;	//报警时图片处理方式 0-不处理 非0-上传
            public byte byUpLastAlarm; //2011-04-06 是否先上传最近一次的报警
            public byte byPicRecordEnable;  /*2012-3-1是否启用图片存储, 0-不启用, 1-启用*/
            public byte byRes1;
            public NET_DVR_JPEGPARA struPictureParam; 		//图片规格结构	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RULE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_ONE_RULE_V41[] struRule;  //规则数组
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //简化目标结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_TARGET_INFO
        {
            public uint dwID;//目标ID ,人员密度过高报警时为0
            public NET_VCA_RECT struRect; //目标边界框 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//保留
        }

        //简化的规则信息, 包含规则的基本信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RULE_INFO
        {
            public byte byRuleID;//规则ID,0-7
            public byte byRes;//保留
            public ushort wEventTypeEx;   //行为事件类型扩展，用于代替字段dwEventType，参考VCA_RULE_EVENT_TYPE_EX
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;//规则名称
            public VCA_EVENT_TYPE dwEventType;//警戒事件类型
            public NET_VCA_EVENT_UNION uEventParam;//事件参数
        }

        //前端设备地址信息，智能分析仪表示的是前端设备的地址信息，其他设备表示本机的地址
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_DEV_INFO
        {
            public NET_DVR_IPADDR struDevIP;//前端设备地址，
            public ushort wPort;//前端设备端口号， 
            public byte byChannel;//前端设备通道，
            public byte byIvmsChannel;// 保留字节
        }

        //异常行为识别结果上报结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RULE_ALARM
        {
            public uint dwSize;//结构长度
            public uint dwRelativeTime;//相对时标
            public uint dwAbsTime;//绝对时标
            public NET_VCA_RULE_INFO struRuleInfo;//事件规则信息
            public NET_VCA_TARGET_INFO struTargetInfo;//报警目标信息
            public NET_VCA_DEV_INFO struDevInfo;//前端设备信息
            public uint dwPicDataLen;//返回图片的长度 为0表示没有图片，大于0表示该结构后面紧跟图片数据*/
            public byte byPicType; //0-普通图片 1-对比图片            
            public byte byRelAlarmPicNum; //关联通道报警图片数量
            public byte bySmart;//IDS设备返回0(默认值)，Smart Functiom Return 1
            public byte byPicTransType;        //图片数据传输方式: 0-二进制；1-url
            public uint dwAlarmID;     //报警ID，用以标识通道间关联产生的组合报警，0表示无效
            public ushort wDevInfoIvmsChannelEx;     //与NET_VCA_DEV_INFO里的byIvmsChannel含义相同，能表示更大的值。老客户端用byIvmsChannel能继续兼容，但是最大到255。新客户端版本请使用wDevInfoIvmsChannelEx。
            public byte byRelativeTimeFlag;      //dwRelativeTime字段是否有效  0-无效， 1-有效，dwRelativeTime表示UTC时间 
            public byte byAppendInfoUploadEnabled; //附加信息上传使能 0-不上传 1-上传
            public IntPtr pAppendInfo;     //指向附加信息NET_VCA_APPEND_INFO的指针，byAppendInfoUploadEnabled为1时或者byTimeDiffFlag为1时有效
            public IntPtr pImage;//指向图片的指针
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SYSTEM_TIME
        {
            public ushort wYear;           //年
            public ushort wMonth;          //月
            public ushort wDay;            //日
            public ushort wHour;           //时
            public ushort wMinute;      //分
            public ushort wSecond;      //秒
            public ushort wMilliSec;    //毫秒
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //设备支持AI开放平台接入，上传视频检测数据
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_AIOP_VIDEO_HEAD
        {
            public uint dwSize;      //dwSize = sizeof(NET_AIOP_VIDEO_HEAD)
            public uint dwChannel;    //设备分析通道的通道号；
            public NET_DVR_SYSTEM_TIME struTime; 	//时间
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] szTaskID;     //视频任务ID，来自于视频任务派发
            public uint dwAIOPDataSize;   //对应AIOPDdata数据长度
            public uint dwPictureSize;    //对应分析图片长度
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] szMPID;        //检测模型包ID，用于匹配AIOP的检测数据解析；可以通过URI(GET /ISAPI/Intelligent/AIOpenPlatform/algorithmModel/management?format=json)获取当前设备加载的模型包的label description信息；
            public IntPtr pBufferAIOPData;  //AIOPDdata数据
            public IntPtr pBufferPicture;//对应分析图片数据
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 184, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //设备支持AI开放平台接入，上传图片检测数据
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_AIOP_PICTURE_HEAD
        {
            public uint dwSize;           //dwSize = sizeof(NET_AIOP_PICTURE_HEAD)
            public NET_DVR_SYSTEM_TIME struTime; 	//时间
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] szPID;        //透传下发的图片ID，来自于图片任务派发
            public uint dwAIOPDataSize;   //对应AIOPDdata数据长度
            public byte byStatus;         //状态值：0-成功，1-图片大小错误
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] szMPID; //检测模型包ID，用于匹配AIOP的检测数据解析；
            public IntPtr pBufferAIOPData;//AIOPDdata数据
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 184, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_AIOP_POLLING_VIDEO_HEAD
        {
            public uint dwSize;			//dwSize = sizeof(NET_AIOP_POLLING_VIDEO_HEAD)		
            public uint dwChannel;      //设备分析通道的通道号(走SDK协议)；
            public NET_DVR_SYSTEM_TIME     struTime; 	//时间
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] szTaskID;    //轮询抓图任务ID，来自于轮询抓图任务派发
            public uint dwAIOPDataSize;	//对应AIOPDdata数据长度
            public uint dwPictureSize;	//对应分析图片长度
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] szMPID; //检测模型包ID，用于匹配AIOP的检测数据解析；
            public IntPtr pBufferAIOPData;//AIOPDdata数据
            public IntPtr pBufferPicture;//对应分析图片数据
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 184, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_AIOP_POLLING_SNAP_HEAD
        {
            public uint dwSize;			//dwSize = sizeof(NET_AIOP_POLLING_SNAP_HEAD)		
            public uint dwChannel;      //设备分析通道的通道号(走SDK协议)；
            public NET_DVR_SYSTEM_TIME struTime; 	//时间
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] szTaskID;    //轮询抓图任务ID，来自于轮询抓图任务派发
            public uint dwAIOPDataSize;	//对应AIOPDdata数据长度
            public uint dwPictureSize;	//对应分析图片长度
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] szMPID;       //检测模型包ID，用于匹配AIOP的检测数据解析；
            public IntPtr pBufferAIOPData;//AIOPDdata数据
            public IntPtr pBufferPicture;//分析图片数据
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 184, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //异常行为识别规则DSP信息叠加结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_DRAW_MODE
        {
            public uint dwSize;
            public byte byDspAddTarget;//编码是否叠加目标
            public byte byDspAddRule;//编码是否叠加规则
            public byte byDspPicAddTarget;//抓图是否叠加目标
            public byte byDspPicAddRule;//抓图是否叠加规则
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //物体类型
        public enum OBJECT_TYPE_ENUM
        {
            ENUM_OBJECT_TYPE_COAT = 1  //上衣
        }

        //物体颜色条件结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OBJECT_COLOR_COND
        {
            public uint dwChannel;   //通道号
            public uint dwObjType;   //物体类型，参见OBJECT_TYPE_ENUM
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   //保留
        }

        //图片参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PIC
        {
            public byte byPicType;        //图片类型，1-jpg
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;        //保留
            public uint dwPicWidth;       //图片宽度
            public uint dwPicHeight;      //图片高度
            public uint dwPicDataLen;     //图片数据实际大小
            public uint dwPicDataBuffLen; //图片数据缓冲区大小
            public IntPtr byPicDataBuff;    //图片数据缓冲区
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;       //保留
        }

        //颜色联合体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OBJECT_COLOR_UNION
        {
            public NET_DVR_COLOR struColor;   //颜色值
            public NET_DVR_PIC struPicture; //图片
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   //保留
        }

        //物体颜色参数结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OBJECT_COLOR
        {
            public uint dwSize;       //结构体大小
            public byte byEnable;     //0-不启用，1-启用
            public byte byColorMode;  //取色方式，1-颜色值，2-图片
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;    //保留
            public NET_DVR_OBJECT_COLOR_UNION uObjColor; //物体颜色联合体，取值依赖于取色方式
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;   //保留
        }

        //区域类型
        public enum AREA_TYPE_ENUM
        {
            ENUM_OVERLAP_REGION = 1,//共同区域
            ENUM_BED_LOCATION = 2   //床铺位置
        }

        //辅助区域
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AUXAREA
        {
            public uint dwAreaType;   //区域类型，参见AREA_TYPE_ENUM
            public byte byEnable;     //0-不启用，1-启用
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;     //保留
            public NET_VCA_POLYGON struPolygon; //区域
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;   //保留
        }

        //辅助区域列表
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AUXAREA_LIST
        {
            public uint dwSize;	// 结构体大小
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AUXAREA_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_AUXAREA[] struArea; //辅助区域
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;	// 保留
        }

        //通道工作模式
        public enum CHAN_WORKMODE_ENUM
        {
            ENUM_CHAN_WORKMODE_INDEPENDENT = 1,  //独立模式
            ENUM_CHAN_WORKMODE_MASTER = 2,      //主模式
            ENUM_CHAN_WORKMODE_SLAVE = 3        //从模式
        }

        //通道工作模式参数结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CHANNEL_WORKMODE
        {
            public uint dwSize;        //结构体大小
            public byte byWorkMode;    //工作模式，参见CHAN_WORKMODE_ENUM
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     //保留
        }

        //设备通道参数结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CHANNEL
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byAddress;	//设备IP或域名
            public ushort wDVRPort;			 	    //端口号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                   //保留
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;	        //主机用户名
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;       //主机密码
            public uint dwChannel;                   //通道号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                  //保留
        }

        //从通道信息联合体
        [StructLayout(LayoutKind.Explicit)]
        public struct NET_DVR_SLAVE_CHANNEL_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 152, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;        //联合体大小
        }

        //从通道参数结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SLAVE_CHANNEL_PARAM
        {
            public byte byChanType;   //从通道类型，1-本机通道，2-远程通道 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;    //保留
            public NET_DVR_SLAVE_CHANNEL_UNION uSlaveChannel; //从通道联合体，取值依赖于byChanType
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;   //保留
        }


        //从通道参数配置结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SLAVE_CHANNEL_CFG
        {
            public uint dwSize;   //结构体大小
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SLAVE_CHANNEL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SLAVE_CHANNEL_PARAM[] struChanParam;//从通道参数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //保留
        }

        //视频质量诊断检测事件
        public enum VQD_EVENT_ENUM
        {
            ENUM_VQD_EVENT_BLUR = 1,  //图像模糊
            ENUM_VQD_EVENT_LUMA = 2,  //亮度异常
            ENUM_VQD_EVENT_CHROMA = 3,  //图像偏色
            ENUM_VQD_EVENT_SNOW = 4,  //雪花干扰
            ENUM_VQD_EVENT_STREAK = 5,  //条纹干扰
            ENUM_VQD_EVENT_FREEZE = 6,  //画面冻结
            ENUM_VQD_EVENT_SIGNAL_LOSS = 7,  //信号丢失
            ENUM_VQD_EVENT_PTZ = 8,  //云台失控
            ENUM_VQD_EVENT_SCNENE_CHANGE = 9,  //场景突变
            ENUM_VQD_EVENT_VIDEO_ABNORMAL = 10, //视频异常
            ENUM_VQD_EVENT_VIDEO_BLOCK = 11, //视频遮挡
        }

        //视频质量诊断事件条件结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VQD_EVENT_COND
        {
            public uint dwChannel;   //通道号
            public uint dwEventType; //检测事件类型，参见VQD_EVENT_ENUM
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   //保留
        }

        //视频质量诊断事件参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VQD_EVENT_PARAM
        {
            public byte byThreshold;    //报警阈值，范围[0,100]
            public byte byTriggerMode;  //1-持续触发，2-单次触发
            public byte byUploadPic;    //0-不上传图片，1-上传图片，无论是否上传图片，事后都可以从设备获取该事件所对应最新的一张报警图片，参见接口NET_DVR_StartDownload
            public byte byRes1;         //保留
            public uint dwTimeInterval; //持续触发报警时间间隔，范围[0,3600] 单位：秒
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;     //保留
        }

        //视频质量诊断事件规则
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VQD_EVENT_RULE
        {
            public uint dwSize;       //结构体大小 
            public byte byEnable;     //0-不启用，1-启用
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;    //保留
            public NET_DVR_VQD_EVENT_PARAM struEventParam; //视频质量诊断事件参数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//检测时间
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;  //处理方式
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IVMS_IP_CHANNEL, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan; //报警触发的录象通道：1表示触发该通道；0表示不触发
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;    //保留
        }

        //基准场景参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BASELINE_SCENE
        {
            public uint dwSize;     //结构体大小
            public byte byEnable;   //0-不启用，1-启用
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //保留
        }

        //基准场景操作参数结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CONTROL_BASELINE_SCENE_PARAM
        {
            public uint dwSize;     //结构体大小
            public uint dwChannel;  //通道号
            public byte byCommand;  //操作类型，1-此字段保留，暂不使用，2-更新基准场景
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 127, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //保留
        }

        //视频质量诊断报警结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VQD_ALARM
        {
            public uint dwSize;                //结构体大小
            public uint dwRelativeTime;        //相对时标
            public uint dwAbsTime;	          //绝对时标
            public NET_VCA_DEV_INFO struDevInfo; //前端设备信息 
            public uint dwEventType;           //事件类型，参考VQD_EVENT_ENUM
            public float fThreshold;            //报警阈值[0.000,1.000]
            public uint dwPicDataLen;          //图片长度，为0表示没有图片
            public IntPtr pImage;               //指向图片的指针 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;            //保留
        }

        //标定点子结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CB_POINT
        {
            public NET_VCA_POINT struPoint;     //标定点，主摄像机（枪机）
            public NET_DVR_PTZPOS struPtzPos;  //球机输入的PTZ坐标
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //标定参数配置结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRACK_CALIBRATION_PARAM
        {
            public byte byPointNum;			//有效标定点个数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CALIB_PT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CB_POINT[] struCBPoint; //标定点组
        }

        //球机配置结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRACK_CFG
        {
            public uint dwSize;				//结构长度	
            public byte byEnable;				//标定使能
            public byte byFollowChan;          // 被控制的从通道
            public byte byDomeCalibrate;			//设置智能跟踪球机标定，1设置 0不设置 
            public byte byRes;					// 保留字节
            public NET_DVR_TRACK_CALIBRATION_PARAM struCalParam; //标定点组
        }

        //跟踪模式
        public enum TRACK_MODE
        {
            MANUAL_CTRL = 0,  //手动跟踪
            ALARM_TRACK    //报警触发跟踪
        }

        //手动控制结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MANUAL_CTRL_INFO
        {
            public NET_VCA_POINT struCtrlPoint;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //跟踪模式结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRACK_MODE
        {
            public uint dwSize;		//结构长度
            public byte byTrackMode;   //跟踪模式
            public byte byRuleConfMode;   //规则配置跟踪模式0-本地配置跟踪，1-远程配置跟踪
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   //保留，置0
            [StructLayout(LayoutKind.Explicit)]
            public struct uModeParam
            {
                [FieldOffsetAttribute(0)]
                [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
                public uint[] dwULen;
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARM_JPEG
        {
            public byte byPicProType;	    /*报警时图片处理方式 0-不处理 1-上传*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           //保留字节
            public NET_DVR_JPEGPARA struPicParam; 				/*图片规格结构*/
        }

        //分析仪异常行为识别规则结构
        //警戒规则结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_ONE_RULE
        {
            public byte byActive;/* 是否激活规则,0-否, 非0-是 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//保留，设置为0字段
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;//规则名称
            public VCA_EVENT_TYPE dwEventType;//异常行为识别事件类型
            public NET_VCA_EVENT_UNION uEventParam;//异常行为识别事件参数
            public NET_VCA_SIZE_FILTER struSizeFilter;//尺寸过滤器
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 68, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;/*保留，设置为0*/
        }

        // 分析仪规则结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_RULECFG
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RULE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_IVMS_ONE_RULE[] struRule; //规则数组
        }

        // IVMS异常行为识别配置结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_BEHAVIORCFG
        {
            public uint dwSize;
            public byte byPicProType;//报警时图片处理方式 0-不处理 非0-上传
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_JPEGPARA struPicParam;//图片规格结构
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_IVMS_RULECFG[] struRuleCfg;//每个时间段对应规则
        }

        //智能分析仪取流计划子结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_DEVSCHED
        {
            public NET_DVR_SCHEDTIME struTime;//时间参数
            public NET_DVR_PU_STREAM_CFG struPUStream;//前端取流参数
        }

        //智能分析仪参数配置结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_STREAMCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_IVMS_DEVSCHED[] struDevSched;//按时间段配置前端取流以及规则信息
        }

        //屏蔽区域
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_MASK_REGION
        {
            public byte byEnable;//是否激活, 0-否，非0-是
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//保留，置0
            public NET_VCA_POLYGON struPolygon;//屏蔽多边形
        }

        //屏蔽区域链表结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_MASK_REGION_LIST
        {
            public uint dwSize;//结构长度
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //保留，置0
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_MASK_REGION_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_MASK_REGION[] struMask;//屏蔽区域数组
        }

        //ATM进入区域参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_ENTER_REGION
        {
            public uint dwSize;
            public byte byEnable;//是否激活，0-否，非0-是
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_VCA_POLYGON struPolygon;//进入区域
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //IVMS屏蔽区域链表
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_MASK_REGION_LIST
        {
            public uint dwSize;//结构长度
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_MASK_REGION_LIST[] struList;
        }

        //IVMS的ATM进入区域参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_ENTER_REGION
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_ENTER_REGION[] struEnter;//进入区域
        }

        // ivms 报警图片上传结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_ALARM_JPEG
        {
            public byte byPicProType;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_JPEGPARA struPicParam;
        }

        // IVMS 后检索配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_SEARCHCFG
        {
            public uint dwSize;
            public NET_DVR_MATRIX_DEC_REMOTE_PLAY struRemotePlay;// 远程回放
            public NET_IVMS_ALARM_JPEG struAlarmJpeg;// 报警上传图片配置
            public NET_IVMS_RULECFG struRuleCfg;//IVMS 行为规则配置
        }

        /************************************end******************************************/
        //NAS认证配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IDENTIFICATION_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;		/* 用户名 32*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;		/* 密码 16*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;	//保留
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_MOUNT_PARAM_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 52, ArraySubType = UnmanagedType.I1)]
            public byte[] uLen;   //联合体结构大小
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NAS_MOUNT_PARAM
        {
            public byte byMountType; //0～保留,1~NFS, 2~ SMB/CIFS
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_MOUNT_PARAM_UNION uMountParam;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_MOUNTMETHOD_PARAM_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 56, ArraySubType = UnmanagedType.I1)]
            public byte[] uLen; //联合体结构大小   
        }

        //网络硬盘结构配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SINGLE_NET_DISK_INFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//保留
            public NET_DVR_IPADDR struNetDiskAddr;//网络硬盘地址
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PATHNAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDirectory;// PATHNAME_LEN = 128
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 68, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;//保留
        }

        public const int MAX_NET_DISK = 16;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NET_DISKCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NET_DISK, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SINGLE_NET_DISK_INFO[] struNetDiskParam;
        }

        //事件类型
        //主类型
        public enum MAIN_EVENT_TYPE
        {
            EVENT_MOT_DET = 0,//移动侦测
            EVENT_ALARM_IN = 1,//报警输入
            EVENT_VCA_BEHAVIOR = 2,//异常行为识别
            EVENT_INQUEST = 3,       //审讯事件
            EVENT_VCA_DETECTION = 4, //智能侦测
            EVENT_STREAM_INFO = 100  //流ID信息
        }

        public const int INQUEST_START_INFO = 0x1001;      /*讯问开始信息*/
        public const int INQUEST_STOP_INFO = 0x1002;       /*讯问停止信息*/
        public const int INQUEST_TAG_INFO = 0x1003;       /*重点标记信息*/
        public const int INQUEST_SEGMENT_INFO = 0x1004;      /*审讯片断状态信息*/

        public enum VCA_DETECTION_MINOR_TYPE:uint
        {
            EVENT_VCA_TRAVERSE_PLANE = 1,        //越警侦测
            EVENT_FIELD_DETECTION,		     //区域入侵侦测
            EVENT_AUDIO_INPUT_ALARM,      //音频输入异常
            EVENT_SOUND_INTENSITY_ALARM,   //声强突变侦测
            EVENT_FACE_DETECTION,             //人脸侦测
            EVENT_VIRTUAL_FOCUS_ALARM, /*虚焦侦测*/
            EVENT_SCENE_CHANGE_ALARM, /*场景变更侦测*/
            EVENT_ALL = 0xffffffff				//表示全部
        }

        //异常行为识别主类型对应的此类型， 0xffff表示全部
        public enum BEHAVIOR_MINOR_TYPE
        {
            EVENT_TRAVERSE_PLANE = 0,// 穿越警戒面,
            EVENT_ENTER_AREA,//目标进入区域,支持区域规则
            EVENT_EXIT_AREA,//目标离开区域,支持区域规则
            EVENT_INTRUSION,// 周界入侵,支持区域规则
            EVENT_LOITER,//徘徊,支持区域规则
            EVENT_LEFT_TAKE,//丢包捡包,支持区域规则
            EVENT_PARKING,//停车,支持区域规则
            EVENT_RUN,//奔跑,支持区域规则
            EVENT_HIGH_DENSITY,//区域内人员密度,支持区域规则
            EVENT_STICK_UP,//贴纸条,支持区域规则
            EVENT_INSTALL_SCANNER,//安装读卡器,支持区域规则
            EVENT_OPERATE_OVER_TIME,        // 操作超时
            EVENT_FACE_DETECT,              // 异常人脸
            EVENT_LEFT,                     // 物品遗留
            EVENT_TAKE,                      // 物品拿取
            EVENT_LEAVE_POSITION,         //离岗事件
            EVENT_TRAIL_INFO = 16,            //尾随
            EVENT_FALL_DOWN_INFO = 19,                 //倒地
            EVENT_OBJECT_PASTE = 20,		// 异物粘贴区域
            EVENT_FACE_CAPTURE_INFO = 21,                //正常人脸
            EVENT_MULTI_FACES_INFO = 22,                  //多张人脸
            EVENT_AUDIO_ABNORMAL_INFO = 23,             //声强突变
            EVENT_DETECT = 24     			   //智能侦测
        }

        // 主类型100，对应的小类型
        public enum STREAM_INFO_MINOR_TYPE
        {
            EVENT_STREAM_ID = 0,				// 流ID
            EVENT_TIMING = 1,					// 定时录像
            EVENT_MOTION_DETECT = 2,			// 移动侦测
            EVENT_ALARM = 3,					// 报警录像
            EVENT_ALARM_OR_MOTION_DETECT = 4,	// 报警或移动侦测
            EVENT_ALARM_AND_MOTION_DETECT = 5,	// 报警和移动侦测
            EVENT_COMMAND_TRIGGER = 6,			// 命令触发
            EVENT_MANNUAL = 7,					// 手动录像
            EVENT_BACKUP_VOLUME = 8				// 存档卷录像
        }

        //邦诺CVR
        public const int MAX_ID_COUNT = 256;
        public const int MAX_STREAM_ID_COUNT = 1024;
        public const int STREAM_ID_LEN = 32;
        public const int PLAN_ID_LEN = 32;

        // 流信息 - 72字节长
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_STREAM_INFO
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = STREAM_ID_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byID;      //ID数据
            public uint dwChannel;                //关联设备通道，等于0xffffffff时，表示不关联
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                //保留
            public void Init()
            {
                byID = new byte[STREAM_ID_LEN];
                byRes = new byte[32];
            }
        }

        //事件搜索条件 200-04-07 9000_1.1
        public const int SEARCH_EVENT_INFO_LEN = 300;

        //报警输入
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_ALARM_BYBIT
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmInNo;//报警输入号，byAlarmInNo[0]若置1则表示查找由报警输入1触发的事件
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SEARCH_EVENT_INFO_LEN - MAX_ALARMIN_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                byAlarmInNo = new byte[MAX_ALARMIN_V30];
                byRes = new byte[SEARCH_EVENT_INFO_LEN - MAX_CHANNUM_V30];
            }
        }

        //报警输入 按值表示
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_ALARM_BYVALUE
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.U2)]
            public ushort[] wAlarmInNo;//报警输入号，byAlarmInNo[0]若置1则表示查找由报警输入1触发的事件
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                wAlarmInNo = new ushort[128];
                byRes = new byte[44];
            }
        }

        //移动侦测
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_MOTION_BYBIT
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byMotDetChanNo;//移动侦测通道，byMotDetChanNo[0]若置1则表示查找由通道1发生移动侦测触发的事件
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SEARCH_EVENT_INFO_LEN - MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                byMotDetChanNo = new byte[MAX_CHANNUM_V30];
                byRes = new byte[SEARCH_EVENT_INFO_LEN - MAX_CHANNUM_V30];
            }
        }

        //移动侦测--按值
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_MOTION_BYVALUE
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.U2)]
            public ushort[] wMotDetChanNo;//报警输入号，byAlarmInNo[0]若置1则表示查找由报警输入1触发的事件
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 172, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                wMotDetChanNo = new ushort[64];
                byRes = new byte[172];
            }
        }

        //异常行为识别
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_VCA_BYBIT
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byChanNo;//触发事件的通道
            public byte byRuleID;//规则ID，0xff表示全部
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 235, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//保留

            public void init()
            {
                byChanNo = new byte[MAX_CHANNUM_V30];
                byRes1 = new byte[235];
            }
        }

        //异常行为识别--按值方式查找 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_VCA_BYVALUE
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.U2)]
            public ushort[] wChanNo;	//触发事件的通道			
            public byte byRuleID;      //异常行为识别类型，规则0xff表示全部，从0开始
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 171, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;	 /*保留*/
            public void init()
            {
                wChanNo = new ushort[64];
                byRes = new byte[171];
            }
        }

        //审讯事件搜索条件
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_INQUEST_PARAM
		{			
            public byte byRoomIndex;    //审讯室编号,从1开始
			[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 299, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     //保留
            public void init()
            {
                byRes = new byte[299];
            }
		}

        //智能侦测查找条件
		[StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_VCADETECT_BYBIT
		{
			[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byChan;//触发智能侦测的通道号，按数组下标表示，byChan[0]若置1则表示查找由通道1发生移动侦测触发的事件 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     //保留
            public void init()
            {
                byChan = new byte[256];
                byRes = new byte[44];
            }
		}
		
        //智能侦测查找条件 ，通道号按值表示
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_VCADETECT_BYVALUE
		{
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30-1, ArraySubType = UnmanagedType.U4)]
            public uint[] dwChanNo;// 触发通道号,按值表示，0xffffffff无效，且后续数据也表示无效值
            public byte byAll;//0-表示不是全部，1-表示全部。
			[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 47, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public void init()
            {
                dwChanNo = new uint[MAX_CHANNUM_V30 - 1];
                byRes = new byte[47];
            }
		}

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_STREAMID_PARAM
        {
            public NET_DVR_STREAM_INFO struIDInfo; // 流id信息，72字节长
            public uint dwCmdType;  // 外部触发类型，NVR接入云存储使用
            public byte byBackupVolumeNum; //存档卷号，CVR使用
			[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 223, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public void init()
            {
                struIDInfo.Init();
                byRes = new byte[223];
            }
		}

        [StructLayout(LayoutKind.Explicit)]
        public struct SEARCH_EVENT_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SEARCH_EVENT_INFO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byLen;
           /* [FieldOffsetAttribute(0)]
            public EVENT_ALARM_BYBIT struAlarmParam;
            [FieldOffsetAttribute(0)]
            public EVENT_ALARM_BYVALUE struAlarmParamByValue;
            [FieldOffsetAttribute(0)]
            public EVENT_MOTION_BYBIT struMotionParam;
            [FieldOffsetAttribute(0)]
            public EVENT_MOTION_BYVALUE struMotionParamByValue;
            [FieldOffsetAttribute(0)]
            public EVENT_VCA_BYBIT struVcaParam;
            [FieldOffsetAttribute(0)]
            public EVENT_VCA_BYVALUE struVcaParamByValue;
            [FieldOffsetAttribute(0)]
            public EVENT_INQUEST_PARAM struInquestParam;
            [FieldOffsetAttribute(0)]
            public EVENT_VCADETECT_BYBIT struVCADetectByBit;
            [FieldOffsetAttribute(0)]
            public EVENT_VCADETECT_BYVALUE struVCADetectByValue;
            [FieldOffsetAttribute(0)]
            public EVENT_STREAMID_PARAM struStreamIDParam;
            * */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SEARCH_EVENT_PARAM
        {
            public ushort wMajorType;//0-移动侦测，1-报警输入, 2-智能事件
            public ushort wMinorType;//搜索次类型- 根据主类型变化，0xffff表示全部
            public NET_DVR_TIME struStartTime;//搜索的开始时间，停止时间: 同时为(0, 0) 表示从最早的时间开始，到最后，最前面的4000个事件
            public NET_DVR_TIME struEndTime;
            public byte byLockType;		// 0xff-全部，0-未锁，1-锁定
            public byte byValue;			//0-按位表示，1-按值表示
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 130, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//保留
            public SEARCH_EVENT_UNION uSeniorPara;
        }

        //报警输入结果
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_ALARM_RET
        {
            public uint dwAlarmInNo;//报警输入号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SEARCH_EVENT_INFO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                byRes = new byte[SEARCH_EVENT_INFO_LEN];
            }
        }
        //移动侦测结果
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_MOTION_RET
        {
            public uint dwMotDetNo;//移动侦测通道
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SEARCH_EVENT_INFO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                byRes = new byte[SEARCH_EVENT_INFO_LEN];
            }
        }
        //异常行为识别结果 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_VCA_RET
        {
            public uint dwChanNo;//触发事件的通道号
            public byte byRuleID;//规则ID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//保留
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;//规则名称
            public NET_VCA_EVENT_UNION uEvent;//行为事件参数，wMinorType = VCA_EVENT_TYPE决定事件类型

            public void init()
            {
                byRes1 = new byte[3];
                byRuleName = new byte[NAME_LEN];
            }
        }

        //审讯事件查询结果 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_INQUEST_RET
        {
            public byte byRoomIndex;  //审讯室编号,从1开始
            public byte byDriveIndex; //刻录机编号,从1开始
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  //保留            
            public uint dwSegmentNo;     //本片断在本次审讯中的序号,从1开始 
            public ushort wSegmetSize;     //本片断的大小, 单位M 
            public ushort wSegmentState;   //本片断状态 0 刻录正常，1 刻录异常，2 不刻录审讯
			[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 288, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;     //保留

            public void init()
            {
                byRes1 = new byte[6];
                byRes2 = new byte[288];
            }
        }

        //流id录像查询结果
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_STREAMID_RET
        {
            public uint dwRecordType;	//录像类型 0-定时录像 1-移动侦测 2-报警录像 3-报警|移动侦测 4-报警&移动侦测 5-命令触发 6-手动录像 7-震动报警 8-环境触发 9-智能报警 10-回传录像
            public uint dwRecordLength;	//录像大小
            public byte byLockFlag;    // 锁定标志 0：没锁定 1：锁定
            public byte byDrawFrameType;    // 0：非抽帧录像 1：抽帧录像
			[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
			[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byFileName; 	//文件名
            public uint dwFileIndex;    		// 存档卷上的文件索引
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                byRes1 = new byte[2];
                byFileName = new byte[NAME_LEN];
                byRes = new byte[256];
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct SEARCH_EVENT_RET
        {
            [FieldOffset(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 304, ArraySubType = UnmanagedType.I1)]
            public byte[] byEventRetUnion;
            /*
            [FieldOffset(0)]
            public EVENT_ALARM_RET struAlarmRet;
            [FieldOffset(0)]
            public EVENT_MOTION_RET struMotionRet;
            [FieldOffset(0)]
            public EVENT_VCA_RET struVcaRet;
            [FieldOffset(0)]
            public EVENT_INQUEST_RET struInquestRet;
            [FieldOffset(0)]
            public EVENT_STREAMID_RET struStreamIDRet;
             * */
        }
        //查找返回结果
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SEARCH_EVENT_RET
        {
            public ushort wMajorType;//主类型MA
            public ushort wMinorType;//次类型
            public NET_DVR_TIME struStartTime;//事件开始的时间
            public NET_DVR_TIME struEndTime;//事件停止的时间，脉冲事件时和开始时间一样
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byChan;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 36, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public SEARCH_EVENT_RET uSeniorRet;

            public void init()
            {
                byChan = new byte[MAX_CHANNUM_V30];
                byRes = new byte[36];
            }
        }

        //SDK_V35  2009-10-26

        // 标定配置类型
        public enum tagCALIBRATE_TYPE
        {
            PDC_CALIBRATE  = 0x01,  // PDC 标定
            BEHAVIOR_OUT_CALIBRATE  = 0x02, //行为室外场景标定  
            BEHAVIOR_IN_CALIBRATE = 0x03,    // 行为室内场景标定 
            ITS_CALBIRETE       = 0x04      //  交通事件标定
        }

        public const int MAX_RECT_NUM = 6;
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECT_LIST
        {	
            public byte byRectNum;    // 矩形框的个数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  //保留字节 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RECT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_RECT[] struVcaRect; // 最大为6个Rect 
        }

        // PDC 标定参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_CALIBRATION
        {
            public NET_DVR_RECT_LIST struRectList;       // 标定矩形框列表
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 120, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;       // 保留字节 
        }

        // 标定线的属性类别，用来表示当前标定线在实际表示的是高度线还是长度线。
        public enum LINE_MODE
        {
            HEIGHT_LINE,        //高度样本线
            LENGTH_LINE        //长度样本线
        }
        /*在设置标定信息的时候，如果相应位设置了使能，并设置相关参数，若没有设置使能，则标定后可以获取相关的摄像机参数*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CAMERA_PARAM
        {
            public byte byEnableHeight;     // 是否使能设置摄像机高度线
            public byte byEnableAngle;      // 是否使能设置摄像机俯仰角度
            public byte byEnableHorizon;    // 是否使能设置摄像机地平线
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   // 保留字节 
            public float  fCameraHeight;    // 摄像机高度
            public float  fCameraAngle;     // 摄像机俯仰角度
            public float  fHorizon;         // 场景中的地平线
        }
        
        /*当fValue表示目标高度的时候，struStartPoint和struEndPoint分别表示目标头部点和脚部点。
         * 当fValue表示线段长度的时候，struStartPoint和struEndPoint分别表示线段起始点和终点，
         * mode表示当前样本线表示高度线还是长度线。*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LINE_SEGMENT
        {
            public byte byLineMode;     // 参照 LINE_MODE
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;       // 保留字节 
            public NET_VCA_POINT   struStartPoint;  
            public NET_VCA_POINT   struEndPoint;
            public float fValue;
        }

        public const int MAX_LINE_SEG_NUM = 8;

        /*标定样本线目前需要4-8调样本线，以获取摄像机相关参数*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BEHAVIOR_OUT_CALIBRATION
        {
            public uint dwLineSegNum;          // 样本线个数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LINE_SEG_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_LINE_SEGMENT[]  struLineSegment;    // 样本线最大个数
            public NET_DVR_CAMERA_PARAM  struCameraParam;    // 摄像机参数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*该结构体表示IAS智能库标定样本，其中包括一个目标框和一条对应的高度标定线；
         * 目标框为站立的人体外接矩形框；高度线样本标识从人头顶点到脚点的标定线；用归一化坐标表示；*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IN_CAL_SAMPLE
        {
            public NET_VCA_RECT struVcaRect;   // 目标框
            public NET_DVR_LINE_SEGMENT struLineSegment;    // 高度标定线
        }

        public const int MAX_SAMPLE_NUM = 5;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BEHAVIOR_IN_CALIBRATION 
        {
            public uint dwCalSampleNum;      //  标定样本个数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SAMPLE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IN_CAL_SAMPLE[]  struCalSample; // 标定样本最大个数
            public NET_DVR_CAMERA_PARAM    struCameraParam;    // 摄像机参数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int CALIB_PT_NUM = 4;
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ITS_CALIBRATION
        {
            public uint dwPointNum; //标定点数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CALIB_PT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_POINT[] struPoint; //图像坐标
            public float fWidth;
            public float fHeight;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;        // 保留字节
        }

        // 标定参数联合体
        // 后续的相关标定参数可以放在该结构里面
        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_CALIBRATION_PRARM_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 240, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //联合体结构大小
            /*[FieldOffsetAttribute(0)]
            public NET_DVR_PDC_CALIBRATION struPDCCalibration;  //PDC 标定参数
            [FieldOffsetAttribute(0)]
            public NET_DVR_BEHAVIOR_OUT_CALIBRATION  struBehaviorOutCalibration;  //  行为室外场景标定  主要应用于IVS等
            [FieldOffsetAttribute(0)]
            public NET_DVR_BEHAVIOR_IN_CALIBRATION  struBehaviorInCalibration;     // 行为室内场景标定，主要应用IAS等 
            [FieldOffsetAttribute(0)]
            public NET_DVR_ITS_CALIBRATION struITSCalibration;
             * */
        }

        // 标定配置结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CALIBRATION_CFG
        {
            public uint dwSize;               //标定结构大小
            public byte byEnable;           // 是否启用标定
            public byte byCalibrationType;    // 标定类型 根据不同类型在联合体类选择不同的标定 参考CALIBRATE_TYPE
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_CALIBRATION_PRARM_UNION uCalibrateParam;  // 标定参数联合体
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //流量统计方向结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_ENTER_DIRECTION
        {
            public NET_VCA_POINT struStartPoint; //流量统计方向起始点
            public NET_VCA_POINT struEndPoint;    // 流量统计方向结束点 
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_RULE_CFG
        {
            public uint dwSize;              //结构大小
            public byte byEnable;             // 是否激活规则;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;       // 保留字节 
            public NET_VCA_POLYGON  struPolygon;            // 多边形
            public NET_DVR_PDC_ENTER_DIRECTION  struEnterDirection;    // 流量进入方向
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_RULE_CFG_V41
        {
            public uint dwSize;              //结构大小
            public byte byEnable;             // 是否激活规则;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;       // 保留字节 
            public NET_VCA_POLYGON struPolygon;            // 多边形
            public NET_DVR_PDC_ENTER_DIRECTION  struEnterDirection;    // 流量进入方向
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME struAlarmTime;//布防时间
            public NET_DVR_TIME_EX struDayStartTime; //白天开始时间，时分秒有效
            public NET_DVR_TIME_EX struNightStartTime; //夜晚开始时间，时分秒有效
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;       // 保留字节
        }

        //试用版信息结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRIAL_VERSION_CFG
        {
            public uint dwSize;
            public ushort wReserveTime; //试用期剩余时间，0xffff表示无效，单位：天
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 62, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SYN_CHANNEL_NAME_PARAM
        {
            public uint dwSize;
            public uint dwChannel; //通道号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; 
        }


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TIME_SEGMENT
        {
            public NET_DVR_SIMPLE_DAYTIME struBeginTime;  //begin time
            public NET_DVR_SIMPLE_DAYTIME struEndTime;    //end time
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SINGLE_PLAN_SEGMENT
        {
            public byte byEnable; //whether to enable, 1-enable, 0-disable
            public byte byDoorStatus; //door status(control ladder status),0-invaild, 1-always open(free), 2-always close(forbidden), 3-ordinary status(used by door plan)
            public byte byVerifyMode;  //verify method, 0-invaild, 1-swipe card, 2-swipe card +password(used by card verify ) 3-swipe card(used by card verify) 4-swipe card or password(used by card verify)
            //5-fingerprint, 6-fingerprint and passwd, 7-fingerprint or swipe card, 8-fingerprint and swipe card, 9-fingerprint and passwd and swipe card,
            //10-face or finger print or swipe card or password,11-face and finger print,12-face and password,13-face and swipe card,14-face,15-employee no and password,
            //16-finger print or password,17-employee no and finger print,18-employee no and finger print and password,
            //19-face and finger print and swipe card,20-face and password and finger print,21-employee no and face,22-face or face and swipe card
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_TIME_SEGMENT struTimeSegment;  //time segment parameter 

            public void Init()
            {
                byRes = new byte[5];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WEEK_PLAN_CFG
        {
            public uint dwSize;
            public byte byEnable;  //whether to enable, 1-enable, 0-disable
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SINGLE_PLAN_SEGMENT[] struPlanCfg; //week plan parameter
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;

            public void Init()
            {
                struPlanCfg = new NET_DVR_SINGLE_PLAN_SEGMENT[MAX_DAYS * MAX_TIMESEGMENT_V30];
                foreach (NET_DVR_SINGLE_PLAN_SEGMENT singlStruPlanCfg in struPlanCfg)
                {
                    singlStruPlanCfg.Init();
                }
                byRes1 = new byte[3];
                byRes2 = new byte[16];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDAY_PLAN_CFG
        {
            public uint dwSize;
            public byte byEnable;  //whether to enable, 1-enable, 0-disable
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_DATE struBeginDate;  //holiday begin date
            public NET_DVR_DATE struEndDate;  //holiday end date
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SINGLE_PLAN_SEGMENT[] struPlanCfg;  //time segment parameter 
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] byRes2;

            public void Init()
            {
                struPlanCfg = new NET_DVR_SINGLE_PLAN_SEGMENT[MAX_TIMESEGMENT_V30];
                foreach (NET_DVR_SINGLE_PLAN_SEGMENT singlStruPlanCfg in struPlanCfg)
                {
                    singlStruPlanCfg.Init();
                }
                byRes1 = new byte[3];
                byRes2 = new byte[16];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDAY_GROUP_CFG
        {
            public uint dwSize;
            public byte byEnable; //whether to enable, 1-enable, 0-disable 
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HOLIDAY_GROUP_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byGroupName; //holiday group name 
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = MAX_HOLIDAY_PLAN_NUM, ArraySubType = UnmanagedType.U4)]
            public uint[] dwHolidayPlanNo; //holiday plan No. fill in from the front side, invalid when meet zero.
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;

            public void Init()
            {
                byGroupName = new byte[HOLIDAY_GROUP_NAME_LEN];
                dwHolidayPlanNo = new uint[MAX_HOLIDAY_PLAN_NUM];
                byRes1 = new byte[3];
                byRes2 = new byte[32];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLAN_TEMPLATE
        {
            public uint dwSize;
            public byte byEnable; //whether to enable, 1-enable, 0-disable 
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = TEMPLATE_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byTemplateName; //template name 
            public uint dwWeekPlanNo; //week plan no. 0 invalid
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = MAX_HOLIDAY_GROUP_NUM, ArraySubType = UnmanagedType.U4)]
            public uint[] dwHolidayGroupNo; //holiday group. fill in from the front side, invalid when meet zero.
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;

            public void Init()
            {
                byTemplateName = new byte[TEMPLATE_NAME_LEN];
                dwHolidayGroupNo = new uint[MAX_HOLIDAY_GROUP_NUM];
                byRes1 = new byte[3];
                byRes2 = new byte[32];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDAY_PLAN_COND
        {
            public uint dwSize;
            public uint dwHolidayPlanNumber; //Holiday plan number 
            public ushort wLocalControllerID; //On the controller serial number [1, 64]
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 106, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public void Init()
            {
                byRes = new byte[106];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WEEK_PLAN_COND
        {
            public uint dwSize;
            public uint dwWeekPlanNumber; //Week plan number 
            public ushort wLocalControllerID; //On the controller serial number [1, 64]
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 106, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void Init()
            {
                byRes = new byte[106];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDAY_GROUP_COND
        {
            public uint dwSize;
            public uint dwHolidayGroupNumber; //Holiday group number 
            public ushort wLocalControllerID; //On the controller serial number [1, 64]
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 106, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void Init()
            {
                byRes = new byte[106];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLAN_TEMPLATE_COND
        {
            public uint dwSize;
            public uint dwPlanTemplateNumber; //Plan template number, starting from 1, the maximum value from the entrance guard capability sets 
            public ushort wLocalControllerID; //On the controller serial number[1,64], 0 is invalid 
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 106, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void Init()
            {
                byRes = new byte[106];
            }
        }


        public const int MAX_TIMESEGMENT_V30 = 8; //Maximum number of time segments in 9000 DVR's guard schedule
        public const int HOLIDAY_GROUP_NAME_LEN = 32;  //holiday group name len
        public const int MAX_HOLIDAY_PLAN_NUM = 16;  //holiday max plan number
        public const int TEMPLATE_NAME_LEN = 32; //plan template name len 
        public const int MAX_HOLIDAY_GROUP_NUM = 16;   //plan template max group number

        public const int NET_DVR_GET_WEEK_PLAN_CFG = 2100; //get door status week plan config 
        public const int NET_DVR_SET_WEEK_PLAN_CFG = 2101; //set door status week plan config 
        public const int NET_DVR_GET_DOOR_STATUS_HOLIDAY_PLAN = 2102; //get door status holiday week plan config 
        public const int NET_DVR_SET_DOOR_STATUS_HOLIDAY_PLAN = 2103; //set door status holiday week plan config
        public const int NET_DVR_GET_DOOR_STATUS_HOLIDAY_GROUP = 2104; //get door holiday group parameter
        public const int NET_DVR_SET_DOOR_STATUS_HOLIDAY_GROUP = 2105; //set door holiday group parameter
        public const int NET_DVR_GET_DOOR_STATUS_PLAN_TEMPLATE = 2106; //get door status plan template parameter
        public const int NET_DVR_SET_DOOR_STATUS_PLAN_TEMPLATE = 2107; //set door status plan template parameter
        public const int NET_DVR_GET_VERIFY_WEEK_PLAN = 2124; //get reader card verfy week plan
        public const int NET_DVR_SET_VERIFY_WEEK_PLAN = 2125; //set reader card verfy week plan
        public const int NET_DVR_GET_CARD_RIGHT_WEEK_PLAN = 2126;  //get card right week plan 
        public const int NET_DVR_SET_CARD_RIGHT_WEEK_PLAN = 2127; //set card right week plan 
        public const int NET_DVR_GET_VERIFY_HOLIDAY_PLAN = 2128; //get card reader verify holiday plan 
        public const int NET_DVR_SET_VERIFY_HOLIDAY_PLAN = 2129; //set card reader verify holiday plan 
        public const int NET_DVR_GET_CARD_RIGHT_HOLIDAY_PLAN = 2130; //get card right holiday plan 
        public const int NET_DVR_SET_CARD_RIGHT_HOLIDAY_PLAN = 2131; //set card right holiday plan 
        public const int NET_DVR_GET_VERIFY_HOLIDAY_GROUP = 2132; //get card reader verify holiday group 
        public const int NET_DVR_SET_VERIFY_HOLIDAY_GROUP = 2133; //set card reader verify holiday group 
        public const int NET_DVR_GET_CARD_RIGHT_HOLIDAY_GROUP = 2134; //get card right holiday group 
        public const int NET_DVR_SET_CARD_RIGHT_HOLIDAY_GROUP = 2135; //set card right holiday group 
        public const int NET_DVR_GET_VERIFY_PLAN_TEMPLATE = 2136; //get card reader verify plan template 
        public const int NET_DVR_SET_VERIFY_PLAN_TEMPLATE = 2137; //set card reader verify plan template 
        public const int NET_DVR_GET_CARD_RIGHT_PLAN_TEMPLATE = 2138; //get card right plan template
        public const int NET_DVR_SET_CARD_RIGHT_PLAN_TEMPLATE = 2139; //set card right plan template
        // V50
        public const int NET_DVR_GET_CARD_RIGHT_WEEK_PLAN_V50 = 2304;  //Access card right V50 weeks plan parameters
        public const int NET_DVR_SET_CARD_RIGHT_WEEK_PLAN_V50 = 2305;  //Set card right V50 weeks plan parameters 
        public const int NET_DVR_GET_CARD_RIGHT_HOLIDAY_PLAN_V50 = 2310;  //Access card right parameters V50 holiday plan  
        public const int NET_DVR_SET_CARD_RIGHT_HOLIDAY_PLAN_V50 = 2311;  //Set card right parameters V50 holiday plan
        public const int NET_DVR_GET_CARD_RIGHT_HOLIDAY_GROUP_V50 = 2316; //Access card right parameters V50 holiday group
        public const int NET_DVR_SET_CARD_RIGHT_HOLIDAY_GROUP_V50 = 2317; //Set card right parameters V50 holiday group
        public const int NET_DVR_GET_CARD_RIGHT_PLAN_TEMPLATE_V50 = 2322; //Access card right parameters V50 plan template
        public const int NET_DVR_SET_CARD_RIGHT_PLAN_TEMPLATE_V50 = 2323; //Set card right parameters V50 plan template

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RESET_COUNTER_CFG
        {
            public uint dwSize;
            public byte byEnable; //是否启用，0-不启用，1-启用
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_TIME_EX[] struTime;//数据清零时间，时分秒有效
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; 
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VCA_CTRLINFO_COND
        {
            public uint dwSize;
            public NET_DVR_STREAM_INFO  struStreamInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VCA_CTRLINFO_CFG
        {
            public uint dwSize;
            public byte byVCAEnable;     //是否开启智能
            public byte byVCAType;       //智能能力类型，VCA_CHAN_ABILITY_TYPE 
            public byte byStreamWithVCA; //码流中是否带智能信息
            public byte byMode;			//模式，ATM 能力时参照VCA_CHAN_MODE_TYPE ,TFS 能力时参照 TFS_CHAN_MODE_TYPE，异常行为识别完整版时参照BEHAVIOR_SCENE_MODE_TYPE
            public byte byControlType;   //控制类型，按位表示，0-否，1-是
	                        //byControlType &1 是否启用抓拍功能
                            //byControlType &2 是否启用联动前端设备
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 83, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; 		//保留，设置为0
        }

        /*设置人流量统计参数  复用行为内部关键字参数
         * HUMAN_GENERATE_RATE
         * 目标生成速度参数，控制PDC库生成目标的速度。速度越快，目标越容易生成。
         * 当输入视频光照条件较差，对比度较低时，或者设置的规则区域较小时，应加快目标生成速度， 避免目标的漏检；
         * 当输入视频中对比度较高时，或者规则区域较大时，应该降低目标生成速度，以减少误检。
         * 目标生成速度参数共有5级，1级速度最慢，5级最快，默认参数为3。
         *
         * DETECT_SENSITIVE
         * 目标检测灵敏度控制参数，控制PDC库中一个矩形区域被检测为目标的灵敏度。
         * 灵敏度越高，矩形区域越容易被检测为目标，灵敏度越低则越难检测为目标。
         * 当输入视频光照条件较差，对比度较低时，应提高检测灵敏度， 避免目标的漏检；
         * 当输入视频中对比度较高时，应该降低检测灵敏度，以减少误检。
         * 对应参数共有5级，级别1灵敏度最低，5级最高，默认级别为3。
         * 
         * TRAJECTORY_LEN
         * 轨迹生成长度控制参数，表示生成轨迹时要求目标的最大位移像素。
         * 对应参数共有5级，级别1，生成长度最长，轨迹生成最慢，5级生成长度最短，轨迹生成最快，默认级别为3。
         * 
         * TRAJECT_CNT_LEN
         * 轨迹计数长度控制参数，表示轨迹计数时要求目标的最大位移像素。
         * 对应参数共有5级，级别1，计数要求长度最长，轨迹计数最慢，5级计数要求长度最短，轨迹计数最快，默认级别为3。
         * 
         * PREPROCESS
         * 图像预处理控制参数，0 - 不处理；1 - 处理。默认为0；
         * 
         * CAMERA_ANGLE
         * 摄像机角度输入参数， 0 - 倾斜； 1 - 垂直。默认为0；
         */

        public enum PDC_PARAM_KEY
        {
            HUMAN_GENERATE_RATE = 50,  // 目标生成速度 从50开始
            DETECT_SENSITIVE    = 51,  // 检测灵敏度
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_TARGET_INFO
        {
            public uint dwTargetID;                 // 目标id 
            public NET_VCA_RECT struTargetRect;    // 目标框
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;      // 保留字节
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_TARGET_IN_FRAME
        {
            public byte byTargetNum;                   //目标个数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] yRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TARGET_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PDC_TARGET_INFO[]  struTargetInfo;   //目标信息数组
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                  // 保留字节
        }

        //单帧统计结果时使用
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct UNION_STATFRAME
        {
            public uint dwRelativeTime;     // 相对时标
            public uint dwAbsTime;          // 绝对时标
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 92, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct UNION_STATTIME
        {
            public NET_DVR_TIME tmStart; // 统计起始时间 
            public NET_DVR_TIME tmEnd;  //  统计结束时间 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 92, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct UNION_PDCPARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 140, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_ALRAM_INFO
        {
            public uint dwSize;           // PDC人流量报警上传结构体大小
            public byte byMode;            // 0 单帧统计结果 1最小时间段统计结果  
            public byte byChannel;           // 报警上传通道号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;         // 保留字节   
            public NET_VCA_DEV_INFO struDevInfo;		        //前端设备信息
            public UNION_PDCPARAM uStatModeParam;
            public uint dwLeaveNum;        // 离开人数
            public uint dwEnterNum;        // 进入人数			
            public byte byBrokenNetHttp;     //断网续传标志位，0-不是重传数据，1-重传数据
            public byte byRes3;
            public ushort wDevInfoIvmsChannelEx;     //与NET_VCA_DEV_INFO里的byIvmsChannel含义相同，能表示更大的值。老客户端用byIvmsChannel能继续兼容，但是最大到255。新客户端版本请使用wDevInfoIvmsChannelEx
            public uint dwPassingNum;        // 经过人数（进入区域后徘徊没有触发进入、离开的人数）
            public uint dwChildLeaveNum;        // 小孩离开人数
            public uint dwChildEnterNum;        // 小孩进入人数
            public uint dwDuplicatePeople;        // 重复人数
            public uint dwXmlLen;//XML透传数据长度, 即EventNotificationAlert XML Block的数据长度
            public IntPtr pXmlBuf; // XML报警信息指针,其XML对应到EventNotificationAlert XML Block
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;           // 保留字节
        }

        //人流量信息查询
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_QUERY
        {
            public NET_DVR_TIME tmStart;
            public NET_DVR_TIME tmEnd;
            public uint dwLeaveNum;
            public uint dwEnterNum; 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PTZ_POSITION
        {
            // 是否启用场景，在设置场景行为规则的时候该字段无效，在设置球机本地配置场景位置信息时作为使能位
            public byte byEnable;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  //保留
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPtzPositionName; //场景位置名称
            public NET_DVR_PTZPOS struPtzPos; //ptz 坐标
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POSITION_RULE_CFG
        {
            public uint dwSize;             // 结构大小 
            public NET_DVR_PTZ_POSITION    struPtzPosition;    // 场景位置信息
            public NET_VCA_RULECFG         struVcaRuleCfg;     //行为规则配置
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 80, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;         // 保留字节
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POSITION_RULE_CFG_V41
        {
            public uint dwSize;             // 结构大小 
            public NET_DVR_PTZ_POSITION  struPtzPosition;    // 场景位置信息
            public NET_VCA_RULECFG_V41   struVcaRuleCfg;     //行为规则配置
            public byte byTrackEnable; //是否启用跟踪
            public byte byRes1;
            public ushort wTrackDuration; //跟踪持续时间，单位s
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 76, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;         // 保留字节
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LIMIT_ANGLE
        {
            public byte byEnable;	// 是否启用场景限位功能
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_PTZPOS  struUp;     // 上限位
            public NET_DVR_PTZPOS  struDown;   // 下限位
            public NET_DVR_PTZPOS  struLeft;   // 左限位
            public NET_DVR_PTZPOS  struRight;  // 右限位
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POSITION_INDEX
        {
            public byte byIndex;    // 场景索引
            public byte byRes1;
            public ushort wDwell;	// 停留时间 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;   // 保留字节
        }

        public const int MAX_POSITION_NUM = 10;
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POSITION_TRACK_CFG
        {
            public uint dwSize;
            public byte byNum; // 场景个数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_POSITION_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_POSITION_INDEX[]   struPositionIndex;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }
        
        //巡航路径场景信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PATROL_SCENE_INFO
        {
            public ushort wDwell;         // 停留时间 30-300
            public byte byPositionID;   // 场景号1-10，默认0表示该巡航点不添加场景
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //场景巡航跟踪配置信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PATROL_TRACKCFG
        {
            public uint dwSize;  // 结构大小
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PATROL_SCENE_INFO[] struPatrolSceneInfo;    // 巡航路径
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                              // 保留字节
        }

        //球机本地规则菜单配置结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRACK_PARAMCFG
        {
            public uint dwSize;             // 结构大小
            public ushort wAlarmDelayTime;    // 报警延时时间，目前球机只支持全局入侵 范围1-120秒
            public ushort wTrackHoldTime;     // 报警跟踪持续时间  范围0-300秒
            public byte byTrackMode;        //  参照 IPDOME_TRACK_MODE
            public byte byPreDirection;	// 跟踪方向预判 0-不启用 1-启用
            public byte byTrackSmooth;	    // 跟踪连续  0-不启用 1-启用
            public byte byZoomAdjust;	// 倍率系数调整 参见下表
            public byte byMaxTrackZoom;	//最大跟踪倍率系数,0-表示默认倍率系数,等级6-标定值*1.0(默认),1-5为缩小标定值，值越小，缩小的比例越大,7-15为放大，值越大，放大的比例越大
            public byte byStopTrackWhenFindFace;  //人脸检测到后是否停止跟踪 0-否 1-是
            public byte byStopTrackThreshold;   //跟踪终止评分阈值
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;          //  保留字节                
        }

        //球机机芯参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DOME_MOVEMENT_PARAM
        {
            public ushort wMaxZoom;   // 球机最大倍率系数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 42, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  // 保留字节
        }

        /********************************智能交通事件 begin****************************************/
        public const int MAX_REGION_NUM	= 8;  // 区域列表最大数目
        public const int MAX_TPS_RULE = 8;   // 最大参数规则数目
        public const int MAX_AID_RULE = 8;   // 最大事件规则数目
        public const int MAX_LANE_NUM = 8;   // 最大车道数目

        //交通事件类型
        public enum TRAFFIC_AID_TYPE
        {
            CONGESTION            = 0x01,    //拥堵
            PARKING               = 0x02,    //停车  
            INVERSE               = 0x04,    //逆行
            PEDESTRIAN            = 0x08,    //行人                      
            DEBRIS                = 0x10,    //遗留物 抛洒物碎片 
            SMOKE                 = 0x20,    //烟雾  
	        OVERLINE              = 0x40,     //压线
	        VEHICLE_CONTROL_LIST  = 0x80,  //禁止名单数据
	        SPEED                 = 0x100  //超速
        }
        
        public enum TRAFFIC_SCENE_MODE
        {
	        FREEWAY = 0,	//  高速户外场景
	        TUNNEL,         //  高速隧道场景
	        BRIDGE          //  高速桥梁场景
        }
        
        public enum ITS_ABILITY_TYPE
        {
            ITS_CONGESTION_ABILITY             = 0x01,      //拥堵
            ITS_PARKING_ABILITY                = 0x02,      //停车  
            ITS_INVERSE_ABILITY                = 0x04,      //逆行
            ITS_PEDESTRIAN_ABILITY             = 0x08,      //行人                      
            ITS_DEBRIS_ABILITY                 = 0x10,      //遗留物 抛洒物碎片
            ITS_SMOKE_ABILITY                  = 0x20,      //烟雾-隧道
            ITS_OVERLINE_ABILITY               = 0x40,      //压线
	        ITS_VEHICLE_CONTROL_LIST_ABILITY   = 0x80,		//禁止名单数据
	        ITS_SPEED_ABILITY				   = 0x100,	    //超速	
            ITS_LANE_VOLUME_ABILITY            = 0x010000,  //车道流量
            ITS_LANE_VELOCITY_ABILITY          = 0x020000,  //车道平均速度
            ITS_TIME_HEADWAY_ABILITY           = 0x040000,  //车头时距
            ITS_SPACE_HEADWAY_ABILITY          = 0x080000,  //车头间距
            ITS_TIME_OCCUPANCY_RATIO_ABILITY   = 0x100000,  //车道占有率，（时间上)
            ITS_SPACE_OCCUPANCY_RATIO_ABILITY  = 0x200000,  //车道占有率，百分比计算（空间上)
            ITS_LANE_QUEUE_ABILITY             = 0x400000,  //排队长度
	        ITS_VEHICLE_TYPE_ABILITY           = 0x800000,  //车辆类型
	        ITS_TRAFFIC_STATE_ABILITY          = 0x1000000  //交通状态
        }
        
        // 交通统计参数
        public enum ITS_TPS_TYPE
        {
            LANE_VOLUME           = 0x01,    //车道流量
            LANE_VELOCITY         = 0x02,    //车道速度
            TIME_HEADWAY          = 0x04,    //车头时距
            SPACE_HEADWAY         = 0x08,    //车头间距
            TIME_OCCUPANCY_RATIO  = 0x10,    //车道占有率 (时间上)
            SPACE_OCCUPANCY_RATIO = 0x20,    //车道占有率，百分比计算(空间上)
            QUEUE                 = 0x40,    //排队长度
	        VEHICLE_TYPE          = 0x80,    //车辆类型
	        TRAFFIC_STATE         = 0x100    //交通状态
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_REGION_LIST
        {
            public uint dwSize;	// 结构体大小
            public byte byNum;      // 区域个数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;    // 保留字节
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_REGION_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_POLYGON[] struPolygon; // 区域
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;	// 保留字节
        }

        //方向结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DIRECTION
        {
            public NET_VCA_POINT struStartPoint;   // 方向起始点
            public NET_VCA_POINT struEndPoint;     // 方向结束点 
        }

        //单个车道
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_LANE
        {
            public byte byEnable;  //车道是否启用
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;	   // 保留字节
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byLaneName;       // 车道规则名称
            public NET_DVR_DIRECTION struFlowDirection;// 车道内车流方向
            public NET_VCA_POLYGON struPolygon;		// 车道区域
        }

        //车道配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LANE_CFG
        {
            public uint dwSize;	// 结构体大小
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LANE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_LANE[] struLane;	// 车道参数 数组下标作为车道ID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;	 // 保留字节
        }

        //交通事件参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AID_PARAM
        {
            public ushort wParkingDuration;       // 违停检测灵敏度  10-120s
            public ushort wPedestrianDuration;    // 行人持续时间    1-120s
            public ushort wDebrisDuration;        // 抛洒物持续时间  10-120s
            public ushort wCongestionLength;      // 拥堵长度阈值    5-200（米）
            public ushort wCongestionDuration;    // 拥堵持续参数    10-120s
            public ushort wInverseDuration;       // 逆行持续时间    1-10s
            public ushort wInverseDistance;       // 逆行距离阈值 单位m 范围[2-100] 默认 10米
            public ushort wInverseAngleTolerance; // 允许角度偏差 90-180度,车流与逆行允许的夹角
            public ushort wIllegalParkingTime;    // 违停时间[4,60]，单位：分钟 ,TFS(交通违章取证) 城市模式下
            public ushort wIllegalParkingPicNum;  // 违停图片数量[1,6], TFS(交通违章取证) 城市模式下
            public byte byMergePic;             // 图片拼接,TFS 城市模式下 0- 不拼接 1- 拼接
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;             // 保留字节
        }

        //单条交通事件规则结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_AID_RULE
        {   
            public byte byEnable;                   // 是否启用事件规则
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                  // 保留字节
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;       // 规则名称 
            public uint dwEventType;                // 交通事件检测类型 TRAFFIC_AID_TYPE
            public NET_VCA_SIZE_FILTER struSizeFilter; // 尺寸过滤器
            public NET_VCA_POLYGON     struPolygon;    // 规则区域
            public NET_DVR_AID_PARAM   struAIDParam;   //  事件参数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_2, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[]   struAlarmTime;//布防时间
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	  //处理方式
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;        //报警触发的录象通道,为1表示触发该通道
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //交通事件规则
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AID_RULECFG
        {
            public uint dwSize;                    // 结构体大小 
            public byte byPicProType;              //报警时图片处理方式 0-不处理 非0-上传
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                 // 保留字节
            public NET_DVR_JPEGPARA struPictureParam; //图片规格结构
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AID_RULE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_AID_RULE[]  struOneAIDRule;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //单条交通事件规则结构体(扩展)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_AID_RULE_V41
        {   
            public byte byEnable;                 // 是否启用事件规则
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                // 保留字节
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;     // 规则名称 
            public uint dwEventType;              // 交通事件检测类型 TRAFFIC_AID_TYPE
            public NET_VCA_SIZE_FILTER struSizeFilter;           // 尺寸过滤器
            public NET_VCA_POLYGON struPolygon;              // 规则区域
            public NET_DVR_AID_PARAM struAIDParam;             // 事件参数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;// 布防时间段
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	          //处理方式 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IVMS_IP_CHANNEL, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan; //报警触发的录象通道：1表示触发该通道；0表示不触发
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;               //保留
        }

        //交通事件规则(扩展)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AID_RULECFG_V41
        {
            public uint dwSize;                     // 结构体大小 
            public byte byPicProType;               // 报警时图片处理方式 0-不处理 非0-上传
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                  // 保留字节
            public NET_DVR_JPEGPARA struPictureParam; 	// 图片规格结构
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AID_RULE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_AID_RULE_V41[]  struAIDRule;  //规则数组
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                //保留
        }

        //交通统计参数结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_TPS_RULE
        {
            public byte byEnable;                   //是否使能车道交通规则参数
            public byte byLaneID;		            //车道ID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwCalcType;                 //统计参数类型ITS_TPS_TYPE
            public NET_VCA_SIZE_FILTER struSizeFilter; //尺寸过滤器 
            public NET_VCA_POLYGON struVitrualLoop;    //虚拟线圈
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_2, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//布防时间
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	//处理方式,一般为处理是否上传中心，其他功能不需要
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                         //保留字节
        }

        //交通参数统计规则配置结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_RULECFG
        {
            public uint dwSize;              // 结构大小
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TPS_RULE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_TPS_RULE[] struOneTpsRule; // 下标对应交通参数ID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;         // 保留字节
        }

        //交通统计参数结构体(扩展)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_TPS_RULE_V41
        {
            public byte byEnable;                     //是否使能车道交通规则参数
            public byte byLaneID;		              //车道ID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                    //保留
            public uint dwCalcType;                   // 统计参数类型ITS_TPS_TYPE
            public NET_VCA_SIZE_FILTER  struSizeFilter;  //尺寸过滤器 
            public NET_VCA_POLYGON  struVitrualLoop; //虚拟线圈
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[]  struAlarmTime;//布防时间
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	   //处理方式 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                   // 保留字节
        }

        //交通参数统计规则配置结构体(扩展)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_RULECFG_V41
        {
            public uint dwSize;         // 结构大小
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TPS_RULE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_TPS_RULE_V41[] struOneTpsRule; // 下标对应交通参数ID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     // 保留
        }
        
        //实时信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_PARAM
        {
            public byte byStart;          // 开始码
            public byte byCMD;         // 命令号，01-进入指令，02-离开指令，03-拥堵状态指令(为03时，只有byLaneState和byQueueLen有效)，04-多线圈状态（为04时，wLoopState和wStateMask有效，表示byLane车道上多个线圈的过车状态）
            public ushort wSpaceHeadway;        //车头间距，以米来计算
            public ushort wDeviceID;      // 设备ID
            public ushort wDataLen;       // 数据长度
            public byte byLane;         // 对应车道号
            public byte bySpeed;        // 对应车速（KM/H）
            public byte byLaneState;     // 车道状态；0-无状态，1-畅通，2-拥挤，3-堵塞
            public byte byQueueLen;       // 堵塞状态下排队长度（比如50米）
            public ushort wLoopState;         //线圈状态，第几位表示几号线圈状态，线圈编号从镜头由近到远依次增大。状态1-到达，0-离开
            public ushort wStateMask;         //线圈状态掩码，掩码位为1对应wLoopState状态位有效，为0表示无效
            public uint dwDownwardFlow;     //当前车道 从上到下车流量
            public uint dwUpwardFlow;       //当前车道 从下到上车流量
            public byte byJamLevel;         //拥堵等级，当byLaneState为3时有效，1-轻度，2-中度，3-重度
            public byte byVehicleDirection; //0-未知，1-由上而下，2-由下而上
            public byte byJamFlow;          //拥堵新增流量，每新增一辆车就上报一次累计车辆的信息
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;        //保留
            public ushort wTimeHeadway;        // 车头时距，以秒计算
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LLI_PARAM
        {
            public float fSec;//秒[0.000000,60.000000]
            public byte  byDegree;//度:纬度[0,90] 经度[0,180]
            public byte byMinute;//分[0,59]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LLPOS_PARAM
        {
            public byte byLatitudeType;//纬度类型，0-北纬，1-南纬
            public byte byLongitudeType;//经度类型，0-东经，1-西经
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_LLI_PARAM struLatitude;    /*纬度*/
            public NET_DVR_LLI_PARAM struLongitude; /*经度*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //TPS附加信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_ADDINFO
        {
            public NET_DVR_LLPOS_PARAM struLLPos;//车流量最后一辆车的经纬度位置信息(byLaneState=3且byQueueLen>0时才返回)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 1024, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //TPS实时过车数据上传
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_REAL_TIME_INFO
        {
            public uint dwSize;          // 结构体大小
            public uint dwChan;//通道号
            public NET_DVR_TIME_V30 struTime;    //检测时间
            public NET_DVR_TPS_PARAM struTPSRealTimeInfo;// 交通参数统计信息
            public IntPtr pAddInfoBuffer;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            /*附加信息标识（即是否有NET_DVR_TPS_ADDINFO结构体）,0-无附加信息, 1-有附加信息。*/
            public byte byAddInfoFlag;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      // 保留
        }

        //统计信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_LANE_PARAM
        {
            public byte byLane;             // 对应车道号
            public byte bySpeed;             // 车道过车平均速度
            public ushort wArrivalFlow;        //到达流量
            public uint dwLightVehicle;      // 小型车数量
            public uint dwMidVehicle;        // 中型车数量
            public uint dwHeavyVehicle;      // 重型车数量
            public uint dwTimeHeadway;      // 车头时距，以秒计算
            public uint dwSpaceHeadway;     // 车头间距，以米来计算
            public float fSpaceOccupyRation; // 空间占有率，百分比计算,浮点数*1000
            public float fTimeOccupyRation;  // 时间占有率，百分比计算,浮点数*1000
            public byte byStoppingTimes; //平均停车次数
            public byte byQueueLen;       // 堵塞状态下排队长度（比如50米）
            public byte byFlag;          //上传标识，0-表示T1时间的统计结果,1-表示T2时间的统计
            public byte byVehicelNum;         //区域车辆数
            public ushort wDelay;         //平均延误
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;               // 保留
            public uint dwNonMotor;      // 非机动车数量
        }

        // 交通参数统计信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_STATISTICS_PARAM
        {
            public byte byStart;          // 开始码
            public byte byCMD;         // 命令号， 08-定时成组数据指令
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;        // 预留字节
            public ushort wDeviceID;      // 设备ID
            public ushort wDataLen;       // 数据长度
            public byte byTotalLaneNum;  // 有效车道总数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_TIME_V30 struStartTime;    //统计开始时间
            public uint dwSamplePeriod;    //统计时间,单位秒
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TPS_RULE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_TPS_LANE_PARAM[] struLaneParam;
        }

        //TPS统计过车数据上传
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_STATISTICS_INFO
        {
            public uint dwSize;          // 结构体大小
            public uint dwChan;//通道号
            public NET_DVR_TPS_STATISTICS_PARAM struTPSStatisticsInfo;// 交通参数统计信息
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      // 保留
        }

        //交通事件信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AID_INFO
        {
            public byte byRuleID;   // 规则序号，为规则配置结构下标，0-16
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName; //  规则名称
            public uint dwAIDType;  // 报警事件类型
            public NET_DVR_DIRECTION   struDirect; // 报警指向区域  
            public byte bySpeedLimit; //限速值，单位km/h[0,255]
            public byte byCurrentSpeed; //当前速度值，单位km/h[0,255]
            public byte byVehicleEnterState;//车辆出入状态 0-无效 1-驶入 2-驶出
            public byte byState; //0-变化上传，1-轮巡上传
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byParkingID; //停车位编号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;  // 保留字节 
        }

        //交通事件报警 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AID_ALARM
        {
            public uint dwSize;         // 结构长度
            public uint dwRelativeTime;	// 相对时标
            public uint dwAbsTime;		// 绝对时标
            public NET_VCA_DEV_INFO struDevInfo;	// 前端设备信息
            public NET_DVR_AID_INFO struAIDInfo;    // 交通事件信息
            public uint dwPicDataLen;   // 返回图片的长度 为0表示没有图片，大于0表示该结构后面紧跟图片数据
            public IntPtr pImage;        // 指向图片的指针
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      // 保留字节  
        }
        
        //交通取证报警
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TFS_ALARM
        {
            public uint dwSize;                //结构体大小
            public uint dwRelativeTime;        //相对时标
            public uint dwAbsTime;               //绝对时标
            public uint dwIllegalType;         //违章类型，采用国标定义，当dwIllegalType值为0xffffffff时使用byIllegalCode
            public uint dwIllegalDuration;     //违法持续时间（单位：秒） = 抓拍最后一张图片的时间 - 抓拍第一张图片的时间
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MONITORSITE_ID_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMonitoringSiteID;//监测点编号（路口编号、内部编号）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DEVICE_ID_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDeviceID;             //设备编号
            public NET_VCA_DEV_INFO        struDevInfo;           //前端设备信息
            public NET_DVR_SCENE_INFO      struSceneInfo;         //场景信息
            public NET_DVR_TIME_EX         struBeginRecTime;      //录像开始时间 
            public NET_DVR_TIME_EX         struEndRecTime;        //录像结束时间 
            public NET_DVR_AID_INFO        struAIDInfo;           //交通事件信息
            public NET_DVR_PLATE_INFO      struPlateInfo;         //车牌信息
            public NET_DVR_VEHICLE_INFO    struVehicleInfo;       //车辆信息
            public uint dwPicNum;              //图片数量
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.Struct)]
            public NET_ITS_PICTURE_INFO[]    struPicInfo;        //图片信息，最多8张 
            public byte bySpecificVehicleType;     //具体车辆种类  参考识别结果类型VTR_RESULT
            public byte byLaneNo;  //关联车道号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1; //保留
            public NET_DVR_TIME_V30        struTime;//手动跟踪定位，当前时间。
            public uint dwSerialNo;//序号；
            public byte byVehicleAttribute;//车辆属性，按位表示，0- 无附加属性(普通车)，bit1- 黄标车(类似年检的标志)，bit2- 危险品车辆，值：0- 否，1- 是
            public byte byPilotSafebelt;//0-表示未知,1-系安全带,2-不系安全带
            public byte byCopilotSafebelt;//0-表示未知,1-系安全带,2-不系安全带
            public byte byPilotSunVisor;//0-表示未知,1-不打开遮阳板,2-打开遮阳板
            public byte byCopilotSunVisor;//0-表示未知, 1-不打开遮阳板,2-打开遮阳板
            public byte byPilotCall;// 0-表示未知, 1-不打电话,2-打电话
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //保留
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = ILLEGAL_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byIllegalCode;//违法代码扩展，当dwIllegalType值为0xffffffff；使用这个值
            public ushort wCountry; // 国家索引值,参照枚举COUNTRY_INDEX
            public byte byRegion; //区域索引值,0-保留，1-欧洲(Europe Region)，2-俄语区域(Russian Region)，3-欧洲&俄罗斯(EU&CIS) , 4-中东（Middle East），0xff-所有
            public byte byCrossLine;//是否压线停车（侧方停车），0-表示未知，1-不压线，2-压线
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIAL_NO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byParkingSerialNO;//泊车位编号
            public byte byCrossSpaces;//是否跨泊车位停车（侧方停车），0-表示未知，1-未跨泊车位停车，2-跨泊车位停车
            public byte byAngledParking;//是否倾斜停车（侧方停车）, 0-表示未知，1-未倾斜停车，2-倾斜停车
            public byte byAlarmValidity;//报警置信度，可以输出驶入驶出的置信度，范围0-100；置信度越高，事件真实性越高
            public byte byDoorsStatus;//车门状态 0-车门关闭 1-车门开启
            public uint dwXmlLen;//XML报警信息长度
            public IntPtr pXmlBuf; // XML报警信息指针,其XML对应到EventNotificationAlert XML Block
            //[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            //public byte[] byRes3; //32位SDK需要保留字节对齐
            public byte byVehicleHeadTailStatus;//车头车尾状态 0-保留 1-车头 2-车尾
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 31, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //保留
    }

        //车道队列结构体 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LANE_QUEUE
        {
            public NET_VCA_POINT struHead;       //队列头
            public NET_VCA_POINT struTail;       //队列尾
            public uint dwLength;      //实际队列长度 单位为米 [0-500]
        }

        public enum TRAFFIC_DATA_VARY_TYPE
        {
            NO_VARY,         //无变化 
            VEHICLE_ENTER,   //车辆进入虚拟线圈
            VEHICLE_LEAVE,   //车辆离开虚拟线圈 
            UEUE_VARY        //队列变化             
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LANE_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;  //车道规则名称 
            public byte byRuleID;              //规则序号，为规则配置结构下标，0-7 
            public byte byVaryType;            //车道交通参数变化类型 参照 TRAFFIC_DATA_VARY_TYPE
            public byte byLaneType;			   //车道上行或下行
            public byte byRes1;
            public uint dwLaneVolume;         //车道流量 ，统计有多少车子通过
            public uint dwLaneVelocity;        //车道速度，公里计算
            public uint dwTimeHeadway;         //车头时距，以秒计算
            public uint dwSpaceHeadway;        //车头间距，以米来计算
            public float fSpaceOccupyRation;    //车道占有率，百分比计算（空间上)
            public NET_DVR_LANE_QUEUE struLaneQueue;    //车道队列长度
            public NET_VCA_POINT struRuleLocation; //线圈规则的中心点位置
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_INFO
        {
            public uint dwLanNum;   // 交通参数的车道数目
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TPS_RULE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_LANE_PARAM[]  struLaneParam;
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_ALARM
        {
            public uint dwSize;          //结构体大小
            public uint dwRelativeTime;  //相对时标
            public uint dwAbsTime;       //绝对时标
            public NET_VCA_DEV_INFO  struDevInfo;     //前端设备信息
            public NET_DVR_TPS_INFO  struTPSInfo;     //交通事件信息
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;      //保留字节
        }
        
        public enum TRAFFIC_DATA_VARY_TYPE_EX_ENUM
        {    
	        ENUM_TRAFFIC_VARY_NO             = 0x00,   //无变化
	        ENUM_TRAFFIC_VARY_VEHICLE_ENTER  = 0x01,   //车辆进入虚拟线圈
	        ENUM_TRAFFIC_VARY_VEHICLE_LEAVE  = 0x02,   //车辆离开虚拟线圈
	        ENUM_TRAFFIC_VARY_QUEUE          = 0x04,   //队列变化
	        ENUM_TRAFFIC_VARY_STATISTIC      = 0x08,   //统计数据变化（每分钟变化一次包括平均速度，车道空间/时间占有率，交通状态）        
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LANE_PARAM_V41
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName; // 车道规则名称
            public byte byRuleID;             // 规则序号，为规则配置结构下标，0-7 
            public byte byLaneType;		     // 车道上行或下行
            public byte byTrafficState;       // 车道的交通状态，0-无效，1-畅通，2-拥挤，3-堵塞
            public byte byRes1;               // 保留
            public uint dwVaryType;           // 车道交通参数变化类型参照  TRAFFIC_DATA_VARY_TYPE_EX_ENUM，按位区分
            public uint dwTpsType;            // 数据变化类型标志，表示当前上传的统计参数中，哪些数据有效，参照ITS_TPS_TYPE,按位区分
            public uint dwLaneVolume;	     // 车道流量，统计有多少车子通过
            public uint dwLaneVelocity;       // 车道速度，公里计算
            public uint dwTimeHeadway ;       // 车头时距，以秒计算
            public uint dwSpaceHeadway;       // 车头间距，以米来计算
            public float fSpaceOccupyRation;   // 车道占有率，百分比计算（空间上)
            public float fTimeOccupyRation;    // 时间占有率，百分比计算
            public uint dwLightVehicle;       // 小型车数量
            public uint dwMidVehicle;         // 中型车数量
            public uint dwHeavyVehicle;       // 重型车数量
            public NET_DVR_LANE_QUEUE struLaneQueue;        // 车道队列长度
            public NET_VCA_POINT struRuleLocation;     // 规则位置虚拟线圈的中心
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;           // 保留
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_INFO_V41
        {
            public uint dwLanNum;          // 交通参数的车道数目
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TPS_RULE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_LANE_PARAM_V41[]  struLaneParam;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;         //保留
        }

        //人脸规则配置 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FACEDETECT_RULECFG
        {
            public uint dwSize;              // 结构体大小
            public byte byEnable;            // 是否启用
            public byte byEventType;			//警戒事件类型， 0-异常人脸; 1-正常人脸;2-异常人脸&正常人脸;
            public byte byUpLastAlarm;       //2011-04-06 是否先上传最近一次的报警
            public byte byUpFacePic; //是否上传人脸子图，0-否，1-是	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;
            public NET_VCA_POLYGON     struVcaPolygon;    // 人脸检测规则区域
            public byte byPicProType;	//报警时图片处理方式 0-不处理 非0-上传
            public byte bySensitivity;   // 规则灵敏度
            public ushort wDuration;      // 触发人脸报警时间阈值
            public NET_DVR_JPEGPARA    struPictureParam; 		//图片规格结构
            public NET_VCA_SIZE_FILTER struSizeFilter;         //尺寸过滤器
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_2, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//布防时间
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	  //处理方式 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;			//报警触发的录象通道,为1表示触发该通道
            public byte byPicRecordEnable;  /*2012-3-1是否启用图片存储, 0-不启用, 1-启用*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 39, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;         //保留字节
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FACE_PIPCFG
        {	
            public byte byEnable; //是否开启画中画
            public byte byBackChannel; //背景通道号（面板通道）
            public byte byPosition; //叠加位置，0-左上,1-左下,2-右上,3-右下
            public byte byPIPDiv; //分屏系数(人脸画面:面板画面)，0-1:4,1-1:9,2-1:16
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FACEDETECT_RULECFG_V41
        {
            public uint dwSize;              // 结构体大小
            public byte byEnable;            // 是否启用
            public byte byEventType;			//警戒事件类型， 0-异常人脸; 1-正常人脸;2-异常人脸&正常人脸;
            public byte byUpLastAlarm;       //2011-04-06 是否先上传最近一次的报警
            public byte byUpFacePic; //是否上传人脸子图，0-否，1-是	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;
            public NET_VCA_POLYGON struVcaPolygon;    // 人脸检测规则区域
            public byte byPicProType;	//报警时图片处理方式 0-不处理 非0-上传
            public byte bySensitivity;   // 规则灵敏度
            public ushort wDuration;      // 触发人脸报警时间阈值
            public NET_DVR_JPEGPARA    struPictureParam; 		//图片规格结构
            public NET_VCA_SIZE_FILTER struSizeFilter;         //尺寸过滤器
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[]   struAlarmTime;//布防时间
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	  //处理方式 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;			//报警触发的录象通道,为1表示触发该通道
            public byte byPicRecordEnable;  /*2012-10-22是否启用图片存储, 0-不启用, 1-启用*/
            public byte byRes1;
            public ushort wAlarmDelay; //2012-10-22智能报警延时，0-5s,1-10,2-30s,3-60s,4-120s,5-300s,6-600s
            public NET_DVR_FACE_PIPCFG struFacePIP; //2012-11-7画中画参数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 28, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;         //保留字节
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FACEDETECT_ALARM
        {
            public uint dwSize;     		// 结构大小
            public uint dwRelativeTime; // 相对时标
            public uint dwAbsTime;			// 绝对时标
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;   // 规则名称
            public NET_VCA_TARGET_INFO  struTargetInfo;	//报警目标信息
            public NET_VCA_DEV_INFO  	 struDevInfo;		//前端设备信息
            public uint dwPicDataLen;						//返回图片的长度 为0表示没有图片，大于0表示该结构后面紧跟图片数据*/
            public byte byAlarmPicType;			// 0-异常人脸报警图片 1- 人脸图片,2-多张人脸 
            public byte byPanelChan;        /*2012-3-1人脸通道关联的面板通道*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwFacePicDataLen;			//人脸图片的长度 为0表示没有图片，大于0表示该结构后面紧跟图片数据*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 48, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;              // 保留字节
            public IntPtr pFaceImage; //指向人脸图指针
            public IntPtr pImage;   						//指向图片的指针
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EVENT_PARAM_UNION
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.U4)]
            public uint[] uLen;        	// 联合体大小为12字节
            public uint dwHumanIn;  	//有无人接近 0 - 无人 1- 有人  
            public float fCrowdDensity;  // 人员聚集值
        }

        //目前只有有人无人事件和人员聚集事件实时报警上传
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EVENT_INFO
        {
            public byte byRuleID;				// Rule ID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;				// 保留字节
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;	// 规则名称
            public uint dwEventType;    		// 参照VCA_EVENT_TYPE
            public NET_DVR_EVENT_PARAM_UNION uEventParam;  // 
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EVENT_INFO_LIST
        {
            public byte byNum;		// 事件实时信息个数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;			// 保留字节
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RULE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_EVENT_INFO[] struEventInfo;	// 事际实时信息
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RULE_INFO_ALARM
        {
            public uint dwSize;				// 结构体大小
            public uint dwRelativeTime; 	// 相对时标
            public uint dwAbsTime;			// 绝对时标
            public NET_VCA_DEV_INFO  	struDevInfo;		// 前端设备信息
            public NET_DVR_EVENT_INFO_LIST struEventInfoList;	//事件信息列表
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;			// 保留字节
        }

        //单条场景时间段
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_SCENE_TIME
        {
            public byte byActive;                     //0 -无效,1–有效
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                    //保留
            public uint dwSceneID;                    //场景ID
            public NET_DVR_SCHEDTIME struEffectiveTime;   //场景起效时间
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                   //保留
        }

        //场景起效时间段配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCENE_TIME_CFG
        {   
            public uint dwSize;                                               //结构大小
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SCENE_TIMESEG_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_SCENE_TIME[] struSceneTime; //场景时间段数组
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                                            //保留
        }

        //单条场景配置信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_SCENE_CFG
        {    
            public byte byEnable;                 //是否启用该场景,0-不启用 1- 启用
            public byte byDirection;              //监测方向 1-上行，2-下行，3-双向，4-由东向西，5-由南向北，6-由西向东，7-由北向南，8-其它
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                //保留
            public uint dwSceneID;                //场景ID(只读), 0 - 表示该场景无效
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] bySceneName;    //场景名称
            public NET_DVR_PTZPOS struPtzPos;       //ptz 坐标
            public uint dwTrackTime;              //球机跟踪时间[5,300] 秒，TFS(交通取证)模式下有效
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;               //保留
        }

        //场景配置结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCENE_CFG
        {
            public uint dwSize;                                          //结构大小
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ITS_SCENE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_SCENE_CFG[] struSceneCfg; //场景配置信息
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                                      //保留
        }

        //多场景操作条件
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCENE_COND
        {
            public uint dwSize;       //结构大小
            public Int32 lChannel;     //通道号
            public uint dwSceneID;    //场景ID, 0-表示该场景无效
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 48, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;    //保留
        }

        //取证方式
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FORENSICS_MODE
        {
            public uint dwSize;      //结构大小
            public byte byMode;      // 0-手动取证 ,1-自动取证
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   //保留
        }

        //报警场景信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCENE_INFO
        {  
            public uint dwSceneID;              //场景ID, 0 - 表示该场景无效
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] bySceneName;  //场景名称
            public byte byDirection;            //监测方向 1-上行，2-下行，3-双向，4-由东向西，5-由南向北，6-由西向东，7-由北向南，8-其它
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;              //保留
            public NET_DVR_PTZPOS  struPtzPos;             //Ptz 坐标
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2 ;            //保留
        }

        //交通事件报警(扩展)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AID_ALARM_V41
        {
            public uint dwSize;              //结构长度
            public uint dwRelativeTime;        //相对时标
            public uint dwAbsTime;            //绝对时标
            public NET_VCA_DEV_INFO struDevInfo;            //前端设备信息
            public NET_DVR_AID_INFO struAIDInfo;         //交通事件信息
            public NET_DVR_SCENE_INFO struSceneInfo;       //场景信息
            public uint dwPicDataLen;        //图片长度
            public IntPtr pImage;             //指向图片的指针
            // 0-数据直接上传; 1-云存储服务器URL(3.7Ver)原先的图片数据变成URL数据，图片长度变成URL长度
            public byte byDataType;
            public byte byLaneNo;  //关联车道号 
            public ushort wMilliSecond;        //时标毫秒
            //监测点编号（路口编号、内部编号）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MONITORSITE_ID_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMonitoringSiteID;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DEVICE_ID_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDeviceID;//设备编号
            public uint dwXmlLen;//XML报警信息长度
            public IntPtr pXmlBuf;// XML报警信息指针,其XML对应到EventNotificationAlert XML Block
            public byte byTargetType;// 检测的目标类型，0~未知，1~行人、2~二轮车、3~三轮车(行人检测中返回)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 19, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; // 保留字节   
        }

        //交通统计信息报警(扩展)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_ALARM_V41
        {
            public uint dwSize;          // 结构体大小
            public uint dwRelativeTime;  // 相对时标
            public uint dwAbsTime;       // 绝对时标
            public NET_VCA_DEV_INFO struDevInfo;     // 前端设备信息
            public NET_DVR_TPS_INFO_V41  struTPSInfo;     // 交通参数统计信息 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      // 保留
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VCA_VERSION
        {
            public ushort wMajorVersion;		// 主版本号
            public ushort wMinorVersion;		// 次版本号
            public ushort wRevisionNumber;	// 修正号
            public ushort wBuildNumber;		// 编译号
            public ushort wVersionYear;		//	版本日期-年
            public byte byVersionMonth;		//	版本日期-月
            public byte byVersionDay;		//	版本日期-日
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;			// 保留字节
        }
        /*******************************智能交通事件 end*****************************************/

        /******************************车牌识别 begin******************************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLATE_PARAM
        {	
            public byte byPlateRecoMode;    //车牌识别的模式,默认为1(视频触发模式)
            public byte byBelive;	/*整牌置信度阈值, 只用于视频识别方式, 根据背景复杂程度设置, 误触发率高就设高, 漏车率高就设低, 
                                     * 建议在80-90范围内*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 22, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;          //保留字节
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLATECFG
        {	
            public uint dwSize;
            public uint dwEnable;				           /* 是否启用视频车牌识别 0－否 1－是 */
            public byte byPicProType;	//报警时图片处理方式 0-不处理 非0-上传
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  // 保留字节
            public NET_DVR_JPEGPARA struPictureParam; 		//图片规格结构
            public NET_DVR_PLATE_PARAM struPlateParam;   // 车牌识别参数配置
            public NET_DVR_HANDLEEXCEPTION struHandleType;	   /* 处理方式 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//布防时间
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;        //报警触发的录象通道,为1表示触发该通道
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   // 保留字节
        }

        //车牌识别结果子结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLATE_INFO
        {
            public byte byPlateType; //车牌类型
            public byte byColor; //车牌颜色
            public byte byBright; //车牌亮度
            public byte byLicenseLen;	//车牌字符个数
            public byte byEntireBelieve;//整个车牌的置信度，0-100
            public byte byRegion;                       // 区域索引值 0-保留，1-欧洲(EU)，2-俄语区域(ER)，3-欧洲&俄罗斯(EU&CIS) ,4-中东(ME),0xff-所有
            public byte byCountry;                      // 国家索引值，参照枚举COUNTRY_INDEX（不支持"COUNTRY_ALL = 0xff, //ALL  全部"）
            public byte byArea;                         //区域（省份），各国家内部区域枚举，阿联酋参照 EMI_AREA
            public byte byPlateSize;                    //车牌尺寸，0~未知，1~long, 2~short(中东车牌使用)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                       //保留
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CATEGORY_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPlateCategory;//车牌附加信息, 即中东车牌中车牌号码旁边的小字信息，(目前只有中东地区支持)
            public uint dwXmlLen;                        //XML报警信息长度
            public IntPtr pXmlBuf;                      // XML报警信息指针,报警类型为 COMM_ITS_PLATE_RESUL时有效，其XML对应到EventNotificationAlert XML Block
            public NET_VCA_RECT	struPlateRect;	//车牌位置
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LICENSE_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sLicense;	//车牌号码 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LICENSE_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byBelieve; //各个识别字符的置信度，如检测到车牌"浙A12345", 置信度为,20,30,40,50,60,70，则表示"浙"字正确的可能性只有%，"A"字的正确的可能性是%
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLATERECO_RESULE
        {
            public uint dwSize;
            public uint dwRelativeTime;	//相对时标
            public uint dwAbsTime;	//绝对时标
            public NET_VCA_DEV_INFO struDevInfo; // 前段设备信息
            public NET_DVR_PLATE_INFO struPlateInfo;
            public uint dwPicDataLen;	//返回图片的长度 为0表示没有图片，大于0表示该结构后面紧跟图片数据
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;	//保留，设置为0
            public IntPtr pImage;   //指向图片的指针
        }
        /******************************车牌识别 end******************************************/

        /******************************抓拍机*******************************************/
        //IO输入配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IO_INCFG
        {
            public uint dwSize;
            public byte byIoInStatus;//输入的IO口状态，0-下降沿，1-上升沿，2-上升沿和下降沿，3-高电平，4-低电平
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//保留字节
        }

        //IO输出配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IO_OUTCFG
        {
            public uint dwSize;
            public byte byDefaultStatus;//IO默认状态：0-低电平，1-高电平 
            public byte byIoOutStatus;//IO起效时状态：0-低电平，1-高电平，2-脉冲
            public ushort wAheadTime;//输出IO提前时间，单位us
            public uint dwTimePluse;//脉冲间隔时间，单位us
            public uint dwTimeDelay;//IO有效持续时间，单位us
            public byte byFreqMulti;		//倍频，数值范围[1,15]
            public byte byDutyRate;		//占空比，[0,40%]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //闪光灯配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FLASH_OUTCFG
        {
            public uint dwSize;
            public byte byMode;//闪光灯闪烁模式，0-不闪，1-闪，2-关联闪，3-轮闪
            public byte byRelatedIoIn;//闪光灯关联的输入IO号（关联闪时此参数有效）
            public byte byRecognizedLane;  /*关联的IO号，按位表示，bit0表示IO1是否关联，0-不关联，1-关联*/
            public byte byDetectBrightness;/*自动检测亮度使能闪光灯0-不检测；1-检测*/
            public byte byBrightnessThreld;/*使能闪光灯亮度阈值，范围[0,100],高于阈值闪*/
            public byte byStartHour;		//开始时间-小时,取值范围0-23
            public byte byStartMinute;		//开始时间-分,取值范围0-59
            public byte byEndHour;		 	//结束时间-小时,取值范围0-23
            public byte byEndMinute;		//结束时间-分,取值范围0-59
            public byte byFlashLightEnable;	//设置闪光灯时间使能:0-关;1-开
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //红绿灯功能（2个IO输入一组）
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LIGHTSNAPCFG
        {
            public uint dwSize;
            public byte byLightIoIn;//红绿灯的IO 号
            public byte byTrigIoIn;//触发的IO号
            public byte byRelatedDriveWay;//触发IO关联的车道号
            public byte byTrafficLight; //0-高电平红灯，低电平绿灯；1-高电平绿灯，低电平红灯
            public byte bySnapTimes1; //红灯抓拍次数1，0-不抓拍，非0-连拍次数，最大5次 
            public byte bySnapTimes2; //绿灯抓拍次数2，0-不抓拍，非0-连拍次数，最大5次 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_INTERVAL_NUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wIntervalTime1;//红灯连拍间隔时间，ms
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_INTERVAL_NUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wIntervalTime2;//绿灯连拍间隔时间，ms
            public byte byRecord;//闯红灯周期录像标志，0-不录像，1-录像
            public byte bySessionTimeout;//闯红灯周期录像超时时间（秒）
            public byte byPreRecordTime;//闯红灯录像片段预录时间(秒)
            public byte byVideoDelay;//闯红灯录像片段延时时间（秒）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;//保留字节
        }

        //测速功能(2个IO输入一组）
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MEASURESPEEDCFG
        {
            public uint dwSize;
            public byte byTrigIo1;   //测速第1线圈
            public byte byTrigIo2;   //测速第2线圈
            public byte byRelatedDriveWay;//触发IO关联的车道号
            public byte byTestSpeedTimeOut;//测速模式超时时间，单位s
            public uint dwDistance;//线圈距离,cm
            public byte byCapSpeed;//测速模式起拍速度，单位km/h
            public byte bySpeedLimit;//限速值，单位km/h
            public byte bySnapTimes1; //线圈1抓拍次数，0-不抓拍，非0-连拍次数，最大5次 
            public byte bySnapTimes2; //线圈2抓拍次数，0-不抓拍，非0-连拍次数，最大5次 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_INTERVAL_NUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wIntervalTime1;//线圈1连拍间隔时间，ms
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_INTERVAL_NUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wIntervalTime2;//线圈2连拍间隔时间，ms
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//保留字节
        }

        //视频参数配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEOEFFECT
        {
            public byte byBrightnessLevel; /*0-100*/
            public byte byContrastLevel; /*0-100*/
            public byte bySharpnessLevel; /*0-100*/
            public byte bySaturationLevel; /*0-100*/
            public byte byHueLevel; /*0-100,（保留）*/
            public byte byEnableFunc; //使能，按位表示，bit0-SMART IR(防过曝)，bit1-低照度,bit2-强光抑制使能，0-否，1-是
            public byte byLightInhibitLevel; //强光抑制等级，[1-3]表示等级
            public byte byGrayLevel; //灰度值域，0-[0-255]，1-[16-235]
        }

        //增益配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_GAIN
        {
            public byte byGainLevel; /*增益：0-100*/
            public byte byGainUserSet; /*用户自定义增益；0-100，对于抓拍机，是CCD模式下的抓拍增益*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwMaxGainValue;/*最大增益值，单位dB*/
        }

        //白平衡配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WHITEBALANCE
        {
            public byte byWhiteBalanceMode; /*0-手动白平衡（MWB）,1-自动白平衡1（AWB1）,2-自动白平衡2 (AWB2),3-自动控制改名为锁定白平衡(Locked WB)，
	                         4-室外(Indoor)，5-室内(Outdoor)6-日光灯(Fluorescent Lamp)，7-钠灯(Sodium Lamp)，
	                         8-自动跟踪(Auto-Track)9-一次白平衡(One Push)，10-室外自动(Auto-Outdoor)，
	                         11-钠灯自动 (Auto-Sodiumlight)，12-水银灯(Mercury Lamp)，13-自动白平衡(Auto)，
	                         14-白炽灯 (IncandescentLamp)，15-暖光灯(Warm Light Lamp)，16-自然光(Natural Light) */
            public byte byWhiteBalanceModeRGain; /*手动白平衡时有效，手动白平衡 R增益*/
            public byte byWhiteBalanceModeBGain; /*手动白平衡时有效，手动白平衡 B增益*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //曝光控制
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EXPOSURE
        {
            public byte byExposureMode; /*0 手动曝光 1自动曝光*/
            public byte byAutoApertureLevel; /* 自动光圈灵敏度, 0-10 */ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwVideoExposureSet; /* 自定义视频曝光时间（单位us）*//*注:自动曝光时该值为曝光最慢值 新增20-1s(1000000us)*/        
            public uint dwExposureUserSet; /* 自定义曝光时间,在抓拍机上应用时，CCD模式时是抓拍快门速度*/   
            public uint dwRes;    
        }

        //宽动态配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WDR
        {
            public byte byWDREnabled; /*宽动态：0 dsibale  1 enable 2 auto*/
            public byte byWDRLevel1; /*0-F*/
            public byte byWDRLevel2; /*0-F*/
            public byte byWDRContrastLevel; /*0-100*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //日夜转换功能配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DAYNIGHT
        {
            public byte byDayNightFilterType; /*日夜切换：0-白天，1-夜晚，2-自动，3-定时，4-报警输入触发*/
            public byte bySwitchScheduleEnabled; /*0 dsibale  1 enable,(保留)*/
            //定时模式参数
            public byte byBeginTime; /*开始时间（小时），0-23*/
            public byte byEndTime; /*结束时间（小时），0-23*/
            //模式2
            public byte byDayToNightFilterLevel; //0-7
            public byte byNightToDayFilterLevel; //0-7
            public byte byDayNightFilterTime;//(60秒)
            //定时模式参数
            public byte byBeginTimeMin; //开始时间（分），0-59
            public byte byBeginTimeSec; //开始时间（秒），0-59
            public byte byEndTimeMin; //结束时间（分），0-59
            public byte byEndTimeSec; //结束时间（秒），0-59
	        //报警输入触发模式参数
            public byte byAlarmTrigState; //报警输入触发状态，0-白天，1-夜晚
        }

        //Gamma校正
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_GAMMACORRECT
        {
            public byte byGammaCorrectionEnabled; /*0 dsibale  1 enable*/
            public byte byGammaCorrectionLevel; /*0-100*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //背光补偿配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BACKLIGHT
        {
            public byte byBacklightMode; /*背光补偿:0 off 1 UP、2 DOWN、3 LEFT、4 RIGHT、5MIDDLE、6自定义*/
            public byte byBacklightLevel; /*0x0-0xF*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwPositionX1; //（X坐标1）
            public uint dwPositionY1; //（Y坐标1）
            public uint dwPositionX2; //（X坐标2）
            public uint dwPositionY2; //（Y坐标2）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //数字降噪功能
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NOISEREMOVE
        {
            public byte byDigitalNoiseRemoveEnable; /*0-不启用，1-普通模式数字降噪，2-专家模式数字降噪*/
            public byte byDigitalNoiseRemoveLevel; /*普通模式数字降噪级别：0x0-0xF*/
            public byte bySpectralLevel;       /*专家模式下空域强度：0-100*/
            public byte byTemporalLevel;   /*专家模式下时域强度：0-100*/
            public byte byDigitalNoiseRemove2DEnable;         /* 抓拍帧2D降噪，0-不启用，1-启用 */	
            public byte byDigitalNoiseRemove2DLevel;            /* 抓拍帧2D降噪级别，0-100 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //CMOS模式下前端镜头配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CMOSMODECFG
        {
            public byte byCaptureMod;   //抓拍模式：0-抓拍模式1；1-抓拍模式2
            public byte byBrightnessGate;//亮度阈值
            public byte byCaptureGain1;   //抓拍增益1,0-100
            public byte byCaptureGain2;   //抓拍增益2,0-100
            public uint dwCaptureShutterSpeed1;//抓拍快门速度1
            public uint dwCaptureShutterSpeed2;//抓拍快门速度2
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //前端参数配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CAMERAPARAMCFG
        {
            public uint dwSize;
            public NET_DVR_VIDEOEFFECT struVideoEffect;/*亮度、对比度、饱和度、锐度、色调配置*/    
            public NET_DVR_GAIN struGain;/*自动增益*/
            public NET_DVR_WHITEBALANCE struWhiteBalance;/*白平衡*/
            public NET_DVR_EXPOSURE struExposure; /*曝光控制*/
            public NET_DVR_GAMMACORRECT struGammaCorrect;/*Gamma校正*/
            public NET_DVR_WDR struWdr;/*宽动态*/
            public NET_DVR_DAYNIGHT struDayNight;/*日夜转换*/
            public NET_DVR_BACKLIGHT struBackLight;/*背光补偿*/
            public NET_DVR_NOISEREMOVE struNoiseRemove;/*数字降噪*/
            public byte byPowerLineFrequencyMode; /*0-50HZ; 1-60HZ*/
            public byte byIrisMode; /*0 自动光圈 1手动光圈*/    
            public byte byMirror ;  /* 镜像：0 off，1- leftright，2- updown，3-center */
            public byte byDigitalZoom;  /*数字缩放:0 dsibale  1 enable*/
            public byte byDeadPixelDetect;   /*坏点检测,0 dsibale  1 enable*/
            public byte byBlackPwl;/*黑电平补偿 ,  0-255*/ 
            public byte byEptzGate;// EPTZ开关变量:0-不启用电子云台，1-启用电子云台
            public byte byLocalOutputGate;//本地输出开关变量0-本地输出关闭1-本地BNC输出打开 2-HDMI输出关闭  
				     //20-HDMI_720P50输出开
					 //21-HDMI_720P60输出开
					 //22-HDMI_1080I60输出开
					 //23-HDMI_1080I50输出开
					 //24-HDMI_1080P24输出开
					 //25-HDMI_1080P25输出开
					 //26-HDMI_1080P30输出开
					 //27-HDMI_1080P50输出开
			         //28-HDMI_1080P60输出开
					 //40-SDI_720P50,
					 //41-SDI_720P60,
					 //42-SDI_1080I50,
					 //43-SDI_1080I60,
					 //44-SDI_1080P24,
					 //45-SDI_1080P25,
					 //46-SDI_1080P30,
					 //47-SDI_1080P50,
					 //48-SDI_1080P60
            public byte byCoderOutputMode;//编码器fpga输出模式0直通3像素搬家
            public byte byLineCoding; //是否开启行编码：0-否，1-是
            public byte byDimmerMode; //调光模式：0-半自动，1-自动
            public byte byPaletteMode; //调色板：0-白热，1-黑热，2-调色板2，…，8-调色板8
            public byte byEnhancedMode; //增强方式（探测物体周边）：0-不增强，1-1，2-2，3-3，4-4
            public byte byDynamicContrastEN;    //动态对比度增强 0-1
            public byte byDynamicContrast;    //动态对比度 0-100
            public byte byJPEGQuality;    //JPEG图像质量 0-100
            public NET_DVR_CMOSMODECFG struCmosModeCfg;//CMOS模式下前端参数配置，镜头模式从能力集获取
            public byte byFilterSwitch; //滤波开关：0-不启用，1-启用
            public byte byFocusSpeed; //镜头调焦速度：0-10
            public byte byAutoCompensationInterval; //定时自动快门补偿：1-120，单位：分钟
            public byte bySceneMode;  //场景模式：0-室外，1-室内，2-默认，3-弱光
        }

        //透雾
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEFOGCFG
        {
            public byte byMode; //模式，0-不启用，1-自动模式，2-常开模式
            public byte byLevel; //等级，0-100
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; 
        }

        //电子防抖
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ELECTRONICSTABILIZATION
        {
            public byte byEnable;//使能 0- 不启用，1- 启用
            public byte byLevel; //等级，0-100
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; 
        }

        //走廊模式
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CORRIDOR_MODE_CCD
        {
            public byte byEnableCorridorMode; //是否启用走廊模式 0～不启用， 1～启用
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //SMART IR(防过曝)配置参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SMARTIR_PARAM
        {
            public byte byMode;//0～手动，1～自动
            public byte byIRDistance;//红外距离等级(等级，距离正比例)level:1~100 默认:50（手动模式下增加）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //在byIrisMode 为P-Iris1时生效，配置红外光圈大小等级，配置模式
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PIRIS_PARAM
        {
            public byte byMode;//0-自动，1-手动
            public byte byPIrisAperture;//红外光圈大小等级(等级,光圈大小正比例)level:1~100 默认:50（手动模式下增加）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //前端参数配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CAMERAPARAMCFG_EX
        {
            public uint dwSize;
            public NET_DVR_VIDEOEFFECT struVideoEffect;/*亮度、对比度、饱和度、锐度、色调配置*/
            public NET_DVR_GAIN struGain;/*自动增益*/
            public NET_DVR_WHITEBALANCE struWhiteBalance;/*白平衡*/
            public NET_DVR_EXPOSURE struExposure; /*曝光控制*/
            public NET_DVR_GAMMACORRECT struGammaCorrect;/*Gamma校正*/
            public NET_DVR_WDR struWdr;/*宽动态*/
            public NET_DVR_DAYNIGHT struDayNight;/*日夜转换*/
            public NET_DVR_BACKLIGHT struBackLight;/*背光补偿*/
            public NET_DVR_NOISEREMOVE struNoiseRemove;/*数字降噪*/
            public byte byPowerLineFrequencyMode; /*0-50HZ; 1-60HZ*/
            public byte byIrisMode; /*0-自动光圈 1-手动光圈, 2-P-Iris1*/    
            public byte byMirror ;  /* 镜像：0 off，1- leftright，2- updown，3-center */
            public byte byDigitalZoom;  /*数字缩放:0 dsibale  1 enable*/
            public byte byDeadPixelDetect;   /*坏点检测,0 dsibale  1 enable*/
            public byte byBlackPwl;/*黑电平补偿 ,  0-255*/ 
            public byte byEptzGate;// EPTZ开关变量:0-不启用电子云台，1-启用电子云台
            public byte byLocalOutputGate;//本地输出开关变量0-本地输出关闭1-本地BNC输出打开 2-HDMI输出关闭  
	        //20-HDMI_720P50输出开
	        //21-HDMI_720P60输出开
	        //22-HDMI_1080I60输出开
	        //23-HDMI_1080I50输出开
	        //24-HDMI_1080P24输出开
	        //25-HDMI_1080P25输出开
	        //26-HDMI_1080P30输出开
	        //27-HDMI_1080P50输出开
	        //28-HDMI_1080P60输出开
            public byte byCoderOutputMode;//编码器fpga输出模式0直通3像素搬家
            public byte byLineCoding; //是否开启行编码：0-否，1-是
            public byte byDimmerMode; //调光模式：0-半自动，1-自动
            public byte byPaletteMode; //调色板：0-白热，1-黑热，2-调色板2，…，8-调色板8
            public byte byEnhancedMode; //增强方式（探测物体周边）：0-不增强，1-1，2-2，3-3，4-4
            public byte byDynamicContrastEN;    //动态对比度增强 0-1
            public byte byDynamicContrast;    //动态对比度 0-100
            public byte byJPEGQuality;    //JPEG图像质量 0-100
            public NET_DVR_CMOSMODECFG struCmosModeCfg;//CMOS模式下前端参数配置，镜头模式从能力集获取
            public byte byFilterSwitch; //滤波开关：0-不启用，1-启用
            public byte byFocusSpeed; //镜头调焦速度：0-10
            public byte byAutoCompensationInterval; //定时自动快门补偿：1-120，单位：分钟
            public byte bySceneMode;  //场景模式：0-室外，1-室内，2-默认，3-弱光
            public NET_DVR_DEFOGCFG struDefogCfg;//透雾参数
            public NET_DVR_ELECTRONICSTABILIZATION struElectronicStabilization;//电子防抖
            public NET_DVR_CORRIDOR_MODE_CCD struCorridorMode;//走廊模式
            public byte byExposureSegmentEnable; //0~不启用,1~启用  曝光时间和增益呈阶梯状调整，比如曝光往上调整时，先提高曝光时间到中间值，然后提高增益到中间值，再提高曝光到最大值，最后提高增益到最大值
            public byte byBrightCompensate;//亮度增强 [0~100]

	        /*0-关闭、1-640*480@25fps、2-640*480@30ps、3-704*576@25fps、4-704*480@30fps、5-1280*720@25fps、6-1280*720@30fps、
             * 7-1280*720@50fps、8-1280*720@60fps、9-1280*960@15fps、10-1280*960@25fps、11-1280*960@30fps、
             * 12-1280*1024@25fps、13--1280*1024@30fps、14-1600*900@15fps、15-1600*1200@15fps、16-1920*1080@15fps、
             * 17-1920*1080@25fps、18-1920*1080@30fps、19-1920*1080@50fps、20-1920*1080@60fps、21-2048*1536@15fps、22-2048*1536@20fps、
             * 23-2048*1536@24fps、24-2048*1536@25fps、25-2048*1536@30fps、26-2560*2048@25fps、27-2560*2048@30fps、
             * 28-2560*1920@7.5fps、29-3072*2048@25fps、30-3072*2048@30fps、31-2048*1536@12.5、32-2560*1920@6.25、
             * 33-1600*1200@25、34-1600*1200@30、35-1600*1200@12.5、36-1600*900@12.5、37-1600@900@15、38-800*600@25、39-800*600@30*/
            public byte byCaptureModeN; //视频输入模式（N制）
            public byte byCaptureModeP; //视频输入模式（P制）
            public NET_DVR_SMARTIR_PARAM struSmartIRParam; //红外放过爆配置信息
            public NET_DVR_PIRIS_PARAM struPIrisParam;//PIris配置信息对应byIrisMode字段从2-PIris1开始生效
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 296, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }

        //车牌颜色
        public enum VCA_PLATE_COLOR
        {
            VCA_BLUE_PLATE = 0,//蓝色车牌
            VCA_YELLOW_PLATE,//黄色车牌
            VCA_WHITE_PLATE,//白色车牌
            VCA_BLACK_PLATE,//黑色车牌
            VCA_GREEN_PLATE //绿色车牌
        }

        //车牌类型
        public enum VCA_PLATE_TYPE
        {
            VCA_STANDARD92_PLATE = 0,//标准民用车与军车
            VCA_STANDARD02_PLATE,//02式民用车牌 
            VCA_WJPOLICE_PLATE,//武警车 
            VCA_JINGCHE_PLATE,//警车
            STANDARD92_BACK_PLATE,//民用车双行尾牌
            VCA_SHIGUAN_PLATE,          //使馆车牌
            VCA_NONGYONG_PLATE,         //农用车
            VCA_MOTO_PLATE              //摩托车
        }

        public enum VLR_VEHICLE_CLASS
        {
            VLR_OTHER       = 0,   //其它
	        VLR_VOLKSWAGEN = 1,    //大众
	        VLR_BUICK        = 2,  //别克
	        VLR_BMW         = 3,   //宝马
	        VLR_HONDA       = 4,   //本田
	        VLR_PEUGEOT     = 5,   //标致
	        VLR_TOYOTA      = 6,   //丰田
	        VLR_FORD         = 7,  //福特
	        VLR_NISSAN       = 8,  //日产
	        VLR_AUDI         = 9,  //奥迪
	        VLR_MAZDA       = 10,  //马自达
	        VLR_CHEVROLET  = 11,   //雪佛兰
	        VLR_CITROEN     = 12,  //雪铁龙
	        VLR_HYUNDAI    = 13,   //现代
	        VLR_CHERY       = 14   //奇瑞
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VEHICLE_INFO
        {
            public uint dwIndex;
            public byte byVehicleType;
            public byte byColorDepth;
            public byte byColor;
            public byte byRadarState;
            public ushort wSpeed;
            public ushort wLength;
            public byte byIllegalType;
            public byte byVehicleLogoRecog; //参考枚举类型 VLR_VEHICLE_CLASS
            public byte byVehicleSubLogoRecog; //车辆品牌子类型识别；参考VSB_VOLKSWAGEN_CLASS等子类型枚举。
            public byte byVehicleModel; //车辆子品牌年款，0-未知，参考"车辆子品牌年款.xlsx"
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byCustomInfo;  //自定义信息
            public ushort wVehicleLogoRecog;  //车辆主品牌，参考"车辆主品牌.xlsx" (该字段兼容byVehicleLogoRecog);
            public byte byIsParking;//是否停车 0-无效，1-停车，2-未停车
            public byte byRes;//保留字节
            public uint dwParkingTime; //停车时间，单位：s
            public byte byBelieve; //byIllegalType置信度，1-100
            public byte byCurrentWorkerNumber;//当前作业人数
            public byte byCurrentGoodsLoadingRate;//当前货物装载率 0-空 1-少 2-中 3-多 4-满
            public byte byDoorsStatus;//车门状态 0-车门关闭 1-车门开启
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;

            public void Init()
            {
                byCustomInfo = new byte[16];
                byRes3 = new byte[4];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLATE_RESULT
        {
            public uint dwSize;
            public byte byResultType;
            public byte byChanIndex;
            public ushort wAlarmRecordID;	//报警录像ID(用于查询录像，仅当byResultType为2时有效)
            public uint dwRelativeTime;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byAbsTime;
            public uint dwPicLen;
            public uint dwPicPlateLen;
            public uint dwVideoLen;
            public byte byTrafficLight;
            public byte byPicNum;
            public byte byDriveChan;
            public byte byVehicleType; //0- 未知，1- 客车，2- 货车，3- 轿车，4- 面包车，5- 小货车
            public uint dwBinPicLen;
            public uint dwCarPicLen;
            public uint dwFarCarPicLen;
            public IntPtr pBuffer3;
            public IntPtr pBuffer4;
            public IntPtr pBuffer5;
            public byte byRelaLaneDirectionType;
            public byte byCarDirectionType; 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
            public NET_DVR_PLATE_INFO struPlateInfo;
            public NET_DVR_VEHICLE_INFO struVehicleInfo;
            public IntPtr pBuffer1;
            public IntPtr pBuffer2;

            public void Init()
            {
                byAbsTime = new byte[32];
                byRes3 = new byte[6];
            }
        }

        //图像叠加信息配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IMAGEOVERLAYCFG
        {
            public uint dwSize;
            public byte byOverlayInfo;//叠加使能开关，0-不叠加，1-叠加
            public byte byOverlayMonitorInfo;//是否叠加监测点信息，0-不叠加，1-叠加
            public byte byOverlayTime;//是否叠加时间，0-不叠加，1-叠加
            public byte byOverlaySpeed;//是否叠加速度，0-不叠加，1-叠加
            public byte byOverlaySpeeding;//是否叠加超速比例，0-不叠加，1-叠加
            public byte byOverlayLimitFlag;//是否叠加限速标志，0-不叠加，1-叠加
            public byte byOverlayPlate;//是否叠加车牌号，0-不叠加，1-叠加
            public byte byOverlayColor;//是否叠加车身颜色，0-不叠加，1-叠加
            public byte byOverlayLength;//是否叠加车长，0-不叠加，1-叠加
            public byte byOverlayType;//是否叠加车型，0-不叠加，1-叠加
            public byte byOverlayColorDepth;//是否叠加车身颜色深浅，0-不叠加，1-叠加
            public byte byOverlayDriveChan;//是否叠加车道，0-不叠加，1-叠加
            public byte byOverlayMilliSec; //叠加毫秒信息 0-不叠加，1-叠加
            public byte byOverlayIllegalInfo; //叠加违章信息 0-不叠加，1-叠加
            public byte byOverlayRedOnTime;  //叠加红灯已亮时间 0-不叠加，1-叠加
            public byte byFarAddPlateJpeg;      //远景图是否叠加车牌截图,0-不叠加,1-叠加
            public byte byNearAddPlateJpeg;      //近景图是否叠加车牌截图,0-不叠加,1-叠加
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;    //保留
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byMonitorInfo1;    //监测点信息1
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
            public byte[] byMonitorInfo2; //检测点信息2
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 52, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //保留
        }



        public struct NET_DVR_FACELIB_GUARD_COND
        {
            public uint dwSize;
            public uint dwChannel;  //通道号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 68, ArraySubType = UnmanagedType.I1)]
            public byte[] szFDID;//人脸库的ID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }


        public struct NET_DVR_EVENT_SCHEDULE
        {
            public uint dwSize;//结构体大小
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime; /*布防时间*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struHolidayAlarmTime; /*假日布防时间*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] bySceneID;//场景号,目前支持1~4场景，0为无效。该场景号与布防时间中每个时间段一一对应。
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 72, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SNAPCFG
        {
            public uint dwSize;
            public byte byRelatedDriveWay;
            public byte bySnapTimes;
            public ushort wSnapWaitTime;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_INTERVAL_NUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wIntervalTime;
            public uint dwSnapVehicleNum; //抓拍车辆序号。
            public NET_DVR_JPEGPARA  struJpegPara;//抓拍图片参数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        public enum ITC_MAINMODE_ABILITY
        {
            ITC_MODE_UNKNOW = 0x0,   //无
	        ITC_POST_MODE   = 0x1,  //卡口模式
	        ITC_EPOLICE_MODE      = 0x2,  //电警模式
	        ITC_POSTEPOLICE_MODE  = 0x4  //卡式电警模式
        }

        public enum ITC_RECOG_REGION_TYPE
        {
            ITC_REGION_RECT    = 0x0,   //矩形
	        ITC_REGION_POLYGON  = 0x1,  //多边形
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SNAP_ABILITY
        {
            public uint dwSize;
            public byte byIoInNum;//IO输入口数
            public byte byIoOutNum;//IO输出口数
            public byte bySingleSnapNum;//单IO触发组数
            public byte byLightModeArrayNum;//红绿灯模式组数
            public byte byMeasureModeArrayNum;//测速模式组数
            public byte byPlateEnable; //车牌识别能力
            public byte byLensMode;//镜头模式0-CCD,1-CMOS
            public byte byPreTriggerSupport; //是否支持原触发模式，0-支持，1-不支持
            public uint dwAbilityType; //支持的触发模式能力，按位表示，定义见ITC_MAINMODE_ABILITY
            public byte byIoSpeedGroup; //支持的IO测速组数
            public byte byIoLightGroup; //支持的IO红绿灯组数
            public byte byRecogRegionType; //牌识区域支持的类型，详见定义ITC_RECOG_REGION_TYPE
            public byte bySupport; //设备能力，按位表示，0-不支持，1-支持
	        // bySupport&0x1，表示是否支持扩展的字符叠加配置
	        // bySupport&0x2，表示是否支持扩展的校时配置结构
	        // bySupport&0x4, 表示是否支持多网卡(多网隔离)
	        // bySupport&0x8, 表示是否支持网卡的bonding功能(网络容错)
	        // bySupport&0x10, 表示是否支持语音对讲
	        //2013-07-09 能力集返回
            public ushort wSupportMultiRadar;// 设备能力，按位表示，0-不支持，1-支持
	        // wSupportMultiRadar&0x1，表示 卡口RS485雷达 支持车道关联雷达处理
	        // wSupportMultiRadar&0x2，表示 卡口虚拟线圈 支持车道关联雷达处理
	        // wSupportMultiRadar&0x4，表示 混行卡口 支持车道关联雷达处理
	        // wSupportMultiRadar&0x8，表示 视频检测 支持车道关联雷达处理
            public byte byICRPresetNum;
	        // 表示支持的ICR预置点（滤光片偏移点）数
            public byte byICRTimeSlot;//表示支持的ICR的时间段数（1～8）
            public byte bySupportRS485Num;//表示支持的RS485口的数量
            public byte byExpandRs485SupportSensor;// 设备能力，按位表示，0-不支持，1-支持
	        // byExpandRs485SupportSensor &0x1，表示电警车检器支持车检器
	        // byExpandRs485SupportSensor &0x2，表示卡式电警车检器支持车检器
            public byte byExpandRs485SupportSignalLampDet;// 设备能力，按位表示，0-不支持，1-支持
	        // byExpandRs485SupportSignalLampDet &0x1，表示电警车检器支持外接信号灯检测器
            // byExpandRs485SupportSignalLampDet &0x2，表示卡式电警车检器支持外接信号灯检测器
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 13, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_ICRTIMECFG
        {
            public NET_DVR_SCHEDTIME  struTime;
            public byte byAssociateRresetNo;//预置点号1～8 , 0代表无
            public byte bySubSwitchMode;//1~白天，2~晚上 (当预置点等于0 的时候生效)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_ICR_TIMESWITCH_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_ITC_ICRTIMECFG[] struAutoCtrlTime;//自动切换时间段 (自动切换下 时空下生效 现在支持4组，预留4组)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ICR_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byICRPreset; //实际生效根据能力集动态显示 [0~100] 数组下标表示预置点号1～8 （0～7 相对应）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_ICR_MANUALSWITCH_PARAM
        {	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ICR_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byICRPreset; //实际生效根据能力集动态显示 [0~100]
            public byte  bySubSwitchMode;//1~白天，2~晚上
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 147, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_ICR_AOTOSWITCH_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ICR_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byICRPreset; //实际生效根据能力集动态显示 [0~100] 数组下标表示预置点号1～8 （0～7 相对应）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 148, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_ICR_PARAM_UNION
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 156, ArraySubType = UnmanagedType.I1)]
            public byte[] uLen;
            public NET_ITC_ICR_AOTOSWITCH_PARAM struICRAutoSwitch;
            public NET_ITC_ICR_MANUALSWITCH_PARAM struICRManualSwitch;
            public NET_ITC_ICR_TIMESWITCH_PARAM struICRTimeSwitch;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_ICRCFG
        {
            public uint dwSize;
            public byte bySwitchType;//1~自动切换，2~手动切换 ,3~定时切换 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_ITC_ICR_PARAM_UNION uICRParam;
        }

        //2013-07-09 异常处理
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_HANDLEEXCEPTION
        {
            public uint dwHandleType; //异常处理,异常处理方式的"或"结果
	        /*0x00: 无响应*/
	        /*0x01: 监视器上警告*/
	        /*0x02: 声音警告*/
	        /*0x04: 上传中心*/
	        /*0x08: 触发报警输出（继电器输出）*/
	        /*0x10: 触发JPRG抓图并上传Email*/
	        /*0x20: 无线声光报警器联动*/
	        /*0x40: 联动电子地图(目前只有PCNVR支持)*/
	        /*0x200: 抓图并上传FTP*/  
            public byte byEnable; //0～不启用，1～启用
            public byte byRes;
            public ushort wDuration;//持续时间(单位/s)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ITC_EXCEPTIONOUT, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmOutTriggered;//触发输出通道
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_EXCEPTION
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EXCEPTIONNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_ITC_HANDLEEXCEPTION[] struSnapExceptionType; 
            //数组的每个元素都表示一种异常，数组0- 硬盘出错,1-网线断,2-IP 地址冲突, 3-车检器异常, 4-信号灯检测器异常
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRIGCOORDINATE
        {
            public ushort wTopLeftX; /*线圈左上角横坐标（2个字节）*/
            public ushort wTopLeftY; /*线圈左上角纵坐标（2个字节）*/
            public ushort wWdith; /*线圈宽度（2个字节）*/
            public ushort wHeight; /*线圈高度（2个字节）*/
        }

        public enum PROVINCE_CITY_IDX
        {
	        ANHUI_PROVINCE             = 0,              //安徽
	        AOMEN_PROVINCE             = 1,              //澳门
	        BEIJING_PROVINCE           = 2,              //北京
	        CHONGQING_PROVINCE         = 3,              //重庆
	        FUJIAN_PROVINCE            = 4,              //福建
	        GANSU_PROVINCE             = 5,              //甘肃
	        GUANGDONG_PROVINCE         = 6,              //广东
	        GUANGXI_PROVINCE           = 7,              //广西
	        GUIZHOU_PROVINCE           = 8,              //贵州
	        HAINAN_PROVINCE            = 9,              //海南
	        HEBEI_PROVINCE             = 10,             //河北
	        HENAN_PROVINCE             = 11,             //河南
	        HEILONGJIANG_PROVINCE      = 12,             //黑龙江
	        HUBEI_PROVINCE             = 13,             //湖北
	        HUNAN_PROVINCE             = 14,             //湖南
	        JILIN_PROVINCE             = 15,             //吉林
	        JIANGSU_PROVINCE           = 16,             //江苏
	        JIANGXI_PROVINCE           = 17,             //江西
	        LIAONING_PROVINCE          = 18,             //辽宁
	        NEIMENGGU_PROVINCE         = 19,             //内蒙古
	        NINGXIA_PROVINCE           = 20,             //宁夏
	        QINGHAI_PROVINCE           = 21,             //青海
	        SHANDONG_PROVINCE          = 22,             //山东
	        SHANXI_JIN_PROVINCE        = 23,             //山西
	        SHANXI_SHAN_PROVINCE       = 24,             //陕西
	        SHANGHAI_PROVINCE          = 25,             //上海
	        SICHUAN_PROVINCE           = 26,             //四川
	        TAIWAN_PROVINCE            = 27,             //台湾
	        TIANJIN_PROVINCE           = 28,             //天津
	        XIZANG_PROVINCE            = 29,             //西藏
	        XIANGGANG_PROVINCE         = 30,             //香港
	        XINJIANG_PROVINCE          = 31,             //新疆
	        YUNNAN_PROVINCE            = 32,             //云南
	        ZHEJIANG_PROVINCE          = 33              //浙江
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_GEOGLOCATION
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U4)]
            public int[] iRes; /*保留*/
            public uint dwCity; /*城市，详见PROVINCE_CITY_IDX */
        }

        //场景模式
        public enum SCENE_MODE
        {
	        UNKOWN_SCENE_MODE   = 0,            //未知场景模式
	        HIGHWAY_SCENE_MODE  = 1,            //高速场景模式
	        SUBURBAN_SCENE_MODE = 2,            //郊区场景模式(保留)
	        URBAN_SCENE_MODE    = 3,            //市区场景模式
	        TUNNEL_SCENE_MODE   = 4             //隧道场景模式(保留)
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VTPARAM
        {
            public uint dwSize;
            public byte byEnable;  /* 是否使能虚拟线圈，0-不使用，1-使用*/
            public byte byIsDisplay; /* 是否显示虚拟线圈，0-不显示，1-显示*/
            public byte byLoopPos; //晚间触发线圈的偏向：0-向上，1-向下
            public byte bySnapGain; /*抓拍增益*/
            public uint dwSnapShutter; /*抓拍快门速度*/
            public NET_DVR_TRIGCOORDINATE struTrigCoordinate; //保留
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_TRIGCOORDINATE[] struRes;
            public byte byTotalLaneNum;/*视频触发的车道数1*/
            public byte byPolarLenType; /*偏振镜类型，0：不加偏振镜；1：加施耐德偏振镜。*/
            public byte	byDayAuxLightMode; /*白天辅助照明模式，0：无辅助照明；1：LED灯照明；2：闪光灯照明*/
            public byte	byLoopToCalRoadBright; /*用以计算路面亮度的车道(虚拟线圈)*/
            public byte	byRoadGrayLowTh; /*路面亮度低阈值初始化值1*/
            public byte	byRoadGrayHighTh; /*路面亮度高阈值初始化值140*/
            public ushort wLoopPosBias; /*晚间触发线圈位移30*/
            public uint dwHfrShtterInitValue; /*连续图像曝光时间的初始值2000*/
            public uint dwSnapShtterInitValue; /*抓拍图像曝光时间的初始值500*/
            public uint dwHfrShtterMaxValue; /*连续图像曝光时间的最大值20000*/
            public uint dwSnapShtterMaxValue; /*抓拍图像曝光时间的最大值1500*/
            public uint dwHfrShtterNightValue; /*晚间连续图像曝光时间的设置值3000*/
            public uint dwSnapShtterNightMinValue; /*晚间抓拍图像曝光时间的最小值3000*/
            public uint dwSnapShtterNightMaxValue; /*晚间抓拍图像曝光时间的最大值5000*/
            public uint dwInitAfe; /*增益的初始值200*/
            public uint dwMaxAfe; /*增益的最大值400*/
            public ushort wResolutionX;/* 设备当前分辨率宽*/
            public ushort wResolutionY;/* 设备当前分辨率高*/
            public uint dwGainNightValue; /*晚间增益，默认值70*/
            public uint dwSceneMode; /*场景模式， 详见SCENE_MODE */
            public uint dwRecordMode; /*录像标志：0-不录像，1-录像*/
            public NET_DVR_GEOGLOCATION struGeogLocation; /*地址位置*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VL_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byTrigFlag; /*触发标志，0-车头触发；1-车尾触发；2-车头/车尾都触发*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VL_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byTrigSensitive;  /*触发灵敏度，1-100*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 62, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SNAPENABLECFG
        {
            public uint dwSize;
            public byte byPlateEnable;//是否支持车牌识别，0-不支持，1-支持
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;   //保留
            public byte byFrameFlip;   //图像是否翻转 0-不翻转，1-翻转
            public ushort wFlipAngle;    //图像翻转角度 0,90,180,270
            public ushort wLightPhase;   //相位，取值范围[0, 360]
            public byte byLightSyncPower;  //是否信号灯电源同步，0-不同步；1-同步
            public byte byFrequency;		//信号频率
            public byte byUploadSDEnable;  //是否自动上传SD图片，0-否；1-是
            public byte byPlateMode; //识别模式参数:0-视频触发,1-外部触发
            public byte byUploadInfoFTP; //是否上传抓拍附加信息到FTP，0-否，1-是
            public byte byAutoFormatSD; //是否自动格式化SD卡，0-否，1-是
            public ushort wJpegPicSize; //Jpeg图片大小[64-8196]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 56, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //保留
        }



        /*ftp上传参数*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FTPCFG
        {
            public uint dwSize;
            public uint dwEnableFTP;			/*是否启动ftp上传功能*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sFTPIP;				/*ftp 服务器*/
            public uint dwFTPPort;				/*ftp端口*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;	/*用户名*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;	/*密码*/
            public uint dwDirLevel;	/*0 = 不使用目录结构，直接保存在根目录,1 = 使用1级目录,2=使用2级目录*/
            public ushort wTopDirMode;	/* 一级目录，0x1 = 使用设备名,0x2 = 使用设备号,0x3 = 使用设备ip地址，0x4=使用监测点,0x5=使用时间(年月),0x=6自定义,0x7=违规类型,0x8=方向,0x9=地点*/
            public ushort wSubDirMode;	/* 二级目录，0x1 = 使用通道名,0x2 = 使用通道号，,0x3=使用时间(年月日),0x4=使用车道号,0x=5自定义,0x6=违规类型,0x7=方向,0x8=地点*/
            public byte byEnableAnony; //启用匿名，0-否，1-是
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*可用来命名图片的相关元素 */
        public const int PICNAME_ITEM_DEV_NAME = 1;		/*设备名*/
        public const int PICNAME_ITEM_DEV_NO = 2;		/*设备号*/
        public const int PICNAME_ITEM_DEV_IP = 3;		/*设备IP*/
        public const int PICNAME_ITEM_CHAN_NAME = 4;	/*通道名*/
        public const int PICNAME_ITEM_CHAN_NO = 5;		/*通道号*/
        public const int PICNAME_ITEM_TIME = 6;		/*时间*/
        public const int PICNAME_ITEM_CARDNO = 7;		/*卡号*/
        public const int PICNAME_ITEM_PLATE_NO = 8;   /*车牌号码*/
        public const int PICNAME_ITEM_PLATE_COLOR = 9;   /*车牌颜色*/
        public const int PICNAME_ITEM_CAR_CHAN = 10;  /*车道号*/
        public const int PICNAME_ITEM_CAR_SPEED = 11;  /*车辆速度*/
        public const int PICNAME_ITEM_CARCHAN = 12;  /*监测点*/
        public const int PICNAME_ITEM_PIC_NUMBER = 13;  //图片序号
        public const int PICNAME_ITEM_CAR_NUMBER = 14;  //车辆序号

        public const int PICNAME_ITEM_SPEED_LIMIT_VALUES = 15; //限速值
        public const int PICNAME_ITEM_ILLEGAL_CODE = 16; //国标违法代码
        public const int PICNAME_ITEM_CROSS_NUMBER = 17; //路口编号
        public const int PICNAME_ITEM_DIRECTION_NUMBER = 18; //方向编号

        public const int PICNAME_MAXITEM = 15;
        //图片命名
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PICTURE_NAME
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PICNAME_MAXITEM, ArraySubType = UnmanagedType.I1)]
            public byte[] byItemOrder;	/*	桉数组定义文件命名的规则 */
            public byte byDelimiter;		/*分隔符，一般为'_'*/
        }


        //命名规则：2013-09-27
        public const int PICNAME_ITEM_PARK_DEV_IP = 1;	/*设备IP*/
        public const int PICNAME_ITEM_PARK_PLATE_NO = 2;/*车牌号码*/
        public const int PICNAME_ITEM_PARK_TIME = 3;	/*时间*/
        public const int PICNAME_ITEM_PARK_INDEX = 4;   /*车位编号*/
        public const int PICNAME_ITEM_PARK_STATUS = 5;  /*车位状态*/

        //图片命名扩展 2013-09-27
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PICTURE_NAME_EX
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PICNAME_MAXITEM, ArraySubType = UnmanagedType.I1)]
            public byte[] byItemOrder;	/*	桉数组定义文件命名的规则 */
            public byte byDelimiter;	            	/*分隔符，一般为'_'*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                      /*保留*/
        }

        /* 串口抓图设置*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SERIAL_CATCHPIC_PARA
        {
            public byte byStrFlag;	/*串口数据开始符*/
            public byte byEndFlag;	/*结束符*/
            public ushort wCardIdx;	/*卡号相对起始位*/
            public uint dwCardLen;	/*卡号长度*/
            public uint dwTriggerPicChans;	/*所触发的通道号，按位，从第1位开始计，即0x2表示第一通道*/
        }

        //DVR抓图参数配置（基线）
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_JPEGCFG_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_JPEGPARA[] struJpegPara;	/*每个通道的图像参数*/
            public ushort wBurstMode;							/*抓图方式,按位设置.0x1=报警输入触发，0x2=移动侦测触发 0x4=232触发，0x8=485触发，0x10=网络触发*/
            public ushort wUploadInterval;					/*图片上传间隔(秒)[0,65535]*/
            public NET_DVR_PICTURE_NAME 	struPicNameRule;	/* 图片命名规则 */
            public byte bySaveToHD;		/*是否保存到硬盘*/
            public byte byRes1;
            public ushort wCatchInterval;		/*抓图间隔(毫秒)[0,65535]*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public NET_DVR_SERIAL_CATCHPIC_PARA struRs232Cfg;
            public NET_DVR_SERIAL_CATCHPIC_PARA struRs485Cfg;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.U4)]
            public uint[] dwTriggerPicTimes;	/* 每个通道一次触发拍照次数 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN_V30, ArraySubType = UnmanagedType.U4)]
            public uint[] dwAlarmInPicChanTriggered; /*报警触发抓拍通道,按位设置，从第1位开始*/
        }

        //手动触发参数
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MANUALSNAP
        {
            public byte byOSDEnable;
            public byte byLaneNo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 22, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int NET_ITC_GET_TRIGGERCFG = 3003; //获取触发参数
        public const int NET_ITC_SET_TRIGGERCFG = 3004; //设置触发参数
        public const int NET_DVR_GET_CURTRIGGERMODE = 3130; //获取设备当前触发模式
        public const int NET_ITC_GET_VIDEO_TRIGGERCFG = 3017;  //获取视频电警触发参数
        public const int NET_ITC_SET_VIDEO_TRIGGERCFG = 3018;  //设置视频电警触发参数

        public const int MAX_ITC_LANE_NUM = 6;
        public const int MAX_IOOUT_NUM = 4;
        public const int MAX_LANEAREA_NUM = 2;
        public const int MAX_IOIN_NUMEX = 10;

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_ITC_SERIAL_INFO
        {
            public byte bySerialProtocol;
            public byte byIntervalType;
            public ushort wInterval;
            public byte byNormalPassProtocol;
            public byte byInverseProtocol;
            public byte bySpeedProtocol;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_ITC_EPOLICE_LANE_PARAM
        {
            public byte byEnable;
            public byte byRelatedDriveWay;
            public ushort wDistance;
            public byte byRecordEnable;
            public byte byRecordType;
            public byte byPreRecordTime;
            public byte byRecordDelayTime;
            public byte byRecordTimeOut;
            public byte bySignSpeed;
            public byte bySpeedLimit;
            public byte byOverlayDriveWay;
            public NET_ITC_SERIAL_INFO struSerialInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IOOUT_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelatedIOOut;
            public byte byFlashMode;
            public byte bySerialType;
            public byte byRelatedIOOutEx;
            public byte bySnapPicPreRecord;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LANEAREA_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_ITC_PLATE_RECOG_REGION_PARAM[] struPlateRecog;
            public byte byBigCarSignSpeed;
            public byte byBigCarSpeedLimit;
            public byte byRedTrafficLightChan;
            public byte byYellowTrafficLightChan;
            public byte byRelaLaneDirectionType;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_ITC_EPOLICE_RS485_PARAM
        {
            public byte byRelatedLaneNum;
            public byte byTrafficLightSignalSrc;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_ITC_PLATE_RECOG_PARAM struPlateRecog;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ITC_LANE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_ITC_EPOLICE_LANE_PARAM[] struLane;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_ITC_SINGLEIO_PARAM
        {
            public byte byDefaultStatus;
            public byte byRelatedDriveWay;
            public byte bySnapTimes;
            public byte byRelatedIOOutEx;
            public NET_ITC_INTERVAL_PARAM struInterval;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IOOUT_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelatedIOOut;
            public byte byFlashMode;
            public byte byEnable;
            public byte byUseageType;
            public byte byRes2;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LANEAREA_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_ITC_PLATE_RECOG_REGION_PARAM[] struPlateRecog;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_ITC_POST_SINGLEIO_PARAM
        {
            public NET_ITC_PLATE_RECOG_PARAM struPlateRecog;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IOIN_NUMEX, ArraySubType = UnmanagedType.Struct)]
            public NET_ITC_SINGLEIO_PARAM[] struSingleIO;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_CURTRIGGERMODE
        {
            public uint dwSize;
            public uint dwTriggerType;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_ITC_PLATE_RECOG_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 3)]
            public string byDefaultCHN;
            public byte byEnable;
            public uint dwRecogMode;
            public byte byVehicleLogoRecog;
            public byte byProvince;
            public byte byRegion;
            public byte byRes1;
            public ushort wPlatePixelWidthMin;
            public ushort wPlatePixelWidthMax;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_ITC_INTERVAL_PARAM
        {
            public byte byIntervalType;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_INTERVAL_NUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wInterval;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct UNION_REGION
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 164, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_ITC_PLATE_RECOG_REGION_PARAM
        {
            public byte byMode;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public UNION_REGION uRegion;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_ITC_LANE_PARAM
        {
            public byte byEnable;
            public byte byRelatedDriveWay;
            public ushort wDistance;
            public ushort wTrigDelayTime;
            public byte byTrigDelayDistance;
            public byte bySpeedCapEn;
            public byte bySignSpeed;
            public byte bySpeedLimit;
            public byte bySnapTimes;
            public byte byOverlayDriveWay;
            public NET_ITC_INTERVAL_PARAM struInterval;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IOOUT_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelatedIOOut;
            public byte byFlashMode;
            public byte byCartSignSpeed;
            public byte byCartSpeedLimit;
            public byte byRelatedIOOutEx;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LANEAREA_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_ITC_PLATE_RECOG_REGION_PARAM[] struPlateRecog;
            public byte byLaneType;
            public byte byUseageType;
            public byte byRelaLaneDirectionType;
            public byte byLowSpeedLimit;
            public byte byBigCarLowSpeedLimit;
            public byte byLowSpeedCapEn;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_ITC_RADAR_PARAM
        {
            public byte byRadarType;
            public byte byLevelAngle;
            public ushort wRadarSensitivity;
            public ushort wRadarSpeedValidTime;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public float fLineCorrectParam;
            public int iConstCorrectParam;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_ITC_POST_RS485_RADAR_PARAM
        {
            public byte byRelatedLaneNum;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_ITC_PLATE_RECOG_PARAM struPlateRecog;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ITC_LANE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_ITC_LANE_PARAM[] struLane;
            public NET_ITC_RADAR_PARAM struRadar;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_ITC_TRIGGER_PARAM_UNION
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4280, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_ITC_SINGLE_TRIGGERCFG
        {
            public byte byEnable;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwTriggerType;
            public NET_ITC_TRIGGER_PARAM_UNION uTriggerParam;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_ITC_TRIGGERCFG
        {
            public uint dwSize;
            public NET_ITC_SINGLE_TRIGGERCFG struTriggerParam;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_ITC_VIDEO_TRIGGER_COND
        {
            public uint dwSize;
            public uint dwChannel;
            public uint dwTriggerMode;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_ITC_VIDEO_TRIGGER_PARAM_UNION
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 1150, ArraySubType = UnmanagedType.U4)]
            public uint[] uLen;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_ITC_LIGHT_ACCESSPARAM_UNION
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 122, ArraySubType = UnmanagedType.U4)]
            public uint[] uLen;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_ITC_TRAFFIC_LIGHT_PARAM
        {
            public byte bySource; //交通信号灯接入源，0-IO接入，1-RS485接入
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_ITC_LIGHT_ACCESSPARAM_UNION struLightAccess;//信号灯接入参数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //车道属性参数结构
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_ITC_LANE_LOGIC_PARAM
        {
            public byte byUseageType;     //车道用途类型，详见ITC_LANE_USEAGE_TYPE
            public byte byDirectionType;  //车道方向类型，详见ITC_LANE_DIRECTION_TYPE
            public byte byCarDriveDirect; //车辆行驶方向，详见ITC_LANE_CAR_DRIVE_DIRECT 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 33, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;        //保留
        }

        //违规检测参数结构
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_ITC_VIOLATION_DETECT_PARAM
        {
            public uint dwVioDetectType; //违规检测类型, 按位表示, 详见ITC_VIOLATION_DETECT_TYPE ,0-不启用,1-启用
            public byte byDriveLineSnapTimes; //压车道线抓拍张数,2-3
            public byte byReverseSnapTimes; //逆行抓拍,2-3
            public ushort wStayTime; //机占非停留时间（该时间后抓拍），单位s
            public byte byNonDriveSnapTimes;//机占非抓拍张数2-3
            public byte byChangeLaneTimes;//违法变道抓拍张数 2-3
            public byte bybanTimes;//违法禁令抓拍张数2-3
            public byte byDriveLineSnapSen;// 压线灵敏度(0~100)(3.7Ver)
            public ushort wSnapPosFixPixel; //第2,3张抓拍位置最小偏移(违反信号灯时起效)（单位：像素） 命名需改进
            public byte bySpeedTimes;//违法超速抓拍张数2-3(3.8Ver)
            public byte byTurnAroundEnable;//违章掉头使能 0~关闭 1~开启
            public byte byThirdPlateRecogTime;//第三张牌识时间 0~180s
            public byte byPostSnapTimes;//卡口抓拍张数,1-2张
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public ushort wStopLineDis;  //电警第2张违规图片与停止线的最短距离，[0,300]单位(像素)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_ITC_VIDEO_TRIGGER_PARAM
        {
            public uint dwSize;
            public uint dwMode;
            public NET_ITC_VIDEO_TRIGGER_PARAM_UNION uVideoTrigger;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_LAMP_EXTERNAL_CFG
        {
            public uint dwSize;
            public byte byEnable; //外控使能 0～不启用 1～启用
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_LAMP_STATE struLampStateCtrl;//指示灯外控
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //指示灯外控
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_LAMP_STATE
        {
            public byte byFlicker;//0~不闪烁 1 ～闪烁
            public byte byParkingIndex;//车位号1～3
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwIONo;//1~IO1;2~IO2;4~IO3;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        public const int MAX_LED_INFO_LEN = 512;
        public const int MAX_VOICE_INFO_LEN = 128;

        public const int NET_DVR_GET_LEDDISPLAY_CFG = 3673;
        public const int NET_DVR_SET_LEDDISPLAY_CFG = 3672;
        public const int NET_DVR_SET_VOICEBROADCAST_CFG = 3675;


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LEDDISPLAY_CFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LED_INFO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDisplayInfo;
            public byte byDisplayMode;
            public byte bySpeedType;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwShowTime;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VOICEBROADCAST_CFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VOICE_INFO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sInfo; //语音播报内容
            public byte byBroadcastNum;// 语音播报次数， 1~10次
            public byte byIntervalTime;// 语音播报间隔时间,1~5s
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 126, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_ITC_VIDEO_EPOLICE_PARAM
        {
            public byte byEnable;    //是否启用，0-不启用，1-启用
            public byte byLaneNum; //识别的车道个数
            public byte byLogicJudge;//闯红灯违规判断逻辑，设置值为：0-按方向，1-按车道
            public byte byRes1;
            public NET_ITC_PLATE_RECOG_PARAM struPlateRecog; //牌识参数
            public NET_ITC_TRAFFIC_LIGHT_PARAM struTrafficLight; //交通信号灯参数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ITC_LANE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_ITC_LANE_VIDEO_EPOLICE_PARAM[] struLaneParam; //单车道参数
            public NET_ITC_LINE struLaneBoundaryLine; //车道边界线（最右边车道的边界线）
            public NET_ITC_LINE struLeftLine; //左转弯分界线
            public NET_ITC_LINE struRightLine; //右转弯分界线
            public NET_ITC_LINE struTopZebraLine; //上部斑马线
            public NET_ITC_LINE struBotZebraLine; //下部斑马线
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //视频电警线结构
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_ITC_LINE
        {
            public NET_VCA_LINE struLine; //线参数
            public byte byLineType; //线类型，详见ITC_LINE_TYPE
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //多边型结构体
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_ITC_POLYGON
        {
            public uint dwPointNum; //有效点 大于等于3，若是3点在一条线上认为是无效区域，线交叉认为是无效区域 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_POINT[] struPos; //多边形边界点,最多20个 
        }

        //违规检测线参数结构
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_ITC_VIOLATION_DETECT_LINE
        {
            public NET_ITC_LINE struLaneLine; //车道线参数
            public NET_ITC_LINE struStopLine; //停止线参数
            public NET_ITC_LINE struRedLightLine; //闯红灯触发线参数
            public NET_ITC_LINE struCancelLine; //直行触发位置取消线
            public NET_ITC_LINE struWaitLine; //待行区停止线参数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.Struct)]
            public NET_ITC_LINE[] struRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_ITC_LANE_VIDEO_EPOLICE_PARAM
        {
            public byte byLaneNO; //关联的车道号
            public byte bySensitivity; //线圈灵敏度，[1,100]
            public byte byEnableRadar;//启用雷达测试0-不启用，1-启用
            //关联车道方向类型，参考ITC_RELA_LANE_DIRECTION_TYPE
            //该参数为车道方向参数，与关联车道号对应，确保车道唯一性。
            public byte byRelaLaneDirectionType;
            public NET_ITC_LANE_LOGIC_PARAM struLane; //车道参数
            public NET_ITC_VIOLATION_DETECT_PARAM struVioDetect; //违规检测参数
            public NET_ITC_VIOLATION_DETECT_LINE struLine; //违规检测线
            public NET_ITC_POLYGON struPlateRecog; //牌识区域参数
            public byte byRecordEnable;//闯红灯周期录像标志，0-不录像，1-录像
            public byte byRecordType;//闯红灯录像类型，0-预录，1-延时录像
            public byte byPreRecordTime;//闯红灯录像片段预录时间（默认0），单位：秒
            public byte byRecordDelayTime;//闯红灯录像片段延时时间（默认0），单位：秒
            public byte byRecordTimeOut;//闯红灯周期录像超时时间（秒）
            public byte byCarSpeedLimit; //车速限制值，单位km/h
            public byte byCarSignSpeed;//标志限速，单位km/h
            public byte bySnapPicPreRecord; //抓拍图片预录时间点；0-默认值（第二张图片），1-第一张图片，2-第二张图片，3-第三张图片
            public NET_ITC_INTERVAL_PARAM struInterval;//抓拍间隔参数（20byte）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 36, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SPRCFG    
        {
            public uint dwSize; 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHJC_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byDefaultCHN; /*设备运行省份的汉字简写*/
            public byte byPlateOSD;    /*0:不发送车牌彩色图,1:发送车牌彩色图*/
            public byte bySendJPEG1;   /*0-不传送近景JPEG图,1-传送近景JPEG图*/
            public byte bySendJPEG2;   /*0-不传送远景JPEG图,1-传送远景JPEG图*/
            public ushort wDesignedPlateWidth;   /*车牌设计宽度*/
            public byte byTotalLaneNum;  /*识别的车道数*/
            public byte byRes1;      /*保留*/
            public ushort wRecognizedLane;  /*识别的车道号，按位表示，bit0表示车道1是否识别，0-不识别，1-识别*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LANERECT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_RECT[] struLaneRect;  /*车道识别区域*/
            public uint dwRecogMode;  /*识别的类型，
	        bit0-背向识别：0-正向车牌识别，1-背向识别(尾牌识别) ； 
		    bit1-大车牌识别或小车牌识别：0-小车牌识别，1-大车牌识别 ；
		    bit2-车身颜色识别：0-不采用车身颜色识别，在背向识别或小车牌识别时禁止启用，1-车身颜色识别；
		    bit3-农用车识别：0-不采用农用车识别，1-农用车识别； 
		    bit4-模糊识别：0-不采用模糊识别，1-模糊识别；
		    bit5-帧定位或场定位：0-帧定位，1-场定位；
		    bit6-帧识别或场识别：0-帧识别，1-场识别； 
		    bit7-晚上或白天：0-白天，1-晚上 */
            public byte bySendPRRaw;       	//是否发送原图：0-不发送，1-发送 
            public byte bySendBinImage;  	//是否发送车牌二值图：0-不发送，1-发送 
            public byte byDelayCapture;  //延时抓拍控制,单位：帧
            public byte byUseLED;    //使用LED控制，0-否，1-是
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 68, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;    //保留
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLCCFG
        {
            public uint dwSize;
            public byte byPlcEnable;	//是否启用车牌亮度补偿（默认启用）：0-关闭，1-启用 
            public byte byPlateExpectedBright;	//车牌的预期亮度（默认值50）, 范围[0, 100]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;	//保留 
            public byte byTradeoffFlash;     //是否考虑闪光灯的影响: 0 - 否;  1 - 是(默认); 
	        //使用闪光灯补光时, 如果考虑减弱闪光灯的亮度增强效应, 则需要设为1;否则为0
            public byte byCorrectFactor;     //纠正系数, 范围[0, 100], 默认值50 (在tradeoff_flash切换时,恢复默认值）
            public ushort wLoopStatsEn;  //是否该线圈的亮度，按位表示，0-不统计，1-统计
            public byte byPlcBrightOffset;// 车牌亮度补偿灵敏度(虚拟线圈模式起效)，取值范围1~100
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 19, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEVICESTATECFG
        {
            public uint dwSize;
            public ushort wPreviewNum; //预览连接个数
            public ushort wFortifyLinkNum; //布防连接个数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LINK, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPADDR[] struPreviewIP;  //预览的用户IP地址
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_FORTIFY_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPADDR[] struFortifyIP; //布防连接的用户IP地址
            public uint dwVideoFrameRate;	//帧率：0-全部; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20; 14-15; 15-18; 16-22;
            public byte byResolution;  	//分辨率0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF 5（保留）,16-VGA（640*480）, 17-UXGA（1600*1200）, 18-SVGA （800*600）,19-HD720p（1280*720）,20-XVGA,  21-HD900p, 27-HD1080i, 28-2560*1920, 29-1600*304, 30-2048*1536, 31-2448*2048
            public byte bySnapResolution;  	//抓拍分辨率0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF 5（保留）,16-VGA（640*480）, 17-UXGA（1600*1200）, 18-SVGA （800*600）,19-HD720p（1280*720）,20-XVGA,  21-HD900p, 27-HD1080i, 28-2560*1920, 29-1600*304, 30-2048*1536, 31-2448*2048
            public byte byStreamType; //传输类型：0-主码流；1-子码流
            public byte byTriggerType; //触发模式：0-视频触发；1-普通触发
            public uint dwSDVolume;  //SD卡容量
            public uint dwSDFreeSpace; //SD卡剩余空间
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DRIVECHAN_NUM * MAX_COIL_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byDetectorState;  //车检器状态：0-未使用；1-正常；2-异常
            public byte byDetectorLinkState; //车检器连接状态：0-未连接；1-连接
            public byte bySDStatus;    //SD卡状态 0－活动；1－休眠；2－异常，3-无sd卡
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_FORTIFY_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byFortifyLevel; //布防等级，0-无，1-一等级（高），2-二等级（中），3-三等级（低）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 116, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //保留
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POSTEPOLICECFG
        {
            public uint dwSize;
            public uint dwDistance;//线圈距离,单位cm，取值范围[0,20000]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SIGNALLIGHT_NUM, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLightChan;	//信号灯通道号
            public byte byCapSpeed;//标志限速，单位km/h，取值范围[0,255]
            public byte bySpeedLimit;//限速值，单位km/h，取值范围[0,255]
            public byte byTrafficDirection;//车流方向，0-由东向西，1-由西向东，2-由南向北，3-由北向南
            public byte byRes1; //保留
            public ushort wLoopPreDist;        /*触发延迟距离 ，单位：分米*/
            public ushort wTrigDelay;             /*触发硬延时时间 ，单位：毫秒*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//保留字节
        }
        /***************************** end *********************************************/
        public const int IPC_PROTOCOL_NUM = 50;  //ipc 协议最大个数

        //协议类型
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PROTO_TYPE
        {
            public uint dwType;               /*ipc协议值*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDescribe; /*协议描述字段*/
        }

        //协议列表
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPC_PROTO_LIST
        {    
            public uint dwSize; 
            public uint dwProtoNum;           /*有效的ipc协议数目*/  
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = IPC_PROTOCOL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PROTO_TYPE[] struProto;   /*有效的ipc协议*/    
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //协议列表V41
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPC_PROTO_LIST_V41
        {   
            public uint dwSize;  
            public uint dwProtoNum;  //有效的ipc协议数目
            public IntPtr pBuffer;    //协议列表缓冲区, dwProtoNum 个NET_DVR_PROTO_TYPE结构  
            public uint dwBufferLen; //缓冲区长度
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   
        }


        public const int MAX_ALERTLINE_NUM = 8; //最大警戒线条数	
        
        //越界侦测查询条件
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRAVERSE_PLANE_SEARCHCOND
        {	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALERTLINE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_TRAVERSE_PLANE[] struVcaTraversePlane;  //穿越境界面参数
            public uint dwPreTime;   /*智能报警提前时间 单位:秒*/
            public uint dwDelayTime; /*智能报警延迟时间 单位:秒*/ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5656, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //保留
        } 

        public const int MAX_INTRUSIONREGION_NUM = 8; //最大区域数数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INTRUSION_SEARCHCOND  
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_INTRUSIONREGION_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_INTRUSION[] struVcaIntrusion; //入侵区域
            public uint dwPreTime;   /*智能报警提前时间 单位:秒*/
            public uint dwDelayTime; /*智能报警延迟时间 单位:秒*/ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5400, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //保留
        }


        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_AREA_SMARTSEARCH_COND_UNION
        {  
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6144, ArraySubType = UnmanagedType.I1)]
            public byte[] byLen;  //结构体长度
            /*[FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64 * 96, ArraySubType = UnmanagedType.I1)]
            public byte[] byMotionScope; //侦测区域 0-96位表示64行，共有96*64个小宏块，1-是移动侦测区域，0-非移动侦测区域 
            [FieldOffsetAttribute(0)]
            public NET_DVR_TRAVERSE_PLANE_SEARCHCOND struTraversPlaneCond; //越界侦测
            [FieldOffsetAttribute(0)]
            public NET_DVR_INTRUSION_SEARCHCOND struIntrusionCond; //区域入侵
             * */
        }

        //智能搜索参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SMART_SEARCH_PARAM
        {
            public byte byChan;					//通道号
            public byte bySearchCondType; //智能查找联合体NET_DVR_AREA_SMARTSEARCH_COND_UNION的索引     
	        /*0-移动侦测区域 ，1-越界侦测， 2-区域入侵*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_TIME struStartTime;		//录像开始的时间
            public NET_DVR_TIME struEndTime;		//录像停止的时间
            public NET_DVR_AREA_SMARTSEARCH_COND_UNION uSmartSearchCond;  //智能查找条件
            public byte bySensitivity;   			//移动侦测搜索灵敏度,1	>80%  2 40%~80%  3 1%~40%
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }
    
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SMART_SEARCH_RET
        {
            public NET_DVR_TIME struStartTime;	//移动侦测报警开始的时间
            public NET_DVR_TIME struEndTime;   //事件停止的时间
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //IPSAN 文件目录查找
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPSAN_SERACH_PARAM
        {
            public NET_DVR_IPADDR  struIP;     // IPSAN IP地址
            public ushort wPort;      // IPSAN  端口
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  // 保留字节
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPSAN_SERACH_RET
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byDirectory;  // 返回的文件目录
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //DVR设备参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEVICECFG_V40
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDVRName; //DVR名称
            public uint dwDVRID;				//DVR ID,用于遥控器 //V1.4(0-99), V1.5(0-255)
            public uint dwRecycleRecord;		//是否循环录像,0:不是; 1:是
            //以下不可更改
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber; //序列号
            public uint dwSoftwareVersion;			//软件版本号,高16位是主版本,低16位是次版本
            public uint dwSoftwareBuildDate;			//软件生成日期,0xYYYYMMDD
            public uint dwDSPSoftwareVersion;		    //DSP软件版本,高16位是主版本,低16位是次版本
            public uint dwDSPSoftwareBuildDate;		// DSP软件生成日期,0xYYYYMMDD
            public uint dwPanelVersion;				// 前面板版本,高16位是主版本,低16位是次版本
            public uint dwHardwareVersion;	// 硬件版本,高16位是主版本,低16位是次版本
            public byte byAlarmInPortNum;		//DVR报警输入个数
            public byte byAlarmOutPortNum;		//DVR报警输出个数
            public byte byRS232Num;			//DVR 232串口个数
            public byte byRS485Num;			//DVR 485串口个数 
            public byte byNetworkPortNum;		//网络口个数
            public byte byDiskCtrlNum;			//DVR 硬盘控制器个数
            public byte byDiskNum;				//DVR 硬盘个数
            public byte byDVRType;				//DVR类型, 1:DVR 2:ATM DVR 3:DVS ......
            public byte byChanNum;				//DVR 通道个数
            public byte byStartChan;			//起始通道号,例如DVS-1,DVR - 1
            public byte byDecordChans;			//DVR 解码路数
            public byte byVGANum;				//VGA口的个数 
            public byte byUSBNum;				//USB口的个数
            public byte byAuxoutNum;			//辅口的个数
            public byte byAudioNum;			//语音口的个数
            public byte byIPChanNum;			//最大数字通道数 低8位，高8位见byHighIPChanNum 
            public byte byZeroChanNum;			//零通道编码个数
            public byte bySupport;        //能力，位与结果为0表示不支持，1表示支持，
            //bySupport & 0x1, 表示是否支持智能搜索
            //bySupport & 0x2, 表示是否支持备份
            //bySupport & 0x4, 表示是否支持压缩参数能力获取
            //bySupport & 0x8, 表示是否支持多网卡
            //bySupport & 0x10, 表示支持远程SADP
            //bySupport & 0x20, 表示支持Raid卡功能
            //bySupport & 0x40, 表示支持IPSAN搜索
	        //bySupport & 0x80, 表示支持rtp over rtsp
            public byte byEsataUseage;		//Esata的默认用途，0-默认备份，1-默认录像
            public byte byIPCPlug;			//0-关闭即插即用，1-打开即插即用
            public byte byStorageMode;		//0-盘组模式,1-磁盘配额, 2抽帧模式
            public byte bySupport1;		//能力，位与结果为0表示不支持，1表示支持
	        //bySupport1 & 0x1, 表示是否支持snmp v30
	        //bySupport1 & 0x2, 支持区分回放和下载
	        //bySupport1 & 0x4, 是否支持布防优先级	
	        //bySupport1 & 0x8, 智能设备是否支持布防时间段扩展
	        //bySupport1 & 0x10, 表示是否支持多磁盘数（超过33个）
	        //bySupport1 & 0x20, 表示是否支持rtsp over http	
            public ushort wDevType;//设备型号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DEV_TYPE_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDevTypeName;//设备型号名称 
            public byte bySupport2; //能力集扩展，位与结果为0表示不支持，1表示支持
	        //bySupport2 & 0x1, 表示是否支持扩展的OSD字符叠加(终端和抓拍机扩展区分)
            public byte byAnalogAlarmInPortNum; //模拟报警输入个数
            public byte byStartAlarmInNo;    //模拟报警输入起始号
            public byte byStartAlarmOutNo;  //模拟报警输出起始号
            public byte byStartIPAlarmInNo;  //IP报警输入起始号  0-无效
            public byte byStartIPAlarmOutNo; //IP报警输出起始号 0-无效
            public byte byHighIPChanNum;     //数字通道个数，高8位 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;			//保留
        }

        public const int MAX_ZEROCHAN_NUM = 16;
        //零通道压缩配置参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ZEROCHANCFG
        {
            public uint dwSize;			    //结构长度
            public byte byEnable;			//0-停止零通道编码，1-表示启用零通道编码
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;			//保留
            public uint dwVideoBitrate; 	/*视频码率 0-保留 1-16K(保留) 2-32K 3-48k 4-64K 5-80K 6-96K 7-128K 8-160k 9-192K 10-224K 11-256K 
                                             * 12-320K 13-384K 14-448K 15-512K 16-640K 17-768K 18-896K 19-1024K 20-1280K 21-1536K 22-1792K
                                             * 23-2048K
                                             * 最高位(31位)置成1表示是自定义码流, 0-30位表示码流值(MIN-32K MAX-8192K) */
            public uint dwVideoFrameRate;	//帧率 0-全部; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20, 
                                            //V2.0增加14-15, 15-18, 16-22;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;        //保留
        }

        //零通道缩放参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ZERO_ZOOMCFG
        {
            public uint dwSize;			    //结构长度
            public NET_VCA_POINT struPoint;	//画面中的坐标点
            public byte byState;		 //现在的状态，0-缩小，1-放大  
            public byte byPreviewNumber;       //预览数目,0-1画面,1-4画面,2-9画面,3-16画面 该参数只读
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOW_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byPreviewSeq;//画面通道信息 该参数只读
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;				//保留 
        }

        public const int DESC_LEN_64 = 64;
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SNMPCFG
        {
            public uint dwSize;			//结构长度
            public byte byEnable;			//0-禁用SNMP，1-表示启用SNMP
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;			//保留
            public ushort wVersion;		//snmp 版本  v1 = 1, v2 =2, v3 =3，设备目前不支持 v3
            public ushort wServerPort; //snmp消息接收端口，默认 161
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byReadCommunity; //读共同体，最多31,默认"public"
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byWriteCommunity;//写共同体,最多31 字节,默认 "private"
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN_64, ArraySubType = UnmanagedType.I1)]
            public byte[] byTrapHostIP;	//自陷主机ip地址描述，支持IPV4 IPV6和域名描述    
            public ushort wTrapHostPort;   //trap主机端口
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byTrapName;	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 70, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;    //保留
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SNMPv3_USER
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byUserName;			// 用户名				
            public byte bySecLevel;	//安全级别 1-无校验 2-无授权校验 3-授权校验
            public byte byAuthtype;	//认证类型 0-MD5认证 1-SHA认证 2: none
            public byte byPrivtype;	//0: DES; 1: AES; 2: none;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAuthpass;	//认证密码
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPrivpass;	//加密密码
        }
        
        //snmpv30
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SNMPCFG_V30
        {
            public uint dwSize;			//结构长度
            public byte byEnableV1;		//0-禁用SNMP V1，1-表示启用SNMP V1
            public byte byEnableV2;		//0-禁用SNMP V2，1-表示启用SNMP V2
            public byte byEnableV3;		//0-禁用SNMP V3，1-表示启用SNMP V3
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public ushort wServerPort;					//snmp消息接收端口，默认 161
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byReadCommunity;		//读共同体，最多31,默认"public"
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byWriteCommunity;		//写共同体,最多31 字节,默认 "private"
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN_64, ArraySubType = UnmanagedType.I1)]
            public byte[] byTrapHostIP;		//自陷主机ip地址描述，支持IPV4 IPV6和域名描述    
            public ushort wTrapHostPort;					// trap主机端口
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;       
            public NET_DVR_SNMPv3_USER struRWUser;    // 读写用户
            public NET_DVR_SNMPv3_USER struROUser;    // 只读用户
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byTrapName;
        }
        
        public const int PROCESSING = 0;    //正在处理
        public const int PROCESS_SUCCESS = 100;   //过程完成
        public const int PROCESS_EXCEPTION = 400;   //过程异常
        public const int PROCESS_FAILED = 500;   //过程失败
        public const int PROCESS_QUICK_SETUP_PD_COUNT = 501; //一键配置至少3块硬盘

        public const int SOFTWARE_VERSION_LEN = 48;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SADPINFO
        {
            public NET_DVR_IPADDR struIP;     // 设备IP地址
            public ushort wPort;      // 设备端口号
            public ushort wFactoryType;   // 设备厂家类型
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = SOFTWARE_VERSION_LEN)]
            public string chSoftwareVersion;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string chSerialNo; // 序列号
            public ushort wEncCnt;   // 编码通道个数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;		// MAC 地址
            public NET_DVR_IPADDR struSubDVRIPMask;   // DVR IP地址掩码
            public NET_DVR_IPADDR struGatewayIpAddr;  // 网关
            public NET_DVR_IPADDR struDnsServer1IpAddr;	/* 域名服务器1的IP地址 */
            public NET_DVR_IPADDR struDnsServer2IpAddr;	/* 域名服务器2的IP地址 */
            public byte byDns;
            public byte byDhcp;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 158, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     // 保留字节
        }

        public const int MAX_SADP_NUM = 256;  //搜索到设备最大数目
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SADPINFO_LIST
        {
            public uint dwSize;   //  结构大小
            public ushort wSadpNum;   // 搜索到设备数目
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   // 保留字节
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SADP_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SADPINFO[] struSadpInfo; // 搜索
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SADP_VERIFY
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PASSWD_LEN)]
            public string chPassword;
            public NET_DVR_IPADDR struOldIP;
            public ushort wOldPort;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 62, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEO_CALL_COND
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEO_CALL_PARAM
        {
            public uint dwSize;
            public uint dwCmdType;      //信令类型  0-请求呼叫，1-取消本次呼叫，2-接听本次呼叫 3-拒绝本地来电呼叫 4-被叫响铃超时 5-结束本次通话，6-设备正在通话中，7-客户端正在通话中，8室内机不在线
            public ushort wPeriod;  //期号, 范围[0,9]
            public ushort wBuildingNumber; //楼号
            public ushort wUnitNumber;  //单元号
            public ushort wFloorNumber;  //层号
            public ushort wRoomNumber;    //房间号
            public ushort wDevIndex; //设备编号
            public byte byUnitType; //设备类型，1-门口机，2-管理机，3-室内机，4-围墙机，5-别墅门口机，6-二次确认机，7-8700客户端，8-4200客户端，9-APP
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 115, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     //保留
        }

        //开锁记录
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_UNLOCK_RECORD_INFO
        {
            public byte byUnlockType; //开锁方式，参考UNLOCK_TYPE_ENUM
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1; //保留
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byControlSrc; //操作发起源信息，刷卡开锁时为卡号，蓝牙开锁时为萤石的APP账号，二维码开锁时为访客的手机号，其余情况下为设备编号
            public uint dwPicDataLen; //图片数据长度
            public IntPtr pImage; //图片指针
            public uint dwCardUserID; //持卡人ID
            public ushort nFloorNumber;//刷卡开锁时有效，为楼层号
            public ushort wRoomNumber; //操作发起源附加信息，刷卡开锁时有效，为房间号，
            public ushort wLockID; //（对于门口机，0-表示本机控制器上接的锁、1-表示外接控制器上接的锁）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = LOCK_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byLockName; //刷卡开锁时有效，锁名称，对应门参数配置中门名称
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NET_SDK_EMPLOYEE_NO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byEmployeeNo; //工号（人员ID）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 136, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //保留
        }

        //公告信息阅读回执
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NOTICEDATA_RECEIPT_INFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NOTICE_NUMBER_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byNoticeNumber; //公告编号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 224, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //保留
        }

        //认证记录（设备未实现）
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AUTH_INFO
        {
            public byte byAuthResult; //认证结果：0-无效，1-认证成功，2-认证失败
            public byte byAuthType; //认证方式：0-无效，1-指纹，2-人脸
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1; //保留
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = ACS_CARD_NO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byCardNo; //卡号
            public uint dwPicDataLen; //图片数据长度（当认证方式byAuthType为人脸时有效）
            public IntPtr pImage; //图片指针（当认证方式byAuthType为人脸时有效）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 212, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //保留
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_VIDEO_INTERCOM_EVENT_INFO_UINON
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byLen;
        }

        //可视对讲事件记录
        public struct NET_DVR_VIDEO_INTERCOM_EVENT
        {
            public uint dwSize; //结构体大小
            public NET_DVR_TIME_EX struTime; //时间
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DEV_NUMBER_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDevNumber; //设备编号
            public byte byEventType; //事件信息类型，1-开锁记录，2-公告信息阅读回执，3-认证记录，4-车牌信息上传，5非法卡刷卡事件，6-门口机发卡记录(需要启动门口机发卡功能，刷卡时才会上传该事件)
            public byte byPicTransType;        //图片数据传输方式: 0-二进制；1-url
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1; //保留
            public NET_DVR_VIDEO_INTERCOM_EVENT_INFO_UINON uEventInfo; //事件信息，具体内容参考byEventType取值
            public uint dwIOTChannelNo;    //IOT通道号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 252, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //保留
        }
        
        public struct NET_DVR_CONTROL_GATEWAY
        {
            public uint dwSize; //结构体大小
            public uint dwGatewayIndex; //门禁序号，从1开始
            public byte byCommand; //操作命令，0-关闭，1-打开，2-常开（通道状态），3-恢复（普通状态）
            public byte byLockType; //锁类型，0-普通（以前默认都为0）,1-智能锁
            public ushort wLockID; //锁ID，从1开始（远程开门口机锁时，0表示门口机本机控制器上接的锁、1表示外接控制器上接的锁）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byControlSrc; //操作发起源信息
            public byte byControlType; //开锁类型，1-监视，2-通话
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPassword;       //锁密码，当byLockType为智能锁时有效
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 108, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //保留
          }

        //XML透传接口
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_XML_CONFIG_INPUT
        {
            public uint dwSize;//结构体大小 
            public IntPtr lpRequestUrl;//请求信令，字符串格式 
            public uint dwRequestUrlLen;
            public IntPtr lpInBuffer;//输入参数缓冲区，XML格式 
            public uint dwInBufferSize;
            public uint dwRecvTimeOut;//接收超时时间，单位：ms，填0则使用默认超时5s 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_XML_CONFIG_OUTPUT
        {
            public uint dwSize;//结构体大小 
            public IntPtr lpOutBuffer;//输出参数缓冲区，XML格式 
            public uint dwOutBufferSize;
            public uint dwReturnedXMLSize;//实际输出的XML内容大小 
            public IntPtr lpStatusBuffer;//返回的状态参数(XML格式：ResponseStatus)，获取命令成功时不会赋值，如果不需要，可以置NULL 
            public uint dwStatusSize;//状态缓冲区大小(内存大小) 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CHANNEL_GROUP
        {
            public uint dwSize;//结构体大小 
            public uint dwChannel;//通道号 
            public uint dwGroup; //组号，从0开始，即0表示第1组，1表示第2组，依次类推 
            public byte byID;//设备区域设置ID 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwPositionNo;//场景位置索引号，IPC为0，IPD从1开始  
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 56, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_TRAVERSE_PLANE_DETECTION
        {
            public uint dwSize;//结构体大小 
            public byte byEnable;//使能越界侦测功能：0- 否，1- 是  
            public byte byEnableDualVca; //启用支持智能后检索：0- 不启用，1- 启用 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALERTLINE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_TRAVERSE_PLANE[] struAlertParam;//警戒线参数

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmSched;//布防时间，每周7天，每天最多设置8个时间段 

            public NET_DVR_HANDLEEXCEPTION_V40 struHandleException;//异常处理方式 

            public uint dwMaxRelRecordChanNum;
            public uint dwRelRecordChanNum;

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.U4)]
            public uint[] byRelRecordChan;

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struHolidayTime; //假日布防时间，最多设置8个时间段 

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_STD_CONFIG
        {
            public IntPtr lpCondBuffer;
            public uint dwCondSize;
            public IntPtr lpInBuffer;
            public uint dwInSize;
            public IntPtr lpOutBuffer;
            public uint dwOutSize;
            public IntPtr lpStatusBuffer;
            public uint dwStatusSize;
            public IntPtr lpXmlBuffer;
            public uint dwXmlSize;
            public byte byDataType;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_THERMOMETRY_COND
        {
            public uint dwSize;
            public uint dwChannel;
            public ushort wPresetNo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 62, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_THERMOMETRY_TRIGGER_COND
        {
            public uint dwSize;
            public uint dwChan;
            public uint dwPreset;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EVENT_TRIGGER
        {
            public uint dwSize;
            public NET_DVR_HANDLEEXCEPTION_V41 struHandleException;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRelRecordChan;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PRESETCHAN_INFO[] struPresetChanInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CRUISECHAN_INFO[] struCruiseChanInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PTZTRACKCHAN_INFO[] struPtzTrackInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_THERMOMETRY_ALARMRULE
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = THERMOMETRY_ALARMRULE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_THERMOMETRY_ALARMRULE_PARAM[] struThermometryAlarmRuleParam;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_THERMOMETRY_ALARMRULE_PARAM
        {
            public byte byEnabled;
            public byte byRuleID;
            public byte byRule;
            public byte byRes;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = NAME_LEN)]
            public string szRuleName;
            public float fAlert;
            public float fAlarm;
            public float fThreshold;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_THERMOMETRY_ALARM
        {
            public uint dwSize;
            public uint dwChannel;//通道号
            public byte byRuleID;//规则ID
            public byte byThermometryUnit;//测温单位: 0-摄氏度（℃），1-华氏度（℉），2-开尔文(K)
            public ushort wPresetNo; //预置点号
            public NET_PTZ_INFO struPtzInfo;//ptz坐标信息
            public byte byAlarmLevel;//0-预警 1-报警
            public byte byAlarmType;/*报警类型 0-最高温度 1-最低温度 2-平均温度 3-温差 4-温度突升 5-温度突降*/
            public byte byAlarmRule;//0-大于，1-小于
            public byte byRuleCalibType;//规则标定类型 0-点，1-框，2线
            public NET_VCA_POINT struPoint;//点测温坐标（当规则标定类型为点的时候生效）
            public NET_VCA_POLYGON struRegion;//区域（当规则标定类型为框的时候生效）
            public float fRuleTemperature;/*配置规则温度,精确到小数点后一位(-40-1000),（浮点数+100） */
            public float fCurrTemperature;/*当前温度,精确到小数点后一位(-40-1000),（浮点数+100） */
            public uint dwPicLen;//可见光图片长度
            public uint dwThermalPicLen;//热成像图片长度
            public uint dwThermalInfoLen;//热成像附加信息长度
            public IntPtr pPicBuff; ///可见光图片指针
            public IntPtr pThermalPicBuff;// 热成像图片指针
            public IntPtr pThermalInfoBuff; //热成像附加信息指针
            public NET_VCA_POINT struHighestPoint;//线、框测温最高温度位置坐标（当规则标定类型为线、框的时候生效）
            public float fToleranceTemperature;/* 容差温度,精确到小数点后一位(-40-1000),（浮点数+100） */
            public uint dwAlertFilteringTime;//温度预警等待时间 单位秒 范围为0-200秒，默认为0秒
            public uint dwAlarmFilteringTime;//温度报警等待时间 单位秒 范围为0-200秒，默认为0秒
            public uint dwTemperatureSuddenChangeCycle;//温度突变记录周期，单位秒
            public float fTemperatureSuddenChangeValue;//温度突变值,精确到小数点后一位(大于0)
            public byte byPicTransType;        //图片数据传输方式: 0-二进制；1-url
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwVisibleChannel; //可见光通道通道号
            public uint dwRelativeTime;     // 相对时标
            public uint dwAbsTime;          // 绝对时标
            public float fAlarmRuleTemperature;/* TMA测温配置规则温度,精确到小数点后一位(-40-1000),（浮点数+100） */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_SDK_MANUALTHERM_BASICPARAM
        {
            public uint dwSize;
            public ushort wDistance;//距离(m)[0, 10000]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1; //保留
            public float fEmissivity;//发射率(发射率 精确到小数点后两位)[0.01, 1.00](即：物体向外辐射能量的本领)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //保留
        }


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_SDK_POINT_THERMOMETRY
        {
            public float fPointTemperature;/*点测温当前温度, 当标定为0-点时生效。精确到小数点后一位(-40-1000),（浮点数+100）*10 */
            public NET_VCA_POINT struPoint;//点测温坐标（当规则标定类型为“点”的时候生效）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_SDK_REGION_THERMOMETRY
        {
            public float fMaxTemperature;//最高温度,精确到小数点后一位(-40-1000),（浮点数+100）*10 */
            public float fMinTemperature;//最低温度,精确到小数点后一位(-40-1000),（浮点数+100）*10 */
            public float fAverageTemperature;//平均温度,精确到小数点后一位(-40-1000),（浮点数+100）*10 */
            public float fTemperatureDiff;//温差,精确到小数点后一位(-40-1000),（浮点数+100）*10 */
            public NET_VCA_POLYGON struRegion;//区域、线（当规则标定类型为“框”或者“线”的时候生效）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_SDK_MANUALTHERM_RULE
        {
            public byte byRuleID;//规则ID 0-表示无效，从1开始 （list内部判断数据有效性）
            public byte byEnable;//是否启用
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] szRuleName;//规则名称
            public byte byRuleCalibType;//规则标定类型 0-点，1-框，2-线
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public NET_SDK_POINT_THERMOMETRY struPointTherm;//点测温，当标定为0-点时生效
            public NET_SDK_REGION_THERMOMETRY struRegionTherm; //区域测温，当标定为1-框、2-线时生效。
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 512, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_SDK_MANUAL_THERMOMETRY
        {
            public uint dwSize;//结构体大小
            public uint dwChannel;//通道号
            public uint dwRelativeTime; // 相对时标（只读）
            public uint dwAbsTime;      // 绝对时标（只读）
            public byte byThermometryUnit;//测温单位: 0-摄氏度（℃），1-华氏度（℉），2-开尔文(K)
            public byte byDataType;//数据状态类型:0-检测中，1-开始，2-结束（只读）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_SDK_MANUALTHERM_RULE struRuleInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 512, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //实时温度检测条件结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_REALTIME_THERMOMETRY_COND
        {
            public uint dwSize;
            public uint dwChan;//通道号，从1开始，0xffffffff代表获取全部通道
            public byte byRuleID; //规则ID 0-代表获取全部规则，具体规则ID从1开始 
             /*
              * 1-定时模式：设备每隔一秒上传各个规则测温数据的最高温、最低温和平均温度值、温差
              * 2-温差模式：若上一秒与下一秒的最高温或者最低温或者平均温或者温差值的温差大于等于2摄氏度，则上传最高温、最低温和平均温度值。若大于等于一个小时温差值均小于2摄氏度，则上传最高温、最低温、平均温和温差值
              */
            public byte byMode; //长连接模式， 0-保留（为兼容老设备），1-定时模式，2-温差模式
            public ushort wInterval; //上传间隔，仅温差模式支持，1~3600S，填0则默认3600S上传一次
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //保留
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POINT_THERM_CFG
        {
            public float fTemperature;//当前温度
            public NET_VCA_POINT struPoint;//点测温坐标（当规则标定类型为点的时候生效）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 120, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LINEPOLYGON_THERM_CFG
        {
            public float fMaxTemperature;//最高温
            public float fMinTemperature;//最低温
            public float fAverageTemperature;//平均温
            public float fTemperatureDiff;//温差
            public NET_VCA_POLYGON struRegion;//区域（当规则标定类型为框/线的时候生效）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_THERMOMETRY_UPLOAD
        {
            public uint dwSize;
            public uint dwRelativeTime;     // 相对时标
            public uint dwAbsTime;            // 绝对时标
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] szRuleName;//规则名称
            public byte byRuleID;//规则ID号
            public byte byRuleCalibType;//规则标定类型 0-点，1-框，2-线
            public ushort wPresetNo; //预置点号
            public NET_DVR_POINT_THERM_CFG struPointThermCfg;
            public NET_DVR_LINEPOLYGON_THERM_CFG struLinePolygonThermCfg;
            public byte byThermometryUnit;//测温单位: 0-摄氏度（℃），1-华氏度（℉），2-开尔文(K)
            public byte byDataType;//数据状态类型:0-检测中，1-开始，2-结束
            public byte byRes1;
            /*
                bit0-中心点测温：0-不支持，1-支持；
                bit1-最高点测温：0-不支持，1-支持；
                bit2-最低点测温：0-不支持，1-支持；
            */
            public byte bySpecialPointThermType;// 是否支持特殊点测温
            public float fCenterPointTemperature;//中心点温度,精确到小数点后一位(-40-1500),（浮点数+100）*10 （由bySpecialPointThermType判断是否支持中心点）
            public float fHighestPointTemperature;//最高点温度,精确到小数点后一位(-40-1500),（浮点数+100）*10（由bySpecialPointThermType判断是否支持最高点）
            public float fLowestPointTemperature;//最低点温度,精确到小数点后一位(-40-1500),（浮点数+100）*10（由bySpecialPointThermType判断是否支持最低点）
            public NET_VCA_POINT struHighestPoint;//线、框测温最高温度位置坐标（当规则标定类型为线、框的时候生效）
            public NET_VCA_POINT struLowestPoint;//线、框测温最低温度位置坐标（当规则标定类型为线、框的时候生效）
            public byte yIsFreezedata;//是否数据冻结 0-否 1-是
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public uint dwChan; //通道号，查询条件中通道号为0xffffffff时该字段生效
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 88, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        /***************************** end *********************************************/

        /*******************************备份结构 begin********************************/
        //获取备份设备信息接口定义
        public const int DESC_LEN_32 = 32;   //描述字长度
        public const int MAX_NODE_NUM = 256;  //节点个数

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DESC_NODE
        { 
            public int iValue; 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN_32, ArraySubType = UnmanagedType.I1)]
            public byte[] byDescribe; //描述字段 
            public uint dwFreeSpace; //获取磁盘列表专用,单位为M
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;			  //保留  
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISKABILITY_LIST
        { 
            public uint dwSize;            //结构长度
            public uint dwNodeNum;		 //能力结点个数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NODE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DESC_NODE[] struDescNode;  //描述参数  
        }

        //备份进度列表
        public const int BACKUP_SUCCESS            =    100;  //备份完成
        public const int BACKUP_CHANGE_DEVICE      =    101;  //备份设备已满，更换设备继续备份

        public const int BACKUP_SEARCH_DEVICE      =    300;  //正在搜索备份设备
        public const int BACKUP_SEARCH_FILE        =    301;  //正在搜索录像文件
        public const int BACKUP_SEARCH_LOG_FILE    =    302;  //正在搜索日志文件

        public const int BACKUP_EXCEPTION		   =    400;  //备份异常
        public const int BACKUP_FAIL			   =	500;  //备份失败

        public const int BACKUP_TIME_SEG_NO_FILE   =    501;  //时间段内无录像文件
        public const int BACKUP_NO_RESOURCE        =    502;  //申请不到资源
        public const int BACKUP_DEVICE_LOW_SPACE   =    503;  //备份设备容量不足
        public const int BACKUP_DISK_FINALIZED     =    504;  //刻录光盘封盘
        public const int BACKUP_DISK_EXCEPTION     =    505;  //刻录光盘异常
        public const int BACKUP_DEVICE_NOT_EXIST   =    506;  //备份设备不存在
        public const int BACKUP_OTHER_BACKUP_WORK  =    507;  //有其他备份操作在进行
        public const int BACKUP_USER_NO_RIGHT      =    508;  //用户没有操作权限
        public const int BACKUP_OPERATE_FAIL       =    509;  //操作失败
        public const int BACKUP_NO_LOG_FILE        =    510;  //硬盘中无日志

        //备份过程接口定义
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BACKUP_NAME_PARAM
        {
            public uint dwFileNum;   //文件个数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RECORD_FILE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_FINDDATA_V30[] struFileList; //文件列表
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN_32, ArraySubType = UnmanagedType.I1)]
            public byte[] byDiskDes;   //备份磁盘描述
            public byte byWithPlayer;      //是否备份播放器
            public byte byContinue;    /*是否继续备份 0不继续 1继续*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;         //保留
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BACKUP_TIME_PARAM
        {
            public int lChannel;        //按时间备份的通道
            public NET_DVR_TIME struStartTime;   //备份的起始时间
            public NET_DVR_TIME struStopTime;    //备份的终止时间
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN_32, ArraySubType = UnmanagedType.I1)]
            public byte[] byDiskDes;     //备份磁盘描述
            public byte byWithPlayer;               //是否备份播放器
            public byte byContinue;                 //是否继续备份 0不继续 1继续
            public byte byDrawFrame;			     //0 不抽帧  1 抽帧
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 33, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;					 // 保留字节 
        }
        /********************************* end *******************************************/
        public enum COMPRESSION_ABILITY_TYPE
        {
            COMPRESSION_STREAM_ABILITY = 0, //码流压缩类型
	        MAIN_RESOLUTION_ABILITY = 1,	//主码流压缩分辨率
	        SUB_RESOLUTION_ABILITY  = 2,	//子码流压缩分辨率
	        EVENT_RESOLUTION_ABILITY =  3,  //事件压缩参数分辨率
	        FRAME_ABILITY = 4,				//帧率能力
	        BITRATE_TYPE_ABILITY = 5,		//位率类型能力
	        BITRATE_ABILITY = 6,			//位率上限
	        THIRD_RESOLUTION_ABILITY = 7,   //三码流压缩分辨率
	        STREAM_TYPE_ABILITY = 8,        //码流类型
	        PIC_QUALITY_ABILITY = 9,         //图像质量
	        INTERVAL_BPFRAME_ABILITY = 10,  //BP帧间隔
	        VIDEO_ENC_ABILITY = 11,           //视频编码能力
	        AUDIO_ENC_ABILITY = 12,           //音频编码能力
	        VIDEO_ENC_COMPLEXITY_ABILITY = 13, //视频编码复杂度能力
	        FORMAT_ABILITY = 14, //封装格式能力
        }

        //能力列表
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ABILITY_LIST
        { 
            public uint dwAbilityType;	//能力类型 COMPRESSION_ABILITY_TYPE
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;        //保留字节
            public uint dwNodeNum;		//能力结点个数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NODE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DESC_NODE[]  struDescNode;  //描述参数  
        }

        public const int MAX_ABILITYTYPE_NUM = 12;   //最大能力项

        // 压缩参数能力列表
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSIONCFG_ABILITY
        { 
            public uint dwSize;            //结构长度
            public uint dwAbilityNum;		//能力类型个数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ABILITYTYPE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ABILITY_LIST[] struAbilityNode; //描述参数  
        }

        //模式A 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDATE_MODEA
        {
            public byte byStartMonth;	// 开始月 从1开始
            public byte byStartDay;		// 开始日 从1开始
            public byte byEndMonth;		// 结束月 
            public byte byEndDay;		// 结束日
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// 保留字节
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDATE_MODEB
        {
            public byte byStartMonth;	// 从1开始
            public byte byStartWeekNum;	// 第几个星期 从1开始 
            public byte byStartWeekday;	// 星期几
            public byte byEndMonth;		// 从1开始
            public byte byEndWeekNum;	// 第几个星期 从1开始 
            public byte byEndWeekday;	// 星期几
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// 保留字节 
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDATE_MODEC
        {
            public ushort wStartYear;		// 年
            public byte byStartMon;		// 月
            public byte byStartDay;		// 日
            public ushort wEndYear;		// 年
            public byte byEndMon;		// 月
            public byte byEndDay;		// 日
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_HOLIDATE_UNION
        {	
            //联合体大小 12字节
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.U4)]
            public uint[] dwSize;
            /*[FieldOffsetAttribute(0)]
            public NET_DVR_HOLIDATE_MODEA	struModeA;	// 模式A
            [FieldOffsetAttribute(0)]
            public NET_DVR_HOLIDATE_MODEB	struModeB;	// 模式B
            [FieldOffsetAttribute(0)]
            public NET_DVR_HOLIDATE_MODEC	struModeC;	// 模式C
             * */
        }

        public enum HOLI_DATE_MODE
        {
            HOLIDATE_MODEA = 0,
            HOLIDATE_MODEB,
            HOLIDATE_MODEC
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDAY_PARAM
        {
            public byte byEnable;			// 是否启用
            public byte byDateMode;			// 日期模式 0-模式A 1-模式B 2-模式C
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;			// 保留字节
            public NET_DVR_HOLIDATE_UNION uHolidate;	// 假日日期
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byName;	// 假日名称
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;			// 保留字节
        }

        public const int MAX_HOLIDAY_NUM = 32;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDAY_PARAM_CFG
        {
            public uint dwSize;			// 结构体大小
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HOLIDAY_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_HOLIDAY_PARAM[] struHolidayParam;	// 假日参数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// 保留参数
        }

        //假日报警处理方式
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDAY_HANDLE
        {
            public uint dwSize;				// 结构体大小
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;	// 布防时间段
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 240, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;		// 保留字节
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDAY_RECORD
        {
            public uint dwSize;
            public NET_DVR_RECORDDAY struRecDay;     // 录像参数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_RECORDSCHED[] struRecordSched; // 录像时间段
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      //  保留字节
        }

        public const int MAX_LINK_V30 = 128;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_LINK
        {
            public NET_DVR_IPADDR  struIP;     // 客户端IP
            public int lChannel;   // 通道号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  // 保留字节
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LINK_STATUS
        {
            public uint dwSize;      // 结构体大小
            public ushort wLinkNum;    // 连接的数目
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  // 保留字节
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LINK_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_LINK[] struOneLink;   // 连接的客户端信息
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  // 保留字节
        }

        public const int MAX_BOND_NUM = 2;

                //单BONDING网卡配置结构体
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_ONE_BONDING
        {
            public byte byMode;
            public byte byUseDhcp;
            public byte byMasterCard;
            public byte byStatus;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NETWORK_CARD, ArraySubType = UnmanagedType.I1)]
            public byte[] byBond;
            public NET_DVR_ETHERNET_V30 struEtherNet;
            public NET_DVR_IPADDR struGatewayIpAddr;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //BONDING网卡配置结构体
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_NETWORK_BONDING
        {  
            public uint dwSize;  
            public byte byEnable;
            public byte byNum;  
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_BOND_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_BONDING[] struOneBond;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }


        //磁盘配额
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISK_QUOTA 
        {
            public byte byQuotaType;	 // 磁盘配额类型,1 - 按容量 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;       // 保留字节
            public uint dwHCapacity;     // 分配的磁盘容量高32位 单位MB
            public uint dwLCapacity;     // 分配的磁盘容量低32位 单位MB
            public uint dwHUsedSpace;    // 已使用的磁盘大小高32位 单位MB
            public uint dwLUsedSpace;    // 已使用的磁盘大小低32位 单位MB
            public byte byQuotaRatio;    //	分配的磁盘比例,单位:%
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 21, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;      // 保留字节
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISK_QUOTA_CFG
        {
            public uint dwSize;         // 结构体大小
            public NET_DVR_DISK_QUOTA struPicQuota;    //  图片配额
            public NET_DVR_DISK_QUOTA struRecordQuota;    //  录像配额
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      //保留字节
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TIMING_CAPTURE
        {
            public NET_DVR_JPEGPARA struJpegPara;   // 定时抓图图片质量
            public uint dwPicInterval; //定时抓图时间间隔,单位s   1-1s 2-2s 3-3s 4-4s 5-5s 
                                       //6-10m 7-30m 8-1h 9-12h 10-24h
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      // 保留字节
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_REL_CAPTURE_CHAN
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byChan;    // 按位表示
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;          // 保留字节
        }

        public const int MAX_PIC_EVENT_NUM = 32;
        public const int MAX_ALARMIN_CAPTURE = 16;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_REL_CAPTURE_CHAN_V40
        {
            public uint dwMaxRelCaptureChanNum;  //最大可触发的关联通道数-只读属性
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwChanNo; //触发的关联抓图通道号，按值表示，采用紧凑型排列,0xffffffff表示后续无效
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EVENT_CAPTURE_V40
        {
            public NET_DVR_JPEGPARA struJpegPara;   // 事件抓图图片质量
            public uint dwPicInterval;   // 事件抓图时间间隔  单位为秒 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PIC_EVENT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_REL_CAPTURE_CHAN_V40[] struRelCaptureChan;   // 数组下标 0 移动侦测触发抓图 1 视频遮挡触发抓图 2 视频丢失触发抓图,数组3表示PIR报警抓图，数组4表示无线报警抓图，数组5表示呼救报警抓图,数组6表示智能抓图
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN_CAPTURE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_REL_CAPTURE_CHAN_V40[] struAlarmInCapture;    // 报警输入触发抓图，下标0 代表报警输入1 依次类推
            public uint dwMaxGroupNum;  //设备支持的最大报警输入组数，每组16个报警输入
            public byte byCapTimes; //抓图张数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 59, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EVENT_CAPTURE
        {
            public NET_DVR_JPEGPARA  struJpegPara;   // 事件抓图图片质量
            public uint dwPicInterval;  /*事件抓图时间间隔  单位为秒  1-1s 2-2s 3-3s 4-4s 5-5s 
                                             * 6-10m 7-30m 8-1h 9-12h 10-24h*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PIC_EVENT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_REL_CAPTURE_CHAN[] struRelCaptureChan; /* 数组下标 0 移动侦测触发抓图 1 视频遮挡触发抓图,
                                                                   * 2 视频丢失触发抓图,数组3表示PIR报警抓图，数组4表示无线报警抓图，
                                                                   * 数组5表示呼救报警抓图,数组6表示智能抓图， 数组7表示人脸侦测*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN_CAPTURE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_REL_CAPTURE_CHAN[] struAlarmInCapture;  //报警输入触发抓图，下标0 代表报警输入1 依次类推
            public byte byCapTimes; //抓图张数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 59, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_JPEG_CAPTURE_CFG_V40
        {
            public uint dwSize;               //结构体长度
            public NET_DVR_TIMING_CAPTURE struTimingCapture;    
            public NET_DVR_EVENT_CAPTURE_V40 struEventCapture;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;     // 保留字节
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_JPEG_CAPTURE_CFG
        {
            public uint dwSize;         // 结构体大小
            public NET_DVR_TIMING_CAPTURE struTimingCapture;    
            public NET_DVR_EVENT_CAPTURE struEventCapture;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;     // 保留字节
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CAPTURE_DAY
        {
            public byte byAllDayCapture;	// 是否全天抓图
            public byte byCaptureType;		// 抓图类型：0-定时抓图，1-移动侦测抓图，2-报警抓图，3-移动侦测或报警抓图，4-移动侦测和报警抓图，6-智能报警抓图
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CAPTURE_SCHED
        {
            public NET_DVR_SCHEDTIME struCaptureTime;        // 抓图时间段
            public byte byCaptureType;       // 抓图类型：0-定时抓图，1-移动侦测抓图，2-报警抓图，3-移动侦测或报警抓图，4-移动侦测和报警抓图，6-智能报警抓图
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           // 保留字节
        }

        //通道抓图计划
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCHED_CAPTURECFG
        {
            public uint dwSize;     //结构体
            public byte byEnable;	//是否抓图
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;	//保留字节
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CAPTURE_DAY[] struCaptureDay;//全天抓图计划
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CAPTURE_SCHED[] struCaptureSched;//时间段抓图布防计划
            public NET_DVR_CAPTURE_DAY	struCaptureHoliday;	//假日抓图计划
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CAPTURE_SCHED[] struHolidaySched;	//时间段假日抓图布防计划
            public uint dwRecorderDuration;	//抓图保存最长时间 0xffffffff表示该值无效 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;			//保留字节
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FLOW_TEST_PARAM
        {
            public uint dwSize;              //结构大小
            public int lCardIndex;         //网卡索引
            public uint dwInterval;         //设备上传流量时间间隔, 单位:100ms
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           //保留字节
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FLOW_INFO
        {
            public uint dwSize;             //结构大小
            public uint dwSendFlowSize;     //发送流量大小,单位kbps
            public uint dwRecvFlowSize;     //接收流量大小,单位kbps
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;          //保留 
        }

        //录像标签
        public const int LABEL_NAME_LEN = 40;
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECORD_LABEL
        {
            public uint dwSize;					// 结构体大小
            public NET_DVR_TIME struTimeLabel;			// 标签的时间 
            public byte byQuickAdd;				// 是否快速添加 快速添加时标签名称无效
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;				// 保留字节
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = LABEL_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sLabelName;	// 标签的名称 长度为40字节  
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;				// 保留字节
        }

        public const int LABEL_IDENTIFY_LEN = 64;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LABEL_IDENTIFY
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = LABEL_IDENTIFY_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sLabelIdentify;    // 64字节标识
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;               // 保留字节
        }

        public const int MAX_DEL_LABEL_IDENTIFY = 20;// 删除的最大标签标识个数

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEL_LABEL_PARAM
        {
            public uint dwSize;       // 结构体大小
            public byte byMode;   // 按位表示,0x01表示按标识删除
            public byte byRes1;
            public ushort wLabelNum;      // 标签数目   
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DEL_LABEL_IDENTIFY, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_LABEL_IDENTIFY[] struIndentify; // 标签标识
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 160, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;   //保留字节    
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MOD_LABEL_PARAM
        {
            public NET_DVR_LABEL_IDENTIFY struIndentify; //要修改的标签标识
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = LABEL_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sLabelName;	//修改后的标签名称
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;				
        }

        //标签搜索结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FIND_LABEL
        {
            public uint dwSize;          // 结构体大小
            public int lChannel;		// 查找的通道
            public NET_DVR_TIME	struStartTime;	// 开始时间
            public NET_DVR_TIME	struStopTime;	// 结束时间
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = LABEL_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sLabelName;	//  录像标签名称 如果标签名称为空，则搜索起止时间所有标签
            public byte byDrawFrame;		//0:不抽帧，1：抽帧
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 39, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// 保留字节
        }

        //标签信息结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FINDLABEL_DATA
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = LABEL_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sLabelName;	// 标签名称
            public NET_DVR_TIME struTimeLabel;		// 标签时间
            public NET_DVR_LABEL_IDENTIFY struLabelIdentify; // 标签标识
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;			// 保留字节
        }

        public const int CARDNUM_LEN_V30 = 40;
        public const int PICTURE_NAME_LEN = 64;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FIND_PICTURE
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PICTURE_NAME_LEN)]
            public string sFileName;//图片名
            public NET_DVR_TIME struTime;//图片的时间
            public uint dwFileSize;//图片的大小
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = CARDNUM_LEN_V30)]
            public string sCardNum;	//卡号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		//  保留字节
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FIND_PICTURE_PARAM
        {
            public uint dwSize;         // 结构体大小 
            public int lChannel;       // 通道号
            public byte byFileType;        
            public byte byNeedCard;     // 是否需要卡号
            public byte byProvince;     //省份索引值
            public byte byEventType;      // 事件类型：0保留，1-交通事件；2-违章取证；3-其他事件
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CARDNUM_LEN_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] sCardNum;     // 卡号
            public NET_DVR_TIME  struStartTime;//查找图片的开始时间
            public NET_DVR_TIME  struStopTime;// 查找图片的结束时间
            //ITC3.7 新增
            public uint dwTrafficType; //图片检索生效项 参考 VCA_OPERATE _TYPE 
            public uint dwVehicleType; //车辆类型 参考 VCA_VEHICLE_TYPE
            //违规检测类型参考 VCA_ILLEGAL_TYPE 当前不支持复选
            public uint dwIllegalType;
            public byte byLaneNo;  //车道号(1~99)
            public byte bySubHvtType ;//0-保留,1-机动车(机动车子类型中支持车牌检索，省份检索),2-非机动车,3-行人
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LICENSE_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sLicense;    //车牌号码
            public byte byRegion;     // 区域索引值 0-保留，1-欧洲(Europe Region)，2-俄语区域(Russian Region)，3-欧洲&俄罗斯(EU&CIS), 4-中东(Middle East),0xff-所有
            public byte byCountry;     // 国家索引值，参照：COUNTRY_INDEX 
            public byte byArea;  //地区
            public byte byISO8601;  //是否是8601的时间格式，即时差字段是否有效0-时差无效，年月日时分秒为设备本地时间 1-时差有效 
            public byte cStartTimeDifferenceH;   //开始时间与UTC的时差（小时），-12 ... +14， 正数表示东时区
            public byte cStartTimeDifferenceM;   //开始时间与UTC的时差（分钟），-30, 0, 30, 45，正数表示东时区
            public byte cStopTimeDifferenceH;    //结束时间与UTC的时差（小时），-12 ... +14，正数表示东时区
            public byte cStopTimeDifferenceM;    //结束时间与UTC的时差（分钟），-30, 0, 30, 45，正数表示东时区
        }
		
		
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ADDRESS
        {
            public NET_DVR_IPADDR struIP; //IP地址
            public ushort wPort;    //端口号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_PIC_EXTRA_INFO_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 544, ArraySubType = UnmanagedType.I1)]
            public byte[] byUnionLen;   //联合体长度，无实际意义
        }

        public const int MAX_FACE_PIC_NUM = 30;      /*人脸子图个数*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FACE_EXTRA_INFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_FACE_PIC_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_RECT[] struVcaRect;  //人脸子图坐标信息
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FIND_PICTURE_V50
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PICTURE_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sFileName;//图片名
            public NET_DVR_TIME struTime;//图片的时间
            public uint dwFileSize;//图片的大小
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CARDNUM_LEN_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] sCardNum;    //卡号
            public byte byPlateColor;//参考结构 VCA_PLATE_COLOR
            public byte byVehicleLogo;//参考结构 VLR_VEHICLE_CLASS
            public byte byFileType;  //文件类型， :0定时抓图1 移动侦测抓图 2 报警抓图3  报警 | 移动侦测抓图 4 报警 & 移动侦测抓图     6 手动抓图 ,9-智能图片,10- PIR报警，11- 无线报警，12- 呼救报警,    0xa 预览时截图，0xd 人脸侦测, 0xe 越界侦测，0xf 入侵区域侦测，0x10 场景变更侦测, 0x11-设备本地回放时截图, 0x12-智能侦测
            public byte byRecogResult;//识别结果参考结构VTR_RESULT
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LICENSE_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sLicense;    //车牌号码
            public byte byEventSearchStatus; //连续图片表示同一查找结果的时候，0-表示后面没有图片信息，1-表示后面还有图片信息。总共图片信息包括最后一张状态为0的图片。
            public NET_DVR_ADDRESS struAddr;		//图片所在的地址信息，图片下载时用到
            public byte byISO8601;  //是否是8601的时间格式，即时差字段是否有效0-时差无效，年月日时分秒为设备本地时间 1-时差有效 
            public byte cTimeDifferenceH;   //与UTC的时差（小时），-12 ... +14
            public byte cTimeDifferenceM;   //与UTC的时差（分钟），-30,0, 30, 45
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 253, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;        //  保留字节
            public NET_DVR_PIC_EXTRA_INFO_UNION uPicExtraInfo; //图片附件信息
        }

        public const int MAX_RECORD_PICTURE_NUM = 50;   //最大备份图片张数  

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BACKUP_PICTURE_PARAM
        {
            public uint dwSize;         // 结构体大小   
            public uint dwPicNum;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RECORD_PICTURE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_FIND_PICTURE[] struPicture;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN_32, ArraySubType = UnmanagedType.I1)]
            public byte[] byDiskDes;
            public byte byWithPlayer;
            public byte byContinue;    /*是否继续备份 0不继续 1继续*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSION_LIMIT
        {	
            public uint dwSize;           //结构体大小
            public uint dwChannel;        //通道号
            public byte byCompressType;   //待获取的压缩参数类型1,主码流2,子码流3,事件
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;        //保留
            public NET_DVR_COMPRESSIONCFG_V30  struCurrentCfg; //当前压缩参数配置
        }

        public const int STEP_READY      = 0;    //准备升级
        public const int STEP_RECV_DATA  = 1;    //接收升级包数据
        public const int STEP_UPGRADE    = 2;    //升级系统
        public const int STEP_BACKUP     = 3;    //备份系统
        public const int STEP_SEARCH     = 255;  //搜索升级文件

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEO_EFFECT
        {
            public uint dwBrightValue;      //亮度[0,255]
            public uint dwContrastValue;    //对比度[0,255]
            public uint dwSaturationValue;  //饱和度[0,255]
            public uint dwHueValue;         //色调[0,255]
            public uint dwSharpness;		  //锐度[0,255]
            public uint dwDenoising;		  //去噪[0,255]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEO_INPUT_EFFECT
        {	
            public uint dwSize;				//结构体大小
            public ushort wEffectMode;        //模式 0-标准 1-室内 2-弱光 3-室外  255-自定义
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 146, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;        //保留
            public NET_DVR_VIDEO_EFFECT struVideoEffect;	//视频效果参数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;			//保留
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEOPARA_V40
        {
            public uint dwChannel;			// 通道号
            public uint dwVideoParamType;  	// 视频参数类型 0-亮度 1-对比度 2-饱和度 3-色度 4-锐度 5-去噪
            public uint dwVideoParamValue;  //对应的视频参数值，范围依据能力集
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEFAULT_VIDEO_COND
        {
            public uint dwSize;			// 结构体大小
            public uint dwChannel;		// 通道号
            public uint dwVideoMode;	// 模式
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      // 保留
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ENCODE_JOINT_PARAM
        {
            public uint dwSize;			// 结构体大小
            public byte byJointed;		//  0 没有关联 1 已经关联
            public byte byDevType;		// 被关联的设备类型  1 代表智能设备
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;		// 保留字节
            public NET_DVR_IPADDR	struIP;			// 关联的被取流设备IP地址
            public ushort wPort;			// 关联的被取流设备端口号
            public ushort wChannel;		// 关联的被取流设备通道号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;			// 保留字节
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VCA_CHAN_WORKSTATUS
        {
            public byte byJointed;				// 0-没有关联  1-已经关联
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_IPADDR	struIP;					// 关联的取流设备IP地址
            public ushort wPort;					// 关联的取流设备端口号
            public ushort wChannel;				// 关联的取流设备通道号
            public byte byVcaChanStatus;		// 0 - 未启用 1 - 启用
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 19, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;				// 保留字节
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VCA_DEV_WORKSTATUS
        {
            public uint dwSize;			// 结构体大小
            public byte byDeviceStatus;	// 设备的状态0 - 正常工作 1- 不正常工作
            public byte byCpuLoad;		// CPU使用率0-100 分别代表使用百分率
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VCA_CHAN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_VCA_CHAN_WORKSTATUS[] struVcaChanStatus;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;		// 保留字节
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct UNION_VIDEOPLATFORM_V40
        {
            /*各个子窗口对应解码通道所对应的解码子系统的槽位号(对于视频综合平台中解码子系统有效)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecoderId;
            //显示窗口所解视频分辨率，1-D1,2-720P,3-1080P，设备端需要根据此//分辨率进行解码通道的分配，如1分屏配置成1080P，则设备会把4个解码通
            //道都分配给此解码通道
            public byte byDecResolution;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 143, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct UNION_NOTVIDEOPLATFORM_V40
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 160, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VGA_DISP_CHAN_CFG_V40
        {        
            public uint dwSize; 
            public byte byAudio;			/*音频是否开启*/
            public byte byAudioWindowIdx;      /*音频开启子窗口*/
            public byte byVgaResolution;      /*分辨率，从能力集获取*/
            public byte byVedioFormat;         /*1:NTSC,2:PAL，0-NULL*/
            public uint dwWindowMode;		/*画面模式，能力集获取*/       
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecChan;/*各个子窗口关联的解码通道*/
            public byte byEnlargeStatus;          /*是否处于放大状态，0：不放大，1：放大*/
            public byte byEnlargeSubWindowIndex;//放大的子窗口号
            public byte byScale; /*显示模式，0---真实显示，1---缩放显示( 针对BNC )*/
	        /*区分共用体，0-视频综合平台内部解码器显示通道配置，1-其他解码器显示通道配置*/
            public byte byUnionType;
	
            [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct struDiff
            {
                [FieldOffsetAttribute(0)]
		        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 160, ArraySubType = UnmanagedType.I1)]
                public byte[] byRes;

                /*[FieldOffsetAttribute(0)]
                public UNION_VIDEOPLATFORM_V40 struVideoPlatform;

                [FieldOffsetAttribute(0)]
                public UNION_NOTVIDEOPLATFORM_V40 struNotVideoPlatform;
                 * */
	        }
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 120, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_V6SUBSYSTEMPARAM
        {
            public byte bySerialTrans;//是否透传，0-否，1-是
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 35, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int NET_DVR_V6PSUBSYSTEMARAM_GET = 1501;//获取V6子系统配置
        public const int NET_DVR_V6PSUBSYSTEMARAM_SET = 1502;//设置V6子系统配置

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CORRECT_DEADPIXEL_PARAM
        {
            public uint dwSize;
            public uint dwCommand; //命令：0-进入坏点模式，1-添加坏点，2-保存坏点，3-退出坏点
            public uint dwDeadPixelX; //坏点X坐标
            public uint dwDeadPixelY; //坏点Y坐标
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //保留
        }

        public const int MAX_REDAREA_NUM = 6;   //最大红绿灯区域个数

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_REDAREACFG
        {
            public uint dwSize;
            public uint dwCorrectEnable; //是否开启校正功能，0-关闭，1-开启
            public uint dwCorrectLevel; //校正级别，1(校正度最低)-10(校正度最高),默认为5
            public uint dwAreaNum; //校正区域个数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_REDAREA_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_RECT[] struLaneRect; //校正区域
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //保留
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HISTORICDATACFG
        {
            public uint dwSize;
            public uint dwTotalNum;  //历史数据个数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int INQUEST_MESSAGE_LEN  = 44;    //审讯重点标记信息长度
        public const int INQUEST_MAX_ROOM_NUM = 2;    //最大审讯室个数
        public const int MAX_RESUME_SEGMENT   = 2;     //支持同时恢复的片段数目

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_ROOM
        {
            public byte byRoomIndex;     //审讯室编号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;       //保留
        }

        public const int MAX_INQUEST_CDRW_NUM = 4;     //最大刻录机数目

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_CDRW_STATUS
        { 
            /*运行状态：0-审讯开始，
             * 1-审讯过程中刻录，2-审讯停止，
             * 3-刻录审讯文件, 
             * 4-备份(事后备份和本地备份)
             * 5-空闲
             * 6-初始化硬盘
             * 7-恢复审讯*/
            public uint dwType;            
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_INQUEST_CDRW_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_INQUEST_CDRW[] strCDRWNum;   //数组0表示刻录机1    
            public NET_DVR_TIME_EX struInquestStartTime;        //审讯开始的时间点
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;             //保留
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_CDRW
        {     
            public uint dwEnable;            //刻录机状态是否有效,0-无效,1-有效    
            public uint dwStatus;            /* 当dwType=0时，
                                                            0-光盘正常，1-无光盘或光盘异常,
                                                            当dwType=1或2时，
                                                            0-刻录正常，1-无光盘或光盘异常，
                                                            2-光盘已封盘(81不支持)，3-光盘空间不足，
                                                            4-异常导致审讯终止(81不支持)
                                                            当dwType=3时，
                                                            0-刻录正常，1-无光盘或光盘异常，
                                                            2-光盘已封盘(81不支持)，3-光盘空间不足
                                                            当dwType=4时，
                                                            0-刻录正常，1-无光盘或光盘异常，
                                                            2-光盘已封盘(81不支持)，3-光盘空间不足
                                                            当dwType=5时,
                                                            0-光盘正常， 1-无光盘或光盘异常,
                                                            2-光盘已封盘(81不支持)
                                                            当dwType=6或7时,
                                                            0-刻录正常, 1-无光盘或光盘异常,
                                2-光盘已封盘(81不支持), 3-光盘空间不足*/        
            public uint dwVolumn;      //光盘容量,单位M
            public uint dwFreeSpace;   //光盘剩余容量,单位M    
            public uint dwTimeLeft;     // 光盘剩余时间，单位秒
            public byte byCDType;         // 光盘类型
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      //保留字节
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_CDRW_CFG
        {
            public uint dwSize;
            public uint dwNum;                       //刻录机的数量
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.U4)]
            public uint[]dwRwSelectPara;// 是否选中该光驱
            public uint dwModeSelect;                //0表示循环刻录模式  1表示并行刻录模式(默认模式)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                   //保留
            public uint dwStartCDRW;                 //DVR 本地已经开始刻录
            public uint dwHdExcp;                    //硬盘有异 常
            public uint dwInterval;                  //时间间隔，10分钟(0)、20分钟(1)、30分钟(2)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sLable;                  //光盘名称
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_MESSAGE
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = INQUEST_MESSAGE_LEN)]
            public string sMessage; //重点标记信息
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 46, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                     //保留
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_SENSOR_DEVICE
        {
            public ushort wDeviceType;	//数据采集设备型号:0-无 1-米乐 2-镭彩 3-优力 4-佳盟 5-永控、6-垅上、7-维纳斯达
            public ushort wDeviceAddr;	//数据采集设备地址	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 28, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;	    //保留
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_SENSOR_INFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = INQUEST_MAX_ROOM_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_INQUEST_SENSOR_DEVICE[] struSensorDevice;
            public uint  dwSupportPro;      //支持协议类型,按位表示, 新版本走能力集，不再扩展此字段
							   //0x1:米乐 0x2:镭彩 0x4:优力
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 120, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;        //保留
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_ROOM_INFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = NAME_LEN)]
            public string szCDName;	//光盘名称，单室双刻光盘名称是一样的
            [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct uCalcMode
	        {
                [FieldOffsetAttribute(0)]
                public byte byBitRate;	// byCalcType为0时有效，(0-32、1-48、2-64、3-80、4-96、5-128、
								//6-160、7-192、8-224、9-256、10-320、11-384、12-448、
								//13-512、14-640、15-768、16-896前16个值保留)17-1024、18-1280、19-1536、
								//20-1792、21-2048、22-3072、23-4096、24-8192
                [FieldOffsetAttribute(0)]
                public byte byInquestTime;  // byCalcType为1时有效，0-1小时, 1-2小时,2-3小时,3-4小时, 4-6小时,5-8小时
		                        //8-16小时, 9-20小时,10-22小时,11-24小时
	        }
            public byte byCalcType;			//刻录计算类型0-按码率 1-按时间
            public byte byAutoDelRecord;	// 是否自动删除录像，0-不删除，即结束时保存录像 1-删除
            public byte byAlarmThreshold;		// 声音报警阀值
            public byte byInquestChannelResolution;     //审讯通道分辨率，0:720P  1:1080P
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_SYSTEM_INFO
        {
            public uint dwRecordMode;         //刻录模式:1 单室双刻模式 2 单室轮刻模式 3 双室双刻模式（修改需要重启设备）
            public uint  dwWorkMode;           //工作模式:0 标准模式 1 通用模式(保留，目前只有标准模式)
            public uint dwResolutionMode;     //设备分辨率，0:标清 1:D1 2:720P 3:1080P（高清审讯机不用此字段）
            public NET_DVR_INQUEST_SENSOR_INFO struSensorInfo;  //温湿度传感器配置
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = INQUEST_MAX_ROOM_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_INQUEST_ROOM_INFO[] struInquestRoomInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;	
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_RESUME_SEGMENT
        {
            public NET_DVR_TIME  struStartTime; //事件起始时间
            public NET_DVR_TIME  struStopTime;  //事件终止时间
            public byte byRoomIndex;         //审讯室编号,从1开始
            public byte byDriveIndex;        //刻录机编号,从1开始
            public ushort wSegmetSize;         //本片断的大小, 单位M 
            public uint dwSegmentNo;         //本片断在本次审讯中的序号,从1开始 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           //保留
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_RESUME_EVENT
        {
            public uint  dwResumeNum;       //需恢复的事件个数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RESUME_SEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_INQUEST_RESUME_SEGMENT[] struResumeSegment;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 200, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;        //保留
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_DEVICE_VERSION
        {
            public byte byMainVersion;         /*基线主版本.
								   0 : 未知
								   1 : 8000审讯DVR
								       次版本: 1 : 8000HD-S
								   2 : 8100审讯DVR 
									   次版本: 1 : 审讯81SNL
											   2 : 审讯81SH
											   3 : 审讯81SFH
								   3 : 8608高清审讯机NVR 
									   次版本: 1 : DS-8608SN-SP
											   2 : DS-8608SN-ST
									  */
            public byte bySubVersion;          //基线次版本
            public byte byUpgradeVersion;      //升级版本,未升级为0
            public byte byCustomizeVersion;     //定制版本,非定制为0
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;             //保留
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISK_RAID_INFO 
        {
            public uint dwSize;   //结构体大小
            public byte byEnable;  //磁盘Raid是否禁用
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 35, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //保留字节
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SYNCHRONOUS_IPC
        {
            public uint dwSize;    //结构体大小
            public byte byEnable;  //是否启用：为前端IPC同步设备参数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //保留
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPC_PASSWD
        {
            public uint dwSize;    //结构体大小
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PASSWD_LEN)]
            public string sOldPasswd;  //IPC的旧密码，传给DVR让DVR验证
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PASSWD_LEN)]
            public string sNewPasswd;  //IPC的新密码
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //通过获取DVR的网络状态：单位bps
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DEVICE_NET_USING_INFO 
        {
            public uint dwSize;    //结构体大小
            public uint dwPreview;   //预览
            public uint dwPlayback;  //回放
            public uint dwIPCModule; //IPC接入
            public uint dwNetDiskRW; //网盘读写
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        //通过DVR设置前端IPC的IP地址
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPC_NETCFG
        {
            public uint dwSize;      //结构体大小
            public NET_DVR_IPADDR struIP;       //IPC的IP地址
            public ushort wPort;       //IPC的端口
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 126)]
            public string res;  
        }

        //按时间锁定
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TIME_LOCK
        {
            public uint dwSize;      //结构体大小
            public NET_DVR_TIME strBeginTime;
            public NET_DVR_TIME strEndTime;
            public uint dwChannel;        //通道号, 0xff表示所有通道
            public uint dwRecordType;     //录像类型:  0xffffffff－全部，0－定时录像，1-移动侦测，2－报警触发，3-报警触发或移动侦测，4-报警触发和移动侦测，5-命令触发，6-手动录像，7-智能录像(同文件查找)
            public uint dwLockDuration;   //锁定持续时间,单位秒,0xffffffff表示永久锁定
            public NET_DVR_TIME_EX strUnlockTimePoint;	//加锁时有效，当dwLockDuration不为永久锁定时，锁定持续的时间到此时间点就自动解锁
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LOCK_RETURN
        {
            public uint dwSize;      //结构体大小
            public NET_DVR_TIME strBeginTime; 
            public NET_DVR_TIME strEndTime;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //67DVS
        //证书下载类型
        public enum NET_SDK_UPLOAD_TYPE 
        {
            UPGRADE_CERT_FILE = 0, 
	        UPLOAD_CERT_FILE = 1,
	        TRIAL_CERT_FILE = 2,
            CONFIGURATION_FILE = 3
        }

        public enum NET_SDK_DOWNLOAD_TYPE
        {
	        NET_SDK_DOWNLOAD_CERT = 0,		//下载证书
	        NET_SDK_DOWNLOAD_IPC_CFG_FILE = 1,//下载IPC配置文件
            NET_SDK_DOWNLOAD_BASELINE_SCENE_PIC = 2, //下载基准场景图片
	        NET_SDK_DOWNLOAD_VQD_ALARM_PIC = 3,       //下载VQD报警图片
            NET_SDK_DOWNLOAD_CONFIGURATION_FILE=4   //下载配置文件
        }

        //下载状态
       public enum NET_SDK_DOWNLOAD_STATUS
       {
	        NET_SDK_DOWNLOAD_STATUS_SUCCESS = 1,	//下载成功
	        NET_SDK_DOWNLOAD_STATUS_PROCESSING,		//正在下载
	        NET_SDK_DOWNLOAD_STATUS_FAILED,			//下载失败
	        NET_SDK_DOWNLOAD_STATUS_UNKOWN_ERROR	//未知错误 
       }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BONJOUR_CFG
        {
            public uint dwSize;				// 结构体大小
            public byte byEnableBonjour;		// Bonjour使能 0 ：开启 1：关闭
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;				
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byFriendlyName; 	// 服务名
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SOCKS_CFG
        {
            public uint dwSize;				// 结构体大小
            public byte byEnableSocks;  		// 使能 0：关闭 1：开启
            public byte byVersion;  			// SOCKS版本 4：SOCKS4   5：SOCKS5
            public ushort wProxyPort;				// 代理端口，默认1080
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byProxyaddr;  	// 代理IP地址，可以是域名
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byUserName; 	// 用户名 SOCKS才用
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPassword;			// 密码SOCKS5才用
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LOCAL_ADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalAddr;  //不使用socks代理的网段，格式为"ip/netmask;ip/netmask;…"
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_QOS_CFG
        {
            public uint dwSize;
            public byte byManageDscp;   // 管理数据的DSCP值 [0-63]
            public byte byAlarmDscp;    // 报警数据的DSCP值 [0-63]
            public byte byVideoDscp;    // 视频数据的DSCP值 [0-63]，byFlag为0时，表示音视频
            public byte byAudioDscp;    // 音频数据的DSCP值 [0-63]，byFlag为1时有效
            public byte byFlag;			// 0：音视频合一，1：音视频分开
            public byte byEnable;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 126, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HTTPS_CFG
        {
            public uint dwSize;
            public ushort wHttpsPort;		// HTTPS端口
            public byte byEnable;		// 使能 0：关闭 1：开启
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 125, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //证书相关
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CERT_NAME
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_COUNTRY_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byCountry;  			//国家代号 CN等
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byState;				//洲或省
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocality;			//地区
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byOrganization;		//组织
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byUnit;				//单位
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byCommonName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byEmail;  
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CERT_PARAM
        {
            public uint dwSize;
            public ushort wCertFunc; //证书种类，0-802.1x,1-HTTPS
            public ushort wCertType; //证书类型，0-CA，1-Certificate,2-私钥文件
            public byte byFileType; //证书文件类型，0-PEM,1-PFX
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 35, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; 
        }

        public const int UPLOAD_CERTIFICATE = 1; //上传证书

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CERT_INFO
        {
            public uint dwSize;
            public NET_DVR_CERT_PARAM struCertParam;	//证书参数
            public uint dwValidDays;   //有效天数，类型为自签名时有效
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPasswd;   //私钥密码
            public NET_DVR_CERT_NAME struCertName;    // 证书名称
            public NET_DVR_CERT_NAME struIssuerName;    // 证书发行者名称（自签名证书信息获取时有效）
            public NET_DVR_TIME_EX struBeginTime;   //证书创建时间（自签名证书信息获取时有效）
            public NET_DVR_TIME_EX struEndTime;   //证书截止时间（自签名证书信息获取时有效）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] serialNumber;   //证书标识码（自签名证书信息获取时有效）
            public byte byVersion; 
            public byte byKeyAlgorithm;			//加密类型 0-RSA  1-DSA
            public byte byKeyLen;				//加密长度 0-512  1-1024、 2-2048
            public byte bySignatureAlgorithm; //签名算法类型（自签名证书信息获取时有效）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //channel record status
        //***通道录像状态*****//
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CHANS_RECORD_STATUS
        {
            public byte byValid;       //是否有效
            public byte byRecord;      /*(只读)录像类型, 按位表示:0: 不在录像；1：在录像 2-空闲 
						3-无连接 4-无输入视频 5-未加载 6-存档中
							7-回传中 8-用户名或密码错 9-未验证
							10-存档中和录像中 11-录像回传中和录像中*/
            public ushort wChannelNO;   //通道号
            public uint dwRelatedHD;  //关联磁盘
            public byte byOffLineRecord;  //断网录像功能 0-关闭 1-开启
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      //保留字节
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IP_ALARM_GROUP_NUM
        {
            public uint dwSize; 
            public uint dwIPAlarmInGroup;      //IP通道报警输入组数
            public uint dwIPAlarmInNum;       //IP通道报警输入个数
            public uint dwIPAlarmOutGroup;     //IP通道报警输出组数
            public uint dwIPAlarmOutNum;      //IP通道报警输出个数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  
        }
        
        //****NVR end***//
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CHAN_GROUP_RECORD_STATUS
        {
            public uint dwSize; //结构体大小
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CHANS_RECORD_STATUS[] struChanStatus; //一组64个
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECTCFG
        {
            public ushort wXCoordinate; /*矩形左上角起始点X坐标*/
            public ushort wYCoordinate; /*矩形左上角Y坐标*/
            public ushort wWidth;       /*矩形宽度*/
            public ushort wHeight;      /*矩形高度*/
        }

        /*窗口信息*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WINCFG
        {
            public uint dwSize;
            public byte byVaild;
            public byte byInputIdx;          /*输入源索引*/
            public byte byLayerIdx;          /*图层，0为最底层*/
            public byte byTransparency; //透明度，0～100 
            public NET_DVR_RECTCFG  struWin;//目的窗口(相对显示墙)
            public ushort wScreenHeight;//大屏高
            public ushort wScreenWidth;//大屏宽
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALLWINCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LAYERNUMS, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_WINCFG[] struWinCfg;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREENZOOM
        {
            public uint dwSize;
            public uint dwScreenNum;//大屏号
            public NET_DVR_POINT_FRAME struPointFrame;
            public byte byLayer;//图层号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //2011-04-18
        /*摄像机信息,最多9999个，从1开始 */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_CAMERAINFO
        {  
            public uint dwGlobalCamId;      /* cam的全局编号*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sCamName; /*cam的名称*/
            public uint dwMatrixId;          /*cam对应矩阵的编号*/
            public uint dwLocCamId;         /*cam对应矩阵的内部编号*/ 
            public byte byValid;    /*是否有效，0-否，1-是*/
            public byte byPtzCtrl; /* 是否可控，0-否，1-是*/
            public byte byUseType; //*使用类型，0-不作为干线使用，1-BNC，2-SP3,3-V6光纤，4-其他光纤*/ 
            public byte byUsedByTrunk;//当前使用状态，0-没有被使用，1-被干线使用 
            public byte byTrunkReq; /*摄像机分辨率,以D1为单位：1 - 1个D1，2- 2个D1，作为干线使用时，指的是干线的带宽*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_TIME struInstallTime;//安装时间
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPurpose;/*用途描述*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;  
        }

        /*监视器信息，最多2048个*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_MONITORINFO 
        {
            public uint dwGloalMonId; /*mon 的统一编号*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sMonName;
            public uint dwMatrixId;  /*mon所在矩阵的编号*/
            public uint dwLocalMonId; /*mon的内部编号*/
            public byte byValid;    /*是否有效，0-否，1-是*/
            public byte byTrunkType; /*使用类型，0-不作为干线使用，1-BNC，2-SP3,3-V6光纤，4-其他光纤*/ 
            public byte byUsedByTrunk;//当前使用状态，0-没有被使用，1-被干线使用 
            public byte byTrunkReq; /*分辨率, 以D1为单位：1- 1个D1，2- 2个D1，作为干线使用时，指的是干线的带宽*/
            public NET_DVR_TIME struInstallTime;//安装时间
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPurpose;/*用途描述*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_DIGITALMATRIX
        {
            public NET_DVR_IPADDR struAddress; /*设备为数字设备时的IP信息*/
            public ushort wPort;
            public byte byNicNum; /*0 - eth0, 1 - eth1, 考虑双网口如何通信加入绑定的网口*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 69, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_ANALOGMATRIX
        {
            public byte bySerPortNum;   /*连接的串口号*/
            public byte byMatrixSerPortType;/* 矩阵接入网关的串口与模拟矩阵的键盘口(键盘协议)连接还是与矩阵通信口（矩阵协议）连接 ，0 --- 矩阵协议通讯口 1 --- 键盘通讯口*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_SINGLE_RS232 struRS232;	//232串口参数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 200, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;      
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIXLIST
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwMatrixNum;//设备返回的矩阵数量
            public IntPtr pBuffer;//矩阵信息缓冲区
            public uint dwBufLen;//所分配指针长度，输入参数
        }

 
        /*串口配置信息*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_UARTPARAM
        {	
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPortName;
            public ushort wUserId; /*用户编号，当连接设备为键盘时，绑定一个用户，用于权限管理*/
            public byte byPortType;    /*串口类型，三种0-RS232/1-RS485/2-RS422*/
            public byte byFuncType; /*串口连接的设备的类型0-空闲，1-键盘，2-用作透明通道(485串口不可配置成透明通道),3-模拟矩阵*/     
            public byte byProtocolType;  /*串口支持的协议类型, 当连接键盘设备时需要该信息,获取键盘支持协议的编号及描述符*/
            public byte byBaudRate;
            public byte byDataBits;
            public byte byStopBits;   /*停止位*/
            public byte byParity;      /*校验*/
            public byte byFlowCtrl;   /*流控，软件流控，无流控*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 22, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     /*预留*/
        }

        //最多256个用户，1～256
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_USERPARAM 
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;
            public byte byRole;/*用户角色:0-管理员,1-操作员；只有一个系统管理员，255个操作员*/
            public byte byLevel;  /*统一级别，用于操作级别管理,1- 255*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //最多255个资源组
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_RESOURSEGROUPPARAM
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byGroupName;
            public byte byGroupType;/*0-摄像机CAM组，1-监视器MON组*/
            public byte byRes1;
            public ushort wMemNum;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 512, ArraySubType = UnmanagedType.U4)]
            public uint[] dwGlobalId; 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //最多255个用户组
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_USERGROUPPARAM
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sGroupName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 255, ArraySubType = UnmanagedType.U2)]
            public ushort[] wUserMember;  /*包含的用户成员*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 255, ArraySubType = UnmanagedType.U2)]
            public ushort[] wResorceGroupMember; /*包含的资源组成员*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byPermission;//权限，数组0-ptz权限、切换权限、查询权限
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_TRUNKPARAM
        {
            public uint dwSize;
            public uint dwTrunkId;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sTrunkName;
            public uint dwSrcMonId;
            public uint dwDstCamId;
            public byte byTrunkType;  /*使用类型  1-BNC，2-SP3光纤高清，3-SP3光纤D1， 4-V6光纤，5-其他光纤*/
            public byte byAbility;     /*表示光纤的带宽，可以传输几路*/
            public byte bySubChan;   /*针对光纤干线而言，表示子通道号*/
            public byte byLevel;		/* 干线级别 1-255*/
            public ushort wReserveUserID;	//预留的用户ID： 1~256 ，0表示释放预留
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; 
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_TRUNKLIST
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwTrunkNum;//设备返回的干线数量
            public IntPtr pBuffer;//干线信息缓冲区
            public uint dwBufLen;//所分配指针长度，输入参数
        }

        public const int MATRIX_PROTOCOL_NUM   = 20;    //支持的最大矩阵协议数
        public const int KEYBOARD_PROTOCOL_NUM = 20;    //支持的最大键盘协议数

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PROTO_TYPE_EX
        { 
            public ushort wType;               /*ipc协议值*/  
            public ushort wCommunitionType;		/*0：模拟 1：数字 2：兼容模拟、数字*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDescribe; /*协议描述字段*/    
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIXMANAGE_ABIILITY
        {
            public uint dwSize;
            public uint dwMaxCameraNum;//最大Camera数量
            public uint dwMaxMonitorNum;//最大监视器数量
            public ushort wMaxMatrixNum;//最大矩阵数量
            public ushort wMaxSerialNum;//串口数量
            public ushort wMaxUser;//最大用户数
            public ushort wMaxResourceArrayNum;//最大资源组数
            public ushort wMaxUserArrayNum;//最大用户组数
            public ushort wMaxTrunkNum;//最大干线数
            public byte nStartUserNum;//起始用户号
            public byte nStartUserGroupNum;//起始用户组号
            public byte nStartResourceGroupNum;//起始资源组号
            public byte nStartSerialNum;//起始串口号
            public uint  dwMatrixProtoNum;     /*有效的矩阵协议数目，从0开始*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MATRIX_PROTOCOL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PROTO_TYPE_EX[] struMatrixProto;/*最大协议列表长度*/ 
            public uint dwKeyBoardProtoNum;     /*有效的键盘协议数目，从0开始*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MATRIX_PROTOCOL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PROTO_TYPE_EX[] struKeyBoardProto;/*最大协议列表长度*/   
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SINGLEWALLPARAM
        {
            public uint dwSize;
            public byte byEnable;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwWallNum;//电视墙输出号
            //坐标须为基准坐标的整数倍（128×128），宽度和高度值不用设置，即为基准值
            public NET_DVR_RECTCFG struRectCfg;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 36, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*窗口信息*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WALLWINCFG
        {
            public uint dwSize;
            public byte byEnable;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwWinNum;//窗口号
            public uint dwLayerIndex;//窗口相对应的图层号
            public NET_DVR_RECTCFG struWinPosition;//目的窗口(相对显示墙)
            public uint dwDeviceIndex;//分布式大屏控制器设备序号
            public ushort wInputIndex;//输入信号源
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //窗口相关参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WALLWINPARAM
        {
            public uint dwSize;
            public byte byTransparency; //使能透明度，0-关，非0-开	
            public byte byWinMode;//窗口分屏模式，能力集获取
            public byte byEnableSpartan;//畅显使能，0-关，1-开
            public byte byDecResource;  //为窗口分配的解码资源，1-D1,2-720P,3-1080P
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECTCFG_EX
        {
            public uint dwXCoordinate;
            public uint dwYCoordinate;
            public uint dwWidth;
            public uint dwHeight;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //电视墙输出位置配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEOWALLDISPLAYPOSITION
        {
            public uint dwSize;
            public byte byEnable; //使能：0- 禁用，1- 启用
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwVideoWallNo;//电视墙号(组合)
            public uint dwDisplayNo;  //显示输出号(组合)，批量获取全部时有效
            public NET_DVR_RECTCFG_EX struRectCfg;//位置坐标，须为基准坐标（通过能力集获取）的整数倍，宽度和高度值不用设置，即为基准值
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //显示输出参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISPLAYPARAM
        {
            public uint dwDisplayNo;//显示输出号
            public byte byDispChanType;/*输出连接模式,1-BNC，2-VGA，3-HDMI，4-DVI，5-SDI, 6-FIBER, \
                                    7-RGB, 8-YPrPb, 9-VGA/HDMI/DVI自适应，10-3GSDI,11-VGA/DVI自适应，12-HDBaseT, 0xff-无效*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //显示输出参数配置
        public const int MAX_DISPLAY_NUM = 512; //最大显示输出个数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISPLAYCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISPLAY_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DISPLAYPARAM[] struDisplayParam;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //窗口信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEOWALLWINDOWPOSITION
        {
            public uint dwSize;
            public byte byEnable;  //窗口使能,0-不使能，1-使能 
            public byte byWndOperateMode;  //窗口操作模式，0-统一坐标，1-分辨率坐标
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwWindowNo;//窗口号
            public uint dwLayerIndex;//窗口相对应的图层号，图层号到最大即置顶，置顶操作
            public NET_DVR_RECTCFG_EX struRect; //目的窗口统一坐标(相对显示墙)，获取或按统一坐标设置时有效
            public NET_DVR_RECTCFG_EX struResolution; //目的窗口分辨率坐标，获取或按分辨率坐标设置有效
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CHAN_RELATION_RESOURCE
        {
            public uint dwSize;
            public uint dwDisplayChan; //显示通道号（1字节设备号+1字节保留+2字节显示通道号）
            public byte byRelateAudio; //是否关联子窗口音频
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwSubWinNo; //关联音频的子窗口号（1字节电视墙号+1字节子窗口号+2字节窗口号）
            public uint dwChannel; //编码通道号，获取全部时有效
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PU_STREAM_CFG_V41
        {
            public uint dwSize;
            public byte byStreamMode;//取流模式：0- 无效，1- 通过IP或域名取流，2- 通过URL取流，3- 通过动态域名解析向设备取流
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_DEC_STREAM_MODE uDecStreamMode;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_VIDEO_WALL_INFO
        {
            public uint dwSize;
            public uint dwWindowNo;
            public uint dwSceneNo;
            public uint dwDestWallNo; //目的墙号
            public uint dwDestSceneNo;//目的场景号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_SCENE_CONTROL_INFO
        {
            public uint dwSize;
            public NET_DVR_VIDEO_WALL_INFO struVideoWallInfo;
            public uint dwCmd;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WALLSCENECFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSceneName;    //场景名称
            public byte byEnable;                //场景是否有效，0-无效，1-有效
            public byte bySceneIndex;            //场景号，只能获取。获取所有场景时使用该参数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 78, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BUF_INFO
        {
            public IntPtr pBuf;
            public uint nLen;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IN_PARAM
        {
            public NET_DVR_BUF_INFO struCondBuf;
            public NET_DVR_BUF_INFO struInParamBuf;
            public uint dwRecvTimeOut;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OUT_PARAM
        {
            public NET_DVR_BUF_INFO struOutBuf;
            public IntPtr lpStatusList;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INPUTSTREAMCFG_V40
        {
            public uint dwSize;
            public byte byValid;     //
            public byte byCamMode;//见NET_DVR_CAM_MODE
            public ushort wInputNo; //信号源序号
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = NAME_LEN)]
            public string sCamName;
            public NET_DVR_VIDEOEFFECT struVideoEffect;//视频参数
            public NET_DVR_PU_STREAM_CFG struPuStream;    //ip输入时使用
            public ushort wBoardNum;      //信号源所在的板卡号，只能获取
            public ushort wInputIdxOnBoard; //信号源在板卡上的位置，只能获取
            public uint dwResolution;//分辨率
            public byte byVideoFormat;//视频制式，见VIDEO_STANDARD
            public byte byStatus;    //信号源状态，0-字段无效 1-有信号 2-无信号 3-异常 
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = NAME_LEN)]
            public string sGroupName;    //网络信号源分组 组名
            public byte byJointMatrix;            //关联矩阵，0-不关联  1-关联，当输入信号源为NET_DVR_CAM_BNC，NET_DVR_CAM_VGA，NET_DVR_CAM_DVI，NET_DVR_CAM_HDMI,中的一种时，该参数有效。
            public byte byJointNo;         //拼接信号源的拼接编号(只能获取)
            public byte byColorMode;      //色彩模式， 0-自定义 1-锐利 2-普通 3-柔和，当为自定义时，使用struVideoEffect设置
            public byte byScreenServer; //关联屏幕服务器，0-不联，1-关联
            public byte byDevNo; //设备号
            public byte byRes1;
            public uint dwInputSignalNo; //输入信号源编号（新）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 120, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //人脸抓拍规则(单条)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SINGLE_FACESNAPCFG
        {
            public byte byActive;				//是否激活规则：0-否，1-是
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     //保留
            public NET_VCA_SIZE_FILTER struSizeFilter;   //尺寸过滤器
            public NET_VCA_POLYGON struVcaPolygon;		//人脸识别区域
        }

        //人脸抓拍规则参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACESNAPCFG
        {
            public uint dwSize;
            public byte bySnapTime;					//单个目标人脸的抓拍次数0-10
            public byte bySnapInterval;                 //抓拍间隔，单位：帧
            public byte bySnapThreshold;               //抓拍阈值，0-100
            public byte byGenerateRate; 		//目标生成速度,范围[1, 5]	
            public byte bySensitive;			//目标检测灵敏度，范围[1, 5]
            public byte byReferenceBright; //2012-3-27参考亮度[0,100]
            public byte byMatchType;         //2012-5-3比对报警模式，0-目标消失后报警，1-实时报警
            public byte byMatchThreshold;  //2012-5-3实时比对阈值，0~100
            public NET_DVR_JPEGPARA struPictureParam; //图片规格结构
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RULE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_SINGLE_FACESNAPCFG[] struRule; //人脸抓拍规则
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //人体特征识别结果结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_HUMAN_FEATURE
        {
            public byte byAgeGroup;    //年龄段,参见 HUMAN_AGE_GROUP_ENUM
            public byte bySex;         //性别, 0-表示“未知”（算法不支持）,1 – 男 , 2 – 女, 0xff-算法支持，但是没有识别出来
            public byte byEyeGlass;    //是否戴眼镜 0-表示“未知”（算法不支持）,1 – 不戴, 2 – 戴,0xff-算法支持，但是没有识别出来
            //抓拍图片人脸年龄的使用方式，如byAge为15,byAgeDeviation为1,表示，实际人脸图片年龄的为14-16之间
            public byte byAge;//年龄 0-表示“未知”（算法不支持）,0xff-算法支持，但是没有识别出来
            public byte byAgeDeviation;//年龄误差值
            public byte byEthnic;   //字段预留,暂不开放
            public byte byMask;       //是否戴口罩 0-表示“未知”（算法不支持）,1 – 不戴, 2 –戴普通眼镜, 3 –戴墨镜,0xff-算法支持，但是没有识别出来
            public byte bySmile;      //是否微笑 0-表示“未知”（算法不支持）,1 – 不微笑, 2 – 微笑, 0xff-算法支持，但是没有识别出来
            public byte byFaceExpression;    
            public byte byBeard;  
            public byte byRes2;  
            public byte byHat;   //帽子, 0-不支持,1-不戴帽子,2-戴帽子,0xff-unknow表示未知,算法支持未检出
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //保留
        }

        //人脸抓拍附加信息结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACESNAP_ADDINFO
        {
            //人脸矩形框,该坐标为人脸小图(头肩照)中人脸的坐标
            public NET_VCA_RECT struFacePicRect;
            public int iSwingAngle;//旋转角, -90~90度
            public int iTiltAngle;//俯仰角, -90~90度
            public uint dwPupilDistance;//瞳距,范围为：最小值为10像素,最大值为当前分辨率宽度/1.6
            public byte byBlockingState;//目标遮挡状态， 0-表示“未知”（算法不支持）,1~无遮挡,2~瞬时轻度遮挡，3~持续轻度遮挡，4~严重遮挡
            public byte byFaceSnapThermometryEnabled;//人脸抓拍测温使能 1-开启 0-关闭
            public byte byIsAbnomalTemperature;//人脸抓拍测温是否温度异常 1-是 0-否
            public byte byThermometryUnit;//测温单位: 0-摄氏度（℃），1-华氏度（℉），2-开尔文(K)
            public NET_DVR_TIME_EX struEnterTime;   // 最佳抓拍下进入时间
            public NET_DVR_TIME_EX struExitTime;    // 最佳抓拍下离开时间
            public float fFaceTemperature; // 人脸温度（ - 20.0℃~150.0℃，精确到小数点后1位）
            public float fAlarmTemperature;// 测温报警警阈值（精确到小数点后1位）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 472, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;// 保留字节
        }

        //人脸抓拍结果报警上传
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACESNAP_RESULT
        {
            public uint dwSize;
            public uint dwRelativeTime;
            public uint dwAbsTime;
            public uint dwFacePicID;
            public uint dwFaceScore;
            public NET_VCA_TARGET_INFO struTargetInfo;
            public NET_VCA_RECT struRect;
            public NET_VCA_DEV_INFO struDevInfo;
            public uint dwFacePicLen;
            public uint dwBackgroundPicLen;
            public byte bySmart;            //IDS设备返回0(默认值)，Smart Functiom Return 1
            public byte byAlarmEndMark;//报警结束标记0-保留，1-结束标记（该字段结合人脸ID字段使用，表示该ID对应的下报警结束，主要提供给NVR使用，用于判断报警结束，提取识别图片数据中，清晰度最高的图片）
            public byte byRepeatTimes;   //重复报警次数，0-无意义
            public byte byUploadEventDataType;//人脸图片数据长传方式：0-二进制数据，1-URL
            public NET_VCA_HUMAN_FEATURE struFeature;  //人体属性
            public float fStayDuration;  //停留画面中时间(单位: 秒)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] sStorageIP;        //存储服务IP地址
            public ushort wStoragePort;            //存储服务端口号
            public ushort wDevInfoIvmsChannelEx;     //与NET_VCA_DEV_INFO里的byIvmsChannel含义相同，能表示更大的值。老客户端用byIvmsChannel能继续兼容，但是最大到255。新客户端版本请使用wDevInfoIvmsChannelEx。
            public byte byFacePicQuality;
            public byte byUIDLen;     // 上传报警的标识长度
            public byte byLivenessDetectionStatus;// 活体检测状态：0-保留，1-未知(检测失败)，2-非真人人脸，3-真人人脸，4-未开启活体检测
            /*附加信息标识位（即是否有NET_VCA_FACESNAP_ADDINFO结构体）,0-无附加信息, 1-有附加信息。*/
            public byte byAddInfo;
            public IntPtr pUIDBuffer;  //标识指针
            public IntPtr pAddInfoBuffer;
            public byte byTimeDiffFlag;      /*时差字段是否有效  0-时差无效， 1-时差有效 */
            public byte cTimeDifferenceH;         /*与UTC的时差（小时），-12 ... +14， +表示东区,，byTimeDiffFlag为1时有效*/
            public byte cTimeDifferenceM;      	/*与UTC的时差（分钟），-30, 30, 45， +表示东区，byTimeDiffFlag为1时有效*/
            public byte byBrokenNetHttp;     //断网续传标志位，0-不是重传数据，1-重传数据
            public IntPtr pBuffer1;//指向人脸子图的图片数据
            public IntPtr pBuffer2;//背景图的图片数据（保留，通过查找背景图接口可以获取背景图）
        }

        //人脸侦测报警信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FACE_DETECTION
        {
            public uint dwSize;
            public uint dwRelativeTime;
            public uint dwAbsTime;
            public uint dwBackgroundPicLen;
            public NET_VCA_DEV_INFO struDevInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 30, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_RECT[] struFacePic; //人脸子图区域，归一化值，相对于大图（背景图)的分辨率
            public byte byFacePicNum;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 255, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//保留
            public IntPtr pBackgroundPicpBuffer;//背景图的图片数据
        }

        //虚焦侦测结果
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEFOCUS_ALARM
        {
            public uint dwSize;     /*结构长度*/
            public NET_VCA_DEV_INFO struDevInfo;/*设备信息*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// 保留字节
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AUDIOEXCEPTION_ALARM
        {
            public uint    dwSize;     /*结构长度*/
            public byte byAlarmType;//报警类型，1-音频输入异常，2-音频输入突变
            public byte byRes1;
            public ushort wAudioDecibel;//声音强度（音频输入突变时用到）
            public NET_VCA_DEV_INFO struDevInfo;/*设备信息*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// 保留字节
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_BUTTON_DOWN_EXCEPTION_ALARM
        {
            public uint dwSize;     /*结构长度*/
            public NET_VCA_DEV_INFO struDevInfo;/*设备信息*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// 保留字节
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FD_IMAGE_CFG
        {
            public uint dwWidth;                  //灰度图像数据宽度
            public uint dwHeight;                 //灰度图像高度
            public uint dwImageLen;  //灰度图像数据长度
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //保留
            public IntPtr pImage;    //灰度图像数据
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FD_PROCIMG_CFG
        {
            public uint  dwSize;           //结构大小
            public byte byEnable;         //是否激活规则;
            public byte bySensitivity;      //检测灵敏度，[0,5]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 22, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;       //保留字节 
            public NET_VCA_SIZE_FILTER struSizeFilter;  //尺寸过滤器
            public NET_VCA_POLYGON  struPolygon;    //多边形
            public NET_VCA_FD_IMAGE_CFG struFDImage;  //图片信息
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;    //保留
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SUB_PROCIMG
        {
            public uint dwImageLen;  //图片数据长度
            public uint dwFaceScore;		//人脸评分,0-100
            public NET_VCA_RECT struVcaRect; //人脸子图区域
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //保留
            public IntPtr pImage;  //图片数据
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FD_PROCIMG_RESULT
        {
            public uint dwSize;   //结构大小
            public uint dwImageId; //大图ID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //保留
            public uint dwSubImageNum;  //人脸子图张数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TARGET_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_SUB_PROCIMG[] struProcImg;  //单张子图信息
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_PICMODEL_RESULT
        {
            public uint dwImageLen;  //图片数据长度
            public uint dwModelLen;  //模型数据长度
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //保留
            public IntPtr pImage;  //人脸图片数据指针
            public IntPtr pModel;  //模型数据指针
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_REGISTER_PIC
        {
            public uint dwImageID; //大图ID
            public uint dwFaceScore;		//人脸评分,0-100
            public NET_VCA_RECT struVcaRect;  //人脸子图区域
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //保留
        }

        //籍贯参数结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AREAINFOCFG
        {
            public ushort wNationalityID;//国籍
            public ushort wProvinceID;//省
            public ushort wCityID;//市
            public ushort wCountyID;//县
            public uint dwCode;//保留
        }

        //人员信息结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_HUMAN_ATTRIBUTE
        {
            public byte bySex;//性别：0-男，1-女
            public byte byCertificateType;//证件类型：0-身份证，1-警官证
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HUMAN_BIRTHDATE_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byBirthDate;//出生年月，如：201106
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byName; //姓名
            public NET_DVR_AREAINFOCFG struNativePlace;//籍贯参数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byCertificateNumber; //证件号
            public uint dwPersonInfoExtendLen;// 人员标签信息扩展长度
            public IntPtr pPersonInfoExtend;  //人员标签信息扩展信息
            public byte byAgeGroup;//年龄段，详见HUMAN_AGE_GROUP_ENUM，如传入0xff表示未知
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;//保留
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_HUMANATTRIBUTE_COND
        {
            public byte bySex; //性别：0-不启用，1-男，2-女
            public byte byCertificateType; //证件类型：0-不启用，1-身份证，2-警官证
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HUMAN_BIRTHDATE_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byStartBirthDate; //起始出生年月，如：201106
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HUMAN_BIRTHDATE_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byEndBirthDate; //截止出生年月，如201106
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byName; //姓名
            public NET_DVR_AREAINFOCFG struNativePlace; //籍贯参数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byCertificateNumber;  //证件号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //禁止名单信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLOCKLIST_INFO
        {
            public uint dwSize;//结构大小
            public uint dwRegisterID;//名单注册ID号（只读）
            public uint dwGroupNo;//分组号
            public byte byType;//名单标志：0-全部，1-允许名单，2-禁止名单
            public byte byLevel;//禁止名单等级，0-全部，1-低，2-中，3-高
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//保留
            public NET_VCA_HUMAN_ATTRIBUTE struAttribute;//人员信息
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRemark;//备注信息
            public uint dwFDDescriptionLen;//人脸库描述数据长度
            public IntPtr pFDDescriptionBuffer;//人脸库描述数据指针
            public uint dwFCAdditionInfoLen;//抓拍库附加信息长度
            public IntPtr pFCAdditionInfoBuffer;//抓拍库附加信息数据指针（FCAdditionInfo中包含相机PTZ坐标）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;//保留
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLOCKLIST_PARA
        {
            public uint dwSize;   //结构大小
            public NET_VCA_BLOCKLIST_INFO struBlockListInfo;  //禁止名单基本参数
            public uint dwRegisterPicNum;  //禁止名单图个数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HUMAN_PICTURE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_PICMODEL_RESULT[] struRegisterPic;  //禁止名单图片信息
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //保留
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLOCKLIST_COND
        {
            public Int32 lChannel; //通道号
            public uint dwGroupNo; //分组号
            public byte byType; //名单标志：0-全部，1-允许名单，2-禁止名单
            public byte byLevel; //禁止名单等级，0-全部，1-低，2-中，3-高
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  //保留
            public NET_VCA_HUMAN_ATTRIBUTE struAttribute; //人员信息
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLOCKLIST_PIC
        {
            public uint dwSize;   //结构大小
            public uint dwFacePicNum;  //人脸图个数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //保留
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HUMAN_PICTURE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_PICMODEL_RESULT[] struBlockListPic;  //单张照片信息
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FIND_PICTURECOND
        {
            public Int32 lChannel;//通道号
            public NET_DVR_TIME struStartTime;//开始时间
            public NET_DVR_TIME struStopTime;//结束时间
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //保留
        }

        public const int MAX_FACE_PIC_LEN = 6144;   //最大人脸图片数据长度
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SUB_SNAPPIC_DATA
        {
            public uint dwFacePicID; //人脸图ID
            public uint dwFacePicLen;  //人脸图数据长度
            public NET_DVR_TIME struSnapTime;  //抓拍时间
            public uint dwSimilarity; //相似度
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //保留
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_FACE_PIC_LEN)]
            public string sPicBuf;  //图片数据
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_ADVANCE_FIND
        {
            public uint dwFacePicID; //人脸图片ID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 36, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_NORMAL_FIND
        {
            public uint dwImageID; //大图ID
            public uint dwFaceScore;  //人脸评分
            public NET_VCA_RECT struVcaRect; //人脸子图区域
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_VCA_FIND_SNAPPIC_UNION
        {
            //联合体大小为44字节
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            /*[FieldOffsetAttribute(0)]
            public NET_VCA_NORMAL_FIND  struNormalFind; //普通检索
            [FieldOffsetAttribute(0)]
            public NET_VCA_ADVANCE_FIND struAdvanceFind; //高级检索
             * */
        }

        public enum VCA_FIND_SNAPPIC_TYPE
        {
            VCA_NORMAL_FIND  = 0x00000000,   //普通检索
	        VCA_ADVANCE_FIND  = 0x00000001  //高级检索
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FIND_PICTURECOND_ADVANCE
        {
            public Int32 lChannel;//通道号
            public NET_DVR_TIME struStartTime;//开始时间
            public NET_DVR_TIME struStopTime;//结束时间
            public byte byThreshold;  //阈值，0-100
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //保留
            public VCA_FIND_SNAPPIC_TYPE dwFindType;//检索类型，详见VCA_FIND_SNAPPIC_TYPE
            public NET_VCA_FIND_SNAPPIC_UNION uFindParam; //检索参数
        }

        //人脸抓拍信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACESNAP_INFO_ALARM
        {
            public uint dwRelativeTime;     // 相对时标
            public uint dwAbsTime;            // 绝对时标
            public uint dwSnapFacePicID;       //抓拍人脸图ID
            public uint dwSnapFacePicLen;        //抓拍人脸子图的长度，为0表示没有图片，大于0表示有图片
            public NET_VCA_DEV_INFO struDevInfo;   //前端设备信息
            public byte byFaceScore;        //人脸评分，指人脸子图的质量的评分,0-100
            public byte bySex;//性别，0-未知，1-男，2-女
            public byte byGlasses;//是否带眼镜，0-未知，1-是，2-否
            /*
             * 识别人脸的年龄段范围[byAge-byAgeDeviation,byAge+byAgeDeviation]
             */
            public byte byAge;//年龄
            public byte byAgeDeviation;//年龄误差值
            public byte byAgeGroup;//年龄段，详见HUMAN_AGE_GROUP_ENUM，若传入0xff表示未知
            /*人脸子图图片质量评估等级，0-低等质量,1-中等质量,2-高等质量,
            该质量评估算法仅针对人脸子图单张图片,具体是通过姿态、清晰度、遮挡情况、光照情况等可影响人脸识别性能的因素综合评估的结果*/
            public byte byFacePicQuality;
            public byte byEthnic; //字段预留,暂不开放
            public uint dwUIDLen; // 上传报警的标识长度
            public IntPtr pUIDBuffer;  //标识指针
            public float fStayDuration;  //停留画面中时间(单位: 秒)
            public IntPtr pBuffer1;  //抓拍人脸子图的图片数据
        }
        
        
        //禁止名单报警信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLOCKLIST_INFO_ALARM
        {
            public NET_VCA_BLOCKLIST_INFO struBlockListInfo;
            public uint dwBlockListPicLen;       //禁止名单人脸子图的长度，为0表示没有图片，大于0表示有图片
            public uint dwFDIDLen;// 人脸库ID长度
            public IntPtr pFDID;  //人脸库Id指针
            public uint dwPIDLen;// 人脸库图片ID长度
            public IntPtr pPID;  //人脸库图片ID指针
            public ushort wThresholdValue; //人脸库阈值[0,100]
            public byte byIsNoSaveFDPicture;//0-保存人脸库图片,1-不保存人脸库图片, 若开启了导入图片或者建模时不保存原图功能时,该字段返回1,此时人脸库图片将不再返回
            public byte byRealTimeContrast;//是否实时报警 0-实时 1-非实时
            public IntPtr pBuffer1;//指向图片的指针
        }

        //禁止名单比对结果报警上传
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACESNAP_MATCH_ALARM
        {
            public uint dwSize;             // 结构大小
            public float fSimilarity; //相似度，[0.001,1]
            public NET_VCA_FACESNAP_INFO_ALARM struSnapInfo; //抓拍信息
            public NET_VCA_BLOCKLIST_INFO_ALARM struBlockListInfo; //禁止名单信息
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] sStorageIP;        //存储服务IP地址
            public ushort wStoragePort;            //存储服务端口号
            public byte byMatchPicNum; //匹配图片的数量，0-保留（老设备这个值默认0，新设备这个值为0时表示后续没有匹配的图片信息）
            public byte byPicTransType;//图片数据传输方式: 0-二进制；1-url
            public uint dwSnapPicLen;//设备识别抓拍图片长度
            public IntPtr pSnapPicBuffer;//设备识别抓拍图片指针
            public NET_VCA_RECT struRegion;//目标边界框，设备识别抓拍图片中，人脸子图坐标
            public uint dwModelDataLen;//建模数据长度
            public IntPtr pModelDataBuffer;// 建模数据指针
            public byte byModelingStatus;// 建模状态
            public byte byLivenessDetectionStatus;//活体检测状态：0-保留，1-未知（检测失败），2-非真人人脸，3-真人人脸，4-未开启活体检测
            public byte cTimeDifferenceH;         /*与UTC的时差（小时），-12 ... +14， +表示东区,0xff无效*/
            public byte cTimeDifferenceM;      	/*与UTC的时差（分钟），-30, 30, 45， +表示东区，0xff无效*/    
            public byte byMask;                //抓拍图是否戴口罩，0-保留，1-未知，2-不戴口罩，3-戴口罩
            public byte bySmile;               //抓拍图是否微笑，0-保留，1-未知，2-不微笑，3-微笑
            public byte byContrastStatus;      //比对结果，0-保留，1-比对成功，2-比对失败
            public byte byBrokenNetHttp;     //断网续传标志位，0-不是重传数据，1-重传数据
        }   
   
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLOCKLIST_INFO_ALARM_LOG
        {
            public NET_VCA_BLOCKLIST_INFO struBlockListInfo; //禁止名单基本信息
            public uint dwBlockListPicID;       //禁止名单人脸子图ID，用于查找图片
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;              // 保留字节
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACESNAP_INFO_ALARM_LOG
        {
            public uint dwRelativeTime;     // 相对时标
            public uint dwAbsTime;			// 绝对时标
            public uint dwSnapFacePicID;       //抓拍人脸图ID
            public NET_VCA_DEV_INFO struDevInfo;		//前端设备信息
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;              // 保留字节
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACESNAP_MATCH_ALARM_LOG
        {
            public uint dwSize;     		// 结构大小
            public float fSimilarity; //相似度，[0.001,1]
            public NET_VCA_FACESNAP_INFO_ALARM_LOG  struSnapInfoLog; //抓拍信息
            public NET_VCA_BLOCKLIST_INFO_ALARM_LOG struBlockListInfoLog; //禁止名单信息
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;              // 保留字节
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACEMATCH_PICCOND
        {
            public uint dwSize;     		// 结构大小
            public uint dwSnapFaceID; //抓拍人脸子图ID
            public uint dwBlockListID; //匹配的禁止名单ID
            public uint dwBlockListFaceID; //比对的禁止名单人脸子图ID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;              // 保留字节
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACEMATCH_PICTURE
        {
            public uint dwSize;     		// 结构大小
            public uint dwSnapFaceLen; //抓拍人脸子图长度
            public uint dwBlockListFaceLen; //比对的禁止名单人脸子图长度
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;              //保留字节
            public IntPtr pSnapFace;  //抓拍人脸子图的图片数据
            public IntPtr pBlockListFace;  //比对的禁止名单人脸子图数据
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLOCKLIST_FASTREGISTER_PARA
        {
            public uint dwSize;   //结构大小
            public NET_VCA_BLOCKLIST_INFO struBlockListInfo;  //禁止名单基本参数
            public uint dwImageLen;  //图像数据长度
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //保留
            public IntPtr pImage;    //图像数据
        }

        //单个分区配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SINGLE_PATH
        {
            public byte byActive;  // 是否可用,0-否,1-是 
            public byte byType;   //0-存储抓拍，1-存储禁止名单比对报警，2-存储抓拍和禁止名单比对报警，0xff-无效
            public byte bySaveAlarmPic; //是否用于保存断网的报警图片，0-否，1-是
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1; //保留
            public uint dwDiskDriver;   //盘符号，从0开始
            public uint dwLeftSpace;   //预留容量（单位为G）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //保留
        }

        //存储路径设置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SAVE_PATH_CFG
        { 
            public uint dwSize;   //结构大小
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_SINGLE_PATH[] struPathInfo; //单个分区
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //保留
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEV_ACCESS_CFG
        {
            public uint   dwSize;
            public NET_DVR_IPADDR struIP;		//接入设备的IP地址
            public ushort wDevicePort;			 	//端口号
            public byte byEnable;		         //是否启用，0-否，1-是
            public byte byRes1;				//保留
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;	//接入设备的登录帐号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;	//接入设备的登录密码
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }
        /********************************智能人脸识别 end****************************/
        //分辨率
        public const int NOT_AVALIABLE = 0;
        public const int SVGA_60HZ = 52505660;
        public const int SVGA_75HZ = 52505675;
        public const int XGA_60HZ = 67207228;
        public const int XGA_75HZ = 67207243;
        public const int SXGA_60HZ = 84017212;
        public const int SXGA2_60HZ = 84009020;
        public const int _720P_60HZ = 83978300;
        public const int _720P_50HZ = 83978290;
        public const int _1080I_60HZ = 394402876;
        public const int _1080I_50HZ = 394402866;
        public const int _1080P_60HZ = 125967420;
        public const int _1080P_50HZ = 125967410;
        public const int _1080P_30HZ = 125967390;
        public const int _1080P_25HZ = 125967385;
        public const int _1080P_24HZ = 125967384;
        public const int UXGA_60HZ = 105011260;
        public const int UXGA_30HZ = 105011230;
        public const int WSXGA_60HZ = 110234940;
        public const int WUXGA_60HZ = 125982780;
        public const int WUXGA_30HZ = 125982750;
        public const int WXGA_60HZ = 89227324;
        public const int SXGA_PLUS_60HZ = 91884860;

        //显示通道画面分割模式
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISPWINDOWMODE
        {
            public byte byDispChanType;//显示通道类型：0-VGA, 1-BNC, 2-HDMI, 3-DVI
            public byte byDispChanSeq;//显示通道序号,从1开始，如果类型是VGA，则表示第几个VGA
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byDispMode;
        }

        //显示通道信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISPINFO
        {
            public byte byChanNums;//通道个数
            public byte byStartChan;//起始通道
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SUPPORT_RES, ArraySubType = UnmanagedType.U1)]
            public uint[] dwSupportResolution;//支持的分辨率
        }

        //大屏拼接信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREENINFO
        {
            public byte bySupportBigScreenNums;//最多大屏拼接数量
            public byte byStartBigScreenNum;//大屏拼接起始号
            public byte byMaxScreenX;//大屏拼接模式
            public byte byMaxScreenY;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_ABILITY_V41
        {
            public uint dwSize;
            public byte byDspNums;//DSP个数  
            public byte byDecChanNums;//解码通道数
            public byte byStartChan;//起始解码通道
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;

            public NET_DVR_DISPINFO struVgaInfo;//VGA显示通道信息
            public NET_DVR_DISPINFO struBncInfo;//BNC显示通道信息
            public NET_DVR_DISPINFO struHdmiInfo;//HDMI显示通道信息
            public NET_DVR_DISPINFO struDviInfo;//DVI显示通道信息
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISPNUM_V41, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DISPWINDOWMODE[] struDispMode;
            public NET_DVR_SCREENINFO struBigScreenInfo;
            public byte bySupportAutoReboot; //是否支持自动重启，0-不支持，1-支持
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 119, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        public const int MAX_WINDOWS = 16;//最大窗口数
        public const int MAX_WINDOWS_V41 = 36;
        
        public const int STARTDISPCHAN_VGA = 1;
        public const int STARTDISPCHAN_BNC = 9;
        public const int STARTDISPCHAN_HDMI	= 25;
        public const int STARTDISPCHAN_DVI = 29;

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_VIDEO_PLATFORM
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 160, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            /*[FieldOffsetAttribute(0)]
            public VideoPlatform struVideoPlatform;
            [FieldOffsetAttribute(0)]
            public NotVideoPlatform struNotVideoPlatform;
             * */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct VideoPlatform
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecoderId;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byDecResolution;
            public NET_DVR_RECTCFG struPosition; //显示通道在电视墙中位置
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 80, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NotVideoPlatform
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 160, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*显示通道配置结构体*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_VOUTCFG
        {
            public uint dwSize;
            public byte byAudio;			/*音频是否开启*/
            public byte byAudioWindowIdx;      /*音频开启子窗口*/
            public byte byDispChanType;      /*显示通道类型：0-BNC，1-VGA，2-HDMI，3-DVI，4-YPbPr(解码卡服务器DECODER_SERVER专用)*/
            public byte byVedioFormat;         /*1:NTSC,2:PAL，0-NULL*/
            public uint dwResolution;//分辨率
            public uint dwWindowMode;		/*画面模式，能力集获取*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecChan;/*各个子窗口关联的解码通道,设备支持解码资源自动分配时此参数不用填充*/
            public byte byEnlargeStatus;          /*是否处于放大状态，0：不放大，1：放大*/
            public byte byEnlargeSubWindowIndex;//放大的子窗口号
            public byte byScale; /*显示模式，0---真实显示，1---缩放显示( 针对BNC )*/
            public byte byUnionType;/*区分共用体,0-视频综合平台内部解码器显示通道配置，1-其他解码器显示通道配置*/
            public NET_DVR_VIDEO_PLATFORM struDiff;
            public uint dwDispChanNum; //显示输出号，此参数在全部获取时有效
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 76, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        } 

        /*解码器设备状态*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISP_CHAN_STATUS_V41
        {
            public byte byDispStatus;      /*显示状态：0：未显示，1：启动显示*/
            public byte byBVGA;              /*0-BNC，1-VGA， 2-HDMI，3-DVI，0xff-无效*/
            public byte byVideoFormat;     /*视频制式，1:NTSC,2:PAL,0-NON*/
            public byte byWindowMode;       /*画面模式*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecChan;   /*各个子画面关联的解码通道*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byFpsDisp;        /*每个子画面的显示帧率*/
            public byte byScreenMode;		/*屏幕模式0-普通 1-大屏*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwDispChan; /*获取全部显示通道状态时有效，设置时可填0*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
        }

        /*解码器设备状态*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODER_WORK_STATUS_V41
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_CHAN_STATUS[] struDecChanStatus;     /*解码通道状态*/
	        /*显示通道状态*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISPNUM_V41, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DISP_CHAN_STATUS_V41[] struDispChanStatus;     
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmInStatus;         /*报警输入状态*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmOutStatus;       /*报警输出状态*/
            public byte byAudioInChanStatus;          /*语音对讲状态*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 127, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*******************************文件回放-远程回放设置*******************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_DEC_REMOTE_PLAY_V41
        {
            public uint dwSize;
            public NET_DVR_IPADDR	struIP;		/* DVR IP地址 */	
            public ushort wDVRPort;			/* 端口号 */	
            public byte byChannel;			/* 通道号 */
            public byte byReserve;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;		/* 用户名 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;		/* 密码 */
            public uint dwPlayMode;   	/* 0－按文件 1－按时间*/        	
            public NET_DVR_TIME StartTime;
            public NET_DVR_TIME StopTime;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string sFileName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		/*保留*/
        }

        public const int MAX_BIGSCREENNUM_SCENE = 100;

        //显示通道配置结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECTCFG_SCENE
        {
            public ushort wXCoordinate; /*矩形左上角起始点X坐标*/
            public ushort wYCoordinate; /*矩形左上角Y坐标*/
            public ushort wWidth;       /*矩形宽度*/
            public ushort wHeight;      /*矩形高度*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCENEDISPCFG
        {
            public byte byEnable;//是否启用，0-不启用，1-启用
            public byte bySoltNum;//槽位号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byDispChanNum;
            public byte byAudio;				/*音频是否开启,0-否，1-是*/
            public byte byAudioWindowIdx;      /*音频开启子窗口*/
            public byte byVedioFormat;          /*1:NTSC,2:PAL，0-NULL*/
            public byte byWindowMode;			/*画面模式，从能力集获取*/
            public byte byEnlargeStatus;         /*是否处于放大状态，0：不放大，1：放大*/
            public byte byEnlargeSubWindowIndex;//放大的子窗口号    
            public byte byScale; /*显示模式，0-真实显示，1-缩放显示( 针对BNC )*/
            public uint dwResolution;//分辨率
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecChan;/*各个子窗口关联的解码通道*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecoderId;/*槽位号*/
            //显示窗口所解视频分辨率，1-D1,2-720P,3-1080P，设备端需要根据此//分辨率进行解码通道的分配，如1分屏配置成1080P，则设备会把4个解码通道都分配给此解码通道
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byDecResolution;
            public byte byRow;//大屏所在的行的序号
            public byte byColumn;//大屏所在的列的序号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public NET_DVR_RECTCFG struDisp; //电视墙显示位置
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEV_CHAN_INFO_SCENE
        {
            public NET_DVR_IPADDR struIP;				/* DVR IP地址 */
            public ushort wDVRPort;			 	/* 端口号 */
            public byte byChannel;		/* 通道号，对于9000等设备的IPC接入，通道号从33开始 */
            public byte byTransProtocol;		/* 传输协议类型0-TCP，1-UDP ，2-MCAST，3-RTP*/
            public byte byTransMode;			/* 传输码流模式 0－主码流 1－子码流*/
            public byte byFactoryType;				/*前端设备厂家类型*/
            public byte byDeviceType;			//设备类型，1-IPC，2- ENCODER
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;	/* 监控主机登陆帐号 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;	/* 监控主机密码 */
        }

        /*流媒体服务器基本配置*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_STREAM_MEDIA_SERVER_CFG_SCENE
        {
            public byte byValid;			/*是否启用流媒体服务器取流,0表示无效*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_IPADDR struDevIP;	/*流媒体服务器地址*/
            public ushort wDevPort;			/*流媒体服务器端口*/
            public byte byTransmitType;		/*传输协议类型0-TCP，1-UDP */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PU_STREAM_CFG_SCENE
        {
            public NET_DVR_STREAM_MEDIA_SERVER_CFG_SCENE	streamMediaServerCfg;
            public NET_DVR_DEV_CHAN_INFO_SCENE				struDevChanInfo;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CYC_SUR_CHAN_ELE_SCENE
        {
            public byte byEnable;	/* 是否启用 0－否 1－启用*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_STREAM_MEDIA_SERVER_CFG_SCENE	struStreamMediaSvrCfg;	
            public NET_DVR_DEV_CHAN_INFO_SCENE			struDecChanInfo;	/*轮巡解码通道信息*/
        }

        //轮巡解码结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_LOOP_DECINFO_SCENE
        {
            public ushort wPoolTime;		/*轮询间隔*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CYCLE_CHAN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CYC_SUR_CHAN_ELE_SCENE[] struChanArray;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BIGSCREENCFG_SCENE
        {
            public byte byAllValid; /*漫游使能标志 */
            public byte byAssociateBaseMap;//关联的底图序号，0代表不关联
            public byte byEnableSpartan;//大屏畅显使能，1-开，0-关
            public byte byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LAYERNUMS, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_WINCFG[] struWinCfg;
            public NET_DVR_BIGSCREENCFG struBigScreen;

            public void Init()
            {
                struBigScreen = new NET_DVR_BIGSCREENCFG();
                struWinCfg = new NET_DVR_WINCFG[MAX_LAYERNUMS];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_SCENECFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSceneName;
            public byte byBigScreenNums;//大屏的个数，最大值通过能力集获取
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public ushort wDecChanNums;//场景中解码通道的个数
            public ushort wDispChanNums;//场景中显示通道的个数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public IntPtr pBigScreenBuffer;//大屏配置缓冲区, byBigScreenNums×sizeof(NET_DVR_BIGSCREENCFG_SCENE)
            public IntPtr pDecChanBuffer;//解码通道配置缓冲区, wDecChanNums×sizeof(NET_DVR_DECODECHANCFG_SCENE)
            public IntPtr pDispChanBuffer;//显示通道配置缓冲区, wDispChanNums×sizeof(NET_DVR_SCENEDISPCFG)
            public void Init()
            {
                sSceneName = new byte[NAME_LEN];
                byRes1 = new byte[3];
                byRes1 = new byte[12];
            }
        }
        public const int NET_DVR_GET_ALLWINCFG = 1503; //窗口参数获取

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BIGSCREENASSOCIATECFG
        {
            public uint dwSize;
            public byte byEnableBaseMap;//使能底图显示
            public byte byAssociateBaseMap;//关联的底图序号，0代表不关联
            public byte byEnableSpartan;//大屏畅显使能，1-开，0-关
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 21, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        
        /*******************************窗口设置*******************************/
        public const int MAX_WIN_COUNT = 224; //支持的最大开窗数

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREEN_WINCFG{
            public uint dwSize;
            public byte byVaild;
            public byte byInputType;		//见CAM_MDOE
            public ushort wInputIdx;			/*输入源索引*/
            public uint dwLayerIdx;			/*图层，0为最底层*/
            public NET_DVR_RECTCFG struWin;	//目的窗口(相对显示墙)
            public byte byWndIndex;			//窗口号
            public byte byCBD;				//0-无，1-带背景，2-不带背景
            public byte bySubWnd;			//0不是，1是
            public byte byRes1;
            public uint dwDeviceIndex;//设备序号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WINLIST
        {
            public uint dwSize;
            public ushort wScreenSeq;	//设备序号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwWinNum;	//设备返回的窗口数量
            public IntPtr pBuffer;	//窗口信息缓冲区，最大为224*sizeof(NET_DVR_WINCFG)
            public uint dwBufLen;	//所分配指针长度
        }

        public const int MAX_LAYOUT_COUNT = 16;		//最大布局数

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LAYOUTCFG
        {
            public uint dwSize;
            public byte byValid;								//布局是否有效
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byLayoutName;			//布局名称			
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WIN_COUNT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCREEN_WINCFG[] struWinCfg;	//布局内窗口参数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LAYOUT_LIST
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LAYOUT_COUNT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_LAYOUTCFG[] struLayoutInfo;   //所有布局
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int MAX_CAM_COUNT = 224;

        public enum NET_DVR_CAM_MODE
        {
	        NET_DVR_UNKNOW  = 0,//无效
	        NET_DVR_CAM_BNC,
	        NET_DVR_CAM_VGA,
	        NET_DVR_CAM_DVI,
	        NET_DVR_CAM_HDMI,
	        NET_DVR_CAM_IP,
	        NET_DVR_CAM_RGB,
            NET_DVR_CAM_DECODER,
	        NET_DVR_CAM_MATRIX,
	        NET_DVR_CAM_YPBPR,
	        NET_DVR_CAM_USB,
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INPUTSTREAMCFG
        {
            public uint dwSize ;
            public byte byValid ;
            public byte byCamMode;						//信号输入源类型，见NET_DVR_CAM_MODE
            public ushort wInputNo;						//信号源序号0-224
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sCamName;			//信号输入源名称
            public NET_DVR_VIDEOEFFECT struVideoEffect;	//视频参数
            public NET_DVR_PU_STREAM_CFG struPuStream;	//ip输入时使用
            public ushort wBoardNum ;						//信号源所在的板卡号
            public ushort wInputIdxOnBoard;				//信号源在板卡上的位置
            public ushort wResolutionX;					//分辨率
            public ushort wResolutionY;
            public byte byVideoFormat;					//视频制式，0-无，1-NTSC，2-PAL
            public byte byNetSignalResolution;	//; 1-CIF 2-4CIF 3-720P 4-1080P 5-500wp 。网络信号源的分辨率，在添加网络信号源时传给设备，设备根据这个分辨率来分配解码资源。
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sGroupName;	//网络信号源分组 组名
            public byte byJointMatrix;			//  关联矩阵 ，0-不关联  1-关联
            public byte byRes;  
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INPUTSTREAM_LIST
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CAM_COUNT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_INPUTSTREAMCFG[] struInputStreamInfo; //所有信号源
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*******************************输出参数配置*******************************/
        /*输出通道管理*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OUTPUTPARAM
        {
            public uint  dwSize;
            public byte byMonMode;		/*输出连接模式,1-BNC,2-VGA,3-DVI,4-HDMI*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint  dwResolution;	/*分辨率，根据能力集获取所支持的进行设置*/
            public NET_DVR_VIDEOEFFECT  struVideoEffect;	/*输出通道视频参数配置*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OUTPUTCFG
        {
            public uint dwSize;
            public byte byScreenLayX;						//大屏布局-横坐标
            public byte byScreenLayY;						//大屏布局-纵坐标
            public ushort wOutputChanNum;					//输出通道个数，0表示设备支持的最大输出通道个数，最大个数从能力集获取，其他值表示实际输出通道个数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_OUTPUTPARAM struOutputParam;	/*输出通道视频参数配置*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] sWallName;					//电视墙名称
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************能力集*******************************/
        public const int SCREEN_PROTOCOL_NUM = 20;   //支持的最大大屏控制器协议数
        
        //多屏服务器能力集
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREENSERVER_ABILITY
        {
            public uint dwSize;   			/*结构长度*/
            public byte byIsSupportScreenNum; /*所支持大屏控制器的数目*/
            public byte bySerialNums;			//串口个数
            public byte byMaxInputNums;
            public byte byMaxLayoutNums;
            public byte byMaxWinNums;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 19, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byMaxScreenLayX;//大屏布局-最大横坐标大屏数
            public byte byMaxScreenLayY;//大屏布局-最大纵坐标大屏数
            public ushort wMatrixProtoNum; /*有效的大屏协议数目*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SCREEN_PROTOCOL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PROTO_TYPE[] struScreenProto;/*最大协议列表*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //多屏控制器能力集
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREENCONTROL_ABILITY
        {
            public uint dwSize;   		/*结构长度*/
            public byte byLayoutNum; 		/* 布局个数*/
            public byte byWinNum; 			/*屏幕窗口个数*/
            public byte byOsdNum;  		/*OSD个数*/
            public byte byLogoNum; 		/*Logo个数*/
            public byte byInputStreamNum;  //输入源个数 ---设备支持最大输入通道个数（包括本地输入源和网络输入源）
            public byte byOutputChanNum;	//输出通道个数---设备支持最大输出通道个数
            public byte byCamGroupNum;		/*分组个数*/
            public byte byPlanNum;    		/*预案个数*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byIsSupportPlayBack;  /*是否支持回放*/	
            public byte byMatrixInputNum;  //支持输入矩阵最大个数
            public byte byMatrixOutputNum; //支持输出矩阵最大个数
            public NET_DVR_DISPINFO struVgaInfo;//VGA输出信息
            public NET_DVR_DISPINFO struBncInfo;//BNC输出信息
            public NET_DVR_DISPINFO struHdmiInfo;//HDMI输出信息
            public NET_DVR_DISPINFO struDviInfo;//DVI输出信息
            public byte byMaxUserNums;//支持用户数
            public byte byPicSpan;		//底图跨度，一张底图最多可覆盖的屏幕数
            public ushort wDVCSDevNum;	//分布式大屏控制器最大设备数
            public ushort wNetSignalNum;	//最大网络输入源个数
            public ushort wBaseCoordinateX;//基准坐标
            public ushort wBaseCoordinateY; 
            public byte byExternalMatrixNum;	//最大外接矩阵个数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 49, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************输入信号状态*******************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ANALOGINPUTSTATUS
        {
            public uint dwLostFrame;		/*视频输入丢帧数*/
            public byte byHaveSignal;		/*是否有视频信号输入*/
            public byte byVideoFormat;		/*视频制式，1：NTSC,2：PAL,0：无*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 46, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        } 

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_INPUTSTATUS_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 52, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            /*[FieldOffsetAttribute(0)]
            public NET_DVR_MATRIX_CHAN_STATUS struIpInputStatus;
            [FieldOffsetAttribute(0)]
            public NET_DVR_ANALOGINPUTSTATUS struAnalogInputStatus;
             * */
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INPUTSTATUS
        {
            public ushort wInputNo;		/*信号源序号*/
            public byte byInputType;	//见NET_DVR_CAM_MODE
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_INPUTSTATUS_UNION struStatusUnion;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREENINPUTSTATUS
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwNums;		//设备返回的输入源状态的数量
            public IntPtr pBuffer;	//缓冲区
            public uint dwBufLen;	//所分配指针长度，输入参数
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREENALARMCFG
        {
            public uint dwSize;
            public byte byAlarmType;	//报警类型，1-子板拔出，2-子板插入，3-子系统状态异常，4-子系统恢复恢复 5-输入源异常   6-温度报警 7-FPGA版本不匹配 8-预案开始 9-预案结束 10-解码板断网 11-解码板IP地址冲突，12-风扇异常
            public byte byBoardType;	// 1-输入板 2-输出板 ，3-主板，4-背板，报警类型为1，2，3，6的时候使用 
            public byte bySubException;	//输入异常时具体子异常 1- 分辨率正常改变 2-输入端口类型改变3-分辨率错误4-分辨率改变导致解码资源不足，关闭该输入源对应窗口。5-分辨率改变，导致已开窗的缩放比例不在1/8到8倍范围。6-分辨率恢复正常,7-分辨率改变导致输出板数据量超限,设备关闭窗口 
            public byte byRes1;
            public ushort wStartInputNum; // 异常输入源（异常起点） 
            public ushort wEndInputNum;	// 异常输入源（异常终点） 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;	   
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_CFG
        {
            public byte byValid;				//判断是否是模拟矩阵（是否有效）
            public byte byCommandProtocol;	//模拟矩阵的指令（4种）
            public byte byScreenType;			//保留	
            public byte byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byScreenToMatrix;	//模拟矩阵的输出与屏幕的对应关系
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DIGITALSCREEN
        {
            public NET_DVR_IPADDR  struAddress;/*设备为数字设备时的IP信息*/
            public ushort wPort;		//通道号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 26, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //保留
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ANALOGSCREEN
        {
            public byte byDevSerPortNum;   /*连接设备的串口号*/
            public byte byScreenSerPort;  /*连接大屏的串口号*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 130, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   
            public NET_DVR_MATRIX_CFG struMatrixCfg;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_SCREEN_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 172, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  
            
            /*[FieldOffsetAttribute(0)]
            public NET_DVR_DIGITALSCREEN struDigitalScreen;
            [FieldOffsetAttribute(0)]
            public NET_DVR_ANALOGSCREEN struAnalogScreen;
             * */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREEN_SCREENINFO
        {
            public uint dwSize;
            public byte byValid;				//是否有效
            public byte nLinkMode;				//连接方式，0-串口，1-网口
            public byte byDeviceType;			//设备型号，能力集获取
            public byte byScreenLayX;			//大屏布局-横坐标
            public byte byScreenLayY;			//大屏布局-纵坐标
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;	/*登录用户名*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword; /*登录密码*/   
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDevName;	/*设备名称*/
            public NET_DVR_SCREEN_UNION struScreenUnion;
            public byte byInputNum;			// 输入源个数
            public byte byOutputNum;			// 输出源个数
            public byte byCBDNum;				//CBD个数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 29, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************底图上传*******************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BASEMAP_CFG
        {	
            public byte byScreenIndex;         //屏幕的序号
            public byte byMapNum;				/*被分割成了多少块*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
            public ushort wSourWidth;			/* 原图片的宽度 */
            public ushort wSourHeight;			/* 原图片的高度 */
        }            

        /*******************************OSD*******************************/
        public const int MAX_OSDCHAR_NUM = 256;
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OSDCFG
        {
            public uint dwSize;
            public byte byValid;    /*是否有效 0无效 1有效*/
            public byte byDispMode;  //显示模式，1-透明，2-半透明，3-覆盖三种模式
            public byte byFontColorY; /*字体颜色Y,0-255*/
            public byte byFontColorU; /*字体颜色U,0-255*/
            public byte byFontColorV; /*字体颜色V,0-255*/
            public byte byBackColorY; /*背景颜色Y,0-255*/
            public byte byBackColorU; /*背景颜色U,0-255*/
            public byte byBackColorV; /*背景颜色V,0-255*/
            public ushort wXCoordinate;   /*OSD在屏幕左上角位置x*/
            public ushort wYCoordinate;   /*OSD在屏幕左上角位置y*/
            public ushort wWidth;       /*OSD宽度*/
            public ushort wHeight;      /*OSD高度*/
            public uint dwCharCnt;     /*字符的个数*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_OSDCHAR_NUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wOSDChar;       /*OSD字符内容*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*******************************获取串口信息*******************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SERIAL_CONTROL
        { 
            public uint dwSize ;
            public byte bySerialNum;        // 串口个数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] bySerial;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************屏幕控制*******************************/
        //屏幕输入源控制
        public enum INPUT_INTERFACE_TYPE
        {
	        INTERFACE_VGA = 0,
	        INTERFACE_SVIDEO, // 2046NL不支持，2046NH支持
	        INTERFACE_YPBPR,
	        INTERFACE_DVI ,
	        INTERFACE_BNC , 
	        INTERFACE_DVI_LOOP,//(环通) 2046NH不支持，2046NL支持
	        INTERFACE_BNC_LOOP, //(环通) 2046NH不支持，2046NL.支持
	        INTERFACE_HDMI,
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INPUT_INTERFACE_CTRL
        {
            public byte byInputSourceType;	//见INPUT_INTERFACE_TYPE
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        
        //显示单元颜色控制
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISPLAY_COLOR_CTRL
        {
            public byte byColorType;		//1-亮度 2-对比度 3-饱和度 4-清晰度
            public char	byScale;			//-1 、0、+1三个值
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //显示单元位置控制
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISPLAY_POSITION_CTRL
        {
            public byte byPositionType;	//1-水平位置 2-垂直位置，
            public char byScale;			//-1 、0、+1三个值
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_SCREEN_CONTROL_PARAM
        {
            /*[FieldOffsetAttribute(0)]
            public NET_DVR_INPUT_INTERFACE_CTRL struInputCtrl;
            [FieldOffsetAttribute(0)]
            public NET_DVR_DISPLAY_COLOR_CTRL struDisplayCtrl;
            [FieldOffsetAttribute(0)]
            public NET_DVR_DISPLAY_POSITION_CTRL struPositionCtrl;
            [FieldOffsetAttribute(0)]
             * */
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREEN_CONTROL
        { 	
            public uint dwSize;			 
            public uint dwCommand ;      /* 控制方法 1-开 2-关 3-屏幕输入源选择 4-显示单元颜色控制 5-显示单元位置控制*/
            public byte byProtocol;      //串口协议类型,1:LCD-S1,2:LCD-S2
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_SCREEN_CONTROL_PARAM	struControlParam;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 52, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;	
        }

        /*******************************屏幕控制V41*******************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREEN_CONTROL_V41
        { 	
            public uint dwSize;
            public byte bySerialNo;		//串口号
            public byte byBeginAddress;	//左上角屏幕号，从1开始
            public byte byEndAddress;	//右下角屏幕号，从1开始
            public byte byProtocol;      	   // 串口协议类型  1-LCD-S1 , 2-LCD-S2 , 3-LCD-L1 ， 4-LCD-DLP， 5-LCD-S3 , 6-LCD-H1 
            public uint dwCommand ;      /* 控制方法 1-开 2-关 3-屏幕输入源选择 4-显示单元颜色控制 5-显示单元位置控制*/
            public NET_DVR_SCREEN_CONTROL_PARAM	struControlParam;
            public byte byWallNo;		// 电视墙号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 51, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;	
        }

        /*******************************预案管理*******************************/
        public const int MAX_PLAN_ACTION_NUM = 32; 	//预案动作个数
        public const int DAYS_A_WEEK = 7;	//一周7天
        public const int MAX_PLAN_COUNT = 16;	//预案个数

        public enum NET_DVR_PLAN_OPERATE_TYPE
        {
	        NET_DVR_SWITCH_LAYOUT = 1, 		// 布局切换 默认
	        NET_DVR_SCREEN_POWER_OFF,  		// 关闭大屏幕显示
	        NET_DVR_SCREEN_POWER_ON,   		// 打开大屏幕显示
        }

        /*预案项信息*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLAN_INFO
        {
            public byte byValid;      	// 该项是否有效
            public byte byType;       	// 见定义NET_DVR_PLAN_OPERATE_TYPE
            public ushort wLayoutNo;  	// 布局号
            public byte byScreenStyle;    //屏幕型号，开关机所用，1是低亮，2是高亮
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwDelayTime;  	// 一个项的运行时间, 单位秒
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CYCLE_TIME
        {
            public byte byValid; 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_TIME_EX struTime;
        }

        /*预案管理*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLAN_CFG
        {
            public uint dwSize;
            public byte byValid;      	// 该预案是否有效
            public byte byWorkMode;  	// 预案工作模式 1表示手动，2自动，3预案循环
            public byte byWallNo;		//电视墙号，从1开始
            public byte byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPlanName; //预案名称
            public NET_DVR_TIME_EX struTime; // 工作模式为自动时使用
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DAYS_A_WEEK, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CYCLE_TIME[] struTimeCycle; /*循环时间，周期为一个星期，年、月、日三个参数不使用。如：struTimeCycle[0]中的byValid的值是1，表示星期天执行该预案。星期取值区间为[0,6]，其中0代表星期天，1代表星期一，以此类推*/
            public uint dwWorkCount;  	// 预案内容执行次数，0为一直循环播放，其他值表示次数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PLAN_ACTION_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PLAN_INFO[] strPlanEntry;  // 预案执行的内容
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************获取设备状态*******************************/
        /*预案列表*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLAN_LIST
        {
            public uint dwSize;
            public uint dwPlanNums;			//设备输入信号源数量
            public IntPtr pBuffer;			//指向dwInputSignalNums个NET_DVR_PLAN_CFG结构大小的缓冲区
            public byte byWallNo;			//墙号，从1开始
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwBufLen;			//所分配缓冲区长度，输入参数（大于等于dwInputSignalNums个NET_DVR_PLAN_CFG结构大小）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************预案控制*******************************/
        //该结构体可作为通用控制结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CONTROL_PARAM
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDeviceID; //被控设备的设备ID
            public ushort wChan;				 //被控通道
            public byte byIndex;			 //控制索引，根据命令确定具体表示什么索引
            public byte byRes1;
            public uint dwControlParam;
            public byte byMandatoryAlarm;    //1-使能  0-不使能
            public byte byRes2;
            public ushort wZoneIndex;  //防区号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byOperatorCode;//回控码
            public uint dwPlanNo; //4字节预案号，客户端统一使用4字节的预案号，单字节的预案号不再使用
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }

        /*******************************获取设备状态*******************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEVICE_RUN_STATUS
        {
            public uint dwSize;
            public uint dwMemoryTotal;		//内存总量	单位Kbyte
            public uint dwMemoryUsage;		//内存使用量 单位Kbyte
            public byte byCPUUsage;			//CPU使用率 0-100
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 127, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //91系列HD-SDI高清DVR 相机信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ACCESS_CAMERA_INFO
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sCameraInfo;		// 前端相机信息
            public byte  byInterfaceType;		// 前端接入接口类型，1:VGA, 2:HDMI, 3:YPbPr 4:SDI 5:FC
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwChannel;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AUDIO_INPUT_PARAM
        {
            public byte byAudioInputType;  //音频输入类型，0-mic in，1-line in
            public byte byVolume; //volume,[0-100]
            public byte byEnableNoiseFilter; //是否开启声音过滤-关，-开
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byres;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CAMERA_DEHAZE_CFG
        {
            public uint dwSize;
            public byte byDehazeMode; //0-不启用，1-自动模式，2-开
            public byte byLevel; //等级，0-100
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; 
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INPUT_SIGNAL_LIST
        {
            public uint dwSize;
            public uint dwInputSignalNums;	//设备输入信号源数量
            public IntPtr pBuffer;			//指向dwInputSignalNums个NET_DVR_INPUTSTREAMCFG结构大小的缓冲区
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwBufLen;			//所分配缓冲区长度，输入参数（大于等于dwInputSignalNums个NET_DVR_INPUTSTREAMCFG结构大小）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //安全拔盘状态
        public const int PULL_DISK_SUCCESS = 1;     // 安全拔盘成功
        public const int PULL_DISK_FAIL = 2;        // 安全拔盘失败
        public const int PULL_DISK_PROCESSING = 3;  // 正在停止阵列
        public const int PULL_DISK_NO_ARRAY = 4;	// 阵列不存在 
        public const int PULL_DISK_NOT_SUPPORT = 5; // 不支持安全拔盘

        //扫描阵列状态
        public const int SCAN_RAID_SUC = 1; 	// 扫描阵列成功
        public const int SCAN_RAID_FAIL = 2; 	// 扫描阵列失败
        public const int SCAN_RAID_PROCESSING = 3;	// 正在扫描阵列
        public const int SCAN_RAID_NOT_SUPPORT = 4; // 不支持阵列扫描

        //设置前端相机类型状态
        public const int SET_CAMERA_TYPE_SUCCESS = 1;  // 成功
        public const int SET_CAMERA_TYPE_FAIL = 2;  // 失败
        public const int SET_CAMERA_TYPE_PROCESSING	= 3;   // 正在处理

        //9000 2.2
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECORD_TIME_SPAN_INQUIRY
        {
            public uint dwSize;    //结构体大小
            public byte byType;    //0 正常音视频录像, 1图片通道录像, 2ANR通道录像, 3抽帧通道录像
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //保留
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECORD_TIME_SPAN
        {
            public uint dwSize;        //结构体大小
            public NET_DVR_TIME strBeginTime;  //开始时间
            public NET_DVR_TIME strEndTime;    //结束时间
            public byte byType;        //0 正常音视频录像, 1图片通道录像, 2ANR通道录像, 3抽帧通道录像
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 35, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     //保留
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DRAWFRAME_DISK_QUOTA_CFG
        {
            public uint dwSize;					//结构体大小
            public byte byPicQuota;				//图片百分比	 [0%,  30%]
            public byte byRecordQuota;				//普通录像百分比 [20%, 40%]
            public byte byDrawFrameRecordQuota;	//抽帧录像百分比 [30%, 80%]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 61, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;					//保留字节
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MANUAL_RECORD_PARA
        {
            public NET_DVR_STREAM_INFO struStreamInfo; 
            public uint lRecordType;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //端口映射配置结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NAT_PORT
        {
            public ushort wEnable;
            public ushort wExtPort;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //端口映射配置结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NAT_CFG
        {
            public uint dwSize;
            public ushort wEnableUpnp;
            public ushort wEnableNat;
            public NET_DVR_IPADDR struIpAddr;//夏时制停止时间
            public NET_DVR_NAT_PORT struHttpPort;//夏时制停止时间
            public NET_DVR_NAT_PORT struCmdPort;//夏时制停止时间
            public NET_DVR_NAT_PORT struRtspPort;//夏时制停止时间
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byFriendName;
            public byte byNatType;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_NAT_PORT struHttpsPort;//夏时制停止时间
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 76, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //Upnp端口映射状态结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_UPNP_PORT_STATE
        {
            public uint dwEnabled;//该端口是否被使能映射
            public ushort wInternalPort;//映射前的端口
            public ushort wExternalPort;//映射后的端口
            public uint dwStatus;//端口映射状态：0- 未生效；1- 未生效：映射源端口与目的端口需一致；2- 未生效：映射端口号已被使用；3- 生效
            public NET_DVR_IPADDR struNatExternalIp;//映射后的外部地址
            public NET_DVR_IPADDR struNatInternalIp;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//保留
        }

        //Upnp端口映射状态结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_UPNP_NAT_STATE
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_UPNP_PORT_STATE[] strUpnpPort;//端口映射状态:：数组0- web server端口，数组1- 管理端口，数组2- rtsp端
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 200, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//保留
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLAYCOND
        {
            public uint dwChannel;
            public NET_DVR_TIME struStartTime;
            public NET_DVR_TIME struStopTime;
            public byte byDrawFrame;  //0:不抽帧，1：抽帧
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;    //保留
        }

        //录像回放结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VOD_PARA
        {
            public uint dwSize; //结构体大小
            public NET_DVR_STREAM_INFO struIDInfo; //流ID信息
            public NET_DVR_TIME struBeginTime;//回放开始时间
            public NET_DVR_TIME struEndTime;//回放结束时间
            public IntPtr hWnd;//回放窗口
            public byte byDrawFrame;//是否抽帧：0- 不抽帧，1- 抽帧
            public byte byVolumeType;//0-普通录像卷，1-存档卷，适用于CVR设备，普通卷用于通道录像，存档卷用于备份录像
            public byte byVolumeNum;//存档卷号 
            public byte byRes1;//保留
            public uint dwFileIndex;//存档卷上的录像文件索引，搜索存档卷录像时返回的值
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;    //保留
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATMFINDINFO
        {
            public byte byTransactionType;       //交易类型 0-全部，1-查询， 2-取款， 3-存款， 4-修改密码，5-转账， 6-无卡查询 7-无卡存款， 8-吞钞 9-吞卡 10-自定义
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;    //保留
            public uint dwTransationAmount ;     //交易金额 ;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_SPECIAL_FINDINFO_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byLenth ;
           /* [FieldOffsetAttribute(0)]
            public NET_DVR_ATMFINDINFO struATMFindInfo;	       //ATM查询
            * */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FILECOND_V40
        {
            public Int32 lChannel;
            public uint dwFileType;
            public uint dwIsLocked;
            public uint dwUseCardNo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CARDNUM_LEN_OUT, ArraySubType = UnmanagedType.I1)]
            public byte[] sCardNumber;
            public NET_DVR_TIME struStartTime;
            public NET_DVR_TIME struStopTime;
            public byte byDrawFrame; //0:不抽帧，1：抽帧
            public byte byFindType; //0:查询普通卷，1：查询存档卷
            public byte byQuickSearch; //0:普通查询，1：快速（日历）查询
            public byte bySpecialFindInfoType ;    //专有查询条件类型 0-无效， 1-带ATM查询条件  
            public uint dwVolumeNum;  //存档卷号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = GUID_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byWorkingDeviceGUID;    //工作机GUID，通过获取N+1得到
            public NET_DVR_SPECIAL_FINDINFO_UNION uSpecialFindInfo ;   //专有查询条件
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;    //保留
        }

        //事件搜索条件
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SEARCH_EVENT_PARAM_V40
        {
            public ushort wMajorType;            //0-移动侦测，1-报警输入, 2-智能事件 5-pos录像 7-门禁事件
            public ushort wMinorType;            //搜索次类型- 根据主类型变化，0xffff表示全部
            public NET_DVR_TIME struStartTime;    //搜索的开始时间，停止时间: 同时为(0, 0) 表示从最早的时间开始，到最后，最前面的4000个事件
            public NET_DVR_TIME struEndTime;    //
            public byte byLockType;        // 0xff-全部，0-未锁，1-锁定
            public byte byQuickSearch;        // 是否启用快速查询，0-不启用，1-启用（快速查询不会返回文件大小，仅对设备数据库进行查询，避免频繁唤醒硬盘）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 130, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;// 保留
            public UNION_EVENT_PARAM uSeniorParam;

            public void Init()
            {
                byRes = new byte[130];
                uSeniorParam.Init();
            }
        }

        public const int SEARCH_EVENT_INFO_LEN_V40 = 800; 

        [StructLayout(LayoutKind.Explicit)]
        public struct UNION_EVENT_PARAM
        {
            [FieldOffset(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SEARCH_EVENT_INFO_LEN_V40, ArraySubType = UnmanagedType.I1)]
            public byte[] byLen;
            public void Init()
            {
                byLen = new byte[SEARCH_EVENT_INFO_LEN_V40];
            }
         }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct struMotionParam
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.U2)]
            public ushort[] wMotDetChanNo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 672, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public void Init()
            {
                wMotDetChanNo = new ushort[MAX_CHANNUM_V30];
                byRes = new byte[672];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct struStreamIDParam
        {
            public NET_DVR_STREAM_INFO struIDInfo;
            public uint dwCmdType;
            public byte byBackupVolumeNum;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byArchiveLabel;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 656, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public void Init()
            {
                byRes1 = new byte[3];
                byArchiveLabel = new byte[64];
                byRes = new byte[656];
                struIDInfo.Init();
            }
        }

        //查找返回结果
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SEARCH_EVENT_RET_V40
        {
            public ushort wMajorType;            //主类型
            public ushort wMinorType;            //次类型
            public NET_DVR_TIME struStartTime;    //事件开始的时间
            public NET_DVR_TIME struEndTime;   //事件停止的时间，脉冲事件时和开始时间一样
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U2)]
            public ushort[] wChan;    //触发的通道号，0xffff表示后续无效
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 36, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public UNION_EVENT_RET uSeniorRet;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct UNION_EVENT_RET
        {
            [FieldOffset(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 800, ArraySubType = UnmanagedType.I1)]
            public byte[] byLen;                 
         }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct struMotionRet
        {
            public uint dwMotDetNo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 796, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int NET_SDK_MAX_TAPE_INDEX_LEN = 32; //磁带编号最大长度
        public const int NET_SDK_MAX_FILE_LEN = 256;      //文件名最大长度

        //流id录像查询结果
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct struStreamIDRet
        {
            public uint dwRecordType;    //录像类型 0-定时录像 1-移动侦测 2-报警录像 3-报警|移动侦测 4-报警&移动侦测 5-命令触发 6-手动录像 7-震动报警 8-环境触发 9-智能报警 10-回传录像
            public uint dwRecordLength;    //录像大小
            public byte byLockFlag;    // 锁定标志 0：没锁定 1：锁定
            public byte byDrawFrameType;    // 0：非抽帧录像 1：抽帧录像
            public byte byPosition;// 文件所在存储位置：0-阵列上，1-带库机位上，可以直接下载，2-磁带库内，需要把磁盘切换到机位上，3-不在磁带库中，需要把磁盘插到磁带库中
            public byte byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byFileName;     //文件名
            public uint dwFileIndex;            // 存档卷上的文件索引
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NET_SDK_MAX_TAPE_INDEX_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byTapeIndex;  //文件所在磁带编号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NET_SDK_MAX_FILE_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byFileNameEx; //文件名扩展
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 464, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AES_KEY_INFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] sAESKey;  /*码流加密密钥*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  /*保留字节*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POE_CFG
        {
            public NET_DVR_IPADDR struIP;     //IP地址
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //保留
        }

        public const int MAX_PRO_PATH = 256; //最大协议路径长度

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CUSTOM_PROTOCAL
        {
            public uint dwSize;              //结构体大小
            public uint dwEnabled;           //是否启用该协议0 不启用 1 启用
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = DESC_LEN)]
            public string sProtocalName;   //自定义协议名称, 16位
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;          //保留,用于协议名称扩展
            public uint dwEnableSubStream;   //子码流是否启用0 不启用 1 启用	
            public byte byMainProType;        //主码流协议类型 1 RTSP
            public byte byMainTransType;		//主码流传输类型 0：Auto 1：udp 2：rtp over rtsp
            public ushort wMainPort;           //主码流端口	
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_PRO_PATH)]
            public string sMainPath;  //主码流路径	
            public byte bySubProType;         //子码流协议类型 1 RTSP
            public byte bySubTransType;		//子码流传输类型 0：Auto 1：udp 2：rtp over rtsp
            public ushort wSubPort;   //子码流端口
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_PRO_PATH)]
            public string sSubPath;   //子码流路径 	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 200, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;          //保留
        }
     
        //预览V40接口
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PREVIEWINFO
        {
            public Int32 lChannel;//通道号
            public uint dwStreamType;	// 码流类型，0-主码流，1-子码流，2-码流3，3-码流4 等以此类推
            public uint dwLinkMode;// 0：TCP方式,1：UDP方式,2：多播方式,3 - RTP方式，4-RTP/RTSP,5-RSTP/HTTP 
            public IntPtr hPlayWnd;//播放窗口的句柄,为NULL表示不播放图象
            public bool bBlocked;  //0-非阻塞取流, 1-阻塞取流, 如果阻塞SDK内部connect失败将会有5s的超时才能够返回,不适合于轮询取流操作.
            public bool bPassbackRecord; //0-不启用录像回传,1启用录像回传
            public byte byPreviewMode;//预览模式，0-正常预览，1-延迟预览
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = STREAM_ID_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byStreamID;//流ID，lChannel为0xffffffff时启用此参数
            public byte byProtoType; //应用层取流协议，0-私有协议，1-RTSP协议
            public byte byRes1;
            public byte byVideoCodingType; //码流数据编解码类型 0-通用编码数据 1-热成像探测器产生的原始数据（温度数据的加密信息，通过去加密运算，将原始数据算出真实的温度值）
            public uint dwDisplayBufNum; //播放库播放缓冲区最大缓冲帧数，范围1-50，置0时默认为1 
            public byte byNPQMode;	//NPQ是直连模式，还是过流媒体 0-直连 1-过流媒体
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 215, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        ///抓拍机
        ///
        public const int MAX_OVERLAP_ITEM_NUM = 50;       //最大字符叠加种数
        public const int NET_ITS_GET_OVERLAP_CFG = 5072;//获取字符叠加参数配置（相机或ITS终端）
        public const int NET_ITS_SET_OVERLAP_CFG = 5073;//设置字符叠加参数配置（相机或ITS终端）
        public const int NET_ITS_SET_LAMP_EXTERNAL_CFG = 5095;  //设置外控配置参数

        //字符叠加配置条件参数结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_OVERLAPCFG_COND
        {
            public uint dwSize;
            public uint dwChannel;//通道号 
            public uint dwConfigMode;//配置模式：0- 终端，1- 前端(直连前端或终端接前端)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//保留
        }

        //单条字符叠加信息结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_OVERLAP_SINGLE_ITEM_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//保留
            public byte byItemType;//类型
            public byte byChangeLineNum;//叠加项后的换行数，取值范围：[0,10]，默认：0 
            public byte bySpaceNum;//叠加项后的空格数，取值范围：[0-255]，默认：0
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//保留
        }

        //字符串参数配置结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_OVERLAP_ITEM_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_OVERLAP_ITEM_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_ITS_OVERLAP_SINGLE_ITEM_PARAM[] struSingleItem;//字符串内容信息
            public uint dwLinePercent;
            public uint dwItemsStlye;
            public ushort wStartPosTop;
            public ushort wStartPosLeft;
            public ushort wCharStyle;
            public ushort wCharSize;
            public ushort wCharInterval;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//保留
            public uint dwForeClorRGB;//前景色的RGB值，bit0~bit7: B，bit8~bit15: G，bit16~bit23: R，默认：x00FFFFFF-白
            public uint dwBackClorRGB;//背景色的RGB值，只对图片外叠加有效，bit0~bit7: B，bit8~bit15: G，bit16~bit23: R，默认：x00000000-黑 
            public byte byColorAdapt;//颜色是否自适应：0-否，1-是
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 31, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//保留
        }

        //字符叠加内容信息结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_OVERLAP_INFO_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] bySite;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRoadNum;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byInstrumentNum;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byDirection;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byDirectionDesc;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byLaneDes;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//这里保留音频的压缩参数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
            public byte[] byMonitoringSite1;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byMonitoringSite2;//这里保留音频的压缩参数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//这里保留音频的压缩参数 
        }

        //字符叠加配置条件参数结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_OVERLAP_CFG
        {
            public uint dwSize;
            public byte byEnable;//是否启用：0- 不启用，1- 启用
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//这里保留音频的压缩参数
            public NET_ITS_OVERLAP_ITEM_PARAM struOverLapItem;//字符串参数
            public NET_ITS_OVERLAP_INFO_PARAM struOverLapInfo;//字符串内容信息
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//这里保留音频的压缩参数 
        }

        //报警布防参数结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SETUPALARM_PARAM
        {
            public uint dwSize;
            public byte byLevel;//布防优先级：0- 一等级（高），1- 二等级（中），2- 三等级（低，保留）
            public byte byAlarmInfoType;//上传报警信息类型（智能交通摄像机支持）：0- 老报警信息（NET_DVR_PLATE_RESULT），1- 新报警信息(NET_ITS_PLATE_RESULT) 
            public byte byRetAlarmTypeV40;
            public byte byRetDevInfoVersion;
            public byte byRetVQDAlarmType;
            public byte byFaceAlarmDetection;
            public byte bySupport;
            public byte byBrokenNetHttp;
            public ushort wTaskNo;
            public byte byDeployType;    //布防类型：0-客户端布防，1-实时布防
            public byte bySubScription;	//订阅，按位表示，未开启订阅不上报  //占位 //Bit7-移动侦测人车分类是否传图；0-不传图(V30上报)，1-传图(V40上报)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byAlarmTypeURL;
            //bit0-表示人脸抓拍报警上传（INTER_FACESNAP_RESULT）；0-表示二进制传输，1-表示URL传输（设备支持的情况下，设备支持能力根据具体报警能力集判断,同时设备需要支持URL的相关服务，当前是”云存储“）
            //bit1-表示EVENT_JSON中图片数据长传类型；0-表示二进制传输，1-表示URL传输（设备支持的情况下，设备支持能力根据具体报警能力集判断）
            //bit2 - 人脸比对(报警类型为COMM_SNAP_MATCH_ALARM)中图片数据上传类型：0 - 二进制传输，1 - URL传输
            //bit3 - 异常行为识别(报警类型为COMM_ALARM_RULE)中图片数据上传类型：0 - 二进制传输，1 - URL传输，本字段设备是否支持，对应软硬件能力集中<isSupportBehaviorUploadByCloudStorageURL>节点是否返回且为true
            public byte byCustomCtrl;//Bit0- 表示支持副驾驶人脸子图上传: 0-不上传,1-上传
        }

        //道闸控制参数
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_BARRIERGATE_CFG
        {
            public uint dwSize;
            public uint dwChannel;//通道号
            public byte byLaneNo; //道闸号（0-表示无效值(设备需要做有效值判断),1-道闸1）
            public byte byBarrierGateCtrl;//0-关闭道闸,1-开启道闸,2-停止道闸 3-锁定道闸,4~解锁道闸
            public byte byEntranceNo;//出入口编号 [1,8]
            public byte byUnlock;//启用解锁使能，0~为不启用，1~启用
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int MAX_RELAY_NUM = 12;
        public const int MAX_IOIN_NUM = 8;
        public const int MAX_VEHICLE_TYPE_NUM = 8;

        public const int NET_DVR_GET_ENTRANCE_PARAMCFG = 3126; //获取出入口控制参数
        public const int NET_DVR_SET_ENTRANCE_PARAMCFG = 3127; //设置出入口控制参数

        //出入口控制条件
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_BARRIERGATE_COND
        {
            public byte byLaneNo;//车道号：0- 表示无效值(设备需要做有效值判断)，1- 车道1
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //继电器关联配置
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_RELAY_PARAM
        {
            public byte byAccessDevInfo;//0-不接入设备，1-开道闸、2-关道闸、3-停道闸、4-报警信号、5-常亮灯
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //车辆信息管控参数
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_VEHICLE_CONTROL
        {
            public byte byGateOperateType;//操作类型：0- 无操作，1- 开道闸
            public byte byRes1;
            public ushort wAlarmOperateType; //报警处理类型：0- 无操作，bit0- 继电器输出报警，bit1- 布防上传报警，bit3- 告警主机上传，值：0-表示关，1-表示开，可复选
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //出入口控制参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ENTRANCE_CFG
        {
            public uint dwSize;
            public byte byEnable;
            public byte byBarrierGateCtrlMode;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//保留
            public uint dwRelateTriggerMode;
            public uint dwMatchContent;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RELAY_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_RELAY_PARAM[] struRelayRelateInfo;//继电器关联配置信息
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IOIN_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byGateSingleIO;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VEHICLE_TYPE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_VEHICLE_CONTROL[] struVehicleCtrl;//车辆信息管控
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;//保留
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_GATE_VEHICLE
        {
            public uint dwSize;
            public uint dwMatchNo;
            public byte byGroupNum;
            public byte byPicNo;
            public byte bySecondCam;

            public byte byRes;
            public ushort wLaneid;
            public byte byCamLaneId;
            public byte byRes1;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] byAlarmReason;

            public ushort wBackList;
            public ushort wSpeedLimit;
            public uint dwChanIndex;


            public NET_DVR_PLATE_INFO struPlateInfo;

            public NET_DVR_VEHICLE_INFO struVehicleInfo;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public byte[] byMonitoringSiteID;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public byte[] byDeviceID;


            public byte byDir;
            public byte byDetectType;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] byRes2;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public byte[] byCardNo;

            public uint dwPicNum;

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.Struct)]
            public NET_ITS_PICTURE_INFO[] struPicInfo;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] bySwipeTime;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 224)]
            public byte[] byRes3;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_PICTURE_INFO
        {
            public uint dwDataLen;
            public byte byType;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] byRes1;
            public uint dwRedLightTime;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] byAbsTime;
            public NET_VCA_RECT struPlateRect;
            public NET_VCA_RECT struPlateRecgRect;
            public IntPtr pBuffer;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public byte[] byRes2;
        }  

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_PLATE_RESULT
        {
            public uint dwSize;        //结构长度
            public uint dwMatchNo;        //匹配序号,由(车辆序号,数据类型,车道号)组成匹配码
            public byte byGroupNum;    //图片组数量（一辆过车相机多次抓拍的数量，代表一组图片的总数，用于延时匹配数据）
            public byte byPicNo;        //连拍的图片序号（接收到图片组数量后，表示接收完成;接收超时不足图片组数量时，根据需要保留或删除）
            public byte bySecondCam;    //是否第二相机抓拍（如远近景抓拍的远景相机，或前后抓拍的后相机，特殊项目中会用到）
            public byte byFeaturePicNo; //闯红灯电警，取第几张图作为特写图,0xff-表示不取
            public byte byDriveChan;        //触发车道号
            public byte byVehicleType;     //车辆类型，参考VTR_RESULT
            public byte byDetSceneID;//检测场景号[1,4], IPC默认是0
            //车辆属性，按位表示，0- 无附加属性(普通车)，bit1- 黄标车(类似年检的标志)，bit2- 危险品车辆，值：0- 否，1- 是
            //该节点已不再使用,使用下面的byYellowLabelCar和byDangerousVehicles判断是否黄标车和危险品车
            public byte byVehicleAttribute;
            public ushort wIllegalType;       //违章类型采用国标定义
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byIllegalSubType;   //违章子类型
            public byte byPostPicNo;    //违章时取第几张图片作为卡口图,0xff-表示不取
            //通道号(有效，报警通道号和所在设备上传报警通道号一致，在后端和所接入的 通道号一致)
            public byte byChanIndex;
            public ushort wSpeedLimit;        //限速上限（超速时有效）
            public byte byChanIndexEx;      //byChanIndexEx*256+byChanIndex表示真实通道号。
            public byte byRes2;
            public NET_DVR_PLATE_INFO struPlateInfo;     //车牌信息结构
            public NET_DVR_VEHICLE_INFO struVehicleInfo;    //车辆信息
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 48, ArraySubType = UnmanagedType.I1)]
            public byte[] byMonitoringSiteID;        //监测点编号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 48, ArraySubType = UnmanagedType.I1)]
            public byte[] byDeviceID;                //设备编号
            public byte byDir;            //监测方向，1-上行（反向），2-下行(正向)，3-双向，4-由东向西，5-由南向北,6-由西向东，7-由北向南，8-其它
            public byte byDetectType;    //检测方式,1-地感触发，2-视频触发，3-多帧识别，4-雷达触发
            //关联车道方向类型，参考ITC_RELA_LANE_DIRECTION_TYPE
            //该参数为车道方向参数，与关联车道号对应，确保车道唯一性。
            public byte byRelaLaneDirectionType;
            public byte byCarDirectionType; //车辆具体行驶的方向，0表示从上往下，1表示从下往上（根据实际车辆的行驶方向来的区分）
            //当wIllegalType参数为空时，使用该参数。若wIllegalType参数为有值时，以wIllegalType参数为准，该参数无效。
            public uint dwCustomIllegalType; //违章类型定义(用户自定义)
            /*为0~数字格式时，为老的违章类型，wIllegalType、dwCustomIllegalType参数生效，赋值国标违法代码。
             * 为1~字符格式时，pIllegalInfoBuf参数生效。老的违章类型，wIllegalType、dwCustomIllegalType参数依然赋值国标违法代码*/
            public IntPtr pIllegalInfoBuf;    //违法代码字符信息结构体指针；指向NET_ITS_ILLEGAL_INFO 
            public byte byIllegalFromatType; //违章信息格式类型； 0~数字格式， 1~字符格式
            public byte byPendant;// 0-表示未知,1-车窗有悬挂物，2-车窗无悬挂物
            public byte byDataAnalysis;            //0-数据未分析, 1-数据已分析
            public byte byYellowLabelCar;        //0-表示未知, 1-非黄标车,2-黄标车
            public byte byDangerousVehicles;    //0-表示未知, 1-非危险品车,2-危险品车
            //以下字段包含Pilot字符均为主驾驶，含Copilot字符均为副驾驶
            public byte byPilotSafebelt;//0-表示未知,1-系安全带,2-不系安全带
            public byte byCopilotSafebelt;//0-表示未知,1-系安全带,2-不系安全带
            public byte byPilotSunVisor;//0-表示未知,1-不打开遮阳板,2-打开遮阳板
            public byte byCopilotSunVisor;//0-表示未知, 1-不打开遮阳板,2-打开遮阳板
            public byte byPilotCall;// 0-表示未知, 1-不打电话,2-打电话
			//0-开闸，1-未开闸 (专用于历史数据中相机根据名单匹配后，是否开闸成功的标志)；当byAlarmDataType为0-实时数据时 0-未开闸 1-开闸
            public byte byBarrierGateCtrlType;
            public byte byAlarmDataType;//0-实时数据，1-历史数据
            public NET_DVR_TIME_V30 struSnapFirstPicTime;//端点时间(ms)（抓拍第一张图片的时间）
            public uint dwIllegalTime;//违法持续时间（ms） = 抓拍最后一张图片的时间 - 抓拍第一张图片的时间
            public uint dwPicNum;        //图片数量（与picGroupNum不同，代表本条信息附带的图片数量，图片信息由struVehicleInfoEx定义    
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.Struct)]
            public NET_ITS_PICTURE_INFO[] struPicInfo;         //图片信息,单张回调，最多6张图，由序号区分
        }     
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_PARK_VEHICLE
        {
            public uint dwSize;
            public byte byGroupNum;      
            public byte byPicNo;      
            public byte byLocationNum;    
            public byte byParkError;    
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_PARKNO_LEN)]
            public string byParkingNo;    
            public byte byLocationStatus;    
            public byte bylogicalLaneNum;    
            public ushort wUpLoadType;     
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;        
            public uint dwChanIndex;  
            public NET_DVR_PLATE_INFO      struPlateInfo;
            public NET_DVR_VEHICLE_INFO    struVehicleInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ID_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMonitoringSiteID;  
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ID_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDeviceID;  
            public uint dwPicNum;  
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.Struct)]
            public NET_ITS_PICTURE_INFO[] struPicInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;     
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct UNION_GATE_INFO
        {
            public UNION_GATE_VEHICLE struVehicleInfo; //当struAlarmType为(0x1车辆非法侵入报警)
        }
        
         [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct UNION_GATE_VEHICLE
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LICENSE_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sLicense;//车牌号码
            /*车辆类型0-保留 1-固定车，2-临时车，3-预订车，4-联检车，5-授权车*/
            public byte byVehicleType;
             [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 111, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_GATE_ALARMINFO
        {
            public uint dwSize;
    	//0x1车辆非法侵入报警
    	//0x2道闸超时未关报警
    	//0x3车辆压线圈超时报警
    	//0x4发卡报警（无卡）
    	//0x5发卡报警（少卡）
    	//0x6发卡报警（发卡异常）
            public byte byAlarmType;
            public byte byExternalDevType;//外接设备类型(EXTERNAL_DEVICES_TYPE)
            public byte byExternalDevStatus;//外接设备类型(EXTERNAL_DEVICES_STATUS)
            public byte byRes;
            public NET_DVR_TIME_V30 struAlarmTime;//报警时间
            public UNION_GATE_INFO uAlarmInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //预留
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DIAGNOSIS_UPLOAD
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = STREAM_ID_LEN)]
            public string sStreamID;	///< 流ID，长度小于32个字节
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string sMonitorIP;  ///< 监控点ip
            public uint dwChanIndex;  ///< 监控点通道号  
            public uint dwWidth;  ///< 图像宽度
            public uint dwHeight;  ///< 图像高度
            public NET_DVR_TIME struCheckTime;  ///< 检测时间(合并日期和时间字段)，格式：2012-08-06 13:00:00
            public byte byResult;  ///0-未检测 1-正常 2-异常 3-登录失败 4-取流异常
            public byte bySignalResult; ///< 视频丢失检测结果 0-未检测 1-正常 2-异常
            public byte byBlurResult;  ///< 图像模糊检测结果，0-未检测 1-正常 2-异常
            public byte byLumaResult;  ///< 图像过亮检测结果，0-未检测 1-正常 2-异常
            public byte byChromaResult;  ///< 偏色检测结果，0-未检测 1-正常 2-异常
            public byte bySnowResult;  ///< 噪声干扰检测结果，0-未检测 1-正常 2-异常
            public byte byStreakResult;  ///< 条纹干扰检测结果，0-未检测 1-正常 2-异常
            public byte byFreezeResult;  ///< 画面冻结检测结果，0-未检测 1-正常 2-异常
            public byte byPTZResult;  ///< 云台检测结果，0-未检测 1-正常 2-异常
            public byte byContrastResult;     //对比度异常检测结果，0-未检测，1-正常，2-异常
            public byte byMonoResult;         //黑白图像检测结果，0-未检测，1-正常，2-异常
            public byte byShakeResult;        //视频抖动检测结果，0-未检测，1-正常，2-异常
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string sSNapShotURL;	///<图片URL地址
            public byte byFlashResult;        //视频剧变检测结果，0-未检测，1-正常，2-异常
            public byte byCoverResult;        //视频遮挡检测结果，0-未检测，1-正常，2-异常
            public byte bySceneResult;        //场景变更检测结果，0-未检测，1-正常，2-异常
            public byte byDarkResult;         //图像过暗检测结果，0-未检测，1-正常，2-异常
            public byte byStreamType;		//码流类型，0-无效，1-未知，2-国标类型，3-非国标类型
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 59, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        public const int CID_CODE_LEN = 4;
        public const int ACCOUNTNUM_LEN = 6;
        public const int ACCOUNTNUM_LEN_32 = 32;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CID_ALARM
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CID_CODE_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sCIDCode;    //CID事件号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sCIDDescribe;    //CID事件名
            public NET_DVR_TIME_EX struTriggerTime;            //触发报警的时间点
            public NET_DVR_TIME_EX struUploadTime;                //上传报警的时间点
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = ACCOUNTNUM_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sCenterAccount;    //中心帐号
            public byte byReportType;                    //见定义NET_DVR_ALARMHOST_REPORT_TYPE
            public byte byUserType;                        //用户类型，0-网络用户 1-键盘用户,2-手机用户,3-系统用户
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;        //网络用户用户名
            public ushort wKeyUserNo;                        //键盘用户号    0xFFFF表示无效
            public byte byKeypadNo;                        //键盘号        0xFF表示无效
            public byte bySubSysNo;                        //子系统号        0xFF表示无效
            public ushort wDefenceNo;                        //防区号        0xFFFF表示无效
            public byte byVideoChanNo;                    //视频通道号    0xFF表示无效
            public byte byDiskNo;                        //硬盘号        0xFF表示无效
            public ushort wModuleAddr;                    //模块地址        0xFFFF表示无效
            public byte byCenterType;                    //0-无效, 1-中心账号(长度6),2-扩展的中心账号(长度9)
            public byte byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = ACCOUNTNUM_LEN_32, ArraySubType = UnmanagedType.I1)]
            public byte[] sCenterAccountV40;    //中心账号V40,使用此字段时sCenterAccount无效
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 28, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_PTZ_INFO
        {
            public float fPan;
            public float fTilt;
            public float fZoom;
            public uint dwFocus;// 聚焦参数，聚焦范围：归一化0-100000
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //火点检测报警
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FIREDETECTION_ALARM
        {
            public uint dwSize; //结构大小
            public uint dwRelativeTime; //相对时标
            public uint dwAbsTime; //绝对时标
            public NET_VCA_DEV_INFO struDevInfo;   //前端设备信息
            public ushort wPanPos;
            public ushort wTiltPos;
            public ushort wZoomPos;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwPicDataLen;//报警抓拍图片长度
            public IntPtr pBuffer;    //数据指针
            public NET_VCA_RECT struRect;//火点框 
            public NET_VCA_POINT struPoint;//火点框内最高温度点坐标
            public ushort wFireMaxTemperature;//火点最高温度[300℃~4000℃]
            public ushort wTargetDistance;//目标距离[100m ~ 10000m]
            public byte byStrategyType;//策略类型；0~任意报警，1~协同报警，2~多系统报警，3~指定火点报警，4~指定烟雾报警
            public byte byAlarmSubType;//报警子类型。0~火点检测报警，1~烟雾检测报警，2~烟火报警
            /*是否启用PTZ坐标扩展，
            0~不启用，PTZ坐标值以wPanPos、wTiltPos、wZoomPos为准。
            1~启用，PTZ坐标值以struPtzPosEx为准。但是新老PTZ都需返回。struPtzPosEx的值需转化为wPanPos、wTiltPos、wZoomPos值。
            */
            public byte byPTZPosExEnable;
            public byte byRes2;
            public NET_PTZ_INFO struPtzPosEx;// ptz坐标扩展(支持高精度PTZ值，精确到小数点后三位)
            public uint dwVisiblePicLen;//可见光图片长度
            public IntPtr pVisiblePicBuf;    //可见光图片数据指针
            // pSmokeBuf参数当byAlarmSubType报警子类型为1（烟雾检测报警）、2（烟火报警）时生效。
            public IntPtr pSmokeBuf;    //烟雾检测报警数据指针，指向一个NET_DVR_SMOKEDETECTION_ALARM结构体
            public ushort wDevInfoIvmsChannelEx;     //与NET_VCA_DEV_INFO里的byIvmsChannel含义相同，能表示更大的值。老客户端用byIvmsChannel能继续兼容，但是最大到255。新客户端版本请使用wDevInfoIvmsChannelEx。
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 58, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ACS_EVENT_INFO
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = ACS_CARD_NO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byCardNo; //卡号，为0无效
            public byte byCardType; //卡类型，1-普通卡，3-禁止名单卡，4-巡更卡，5-胁迫卡，6-超级卡，7-来宾卡，为0无效
            public byte byAllowListNo; //允许名单单号,1-8，为0无效
            public byte byReportChannel; //报告上传通道，1-布防上传，2-中心组1上传，3-中心组2上传，为0无效
            public byte byCardReaderKind; //读卡器属于哪一类，0-无效，1-IC读卡器，2-身份证读卡器，3-二维码读卡器,4-指纹头
            public uint dwCardReaderNo; //读卡器编号，为0无效
            public uint dwDoorNo; //门编号(楼层编号)，为0无效
            public uint dwVerifyNo; //多重卡认证序号，为0无效
            public uint dwAlarmInNo;  //报警输入号，为0无效
            public uint dwAlarmOutNo; //报警输出号，为0无效
            public uint dwCaseSensorNo; //事件触发器编号
            public uint dwRs485No;    //RS485通道号，为0无效
            public uint dwMultiCardGroupNo; //群组编号
            public ushort wAccessChannel;    //人员通道号
            public byte byDeviceNo;    //设备编号，为0无效
            public byte byDistractControlNo;//分控器编号，为0无效
            public uint dwEmployeeNo; //工号，为0无效
            public ushort wLocalControllerID; //就地控制器编号，0-门禁主机，1-64代表就地控制器
            public byte byInternetAccess; //网口ID：（1-上行网口1,2-上行网口2,3-下行网口1）
            public byte byType;     //防区类型，0:即时防区,1-24小时防区,2-延时防区 ,3-内部防区，4-钥匙防区 5-火警防区 6-周界防区 7-24小时无声防区  8-24小时辅助防区，9-24小时震动防区,10-门禁紧急开门防区，11-门禁紧急关门防区 0xff-无
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr; //物理地址，为0无效
            public byte bySwipeCardType;//刷卡类型，0-无效，1-二维码
            public byte byMask;//是否带口罩：0-保留，1-未知，2-不戴口罩，3-戴口罩
            public uint dwSerialNo; //事件流水号，为0无效
            public byte byChannelControllerID; //通道控制器ID，为0无效，1-主通道控制器，2-从通道控制器
            public byte byChannelControllerLampID; //通道控制器灯板ID，为0无效（有效范围1-255）
            public byte byChannelControllerIRAdaptorID; //通道控制器红外转接板ID，为0无效（有效范围1-255）
            public byte byChannelControllerIREmitterID; //通道控制器红外对射ID，为0无效（有效范围1-255）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ACS_EVENT_INFO_EXTEND
        {
            public int dwFrontSerialNo; //事件流水号，为0无效（若该字段为0，平台根据dwSerialNo判断是否丢失事件；若该字段不为0，平台根据该字段和dwSerialNo字段共同判断是否丢失事件）（主要用于解决报警订阅后导致dwSerialNo不连续的情况）
            public byte byUserType; //人员类型：0-无效，1-普通人（主人），2-来宾（访客），3-禁止名单人，4-管理员
            public byte byCurrentVerifyMode; //读卡器当前验证方式：0-无效，1-休眠，2-刷卡+密码，3-刷卡，4-刷卡或密码，5-指纹，6-指纹+密码，7-指纹或刷卡，8-指纹+刷卡，9-指纹+刷卡+密码，10-人脸或指纹或刷卡或密码，11-人脸+指纹，12-人脸+密码，13-人脸+刷卡，14-人脸，15-工号+密码，16-指纹或密码，17-工号+指纹，18-工号+指纹+密码，19-人脸+指纹+刷卡，20-人脸+密码+指纹，21-工号+人脸，22-人脸或人脸+刷卡，23-指纹或人脸，24-刷卡或人脸或密码，25-刷卡或人脸，26-刷卡或人脸或指纹，27-刷卡或指纹或密码
            public byte byCurrentEvent; //是否为实时事件：0-无效，1-是（实时事件），2-否（离线事件）
            public byte byPurePwdVerifyEnable; //设备是否支持纯密码认证， 0-不支持，1-支持
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NET_SDK_EMPLOYEE_NO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byEmployeeNo; //工号（人员ID）（对于设备来说，如果使用了工号（人员ID）字段，byEmployeeNo一定要传递，如果byEmployeeNo可转换为dwEmployeeNo，那么该字段也要传递；对于上层平台或客户端来说，优先解析byEmployeeNo字段，如该字段为空，再考虑解析dwEmployeeNo字段）
            public byte byAttendanceStatus; //考勤状态：0-未定义,1-上班，2-下班，3-开始休息，4-结束休息，5-开始加班，6-结束加班
            public byte byStatusValue; //考勤状态值
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NET_SDK_UUID_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byUUID; //UUID（该字段仅在对接萤石平台过程中才会使用）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NET_DEV_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDeviceName;   //设备序列号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //扩展结构体信息V20
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ACS_EVENT_INFO_EXTEND_V20
        {
            public byte byRemoteCheck; //是否需要远程核验（0-无效，1-不需要（默认），2-需要）
            public byte byThermometryUnit; //测温单位（0-摄氏度（默认），1-华氏度，2-开尔文）
            public byte byIsAbnomalTemperature; //人脸抓拍测温是否温度异常：1-是，0-否
            public byte byRes2;
            public float fCurrTemperature; //人脸温度（精确到小数点后一位）
            public NET_VCA_POINT struRegionCoordinates; //人脸温度坐标
            public ushort dwQRCodeInfoLen; //二维码信息长度，不为0是表示后面带数据
            public ushort dwVisibleLightDataLen; //热成像相机可见光图片长度，不为0是表示后面带数据
            public ushort dwThermalDataLen; //热成像图片长度，不为0是表示后面带数据
            public IntPtr pQRCodeInfo; //二维码信息指针
            public IntPtr pVisibleLightData; //热成像相机可见光图片指针
            public IntPtr pThermalData; //热成像图片指针
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byAttendanceLabel; //考勤自定义名称
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 960, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ACS_ALARM_INFO
        {
            public uint dwSize;
            public uint dwMajor; //报警主类型，参考宏定义
            public uint dwMinor; //报警次类型，参考宏定义
            public NET_DVR_TIME struTime; //时间
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sNetUser;//网络操作的用户名
            public NET_DVR_IPADDR    struRemoteHostAddr ;//远程主机地址
            public NET_DVR_ACS_EVENT_INFO struAcsEventInfo; //详细参数
            public uint dwPicDataLen;   //图片数据大小，不为0是表示后面带数据
            public IntPtr pPicData;
            public ushort wInductiveEventType; //归纳事件类型，0-无效，客户端判断该值为非0值后，报警类型通过归纳事件类型区分，否则通过原有报警主次类型（dwMajor、dwMinor）区分
            public byte byPicTransType;        //图片数据传输方式: 0-二进制；1-url
            public byte byRes1;             //保留字节
            public uint dwIOTChannelNo;    //IOT通道号
            public IntPtr pAcsEventInfoExtend;    //byAcsEventInfoExtend为1时，表示指向一个NET_DVR_ACS_EVENT_INFO_EXTEND结构体
            public byte byAcsEventInfoExtend;    //pAcsEventInfoExtend是否有效：0-无效，1-有效
            public byte byTimeType; //时间类型：0-设备本地时间，1-UTC时间（struTime的时间）
            public byte byRes2;             //保留字节
            public byte byAcsEventInfoExtendV20;    //pAcsEventInfoExtendV20是否有效：0-无效，1-有效
            public IntPtr pAcsEventInfoExtendV20;    //byAcsEventInfoExtendV20为1时，表示指向一个NET_DVR_ACS_EVENT_INFO_EXTEND_V20结构体
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ACS_EVENT_DETAIL
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = ACS_CARD_NO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byCardNo; //卡号（mac地址），为0无效
            public byte byCardType; //卡类型，1-普通卡，3-禁止名单卡，4-巡更卡，5-胁迫卡，6-超级卡，7-来宾卡，8-解除卡，为0无效
            public byte byAllowListNo; //允许名单单号,1-8，为0无效
            public byte byReportChannel; //报告上传通道，1-布防上传，2-中心组1上传，3-中心组2上传，为0无效
            public byte byCardReaderKind; //读卡器属于哪一类，0-无效，1-IC读卡器，2-身份证读卡器，3-二维码读卡器,4-指纹头
            public uint dwCardReaderNo; //读卡器编号，为0无效
            public uint dwDoorNo; //门编号（楼层编号），为0无效
            public uint dwVerifyNo; //多重卡认证序号，为0无效
            public uint dwAlarmInNo;  //报警输入号，为0无效
            public uint dwAlarmOutNo; //报警输出号，为0无效
            public uint dwCaseSensorNo; //事件触发器编号
            public uint dwRs485No;    //RS485通道号，为0无效
            public uint dwMultiCardGroupNo; //群组编号
            public ushort wAccessChannel;    //人员通道号
            public byte byDeviceNo; //设备编号，为0无效（有效范围1-255）
            public byte byDistractControlNo;//分控器编号，为0无效
            public uint dwEmployeeNo; //工号，为0无效
            public ushort wLocalControllerID; //就地控制器编号，0-门禁主机，1-64代表就地控制器
            public byte byInternetAccess; //网口ID：（1-上行网口1,2-上行网口2,3-下行网口1）
            public byte byType;     //防区类型，0:即时防区,1-24小时防区,2-延时防区 ,3-内部防区，4-钥匙防区 5-火警防区 6-周界防区 7-24小时无声防区  8-24小时辅助防区，9-24小时震动防区,10-门禁紧急开门防区，11-门禁紧急关门防区 0xff-无
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr; //物理地址，为0无效
            public byte bySwipeCardType;//刷卡类型，0-无效，1-二维码
            public byte byEventAttribute; //事件属性：0-未定义，1-合法认证，2-其它
            public uint dwSerialNo; //事件流水号，为0无效
            public byte byChannelControllerID; //通道控制器ID，为0无效，1-主通道控制器，2-从通道控制器
            public byte byChannelControllerLampID; //通道控制器灯板ID，为0无效（有效范围1-255）
            public byte byChannelControllerIRAdaptorID; //通道控制器红外转接板ID，为0无效（有效范围1-255）
            public byte byChannelControllerIREmitterID; //通道控制器红外对射ID，为0无效（有效范围1-255）
            public uint dwRecordChannelNum; //录像通道数目
            public IntPtr pRecordChannelData;//录像通道，大小为sizeof(DWORD)* dwRecordChannelNum
            public byte byUserType; //人员类型：0-无效，1-普通人（主人），2-来宾（访客），3-禁止名单人，4-管理员
            public byte byCurrentVerifyMode; //读卡器当前验证方式：0-无效，1-休眠，2-刷卡+密码，3-刷卡，4-刷卡或密码，5-指纹，6-指纹+密码，7-指纹或刷卡，8-指纹+刷卡，9-指纹+刷卡+密码，10-人脸或指纹或刷卡或密码，11-人脸+指纹，12-人脸+密码，
            //13-人脸+刷卡，14-人脸，15-工号+密码，16-指纹或密码，17-工号+指纹，18-工号+指纹+密码，19-人脸+指纹+刷卡，20-人脸+密码+指纹，21-工号+人脸，22-人脸或人脸+刷卡，23-指纹或人脸，24-刷卡或人脸或密码，25-刷卡或人脸，26-刷卡或人脸或指纹，27-刷卡或指纹或密码
            public byte byAttendanceStatus;  //考勤状态：0-未定义,1-上班，2-下班，3-开始休息，4-结束休息，5-开始加班，6-结束加班
            public byte byStatusValue;  //考勤状态值
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NET_SDK_EMPLOYEE_NO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byEmployeeNo; //工号（人员ID）（对于设备来说，如果使用了工号（人员ID）字段，byEmployeeNo一定要传递，如果byEmployeeNo可转换为dwEmployeeNo，那么该字段也要传递；对于上层平台或客户端来说，优先解析byEmployeeNo字段，如该字段为空，再考虑解析dwEmployeeNo字段）
            public byte byRes1; //保留
            public byte byMask; //是否带口罩：0-保留，1-未知，2-不戴口罩，3-戴口罩
            public byte byThermometryUnit; //测温单位（0-摄氏度（默认），1-华氏度，2-开尔文）
            public byte byIsAbnomalTemperature; //人脸抓拍测温是否温度异常：1-是，0-否
            public float fCurrTemperature; //人脸温度（精确到小数点后一位）
            public NET_VCA_POINT struRegionCoordinates; //人脸温度坐标
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 48, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public void init()
            {
                byCardNo = new byte[ACS_CARD_NO_LEN];
                byMACAddr = new byte[MACADDR_LEN];
                byEmployeeNo = new byte[NET_SDK_EMPLOYEE_NO_LEN];
                byRes = new byte[48];
            }
         }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ACS_EVENT_CFG
        {
            public uint dwSize;
            public uint dwMajor; //报警主类型，参考宏定义
            public uint dwMinor; //报警次类型，参考宏定义
            public NET_DVR_TIME struTime; //时间
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sNetUser;//网络操作的用户名
            public NET_DVR_IPADDR struRemoteHostAddr;//远程主机地址
            public NET_DVR_ACS_EVENT_DETAIL struAcsEventInfo; //详细参数
            public uint dwPicDataLen;   //图片数据大小，不为0是表示后面带数据
            public IntPtr pPicData;
            public ushort wInductiveEventType; //归纳事件类型，0-无效，其他值参见2.2章节，客户端判断该值为非0值后，报警类型通过归纳事件类型区分，否则通过原有报警主次类型（dwMajor、dwMinor）区分
            public byte byTimeType; //时间类型：0-设备本地时间（默认），1-UTC时间（struTime的时间）
            public byte byRes1;
            public uint dwQRCodeInfoLen; //二维码信息长度，不为0是表示后面带数据
            public uint dwVisibleLightDataLen; //热成像相机可见光图片长度，不为0是表示后面带数据
            public uint dwThermalDataLen; //热成像图片长度，不为0是表示后面带数据
            public IntPtr pQRCodeInfo; //二维码信息指针
            public IntPtr pVisibleLightData; //热成像相机可见光图片指针
            public IntPtr pThermalData; //热成像图片指针
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 36, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public void init()
            {
                sNetUser = new byte[MAX_NAMELEN];
                struRemoteHostAddr.Init();
                struAcsEventInfo.init();
                byRes = new byte[36];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DATE
        {
            public ushort wYear;        //年
            public byte byMonth;        //月    
            public byte byDay;        //日                        
        }

        //身份证信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ID_CARD_INFO
        {
            public uint dwSize;        //结构长度
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ID_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byName;   //姓名
            public NET_DVR_DATE struBirth; //出生日期
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ID_ADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAddr;  //住址
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ID_NUM_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byIDNum;   //身份证号码
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ID_ISSUING_AUTHORITY_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byIssuingAuthority;  //签发机关
            public NET_DVR_DATE struStartDate;  //有效开始日期
            public NET_DVR_DATE struEndDate;  //有效截止日期
            public byte byTermOfValidity;  //是否长期有效， 0-否，1-是（有效截止日期无效）
            public byte bySex;  //性别，1-男，2-女
            public byte byNation;    
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 101, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //扩展结构体信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ID_CARD_INFO_EXTEND
        {
            public byte byRemoteCheck; //是否需要远程核验（0-无效，1-不需要（默认），2-需要）
            public byte byThermometryUnit; //测温单位（0-摄氏度（默认），1-华氏度，2-开尔文）
            public byte byIsAbnomalTemperature; //人脸抓拍测温是否温度异常：1-是，0-否
            public byte byRes2;
            public float fCurrTemperature; //人脸温度（精确到小数点后一位）
            public NET_VCA_POINT struRegionCoordinates; //人脸温度坐标
            public uint dwQRCodeInfoLen; //二维码信息长度，不为0是表示后面带数据
            public uint dwVisibleLightDataLen; //热成像相机可见光图片长度，不为0是表示后面带数据
            public uint dwThermalDataLen; //热成像图片长度，不为0是表示后面带数据
            public IntPtr pQRCodeInfo; //二维码信息指针
            public IntPtr pVisibleLightData; //热成像相机可见光图片指针
            public IntPtr pThermalData; //热成像图片指针
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 1024, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //身份证信息报警
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ID_CARD_INFO_ALARM
        {
            public uint dwSize;        //结构长度
            public NET_DVR_ID_CARD_INFO struIDCardCfg;//身份证信息
            public uint dwMajor; //报警主类型，参考宏定义
            public uint dwMinor; //报警次类型，参考宏定义
            public NET_DVR_TIME_V30 struSwipeTime; //时间
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byNetUser;//网络操作的用户名
            public NET_DVR_IPADDR struRemoteHostAddr;//远程主机地址
            public uint dwCardReaderNo; //读卡器编号，为0无效
            public uint dwDoorNo; //门编号，为0无效
            public uint dwPicDataLen;   //图片数据大小，不为0是表示后面带数据
            public IntPtr pPicData;
            public byte byCardType; //卡类型，1-普通卡，3-禁止名单卡，4-巡更卡，5-胁迫卡，6-超级卡，7-来宾卡，8-解除卡，为0无效
            public byte byDeviceNo;                             // 设备编号，为0时无效（有效范围1-255）
            public byte byMask; //是否带口罩：0-保留，1-未知，2-不戴口罩，3-戴口罩
            public byte byCurrentEvent;//是否为实时事件：0-无效，1-是（实时事件），2-否（离线事件）
            public uint dwFingerPrintDataLen;                  // 指纹数据大小，不为0是表示后面带数据
            public IntPtr pFingerPrintData;
            public uint dwCapturePicDataLen;                   // 抓拍图片数据大小，不为0是表示后面带数据
            public IntPtr pCapturePicData;
            public uint dwCertificatePicDataLen;   //证件抓拍图片数据大小，不为0是表示后面带数据
            public IntPtr pCertificatePicData;
            public byte byCardReaderKind; //读卡器属于哪一类，0-无效，1-IC读卡器，2-身份证读卡器，3-二维码读卡器,4-指纹头
            public byte byHelmet;//可选，是否戴安全帽：0-保留，1-未知，2-不戴安全, 3-戴安全帽
            public byte byRes3;
            public byte byIDCardInfoExtend;    //pIDCardInfoExtend是否有效：0-无效，1-有效
            public IntPtr pIDCardInfoExtend;    //byIDCardInfoExtend为1时，表示指向一个NET_DVR_ID_CARD_INFO_EXTEND结构体
            public uint dwSerialNo; //事件流水号，为0无效
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 168, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VALID_PERIOD_CFG
        {
            public byte byEnable; //使能有效期，0-不使能，1使能
            public byte byBeginTimeFlag;      //是否限制起始时间的标志，0-不限制，1-限制
            public byte byEnableTimeFlag;     //是否限制终止时间的标志，0-不限制，1-限制
            public byte byTimeDurationNo;     //有效期索引,从0开始（时间段通过SDK设置给锁，后续在制卡时，只需要传递有效期索引即可，以减少数据量）
            public NET_DVR_TIME_EX struBeginTime; //有效期起始时间
            public NET_DVR_TIME_EX struEndTime; //有效期结束时间
            public byte byTimeType; //时间类型：0-设备本地时间（默认），1-UTC时间（对于struBeginTime，struEndTime字段有效）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 31, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CARD_COND
        {
            public uint dwSize;
            public uint dwCardNum; //card number, 0xffffffff means to get all card information when getting
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void Init()
            {
                byRes = new byte[64];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CARD_RECORD
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = ACS_CARD_NO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byCardNo; //card No
            public byte byCardType;
            public byte byLeaderCard;
            public byte byUserType;
            public byte byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOOR_NUM_256, ArraySubType = UnmanagedType.I1)]
            public byte[] byDoorRight;
            public NET_DVR_VALID_PERIOD_CFG struValid;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_GROUP_NUM_128, ArraySubType = UnmanagedType.I1)]
            public byte[] byBelongGroup;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CARD_PASSWORD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byCardPassword;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOOR_NUM_256, ArraySubType = UnmanagedType.I1)]
            public ushort[] wCardRightPlan;
            public uint dwMaxSwipeTimes;
            public uint dwSwipeTimes;
            public uint dwEmployeeNo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byName;
            //按位表示，0-无权限，1-有权限
            //第0位表示：弱电报警
            //第1位表示：开门提示音
            //第2位表示：限制客卡
            //第3位表示：通道
            //第4位表示：反锁开门
            //第5位表示：巡更功能
            public uint dwCardRight;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void Init()
            {
                byCardNo = new byte[ACS_CARD_NO_LEN];
                byDoorRight = new byte[MAX_DOOR_NUM_256];
                byBelongGroup = new byte[MAX_GROUP_NUM_128];
                byCardPassword = new byte[CARD_PASSWORD_LEN];
                wCardRightPlan = new ushort[MAX_DOOR_NUM_256];
                byName = new byte[NAME_LEN];
                byRes = new byte[256];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CARD_STATUS
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = ACS_CARD_NO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byCardNo; //card No
            public uint dwErrorCode;
            public byte byStatus; //0-fail, 1-success
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void Init()
            {
                byCardNo = new byte[ACS_CARD_NO_LEN];
                byRes = new byte[23];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CARD_SEND_DATA
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = ACS_CARD_NO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byCardNo; //card No
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void Init()
            {
                byCardNo = new byte[ACS_CARD_NO_LEN];
                byRes = new byte[16];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FACE_PARAM_CTRL_ByCard
        {
            public int dwSize;
            public byte byMode;//0 del by card,1 del by card reader
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_FACE_PARAM_BYCARD struProcessMode;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void Init()
            {
                byRes1 = new byte[3];
                byRes = new byte[64];
                struProcessMode = new NET_DVR_FACE_PARAM_BYCARD();
                struProcessMode.Init();
            }
        }

        public const int MAX_FACE_NUM = 2;                       //max face number

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FACE_PARAM_BYCARD
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ACS_CARD_NO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byCardNo;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = MAX_CARD_READER_NUM_512, ArraySubType = UnmanagedType.I1)]
            public byte[] byEnableCardReader;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = MAX_FACE_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byFaceID;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 42, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;

            public void Init()
            {
                byCardNo = new byte[ACS_CARD_NO_LEN];
                byEnableCardReader = new byte[MAX_CARD_READER_NUM_512];
                byFaceID = new byte[MAX_FACE_NUM];
                byRes1 = new byte[42];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FACE_PARAM_CTRL_ByReader
        {
            public int dwSize;
            public byte byMode;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_FACE_PARAM_BYREADER struProcessMode;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void Init()
            {
                byRes1 = new byte[3];
                byRes = new byte[64];
                struProcessMode = new NET_DVR_FACE_PARAM_BYREADER();
                struProcessMode.Init();
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FACE_PARAM_BYREADER
        {
            public int dwCardReaderNo;
            public byte byClearAllCard;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ACS_CARD_NO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byCardNo;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 548, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void Init()
            {
                byRes1 = new byte[3];
                byCardNo = new byte[ACS_CARD_NO_LEN];
                byRes = new byte[548];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FACE_STATUS
        {
            public int dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = ACS_CARD_NO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byCardNo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = ERROR_MSG_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byErrorMsg;//下发错误信息，当byCardReaderRecvStatus为4时，表示已存在人脸对应的卡号
            public int dwReaderNo; //人脸读卡器编号，可用于下发错误返回
            public byte byRecvStatus;  //人脸读卡器状态，按字节表示，0-失败，1-成功，2-重试或人脸质量差，3-内存已满(人脸数据满)，4-已存在该人脸，5-非法人脸ID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 131, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public void init()
            {
                byCardNo = new byte[ACS_CARD_NO_LEN];
                byErrorMsg = new byte[ERROR_MSG_LEN];
                byRes = new byte[131];
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct NET_DVR_FACE_RECORD
        {
            public int dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = ACS_CARD_NO_LEN)]
            public byte[] byCardNo;
            public int dwFaceLen;
            public IntPtr pFaceBuffer;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] byRes;

            public void init()
            {
                byCardNo = new byte[ACS_CARD_NO_LEN];
                byRes = new byte[128];
            }
        }


        [StructLayout(LayoutKind.Sequential)]
        public struct NET_DVR_FACE_COND
        {
            public int dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = ACS_CARD_NO_LEN)]
            public byte[] byCardNo;//人脸关联的卡号（设置时该参数可不设置）
            public int dwFaceNum;// 设置或获取人脸数量，获取时置为0xffffffff表示获取所有人脸信息
            public int dwEnableReaderNo;// 人脸读卡器编号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 124)]
            public byte[] byRes;
            public void init()
            {
                byCardNo = new byte[ACS_CARD_NO_LEN];
                byRes = new byte[124];
            }
        }


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FACE_PARAM_CTRL_CARDNO
        {
            public int dwSize;
            public byte byMode;//删除方式，0-按卡号方式删除，1-按读卡器删除
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_FACE_PARAM_BYCARD struByCard;//按卡号的方式删除,读卡器暂时不写
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public void Init()
            {
                byRes1 = new byte[3];
                byRes = new byte[64];
                struByCard.Init();
            }
        }


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FINGERPRINT_COND
        {
            public int dwSize;
            public int dwFingerprintNum;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = ACS_CARD_NO_LEN)]
            public byte[] byCardNo;
            public int dwEnableReaderNo;
            public byte byFingerPrintID;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 131)]
            public byte[] byRes;

            public void init()
            {
                byCardNo = new byte[ACS_CARD_NO_LEN];
                byRes = new byte[131];
            }
        }


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CARD_CFG_V50
        {
            public uint dwSize;
            public uint dwModifyParamType;
            // 需要修改的卡参数，设置卡参数时有效，按位表示，每位代表一种参数，1为需要修改，0为不修改
            // #define CARD_PARAM_CARD_VALID       0x00000001 //卡是否有效参数
            // #define CARD_PARAM_VALID            0x00000002  //有效期参数
            // #define CARD_PARAM_CARD_TYPE        0x00000004  //卡类型参数
            // #define CARD_PARAM_DOOR_RIGHT       0x00000008  //门权限参数
            // #define CARD_PARAM_LEADER_CARD      0x00000010  //首卡参数
            // #define CARD_PARAM_SWIPE_NUM        0x00000020  //最大刷卡次数参数
            // #define CARD_PARAM_GROUP            0x00000040  //所属群组参数
            // #define CARD_PARAM_PASSWORD         0x00000080  //卡密码参数
            // #define CARD_PARAM_RIGHT_PLAN       0x00000100  //卡权限计划参数
            // #define CARD_PARAM_SWIPED_NUM       0x00000200  //已刷卡次数
            // #define CARD_PARAM_EMPLOYEE_NO      0x00000400  //工号
            // #define CARD_PARAM_NAME             0x00000800  //姓名
            // #define CARD_PARAM_DEPARTMENT_NO    0x00001000  //部门编号
            // #define CARD_SCHEDULE_PLAN_NO       0x00002000  //排班计划编号
            // #define CARD_SCHEDULE_PLAN_TYPE     0x00004000  //排班计划类型
            // #define CARD_ROOM_NUMBER            0x00008000  //房间号
            // #define CARD_SIM_NO                 0x00010000  //SIM卡号（手机号）
            // #define CARD_FLOOR_NUMBER           0x00020000  //楼层号
            // #define CARD_USER_TYPE              0x00040000  //用户类型
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = ACS_CARD_NO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byCardNo; //卡号
            public byte byCardValid; //卡是否有效，0-无效，1-有效（用于删除卡，设置时置为0进行删除，获取时此字段始终为1）
            public byte byCardType; //卡类型，1-普通卡，3-禁止名单卡，4-巡更卡，5-胁迫卡，6-超级卡，7-来宾卡，8-解除卡，9-员工卡，10-应急卡，11-应急管理卡（用于授权临时卡权限，本身不能开门），默认普通卡
            public byte byLeaderCard; //是否为首卡，1-是，0-否
            public byte byUserType; // 0 – 普通用户1 - 管理员用户;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOOR_NUM_256, ArraySubType = UnmanagedType.I1)]
            public byte[] byDoorRight; //门权限(楼层权限、锁权限)，按位表示，1为有权限，0为无权限，从低位到高位表示对门（锁）1-N是否有权限
            public NET_DVR_VALID_PERIOD_CFG struValid; //有效期参数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_GROUP_NUM_128, ArraySubType = UnmanagedType.I1)]
            public byte[] byBelongGroup; //所属群组，按字节表示，1-属于，0-不属于
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CARD_PASSWORD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byCardPassword; //卡密码
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOOR_NUM_256*MAX_CARD_RIGHT_PLAN_NUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wCardRightPlan; //卡权限计划，取值为计划模板编号，同个门（锁）不同计划模板采用权限或的方式处理
            public uint dwMaxSwipeTime; //最大刷卡次数，0为无次数限制（开锁次数）
            public uint dwSwipeTime; //已刷卡次数
            public ushort wRoomNumber;  //房间号
            public ushort wFloorNumber;   //层号
            public uint dwEmployeeNo;   //工号（用户ID）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byName;   //姓名
            public ushort wDepartmentNo;   //部门编号
            public ushort wSchedulePlanNo;   //排班计划编号
            public byte bySchedulePlanType;  //排班计划类型：0-无意义、1-个人、2-部门
            public byte byRightType;  //下发权限类型：0-普通发卡权限、1-二维码权限、2-蓝牙权限（可视对讲设备二维码权限配置项：房间号、卡号（虚拟卡号）、最大刷卡次数（开锁次数）、有效期参数；蓝牙权限：卡号（萤石APP账号）、其他参数配置与普通发卡权限一致）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public uint dwLockID;  //锁ID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LOCK_CODE_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byLockCode;    //锁代码
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOOR_CODE_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRoomCode;  //房间代码
            //按位表示，0-无权限，1-有权限
            //第0位表示：弱电报警
            //第1位表示：开门提示音
            //第2位表示：限制客卡
            //第3位表示：通道
            //第4位表示：反锁开门
            //第5位表示：巡更功能
            public uint dwCardRight;      //卡权限
            public uint dwPlanTemplate;   //计划模板(每天)各时间段是否启用，按位表示，0--不启用，1-启用
            public uint dwCardUserId;    //持卡人ID
            public byte byCardModelType;  //0-空，1- MIFARE S50，2- MIFARE S70，3- FM1208 CPU卡，4- FM1216 CPU卡，5-国密CPU卡，6-身份证，7- NFC
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 51, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] bySIMNum; //SIM卡号（手机号）
        }
        

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CHECK_FACE_PICTURE_COND
        {
            public uint dwSize;
            public uint dwPictureNum; //图片数量
            public byte byCheckTemplate; //0-校验图片是否合法（默认），1-校验图片和建模数据是否匹配
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 127, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_GROUP_COMBINATION_INFO_V50
        {
            public byte byEnable; //是否启用该群组组合
            public byte byMemberNum; //刷卡成员数量
            public byte bySequenceNo; //群组刷卡次序号
            public byte byRes;
            public uint dwGroupNo;  //群组编号,0xffffffff表示远程开门，0xfffffffe表示超级密码
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MULTI_CARD_GROUP_CFG_V50
        {
            public byte byEnable; //是否启用该多重卡组参数，0-不启用，1-启用
            public byte byEnableOfflineVerifyMode; //是否启用主机离线时验证方式（超级密码代替远程开门），1-启用，0-不启用
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwTemplateNo; //启用多重卡功能的计划模板编号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = GROUP_COMBINATION_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_GROUP_COMBINATION_INFO_V50[] struGroupCombination; //群组组合参数
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MULTI_CARD_CFG_V50
        {
            public uint dwSize;
            public byte byEnable; //是否启用多重卡功能，0-不启用，1-启用
            public byte bySwipeIntervalTimeout; //刷卡间隔超时时间，1-255s，默认10s
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NET_SDK_MULTI_CARD_GROUP_NUM_20, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MULTI_CARD_GROUP_CFG_V50[] struGroupCfg; //群组刷卡参数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        public const int NET_SDK_MONITOR_ID_LEN = 64; //监控点ID长度

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ACS_EVENT_COND
        {
            public uint dwSize;
            public uint dwMajor; //报警主类型，参考事件上传宏定义，0-全部
            public uint dwMinor; //报警次类型，参考事件上传宏定义，0-全部
            public NET_DVR_TIME  struStartTime; //开始时间
            public NET_DVR_TIME  struEndTime; //结束时间
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = ACS_CARD_NO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byCardNo; //卡号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byName; //持卡人姓名
            public byte byPicEnable; //是否带图片，0-不带图片，1-带图片
            public byte byTimeType; //时间类型：0-设备本地时间（默认），1-UTC时间（struStartTime和struEndTime的时间）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //保留
            public uint dwBeginSerialNo; //起始流水号（为0时默认全部）
            public uint dwEndSerialNo; //结束流水号（为0时默认全部）
            public uint dwIOTChannelNo; //IOT通道号，0-无效
            public ushort wInductiveEventType; //归纳事件类型，0-无效，其他值参见2.2章节，客户端判断该值为非0值后，报警类型通过归纳事件类型区分，否则通过原有报警主次类型（dwMajor、dwMinor）区分
            public byte bySearchType;      //搜索方式：0-保留，1-按事件源搜索（此时通道号为非视频通道号），2-按监控点ID搜索
            public byte byEventAttribute; //事件属性：0-未定义，1-合法事件，2-其它
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NET_SDK_MONITOR_ID_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] szMonitorID;          //监控点ID（由设备序列号、通道类型、编号组成，例如门禁点：设备序列号+“DOOR”+门编号）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NET_SDK_EMPLOYEE_NO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byEmployeeNo; //工号（人员ID）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 140, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //保留

            public void Init()
            {
                byCardNo = new byte[ACS_CARD_NO_LEN];
                byName = new byte[NAME_LEN];
                byRes2 = new byte[2];
                byEmployeeNo = new byte[NET_SDK_EMPLOYEE_NO_LEN];
                byRes = new byte[140];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LOCAL_GENERAL_CFG
        {
            public byte byExceptionCbDirectly;    //0-通过线程池异常回调，1-直接异常回调给上层
            public byte byNotSplitRecordFile;     //回放和预览中保存到本地录像文件不切片 0-默认切片，1-不切片
            public byte byResumeUpgradeEnable;    //断网续传升级使能，0-关闭（默认），1-开启
            public byte byAlarmJsonPictureSeparate;   //控制JSON透传报警数据和图片是否分离，0-不分离，1-分离（分离后走COMM_ISAPI_ALARM回调返回）
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      //保留
            public Int64 i64FileSize;      //单位：Byte
            public uint dwResumeUpgradeTimeout;       //断网续传重连超时时间，单位毫秒
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 236, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;    //预留
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LOCAL_CHECK_DEV
        {
            public uint dwCheckOnlineTimeout;     //巡检时间间隔，单位ms  最小值为30s，最大值120s。为0时，表示用默认值(120s)
            public uint dwCheckOnlineNetFailMax;  //由于网络原因失败的最大累加次数；超过该值SDK才回调用户异常，为0时，表示使用默认值1
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARM_ISAPI_INFO
        {
            public IntPtr pAlarmData;           // 报警数据
            public uint dwAlarmDataLen;   // 报警数据长度
            public byte byDataType;        // 0-invalid,1-xml,2-json
            public byte byPicturesNumber;  // 图片数量
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public IntPtr pPicPackData;         // 图片变长部分
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }
        public const int MAX_FILE_PATH_LEN = 256;     //文件路径长度
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARM_ISAPI_PICDATA
        {
            public uint dwPicLen;
            public byte byPicType;  //图片格式: 1- jpg
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_FILE_PATH_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] szFilename;
            public IntPtr pPicData;
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EXTERNAL_DEVICE_STATE_UNION
        {
           [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 512, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMHOST_EXTERNAL_DEVICE_STATE
        {
            public uint dwSize;
            public byte byDevType;    //1-UPS，2-开关电源，3-气体检测系统，4-温湿度传感器，5-空调，6-电量表，7-变电器状态, 8-水位传感器、9-扬尘噪声传感器、10-环境采集仪、11-风速传感器状态、12-通用扩展输出模块状态、13-浸水传感器状态、14-太阳能控制器状态、15-SF6报警主机状态、16-称重仪状态、17-气象采集系统状态、18-水质检测仪状态、19-燃气监测系统状态、20-消防主机状态
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_EXTERNAL_DEVICE_STATE_UNION struDevState;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
       }

        //设备区域设置
        public const int REGIONTYPE = 0;//代表区域
        public const int MATRIXTYPE = 11;//矩阵节点
        public const int DEVICETYPE = 2;//代表设备
        public const int CHANNELTYPE = 3;//代表通道
        public const int USERTYPE = 5;//代表用户

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LOG_MATRIX
        {
            public NET_DVR_TIME strLogTime;
            public uint dwMajorType;
            public uint dwMinorType;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPanelUser;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sNetUser;
            public NET_DVR_IPADDR struRemoteHostAddr;
            public uint dwParaType;
            public uint dwChannel;
            public uint dwDiskNumber;
            public uint dwAlarmInPort;
            public uint dwAlarmOutPort;
            public uint dwInfoLen;
            public byte byDevSequence;//槽位号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMacAddr;//MAC地址
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;//序列号
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = LOG_INFO_LEN - SERIALNO_LEN - MACADDR_LEN - 1)]
            public string sInfo;
        }

        //视频综合平台软件
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct tagVEDIOPLATLOG
        {
            public byte bySearchCondition;//搜索条件，0-按槽位号搜索，1-按序列号搜索 2-按MAC地址进行搜索
            public byte byDevSequence;//槽位号，0-79：对应子系统的槽位号；
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;//序列号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMacAddr;//MAC地址
        }

        //参数关键字
        public enum IVS_PARAM_KEY
        {
            OBJECT_DETECT_SENSITIVE = 1,//目标检测灵敏度
            BACKGROUND_UPDATE_RATE = 2,//背景更新速度
            SCENE_CHANGE_RATIO = 3,//场景变化检测最小值
            SUPPRESS_LAMP = 4,//是否抑制车头灯
            MIN_OBJECT_SIZE = 5,//能检测出的最小目标大小
            OBJECT_GENERATE_RATE = 6,//目标生成速度
            MISSING_OBJECT_HOLD = 7,//目标消失后继续跟踪时间
            MAX_MISSING_DISTANCE = 8,//目标消失后继续跟踪距离
            OBJECT_MERGE_SPEED = 9,//多个目标交错时，目标的融合速度
            REPEATED_MOTION_SUPPRESS = 10,//重复运动抑制
            ILLUMINATION_CHANGE = 11,//光影变化抑制开关
            TRACK_OUTPUT_MODE = 12,//轨迹输出模式：0-输出目标的中心，1-输出目标的底部中心
            ENTER_CHANGE_HOLD = 13,//检测区域变化阈值
            RESUME_DEFAULT_PARAM = 255,//恢复默认关键字参数
        }

        //标定参数配置结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LF_CALIBRATION_PARAM
        {
            public byte byPointNum;//有效标定点个数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CALIB_PT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CB_POINT[] struCBPoint;//标定点组
        }

        //LF双摄像机配置结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LF_CFG
        {
            public uint dwSize;//结构长度	
            public byte byEnable;//标定使能
            public byte byFollowChan;// 被控制的从通道
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_LF_CALIBRATION_PARAM struCalParam;//标定点组
        }

        //L/F手动控制结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LF_MANUAL_CTRL_INFO
        {
            public NET_VCA_POINT struCtrlPoint;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //L/F目标跟踪结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LF_TRACK_TARGET_INFO
        {
            public uint dwTargetID;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LF_TRACK_MODE
        {
            public uint dwSize;//结构长度
            public byte byTrackMode;//跟踪模式
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//保留，置0
            [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct uModeParam
            {
                [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
                [FieldOffsetAttribute(0)]
                public uint[] dwULen;
                /*[FieldOffsetAttribute(0)]
                public NET_DVR_LF_MANUAL_CTRL_INFO struManualCtrl;//手动跟踪结构
                [FieldOffsetAttribute(0)]
                public NET_DVR_LF_TRACK_TARGET_INFO struTargetTrack;//目标跟踪结构
                 * */
            }
        }        

        // Long config callback type
        public enum NET_SDK_CALLBACK_TYPE
        {
            NET_SDK_CALLBACK_TYPE_STATUS = 0, //回调状态值
            NET_SDK_CALLBACK_TYPE_PROGRESS,   //回调进度值 
            NET_SDK_CALLBACK_TYPE_DATA        //回调数据内容
        }
        

        // Long config status value
        public enum NET_SDK_CALLBACK_STATUS_NORMAL
        {
            NET_SDK_CALLBACK_STATUS_SUCCESS = 1000,        //成功
            NET_SDK_CALLBACK_STATUS_PROCESSING,            //处理中
            NET_SDK_CALLBACK_STATUS_FAILED,                //失败
            NET_SDK_CALLBACK_STATUS_EXCEPTION,             //异常
            NET_SDK_CALLBACK_STATUS_LANGUAGE_MISMATCH,     //语言不匹配
            NET_SDK_CALLBACK_STATUS_DEV_TYPE_MISMATCH,     //设备类型不匹配
            NET_DVR_CALLBACK_STATUS_SEND_WAIT             //发送等待
        }
        
        //Sensor信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SENSOR_PARAM
        {
            public byte bySensorType;//SensorType:0-CCD,1-CMOS
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 31, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public float  fHorWidth;//水平宽度 精确到小数点后两位 *10000
            public float  fVerWidth;//垂直宽度 精确到小数点后两位 *10000
            public float  fFold;//zoom=1没变时的焦距 精确到小数点后两位 *100
        }
        
        
       //球机位置信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PTZPOS_PARAM{
            public float fPanPos;//水平参数，精确到小数点后1位
            public float fTiltPos;//垂直参数，精确到小数点后1位
            public float fZoomPos;//变倍参数，精确到小数点后1位
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes ;
        }

        //GIS信息上传
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_GIS_UPLOADINFO
        {
            public uint dwSize;//结构体大小
            public uint dwRelativeTime; //相对时标
            public uint dwAbsTime; //绝对时标
            public NET_VCA_DEV_INFO    struDevInfo;//前端设备
            public float fAzimuth;//电子罗盘的方位信息；方位角[0.00°,360.00°)
            public byte byLatitudeType ;//纬度类型，0-北纬，1-南纬
            public byte byLongitudeType ;// 经度类型，0-东度，1-西度
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_LLI_PARAM struLatitude;     /*纬度*/
            public NET_DVR_LLI_PARAM struLongitude;   /*经度*/
            public float   fHorizontalValue;//水平视场角，精确到小数点后面两位
            public float   fVerticalValue;//垂直视场角，精确到小数点后面两位
            public float   fVisibleRadius;//当前可视半径，精确到小数点后面两位
            public float   fMaxViewRadius;//最大可视半径，精确到小数点后面0位（预留处理）
            public NET_DVR_SENSOR_PARAM  struSensorParam;//Sensor信息
            public NET_DVR_PTZPOS_PARAM  struPtzPos; //ptz坐标
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
         }
         
         public const int NET_SDK_MAX_FDID_LEN = 256;

        //导入人脸数据(人脸图片+图片附件信息)到人脸库的条件参数结构体。
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FACELIB_COND
        {
            public uint dwSize;     		// 结构大小
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NET_SDK_MAX_FDID_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] szFDID;
            public byte byConcurrent;//设备并发处理：0- 不开启，1- 开始 
            public byte byCover;//是否覆盖式导入 0-否，1-是
            public byte byCustomFaceLibID;//FDID是否是自定义，0-不是，1-是；
            public byte byPictureSaveMode;//上传原图保存模式，0-保存，1-不保存;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byIdentityKey;//交互操作口令
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//保留
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SEND_PARAM_IN
        {
            public IntPtr pSendData;
            public uint dwSendDataLen;
            public NET_DVR_TIME_V30 struTime;
            public byte byPicType;
            public byte byPicURL;  //图片数据采用URL方式 0-二进制图片数据，1-图片数据走URL方式
            public byte byUploadModeling;
            public byte byRes1;
            public uint dwPicMangeNo;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sPicName;
            public uint dwPicDisplayTime;
            public IntPtr pSendAppendData;
            public uint dwSendAppendDataLen;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 192, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public enum HKUploadType
        {
            IMPORT_DATA_TO_FACELIB = 39,// 导入人脸数据(人脸图片+图片附加信息)到人脸库
        }

        public const int MAX_UPLOADFILE_URL_LEN = 240;

        //导入人脸图片数据到人脸库的结果参数结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_UPLOAD_FILE_RET
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_UPLOADFILE_URL_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUrl;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 260, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//保留
        }
		
		//GPS报警信息结构体
		 [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_GPSALARMINFO
        {
			[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDeviceID;/*设备的ID串*/
			public NET_DVR_TIME_EX struGpsTime;    /*GPS上传的时间*/
			public uint dwLongitude;    /* 经度*/
			public uint dwLatitude;  /* 纬度*/
			public int iTimeZone; /*时区，用分钟数表示，+60代表东1区，+480代表东8区，-60代表西区，-480代表西8区，该字段和GPSTime构成一个完整的时间描述*/ 
			public uint dwDirection; /*车辆方向=实际方向（以度为单位，正北方向为，顺时针方向计算）*100*/
			public ushort wSatellites; /*卫星数量*/
			public ushort wPrecision; /*精度*/
			public uint dwHeight; /*高度:厘米，预留*/
			public uint dwGPSSeq; /*GPS序号，GPS补传时要用到*/
			public ushort wSpeed;//速度，单位，km/h
			/* direction[0]:'E'or'W'(东经/西经), direction[1]:'N'or'S'(北纬/南纬)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] sDirection; 
			public byte byLocateMode;/*定位模式(初值0)，1,自主定位,2,差分3,估算,4,数据无效，65,有效定位，78，无效定位*/  
			[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
        }
		
		//热度图报警上传
		[StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HEATMAP_RESULT
        {
			public uint dwSize;
			public NET_VCA_DEV_INFO struDevInfo;/*设备信息*/
			public NET_DVR_TIME_EX struStartTime;/*开始时间*/
			public NET_DVR_TIME_EX struEndTime;/*结束时间*/
			public uint dwMaxHeatMapValue;//最大热度值
			public uint dwMinHeatMapValue;//最小热度值
			public uint dwTimeHeatMapValue;// (时间热度值)平均热度值
			public ushort wArrayLine;//图片像素点行值 
			public ushort wArrayColumn;//图片像素点列值 （当行列值为0的时候，像素点值内存信息不存在）
			public IntPtr pBuffer;  //热度图片像素点数据信息
			public byte byDetSceneID;//检测场景号[1],球机当前支持1个场景, IPC默认是0
			public byte byBrokenNetHttp;     //断网续传标志位，0-不是重传数据，1-重传数据
			public ushort wDevInfoIvmsChannelEx;     //与NET_VCA_DEV_INFO里的byIvmsChannel含义相同，能表示更大的值。老客户端用byIvmsChannel能继续兼容，但是最大到255。新客户端版本请使用wDevInfoIvmsChannelEx。
			public byte byTimeDiffFlag;      /*时差字段是否有效  0-时差无效， 1-时差有效 */
			public byte cStartTimeDifferenceH;      /*开始时间与UTC的时差（小时），-12 ... +14，+表示东区*/
			public byte cStartTimeDifferenceM;      /*开始时间与UTC的时差（分钟），-30, 30, 45，+表示东区*/
			public byte cStopTimeDifferenceH;        /*结束时间与UTC的时差（小时），-12 ... +14， +表示东区*/
			public byte cStopTimeDifferenceM;       /*结束时间与UTC的时差（分钟），-30, 30, 45，+表示东区*/
			public byte byArrayUnitType; //矩阵单元数据类型（矩阵信息中每个像素点数据的数据类型），1-byte，2-short,4-int
			[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public uint dwTotalTime;//停留时间总和，单位秒，按人员停留时间报警时上传
			[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 112, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}
		
        /********************************接口参数结构(end)*********************************/


        #region 接口函数
        /********************************SDK接口函数声明*********************************/

        /*********************************************************
        Function:	NET_DVR_Init
        Desc:		初始化SDK，调用其他SDK函数的前提。
        Input:	
        Output:	
        Return:	TRUE表示成功，FALSE表示失败。
        **********************************************************/

        /*********************************************************
        Function:	NET_DVR_Cleanup
        Desc:		释放SDK资源，在结束之前最后调用
        Input:	
        Output:	
        Return:	TRUE表示成功，FALSE表示失败
        **********************************************************/




        /*********************************************************
        Function:	EXCEPYIONCALLBACK
        Desc:		(回调函数)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void EXCEPYIONCALLBACK(uint dwType, int lUserID, int lHandle, IntPtr pUser);



        /*********************************************************
        Function:	MESSCALLBACK
        Desc:		(回调函数)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate int MESSCALLBACK(int lCommand, string sDVRIP, string pBuf, uint dwBufLen);


        /*********************************************************
        Function:	MESSCALLBACKEX
        Desc:		(回调函数)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate int MESSCALLBACKEX(int iCommand, int iUserID, string pBuf, uint dwBufLen);


        /*********************************************************
        Function:	MESSCALLBACKNEW
        Desc:		(回调函数)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate int MESSCALLBACKNEW(int lCommand, string sDVRIP, string pBuf, uint dwBufLen, ushort dwLinkDVRPort);


        /*********************************************************
        Function:	MESSAGECALLBACK
        Desc:		(回调函数)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate int MESSAGECALLBACK(int lCommand, System.IntPtr sDVRIP, System.IntPtr pBuf, uint dwBufLen, uint dwUser);



        /*********************************************************
        Function:	MSGCallBack
        Desc:		(回调函数)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void MSGCallBack(int lCommand, ref NET_DVR_ALARMER pAlarmer, IntPtr pAlarmInfo, uint dwBufLen, IntPtr pUser);


        public delegate bool MSGCallBack_V31(int lCommand, ref NET_DVR_ALARMER pAlarmer, IntPtr pAlarmInfo, uint dwBufLen, IntPtr pUser);





















        //预览相关接口

        /*********************************************************
		Function:	REALDATACALLBACK
		Desc:		预览回调
		Input:	lRealHandle 当前的预览句柄 
				dwDataType 数据类型
				pBuffer 存放数据的缓冲区指针 
				dwBufSize 缓冲区大小 
				pUser 用户数据 
		Output:	
		Return:	void
		**********************************************************/
        public delegate void REALDATACALLBACK(Int32 lRealHandle, UInt32 dwDataType, IntPtr pBuffer, UInt32 dwBufSize, IntPtr pUser);

        /*********************************************************
        Function:	NET_DVR_RealPlay_V40
        Desc:		实时预览扩展接口。
        Input:	lUserID [in] NET_DVR_Login()或NET_DVR_Login_V30()的返回值 
                lpPreviewInfo [in] 预览参数 
                fRealDataCallBack_V30 [in] 码流数据回调函数 
                pUser [in] 用户数据 
        Output:	
        Return:	1表示失败，其他值作为NET_DVR_StopRealPlay等函数的句柄参数
        **********************************************************/

       // [DllImport(@".\HCNetSDK.dll")]
       // public static extern int NET_DVR_GetRealPlayerIndex(int lRealHandle);
        /*********************************************************
		Function:	NET_DVR_StopRealPlay
		Desc:		停止预览。
		Input:	lRealHandle [in] 预览句柄，NET_DVR_RealPlay或者NET_DVR_RealPlay_V30的返回值 
		Output:	
		Return:	
		**********************************************************/

        /*********************************************************
        Function:	DRAWFUN
        Desc:		(回调函数)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void DRAWFUN(int lRealHandle, IntPtr hDc, uint dwUser);












        /*********************************************************
        Function:	REALDATACALLBACK
        Desc:		(回调函数)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void SETREALDATACALLBACK(int lRealHandle, uint dwDataType, IntPtr pBuffer, uint dwBufSize, uint dwUser);


        /*********************************************************
        Function:	STDDATACALLBACK
        Desc:		(回调函数)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void STDDATACALLBACK(int lRealHandle, uint dwDataType, ref byte pBuffer, uint dwBufSize, uint dwUser);


		
		
        //动态生成I帧


        //云台控制相关接口
























        //文件查找与回放










        //2007-04-16增加查询结果带卡号的文件查找









        


        /*********************************************************
        Function:	PLAYDATACALLBACK
        Desc:		(回调函数)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void PLAYDATACALLBACK(int lPlayHandle, uint dwDataType, IntPtr pBuffer, uint dwBufSize, uint dwUser);












		
		//图片查找



        //升级





        //远程格式化硬盘




        //报警





        //语音对讲
        /*********************************************************
        Function:	VOICEDATACALLBACK
        Desc:		(回调函数)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void VOICEDATACALLBACK(int lVoiceComHandle, string pRecvDataBuffer, uint dwBufSize, byte byAudioFlag, uint dwUser);


        /*********************************************************
        Function:	VOICEDATACALLBACKV30
        Desc:		(回调函数)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void VOICEDATACALLBACKV30(int lVoiceComHandle, IntPtr pRecvDataBuffer, uint dwBufSize, byte byAudioFlag, System.IntPtr pUser);





        //语音转发



        //语音广播

        /*********************************************************
        Function:	VOICEAUDIOSTART
        Desc:		(回调函数)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void VOICEAUDIOSTART(string pRecvDataBuffer, uint dwBufSize, IntPtr pUser);









        //透明通道设置
        /*********************************************************
        Function:	SERIALDATACALLBACK
        Desc:		(回调函数)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void SERIALDATACALLBACK(int lSerialHandle, string pRecvDataBuffer, uint dwBufSize, uint dwUser);


        //485作为透明通道时，需要指明通道号，因为不同通道号485的设置可以不同(比如波特率)




        //解码 nBitrate = 16000



        //编码



        //远程控制本地显示

        //远程控制设备端手动录像


        //解码卡
















        //获取解码卡序列号此接口无效，改用GetBoardDetail接口获得(2005-12-08支持)

        //日志






        //截止2004年8月5日,共113个接口
        //ATM DVR


        //2005-09-15

        //JPEG抓图到内存

        //2006-02-16






        //获取当前上传的结果信息。




        //2006-08-28 704-640 缩放配置




        //2006-08-28 ATM机端口设置


        //2006-11-10 支持显卡辅助输出






        //解码设备DS-6001D/DS-6001F



        //2005-08-01










        //多路解码器
        //2007-11-30 V211支持以下接口 //11












        //2007-12-22 增加支持接口 //18





        //2009-4-13 新增

















   

        public const int NET_DVR_SHOWLOGO = 1;/*显示LOGO*/
        public const int NET_DVR_HIDELOGO = 2;/*隐藏LOGO*/




        public const int DISP_CMD_ENLARGE_WINDOW = 1;	/*显示通道放大某个窗口*/
        public const int DISP_CMD_RENEW_WINDOW = 2;	/*显示通道窗口还原*/


        //end

        //恢复默认值

        //保存参数

        //重启

        //关闭DVR

        //参数配置 begin












        //获取UPNP端口映射状态

        //视频参数调节


        //配置文件





        //启用日志文件写入接口




        //前面板锁定




        //视频综合平台




        //Win32位定义
        //[DllImport(@".\HCNetSDK.dll")]
        //public static extern bool NET_DVR_EncodeG711Frame(uint iType, ref byte pInBuffer, ref byte pOutBuffer);
       




        //2009-7-22 end  

        //邮件服务测试 9000_1.1



        /*********************************************************
        Function:	NET_DVR_Login_V30
        Desc:		
        Input:	sDVRIP [in] 设备IP地址 
                wServerPort [in] 设备端口号 
                sUserName [in] 登录的用户名 
                sPassword [in] 用户密码 
        Output:	lpDeviceInfo [out] 设备信息 
        Return:	-1表示失败，其他值表示返回的用户ID值
        **********************************************************/

        /*********************************************************
        Function:	NET_DVR_Logout_V30
        Desc:		用户注册设备。
        Input:	lUserID [in] 用户ID号
        Output:	
        Return:	TRUE表示成功，FALSE表示失败
        **********************************************************/







        


        public delegate void RemoteConfigCallback(uint dwType, IntPtr lpBuffer, uint dwBufLen, IntPtr pUserData);

        








        /*********************************************************
		Function:	NET_DVR_GetDeviceAbility
		Desc:		
		Input:	
		Output:	
		Return:	TRUE表示成功，FALSE表示失败。
		**********************************************************/

        //设置/获取参数关键字


        //获取/设置异常行为识别目标叠加接口


        //双摄像机跟踪模式设置接口





        #endregion

        #region 消息事件
        #endregion


        //识别场景
        public enum VCA_RECOGNIZE_SCENE
        {
            VCA_LOW_SPEED_SCENE = 0,//低速通过场景（收费站、小区门口、停车场）
            VCA_HIGH_SPEED_SCENE = 1,//高速通过场景（卡口、高速公路、移动稽查)
            VCA_MOBILE_CAMERA_SCENE = 2,//移动摄像机应用） 
        }

        //识别结果标志
        public enum VCA_RECOGNIZE_RESULT
        {
            VCA_RECOGNIZE_FAILURE = 0,//识别失败
            VCA_IMAGE_RECOGNIZE_SUCCESS,//图像识别成功
            VCA_VIDEO_RECOGNIZE_SUCCESS_OF_BEST_LICENSE,//视频识别更优结果
            VCA_VIDEO_RECOGNIZE_SUCCESS_OF_NEW_LICENSE,//视频识别到新的车牌
            VCA_VIDEO_RECOGNIZE_FINISH_OF_CUR_LICENSE,//视频识别车牌结束
        }
        

        //视频识别触发类型
        public enum VCA_TRIGGER_TYPE
        {
            INTER_TRIGGER = 0,// 模块内部触发识别
            EXTER_TRIGGER = 1,// 外部物理信号触发：线圈、雷达、手动触发信号；
        }

        public const int MAX_CHINESE_CHAR_NUM = 64;    // 最大汉字类别数量
        //车牌可动态修改参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_PLATE_PARAM
        {
            public NET_VCA_RECT struSearchRect;//搜索区域(归一化)
            public NET_VCA_RECT struInvalidateRect;//无效区域，在搜索区域内部 (归一化)
            public ushort wMinPlateWidth;//车牌最小宽度
            public ushort wTriggerDuration;//触发持续帧数
            public byte byTriggerType;//触发模式, VCA_TRIGGER_TYPE
            public byte bySensitivity;//灵敏度
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//保留，置0
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byCharPriority;// 汉字优先级
        }

        /*wMinPlateWidth:该参数默认配置为80像素；该参数的配置对于车牌海康威视车牌识别说明文档 
	    识别有影响，如果设置过大，那么如果场景中出现小车牌就会漏识别；如果场景中车牌宽度普遍较大，可以把该参数设置稍大，便于减少对虚假车牌的处理。在标清情况下建议设置为80， 在高清情况下建议设置为120
        wTriggerDuration － 外部触发信号持续帧数量，其含义是从触发信号开始识别的帧数量。该值在低速场景建议设置为50～100；高速场景建议设置为15～25；移动识别时如果也有外部触发，设置为15～25；具体可以根据现场情况进行配置
        */
        //车牌识别参数子结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_PLATEINFO
        {
            public VCA_RECOGNIZE_SCENE eRecogniseScene;//识别场景(低速和高速)
            public NET_VCA_PLATE_PARAM struModifyParam;//车牌可动态修改参数
        }

        //车牌识别配置参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_PLATECFG
        {
            public uint dwSize;
            public byte byPicProType;//报警时图片处理方式 0-不处理 1-上传
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//保留，设置为0
            public NET_DVR_JPEGPARA struPictureParam;//图片规格结构
            public NET_VCA_PLATEINFO struPlateInfo;//车牌信息
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_2, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//布防时间
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;//处理方式
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;//报警触发的录象通道,为1表示触发该通道
        }

        //车牌识别结果子结构
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_VCA_PLATE_INFO
        {
            public VCA_RECOGNIZE_RESULT eResultFlag;//识别结果标志 
            public VCA_PLATE_TYPE ePlateType;//车牌类型
            public VCA_PLATE_COLOR ePlateColor;//车牌颜色
            public NET_VCA_RECT struPlateRect;//车牌位置
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;//保留，设置为0 
            public uint dwLicenseLen;//车牌长度
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_LICENSE_LEN)]
            public string sLicense;//车牌号码 
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_LICENSE_LEN)]
            public string sBelieve;//各个识别字符的置信度，如检测到车牌"浙A12345", 置信度为10,20,30,40,50,60,70，则表示"浙"字正确的可能性只有10%，"A"字的正确的可能性是20%
        }

        //车牌检测结果
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_PLATE_RESULT
        {
            public uint dwSize;//结构长度
            public uint dwRelativeTime;//相对时标
            public uint dwAbsTime;//绝对时标
            public byte byPlateNum;//车牌个数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PLATE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_PLATE_INFO[] struPlateInfo;//车牌信息结构
            public uint dwPicDataLen;//返回图片的长度 为0表示没有图片，大于0表示该结构后面紧跟图片数据
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes2;//保留，设置为0 图片的高宽
            public System.IntPtr pImage;//指向图片的指针
        }

        //重启智能库

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_LINE_SEGMENT
        {
            public NET_VCA_POINT struStartPoint;//表示高度线时，表示头部点
            public NET_VCA_POINT struEndPoint;//表示高度线时，表示脚部点
            public float fValue;//高度值，单位米
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //标定线链表
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_LINE_SEG_LIST
        {
            public uint dwSize;//结构长度
            public byte bySegNum;//标定线条数
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I1)]
            public byte[] byRes;//保留，置0
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SEGMENT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_LINE_SEGMENT[] struSeg;
        }      

        //2009-8-18 抓拍机
        public const int PLATE_INFO_LEN = 1024;
        public const int PLATE_NUM_LEN = 16;
        public const int FILE_NAME_LEN = 256;

        //liscense plate result
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLATE_RET
        {
            public uint dwSize;//结构长度
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PLATE_NUM_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPlateNum;//车牌号
            public byte byVehicleType;// 车类型
            public byte byTrafficLight;//0-绿灯；1-红灯
            public byte byPlateColor;//车牌颜色
            public byte byDriveChan;//触发车道号
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byTimeInfo;/*时间信息*///plate_172.6.113.64_20090724155526948_197170484 
            //目前是17位，精确到ms:20090724155526948
            public byte byCarSpeed;/*单位km/h*/
            public byte byCarSpeedH;/*cm/s高8位*/
            public byte byCarSpeedL;/*cm/s低8位*/
            public byte byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PLATE_INFO_LEN - 36, ArraySubType = UnmanagedType.I1)]
            public byte[] byInfo;
            public uint dwPicLen;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CCD_CFG
        {
            public uint dwSize;//结构长度
            public byte byBlc;/*背光补偿0-off; 1-on*/
            public byte byBlcMode;/*blc类型0-自定义1-上；2-下；3-左；4-右；5-中；注：此项在blc为 on 时才起效*/
            public byte byAwb;/*自动白平衡0-自动1; 1-自动2; 2-自动控制*/
            public byte byAgc;/*自动增益0-关; 1-低; 2-中; 3-高*/
            public byte byDayNight;/*日夜转换；0 彩色；1黑白；2自动*/
            public byte byMirror;/*镜像0-关;1-左右;2-上下;3-中心*/
            public byte byShutter;/*快门0-自动; 1-1/25; 2-1/50; 3-1/100; 4-1/250;5-1/500; 6-1/1k ;7-1/2k; 8-1/4k; 9-1/10k; 10-1/100k;*/
            public byte byIrCutTime;/*IRCUT切换时间，5, 10, 15, 20, 25*/
            public byte byLensType;/*镜头类型0-电子光圈; 1-自动光圈*/
            public byte byEnVideoTrig;/*视频触发使能：1-支持；0-不支持。视频触发模式下视频快门速度按照byShutter速度，抓拍图片的快门速度按照byCapShutter速度，抓拍完成后会自动调节回视频模式*/
            public byte byCapShutter;/*抓拍时的快门速度，1-1/25; 2-1/50; 3-1/100; 4-1/250;5-1/500; 6-1/1k ;7-1/2k; 8-1/4k; 9-1/10k; 10-1/100k; 11-1/150; 12-1/200*/
            public byte byEnRecognise;/*1-支持识别；0-不支持识别*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct tagCAMERAPARAMCFG
        {
            public uint dwSize;
            public uint dwPowerLineFrequencyMode;/*0-50HZ; 1-60HZ*/
            public uint dwWhiteBalanceMode;/*0手动白平衡; 1自动白平衡1（范围小）; 2 自动白平衡2（范围宽，2200K-15000K）;3自动控制3*/
            public uint dwWhiteBalanceModeRGain;/*手动白平衡时有效，手动白平衡 R增益*/
            public uint dwWhiteBalanceModeBGain;/*手动白平衡时有效，手动白平衡 B增益*/
            public uint dwExposureMode;/*0 手动曝光 1自动曝光*/
            public uint dwExposureSet;/* 0-USERSET, 1-自动x2，2-自动4，3-自动81/25, 4-1/50, 5-1/100, 6-1/250, 7-1/500, 8-1/750, 9-1/1000, 10-1/2000, 11-1/4000,12-1/10,000; 13-1/100,000*/
            public uint dwExposureUserSet;/* 自动自定义曝光时间*/
            public uint dwExposureTarget;/*手动曝光时间 范围（Manumal有效，微秒）*/
            public uint dwIrisMode;/*0 自动光圈 1手动光圈*/
            public uint dwGainLevel;/*增益：0-100*/
            public uint dwBrightnessLevel;/*0-100*/
            public uint dwContrastLevel;/*0-100*/
            public uint dwSharpnessLevel;/*0-100*/
            public uint dwSaturationLevel;/*0-100*/
            public uint dwHueLevel;/*0-100，（保留）*/
            public uint dwGammaCorrectionEnabled;/*0 dsibale  1 enable*/
            public uint dwGammaCorrectionLevel;/*0-100*/
            public uint dwWDREnabled;/*宽动态：0 dsibale  1 enable*/
            public uint dwWDRLevel1;/*0-F*/
            public uint dwWDRLevel2;/*0-F*/
            public uint dwWDRContrastLevel;/*0-100*/
            public uint dwDayNightFilterType;/*日夜切换：0 day,1 night,2 auto */
            public uint dwSwitchScheduleEnabled;/*0 dsibale  1 enable,(保留)*/
            //模式1(保留)
            public uint dwBeginTime;	/*0-100*/
            public uint dwEndTime;/*0-100*/
            //模式2
            public uint dwDayToNightFilterLevel;//0-7
            public uint dwNightToDayFilterLevel;//0-7
            public uint dwDayNightFilterTime;//(60秒)
            public uint dwBacklightMode;/*背光补偿:0 USERSET 1 UP、2 DOWN、3 LEFT、4 RIGHT、5MIDDLE*/
            public uint dwPositionX1;//（X坐标1）
            public uint dwPositionY1;//（Y坐标1）
            public uint dwPositionX2;//（X坐标2）
            public uint dwPositionY2;//（Y坐标2）
            public uint dwBacklightLevel;/*0x0-0xF*/
            public uint dwDigitalNoiseRemoveEnable; /*数字去噪：0 dsibale  1 enable*/
            public uint dwDigitalNoiseRemoveLevel;/*0x0-0xF*/
            public uint dwMirror; /* 镜像：0 Left;1 Right,;2 Up;3Down */
            public uint dwDigitalZoom;/*数字缩放:0 dsibale  1 enable*/
            public uint dwDeadPixelDetect;/*坏点检测,0 dsibale  1 enable*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;
        }

        public const int NET_DVR_GET_CCDPARAMCFG = 1067;       //IPC获取CCD参数配置
        public const int NET_DVR_SET_CCDPARAMCFG = 1068;      //IPC设置CCD参数配置

        //图像增强仪
        //图像增强去燥区域配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct tagIMAGEREGION
        {
            public uint dwSize;//总的结构长度
            public ushort wImageRegionTopLeftX;/* 图像增强去燥的左上x坐标 */
            public ushort wImageRegionTopLeftY;/* 图像增强去燥的左上y坐标 */
            public ushort wImageRegionWidth;/* 图像增强去燥区域的宽 */
            public ushort wImageRegionHeight;/*图像增强去燥区域的高*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //图像增强、去噪级别及稳定性使能配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct tagIMAGESUBPARAM
        {
            public NET_DVR_SCHEDTIME struImageStatusTime;//图像状态时间段
            public byte byImageEnhancementLevel;//图像增强的级别，0-7，0表示关闭
            public byte byImageDenoiseLevel;//图像去噪的级别，0-7，0表示关闭
            public byte byImageStableEnable;//图像稳定性使能，0表示关闭，1表示打开
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int NET_DVR_GET_IMAGEREGION = 1062;       //图像增强仪图像增强去燥区域获取
        public const int NET_DVR_SET_IMAGEREGION = 1063;       //图像增强仪图像增强去燥区域获取
        public const int NET_DVR_GET_IMAGEPARAM = 1064;       // 图像增强仪图像参数(去噪、增强级别，稳定性使能)获取
        public const int NET_DVR_SET_IMAGEPARAM = 1065;       // 图像增强仪图像参数(去噪、增强级别，稳定性使能)设置

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct tagIMAGEPARAM
        {
            public uint dwSize;
            //图像增强时间段参数配置，周日开始	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public tagIMAGESUBPARAM[] struImageParamSched;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }    
    }
}
