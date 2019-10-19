using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

static class System_Interface{
    //Login
    #region Login_Interface (Language)
    #region ui_Main
    public static string Start_Text, Setting_Text, Thank_Text;
    #endregion
    #region ui_Start
    public static string Username_Placeholder, Password_Placeholder, NickName_Placeholder, Login_Text, Login_Message;
    #endregion
    #region ui_Setting
    public static string Language_Text, Version_Text;
    #endregion
    #region ui_Thanks
    public static string Resources_Text;
    #endregion
    #endregion
    //Main
    #region Main_Interface (Language)
    public static string Info_Text, Info_Task_Text, Info_Learn_Text;
    #endregion
    public static void InterfaceChange(string index,string s)
    {
        switch (index)
        {
            //Login
            case "Start_Text":
                Start_Text = s;
                break;
            case "Setting_Text":
                Setting_Text = s;
                break;
            case "Thank_Text":
                Thank_Text = s;
                break;
            case "Username_Placeholder":
                Username_Placeholder = s;
                break;
            case "Password_Placeholder":
                Password_Placeholder = s;
                break;
            case "NickName_Placeholder":
                NickName_Placeholder = s;
                break;
            case "Login_Text":
                Login_Text = s;
                break;
            case "Login_Message":
                Login_Message = s;
                break;
            case "Language_Text":
                Language_Text = s;
                break;
            case "Version_Text":
                Version_Text = s;
                break;
            case "Resources_Text":
                Resources_Text = s;
                break;
            //Main
            case "Info_Text":
                Info_Text = s;
                break;
            case "Info_Task_Text":
                Info_Task_Text = s;
                break;
            case "Info_Learn_Text":
                Info_Learn_Text = s;
                break;
            default:
                break;
        }
        Debug.Log(index + " : " + s);
    }
}
