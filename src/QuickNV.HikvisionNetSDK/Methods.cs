using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using static QuickNV.HikvisionNetSDK.Defines;

namespace QuickNV.HikvisionNetSDK
{
    public class Methods
    {
        private static bool IsWindows = Environment.OSVersion.Platform == PlatformID.Win32NT;

        public static int Invoke(int result)
        {
            if (result < 0)
            {
                uint lastErrorCode = NET_DVR_GetLastError();
                throw new HikvisionException(lastErrorCode);
            }
            return result;
        }

        public static bool Invoke(bool result)
        {
            if (!result)
            {
                uint lastErrorCode = NET_DVR_GetLastError();
                throw new HikvisionException(lastErrorCode);
            }
            return result;
        }

        public static int NET_DVR_SendWithRecvRemoteConfig(int lHandle, ref NET_DVR_FACE_RECORD lpInBuff, int dwInBuffSize, ref NET_DVR_FACE_STATUS lpOutBuff, int dwOutBuffSize, IntPtr dwOutDataLen)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SendWithRecvRemoteConfig(lHandle, ref lpInBuff, dwInBuffSize, ref lpOutBuff, dwOutBuffSize, dwOutDataLen);
            else
                return Methods_Linux.NET_DVR_SendWithRecvRemoteConfig(lHandle, ref lpInBuff, dwInBuffSize, ref lpOutBuff, dwOutBuffSize, dwOutDataLen);
        }
        public static int NET_DVR_SendWithRecvRemoteConfig(int lHandle, ref NET_DVR_FINGERPRINT_RECORD lpInBuff, int dwInBuffSize, ref NET_DVR_FINGERPRINT_STATUS lpOutBuff, int dwOutBuffSize, IntPtr dwOutDataLen)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SendWithRecvRemoteConfig(lHandle, ref lpInBuff, dwInBuffSize, ref lpOutBuff, dwOutBuffSize, dwOutDataLen);
            else
                return Methods_Linux.NET_DVR_SendWithRecvRemoteConfig(lHandle, ref lpInBuff, dwInBuffSize, ref lpOutBuff, dwOutBuffSize, dwOutDataLen);
        }
        public static int NET_DVR_SendWithRecvRemoteConfig(int lHandle, IntPtr lpInBuff, uint dwInBuffSize, IntPtr lpOutBuff, uint dwOutBuffSize, ref uint dwOutDataLen)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SendWithRecvRemoteConfig(lHandle, lpInBuff, dwInBuffSize, lpOutBuff, dwOutBuffSize, ref dwOutDataLen);
            else
                return Methods_Linux.NET_DVR_SendWithRecvRemoteConfig(lHandle, lpInBuff, dwInBuffSize, lpOutBuff, dwOutBuffSize, ref dwOutDataLen);
        }
        public static bool NET_DVR_STDXMLConfig(int lUserID, IntPtr lpInputParam, IntPtr lpOutputParam)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_STDXMLConfig(lUserID, lpInputParam, lpOutputParam);
            else
                return Methods_Linux.NET_DVR_STDXMLConfig(lUserID, lpInputParam, lpOutputParam);
        }
        public static bool NET_DVR_ControlGateway(int lUserID, int lGatewayIndex, uint dwStaic)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_ControlGateway(lUserID, lGatewayIndex, dwStaic);
            else
                return Methods_Linux.NET_DVR_ControlGateway(lUserID, lGatewayIndex, dwStaic);
        }
        public static bool NET_DVR_SetDVRMessageCallBack_V50(int iIndex, MSGCallBack fMessageCallBack, IntPtr pUser)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetDVRMessageCallBack_V50(iIndex, fMessageCallBack, pUser);
            else
                return Methods_Linux.NET_DVR_SetDVRMessageCallBack_V50(iIndex, fMessageCallBack, pUser);
        }
        public static int NET_DVR_GetNextRemoteConfig(int lHandle, ref NET_DVR_CAPTURE_FACE_CFG lpOutBuff, int dwOutBuffSize)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetNextRemoteConfig(lHandle, ref lpOutBuff, dwOutBuffSize);
            else
                return Methods_Linux.NET_DVR_GetNextRemoteConfig(lHandle, ref lpOutBuff, dwOutBuffSize);
        }
        public static int NET_DVR_GetNextRemoteConfig(int lHandle, ref NET_DVR_FINGER_PRINT_INFO_STATUS_V50 lpOutBuff, int dwOutBuffSize)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetNextRemoteConfig(lHandle, ref lpOutBuff, dwOutBuffSize);
            else
                return Methods_Linux.NET_DVR_GetNextRemoteConfig(lHandle, ref lpOutBuff, dwOutBuffSize);
        }
        public static int NET_DVR_GetNextRemoteConfig(int lHandle, ref NET_DVR_ACS_EVENT_CFG lpOutBuff, int dwOutBuffSize)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetNextRemoteConfig(lHandle, ref lpOutBuff, dwOutBuffSize);
            else
                return Methods_Linux.NET_DVR_GetNextRemoteConfig(lHandle, ref lpOutBuff, dwOutBuffSize);
        }
        public static int NET_DVR_GetNextRemoteConfig(int lHandle, ref NET_DVR_FINGERPRINT_RECORD lpOutBuff, int dwOutBuffSize)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetNextRemoteConfig(lHandle, ref lpOutBuff, dwOutBuffSize);
            else
                return Methods_Linux.NET_DVR_GetNextRemoteConfig(lHandle, ref lpOutBuff, dwOutBuffSize);
        }
        public static int NET_DVR_GetNextRemoteConfig(int lHandle, ref NET_DVR_CAPTURE_FINGERPRINT_CFG lpOutBuff, int dwOutBuffSize)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetNextRemoteConfig(lHandle, ref lpOutBuff, dwOutBuffSize);
            else
                return Methods_Linux.NET_DVR_GetNextRemoteConfig(lHandle, ref lpOutBuff, dwOutBuffSize);
        }
        public static int NET_DVR_GetNextRemoteConfig(int lHandle, ref NET_DVR_FACE_RECORD lpOutBuff, int dwOutBuffSize)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetNextRemoteConfig(lHandle, ref lpOutBuff, dwOutBuffSize);
            else
                return Methods_Linux.NET_DVR_GetNextRemoteConfig(lHandle, ref lpOutBuff, dwOutBuffSize);
        }
        public static bool NET_DVR_Init()
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_Init();
            else
                return Methods_Linux.NET_DVR_Init();
        }
        public static bool NET_DVR_Cleanup()
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_Cleanup();
            else
                return Methods_Linux.NET_DVR_Cleanup();
        }
        public static bool NET_DVR_SetDVRMessage(uint nMessage, IntPtr hWnd)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetDVRMessage(nMessage, hWnd);
            else
                return Methods_Linux.NET_DVR_SetDVRMessage(nMessage, hWnd);
        }
        public static bool NET_DVR_SetExceptionCallBack_V30(uint nMessage, IntPtr hWnd, EXCEPYIONCALLBACK fExceptionCallBack, IntPtr pUser)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetExceptionCallBack_V30(nMessage, hWnd, fExceptionCallBack, pUser);
            else
                return Methods_Linux.NET_DVR_SetExceptionCallBack_V30(nMessage, hWnd, fExceptionCallBack, pUser);
        }
        public static bool NET_DVR_SetDVRMessCallBack(MESSCALLBACK fMessCallBack)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetDVRMessCallBack(fMessCallBack);
            else
                return Methods_Linux.NET_DVR_SetDVRMessCallBack(fMessCallBack);
        }
        public static bool NET_DVR_SetDVRMessCallBack_EX(MESSCALLBACKEX fMessCallBack_EX)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetDVRMessCallBack_EX(fMessCallBack_EX);
            else
                return Methods_Linux.NET_DVR_SetDVRMessCallBack_EX(fMessCallBack_EX);
        }
        public static bool NET_DVR_SetDVRMessCallBack_NEW(MESSCALLBACKNEW fMessCallBack_NEW)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetDVRMessCallBack_NEW(fMessCallBack_NEW);
            else
                return Methods_Linux.NET_DVR_SetDVRMessCallBack_NEW(fMessCallBack_NEW);
        }
        public static bool NET_DVR_SetDVRMessageCallBack(MESSAGECALLBACK fMessageCallBack, uint dwUser)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetDVRMessageCallBack(fMessageCallBack, dwUser);
            else
                return Methods_Linux.NET_DVR_SetDVRMessageCallBack(fMessageCallBack, dwUser);
        }
        public static bool NET_DVR_SetDVRMessageCallBack_V30(MSGCallBack fMessageCallBack, IntPtr pUser)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetDVRMessageCallBack_V30(fMessageCallBack, pUser);
            else
                return Methods_Linux.NET_DVR_SetDVRMessageCallBack_V30(fMessageCallBack, pUser);
        }
        public static bool NET_DVR_SetDVRMessageCallBack_V31(MSGCallBack_V31 fMessageCallBack, IntPtr pUser)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetDVRMessageCallBack_V31(fMessageCallBack, pUser);
            else
                return Methods_Linux.NET_DVR_SetDVRMessageCallBack_V31(fMessageCallBack, pUser);
        }
        public static bool NET_DVR_SetSDKLocalCfg(int enumType, IntPtr lpInBuff)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetSDKLocalCfg(enumType, lpInBuff);
            else
                return Methods_Linux.NET_DVR_SetSDKLocalCfg(enumType, lpInBuff);
        }
        public static bool NET_DVR_GetSDKLocalCfg(int enumType, IntPtr lpOutBuff)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetSDKLocalCfg(enumType, lpOutBuff);
            else
                return Methods_Linux.NET_DVR_GetSDKLocalCfg(enumType, lpOutBuff);
        }
        public static bool NET_DVR_SetConnectTime(uint dwWaitTime, uint dwTryTimes)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetConnectTime(dwWaitTime, dwTryTimes);
            else
                return Methods_Linux.NET_DVR_SetConnectTime(dwWaitTime, dwTryTimes);
        }
        public static bool NET_DVR_SetReconnect(uint dwInterval, int bEnableRecon)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetReconnect(dwInterval, bEnableRecon);
            else
                return Methods_Linux.NET_DVR_SetReconnect(dwInterval, bEnableRecon);
        }
        public static bool NET_DVR_GetLocalIP(byte[] strIP, ref uint pValidNum, ref Boolean pEnableBind)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetLocalIP(strIP, ref pValidNum, ref pEnableBind);
            else
                return Methods_Linux.NET_DVR_GetLocalIP(strIP, ref pValidNum, ref pEnableBind);
        }
        public static bool NET_DVR_SetValidIP(uint dwIPIndex, Boolean bEnableBind)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetValidIP(dwIPIndex, bEnableBind);
            else
                return Methods_Linux.NET_DVR_SetValidIP(dwIPIndex, bEnableBind);
        }
        public static uint NET_DVR_GetSDKVersion()
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetSDKVersion();
            else
                return Methods_Linux.NET_DVR_GetSDKVersion();
        }
        public static uint NET_DVR_GetSDKBuildVersion()
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetSDKBuildVersion();
            else
                return Methods_Linux.NET_DVR_GetSDKBuildVersion();
        }
        public static Int32 NET_DVR_IsSupport()
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_IsSupport();
            else
                return Methods_Linux.NET_DVR_IsSupport();
        }
        public static bool NET_DVR_StartListen(string sLocalIP, ushort wLocalPort)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_StartListen(sLocalIP, wLocalPort);
            else
                return Methods_Linux.NET_DVR_StartListen(sLocalIP, wLocalPort);
        }
        public static bool NET_DVR_StopListen()
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_StopListen();
            else
                return Methods_Linux.NET_DVR_StopListen();
        }
        public static int NET_DVR_StartListen_V30(String sLocalIP, ushort wLocalPort, MSGCallBack DataCallback, IntPtr pUserData)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_StartListen_V30(sLocalIP, wLocalPort, DataCallback, pUserData);
            else
                return Methods_Linux.NET_DVR_StartListen_V30(sLocalIP, wLocalPort, DataCallback, pUserData);
        }
        public static bool NET_DVR_StopListen_V30(Int32 lListenHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_StopListen_V30(lListenHandle);
            else
                return Methods_Linux.NET_DVR_StopListen_V30(lListenHandle);
        }
        public static Int32 NET_DVR_Login(string sDVRIP, ushort wDVRPort, string sUserName, string sPassword, ref NET_DVR_DEVICEINFO lpDeviceInfo)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_Login(sDVRIP, wDVRPort, sUserName, sPassword, ref lpDeviceInfo);
            else
                return Methods_Linux.NET_DVR_Login(sDVRIP, wDVRPort, sUserName, sPassword, ref lpDeviceInfo);
        }
        public static bool NET_DVR_Logout(int iUserID)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_Logout(iUserID);
            else
                return Methods_Linux.NET_DVR_Logout(iUserID);
        }
        public static uint NET_DVR_GetLastError()
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetLastError();
            else
                return Methods_Linux.NET_DVR_GetLastError();
        }
        public static IntPtr NET_DVR_GetErrorMsg(ref int pErrorNo)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetErrorMsg(ref pErrorNo);
            else
                return Methods_Linux.NET_DVR_GetErrorMsg(ref pErrorNo);
        }
        public static bool NET_DVR_SetShowMode(uint dwShowType, uint colorKey)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetShowMode(dwShowType, colorKey);
            else
                return Methods_Linux.NET_DVR_SetShowMode(dwShowType, colorKey);
        }
        public static bool NET_DVR_GetDVRIPByResolveSvr(string sServerIP, ushort wServerPort, string sDVRName, ushort wDVRNameLen, string sDVRSerialNumber, ushort wDVRSerialLen, IntPtr pGetIP)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetDVRIPByResolveSvr(sServerIP, wServerPort, sDVRName, wDVRNameLen, sDVRSerialNumber, wDVRSerialLen, pGetIP);
            else
                return Methods_Linux.NET_DVR_GetDVRIPByResolveSvr(sServerIP, wServerPort, sDVRName, wDVRNameLen, sDVRSerialNumber, wDVRSerialLen, pGetIP);
        }
        public static bool NET_DVR_GetDVRIPByResolveSvr_EX(string sServerIP, ushort wServerPort, byte[] sDVRName, ushort wDVRNameLen, byte[] sDVRSerialNumber, ushort wDVRSerialLen, byte[] sGetIP, ref uint dwPort)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetDVRIPByResolveSvr_EX(sServerIP, wServerPort, sDVRName, wDVRNameLen, sDVRSerialNumber, wDVRSerialLen, sGetIP, ref dwPort);
            else
                return Methods_Linux.NET_DVR_GetDVRIPByResolveSvr_EX(sServerIP, wServerPort, sDVRName, wDVRNameLen, sDVRSerialNumber, wDVRSerialLen, sGetIP, ref dwPort);
        }
        public static Int32 NET_DVR_RealPlay(int iUserID, ref NET_DVR_CLIENTINFO lpClientInfo)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_RealPlay(iUserID, ref lpClientInfo);
            else
                return Methods_Linux.NET_DVR_RealPlay(iUserID, ref lpClientInfo);
        }
        public static Int32 NET_SDK_RealPlay(int iUserLogID, ref NET_DVR_CLIENTINFO lpDVRClientInfo)
        {
            if (IsWindows)
                return Methods_Win.NET_SDK_RealPlay(iUserLogID, ref lpDVRClientInfo);
            else
                return Methods_Linux.NET_SDK_RealPlay(iUserLogID, ref lpDVRClientInfo);
        }

        /*********************************************************
        Function:	NET_DVR_RealPlay_V30
        Desc:		实时预览。
        Input:	lUserID [in] NET_DVR_Login()或NET_DVR_Login_V30()的返回值 
                lpClientInfo [in] 预览参数 
                cbRealDataCallBack [in] 码流数据回调函数 
                pUser [in] 用户数据 
                bBlocked [in] 请求码流过程是否阻塞：0－否；1－是 
        Output:	
        Return:	1表示失败，其他值作为NET_DVR_StopRealPlay等函数的句柄参数
        **********************************************************/
        public static int NET_DVR_RealPlay_V30(int iUserID, ref NET_DVR_CLIENTINFO lpClientInfo, REALDATACALLBACK fRealDataCallBack_V30, IntPtr pUser, UInt32 bBlocked)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_RealPlay_V30(iUserID, ref lpClientInfo, fRealDataCallBack_V30, pUser, bBlocked);
            else
                return Methods_Linux.NET_DVR_RealPlay_V30(iUserID, ref lpClientInfo, fRealDataCallBack_V30, pUser, bBlocked);
        }
        public static int NET_DVR_RealPlay_V40(int iUserID, ref NET_DVR_PREVIEWINFO lpPreviewInfo, REALDATACALLBACK fRealDataCallBack_V30, IntPtr pUser)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_RealPlay_V40(iUserID, ref lpPreviewInfo, fRealDataCallBack_V30, pUser);
            else
                return Methods_Linux.NET_DVR_RealPlay_V40(iUserID, ref lpPreviewInfo, fRealDataCallBack_V30, pUser);
        }
        public static bool NET_DVR_StopRealPlay(int iRealHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_StopRealPlay(iRealHandle);
            else
                return Methods_Linux.NET_DVR_StopRealPlay(iRealHandle);
        }
        public static bool NET_DVR_RigisterDrawFun(int lRealHandle, DRAWFUN fDrawFun, uint dwUser)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_RigisterDrawFun(lRealHandle, fDrawFun, dwUser);
            else
                return Methods_Linux.NET_DVR_RigisterDrawFun(lRealHandle, fDrawFun, dwUser);
        }
        public static bool NET_DVR_SetPlayerBufNumber(Int32 lRealHandle, uint dwBufNum)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetPlayerBufNumber(lRealHandle, dwBufNum);
            else
                return Methods_Linux.NET_DVR_SetPlayerBufNumber(lRealHandle, dwBufNum);
        }
        public static bool NET_DVR_ThrowBFrame(Int32 lRealHandle, uint dwNum)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_ThrowBFrame(lRealHandle, dwNum);
            else
                return Methods_Linux.NET_DVR_ThrowBFrame(lRealHandle, dwNum);
        }
        public static bool NET_DVR_SetAudioMode(uint dwMode)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetAudioMode(dwMode);
            else
                return Methods_Linux.NET_DVR_SetAudioMode(dwMode);
        }
        public static bool NET_DVR_OpenSound(Int32 lRealHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_OpenSound(lRealHandle);
            else
                return Methods_Linux.NET_DVR_OpenSound(lRealHandle);
        }
        public static bool NET_DVR_CloseSound()
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_CloseSound();
            else
                return Methods_Linux.NET_DVR_CloseSound();
        }
        public static bool NET_DVR_OpenSoundShare(Int32 lRealHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_OpenSoundShare(lRealHandle);
            else
                return Methods_Linux.NET_DVR_OpenSoundShare(lRealHandle);
        }
        public static bool NET_DVR_CloseSoundShare(Int32 lRealHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_CloseSoundShare(lRealHandle);
            else
                return Methods_Linux.NET_DVR_CloseSoundShare(lRealHandle);
        }
        public static bool NET_DVR_Volume(Int32 lRealHandle, ushort wVolume)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_Volume(lRealHandle, wVolume);
            else
                return Methods_Linux.NET_DVR_Volume(lRealHandle, wVolume);
        }
        public static bool NET_DVR_SaveRealData(Int32 lRealHandle, string sFileName)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SaveRealData(lRealHandle, sFileName);
            else
                return Methods_Linux.NET_DVR_SaveRealData(lRealHandle, sFileName);
        }
        public static bool NET_DVR_StopSaveRealData(Int32 lRealHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_StopSaveRealData(lRealHandle);
            else
                return Methods_Linux.NET_DVR_StopSaveRealData(lRealHandle);
        }
        public static bool NET_DVR_SetRealDataCallBack(int lRealHandle, SETREALDATACALLBACK fRealDataCallBack, uint dwUser)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetRealDataCallBack(lRealHandle, fRealDataCallBack, dwUser);
            else
                return Methods_Linux.NET_DVR_SetRealDataCallBack(lRealHandle, fRealDataCallBack, dwUser);
        }
        public static bool NET_DVR_SetStandardDataCallBack(int lRealHandle, STDDATACALLBACK fStdDataCallBack, uint dwUser)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetStandardDataCallBack(lRealHandle, fStdDataCallBack, dwUser);
            else
                return Methods_Linux.NET_DVR_SetStandardDataCallBack(lRealHandle, fStdDataCallBack, dwUser);
        }
        public static bool NET_DVR_CapturePicture(Int32 lRealHandle, string sPicFileName)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_CapturePicture(lRealHandle, sPicFileName);
            else
                return Methods_Linux.NET_DVR_CapturePicture(lRealHandle, sPicFileName);
        }
        public static bool NET_DVR_CapturePictureBlock(Int32 lRealHandle, string sPicFileName, int dwTimeOut)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_CapturePictureBlock(lRealHandle, sPicFileName, dwTimeOut);
            else
                return Methods_Linux.NET_DVR_CapturePictureBlock(lRealHandle, sPicFileName, dwTimeOut);
        }
        public static bool NET_DVR_GetPTZCtrl(Int32 lRealHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetPTZCtrl(lRealHandle);
            else
                return Methods_Linux.NET_DVR_GetPTZCtrl(lRealHandle);
        }
        public static bool NET_DVR_GetPTZCtrl_Other(Int32 lUserID, int lChannel)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetPTZCtrl_Other(lUserID, lChannel);
            else
                return Methods_Linux.NET_DVR_GetPTZCtrl_Other(lUserID, lChannel);
        }
        public static bool NET_DVR_PTZControl(Int32 lRealHandle, uint dwPTZCommand, uint dwStop)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_PTZControl(lRealHandle, dwPTZCommand, dwStop);
            else
                return Methods_Linux.NET_DVR_PTZControl(lRealHandle, dwPTZCommand, dwStop);
        }
        public static bool NET_DVR_PTZControl_Other(Int32 lUserID, Int32 lChannel, uint dwPTZCommand, uint dwStop)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_PTZControl_Other(lUserID, lChannel, dwPTZCommand, dwStop);
            else
                return Methods_Linux.NET_DVR_PTZControl_Other(lUserID, lChannel, dwPTZCommand, dwStop);
        }
        public static bool NET_DVR_TransPTZ(Int32 lRealHandle, string pPTZCodeBuf, uint dwBufSize)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_TransPTZ(lRealHandle, pPTZCodeBuf, dwBufSize);
            else
                return Methods_Linux.NET_DVR_TransPTZ(lRealHandle, pPTZCodeBuf, dwBufSize);
        }
        public static bool NET_DVR_TransPTZ_Other(int lUserID, int lChannel, string pPTZCodeBuf, uint dwBufSize)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_TransPTZ_Other(lUserID, lChannel, pPTZCodeBuf, dwBufSize);
            else
                return Methods_Linux.NET_DVR_TransPTZ_Other(lUserID, lChannel, pPTZCodeBuf, dwBufSize);
        }
        public static bool NET_DVR_PTZPreset(int lRealHandle, uint dwPTZPresetCmd, uint dwPresetIndex)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_PTZPreset(lRealHandle, dwPTZPresetCmd, dwPresetIndex);
            else
                return Methods_Linux.NET_DVR_PTZPreset(lRealHandle, dwPTZPresetCmd, dwPresetIndex);
        }
        public static bool NET_DVR_PTZPreset_Other(int lUserID, int lChannel, uint dwPTZPresetCmd, uint dwPresetIndex)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_PTZPreset_Other(lUserID, lChannel, dwPTZPresetCmd, dwPresetIndex);
            else
                return Methods_Linux.NET_DVR_PTZPreset_Other(lUserID, lChannel, dwPTZPresetCmd, dwPresetIndex);
        }
        public static bool NET_DVR_TransPTZ_EX(int lRealHandle, string pPTZCodeBuf, uint dwBufSize)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_TransPTZ_EX(lRealHandle, pPTZCodeBuf, dwBufSize);
            else
                return Methods_Linux.NET_DVR_TransPTZ_EX(lRealHandle, pPTZCodeBuf, dwBufSize);
        }
        public static bool NET_DVR_PTZControl_EX(int lRealHandle, uint dwPTZCommand, uint dwStop)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_PTZControl_EX(lRealHandle, dwPTZCommand, dwStop);
            else
                return Methods_Linux.NET_DVR_PTZControl_EX(lRealHandle, dwPTZCommand, dwStop);
        }
        public static bool NET_DVR_PTZPreset_EX(int lRealHandle, uint dwPTZPresetCmd, uint dwPresetIndex)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_PTZPreset_EX(lRealHandle, dwPTZPresetCmd, dwPresetIndex);
            else
                return Methods_Linux.NET_DVR_PTZPreset_EX(lRealHandle, dwPTZPresetCmd, dwPresetIndex);
        }
        public static bool NET_DVR_PTZCruise(int lRealHandle, uint dwPTZCruiseCmd, byte byCruiseRoute, byte byCruisePoint, ushort wInput)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_PTZCruise(lRealHandle, dwPTZCruiseCmd, byCruiseRoute, byCruisePoint, wInput);
            else
                return Methods_Linux.NET_DVR_PTZCruise(lRealHandle, dwPTZCruiseCmd, byCruiseRoute, byCruisePoint, wInput);
        }
        public static bool NET_DVR_PTZCruise_Other(int lUserID, int lChannel, uint dwPTZCruiseCmd, byte byCruiseRoute, byte byCruisePoint, ushort wInput)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_PTZCruise_Other(lUserID, lChannel, dwPTZCruiseCmd, byCruiseRoute, byCruisePoint, wInput);
            else
                return Methods_Linux.NET_DVR_PTZCruise_Other(lUserID, lChannel, dwPTZCruiseCmd, byCruiseRoute, byCruisePoint, wInput);
        }
        public static bool NET_DVR_PTZCruise_EX(int lRealHandle, uint dwPTZCruiseCmd, byte byCruiseRoute, byte byCruisePoint, ushort wInput)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_PTZCruise_EX(lRealHandle, dwPTZCruiseCmd, byCruiseRoute, byCruisePoint, wInput);
            else
                return Methods_Linux.NET_DVR_PTZCruise_EX(lRealHandle, dwPTZCruiseCmd, byCruiseRoute, byCruisePoint, wInput);
        }
        public static bool NET_DVR_PTZTrack(int lRealHandle, uint dwPTZTrackCmd)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_PTZTrack(lRealHandle, dwPTZTrackCmd);
            else
                return Methods_Linux.NET_DVR_PTZTrack(lRealHandle, dwPTZTrackCmd);
        }
        public static bool NET_DVR_PTZTrack_Other(int lUserID, int lChannel, uint dwPTZTrackCmd)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_PTZTrack_Other(lUserID, lChannel, dwPTZTrackCmd);
            else
                return Methods_Linux.NET_DVR_PTZTrack_Other(lUserID, lChannel, dwPTZTrackCmd);
        }
        public static bool NET_DVR_PTZTrack_EX(int lRealHandle, uint dwPTZTrackCmd)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_PTZTrack_EX(lRealHandle, dwPTZTrackCmd);
            else
                return Methods_Linux.NET_DVR_PTZTrack_EX(lRealHandle, dwPTZTrackCmd);
        }
        public static bool NET_DVR_PTZControlWithSpeed(int lRealHandle, uint dwPTZCommand, uint dwStop, uint dwSpeed)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_PTZControlWithSpeed(lRealHandle, dwPTZCommand, dwStop, dwSpeed);
            else
                return Methods_Linux.NET_DVR_PTZControlWithSpeed(lRealHandle, dwPTZCommand, dwStop, dwSpeed);
        }
        public static bool NET_DVR_PTZControlWithSpeed_Other(int lUserID, int lChannel, uint dwPTZCommand, uint dwStop, uint dwSpeed)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_PTZControlWithSpeed_Other(lUserID, lChannel, dwPTZCommand, dwStop, dwSpeed);
            else
                return Methods_Linux.NET_DVR_PTZControlWithSpeed_Other(lUserID, lChannel, dwPTZCommand, dwStop, dwSpeed);
        }
        public static bool NET_DVR_PTZControlWithSpeed_EX(int lRealHandle, uint dwPTZCommand, uint dwStop, uint dwSpeed)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_PTZControlWithSpeed_EX(lRealHandle, dwPTZCommand, dwStop, dwSpeed);
            else
                return Methods_Linux.NET_DVR_PTZControlWithSpeed_EX(lRealHandle, dwPTZCommand, dwStop, dwSpeed);
        }
        public static bool NET_DVR_GetPTZCruise(int lUserID, int lChannel, int lCruiseRoute, ref NET_DVR_CRUISE_RET lpCruiseRet)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetPTZCruise(lUserID, lChannel, lCruiseRoute, ref lpCruiseRet);
            else
                return Methods_Linux.NET_DVR_GetPTZCruise(lUserID, lChannel, lCruiseRoute, ref lpCruiseRet);
        }
        public static bool NET_DVR_PTZMltTrack(int lRealHandle, uint dwPTZTrackCmd, uint dwTrackIndex)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_PTZMltTrack(lRealHandle, dwPTZTrackCmd, dwTrackIndex);
            else
                return Methods_Linux.NET_DVR_PTZMltTrack(lRealHandle, dwPTZTrackCmd, dwTrackIndex);
        }
        public static bool NET_DVR_PTZMltTrack_Other(int lUserID, int lChannel, uint dwPTZTrackCmd, uint dwTrackIndex)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_PTZMltTrack_Other(lUserID, lChannel, dwPTZTrackCmd, dwTrackIndex);
            else
                return Methods_Linux.NET_DVR_PTZMltTrack_Other(lUserID, lChannel, dwPTZTrackCmd, dwTrackIndex);
        }
        public static bool NET_DVR_PTZMltTrack_EX(int lRealHandle, uint dwPTZTrackCmd, uint dwTrackIndex)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_PTZMltTrack_EX(lRealHandle, dwPTZTrackCmd, dwTrackIndex);
            else
                return Methods_Linux.NET_DVR_PTZMltTrack_EX(lRealHandle, dwPTZTrackCmd, dwTrackIndex);
        }
        public static int NET_DVR_FindFile(int lUserID, int lChannel, uint dwFileType, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_FindFile(lUserID, lChannel, dwFileType, ref lpStartTime, ref lpStopTime);
            else
                return Methods_Linux.NET_DVR_FindFile(lUserID, lChannel, dwFileType, ref lpStartTime, ref lpStopTime);
        }
        public static int NET_DVR_FindNextFile(int lFindHandle, ref NET_DVR_FIND_DATA lpFindData)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_FindNextFile(lFindHandle, ref lpFindData);
            else
                return Methods_Linux.NET_DVR_FindNextFile(lFindHandle, ref lpFindData);
        }
        public static bool NET_DVR_FindClose(int lFindHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_FindClose(lFindHandle);
            else
                return Methods_Linux.NET_DVR_FindClose(lFindHandle);
        }
        public static int NET_DVR_FindNextFile_V30(int lFindHandle, ref NET_DVR_FINDDATA_V30 lpFindData)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_FindNextFile_V30(lFindHandle, ref lpFindData);
            else
                return Methods_Linux.NET_DVR_FindNextFile_V30(lFindHandle, ref lpFindData);
        }
        public static int NET_DVR_FindNextFile_V40(int lFindHandle, ref NET_DVR_FINDDATA_V40 lpFindData)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_FindNextFile_V40(lFindHandle, ref lpFindData);
            else
                return Methods_Linux.NET_DVR_FindNextFile_V40(lFindHandle, ref lpFindData);
        }
        public static int NET_DVR_FindFile_V30(int lUserID, ref NET_DVR_FILECOND pFindCond)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_FindFile_V30(lUserID, ref pFindCond);
            else
                return Methods_Linux.NET_DVR_FindFile_V30(lUserID, ref pFindCond);
        }
        public static int NET_DVR_FindFile_V40(int lUserID, ref NET_DVR_FILECOND_V40 pFindCond)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_FindFile_V40(lUserID, ref pFindCond);
            else
                return Methods_Linux.NET_DVR_FindFile_V40(lUserID, ref pFindCond);
        }
        public static int NET_DVR_FindFileByEvent_V40(int lUserID, ref NET_DVR_SEARCH_EVENT_PARAM_V40 lpSearchEventParam)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_FindFileByEvent_V40(lUserID, ref lpSearchEventParam);
            else
                return Methods_Linux.NET_DVR_FindFileByEvent_V40(lUserID, ref lpSearchEventParam);
        }
        public static int NET_DVR_FindNextEvent_V40(int lSearchHandle, ref NET_DVR_SEARCH_EVENT_RET_V40 lpSearchEventRet)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_FindNextEvent_V40(lSearchHandle, ref lpSearchEventRet);
            else
                return Methods_Linux.NET_DVR_FindNextEvent_V40(lSearchHandle, ref lpSearchEventRet);
        }
        public static bool NET_DVR_FindClose_V30(int lFindHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_FindClose_V30(lFindHandle);
            else
                return Methods_Linux.NET_DVR_FindClose_V30(lFindHandle);
        }
        public static int NET_DVR_FindNextFile_Card(int lFindHandle, ref NET_DVR_FINDDATA_CARD lpFindData)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_FindNextFile_Card(lFindHandle, ref lpFindData);
            else
                return Methods_Linux.NET_DVR_FindNextFile_Card(lFindHandle, ref lpFindData);
        }
        public static int NET_DVR_FindFile_Card(int lUserID, int lChannel, uint dwFileType, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_FindFile_Card(lUserID, lChannel, dwFileType, ref lpStartTime, ref lpStopTime);
            else
                return Methods_Linux.NET_DVR_FindFile_Card(lUserID, lChannel, dwFileType, ref lpStartTime, ref lpStopTime);
        }
        public static bool NET_DVR_LockFileByName(int lUserID, string sLockFileName)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_LockFileByName(lUserID, sLockFileName);
            else
                return Methods_Linux.NET_DVR_LockFileByName(lUserID, sLockFileName);
        }
        public static bool NET_DVR_UnlockFileByName(int lUserID, string sUnlockFileName)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_UnlockFileByName(lUserID, sUnlockFileName);
            else
                return Methods_Linux.NET_DVR_UnlockFileByName(lUserID, sUnlockFileName);
        }
        public static int NET_DVR_PlayBackByName(int lUserID, string sPlayBackFileName, IntPtr hWnd)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_PlayBackByName(lUserID, sPlayBackFileName, hWnd);
            else
                return Methods_Linux.NET_DVR_PlayBackByName(lUserID, sPlayBackFileName, hWnd);
        }
        public static int NET_DVR_PlayBackByTime(int lUserID, int lChannel, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime, System.IntPtr hWnd)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_PlayBackByTime(lUserID, lChannel, ref lpStartTime, ref lpStopTime, hWnd);
            else
                return Methods_Linux.NET_DVR_PlayBackByTime(lUserID, lChannel, ref lpStartTime, ref lpStopTime, hWnd);
        }
        public static int NET_DVR_PlayBackByTime_V40(int lUserID, ref NET_DVR_VOD_PARA pVodPara)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_PlayBackByTime_V40(lUserID, ref pVodPara);
            else
                return Methods_Linux.NET_DVR_PlayBackByTime_V40(lUserID, ref pVodPara);
        }
        public static int NET_DVR_PlayBackReverseByName(int lUserID, string sPlayBackFileName, IntPtr hWnd)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_PlayBackReverseByName(lUserID, sPlayBackFileName, hWnd);
            else
                return Methods_Linux.NET_DVR_PlayBackReverseByName(lUserID, sPlayBackFileName, hWnd);
        }
        public static int NET_DVR_PlayBackReverseByTime_V40(int lUserID, IntPtr hWnd, ref NET_DVR_PLAYCOND pPlayCond)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_PlayBackReverseByTime_V40(lUserID, hWnd, ref pPlayCond);
            else
                return Methods_Linux.NET_DVR_PlayBackReverseByTime_V40(lUserID, hWnd, ref pPlayCond);
        }
        public static bool NET_DVR_PlayBackControl(int lPlayHandle, uint dwControlCode, uint dwInValue, ref uint LPOutValue)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_PlayBackControl(lPlayHandle, dwControlCode, dwInValue, ref LPOutValue);
            else
                return Methods_Linux.NET_DVR_PlayBackControl(lPlayHandle, dwControlCode, dwInValue, ref LPOutValue);
        }
        public static bool NET_DVR_PlayBackControl_V40(int lPlayHandle, uint dwControlCode, IntPtr lpInBuffer, uint dwInValue, IntPtr lpOutBuffer, ref uint LPOutValue)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_PlayBackControl_V40(lPlayHandle, dwControlCode, lpInBuffer, dwInValue, lpOutBuffer, ref LPOutValue);
            else
                return Methods_Linux.NET_DVR_PlayBackControl_V40(lPlayHandle, dwControlCode, lpInBuffer, dwInValue, lpOutBuffer, ref LPOutValue);
        }
        public static bool NET_DVR_StopPlayBack(int lPlayHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_StopPlayBack(lPlayHandle);
            else
                return Methods_Linux.NET_DVR_StopPlayBack(lPlayHandle);
        }
        public static bool NET_DVR_SetPlayDataCallBack(int lPlayHandle, PLAYDATACALLBACK fPlayDataCallBack, uint dwUser)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetPlayDataCallBack(lPlayHandle, fPlayDataCallBack, dwUser);
            else
                return Methods_Linux.NET_DVR_SetPlayDataCallBack(lPlayHandle, fPlayDataCallBack, dwUser);
        }
        public static bool NET_DVR_PlayBackSaveData(int lPlayHandle, string sFileName)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_PlayBackSaveData(lPlayHandle, sFileName);
            else
                return Methods_Linux.NET_DVR_PlayBackSaveData(lPlayHandle, sFileName);
        }
        public static bool NET_DVR_StopPlayBackSave(int lPlayHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_StopPlayBackSave(lPlayHandle);
            else
                return Methods_Linux.NET_DVR_StopPlayBackSave(lPlayHandle);
        }
        public static bool NET_DVR_GetPlayBackOsdTime(int lPlayHandle, ref NET_DVR_TIME lpOsdTime)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetPlayBackOsdTime(lPlayHandle, ref lpOsdTime);
            else
                return Methods_Linux.NET_DVR_GetPlayBackOsdTime(lPlayHandle, ref lpOsdTime);
        }
        public static bool NET_DVR_PlayBackCaptureFile(int lPlayHandle, string sFileName)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_PlayBackCaptureFile(lPlayHandle, sFileName);
            else
                return Methods_Linux.NET_DVR_PlayBackCaptureFile(lPlayHandle, sFileName);
        }
        public static int NET_DVR_GetFileByName(int lUserID, string sDVRFileName, string sSavedFileName)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetFileByName(lUserID, sDVRFileName, sSavedFileName);
            else
                return Methods_Linux.NET_DVR_GetFileByName(lUserID, sDVRFileName, sSavedFileName);
        }
        public static int NET_DVR_GetFileByTime(int lUserID, int lChannel, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime, string sSavedFileName)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetFileByTime(lUserID, lChannel, ref lpStartTime, ref lpStopTime, sSavedFileName);
            else
                return Methods_Linux.NET_DVR_GetFileByTime(lUserID, lChannel, ref lpStartTime, ref lpStopTime, sSavedFileName);
        }
        public static int NET_DVR_GetFileByTime_V40(int lUserID, string sSavedFileName, ref NET_DVR_PLAYCOND pDownloadCond)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetFileByTime_V40(lUserID, sSavedFileName, ref pDownloadCond);
            else
                return Methods_Linux.NET_DVR_GetFileByTime_V40(lUserID, sSavedFileName, ref pDownloadCond);
        }
        public static bool NET_DVR_StopGetFile(int lFileHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_StopGetFile(lFileHandle);
            else
                return Methods_Linux.NET_DVR_StopGetFile(lFileHandle);
        }
        public static int NET_DVR_GetDownloadPos(int lFileHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetDownloadPos(lFileHandle);
            else
                return Methods_Linux.NET_DVR_GetDownloadPos(lFileHandle);
        }
        public static int NET_DVR_GetPlayBackPos(int lPlayHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetPlayBackPos(lPlayHandle);
            else
                return Methods_Linux.NET_DVR_GetPlayBackPos(lPlayHandle);
        }
        public static int NET_DVR_FindPicture(int lUserID, ref NET_DVR_FIND_PICTURE_PARAM pFindParam)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_FindPicture(lUserID, ref pFindParam);
            else
                return Methods_Linux.NET_DVR_FindPicture(lUserID, ref pFindParam);
        }
        public static int NET_DVR_FindNextPicture_V50(int lFindHandle, ref NET_DVR_FIND_PICTURE_V50 lpFindData)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_FindNextPicture_V50(lFindHandle, ref lpFindData);
            else
                return Methods_Linux.NET_DVR_FindNextPicture_V50(lFindHandle, ref lpFindData);
        }
        public static bool NET_DVR_CloseFindPicture(int lFindHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_CloseFindPicture(lFindHandle);
            else
                return Methods_Linux.NET_DVR_CloseFindPicture(lFindHandle);
        }
        public static bool NET_DVR_GetPicture(int lUserID, String sDVRFileName, String sSavedFileName)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetPicture(lUserID, sDVRFileName, sSavedFileName);
            else
                return Methods_Linux.NET_DVR_GetPicture(lUserID, sDVRFileName, sSavedFileName);
        }
        public static int NET_DVR_Upgrade(int lUserID, string sFileName)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_Upgrade(lUserID, sFileName);
            else
                return Methods_Linux.NET_DVR_Upgrade(lUserID, sFileName);
        }
        public static int NET_DVR_GetUpgradeState(int lUpgradeHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetUpgradeState(lUpgradeHandle);
            else
                return Methods_Linux.NET_DVR_GetUpgradeState(lUpgradeHandle);
        }
        public static int NET_DVR_GetUpgradeProgress(int lUpgradeHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetUpgradeProgress(lUpgradeHandle);
            else
                return Methods_Linux.NET_DVR_GetUpgradeProgress(lUpgradeHandle);
        }
        public static bool NET_DVR_CloseUpgradeHandle(int lUpgradeHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_CloseUpgradeHandle(lUpgradeHandle);
            else
                return Methods_Linux.NET_DVR_CloseUpgradeHandle(lUpgradeHandle);
        }
        public static bool NET_DVR_SetNetworkEnvironment(uint dwEnvironmentLevel)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetNetworkEnvironment(dwEnvironmentLevel);
            else
                return Methods_Linux.NET_DVR_SetNetworkEnvironment(dwEnvironmentLevel);
        }
        public static int NET_DVR_FormatDisk(int lUserID, int lDiskNumber)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_FormatDisk(lUserID, lDiskNumber);
            else
                return Methods_Linux.NET_DVR_FormatDisk(lUserID, lDiskNumber);
        }
        public static bool NET_DVR_GetFormatProgress(int lFormatHandle, ref int pCurrentFormatDisk, ref int pCurrentDiskPos, ref int pFormatStatic)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetFormatProgress(lFormatHandle, ref pCurrentFormatDisk, ref pCurrentDiskPos, ref pFormatStatic);
            else
                return Methods_Linux.NET_DVR_GetFormatProgress(lFormatHandle, ref pCurrentFormatDisk, ref pCurrentDiskPos, ref pFormatStatic);
        }
        public static bool NET_DVR_CloseFormatHandle(int lFormatHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_CloseFormatHandle(lFormatHandle);
            else
                return Methods_Linux.NET_DVR_CloseFormatHandle(lFormatHandle);
        }
        public static bool NET_DVR_GetIPCProtoList(int lUserID, ref NET_DVR_IPC_PROTO_LIST lpProtoList)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetIPCProtoList(lUserID, ref lpProtoList);
            else
                return Methods_Linux.NET_DVR_GetIPCProtoList(lUserID, ref lpProtoList);
        }
        public static bool NET_DVR_GetIPCProtoList_V41(int lUserID, ref NET_DVR_IPC_PROTO_LIST_V41 lpProtoList)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetIPCProtoList_V41(lUserID, ref lpProtoList);
            else
                return Methods_Linux.NET_DVR_GetIPCProtoList_V41(lUserID, ref lpProtoList);
        }
        public static int NET_DVR_SetupAlarmChan(int lUserID)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetupAlarmChan(lUserID);
            else
                return Methods_Linux.NET_DVR_SetupAlarmChan(lUserID);
        }
        public static bool NET_DVR_CloseAlarmChan(int lAlarmHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_CloseAlarmChan(lAlarmHandle);
            else
                return Methods_Linux.NET_DVR_CloseAlarmChan(lAlarmHandle);
        }
        public static int NET_DVR_SetupAlarmChan_V30(int lUserID)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetupAlarmChan_V30(lUserID);
            else
                return Methods_Linux.NET_DVR_SetupAlarmChan_V30(lUserID);
        }
        public static int NET_DVR_SetupAlarmChan_V41(int lUserID, ref NET_DVR_SETUPALARM_PARAM lpSetupParam)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetupAlarmChan_V41(lUserID, ref lpSetupParam);
            else
                return Methods_Linux.NET_DVR_SetupAlarmChan_V41(lUserID, ref lpSetupParam);
        }
        public static bool NET_DVR_CloseAlarmChan_V30(int lAlarmHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_CloseAlarmChan_V30(lAlarmHandle);
            else
                return Methods_Linux.NET_DVR_CloseAlarmChan_V30(lAlarmHandle);
        }
        public static int NET_DVR_StartVoiceCom(int lUserID, VOICEDATACALLBACK fVoiceDataCallBack, uint dwUser)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_StartVoiceCom(lUserID, fVoiceDataCallBack, dwUser);
            else
                return Methods_Linux.NET_DVR_StartVoiceCom(lUserID, fVoiceDataCallBack, dwUser);
        }
        public static int NET_DVR_StartVoiceCom_V30(int lUserID, uint dwVoiceChan, bool bNeedCBNoEncData, VOICEDATACALLBACKV30 fVoiceDataCallBack, IntPtr pUser)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_StartVoiceCom_V30(lUserID, dwVoiceChan, bNeedCBNoEncData, fVoiceDataCallBack, pUser);
            else
                return Methods_Linux.NET_DVR_StartVoiceCom_V30(lUserID, dwVoiceChan, bNeedCBNoEncData, fVoiceDataCallBack, pUser);
        }
        public static bool NET_DVR_SetVoiceComClientVolume(int lVoiceComHandle, ushort wVolume)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetVoiceComClientVolume(lVoiceComHandle, wVolume);
            else
                return Methods_Linux.NET_DVR_SetVoiceComClientVolume(lVoiceComHandle, wVolume);
        }
        public static bool NET_DVR_StopVoiceCom(int lVoiceComHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_StopVoiceCom(lVoiceComHandle);
            else
                return Methods_Linux.NET_DVR_StopVoiceCom(lVoiceComHandle);
        }
        public static int NET_DVR_StartVoiceCom_MR(int lUserID, VOICEDATACALLBACK fVoiceDataCallBack, uint dwUser)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_StartVoiceCom_MR(lUserID, fVoiceDataCallBack, dwUser);
            else
                return Methods_Linux.NET_DVR_StartVoiceCom_MR(lUserID, fVoiceDataCallBack, dwUser);
        }
        public static int NET_DVR_StartVoiceCom_MR_V30(int lUserID, uint dwVoiceChan, VOICEDATACALLBACKV30 fVoiceDataCallBack, IntPtr pUser)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_StartVoiceCom_MR_V30(lUserID, dwVoiceChan, fVoiceDataCallBack, pUser);
            else
                return Methods_Linux.NET_DVR_StartVoiceCom_MR_V30(lUserID, dwVoiceChan, fVoiceDataCallBack, pUser);
        }
        public static bool NET_DVR_VoiceComSendData(int lVoiceComHandle, string pSendBuf, uint dwBufSize)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_VoiceComSendData(lVoiceComHandle, pSendBuf, dwBufSize);
            else
                return Methods_Linux.NET_DVR_VoiceComSendData(lVoiceComHandle, pSendBuf, dwBufSize);
        }
        public static bool NET_DVR_ClientAudioStart()
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_ClientAudioStart();
            else
                return Methods_Linux.NET_DVR_ClientAudioStart();
        }
        public static bool NET_DVR_ClientAudioStart_V30(VOICEAUDIOSTART fVoiceAudioStart, IntPtr pUser)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_ClientAudioStart_V30(fVoiceAudioStart, pUser);
            else
                return Methods_Linux.NET_DVR_ClientAudioStart_V30(fVoiceAudioStart, pUser);
        }
        public static bool NET_DVR_ClientAudioStop()
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_ClientAudioStop();
            else
                return Methods_Linux.NET_DVR_ClientAudioStop();
        }
        public static bool NET_DVR_AddDVR(int lUserID)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_AddDVR(lUserID);
            else
                return Methods_Linux.NET_DVR_AddDVR(lUserID);
        }
        public static int NET_DVR_AddDVR_V30(int lUserID, uint dwVoiceChan)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_AddDVR_V30(lUserID, dwVoiceChan);
            else
                return Methods_Linux.NET_DVR_AddDVR_V30(lUserID, dwVoiceChan);
        }
        public static bool NET_DVR_DelDVR(int lUserID)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_DelDVR(lUserID);
            else
                return Methods_Linux.NET_DVR_DelDVR(lUserID);
        }
        public static bool NET_DVR_DelDVR_V30(int lVoiceHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_DelDVR_V30(lVoiceHandle);
            else
                return Methods_Linux.NET_DVR_DelDVR_V30(lVoiceHandle);
        }
        public static bool NET_DVR_SerialStart(int lUserID, int lSerialPort, SERIALDATACALLBACK fSerialDataCallBack, uint dwUser)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SerialStart(lUserID, lSerialPort, fSerialDataCallBack, dwUser);
            else
                return Methods_Linux.NET_DVR_SerialStart(lUserID, lSerialPort, fSerialDataCallBack, dwUser);
        }
        public static bool NET_DVR_SerialSend(int lSerialHandle, int lChannel, string pSendBuf, uint dwBufSize)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SerialSend(lSerialHandle, lChannel, pSendBuf, dwBufSize);
            else
                return Methods_Linux.NET_DVR_SerialSend(lSerialHandle, lChannel, pSendBuf, dwBufSize);
        }
        public static bool NET_DVR_SerialStop(int lSerialHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SerialStop(lSerialHandle);
            else
                return Methods_Linux.NET_DVR_SerialStop(lSerialHandle);
        }
        public static bool NET_DVR_SendTo232Port(int lUserID, string pSendBuf, uint dwBufSize)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SendTo232Port(lUserID, pSendBuf, dwBufSize);
            else
                return Methods_Linux.NET_DVR_SendTo232Port(lUserID, pSendBuf, dwBufSize);
        }
        public static bool NET_DVR_SendToSerialPort(int lUserID, uint dwSerialPort, uint dwSerialIndex, string pSendBuf, uint dwBufSize)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SendToSerialPort(lUserID, dwSerialPort, dwSerialIndex, pSendBuf, dwBufSize);
            else
                return Methods_Linux.NET_DVR_SendToSerialPort(lUserID, dwSerialPort, dwSerialIndex, pSendBuf, dwBufSize);
        }
        public static System.IntPtr NET_DVR_InitG722Decoder(int nBitrate)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_InitG722Decoder(nBitrate);
            else
                return Methods_Linux.NET_DVR_InitG722Decoder(nBitrate);
        }
        public static void NET_DVR_ReleaseG722Decoder(IntPtr pDecHandle)
        {
            if (IsWindows)
                Methods_Win.NET_DVR_ReleaseG722Decoder(pDecHandle);
            else
                Methods_Linux.NET_DVR_ReleaseG722Decoder(pDecHandle);
        }
        public static bool NET_DVR_DecodeG722Frame(IntPtr pDecHandle, ref byte pInBuffer, ref byte pOutBuffer)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_DecodeG722Frame(pDecHandle, ref pInBuffer, ref pOutBuffer);
            else
                return Methods_Linux.NET_DVR_DecodeG722Frame(pDecHandle, ref pInBuffer, ref pOutBuffer);
        }
        public static IntPtr NET_DVR_InitG722Encoder()
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_InitG722Encoder();
            else
                return Methods_Linux.NET_DVR_InitG722Encoder();
        }
        public static bool NET_DVR_EncodeG722Frame(IntPtr pEncodeHandle, ref byte pInBuffer, ref byte pOutBuffer)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_EncodeG722Frame(pEncodeHandle, ref pInBuffer, ref pOutBuffer);
            else
                return Methods_Linux.NET_DVR_EncodeG722Frame(pEncodeHandle, ref pInBuffer, ref pOutBuffer);
        }
        public static void NET_DVR_ReleaseG722Encoder(IntPtr pEncodeHandle)
        {
            if (IsWindows)
                Methods_Win.NET_DVR_ReleaseG722Encoder(pEncodeHandle);
            else
                Methods_Linux.NET_DVR_ReleaseG722Encoder(pEncodeHandle);
        }
        public static bool NET_DVR_ClickKey(int lUserID, int lKeyIndex)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_ClickKey(lUserID, lKeyIndex);
            else
                return Methods_Linux.NET_DVR_ClickKey(lUserID, lKeyIndex);
        }
        public static bool NET_DVR_StartDVRRecord(int lUserID, int lChannel, int lRecordType)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_StartDVRRecord(lUserID, lChannel, lRecordType);
            else
                return Methods_Linux.NET_DVR_StartDVRRecord(lUserID, lChannel, lRecordType);
        }
        public static bool NET_DVR_StopDVRRecord(int lUserID, int lChannel)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_StopDVRRecord(lUserID, lChannel);
            else
                return Methods_Linux.NET_DVR_StopDVRRecord(lUserID, lChannel);
        }
        public static bool NET_DVR_InitDevice_Card(ref int pDeviceTotalChan)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_InitDevice_Card(ref pDeviceTotalChan);
            else
                return Methods_Linux.NET_DVR_InitDevice_Card(ref pDeviceTotalChan);
        }
        public static bool NET_DVR_ReleaseDevice_Card()
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_ReleaseDevice_Card();
            else
                return Methods_Linux.NET_DVR_ReleaseDevice_Card();
        }
        public static bool NET_DVR_InitDDraw_Card(IntPtr hParent, uint colorKey)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_InitDDraw_Card(hParent, colorKey);
            else
                return Methods_Linux.NET_DVR_InitDDraw_Card(hParent, colorKey);
        }
        public static bool NET_DVR_ReleaseDDraw_Card()
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_ReleaseDDraw_Card();
            else
                return Methods_Linux.NET_DVR_ReleaseDDraw_Card();
        }
        public static int NET_DVR_RealPlay_Card(int lUserID, ref NET_DVR_CARDINFO lpCardInfo, int lChannelNum)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_RealPlay_Card(lUserID, ref lpCardInfo, lChannelNum);
            else
                return Methods_Linux.NET_DVR_RealPlay_Card(lUserID, ref lpCardInfo, lChannelNum);
        }
        public static bool NET_DVR_ResetPara_Card(int lRealHandle, ref NET_DVR_DISPLAY_PARA lpDisplayPara)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_ResetPara_Card(lRealHandle, ref lpDisplayPara);
            else
                return Methods_Linux.NET_DVR_ResetPara_Card(lRealHandle, ref lpDisplayPara);
        }
        public static bool NET_DVR_RefreshSurface_Card()
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_RefreshSurface_Card();
            else
                return Methods_Linux.NET_DVR_RefreshSurface_Card();
        }
        public static bool NET_DVR_ClearSurface_Card()
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_ClearSurface_Card();
            else
                return Methods_Linux.NET_DVR_ClearSurface_Card();
        }
        public static bool NET_DVR_RestoreSurface_Card()
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_RestoreSurface_Card();
            else
                return Methods_Linux.NET_DVR_RestoreSurface_Card();
        }
        public static bool NET_DVR_OpenSound_Card(int lRealHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_OpenSound_Card(lRealHandle);
            else
                return Methods_Linux.NET_DVR_OpenSound_Card(lRealHandle);
        }
        public static bool NET_DVR_CloseSound_Card(int lRealHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_CloseSound_Card(lRealHandle);
            else
                return Methods_Linux.NET_DVR_CloseSound_Card(lRealHandle);
        }
        public static bool NET_DVR_SetVolume_Card(int lRealHandle, ushort wVolume)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetVolume_Card(lRealHandle, wVolume);
            else
                return Methods_Linux.NET_DVR_SetVolume_Card(lRealHandle, wVolume);
        }
        public static bool NET_DVR_AudioPreview_Card(int lRealHandle, int bEnable)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_AudioPreview_Card(lRealHandle, bEnable);
            else
                return Methods_Linux.NET_DVR_AudioPreview_Card(lRealHandle, bEnable);
        }
        public static int NET_DVR_GetCardLastError_Card()
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetCardLastError_Card();
            else
                return Methods_Linux.NET_DVR_GetCardLastError_Card();
        }
        public static System.IntPtr NET_DVR_GetChanHandle_Card(int lRealHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetChanHandle_Card(lRealHandle);
            else
                return Methods_Linux.NET_DVR_GetChanHandle_Card(lRealHandle);
        }
        public static bool NET_DVR_CapturePicture_Card(int lRealHandle, string sPicFileName)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_CapturePicture_Card(lRealHandle, sPicFileName);
            else
                return Methods_Linux.NET_DVR_CapturePicture_Card(lRealHandle, sPicFileName);
        }
        public static bool NET_DVR_GetSerialNum_Card(int lChannelNum, ref uint pDeviceSerialNo)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetSerialNum_Card(lChannelNum, ref pDeviceSerialNo);
            else
                return Methods_Linux.NET_DVR_GetSerialNum_Card(lChannelNum, ref pDeviceSerialNo);
        }
        public static int NET_DVR_FindDVRLog(int lUserID, int lSelectMode, uint dwMajorType, uint dwMinorType, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_FindDVRLog(lUserID, lSelectMode, dwMajorType, dwMinorType, ref lpStartTime, ref lpStopTime);
            else
                return Methods_Linux.NET_DVR_FindDVRLog(lUserID, lSelectMode, dwMajorType, dwMinorType, ref lpStartTime, ref lpStopTime);
        }
        public static int NET_DVR_FindNextLog(int lLogHandle, ref NET_DVR_LOG lpLogData)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_FindNextLog(lLogHandle, ref lpLogData);
            else
                return Methods_Linux.NET_DVR_FindNextLog(lLogHandle, ref lpLogData);
        }
        public static bool NET_DVR_FindLogClose(int lLogHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_FindLogClose(lLogHandle);
            else
                return Methods_Linux.NET_DVR_FindLogClose(lLogHandle);
        }
        public static int NET_DVR_FindDVRLog_V30(int lUserID, int lSelectMode, uint dwMajorType, uint dwMinorType, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime, bool bOnlySmart)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_FindDVRLog_V30(lUserID, lSelectMode, dwMajorType, dwMinorType, ref lpStartTime, ref lpStopTime, bOnlySmart);
            else
                return Methods_Linux.NET_DVR_FindDVRLog_V30(lUserID, lSelectMode, dwMajorType, dwMinorType, ref lpStartTime, ref lpStopTime, bOnlySmart);
        }
        public static int NET_DVR_FindNextLog_V30(int lLogHandle, ref NET_DVR_LOG_V30 lpLogData)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_FindNextLog_V30(lLogHandle, ref lpLogData);
            else
                return Methods_Linux.NET_DVR_FindNextLog_V30(lLogHandle, ref lpLogData);
        }
        public static bool NET_DVR_FindLogClose_V30(int lLogHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_FindLogClose_V30(lLogHandle);
            else
                return Methods_Linux.NET_DVR_FindLogClose_V30(lLogHandle);
        }
        public static int NET_DVR_FindFileByCard(int lUserID, int lChannel, uint dwFileType, int nFindType, ref byte sCardNumber, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_FindFileByCard(lUserID, lChannel, dwFileType, nFindType, ref sCardNumber, ref lpStartTime, ref lpStopTime);
            else
                return Methods_Linux.NET_DVR_FindFileByCard(lUserID, lChannel, dwFileType, nFindType, ref sCardNumber, ref lpStartTime, ref lpStopTime);
        }
        public static bool NET_DVR_CaptureJPEGPicture(int lUserID, int lChannel, ref NET_DVR_JPEGPARA lpJpegPara, string sPicFileName)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_CaptureJPEGPicture(lUserID, lChannel, ref lpJpegPara, sPicFileName);
            else
                return Methods_Linux.NET_DVR_CaptureJPEGPicture(lUserID, lChannel, ref lpJpegPara, sPicFileName);
        }
        public static bool NET_DVR_CaptureJPEGPicture_NEW(int lUserID, int lChannel, ref NET_DVR_JPEGPARA lpJpegPara, byte[] sJpegPicBuffer, uint dwPicSize, ref uint lpSizeReturned)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_CaptureJPEGPicture_NEW(lUserID, lChannel, ref lpJpegPara, sJpegPicBuffer, dwPicSize, ref lpSizeReturned);
            else
                return Methods_Linux.NET_DVR_CaptureJPEGPicture_NEW(lUserID, lChannel, ref lpJpegPara, sJpegPicBuffer, dwPicSize, ref lpSizeReturned);
        }
        public static int NET_DVR_GetRealPlayerIndex(int lRealHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetRealPlayerIndex(lRealHandle);
            else
                return Methods_Linux.NET_DVR_GetRealPlayerIndex(lRealHandle);
        }
        public static int NET_DVR_GetPlayBackPlayerIndex(int lPlayHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetPlayBackPlayerIndex(lPlayHandle);
            else
                return Methods_Linux.NET_DVR_GetPlayBackPlayerIndex(lPlayHandle);
        }
        //人脸识别上传文件发送数据
        public static Int32 NET_DVR_UploadSend(int lUploadHandle, ref NET_DVR_SEND_PARAM_IN pstruSendParamIN, IntPtr lpOutBuffer)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_UploadSend(lUploadHandle, ref pstruSendParamIN, lpOutBuffer);
            else
                return Methods_Linux.NET_DVR_UploadSend(lUploadHandle, ref pstruSendParamIN, lpOutBuffer);
        }
        //人脸识别上传文件
        public static Int32 NET_DVR_UploadFile_V40(int lUserID, uint dwUploadType, IntPtr lpInBuffer, uint dwInBufferSize, string sFileName, IntPtr lpOutBuffer, uint dwOutBufferSize)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_UploadFile_V40(lUserID, dwUploadType, lpInBuffer, dwInBufferSize, sFileName, lpOutBuffer, dwOutBufferSize);
            else
                return Methods_Linux.NET_DVR_UploadFile_V40(lUserID, dwUploadType, lpInBuffer, dwInBufferSize, sFileName, lpOutBuffer, dwOutBufferSize);
        }
        public static Int32 NET_DVR_GetUploadState(int lUploadHandle, ref uint pProgress)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetUploadState(lUploadHandle, ref pProgress);
            else
                return Methods_Linux.NET_DVR_GetUploadState(lUploadHandle, ref pProgress);
        }
        public static bool NET_DVR_GetUploadResult(int lUploadHandle, IntPtr lpOutBuffer, uint dwOutBufferSize)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetUploadResult(lUploadHandle, lpOutBuffer, dwOutBufferSize);
            else
                return Methods_Linux.NET_DVR_GetUploadResult(lUploadHandle, lpOutBuffer, dwOutBufferSize);
        }
        public static bool NET_DVR_UploadClose(int lUploadHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_UploadClose(lUploadHandle);
            else
                return Methods_Linux.NET_DVR_UploadClose(lUploadHandle);
        }
        public static bool NET_DVR_SetScaleCFG(int lUserID, uint dwScale)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetScaleCFG(lUserID, dwScale);
            else
                return Methods_Linux.NET_DVR_SetScaleCFG(lUserID, dwScale);
        }
        public static bool NET_DVR_GetScaleCFG(int lUserID, ref uint lpOutScale)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetScaleCFG(lUserID, ref lpOutScale);
            else
                return Methods_Linux.NET_DVR_GetScaleCFG(lUserID, ref lpOutScale);
        }
        public static bool NET_DVR_SetScaleCFG_V30(int lUserID, ref NET_DVR_SCALECFG pScalecfg)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetScaleCFG_V30(lUserID, ref pScalecfg);
            else
                return Methods_Linux.NET_DVR_SetScaleCFG_V30(lUserID, ref pScalecfg);
        }
        public static bool NET_DVR_GetScaleCFG_V30(int lUserID, ref NET_DVR_SCALECFG pScalecfg)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetScaleCFG_V30(lUserID, ref pScalecfg);
            else
                return Methods_Linux.NET_DVR_GetScaleCFG_V30(lUserID, ref pScalecfg);
        }
        public static bool NET_DVR_SetATMPortCFG(int lUserID, ushort wATMPort)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetATMPortCFG(lUserID, wATMPort);
            else
                return Methods_Linux.NET_DVR_SetATMPortCFG(lUserID, wATMPort);
        }
        public static bool NET_DVR_GetATMPortCFG(int lUserID, ref ushort LPOutATMPort)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetATMPortCFG(lUserID, ref LPOutATMPort);
            else
                return Methods_Linux.NET_DVR_GetATMPortCFG(lUserID, ref LPOutATMPort);
        }
        public static bool NET_DVR_InitDDrawDevice()
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_InitDDrawDevice();
            else
                return Methods_Linux.NET_DVR_InitDDrawDevice();
        }
        public static bool NET_DVR_ReleaseDDrawDevice()
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_ReleaseDDrawDevice();
            else
                return Methods_Linux.NET_DVR_ReleaseDDrawDevice();
        }
        public static int NET_DVR_GetDDrawDeviceTotalNums()
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetDDrawDeviceTotalNums();
            else
                return Methods_Linux.NET_DVR_GetDDrawDeviceTotalNums();
        }
        public static bool NET_DVR_SetDDrawDevice(int lPlayPort, uint nDeviceNum)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetDDrawDevice(lPlayPort, nDeviceNum);
            else
                return Methods_Linux.NET_DVR_SetDDrawDevice(lPlayPort, nDeviceNum);
        }
        public static bool NET_DVR_PTZSelZoomIn(int lRealHandle, ref NET_DVR_POINT_FRAME pStruPointFrame)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_PTZSelZoomIn(lRealHandle, ref pStruPointFrame);
            else
                return Methods_Linux.NET_DVR_PTZSelZoomIn(lRealHandle, ref pStruPointFrame);
        }
        public static bool NET_DVR_PTZSelZoomIn_EX(int lUserID, int lChannel, ref NET_DVR_POINT_FRAME pStruPointFrame)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_PTZSelZoomIn_EX(lUserID, lChannel, ref pStruPointFrame);
            else
                return Methods_Linux.NET_DVR_PTZSelZoomIn_EX(lUserID, lChannel, ref pStruPointFrame);
        }
        public static bool NET_DVR_StartDecode(int lUserID, int lChannel, ref NET_DVR_DECODERINFO lpDecoderinfo)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_StartDecode(lUserID, lChannel, ref lpDecoderinfo);
            else
                return Methods_Linux.NET_DVR_StartDecode(lUserID, lChannel, ref lpDecoderinfo);
        }
        public static bool NET_DVR_StopDecode(int lUserID, int lChannel)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_StopDecode(lUserID, lChannel);
            else
                return Methods_Linux.NET_DVR_StopDecode(lUserID, lChannel);
        }
        public static bool NET_DVR_GetDecoderState(int lUserID, int lChannel, ref NET_DVR_DECODERSTATE lpDecoderState)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetDecoderState(lUserID, lChannel, ref lpDecoderState);
            else
                return Methods_Linux.NET_DVR_GetDecoderState(lUserID, lChannel, ref lpDecoderState);
        }
        public static bool NET_DVR_SetDecInfo(int lUserID, int lChannel, ref NET_DVR_DECCFG lpDecoderinfo)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetDecInfo(lUserID, lChannel, ref lpDecoderinfo);
            else
                return Methods_Linux.NET_DVR_SetDecInfo(lUserID, lChannel, ref lpDecoderinfo);
        }
        public static bool NET_DVR_GetDecInfo(int lUserID, int lChannel, ref NET_DVR_DECCFG lpDecoderinfo)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetDecInfo(lUserID, lChannel, ref lpDecoderinfo);
            else
                return Methods_Linux.NET_DVR_GetDecInfo(lUserID, lChannel, ref lpDecoderinfo);
        }
        public static bool NET_DVR_SetDecTransPort(int lUserID, ref NET_DVR_PORTCFG lpTransPort)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetDecTransPort(lUserID, ref lpTransPort);
            else
                return Methods_Linux.NET_DVR_SetDecTransPort(lUserID, ref lpTransPort);
        }
        public static bool NET_DVR_GetDecTransPort(int lUserID, ref NET_DVR_PORTCFG lpTransPort)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetDecTransPort(lUserID, ref lpTransPort);
            else
                return Methods_Linux.NET_DVR_GetDecTransPort(lUserID, ref lpTransPort);
        }
        public static bool NET_DVR_DecPlayBackCtrl(int lUserID, int lChannel, uint dwControlCode, uint dwInValue, ref uint LPOutValue, ref NET_DVR_PLAYREMOTEFILE lpRemoteFileInfo)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_DecPlayBackCtrl(lUserID, lChannel, dwControlCode, dwInValue, ref LPOutValue, ref lpRemoteFileInfo);
            else
                return Methods_Linux.NET_DVR_DecPlayBackCtrl(lUserID, lChannel, dwControlCode, dwInValue, ref LPOutValue, ref lpRemoteFileInfo);
        }
        public static bool NET_DVR_StartDecSpecialCon(int lUserID, int lChannel, ref NET_DVR_DECCHANINFO lpDecChanInfo)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_StartDecSpecialCon(lUserID, lChannel, ref lpDecChanInfo);
            else
                return Methods_Linux.NET_DVR_StartDecSpecialCon(lUserID, lChannel, ref lpDecChanInfo);
        }
        public static bool NET_DVR_StopDecSpecialCon(int lUserID, int lChannel, ref NET_DVR_DECCHANINFO lpDecChanInfo)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_StopDecSpecialCon(lUserID, lChannel, ref lpDecChanInfo);
            else
                return Methods_Linux.NET_DVR_StopDecSpecialCon(lUserID, lChannel, ref lpDecChanInfo);
        }
        public static bool NET_DVR_DecCtrlDec(int lUserID, int lChannel, uint dwControlCode)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_DecCtrlDec(lUserID, lChannel, dwControlCode);
            else
                return Methods_Linux.NET_DVR_DecCtrlDec(lUserID, lChannel, dwControlCode);
        }
        public static bool NET_DVR_DecCtrlScreen(int lUserID, int lChannel, uint dwControl)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_DecCtrlScreen(lUserID, lChannel, dwControl);
            else
                return Methods_Linux.NET_DVR_DecCtrlScreen(lUserID, lChannel, dwControl);
        }
        public static bool NET_DVR_GetDecCurLinkStatus(int lUserID, int lChannel, ref NET_DVR_DECSTATUS lpDecStatus)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetDecCurLinkStatus(lUserID, lChannel, ref lpDecStatus);
            else
                return Methods_Linux.NET_DVR_GetDecCurLinkStatus(lUserID, lChannel, ref lpDecStatus);
        }
        public static bool NET_DVR_MatrixStartDynamic(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DYNAMIC_DEC lpDynamicInfo)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixStartDynamic(lUserID, dwDecChanNum, ref lpDynamicInfo);
            else
                return Methods_Linux.NET_DVR_MatrixStartDynamic(lUserID, dwDecChanNum, ref lpDynamicInfo);
        }
        public static bool NET_DVR_MatrixStopDynamic(int lUserID, uint dwDecChanNum)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixStopDynamic(lUserID, dwDecChanNum);
            else
                return Methods_Linux.NET_DVR_MatrixStopDynamic(lUserID, dwDecChanNum);
        }
        public static bool NET_DVR_MatrixGetDecChanInfo(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_CHAN_INFO lpInter)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixGetDecChanInfo(lUserID, dwDecChanNum, ref lpInter);
            else
                return Methods_Linux.NET_DVR_MatrixGetDecChanInfo(lUserID, dwDecChanNum, ref lpInter);
        }
        public static bool NET_DVR_MatrixGetDecChanInfo_V41(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_CHAN_INFO_V41 lpOuter)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixGetDecChanInfo_V41(lUserID, dwDecChanNum, ref lpOuter);
            else
                return Methods_Linux.NET_DVR_MatrixGetDecChanInfo_V41(lUserID, dwDecChanNum, ref lpOuter);
        }
        public static bool NET_DVR_MatrixSetLoopDecChanInfo(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_LOOP_DECINFO lpInter)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixSetLoopDecChanInfo(lUserID, dwDecChanNum, ref lpInter);
            else
                return Methods_Linux.NET_DVR_MatrixSetLoopDecChanInfo(lUserID, dwDecChanNum, ref lpInter);
        }
        public static bool NET_DVR_MatrixGetLoopDecChanInfo(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_LOOP_DECINFO lpInter)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixGetLoopDecChanInfo(lUserID, dwDecChanNum, ref lpInter);
            else
                return Methods_Linux.NET_DVR_MatrixGetLoopDecChanInfo(lUserID, dwDecChanNum, ref lpInter);
        }
        public static bool NET_DVR_MatrixSetLoopDecChanEnable(int lUserID, uint dwDecChanNum, uint dwEnable)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixSetLoopDecChanEnable(lUserID, dwDecChanNum, dwEnable);
            else
                return Methods_Linux.NET_DVR_MatrixSetLoopDecChanEnable(lUserID, dwDecChanNum, dwEnable);
        }
        public static bool NET_DVR_MatrixGetLoopDecChanEnable(int lUserID, uint dwDecChanNum, ref uint lpdwEnable)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixGetLoopDecChanEnable(lUserID, dwDecChanNum, ref lpdwEnable);
            else
                return Methods_Linux.NET_DVR_MatrixGetLoopDecChanEnable(lUserID, dwDecChanNum, ref lpdwEnable);
        }
        public static bool NET_DVR_MatrixGetLoopDecEnable(int lUserID, ref uint lpdwEnable)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixGetLoopDecEnable(lUserID, ref lpdwEnable);
            else
                return Methods_Linux.NET_DVR_MatrixGetLoopDecEnable(lUserID, ref lpdwEnable);
        }
        public static bool NET_DVR_MatrixSetDecChanEnable(int lUserID, uint dwDecChanNum, uint dwEnable)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixSetDecChanEnable(lUserID, dwDecChanNum, dwEnable);
            else
                return Methods_Linux.NET_DVR_MatrixSetDecChanEnable(lUserID, dwDecChanNum, dwEnable);
        }
        public static bool NET_DVR_MatrixGetDecChanEnable(int lUserID, uint dwDecChanNum, ref uint lpdwEnable)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixGetDecChanEnable(lUserID, dwDecChanNum, ref lpdwEnable);
            else
                return Methods_Linux.NET_DVR_MatrixGetDecChanEnable(lUserID, dwDecChanNum, ref lpdwEnable);
        }
        public static bool NET_DVR_MatrixGetDecChanStatus(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_CHAN_STATUS lpInter)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixGetDecChanStatus(lUserID, dwDecChanNum, ref lpInter);
            else
                return Methods_Linux.NET_DVR_MatrixGetDecChanStatus(lUserID, dwDecChanNum, ref lpInter);
        }
        public static bool NET_DVR_MatrixSetTranInfo(int lUserID, ref NET_DVR_MATRIX_TRAN_CHAN_CONFIG lpTranInfo)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixSetTranInfo(lUserID, ref lpTranInfo);
            else
                return Methods_Linux.NET_DVR_MatrixSetTranInfo(lUserID, ref lpTranInfo);
        }
        public static bool NET_DVR_MatrixGetTranInfo(int lUserID, ref NET_DVR_MATRIX_TRAN_CHAN_CONFIG lpTranInfo)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixGetTranInfo(lUserID, ref lpTranInfo);
            else
                return Methods_Linux.NET_DVR_MatrixGetTranInfo(lUserID, ref lpTranInfo);
        }
        public static bool NET_DVR_MatrixSetRemotePlay(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_REMOTE_PLAY lpInter)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixSetRemotePlay(lUserID, dwDecChanNum, ref lpInter);
            else
                return Methods_Linux.NET_DVR_MatrixSetRemotePlay(lUserID, dwDecChanNum, ref lpInter);
        }
        public static bool NET_DVR_MatrixSetRemotePlayControl(int lUserID, uint dwDecChanNum, uint dwControlCode, uint dwInValue, ref uint LPOutValue)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixSetRemotePlayControl(lUserID, dwDecChanNum, dwControlCode, dwInValue, ref LPOutValue);
            else
                return Methods_Linux.NET_DVR_MatrixSetRemotePlayControl(lUserID, dwDecChanNum, dwControlCode, dwInValue, ref LPOutValue);
        }
        public static bool NET_DVR_MatrixGetRemotePlayStatus(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_REMOTE_PLAY_STATUS lpOuter)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixGetRemotePlayStatus(lUserID, dwDecChanNum, ref lpOuter);
            else
                return Methods_Linux.NET_DVR_MatrixGetRemotePlayStatus(lUserID, dwDecChanNum, ref lpOuter);
        }
        public static bool NET_DVR_MatrixStartDynamic_V30(int lUserID, uint dwDecChanNum, ref NET_DVR_PU_STREAM_CFG lpDynamicInfo)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixStartDynamic_V30(lUserID, dwDecChanNum, ref lpDynamicInfo);
            else
                return Methods_Linux.NET_DVR_MatrixStartDynamic_V30(lUserID, dwDecChanNum, ref lpDynamicInfo);
        }
        public static bool NET_DVR_MatrixStartDynamic_V41(int lUserID, uint dwDecChanNum, ref NET_DVR_PU_STREAM_CFG_V41 lpDynamicInfo)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixStartDynamic_V41(lUserID, dwDecChanNum, ref lpDynamicInfo);
            else
                return Methods_Linux.NET_DVR_MatrixStartDynamic_V41(lUserID, dwDecChanNum, ref lpDynamicInfo);
        }
        public static bool NET_DVR_MatrixSetLoopDecChanInfo_V30(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_LOOP_DECINFO_V30 lpInter)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixSetLoopDecChanInfo_V30(lUserID, dwDecChanNum, ref lpInter);
            else
                return Methods_Linux.NET_DVR_MatrixSetLoopDecChanInfo_V30(lUserID, dwDecChanNum, ref lpInter);
        }
        public static bool NET_DVR_MatrixGetLoopDecChanInfo_V30(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_LOOP_DECINFO_V30 lpInter)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixGetLoopDecChanInfo_V30(lUserID, dwDecChanNum, ref lpInter);
            else
                return Methods_Linux.NET_DVR_MatrixGetLoopDecChanInfo_V30(lUserID, dwDecChanNum, ref lpInter);
        }
        public static bool NET_DVR_MatrixGetDecChanInfo_V30(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_CHAN_INFO_V30 lpInter)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixGetDecChanInfo_V30(lUserID, dwDecChanNum, ref lpInter);
            else
                return Methods_Linux.NET_DVR_MatrixGetDecChanInfo_V30(lUserID, dwDecChanNum, ref lpInter);
        }
        public static bool NET_DVR_MatrixSetTranInfo_V30(int lUserID, ref NET_DVR_MATRIX_TRAN_CHAN_CONFIG_V30 lpTranInfo)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixSetTranInfo_V30(lUserID, ref lpTranInfo);
            else
                return Methods_Linux.NET_DVR_MatrixSetTranInfo_V30(lUserID, ref lpTranInfo);
        }
        public static bool NET_DVR_MatrixGetTranInfo_V30(int lUserID, ref NET_DVR_MATRIX_TRAN_CHAN_CONFIG_V30 lpTranInfo)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixGetTranInfo_V30(lUserID, ref lpTranInfo);
            else
                return Methods_Linux.NET_DVR_MatrixGetTranInfo_V30(lUserID, ref lpTranInfo);
        }
        public static bool NET_DVR_MatrixGetDisplayCfg(int lUserID, uint dwDispChanNum, ref NET_DVR_VGA_DISP_CHAN_CFG lpDisplayCfg)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixGetDisplayCfg(lUserID, dwDispChanNum, ref lpDisplayCfg);
            else
                return Methods_Linux.NET_DVR_MatrixGetDisplayCfg(lUserID, dwDispChanNum, ref lpDisplayCfg);
        }
        public static bool NET_DVR_MatrixSetDisplayCfg(int lUserID, uint dwDispChanNum, ref NET_DVR_VGA_DISP_CHAN_CFG lpDisplayCfg)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixSetDisplayCfg(lUserID, dwDispChanNum, ref lpDisplayCfg);
            else
                return Methods_Linux.NET_DVR_MatrixSetDisplayCfg(lUserID, dwDispChanNum, ref lpDisplayCfg);
        }
        public static bool NET_DVR_MatrixGetDisplayCfg_V41(int lUserID, uint dwDispChanNum, ref NET_DVR_MATRIX_VOUTCFG lpDisplayCfg)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixGetDisplayCfg_V41(lUserID, dwDispChanNum, ref lpDisplayCfg);
            else
                return Methods_Linux.NET_DVR_MatrixGetDisplayCfg_V41(lUserID, dwDispChanNum, ref lpDisplayCfg);
        }
        public static bool NET_DVR_MatrixSetDisplayCfg_V41(int lUserID, uint dwDispChanNum, ref NET_DVR_MATRIX_VOUTCFG lpDisplayCfg)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixSetDisplayCfg_V41(lUserID, dwDispChanNum, ref lpDisplayCfg);
            else
                return Methods_Linux.NET_DVR_MatrixSetDisplayCfg_V41(lUserID, dwDispChanNum, ref lpDisplayCfg);
        }
        public static int NET_DVR_MatrixStartPassiveDecode(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_PASSIVEMODE lpPassiveMode)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixStartPassiveDecode(lUserID, dwDecChanNum, ref lpPassiveMode);
            else
                return Methods_Linux.NET_DVR_MatrixStartPassiveDecode(lUserID, dwDecChanNum, ref lpPassiveMode);
        }
        public static bool NET_DVR_MatrixSendData(int lPassiveHandle, System.IntPtr pSendBuf, uint dwBufSize)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixSendData(lPassiveHandle, pSendBuf, dwBufSize);
            else
                return Methods_Linux.NET_DVR_MatrixSendData(lPassiveHandle, pSendBuf, dwBufSize);
        }
        public static bool NET_DVR_MatrixStopPassiveDecode(int lPassiveHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixStopPassiveDecode(lPassiveHandle);
            else
                return Methods_Linux.NET_DVR_MatrixStopPassiveDecode(lPassiveHandle);
        }
        public static bool NET_DVR_UploadLogo(int lUserID, uint dwDispChanNum, ref NET_DVR_DISP_LOGOCFG lpDispLogoCfg, System.IntPtr sLogoBuffer)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_UploadLogo(lUserID, dwDispChanNum, ref lpDispLogoCfg, sLogoBuffer);
            else
                return Methods_Linux.NET_DVR_UploadLogo(lUserID, dwDispChanNum, ref lpDispLogoCfg, sLogoBuffer);
        }
        public static int NET_DVR_PicUpload(int lUserID, String sFileName, ref NET_DVR_PICTURECFG lpPictureCfg)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_PicUpload(lUserID, sFileName, ref lpPictureCfg);
            else
                return Methods_Linux.NET_DVR_PicUpload(lUserID, sFileName, ref lpPictureCfg);
        }
        public static int NET_DVR_GetPicUploadProgress(int lUploadHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetPicUploadProgress(lUploadHandle);
            else
                return Methods_Linux.NET_DVR_GetPicUploadProgress(lUploadHandle);
        }
        public static bool NET_DVR_CloseUploadHandle(int lUploadHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_CloseUploadHandle(lUploadHandle);
            else
                return Methods_Linux.NET_DVR_CloseUploadHandle(lUploadHandle);
        }
        public static int NET_DVR_GetPicUploadState(int lUploadHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetPicUploadState(lUploadHandle);
            else
                return Methods_Linux.NET_DVR_GetPicUploadState(lUploadHandle);
        }
        public static bool NET_DVR_LogoSwitch(int lUserID, uint dwDecChan, uint dwLogoSwitch)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_LogoSwitch(lUserID, dwDecChan, dwLogoSwitch);
            else
                return Methods_Linux.NET_DVR_LogoSwitch(lUserID, dwDecChan, dwLogoSwitch);
        }
        public static bool NET_DVR_MatrixGetDeviceStatus(int lUserID, ref NET_DVR_DECODER_WORK_STATUS lpDecoderCfg)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixGetDeviceStatus(lUserID, ref lpDecoderCfg);
            else
                return Methods_Linux.NET_DVR_MatrixGetDeviceStatus(lUserID, ref lpDecoderCfg);
        }
        public static bool NET_DVR_GetInputSignalList_V40(int lUserID, uint dwDevNum, ref NET_DVR_INPUT_SIGNAL_LIST lpInputSignalList)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetInputSignalList_V40(lUserID, dwDevNum, ref lpInputSignalList);
            else
                return Methods_Linux.NET_DVR_GetInputSignalList_V40(lUserID, dwDevNum, ref lpInputSignalList);
        }
        public static bool NET_DVR_MatrixDiaplayControl(int lUserID, uint dwDispChanNum, uint dwDispChanCmd, uint dwCmdParam)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixDiaplayControl(lUserID, dwDispChanNum, dwDispChanCmd, dwCmdParam);
            else
                return Methods_Linux.NET_DVR_MatrixDiaplayControl(lUserID, dwDispChanNum, dwDispChanCmd, dwCmdParam);
        }
        public static bool NET_DVR_RefreshPlay(int lPlayHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_RefreshPlay(lPlayHandle);
            else
                return Methods_Linux.NET_DVR_RefreshPlay(lPlayHandle);
        }
        public static bool NET_DVR_RestoreConfig(int lUserID)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_RestoreConfig(lUserID);
            else
                return Methods_Linux.NET_DVR_RestoreConfig(lUserID);
        }
        public static bool NET_DVR_SaveConfig(int lUserID)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SaveConfig(lUserID);
            else
                return Methods_Linux.NET_DVR_SaveConfig(lUserID);
        }
        public static bool NET_DVR_RebootDVR(int lUserID)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_RebootDVR(lUserID);
            else
                return Methods_Linux.NET_DVR_RebootDVR(lUserID);
        }
        public static bool NET_DVR_ShutDownDVR(int lUserID)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_ShutDownDVR(lUserID);
            else
                return Methods_Linux.NET_DVR_ShutDownDVR(lUserID);
        }
        public static bool NET_DVR_ControlGateway(int lUserID, int lGatewayIndex, int dwStaic)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_ControlGateway(lUserID, lGatewayIndex, dwStaic);
            else
                return Methods_Linux.NET_DVR_ControlGateway(lUserID, lGatewayIndex, dwStaic);
        }
        public static int NET_DVR_StartRemoteConfig(
            int lUserID,
            uint dwCommand,
            IntPtr lpInBuffer,
            uint dwInBufferLen,
            fRemoteConfigCallback cbStateCallback,
            IntPtr pUserData
        )
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_StartRemoteConfig(
 lUserID, 
 dwCommand, 
 lpInBuffer, 
 dwInBufferLen, 
 cbStateCallback, 
 pUserData
);
            else
                return Methods_Linux.NET_DVR_StartRemoteConfig(
 lUserID, 
 dwCommand, 
 lpInBuffer, 
 dwInBufferLen, 
 cbStateCallback, 
 pUserData
);
        }
        public static bool NET_DVR_GetDVRConfig(int lUserID, uint dwCommand, int lChannel, IntPtr lpOutBuffer, uint dwOutBufferSize, ref uint lpBytesReturned)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetDVRConfig(lUserID, dwCommand, lChannel, lpOutBuffer, dwOutBufferSize, ref lpBytesReturned);
            else
                return Methods_Linux.NET_DVR_GetDVRConfig(lUserID, dwCommand, lChannel, lpOutBuffer, dwOutBufferSize, ref lpBytesReturned);
        }
        public static bool NET_DVR_SetDVRConfig(int lUserID, uint dwCommand, int lChannel, System.IntPtr lpInBuffer, uint dwInBufferSize)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetDVRConfig(lUserID, dwCommand, lChannel, lpInBuffer, dwInBufferSize);
            else
                return Methods_Linux.NET_DVR_SetDVRConfig(lUserID, dwCommand, lChannel, lpInBuffer, dwInBufferSize);
        }
        public static bool NET_DVR_GetDVRWorkState_V30(int lUserID, IntPtr pWorkState)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetDVRWorkState_V30(lUserID, pWorkState);
            else
                return Methods_Linux.NET_DVR_GetDVRWorkState_V30(lUserID, pWorkState);
        }
        public static bool NET_DVR_GetDVRWorkState(int lUserID, ref NET_DVR_WORKSTATE lpWorkState)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetDVRWorkState(lUserID, ref lpWorkState);
            else
                return Methods_Linux.NET_DVR_GetDVRWorkState(lUserID, ref lpWorkState);
        }
        public static bool NET_DVR_SetVideoEffect(int lUserID, int lChannel, uint dwBrightValue, uint dwContrastValue, uint dwSaturationValue, uint dwHueValue)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetVideoEffect(lUserID, lChannel, dwBrightValue, dwContrastValue, dwSaturationValue, dwHueValue);
            else
                return Methods_Linux.NET_DVR_SetVideoEffect(lUserID, lChannel, dwBrightValue, dwContrastValue, dwSaturationValue, dwHueValue);
        }
        public static bool NET_DVR_GetVideoEffect(int lUserID, int lChannel, ref uint pBrightValue, ref uint pContrastValue, ref uint pSaturationValue, ref uint pHueValue)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetVideoEffect(lUserID, lChannel, ref pBrightValue, ref pContrastValue, ref pSaturationValue, ref pHueValue);
            else
                return Methods_Linux.NET_DVR_GetVideoEffect(lUserID, lChannel, ref pBrightValue, ref pContrastValue, ref pSaturationValue, ref pHueValue);
        }
        public static bool NET_DVR_ClientGetframeformat(int lUserID, ref NET_DVR_FRAMEFORMAT lpFrameFormat)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_ClientGetframeformat(lUserID, ref lpFrameFormat);
            else
                return Methods_Linux.NET_DVR_ClientGetframeformat(lUserID, ref lpFrameFormat);
        }
        public static bool NET_DVR_ClientSetframeformat(int lUserID, ref NET_DVR_FRAMEFORMAT lpFrameFormat)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_ClientSetframeformat(lUserID, ref lpFrameFormat);
            else
                return Methods_Linux.NET_DVR_ClientSetframeformat(lUserID, ref lpFrameFormat);
        }
        public static bool NET_DVR_GetAtmProtocol(int lUserID, ref NET_DVR_ATM_PROTOCOL lpAtmProtocol)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetAtmProtocol(lUserID, ref lpAtmProtocol);
            else
                return Methods_Linux.NET_DVR_GetAtmProtocol(lUserID, ref lpAtmProtocol);
        }
        public static bool NET_DVR_GetAlarmOut_V30(int lUserID, IntPtr lpAlarmOutState)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetAlarmOut_V30(lUserID, lpAlarmOutState);
            else
                return Methods_Linux.NET_DVR_GetAlarmOut_V30(lUserID, lpAlarmOutState);
        }
        public static bool NET_DVR_GetAlarmOut(int lUserID, ref NET_DVR_ALARMOUTSTATUS lpAlarmOutState)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetAlarmOut(lUserID, ref lpAlarmOutState);
            else
                return Methods_Linux.NET_DVR_GetAlarmOut(lUserID, ref lpAlarmOutState);
        }
        public static bool NET_DVR_SetAlarmOut(int lUserID, int lAlarmOutPort, int lAlarmOutStatic)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetAlarmOut(lUserID, lAlarmOutPort, lAlarmOutStatic);
            else
                return Methods_Linux.NET_DVR_SetAlarmOut(lUserID, lAlarmOutPort, lAlarmOutStatic);
        }
        public static bool NET_DVR_GetUpnpNatState(int lUserID, ref NET_DVR_UPNP_NAT_STATE lpState)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetUpnpNatState(lUserID, ref lpState);
            else
                return Methods_Linux.NET_DVR_GetUpnpNatState(lUserID, ref lpState);
        }
        public static bool NET_DVR_ClientSetVideoEffect(int lRealHandle, uint dwBrightValue, uint dwContrastValue, uint dwSaturationValue, uint dwHueValue)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_ClientSetVideoEffect(lRealHandle, dwBrightValue, dwContrastValue, dwSaturationValue, dwHueValue);
            else
                return Methods_Linux.NET_DVR_ClientSetVideoEffect(lRealHandle, dwBrightValue, dwContrastValue, dwSaturationValue, dwHueValue);
        }
        public static int NET_DVR_FindNextLog_V50(int lLogHandle, ref NET_DVR_LOG_V50 lpLogData)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_FindNextLog_V50(lLogHandle, ref lpLogData);
            else
                return Methods_Linux.NET_DVR_FindNextLog_V50(lLogHandle, ref lpLogData);
        }
        public static bool NET_DVR_ClientGetVideoEffect(int lRealHandle, ref uint pBrightValue, ref uint pContrastValue, ref uint pSaturationValue, ref uint pHueValue)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_ClientGetVideoEffect(lRealHandle, ref pBrightValue, ref pContrastValue, ref pSaturationValue, ref pHueValue);
            else
                return Methods_Linux.NET_DVR_ClientGetVideoEffect(lRealHandle, ref pBrightValue, ref pContrastValue, ref pSaturationValue, ref pHueValue);
        }
        public static bool NET_DVR_GetConfigFile(int lUserID, string sFileName)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetConfigFile(lUserID, sFileName);
            else
                return Methods_Linux.NET_DVR_GetConfigFile(lUserID, sFileName);
        }
        public static bool NET_DVR_SetConfigFile(int lUserID, string sFileName)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetConfigFile(lUserID, sFileName);
            else
                return Methods_Linux.NET_DVR_SetConfigFile(lUserID, sFileName);
        }
        public static bool NET_DVR_GetConfigFile_V30(int lUserID, string sOutBuffer, uint dwOutSize, ref uint pReturnSize)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetConfigFile_V30(lUserID, sOutBuffer, dwOutSize, ref pReturnSize);
            else
                return Methods_Linux.NET_DVR_GetConfigFile_V30(lUserID, sOutBuffer, dwOutSize, ref pReturnSize);
        }
        public static bool NET_DVR_GetConfigFile_EX(int lUserID, string sOutBuffer, uint dwOutSize)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetConfigFile_EX(lUserID, sOutBuffer, dwOutSize);
            else
                return Methods_Linux.NET_DVR_GetConfigFile_EX(lUserID, sOutBuffer, dwOutSize);
        }
        public static bool NET_DVR_SetConfigFile_EX(int lUserID, string sInBuffer, uint dwInSize)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetConfigFile_EX(lUserID, sInBuffer, dwInSize);
            else
                return Methods_Linux.NET_DVR_SetConfigFile_EX(lUserID, sInBuffer, dwInSize);
        }
        public static bool NET_DVR_SetLogToFile(int bLogEnable, string strLogDir, bool bAutoDel)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetLogToFile(bLogEnable, strLogDir, bAutoDel);
            else
                return Methods_Linux.NET_DVR_SetLogToFile(bLogEnable, strLogDir, bAutoDel);
        }
        public static bool NET_DVR_GetSDKState(ref NET_DVR_SDKSTATE pSDKState)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetSDKState(ref pSDKState);
            else
                return Methods_Linux.NET_DVR_GetSDKState(ref pSDKState);
        }
        public static bool NET_DVR_GetSDKAbility(ref NET_DVR_SDKABL pSDKAbl)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetSDKAbility(ref pSDKAbl);
            else
                return Methods_Linux.NET_DVR_GetSDKAbility(ref pSDKAbl);
        }
        public static bool NET_DVR_GetPTZProtocol(int lUserID, ref NET_DVR_PTZCFG pPtzcfg)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetPTZProtocol(lUserID, ref pPtzcfg);
            else
                return Methods_Linux.NET_DVR_GetPTZProtocol(lUserID, ref pPtzcfg);
        }
        public static bool NET_DVR_LockPanel(int lUserID)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_LockPanel(lUserID);
            else
                return Methods_Linux.NET_DVR_LockPanel(lUserID);
        }
        public static bool NET_DVR_UnLockPanel(int lUserID)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_UnLockPanel(lUserID);
            else
                return Methods_Linux.NET_DVR_UnLockPanel(lUserID);
        }
        public static bool NET_DVR_SetRtspConfig(int lUserID, uint dwCommand, ref NET_DVR_RTSPCFG lpInBuffer, uint dwInBufferSize)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetRtspConfig(lUserID, dwCommand, ref lpInBuffer, dwInBufferSize);
            else
                return Methods_Linux.NET_DVR_SetRtspConfig(lUserID, dwCommand, ref lpInBuffer, dwInBufferSize);
        }
        public static bool NET_DVR_GetRtspConfig(int lUserID, uint dwCommand, ref NET_DVR_RTSPCFG lpOutBuffer, uint dwOutBufferSize)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetRtspConfig(lUserID, dwCommand, ref lpOutBuffer, dwOutBufferSize);
            else
                return Methods_Linux.NET_DVR_GetRtspConfig(lUserID, dwCommand, ref lpOutBuffer, dwOutBufferSize);
        }
        public static bool NET_DVR_MatrixGetSceneCfg(int lUserID, uint dwSceneNum, ref NET_DVR_MATRIX_SCENECFG lpSceneCfg)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixGetSceneCfg(lUserID, dwSceneNum, ref lpSceneCfg);
            else
                return Methods_Linux.NET_DVR_MatrixGetSceneCfg(lUserID, dwSceneNum, ref lpSceneCfg);
        }
        public static bool NET_DVR_MatrixSetSceneCfg(int lUserID, uint dwSceneNum, ref NET_DVR_MATRIX_SCENECFG lpSceneCfg)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_MatrixSetSceneCfg(lUserID, dwSceneNum, ref lpSceneCfg);
            else
                return Methods_Linux.NET_DVR_MatrixSetSceneCfg(lUserID, dwSceneNum, ref lpSceneCfg);
        }
        public static bool NET_DVR_GetRealHeight(int lUserID, int lChannel, ref NET_VCA_LINE lpLine, ref Single lpHeight)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetRealHeight(lUserID, lChannel, ref lpLine, ref lpHeight);
            else
                return Methods_Linux.NET_DVR_GetRealHeight(lUserID, lChannel, ref lpLine, ref lpHeight);
        }
        public static bool NET_DVR_GetRealLength(int lUserID, int lChannel, ref NET_VCA_LINE lpLine, ref Single lpLength)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetRealLength(lUserID, lChannel, ref lpLine, ref lpLength);
            else
                return Methods_Linux.NET_DVR_GetRealLength(lUserID, lChannel, ref lpLine, ref lpLength);
        }
        public static bool NET_DVR_SaveRealData_V30(int lRealHandle, uint dwTransType, string sFileName)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SaveRealData_V30(lRealHandle, dwTransType, sFileName);
            else
                return Methods_Linux.NET_DVR_SaveRealData_V30(lRealHandle, dwTransType, sFileName);
        }
        public static IntPtr NET_DVR_InitG711Encoder(ref NET_DVR_AUDIOENC_INFO enc_info)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_InitG711Encoder(ref enc_info);
            else
                return Methods_Linux.NET_DVR_InitG711Encoder(ref enc_info);
        }
        public static bool NET_DVR_EncodeG711Frame(IntPtr handle, ref NET_DVR_AUDIOENC_PROCESS_PARAM p_enc_proc_param)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_EncodeG711Frame(handle, ref p_enc_proc_param);
            else
                return Methods_Linux.NET_DVR_EncodeG711Frame(handle, ref p_enc_proc_param);
        }
        public static bool NET_DVR_ReleaseG711Encoder(IntPtr pEncodeHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_ReleaseG711Encoder(pEncodeHandle);
            else
                return Methods_Linux.NET_DVR_ReleaseG711Encoder(pEncodeHandle);
        }
        public static bool NET_DVR_DecodeG711Frame(uint iType, ref byte pInBuffer, ref byte pOutBuffer)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_DecodeG711Frame(iType, ref pInBuffer, ref pOutBuffer);
            else
                return Methods_Linux.NET_DVR_DecodeG711Frame(iType, ref pInBuffer, ref pOutBuffer);
        }
        public static bool NET_DVR_EmailTest(int lUserID)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_EmailTest(lUserID);
            else
                return Methods_Linux.NET_DVR_EmailTest(lUserID);
        }
        public static int NET_DVR_FindFileByEvent(int lUserID, ref NET_DVR_SEARCH_EVENT_PARAM lpSearchEventParam)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_FindFileByEvent(lUserID, ref lpSearchEventParam);
            else
                return Methods_Linux.NET_DVR_FindFileByEvent(lUserID, ref lpSearchEventParam);
        }
        public static int NET_DVR_FindNextEvent(int lSearchHandle, ref NET_DVR_SEARCH_EVENT_RET lpSearchEventRet)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_FindNextEvent(lSearchHandle, ref lpSearchEventRet);
            else
                return Methods_Linux.NET_DVR_FindNextEvent(lSearchHandle, ref lpSearchEventRet);
        }
        public static Int32 NET_DVR_Login_V30(string sDVRIP, Int32 wDVRPort, string sUserName, string sPassword, ref NET_DVR_DEVICEINFO_V30 lpDeviceInfo)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_Login_V30(sDVRIP, wDVRPort, sUserName, sPassword, ref lpDeviceInfo);
            else
                return Methods_Linux.NET_DVR_Login_V30(sDVRIP, wDVRPort, sUserName, sPassword, ref lpDeviceInfo);
        }
        public static int NET_DVR_Login_V40(ref NET_DVR_USER_LOGIN_INFO pLoginInfo, ref NET_DVR_DEVICEINFO_V40 lpDeviceInfo)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_Login_V40(ref pLoginInfo, ref lpDeviceInfo);
            else
                return Methods_Linux.NET_DVR_Login_V40(ref pLoginInfo, ref lpDeviceInfo);
        }
        public static bool NET_DVR_Logout_V30(Int32 lUserID)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_Logout_V30(lUserID);
            else
                return Methods_Linux.NET_DVR_Logout_V30(lUserID);
        }
        public static int NET_DVR_FindNextLog_MATRIX(int iLogHandle, ref NET_DVR_LOG_MATRIX lpLogData)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_FindNextLog_MATRIX(iLogHandle, ref lpLogData);
            else
                return Methods_Linux.NET_DVR_FindNextLog_MATRIX(iLogHandle, ref lpLogData);
        }
        public static int NET_DVR_FindDVRLog_Matrix(int iUserID, int lSelectMode, uint dwMajorType, uint dwMinorType, ref tagVEDIOPLATLOG lpVedioPlatLog, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_FindDVRLog_Matrix(iUserID, lSelectMode, dwMajorType, dwMinorType, ref lpVedioPlatLog, ref lpStartTime, ref lpStopTime);
            else
                return Methods_Linux.NET_DVR_FindDVRLog_Matrix(iUserID, lSelectMode, dwMajorType, dwMinorType, ref lpVedioPlatLog, ref lpStartTime, ref lpStopTime);
        }
        public static bool NET_DVR_STDXMLConfig(int iUserID, ref NET_DVR_XML_CONFIG_INPUT lpInputParam, ref NET_DVR_XML_CONFIG_OUTPUT lpOutputParam)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_STDXMLConfig(iUserID, ref lpInputParam, ref lpOutputParam);
            else
                return Methods_Linux.NET_DVR_STDXMLConfig(iUserID, ref lpInputParam, ref lpOutputParam);
        }
        public static bool NET_DVR_GetDeviceConfig(int lUserID, uint dwCommand, uint dwCount, IntPtr lpInBuffer, uint dwInBufferSize, IntPtr lpStatusList, IntPtr lpOutBuffer, uint dwOutBufferSize)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetDeviceConfig(lUserID, dwCommand, dwCount, lpInBuffer, dwInBufferSize, lpStatusList, lpOutBuffer, dwOutBufferSize);
            else
                return Methods_Linux.NET_DVR_GetDeviceConfig(lUserID, dwCommand, dwCount, lpInBuffer, dwInBufferSize, lpStatusList, lpOutBuffer, dwOutBufferSize);
        }
        public static bool NET_DVR_SetDeviceConfig(int lUserID, uint dwCommand, uint dwCount, IntPtr lpInBuffer, uint dwInBufferSize, IntPtr lpStatusList, IntPtr lpInParamBuffer, uint dwInParamBufferSize)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetDeviceConfig(lUserID, dwCommand, dwCount, lpInBuffer, dwInBufferSize, lpStatusList, lpInParamBuffer, dwInParamBufferSize);
            else
                return Methods_Linux.NET_DVR_SetDeviceConfig(lUserID, dwCommand, dwCount, lpInBuffer, dwInBufferSize, lpStatusList, lpInParamBuffer, dwInParamBufferSize);
        }
        public static bool NET_DVR_SetDeviceConfigEx(Int32 lUserID, uint dwCommand, uint dwCount, ref NET_DVR_IN_PARAM lpInParam, ref NET_DVR_OUT_PARAM lpOutParam)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetDeviceConfigEx(lUserID, dwCommand, dwCount, ref lpInParam, ref lpOutParam);
            else
                return Methods_Linux.NET_DVR_SetDeviceConfigEx(lUserID, dwCommand, dwCount, ref lpInParam, ref lpOutParam);
        }
        public static bool NET_DVR_GetSTDConfig(int iUserID, uint dwCommand, ref NET_DVR_STD_CONFIG lpConfigParam)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetSTDConfig(iUserID, dwCommand, ref lpConfigParam);
            else
                return Methods_Linux.NET_DVR_GetSTDConfig(iUserID, dwCommand, ref lpConfigParam);
        }
        public static bool NET_DVR_SetSTDConfig(int iUserID, uint dwCommand, ref NET_DVR_STD_CONFIG lpConfigParam)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetSTDConfig(iUserID, dwCommand, ref lpConfigParam);
            else
                return Methods_Linux.NET_DVR_SetSTDConfig(iUserID, dwCommand, ref lpConfigParam);
        }
        public static int NET_DVR_StartRemoteConfig(int lUserID, int dwCommand, IntPtr lpInBuffer, Int32 dwInBufferLen, RemoteConfigCallback cbStateCallback, IntPtr pUserData)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_StartRemoteConfig(lUserID, dwCommand, lpInBuffer, dwInBufferLen, cbStateCallback, pUserData);
            else
                return Methods_Linux.NET_DVR_StartRemoteConfig(lUserID, dwCommand, lpInBuffer, dwInBufferLen, cbStateCallback, pUserData);
        }
        public static int NET_DVR_GetNextRemoteConfig(int lHandle, IntPtr lpOutBuff, int dwOutBuffSize)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetNextRemoteConfig(lHandle, lpOutBuff, dwOutBuffSize);
            else
                return Methods_Linux.NET_DVR_GetNextRemoteConfig(lHandle, lpOutBuff, dwOutBuffSize);
        }
        public static bool NET_DVR_SendRemoteConfig(int lHandle, int dwDataType, IntPtr pSendBuf, int dwBufSize)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SendRemoteConfig(lHandle, dwDataType, pSendBuf, dwBufSize);
            else
                return Methods_Linux.NET_DVR_SendRemoteConfig(lHandle, dwDataType, pSendBuf, dwBufSize);
        }
        public static bool NET_DVR_StopRemoteConfig(int lHandle)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_StopRemoteConfig(lHandle);
            else
                return Methods_Linux.NET_DVR_StopRemoteConfig(lHandle);
        }
        public static bool NET_DVR_RemoteControl(int lUserID, int dwCommand, IntPtr lpInBuffer, int dwInBufferSize)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_RemoteControl(lUserID, dwCommand, lpInBuffer, dwInBufferSize);
            else
                return Methods_Linux.NET_DVR_RemoteControl(lUserID, dwCommand, lpInBuffer, dwInBufferSize);
        }
        public static bool NET_DVR_RemoteControl(int lUserID, int dwCommand, ref NET_DVR_FACE_PARAM_CTRL_CARDNO lpInBuffer, int dwInBufferSize)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_RemoteControl(lUserID, dwCommand, ref lpInBuffer, dwInBufferSize);
            else
                return Methods_Linux.NET_DVR_RemoteControl(lUserID, dwCommand, ref lpInBuffer, dwInBufferSize);
        }
        public static bool NET_DVR_ContinuousShoot(Int32 lUserID, ref NET_DVR_SNAPCFG lpInter)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_ContinuousShoot(lUserID, ref lpInter);
            else
                return Methods_Linux.NET_DVR_ContinuousShoot(lUserID, ref lpInter);
        }
        public static bool NET_DVR_ManualSnap(Int32 lUserID, ref NET_DVR_MANUALSNAP lpInter, ref NET_DVR_PLATE_RESULT lpOuter)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_ManualSnap(lUserID, ref lpInter, ref lpOuter);
            else
                return Methods_Linux.NET_DVR_ManualSnap(lUserID, ref lpInter, ref lpOuter);
        }
        public static bool NET_DVR_GetDeviceAbility(int lUserID, uint dwAbilityType, IntPtr pInBuf, uint dwInLength, IntPtr pOutBuf, uint dwOutLength)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetDeviceAbility(lUserID, dwAbilityType, pInBuf, dwInLength, pOutBuf, dwOutLength);
            else
                return Methods_Linux.NET_DVR_GetDeviceAbility(lUserID, dwAbilityType, pInBuf, dwInLength, pOutBuf, dwOutLength);
        }
        public static bool NET_DVR_SetBehaviorParamKey(int lUserID, int lChannel, uint dwParameterKey, int nValue)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetBehaviorParamKey(lUserID, lChannel, dwParameterKey, nValue);
            else
                return Methods_Linux.NET_DVR_SetBehaviorParamKey(lUserID, lChannel, dwParameterKey, nValue);
        }
        public static bool NET_DVR_GetBehaviorParamKey(int lUserID, int lChannel, uint dwParameterKey, ref int pValue)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetBehaviorParamKey(lUserID, lChannel, dwParameterKey, ref pValue);
            else
                return Methods_Linux.NET_DVR_GetBehaviorParamKey(lUserID, lChannel, dwParameterKey, ref pValue);
        }
        public static bool NET_DVR_GetVCADrawMode(int lUserID, int lChannel, ref NET_VCA_DRAW_MODE lpDrawMode)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetVCADrawMode(lUserID, lChannel, ref lpDrawMode);
            else
                return Methods_Linux.NET_DVR_GetVCADrawMode(lUserID, lChannel, ref lpDrawMode);
        }

        public static int NET_DVR_FindDVRLog_V50(int lUserID, ref NET_DVR_FIND_LOG_COND pFindCond)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_FindDVRLog_V50(lUserID, ref pFindCond);
            else
                return Methods_Linux.NET_DVR_FindDVRLog_V50(lUserID, ref pFindCond);
        }
        public static bool NET_DVR_SetVCADrawMode(int lUserID, int lChannel, ref NET_VCA_DRAW_MODE lpDrawMode)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetVCADrawMode(lUserID, lChannel, ref lpDrawMode);
            else
                return Methods_Linux.NET_DVR_SetVCADrawMode(lUserID, lChannel, ref lpDrawMode);
        }
        public static bool NET_DVR_SetLFTrackMode(int lUserID, int lChannel, ref NET_DVR_LF_TRACK_MODE lpTrackMode)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetLFTrackMode(lUserID, lChannel, ref lpTrackMode);
            else
                return Methods_Linux.NET_DVR_SetLFTrackMode(lUserID, lChannel, ref lpTrackMode);
        }
        public static bool NET_DVR_GetLFTrackMode(int lUserID, int lChannel, ref NET_DVR_LF_TRACK_MODE lpTrackMode)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetLFTrackMode(lUserID, lChannel, ref lpTrackMode);
            else
                return Methods_Linux.NET_DVR_GetLFTrackMode(lUserID, lChannel, ref lpTrackMode);
        }
        public static bool NET_DVR_GetCCDCfg(int lUserID, int lChannel, ref NET_DVR_CCD_CFG lpCCDCfg)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetCCDCfg(lUserID, lChannel, ref lpCCDCfg);
            else
                return Methods_Linux.NET_DVR_GetCCDCfg(lUserID, lChannel, ref lpCCDCfg);
        }
        public static bool NET_DVR_SetCCDCfg(int lUserID, int lChannel, ref NET_DVR_CCD_CFG lpCCDCfg)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_SetCCDCfg(lUserID, lChannel, ref lpCCDCfg);
            else
                return Methods_Linux.NET_DVR_SetCCDCfg(lUserID, lChannel, ref lpCCDCfg);
        }
        public static bool NET_DVR_GetParamSetMode(int lUserID, ref uint dwParamSetMode)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_GetParamSetMode(lUserID, ref dwParamSetMode);
            else
                return Methods_Linux.NET_DVR_GetParamSetMode(lUserID, ref dwParamSetMode);
        }
        public static bool NET_DVR_InquestStartCDW_V30(int lUserID, ref NET_DVR_INQUEST_ROOM lpInquestRoom, bool bNotBurn)
        {
            if (IsWindows)
                return Methods_Win.NET_DVR_InquestStartCDW_V30(lUserID, ref lpInquestRoom, bNotBurn);
            else
                return Methods_Linux.NET_DVR_InquestStartCDW_V30(lUserID, ref lpInquestRoom, bNotBurn);
        }
        public static int PostMessage(IntPtr hWnd, int Msg, int wParam, int lParam)
        {
            if (IsWindows)
                return Methods_Win.PostMessage(hWnd, Msg, wParam, lParam);
            else
                return Methods_Linux.PostMessage(hWnd, Msg, wParam, lParam);
        }
        public static bool NET_VCA_RestartLib(int lUserID, int lChannel)
        {
            if (IsWindows)
                return Methods_Win.NET_VCA_RestartLib(lUserID, lChannel);
            else
                return Methods_Linux.NET_VCA_RestartLib(lUserID, lChannel);
        }
    }
}
