using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Login : MonoBehaviour {

    #region Variable
    private string user, pwd;
    Manager_Login ml = new Manager_Login();
    Manager_Task mk = new Manager_Task();
    #endregion

    #region Main
    public GameObject ui_Main, ui_Start, ui_Setting, ui_Info,ui_Thank;
    public Button Button_Start, Button_Setting, Button_Thank, Button_Cancel;
    public AudioSource ok,cancel;
    #endregion

    #region Login
    public Button Button_Login;
    public InputField InputField_Usename, InputField_Password;
    #endregion

    #region Setting
    public Dropdown Dropdown_Language, Dropdown_Version;
    public InputField InputField_IP;
    public Button Button_IP;
    #endregion

    #region Login_Interface (Language)
    #region ui_Main
    public Text Start_Text, Setting_Text, Thank_Text;
    #endregion
    #region ui_Start
    public Text Username_Placeholder, Password_Placeholder, Login_Text, Login_Message;
    #endregion
    #region ui_Setting
    public Text Language_Text, Version_Text;
    #endregion
    #region ui_Thanks
    public Text Resources_Text;
    #endregion
    #endregion

    // Use this for initialization
    void Start () {
        Button_Start.onClick.AddListener(START);
        Button_Setting.onClick.AddListener(Setting);
        Button_Thank.onClick.AddListener(Thank);

        Button_Login.onClick.AddListener(confirmlogin);

        Button_Cancel.onClick.AddListener(Cancel);

        Dropdown_Language.onValueChanged.AddListener(LanguageSelect);
        Dropdown_Version.onValueChanged.AddListener(VersionSelect);
        Button_IP.onClick.AddListener(ChangeIP);
        InputField_IP.text = System_Setting.serverlink;

        StartCoroutine(ChangeLanguage());
    }

    void START()
    {
        ok.Play();
        ui_Main.SetActive(false);
        ui_Info.SetActive(true);
        ui_Start.SetActive(true);

    }
    void Setting()
    {
        ok.Play();
        ui_Main.SetActive(false);
        ui_Info.SetActive(true);
        ui_Setting.SetActive(true);

    }
    void Thank()
    {
        ok.Play();
        ui_Main.SetActive(false);
        ui_Info.SetActive(true);
        ui_Thank.SetActive(true);
    }
    #region Login
    void confirmlogin()
    {
        ok.Play();
        user = InputField_Usename.text;
        pwd = InputField_Password.text;
        if (user != "")
        {
            if (pwd != "")
            {
                switch (System_Setting.Language)
                {
                    case 0:
                        Login_Message.text = "資料載入中";
                        break;
                    case 1:
                        Login_Message.text = "Loding......";
                        break;
                    default:
                        break;
                }
                StartCoroutine(Login());
            }
            else
            {
                switch (System_Setting.Language)
                {
                    case 0:
                        Login_Message.text = "密碼不可為空";
                        break;
                    case 1:
                        Login_Message.text = "Password cannot be empty";
                        break;
                    default:
                        break;
                }
            }
        }
        else
        {
            switch (System_Setting.Language)
            {
                case 0:
                    Login_Message.text = "學號不可為空";
                    break;
                case 1:
                    Login_Message.text = "SchoolNumber cannot be empty";
                    break;
                default:
                    break;
            }
        }
    }
    IEnumerator Login()
    {
        StartCoroutine(ml.CheckLogin("Login.php", user, pwd));
        yield return new WaitForSeconds(1f);
        if (ml.state == 1)
        {
            switch (System_Setting.Language)
            {
                case 0:
                    StartCoroutine(mk.DownloadTask("task_chinese.php"));
                    yield return new WaitForSeconds(1f);
                    break;
                case 1:
                    StartCoroutine(mk.DownloadTask("task_english.php"));
                    yield return new WaitForSeconds(1f);
                    break;
                default:
                    break;
            }
            Task_Data.Task_Init();
            Card_Data.Card_Init();
            Vocabulary_Data.Vocabulary_Init();
            SceneManager.LoadScene("Main");
        }
        else if (ml.state == 0)
        {
            switch (System_Setting.Language)
            {
                case 0:
                    Login_Message.text = "帳號或密碼不正確";
                    break;
                case 1:
                    Login_Message.text = "SchoolNumber or Password is incorrect";
                    break;
                default:
                    break;
            }
        }
        else if (ml.state == 2)
        {
            switch (System_Setting.Language)
            {
                case 0:
                    Login_Message.text = "連線失敗";
                    break;
                case 1:
                    Login_Message.text = "Connection failed";
                    break;
                default:
                    break;
            }
        }
        else if (ml.state == 3)
        {
            switch (System_Setting.Language)
            {
                case 0:
                    Login_Message.text = "發生錯誤";
                    break;
                case 1:
                    Login_Message.text = "Error";
                    break;
                default:
                    break;
            }
        }
    }
    #endregion

    void Cancel()
    {
        cancel.Play();
        ui_Main.SetActive(true);
        ui_Start.SetActive(false);
        ui_Setting.SetActive(false);
        ui_Info.SetActive(false);
        ui_Thank.SetActive(false);
    }

    #region Setting
    void LanguageSelect(int index)
    {
        switch (index)
        {
            case 0: //中文
                System_Setting.Language = 0;
                break;
            case 1: //英文
                System_Setting.Language = 1;
                break;
            default:
                break;
        }
        StartCoroutine(ChangeLanguage());
    }
    void VersionSelect(int index)
    {
        switch (index)
        {
            case 0:
                System_Setting.Version = 0;
                break;
            case 1:
                System_Setting.Version = 1;
                break;
            case 2:
                System_Setting.Version = 2;
                break;
            case 3:
                System_Setting.Version = 3;
                break;
            default:
                break;
        }
    }
    IEnumerator ChangeLanguage()
    {
        switch (System_Setting.Language)
        {
            case 0:
                StartCoroutine(ml.ChangeLanguage("interface_chinese.php", 0));
                break;
            case 1:
                StartCoroutine(ml.ChangeLanguage("interface_english.php", 1));
                break;
            default:
                break;
        }
        yield return new WaitForSeconds(1f);
        Start_Text.text = System_Interface.Start_Text;
        Setting_Text.text = System_Interface.Setting_Text;
        Thank_Text.text = System_Interface.Thank_Text;
        Username_Placeholder.text = System_Interface.Username_Placeholder;
        Password_Placeholder.text = System_Interface.Password_Placeholder;
        Login_Text.text = System_Interface.Login_Text;
        Login_Message.text = System_Interface.Login_Message;
        Language_Text.text = System_Interface.Language_Text;
        Version_Text.text = System_Interface.Version_Text;
        Resources_Text.text = System_Interface.Resources_Text;
    }
    void ChangeIP()
    {
        ok.Play();
        System_Setting.serverlink = InputField_IP.text;
    }
    #endregion
}
