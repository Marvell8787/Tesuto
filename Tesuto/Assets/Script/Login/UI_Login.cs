using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Login : MonoBehaviour {

    #region Variable
    public GameObject ui_Main, ui_Start, ui_Setting, ui_About, ui_Info;
    public Button Button_Start, Button_Setting, Button_About, Button_Cancel;
    public InputField InputField_Account, InputField_Password, InputField_Nickname;

    #endregion

    // Use this for initialization
    void Start () {
        Button_Start.onClick.AddListener(Login);
        Button_Setting.onClick.AddListener(Setting);
        Button_About.onClick.AddListener(About);
        Button_Cancel.onClick.AddListener(Cancel);
    }

    void Login()
    {
        ui_Main.SetActive(false);
        ui_Info.SetActive(true);
        ui_Start.SetActive(true);

    }
    void Setting()
    {
        ui_Main.SetActive(false);
        ui_Info.SetActive(true);
        ui_Setting.SetActive(true);

    }
    void About()
    {
        ui_Main.SetActive(false);
        ui_Info.SetActive(true);
        ui_About.SetActive(true);

    }
    void Cancel()
    {
        ui_Main.SetActive(true);
        ui_Start.SetActive(false);
        ui_Setting.SetActive(false);
        ui_About.SetActive(false);
        ui_Info.SetActive(false);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
