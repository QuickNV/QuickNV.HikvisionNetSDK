using static Hikvision.NetSDK.Defines;
using static Hikvision.NetSDK.Methods;

var host = "127.0.0.1";
var port = 8000;
var user = "admin";
var password = "123456";

try
{
    Console.WriteLine("正在初始化...");
    Invoke(() => NET_DVR_Init());
    Console.WriteLine("初始化成功！");
    NET_DVR_DEVICEINFO_V30 deviceInfo = default;
    //登录
    Console.WriteLine("正在登录...");
    Invoke(() => NET_DVR_Login_V30(host, port, user, password, ref deviceInfo));
    Console.WriteLine("登录成功！");
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}