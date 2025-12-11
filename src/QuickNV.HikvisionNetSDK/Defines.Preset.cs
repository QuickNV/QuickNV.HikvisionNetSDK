using System.Runtime.InteropServices;

namespace QuickNV.HikvisionNetSDK
{
    public partial class Defines
    {
        public const int NET_DVR_GET_PRESETCFG = 3224;  //获取预置点参数
        public const int NET_DVR_GET_PRESET_NUM = 3226;  //获取预置点个数

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

    }
}