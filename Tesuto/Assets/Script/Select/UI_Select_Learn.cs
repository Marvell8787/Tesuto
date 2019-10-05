using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class UI_Select_Learn : MonoBehaviour {

    #region Variable
    private string choose_s = "";
    private int choose_n = 0;
    #endregion

    #region Variable Events
    EventTriggerType EPEnter = EventTriggerType.PointerEnter;
    EventTriggerType EPExit = EventTriggerType.PointerExit;
    EventTriggerType EPClick = EventTriggerType.PointerClick;
    #endregion

    #region Select
    public GameObject ui_Select, ui_Content;
    public GameObject[] GameObject_Level = new GameObject[7];
    public Text[] Text_Level = new Text[7];
    public Text Text_Info;
    public GameObject GameObject_Practice,GameObject_Challenge;
    public Button Button_Select_Cancel;
    #endregion

    #region Content
    public Button Button_Content_Cancel;
    public Text Text_QuestionType, Text_Range, Text_Reward, Text_Punishment, Text_HighestScore;
    public Text Text_QuestionType_Content, Text_Range_Content, Text_Reward_Content, Text_Punishment_Content, Text_HighestScore_Content;
    #endregion

    #region Button
    public Button Button_Back, Button_Practice, Button_Challenge,Button_Start;
    #endregion

    #region AudioSource
    public AudioSource ok, cancel;
    #endregion


    void Start () {

        Level_Data.Level_Init();

        Level_Class[] level_temp = new Level_Class[7];
        for (int i = 0; i < 7; i++)
        {
            level_temp[i] = Level_Data.Level_Get(i);
            Text_Level[i].text = "";
        }

        #region Select_Learn PointerEnter
        AddEvents.AddTriggersListener(GameObject_Practice, EPEnter, Select_Learn_PointerEnter.Practice);
        AddEvents.AddTriggersListener(GameObject_Challenge, EPEnter, Select_Learn_PointerEnter.Challenge);
        #endregion

        #region Select_Learn PointerExit
        AddEvents.AddTriggersListener(GameObject_Practice, EPExit, Select_Learn_PointerExit.Exit);
        AddEvents.AddTriggersListener(GameObject_Challenge, EPExit, Select_Learn_PointerExit.Exit);
        #endregion

        #region Select_Learn PointerClick
        AddEvents.AddTriggersListener(GameObject_Level[0], EPClick, Learn_0);
        AddEvents.AddTriggersListener(GameObject_Level[1], EPClick, Learn_1);
        AddEvents.AddTriggersListener(GameObject_Level[2], EPClick, Learn_2);
        AddEvents.AddTriggersListener(GameObject_Level[3], EPClick, Learn_3);
        AddEvents.AddTriggersListener(GameObject_Level[4], EPClick, Learn_4);
        AddEvents.AddTriggersListener(GameObject_Level[5], EPClick, Learn_5);
        AddEvents.AddTriggersListener(GameObject_Level[6], EPClick, Learn_6);
        #endregion

        Button_Practice.onClick.AddListener(Practice);
        Button_Challenge.onClick.AddListener(Challenge);

        Button_Back.onClick.AddListener(Back);
        Button_Start.onClick.AddListener(Play);

        Button_Select_Cancel.onClick.AddListener(Select_Cancel);
        Button_Content_Cancel.onClick.AddListener(Content_Cancel);
    }

    #region Task PointerClick Function
    public void Learn_0(BaseEventData data)
    {
        if (choose_s != "")
        {
            ok.Play();
            choose_n = 0;
            ShowContent(0);
            ui_Content.SetActive(true);
        }

    }
    public void Learn_1(BaseEventData data)
    {
        if (choose_s != "")
        {
            ok.Play();
            choose_n = 1;
            ShowContent(1);
            ui_Content.SetActive(true);
        }
    }
    public void Learn_2(BaseEventData data)
    {
        if (choose_s != "")
        {
            ok.Play();
            choose_n = 2;
            ShowContent(2);
            ui_Content.SetActive(true);
        }
    }
    public void Learn_3(BaseEventData data)
    {
        if (choose_s != "")
        {
            ok.Play();
            choose_n = 3;
            ShowContent(3);
            ui_Content.SetActive(true);
        }
    }
    public void Learn_4(BaseEventData data)
    {
        if (choose_s != "")
        {
            ok.Play();
            choose_n = 4;
            ShowContent(4);
            ui_Content.SetActive(true);
        }
    }
    public void Learn_5(BaseEventData data)
    {
        if (choose_s != "")
        {
            ok.Play();
            choose_n = 5;
            ShowContent(5);
            ui_Content.SetActive(true);
        }
    }
    public void Learn_6(BaseEventData data)
    {
        if (choose_s != "")
        {
            ok.Play();
            choose_n = 6;
            ShowContent(6);
            ui_Content.SetActive(true);
        }
    }
    #endregion

    void Select_Cancel()
    {
        cancel.Play();
        ui_Select.SetActive(false);
        ui_Content.SetActive(false);

    }
    void Content_Cancel()
    {
        cancel.Play();
        ui_Content.SetActive(false);
    }
    void Back()
    {
        SceneManager.LoadScene("Main");
    }
    void Play() //開始關卡
    {

    }
    void Practice()
    {
        ui_Select.SetActive(true);
        choose_s = "practice";
        Level_Class[] level_temp = new Level_Class[7];
        for (int i = 0; i < 7; i++)
        {
            level_temp[i] = Level_Data.Level_Get(i);
            Text_Level[i].text = level_temp[i].GetTitle();
        }
    }

    void Challenge()
    {
        ui_Select.SetActive(true);
        choose_s = "challenge";
        Level_Class[] level_temp = new Level_Class[7];
        for (int i = 0; i < 7; i++)
        {
            level_temp[i] = Level_Data.Level_Get(i);
            Text_Level[i].text = level_temp[i].GetTitle();
        }
    }
    void ShowContent(int n)
    {
        Level_Class level_temp = new Level_Class();
        level_temp = Level_Data.Level_Get(n);

        Task_Class task_temp = new Task_Class();
        task_temp = Task_Data.Learn_Get(n);

        Text_QuestionType_Content.text = level_temp.GetQuestionType();
        Text_Range_Content.text = level_temp.GetRange();
        Text_Reward_Content.text = level_temp.GetReward();
        Text_Punishment_Content.text = level_temp.GetPunishment();
        Text_HighestScore_Content.text = level_temp.GetHighestScore();

        if (task_temp.GetStatus() == 2 && choose_s == "challenge")
        {
            Button_Start.interactable = true;
        }
        else if (choose_s == "practice")
        {
            Button_Start.interactable = true;
        }
        else
        {
            Button_Start.interactable = false;
        }

    }
}
