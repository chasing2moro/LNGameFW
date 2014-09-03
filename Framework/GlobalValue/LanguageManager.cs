//#define LANGUAGE_CHINESE
#define LANGUAGE_ENGLISH

using UnityEngine;
using System.Collections;

public static class LanguageManager {

#if LANGUAGE_CHINESE
	public const string Test_UI_Name = "Test_Chinese";
	
    public const string UI_Title_MoreGame = "更多游戏";
    public const string UI_Title_StartGame = "开始游戏";
    public const string UI_Title_Account = "账户中心";
    public const string UI_Account_MoreGame = "更多游戏";
    public const string UI_Account_Login = "登陆";
    public const string UI_Account_ThirdLogin = "第三方登录";
    public const string UI_Account_FindPassword = "找回密码";
    public const string UI_Account_Regist = "注册";
    public const string UI_Account_Quit = "退出";
    public const string UI_Return = "返回";
    public const string UI_Confirm = "确定";
    public const string UI_Reset = "重置";
    public const string UI_InputEmail = "请输入注册邮箱"; 
    public const string UI_InputAccount = "请输入你的账号";
    public const string UI_InputPassword = "请输入你的密码";
	
#elif LANGUAGE_ENGLISH

                                        public const string UIText_SetBureauTitle = "SetBureau";

    public const string UI_MoreGame = "MoreGame";
    public const string UI_Title_StartGame = "StartGame";
    public const string UI_Title_Account = "Account";
    public const string UI_Account_MoreGame = "MoreGame";
    public const string UI_Account_Login = "Login";
    public const string UI_Account_ThirdLogin = "ThirdLogin";
    public const string UI_Account_FindPassword = "FindPassword";
    public const string UI_Account_Regist = "Regist";
    public const string UI_Account_Quit = "Quit";
    public const string UI_Return = "Return";
    public const string UI_Confirm = "Confirm";
    public const string UI_Reset = "Reset";
    public const string UI_InputEmail = "Please enter your registered mailbox";
    public const string UI_InputAccount = "Please enter your account";
    public const string UI_InputPassword = "Please enter your password";
#endif
	
	
}
