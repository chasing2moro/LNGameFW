using UnityEngine;
using System.Collections;

public class EventUI
{
	public uint EVENT_UI_SHOW_LOADING_ALPHA   = 0x0000001;
	public uint EVENT_UI_HIDE_LOADING_ALPHA   = 0x0000002;
	
	public uint EVENT_UI_SHOW_LOADING_BLOCK   = 0x0000003;
	public uint EVENT_UI_HIDE_LOADING_BLOCK   = 0x0000004;
	
	public uint EVENT_UI_SHOW_LOADING_TRANSPARENT = 0x0000005;
	public uint EVENT_UI_HIDE_LOADING_TRANSPARENT = 0x0000006;
	
	public uint EVENT_UI_SHOWUI               = 0x0000007;
	public uint EVENT_UI_HIDEUI               = 0x0000008;
	
	public uint EVENT_UI_CLICK_BUTTON			= 0x0000009;
	public uint EVENT_UI_COULD_TOUCH			= 0x000000a;
	public uint EVENT_UI_COULD_NOT_TOUCH		= 0x000000b;
	public uint EVENT_UI_ALL_COULD_TOUCH		= 0x000000c;
	public uint EVENT_UI_ALL_COULD_NOT_TOUCH	= 0x000000d;
	
	
	public uint EVENT_UI_QUITGAME = 0x000000e;//退出游戏//
	
	
	public uint EVENT_UI_STARTTOCOPYFILE = 0x000000f;//开启复制文件//
	public uint EVENT_UI_SHOWCOPYSTATUS = 0x0000010;//复制状态//
	public uint EVENT_UI_STARTTOUPDATEFILE = 0x0000011;//开启下载文件//
	public uint EVENT_UI_SHOWUPDATESTATUS = 0x0000012;//下载状态//
	public uint EVENT_UI_SHOWPROGRESS = 0x0000013;//显示进度//
	public uint EVENT_UI_STARTTOLOGIN = 0x0000014;//开启登录//
	
	public uint EVENT_UI_CLOSE_GUES = 0x0000015;//关闭手势/
	public uint EVENT_UI_GESTURE_COMPLETE = 0x0000016;//手势完成//
	public uint EVENT_UI_GESTURE_OPEN = 0x0000017;//开启手势/
	public uint EVENT_UI_GESTURE_CLOSE = 0x0000018;//关闭手势/

}
public class EventWeb
{
	public uint EVENT_WEB_NOT_REACHABLE       = 0xf000001;
	public uint EVENT_WEB_CARRIER_TIME_OUT    = 0xf000002;
	public uint EVENT_WEB_WIFI_TIME_OUT       = 0xf000003;

    //索取版本信息//
 //   public uint EVENT_WEB_RECEIVE_VERSION = 0xf000006;
 //   public uint EVENT_WEB_SEND_VERSION = 0xf000007;//
    public uint EVENT_WEB_RECEIVE_VERSION = 0xf1000004;
    public uint EVENT_WEB_SEND_VERSION = 0xf1000002;//
	
	public uint EVENT_WEB_RECEIVE_ARCHIVE_EMAILITEM = 0xf000009;
	
	public uint EVENT_WEB_SEND_HEART = 0xf00000a;
	
	//注册账号//
	public uint EVENT_WEB_SEND_REGIST = 0xf00000b;
	public uint EVENT_WEB_RECEIVE_REGIST = 0xf00000c;
	
	//登录游戏//
	public uint EVENT_WEB_SEND_LOGIN = 0xf00000d;
	public uint EVENT_WEB_RECEIVE_LOGIN = 0xf00000e;
	
	
	public uint EVENT_WEB_SEND_SOCKET_LOGIN = 0x1000009;

	public uint EVENT_WEB_SEND_HTTP_LOGIN = 0x1000007;
	public uint EVENT_WEB_SEND_TASKID = 0x1000022;

	public uint EVENT_WEB_SEND_TALK = 0x1000020;
		
	public uint EVENT_WEB_LOGIN_SUCCESS = 0x1000024;//玩家登陆成功//
}
public class EventWebView
{
	public uint EVENT_WEBVIEW_OPEN_ANNOUNCEMENT = 0xe000000;
}
public class EventData
{
	public uint EVENT_DATA_FAIL_UPDATEFILE = 0x1000000;//更新文件失败//
	public uint EVENT_DATA_FAIL_SETTASKLIST = 0x1000001;//设置任务列表失败//
	public uint EVENT_DATA_FAIL_GETLOCALLIST = 0x1000002;//获取Local更新列表失败//
	public uint EVENT_DATA_FAIL_GETSERVERLIST = 0x1000003;//获取Server更新列表失败//
	public uint EVENT_DATA_FAIL_SETLOCALLIST = 0x1000004;//写入Local更新列表失败//
	
	
	public uint EVENT_DATA_STARTCOPY = 0x1000005;//开始复制文件//
	public uint EVENT_DATA_SETCOPYSTATUS = 0x1000006;//改变复制文件流程状态//
	public uint EVENT_DATA_SUCCESSCOPYSINGLEFILE = 0x1000007;//单个文件复制成功//
	public uint EVENT_DATA_FINISHEDCOPY = 0x1000008;//复制文件完毕//
	
	public uint EVENT_DATA_STARTUPDATE = 0x1000009;//开启版本更新//
	public uint EVENT_DATA_SETUPDATESTATUS = 0x100000a;//改变更新版本流程状态//
	public uint EVENT_DATA_SUCCESSUPDATESINGLEFILE = 0x100000b;//单个文件下载成功//
	public uint EVENT_DATA_FINISHEDUPDATE = 0x100000c;//更新文件完毕//
	
}
public class EventFighting
{}
public class EventSys
{
	public uint EVENT_WEB_ERROR = 0x2000003;
	
	public uint EVENT_FILE_MD5_ERROR = 0x2000005;
	
	public uint EVENT_WEB_PURCHASE_SUCCESS = 0x2000007;
	
	public uint EVENT_SYS_ERROR = 0x2000100;
}
public class EventInput
{}
public class GameEvent
{
	public static EventUI UIEvent = new EventUI();
	public static EventWeb WebEvent = new EventWeb();
	public static EventFighting FightingEvent = new EventFighting();
	public static EventSys SysEvent = new EventSys();
	public static EventInput InputEvent = new EventInput();
	public static EventData DataEvent = new EventData();
	public static EventWebView WebViewEvent = new EventWebView();
}