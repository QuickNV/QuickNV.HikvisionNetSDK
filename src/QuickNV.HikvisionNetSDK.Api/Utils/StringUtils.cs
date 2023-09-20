using System;
using System.Collections.Generic;
using System.Text;

namespace QuickNV.HikvisionNetSDK.Api.Utils
{
    public class StringUtils
    {
        public static string ByteArray2String(byte[] buffer)
        {
            return ByteArray2String(buffer, Encoding.ASCII);
        }

        public static string ByteArray2String(byte[] buffer, Encoding encoding)
        {
            return encoding.GetString(buffer).Trim(char.MinValue);
        }

        public static void String2ByteArray(string str, byte[] buffer)
        {
            String2ByteArray(str, buffer, Encoding.ASCII);
        }

        public static void String2ByteArray(string str, byte[] buffer, Encoding encoding)
        {
            encoding.GetBytes(str, 0, str.Length, buffer, 0);
        }
    }
}
