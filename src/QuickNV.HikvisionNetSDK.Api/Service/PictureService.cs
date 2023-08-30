using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using static QuickNV.HikvisionNetSDK.Defines;
using static QuickNV.HikvisionNetSDK.Methods;

namespace QuickNV.HikvisionNetSDK.Api.Service
{
    public class PictureService
    {
        private HvSession session;
        internal PictureService(HvSession session)
        {
            this.session = session;
        }

        public void CaptureJPEGPicture(int channelId, string fileName)
        {
            NET_DVR_JPEGPARA lpJpegPara = new NET_DVR_JPEGPARA();
            lpJpegPara.wPicQuality = 0; //图像质量 Image quality
            lpJpegPara.wPicSize = 0xff; //抓图分辨率 Picture size: 0xff-Auto(使用当前码流分辨率) 
            //抓图分辨率需要设备支持，更多取值请参考SDK文档
            Invoke(NET_DVR_CaptureJPEGPicture(session.UserId, channelId, ref lpJpegPara, fileName));
        }

        public byte[] CaptureJPEGPicture_NEW(int channelId)
        {
            byte[] buffer = new byte[10 * 1024 * 1024];
            NET_DVR_JPEGPARA lpJpegPara = new NET_DVR_JPEGPARA();
            lpJpegPara.wPicQuality = 0; //图像质量 Image quality
            lpJpegPara.wPicSize = 0xff; //抓图分辨率 Picture size: 0xff-Auto(使用当前码流分辨率) 
            uint ret = 0;
            Invoke(NET_DVR_CaptureJPEGPicture_NEW(session.UserId, channelId, ref lpJpegPara, buffer, (uint)buffer.Length, ref ret));
            var retBuffer = new byte[ret];
            Buffer.BlockCopy(buffer, 0, retBuffer, 0, (int)ret);
            return retBuffer;
        }
    }
}
