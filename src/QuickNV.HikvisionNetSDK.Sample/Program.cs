using static QuickNV.HikvisionNetSDK.Defines;
using static QuickNV.HikvisionNetSDK.Methods;

var host = "127.0.0.1";
var port = 8000;
var user = "admin";
var password = "123456";

try
{
    NET_DVR_Init();
    Console.WriteLine("初始化成功！");
    //登录
    Console.WriteLine("正在登录...");
    NET_DVR_DEVICEINFO_V30 deviceInfo = default;
    var userId = Invoke(NET_DVR_Login_V30(host, port, user, password, ref deviceInfo));
    Console.WriteLine("登录成功！");
    //退出登录
    NET_DVR_Logout_V30(userId);
    Console.WriteLine("退出登录完成");
    //清理
    NET_DVR_Cleanup();
    Console.WriteLine("清理完成");
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}