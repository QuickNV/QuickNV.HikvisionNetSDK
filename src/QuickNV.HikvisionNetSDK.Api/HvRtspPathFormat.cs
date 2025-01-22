using System;

namespace QuickNV.HikvisionNetSDK.Api
{
    public enum HvRtspPathFormat
    {
        /// <summary>
        /// 2012年以前路径格式。示例：rtsp://192.168.1.65/h264/ch1/sub/av_stream
        /// </summary>
        AvStream,
        /// <summary>
        /// 2012年以后路径格式。rtsp://192.168.1.65/Streaming/Channels/102
        /// </summary>
        Streaming
    }
}