using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_Login{

    private string serverlink= System_Setting.serverlink;
    private string[] items;
    public int state;
    
    public IEnumerator CheckLogin(string fileName, string user , string pwd)
    {
        WWWForm LoginForm = new WWWForm();
        LoginForm.AddField("UsernamePost", user);
        LoginForm.AddField("PasswordPost", pwd);
        WWW reg = new WWW(serverlink + fileName, LoginForm);
        yield return reg;
        //s_state = reg.ToString();

        if (reg.error == null)
        {
            if (reg.text == "2")
            {
                state = 0;//帳密錯誤
            }
            else if (reg.text == "3")
            {
                state = 2;//連線失敗
            }
            else if (reg.text == "1")//帳密正確
            {
                state = 1;
            }
        }
        else
        {
            Debug.Log("error msg" + reg.error);
        }
    }
    public IEnumerator ChangeLanguage(string fileName, int Index)
    {
        WWW reg = new WWW(serverlink + fileName);
        yield return reg;
        string itemDatastring = reg.text;
        items = itemDatastring.Split(';');
        foreach(string str in items)
        {
            string name, s;
            if (str != ""){
                switch (Index)
                {
                    case 0:
                        name = GetDataValue(str, "Interface_Chinese_Name:");
                        s = GetDataValue(str, "Interface_Chinese_Str:");
                        System_Interface.InterfaceChange(name, s);
                        break;
                    case 1:
                        name = GetDataValue(str, "Interface_English_Name:");
                        s = GetDataValue(str, "Interface_English_Str:");
                        System_Interface.InterfaceChange(name, s);
                        break;
                    default:
                        break;
                }
            }
        }
    }

    public string GetDataValue(string data,string index)
    {
        string value = data.Substring(data.IndexOf(index) + index.Length);
        if(value.Contains("|"))value=value.Remove(value.IndexOf("|"));
        return value;
    }
}
