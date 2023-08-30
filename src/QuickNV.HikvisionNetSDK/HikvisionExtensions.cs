using System;
using static QuickNV.HikvisionNetSDK.Defines;

namespace QuickNV.HikvisionNetSDK
{
    public static class HikvisionExtensions
    {
        public static DateTime ToDateTime(this NET_DVR_TIME time)
        {
            return new DateTime(time.dwYear, time.dwMonth, time.dwDay, time.dwHour, time.dwMinute, time.dwSecond, DateTimeKind.Local);
        }

        public static NET_DVR_TIME ToNET_DVR_TIME(this DateTime time)
        {
            return new NET_DVR_TIME()
            {
                dwYear = time.Year,
                dwMonth = time.Month,
                dwDay = time.Day,
                dwHour = time.Hour,
                dwMinute = time.Minute,
                dwSecond = time.Second
            };
        }
    }
}
