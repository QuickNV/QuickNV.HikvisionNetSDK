using System;
using System.Collections.Generic;
using System.Text;

namespace Hikvision.NetSDK.Api
{
    public enum HvPTZCommand : uint
    {
        LIGHT_PWRON = 2, //接通灯光电源
        WIPER_PWRON = 3, //接通雨刷开关
        FAN_PWRON = 4, // 接通风扇开关
        HEATER_PWRON = 5, // 接通加热器开关
        AUX_PWRON1 = 6, // 接通辅助设备开关
        AUX_PWRON2 = 7, // 接通辅助设备开关
        ZOOM_IN = 11, // 焦距变大(倍率变大)
        ZOOM_OUT = 12, // 焦距变小(倍率变小)
        FOCUS_NEAR = 13, // 焦点前调
        FOCUS_FAR = 14, // 焦点后调
        IRIS_OPEN = 15, // 光圈扩大
        IRIS_CLOSE = 16, // 光圈缩小
        TILT_UP = 21, // 云台上仰
        TILT_DOWN = 22, // 云台下俯
        PAN_LEFT = 23, // 云台左转
        PAN_RIGHT = 24, // 云台右转
        UP_LEFT = 25, // 云台上仰和左转
        UP_RIGHT = 26, // 云台上仰和右转
        DOWN_LEFT = 27, // 云台下俯和左转
        DOWN_RIGHT = 28, // 云台下俯和右转
        PAN_AUTO = 29// 云台左右自动扫描
    }
}
