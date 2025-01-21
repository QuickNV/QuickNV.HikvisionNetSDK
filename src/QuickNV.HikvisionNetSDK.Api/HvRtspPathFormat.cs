using System;

namespace QuickNV.HikvisionNetSDK.Api
{
    public enum HvRtspPathFormat
    {
        /// <summary>
        /// rtsp://192.168.1.65/h264/ch1/sub/av_stream
        /// </summary>
        AvStream,
        /// <summary>
        /// rtsp://192.168.1.65/Streaming/Channels/102
        /// </summary>
        Streaming
    }
}