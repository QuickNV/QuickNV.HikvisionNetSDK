using System;
using System.Runtime.InteropServices;
using static QuickNV.HikvisionNetSDK.Defines;

namespace QuickNV.HikvisionNetSDK
{
    internal class Methods_Win
    {
        public const string DllPath = "HCNetSDK.dll";

        [DllImport(DllPath)]
        public static extern int NET_DVR_SendWithRecvRemoteConfig(int lHandle, IntPtr lpInBuff, uint dwInBuffSize, IntPtr lpOutBuff, uint dwOutBuffSize, ref uint dwOutDataLen);
        [DllImport(DllPath)]
        public static extern int NET_DVR_SendWithRecvRemoteConfig(int lHandle, ref NET_DVR_FACE_RECORD lpInBuff, int dwInBuffSize, ref NET_DVR_FACE_STATUS lpOutBuff, int dwOutBuffSize, IntPtr dwOutDataLen);
        [DllImport(DllPath)]
        public static extern int NET_DVR_SendWithRecvRemoteConfig(int lHandle, ref NET_DVR_FINGERPRINT_RECORD lpInBuff, int dwInBuffSize, ref NET_DVR_FINGERPRINT_STATUS lpOutBuff, int dwOutBuffSize, IntPtr dwOutDataLen);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_STDXMLConfig(int lUserID, IntPtr lpInputParam, IntPtr lpOutputParam);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_ControlGateway(int lUserID, int lGatewayIndex, uint dwStaic);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetDVRMessageCallBack_V50(int iIndex, MSGCallBack fMessageCallBack, IntPtr pUser);
        [DllImport(DllPath)]
        public static extern int NET_DVR_GetNextRemoteConfig(int lHandle, ref NET_DVR_CAPTURE_FACE_CFG lpOutBuff, int dwOutBuffSize);
        [DllImport(DllPath)]
        public static extern int NET_DVR_GetNextRemoteConfig(int lHandle, ref NET_DVR_FINGER_PRINT_INFO_STATUS_V50 lpOutBuff, int dwOutBuffSize);
        [DllImport(DllPath)]
        public static extern int NET_DVR_GetNextRemoteConfig(int lHandle, ref NET_DVR_ACS_EVENT_CFG lpOutBuff, int dwOutBuffSize);
        [DllImport(DllPath)]
        public static extern int NET_DVR_GetNextRemoteConfig(int lHandle, ref NET_DVR_FINGERPRINT_RECORD lpOutBuff, int dwOutBuffSize);
        [DllImport(DllPath)]
        public static extern int NET_DVR_GetNextRemoteConfig(int lHandle, ref NET_DVR_CAPTURE_FINGERPRINT_CFG lpOutBuff, int dwOutBuffSize);
        [DllImport(DllPath)]
        public static extern int NET_DVR_GetNextRemoteConfig(int lHandle, ref NET_DVR_FACE_RECORD lpOutBuff, int dwOutBuffSize);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_Init();
        [DllImport(DllPath)]
        public static extern bool NET_DVR_Cleanup();
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetDVRMessage(uint nMessage, IntPtr hWnd);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetExceptionCallBack_V30(uint nMessage, IntPtr hWnd, EXCEPYIONCALLBACK fExceptionCallBack, IntPtr pUser);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetDVRMessCallBack(MESSCALLBACK fMessCallBack);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetDVRMessCallBack_EX(MESSCALLBACKEX fMessCallBack_EX);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetDVRMessCallBack_NEW(MESSCALLBACKNEW fMessCallBack_NEW);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetDVRMessageCallBack(MESSAGECALLBACK fMessageCallBack, uint dwUser);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetDVRMessageCallBack_V30(MSGCallBack fMessageCallBack, IntPtr pUser);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetDVRMessageCallBack_V31(MSGCallBack_V31 fMessageCallBack, IntPtr pUser);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetSDKLocalCfg(int enumType, IntPtr lpInBuff);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetSDKLocalCfg(int enumType, IntPtr lpOutBuff);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetConnectTime(uint dwWaitTime, uint dwTryTimes);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetReconnect(uint dwInterval, int bEnableRecon);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetLocalIP(byte[] strIP, ref uint pValidNum, ref Boolean pEnableBind);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetValidIP(uint dwIPIndex, Boolean bEnableBind);
        [DllImport(DllPath)]
        public static extern uint NET_DVR_GetSDKVersion();
        [DllImport(DllPath)]
        public static extern uint NET_DVR_GetSDKBuildVersion();
        [DllImport(DllPath)]
        public static extern Int32 NET_DVR_IsSupport();
        [DllImport(DllPath)]
        public static extern bool NET_DVR_StartListen(string sLocalIP, ushort wLocalPort);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_StopListen();
        [DllImport(DllPath)]
        public static extern int NET_DVR_StartListen_V30(String sLocalIP, ushort wLocalPort, MSGCallBack DataCallback, IntPtr pUserData);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_StopListen_V30(Int32 lListenHandle);
        [DllImport(DllPath)]
        public static extern Int32 NET_DVR_Login(string sDVRIP, ushort wDVRPort, string sUserName, string sPassword, ref NET_DVR_DEVICEINFO lpDeviceInfo);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_Logout(int iUserID);
        [DllImport(DllPath)]
        public static extern uint NET_DVR_GetLastError();
        [DllImport(DllPath)]
        public static extern IntPtr NET_DVR_GetErrorMsg(ref int pErrorNo);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetShowMode(uint dwShowType, uint colorKey);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetDVRIPByResolveSvr(string sServerIP, ushort wServerPort, string sDVRName, ushort wDVRNameLen, string sDVRSerialNumber, ushort wDVRSerialLen, IntPtr pGetIP);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetDVRIPByResolveSvr_EX(string sServerIP, ushort wServerPort, byte[] sDVRName, ushort wDVRNameLen, byte[] sDVRSerialNumber, ushort wDVRSerialLen, byte[] sGetIP, ref uint dwPort);
        [DllImport(DllPath)]
        public static extern Int32 NET_DVR_RealPlay(int iUserID, ref NET_DVR_CLIENTINFO lpClientInfo);
        [DllImport(DllPath)]
        public static extern Int32 NET_SDK_RealPlay(int iUserLogID, ref NET_DVR_CLIENTINFO lpDVRClientInfo);
        [DllImport(DllPath)]

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
        public static extern int NET_DVR_RealPlay_V30(int iUserID, ref NET_DVR_CLIENTINFO lpClientInfo, REALDATACALLBACK fRealDataCallBack_V30, IntPtr pUser, UInt32 bBlocked);
        [DllImport(DllPath)]
        public static extern int NET_DVR_RealPlay_V40(int iUserID, ref NET_DVR_PREVIEWINFO lpPreviewInfo, REALDATACALLBACK fRealDataCallBack_V30, IntPtr pUser);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_StopRealPlay(int iRealHandle);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_RigisterDrawFun(int lRealHandle, DRAWFUN fDrawFun, uint dwUser);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetPlayerBufNumber(Int32 lRealHandle, uint dwBufNum);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_ThrowBFrame(Int32 lRealHandle, uint dwNum);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetAudioMode(uint dwMode);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_OpenSound(Int32 lRealHandle);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_CloseSound();
        [DllImport(DllPath)]
        public static extern bool NET_DVR_OpenSoundShare(Int32 lRealHandle);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_CloseSoundShare(Int32 lRealHandle);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_Volume(Int32 lRealHandle, ushort wVolume);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SaveRealData(Int32 lRealHandle, string sFileName);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_StopSaveRealData(Int32 lRealHandle);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetRealDataCallBack(int lRealHandle, SETREALDATACALLBACK fRealDataCallBack, uint dwUser);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetStandardDataCallBack(int lRealHandle, STDDATACALLBACK fStdDataCallBack, uint dwUser);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_CapturePicture(Int32 lRealHandle, string sPicFileName);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_CapturePictureBlock(Int32 lRealHandle, string sPicFileName, int dwTimeOut);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MakeKeyFrame(Int32 lUserID, Int32 lChannel);//主码流
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MakeKeyFrameSub(Int32 lUserID, Int32 lChannel);//子码流
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetPTZCtrl(Int32 lRealHandle);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetPTZCtrl_Other(Int32 lUserID, int lChannel);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_PTZControl(Int32 lRealHandle, uint dwPTZCommand, uint dwStop);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_PTZControl_Other(Int32 lUserID, Int32 lChannel, uint dwPTZCommand, uint dwStop);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_TransPTZ(Int32 lRealHandle, string pPTZCodeBuf, uint dwBufSize);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_TransPTZ_Other(int lUserID, int lChannel, string pPTZCodeBuf, uint dwBufSize);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_PTZPreset(int lRealHandle, uint dwPTZPresetCmd, uint dwPresetIndex);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_PTZPreset_Other(int lUserID, int lChannel, uint dwPTZPresetCmd, uint dwPresetIndex);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_TransPTZ_EX(int lRealHandle, string pPTZCodeBuf, uint dwBufSize);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_PTZControl_EX(int lRealHandle, uint dwPTZCommand, uint dwStop);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_PTZPreset_EX(int lRealHandle, uint dwPTZPresetCmd, uint dwPresetIndex);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_PTZCruise(int lRealHandle, uint dwPTZCruiseCmd, byte byCruiseRoute, byte byCruisePoint, ushort wInput);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_PTZCruise_Other(int lUserID, int lChannel, uint dwPTZCruiseCmd, byte byCruiseRoute, byte byCruisePoint, ushort wInput);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_PTZCruise_EX(int lRealHandle, uint dwPTZCruiseCmd, byte byCruiseRoute, byte byCruisePoint, ushort wInput);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_PTZTrack(int lRealHandle, uint dwPTZTrackCmd);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_PTZTrack_Other(int lUserID, int lChannel, uint dwPTZTrackCmd);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_PTZTrack_EX(int lRealHandle, uint dwPTZTrackCmd);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_PTZControlWithSpeed(int lRealHandle, uint dwPTZCommand, uint dwStop, uint dwSpeed);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_PTZControlWithSpeed_Other(int lUserID, int lChannel, uint dwPTZCommand, uint dwStop, uint dwSpeed);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_PTZControlWithSpeed_EX(int lRealHandle, uint dwPTZCommand, uint dwStop, uint dwSpeed);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetPTZCruise(int lUserID, int lChannel, int lCruiseRoute, ref NET_DVR_CRUISE_RET lpCruiseRet);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_PTZMltTrack(int lRealHandle, uint dwPTZTrackCmd, uint dwTrackIndex);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_PTZMltTrack_Other(int lUserID, int lChannel, uint dwPTZTrackCmd, uint dwTrackIndex);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_PTZMltTrack_EX(int lRealHandle, uint dwPTZTrackCmd, uint dwTrackIndex);
        [DllImport(DllPath)]
        public static extern int NET_DVR_FindFile(int lUserID, int lChannel, uint dwFileType, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime);
        [DllImport(DllPath)]
        public static extern int NET_DVR_FindNextFile(int lFindHandle, ref NET_DVR_FIND_DATA lpFindData);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_FindClose(int lFindHandle);
        [DllImport(DllPath)]
        public static extern int NET_DVR_FindNextFile_V30(int lFindHandle, ref NET_DVR_FINDDATA_V30 lpFindData);
        [DllImport(DllPath)]
        public static extern int NET_DVR_FindNextFile_V40(int lFindHandle, ref NET_DVR_FINDDATA_V40 lpFindData);
        [DllImport(DllPath)]
        public static extern int NET_DVR_FindFile_V30(int lUserID, ref NET_DVR_FILECOND pFindCond);
        [DllImport(DllPath)]
        public static extern int NET_DVR_FindFile_V40(int lUserID, ref NET_DVR_FILECOND_V40 pFindCond);
        [DllImport(DllPath)]
        public static extern int NET_DVR_FindFileByEvent_V40(int lUserID, ref NET_DVR_SEARCH_EVENT_PARAM_V40 lpSearchEventParam);
        [DllImport(DllPath)]
        public static extern int NET_DVR_FindNextEvent_V40(int lSearchHandle, ref NET_DVR_SEARCH_EVENT_RET_V40 lpSearchEventRet);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_FindClose_V30(int lFindHandle);
        [DllImport(DllPath)]
        public static extern int NET_DVR_FindNextFile_Card(int lFindHandle, ref NET_DVR_FINDDATA_CARD lpFindData);
        [DllImport(DllPath)]
        public static extern int NET_DVR_FindFile_Card(int lUserID, int lChannel, uint dwFileType, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_LockFileByName(int lUserID, string sLockFileName);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_UnlockFileByName(int lUserID, string sUnlockFileName);
        [DllImport(DllPath)]
        public static extern int NET_DVR_PlayBackByName(int lUserID, string sPlayBackFileName, IntPtr hWnd);
        [DllImport(DllPath)]
        public static extern int NET_DVR_PlayBackByTime(int lUserID, int lChannel, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime, System.IntPtr hWnd);
        [DllImport(DllPath)]
        public static extern int NET_DVR_PlayBackByTime_V40(int lUserID, ref NET_DVR_VOD_PARA pVodPara);
        [DllImport(DllPath)]
        public static extern int NET_DVR_PlayBackReverseByName(int lUserID, string sPlayBackFileName, IntPtr hWnd);
        [DllImport(DllPath)]
        public static extern int NET_DVR_PlayBackReverseByTime_V40(int lUserID, IntPtr hWnd, ref NET_DVR_PLAYCOND pPlayCond);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_PlayBackControl(int lPlayHandle, uint dwControlCode, uint dwInValue, ref uint LPOutValue);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_PlayBackControl_V40(int lPlayHandle, uint dwControlCode, IntPtr lpInBuffer, uint dwInValue, IntPtr lpOutBuffer, ref uint LPOutValue);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_StopPlayBack(int lPlayHandle);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetPlayDataCallBack(int lPlayHandle, PLAYDATACALLBACK fPlayDataCallBack, uint dwUser);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_PlayBackSaveData(int lPlayHandle, string sFileName);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_StopPlayBackSave(int lPlayHandle);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetPlayBackOsdTime(int lPlayHandle, ref NET_DVR_TIME lpOsdTime);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_PlayBackCaptureFile(int lPlayHandle, string sFileName);
        [DllImport(DllPath)]
        public static extern int NET_DVR_GetFileByName(int lUserID, string sDVRFileName, string sSavedFileName);
        [DllImport(DllPath)]
        public static extern int NET_DVR_GetFileByTime(int lUserID, int lChannel, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime, string sSavedFileName);
        [DllImport(DllPath)]
        public static extern int NET_DVR_GetFileByTime_V40(int lUserID, string sSavedFileName, ref NET_DVR_PLAYCOND pDownloadCond);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_StopGetFile(int lFileHandle);
        [DllImport(DllPath)]
        public static extern int NET_DVR_GetDownloadPos(int lFileHandle);
        [DllImport(DllPath)]
        public static extern int NET_DVR_GetPlayBackPos(int lPlayHandle);
        [DllImport(DllPath)]
        public static extern int NET_DVR_FindPicture(int lUserID, ref NET_DVR_FIND_PICTURE_PARAM pFindParam);
        [DllImport(DllPath)]
        public static extern int NET_DVR_FindNextPicture_V50(int lFindHandle, ref NET_DVR_FIND_PICTURE_V50 lpFindData);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_CloseFindPicture(int lFindHandle);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetPicture(int lUserID, String sDVRFileName, String sSavedFileName);
        [DllImport(DllPath)]
        public static extern int NET_DVR_Upgrade(int lUserID, string sFileName);
        [DllImport(DllPath)]
        public static extern int NET_DVR_GetUpgradeState(int lUpgradeHandle);
        [DllImport(DllPath)]
        public static extern int NET_DVR_GetUpgradeProgress(int lUpgradeHandle);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_CloseUpgradeHandle(int lUpgradeHandle);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetNetworkEnvironment(uint dwEnvironmentLevel);
        [DllImport(DllPath)]
        public static extern int NET_DVR_FormatDisk(int lUserID, int lDiskNumber);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetFormatProgress(int lFormatHandle, ref int pCurrentFormatDisk, ref int pCurrentDiskPos, ref int pFormatStatic);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_CloseFormatHandle(int lFormatHandle);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetIPCProtoList(int lUserID, ref NET_DVR_IPC_PROTO_LIST lpProtoList);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetIPCProtoList_V41(int lUserID, ref NET_DVR_IPC_PROTO_LIST_V41 lpProtoList);
        [DllImport(DllPath)]
        public static extern int NET_DVR_SetupAlarmChan(int lUserID);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_CloseAlarmChan(int lAlarmHandle);
        [DllImport(DllPath)]
        public static extern int NET_DVR_SetupAlarmChan_V30(int lUserID);
        [DllImport(DllPath)]
        public static extern int NET_DVR_SetupAlarmChan_V41(int lUserID, ref NET_DVR_SETUPALARM_PARAM lpSetupParam);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_CloseAlarmChan_V30(int lAlarmHandle);
        [DllImport(DllPath)]
        public static extern int NET_DVR_StartVoiceCom(int lUserID, VOICEDATACALLBACK fVoiceDataCallBack, uint dwUser);
        [DllImport(DllPath)]
        public static extern int NET_DVR_StartVoiceCom_V30(int lUserID, uint dwVoiceChan, bool bNeedCBNoEncData, VOICEDATACALLBACKV30 fVoiceDataCallBack, IntPtr pUser);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetVoiceComClientVolume(int lVoiceComHandle, ushort wVolume);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_StopVoiceCom(int lVoiceComHandle);
        [DllImport(DllPath)]
        public static extern int NET_DVR_StartVoiceCom_MR(int lUserID, VOICEDATACALLBACK fVoiceDataCallBack, uint dwUser);
        [DllImport(DllPath)]
        public static extern int NET_DVR_StartVoiceCom_MR_V30(int lUserID, uint dwVoiceChan, VOICEDATACALLBACKV30 fVoiceDataCallBack, IntPtr pUser);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_VoiceComSendData(int lVoiceComHandle, string pSendBuf, uint dwBufSize);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_ClientAudioStart();
        [DllImport(DllPath)]
        public static extern bool NET_DVR_ClientAudioStart_V30(VOICEAUDIOSTART fVoiceAudioStart, IntPtr pUser);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_ClientAudioStop();
        [DllImport(DllPath)]
        public static extern bool NET_DVR_AddDVR(int lUserID);
        [DllImport(DllPath)]
        public static extern int NET_DVR_AddDVR_V30(int lUserID, uint dwVoiceChan);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_DelDVR(int lUserID);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_DelDVR_V30(int lVoiceHandle);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SerialStart(int lUserID, int lSerialPort, SERIALDATACALLBACK fSerialDataCallBack, uint dwUser);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SerialSend(int lSerialHandle, int lChannel, string pSendBuf, uint dwBufSize);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SerialStop(int lSerialHandle);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SendTo232Port(int lUserID, string pSendBuf, uint dwBufSize);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SendToSerialPort(int lUserID, uint dwSerialPort, uint dwSerialIndex, string pSendBuf, uint dwBufSize);
        [DllImport(DllPath)]
        public static extern System.IntPtr NET_DVR_InitG722Decoder(int nBitrate);
        [DllImport(DllPath)]
        public static extern void NET_DVR_ReleaseG722Decoder(IntPtr pDecHandle);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_DecodeG722Frame(IntPtr pDecHandle, ref byte pInBuffer, ref byte pOutBuffer);
        [DllImport(DllPath)]
        public static extern IntPtr NET_DVR_InitG722Encoder();
        [DllImport(DllPath)]
        public static extern bool NET_DVR_EncodeG722Frame(IntPtr pEncodeHandle, ref byte pInBuffer, ref byte pOutBuffer);
        [DllImport(DllPath)]
        public static extern void NET_DVR_ReleaseG722Encoder(IntPtr pEncodeHandle);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_ClickKey(int lUserID, int lKeyIndex);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_StartDVRRecord(int lUserID, int lChannel, int lRecordType);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_StopDVRRecord(int lUserID, int lChannel);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_InitDevice_Card(ref int pDeviceTotalChan);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_ReleaseDevice_Card();
        [DllImport(DllPath)]
        public static extern bool NET_DVR_InitDDraw_Card(IntPtr hParent, uint colorKey);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_ReleaseDDraw_Card();
        [DllImport(DllPath)]
        public static extern int NET_DVR_RealPlay_Card(int lUserID, ref NET_DVR_CARDINFO lpCardInfo, int lChannelNum);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_ResetPara_Card(int lRealHandle, ref NET_DVR_DISPLAY_PARA lpDisplayPara);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_RefreshSurface_Card();
        [DllImport(DllPath)]
        public static extern bool NET_DVR_ClearSurface_Card();
        [DllImport(DllPath)]
        public static extern bool NET_DVR_RestoreSurface_Card();
        [DllImport(DllPath)]
        public static extern bool NET_DVR_OpenSound_Card(int lRealHandle);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_CloseSound_Card(int lRealHandle);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetVolume_Card(int lRealHandle, ushort wVolume);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_AudioPreview_Card(int lRealHandle, int bEnable);
        [DllImport(DllPath)]
        public static extern int NET_DVR_GetCardLastError_Card();
        [DllImport(DllPath)]
        public static extern System.IntPtr NET_DVR_GetChanHandle_Card(int lRealHandle);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_CapturePicture_Card(int lRealHandle, string sPicFileName);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetSerialNum_Card(int lChannelNum, ref uint pDeviceSerialNo);
        [DllImport(DllPath)]
        public static extern int NET_DVR_FindDVRLog(int lUserID, int lSelectMode, uint dwMajorType, uint dwMinorType, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime);
        [DllImport(DllPath)]
        public static extern int NET_DVR_FindNextLog(int lLogHandle, ref NET_DVR_LOG lpLogData);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_FindLogClose(int lLogHandle);
        [DllImport(DllPath)]
        public static extern int NET_DVR_FindDVRLog_V30(int lUserID, int lSelectMode, uint dwMajorType, uint dwMinorType, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime, bool bOnlySmart);
        [DllImport(DllPath)]
        public static extern int NET_DVR_FindNextLog_V30(int lLogHandle, ref NET_DVR_LOG_V30 lpLogData);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_FindLogClose_V30(int lLogHandle);
        [DllImport(DllPath)]
        public static extern int NET_DVR_FindFileByCard(int lUserID, int lChannel, uint dwFileType, int nFindType, ref byte sCardNumber, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_CaptureJPEGPicture(int lUserID, int lChannel, ref NET_DVR_JPEGPARA lpJpegPara, string sPicFileName);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_CaptureJPEGPicture_NEW(int lUserID, int lChannel, ref NET_DVR_JPEGPARA lpJpegPara, byte[] sJpegPicBuffer, uint dwPicSize, ref uint lpSizeReturned);
        [DllImport(DllPath)]
        public static extern int NET_DVR_GetRealPlayerIndex(int lRealHandle);
        [DllImport(DllPath)]
        public static extern int NET_DVR_GetPlayBackPlayerIndex(int lPlayHandle);
        [DllImport(DllPath)]
        //人脸识别上传文件发送数据
        public static extern Int32 NET_DVR_UploadSend(int lUploadHandle, ref NET_DVR_SEND_PARAM_IN pstruSendParamIN, IntPtr lpOutBuffer);
        [DllImport(DllPath)]
        //人脸识别上传文件
        public static extern Int32 NET_DVR_UploadFile_V40(int lUserID, uint dwUploadType, IntPtr lpInBuffer, uint dwInBufferSize, string sFileName, IntPtr lpOutBuffer, uint dwOutBufferSize);
        [DllImport(DllPath)]
        public static extern Int32 NET_DVR_GetUploadState(int lUploadHandle, ref uint pProgress);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetUploadResult(int lUploadHandle, IntPtr lpOutBuffer, uint dwOutBufferSize);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_UploadClose(int lUploadHandle);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetScaleCFG(int lUserID, uint dwScale);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetScaleCFG(int lUserID, ref uint lpOutScale);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetScaleCFG_V30(int lUserID, ref NET_DVR_SCALECFG pScalecfg);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetScaleCFG_V30(int lUserID, ref NET_DVR_SCALECFG pScalecfg);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetATMPortCFG(int lUserID, ushort wATMPort);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetATMPortCFG(int lUserID, ref ushort LPOutATMPort);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_InitDDrawDevice();
        [DllImport(DllPath)]
        public static extern bool NET_DVR_ReleaseDDrawDevice();
        [DllImport(DllPath)]
        public static extern int NET_DVR_GetDDrawDeviceTotalNums();
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetDDrawDevice(int lPlayPort, uint nDeviceNum);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_PTZSelZoomIn(int lRealHandle, ref NET_DVR_POINT_FRAME pStruPointFrame);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_PTZSelZoomIn_EX(int lUserID, int lChannel, ref NET_DVR_POINT_FRAME pStruPointFrame);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_StartDecode(int lUserID, int lChannel, ref NET_DVR_DECODERINFO lpDecoderinfo);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_StopDecode(int lUserID, int lChannel);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetDecoderState(int lUserID, int lChannel, ref NET_DVR_DECODERSTATE lpDecoderState);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetDecInfo(int lUserID, int lChannel, ref NET_DVR_DECCFG lpDecoderinfo);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetDecInfo(int lUserID, int lChannel, ref NET_DVR_DECCFG lpDecoderinfo);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetDecTransPort(int lUserID, ref NET_DVR_PORTCFG lpTransPort);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetDecTransPort(int lUserID, ref NET_DVR_PORTCFG lpTransPort);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_DecPlayBackCtrl(int lUserID, int lChannel, uint dwControlCode, uint dwInValue, ref uint LPOutValue, ref NET_DVR_PLAYREMOTEFILE lpRemoteFileInfo);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_StartDecSpecialCon(int lUserID, int lChannel, ref NET_DVR_DECCHANINFO lpDecChanInfo);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_StopDecSpecialCon(int lUserID, int lChannel, ref NET_DVR_DECCHANINFO lpDecChanInfo);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_DecCtrlDec(int lUserID, int lChannel, uint dwControlCode);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_DecCtrlScreen(int lUserID, int lChannel, uint dwControl);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetDecCurLinkStatus(int lUserID, int lChannel, ref NET_DVR_DECSTATUS lpDecStatus);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MatrixStartDynamic(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DYNAMIC_DEC lpDynamicInfo);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MatrixStopDynamic(int lUserID, uint dwDecChanNum);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MatrixGetDecChanInfo(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_CHAN_INFO lpInter);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MatrixGetDecChanInfo_V41(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_CHAN_INFO_V41 lpOuter);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MatrixSetLoopDecChanInfo(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_LOOP_DECINFO lpInter);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MatrixGetLoopDecChanInfo(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_LOOP_DECINFO lpInter);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MatrixSetLoopDecChanEnable(int lUserID, uint dwDecChanNum, uint dwEnable);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MatrixGetLoopDecChanEnable(int lUserID, uint dwDecChanNum, ref uint lpdwEnable);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MatrixGetLoopDecEnable(int lUserID, ref uint lpdwEnable);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MatrixSetDecChanEnable(int lUserID, uint dwDecChanNum, uint dwEnable);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MatrixGetDecChanEnable(int lUserID, uint dwDecChanNum, ref uint lpdwEnable);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MatrixGetDecChanStatus(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_CHAN_STATUS lpInter);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MatrixSetTranInfo(int lUserID, ref NET_DVR_MATRIX_TRAN_CHAN_CONFIG lpTranInfo);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MatrixGetTranInfo(int lUserID, ref NET_DVR_MATRIX_TRAN_CHAN_CONFIG lpTranInfo);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MatrixSetRemotePlay(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_REMOTE_PLAY lpInter);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MatrixSetRemotePlayControl(int lUserID, uint dwDecChanNum, uint dwControlCode, uint dwInValue, ref uint LPOutValue);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MatrixGetRemotePlayStatus(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_REMOTE_PLAY_STATUS lpOuter);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MatrixStartDynamic_V30(int lUserID, uint dwDecChanNum, ref NET_DVR_PU_STREAM_CFG lpDynamicInfo);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MatrixStartDynamic_V41(int lUserID, uint dwDecChanNum, ref NET_DVR_PU_STREAM_CFG_V41 lpDynamicInfo);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MatrixSetLoopDecChanInfo_V30(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_LOOP_DECINFO_V30 lpInter);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MatrixGetLoopDecChanInfo_V30(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_LOOP_DECINFO_V30 lpInter);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MatrixGetDecChanInfo_V30(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_CHAN_INFO_V30 lpInter);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MatrixSetTranInfo_V30(int lUserID, ref NET_DVR_MATRIX_TRAN_CHAN_CONFIG_V30 lpTranInfo);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MatrixGetTranInfo_V30(int lUserID, ref NET_DVR_MATRIX_TRAN_CHAN_CONFIG_V30 lpTranInfo);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MatrixGetDisplayCfg(int lUserID, uint dwDispChanNum, ref NET_DVR_VGA_DISP_CHAN_CFG lpDisplayCfg);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MatrixSetDisplayCfg(int lUserID, uint dwDispChanNum, ref NET_DVR_VGA_DISP_CHAN_CFG lpDisplayCfg);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MatrixGetDisplayCfg_V41(int lUserID, uint dwDispChanNum, ref NET_DVR_MATRIX_VOUTCFG lpDisplayCfg);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MatrixSetDisplayCfg_V41(int lUserID, uint dwDispChanNum, ref NET_DVR_MATRIX_VOUTCFG lpDisplayCfg);
        [DllImport(DllPath)]
        public static extern int NET_DVR_MatrixStartPassiveDecode(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_PASSIVEMODE lpPassiveMode);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MatrixSendData(int lPassiveHandle, System.IntPtr pSendBuf, uint dwBufSize);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MatrixStopPassiveDecode(int lPassiveHandle);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_UploadLogo(int lUserID, uint dwDispChanNum, ref NET_DVR_DISP_LOGOCFG lpDispLogoCfg, System.IntPtr sLogoBuffer);
        [DllImport(DllPath)]
        public static extern int NET_DVR_PicUpload(int lUserID, String sFileName, ref NET_DVR_PICTURECFG lpPictureCfg);
        [DllImport(DllPath)]
        public static extern int NET_DVR_GetPicUploadProgress(int lUploadHandle);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_CloseUploadHandle(int lUploadHandle);  
        [DllImport(DllPath)]
        public static extern int NET_DVR_GetPicUploadState(int lUploadHandle);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_LogoSwitch(int lUserID, uint dwDecChan, uint dwLogoSwitch);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MatrixGetDeviceStatus(int lUserID, ref NET_DVR_DECODER_WORK_STATUS lpDecoderCfg);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetInputSignalList_V40(int lUserID, uint dwDevNum, ref NET_DVR_INPUT_SIGNAL_LIST lpInputSignalList);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MatrixDiaplayControl(int lUserID, uint dwDispChanNum, uint dwDispChanCmd, uint dwCmdParam);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_RefreshPlay(int lPlayHandle);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_RestoreConfig(int lUserID);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SaveConfig(int lUserID);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_RebootDVR(int lUserID);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_ShutDownDVR(int lUserID);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetDVRConfig(int lUserID, uint dwCommand, int lChannel, IntPtr lpOutBuffer, uint dwOutBufferSize, ref uint lpBytesReturned);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetDVRConfig(int lUserID, uint dwCommand, int lChannel, System.IntPtr lpInBuffer, uint dwInBufferSize);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetDVRWorkState_V30(int lUserID, IntPtr pWorkState);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetDVRWorkState(int lUserID, ref NET_DVR_WORKSTATE lpWorkState);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetVideoEffect(int lUserID, int lChannel, uint dwBrightValue, uint dwContrastValue, uint dwSaturationValue, uint dwHueValue);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetVideoEffect(int lUserID, int lChannel, ref uint pBrightValue, ref uint pContrastValue, ref uint pSaturationValue, ref uint pHueValue);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_ClientGetframeformat(int lUserID, ref NET_DVR_FRAMEFORMAT lpFrameFormat);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_ClientSetframeformat(int lUserID, ref NET_DVR_FRAMEFORMAT lpFrameFormat);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetAtmProtocol(int lUserID, ref NET_DVR_ATM_PROTOCOL lpAtmProtocol);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetAlarmOut_V30(int lUserID, IntPtr lpAlarmOutState);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetAlarmOut(int lUserID, ref NET_DVR_ALARMOUTSTATUS lpAlarmOutState);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetAlarmOut(int lUserID, int lAlarmOutPort, int lAlarmOutStatic);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetUpnpNatState(int lUserID, ref NET_DVR_UPNP_NAT_STATE lpState);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_ClientSetVideoEffect(int lRealHandle, uint dwBrightValue, uint dwContrastValue, uint dwSaturationValue, uint dwHueValue);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_ClientGetVideoEffect(int lRealHandle, ref uint pBrightValue, ref uint pContrastValue, ref uint pSaturationValue, ref uint pHueValue);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetConfigFile(int lUserID, string sFileName);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetConfigFile(int lUserID, string sFileName);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetConfigFile_V30(int lUserID, string sOutBuffer, uint dwOutSize, ref uint pReturnSize);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetConfigFile_EX(int lUserID, string sOutBuffer, uint dwOutSize);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetConfigFile_EX(int lUserID, string sInBuffer, uint dwInSize);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetLogToFile(int bLogEnable, string strLogDir, bool bAutoDel);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetSDKState(ref NET_DVR_SDKSTATE pSDKState);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetSDKAbility(ref NET_DVR_SDKABL pSDKAbl);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetPTZProtocol(int lUserID, ref NET_DVR_PTZCFG pPtzcfg);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_LockPanel(int lUserID);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_UnLockPanel(int lUserID);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetRtspConfig(int lUserID, uint dwCommand, ref NET_DVR_RTSPCFG lpInBuffer, uint dwInBufferSize);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetRtspConfig(int lUserID, uint dwCommand, ref NET_DVR_RTSPCFG lpOutBuffer, uint dwOutBufferSize);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MatrixGetSceneCfg(int lUserID, uint dwSceneNum, ref NET_DVR_MATRIX_SCENECFG lpSceneCfg);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_MatrixSetSceneCfg(int lUserID, uint dwSceneNum, ref NET_DVR_MATRIX_SCENECFG lpSceneCfg);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetRealHeight(int lUserID, int lChannel, ref NET_VCA_LINE lpLine, ref Single lpHeight);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetRealLength(int lUserID, int lChannel, ref NET_VCA_LINE lpLine, ref Single lpLength);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SaveRealData_V30(int lRealHandle, uint dwTransType, string sFileName);
        [DllImport(DllPath)]
        public static extern IntPtr NET_DVR_InitG711Encoder(ref NET_DVR_AUDIOENC_INFO enc_info);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_EncodeG711Frame(IntPtr handle, ref NET_DVR_AUDIOENC_PROCESS_PARAM p_enc_proc_param);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_ReleaseG711Encoder(IntPtr pEncodeHandle);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_DecodeG711Frame(uint iType, ref byte pInBuffer, ref byte pOutBuffer);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_EmailTest(int lUserID);
        [DllImport(DllPath)]
        public static extern int NET_DVR_FindFileByEvent(int lUserID, ref NET_DVR_SEARCH_EVENT_PARAM lpSearchEventParam);
        [DllImport(DllPath)]
        public static extern int NET_DVR_FindNextEvent(int lSearchHandle, ref NET_DVR_SEARCH_EVENT_RET lpSearchEventRet);
        [DllImport(DllPath)]
        public static extern Int32 NET_DVR_Login_V30(string sDVRIP, Int32 wDVRPort, string sUserName, string sPassword, ref NET_DVR_DEVICEINFO_V30 lpDeviceInfo);
        [DllImport(DllPath)]
        public static extern int NET_DVR_Login_V40(ref NET_DVR_USER_LOGIN_INFO pLoginInfo, ref NET_DVR_DEVICEINFO_V40 lpDeviceInfo);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_Logout_V30(Int32 lUserID);
        [DllImport(DllPath)]
        public static extern int NET_DVR_FindNextLog_MATRIX(int iLogHandle, ref NET_DVR_LOG_MATRIX lpLogData);
        [DllImport(DllPath)]
        public static extern int NET_DVR_FindDVRLog_Matrix(int iUserID, int lSelectMode, uint dwMajorType, uint dwMinorType, ref tagVEDIOPLATLOG lpVedioPlatLog, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_STDXMLConfig(int iUserID, ref NET_DVR_XML_CONFIG_INPUT lpInputParam, ref NET_DVR_XML_CONFIG_OUTPUT lpOutputParam);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetDeviceConfig(int lUserID, uint dwCommand, uint dwCount, IntPtr lpInBuffer, uint dwInBufferSize, IntPtr lpStatusList, IntPtr lpOutBuffer, uint dwOutBufferSize);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetDeviceConfig(int lUserID, uint dwCommand, uint dwCount, IntPtr lpInBuffer, uint dwInBufferSize, IntPtr lpStatusList, IntPtr lpInParamBuffer, uint dwInParamBufferSize);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetDeviceConfigEx(Int32 lUserID, uint dwCommand, uint dwCount, ref NET_DVR_IN_PARAM lpInParam, ref NET_DVR_OUT_PARAM lpOutParam);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetSTDConfig(int iUserID, uint dwCommand, ref NET_DVR_STD_CONFIG lpConfigParam);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetSTDConfig(int iUserID, uint dwCommand, ref NET_DVR_STD_CONFIG lpConfigParam);
        [DllImport(DllPath)]
        public static extern int NET_DVR_StartRemoteConfig(int lUserID, int dwCommand, IntPtr lpInBuffer, Int32 dwInBufferLen, RemoteConfigCallback cbStateCallback, IntPtr pUserData);
        [DllImport(DllPath)]
        public static extern int NET_DVR_GetNextRemoteConfig(int lHandle, IntPtr lpOutBuff, int dwOutBuffSize);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SendRemoteConfig(int lHandle, int dwDataType, IntPtr pSendBuf, int dwBufSize);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_StopRemoteConfig(int lHandle);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_RemoteControl(int lUserID, int dwCommand, IntPtr lpInBuffer, int dwInBufferSize);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_RemoteControl(int lUserID, int dwCommand, ref NET_DVR_FACE_PARAM_CTRL_CARDNO lpInBuffer, int dwInBufferSize);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_ContinuousShoot(Int32 lUserID, ref NET_DVR_SNAPCFG lpInter);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_ManualSnap(Int32 lUserID, ref NET_DVR_MANUALSNAP lpInter, ref NET_DVR_PLATE_RESULT lpOuter);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetDeviceAbility(int lUserID, uint dwAbilityType, IntPtr pInBuf, uint dwInLength, IntPtr pOutBuf, uint dwOutLength);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetBehaviorParamKey(int lUserID, int lChannel, uint dwParameterKey, int nValue);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetBehaviorParamKey(int lUserID, int lChannel, uint dwParameterKey, ref int pValue);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetVCADrawMode(int lUserID, int lChannel, ref NET_VCA_DRAW_MODE lpDrawMode);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetVCADrawMode(int lUserID, int lChannel, ref NET_VCA_DRAW_MODE lpDrawMode);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetLFTrackMode(int lUserID, int lChannel, ref NET_DVR_LF_TRACK_MODE lpTrackMode);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetLFTrackMode(int lUserID, int lChannel, ref NET_DVR_LF_TRACK_MODE lpTrackMode);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetCCDCfg(int lUserID, int lChannel, ref NET_DVR_CCD_CFG lpCCDCfg);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_SetCCDCfg(int lUserID, int lChannel, ref NET_DVR_CCD_CFG lpCCDCfg);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_GetParamSetMode(int lUserID, ref uint dwParamSetMode);
        [DllImport(DllPath)]
        public static extern bool NET_DVR_InquestStartCDW_V30(int lUserID,  ref NET_DVR_INQUEST_ROOM lpInquestRoom, bool bNotBurn);
        [DllImport(DllPath)]
        public static extern int PostMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport(DllPath)]
        public static extern bool NET_VCA_RestartLib(int lUserID, int lChannel);
    }
}
