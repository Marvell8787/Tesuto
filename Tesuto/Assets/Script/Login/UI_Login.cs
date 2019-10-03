using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Login : MonoBehaviour {

    #region Main
    public GameObject ui_Main, ui_Start, ui_Setting, ui_Info;
    public Button Button_Start, Button_Setting, Button_Cancel;
    public AudioSource ok;
    #endregion

    #region Login
    public Button Button_Login;
    public InputField InputField_Account, InputField_Password;
    #endregion

    #region Setting
    public Dropdown Dropdown_Language, Dropdown_Version;
    #endregion

    // Use this for initialization
    void Start () {
        Button_Start.onClick.AddListener(START);
        Button_Setting.onClick.AddListener(Setting);

        Button_Login.onClick.AddListener(Login);

        Button_Cancel.onClick.AddListener(Cancel);

        Dropdown_Language.onValueChanged.AddListener(LanguageSelect);
        Dropdown_Version.onValueChanged.AddListener(VersionSelect);
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

    void Login()
    {
        SceneManager.LoadScene("Main");
    }

    void Cancel()
    {
        ok.Play();
        ui_Main.SetActive(true);
        ui_Start.SetActive(false);
        ui_Setting.SetActive(false);
        ui_Info.SetActive(false);
    }

    #region Dropdown
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
    #endregion
}
