using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class UI_Task : MonoBehaviour {

    #region Variable
    private string choose_s="";
    private int choose_n = 0;
    #endregion

    #region Variable Events
    EventTriggerType EPEnter = EventTriggerType.PointerEnter;
    EventTriggerType EPExit = EventTriggerType.PointerExit;
    EventTriggerType EPClick = EventTriggerType.PointerClick;
    #endregion

    #region Home
    public GameObject ui_Home, ui_Task_Goal;
    public AudioSource ok, cancel,choose;
    public Text Text_Info;
    #endregion

    #region Task 
    public GameObject ui_Task, ui_Task_Content;
    public GameObject  Image_Task_Learn, Image_Task_Battle; //Image
    public Button Button_Task_Cancel, Button_Task_Content_Cancel;
    public GameObject Image_Task_Memo, Image_Task_Content; //Image
    public GameObject[] GameObject_Task = new GameObject[7];
    public Text[] Text_Task = new Text[7];
    #endregion

    #region Task Content
    public Text Text_Threshold, Text_Request, Text_Reward, Text_Punishment;
    public Text Text_Threshold_Content, Text_Request_Content, Text_Reward_Content, Text_Punishment_Content;
    public Button Button_Take;
    #endregion

    // Use this for initialization
    void Start () {
        for(int i = 0; i < 7; i++)
        {
            Text_Task[i].text = "";
        }
        Button_Take.onClick.AddListener(Take);

        #region Task PointerEnter
        AddEvents.AddTriggersListener(Image_Task_Learn, EPEnter, Enter_Task_Learn);
        AddEvents.AddTriggersListener(Image_Task_Battle, EPEnter, Enter_Task_Battle);
        #endregion

        #region Task PointerExit
        AddEvents.AddTriggersListener(Image_Task_Learn, EPExit, Exit);
        AddEvents.AddTriggersListener(Image_Task_Battle, EPExit, Exit);
        #endregion

        #region Task PointerClick
        AddEvents.AddTriggersListener(Image_Task_Learn, EPClick, Click_Task_Learn);
        AddEvents.AddTriggersListener(Image_Task_Battle, EPClick, Click_Task_Battle);
        AddEvents.AddTriggersListener(GameObject_Task[0], EPClick, Task_0);
        AddEvents.AddTriggersListener(GameObject_Task[1], EPClick, Task_1);
        AddEvents.AddTriggersListener(GameObject_Task[2], EPClick, Task_2);
        AddEvents.AddTriggersListener(GameObject_Task[3], EPClick, Task_3);
        AddEvents.AddTriggersListener(GameObject_Task[4], EPClick, Task_4);
        AddEvents.AddTriggersListener(GameObject_Task[5], EPClick, Task_5);
        AddEvents.AddTriggersListener(GameObject_Task[6], EPClick, Task_6);
        #endregion

        #region Task Cancel
        Button_Task_Cancel.onClick.AddListener(Task_Cancel);
        Button_Task_Content_Cancel.onClick.AddListener(Task_Content_Cancel);
        #endregion
    }

    #region Task PointerEnter Function
    void Enter_Task_Learn(BaseEventData data)
    {
        choose.Play();
        Text_Info.text = "這是任務中的學習分類\n點擊可觀看學習任務";
    }
    void Enter_Task_Battle(BaseEventData data)
    {
        choose.Play();
        Text_Info.text = "這是任務中的戰鬥分類\n點擊可觀看戰鬥任務";
    }
    #endregion

    #region Task PointerExit Function
    void Exit(BaseEventData data)
    {
        Text_Info.text = "點擊文字可觀看任務資訊\n點擊旁邊的圖像可選擇要接的任務類別";
    }
    #endregion

    #region Task PointerClick Function
    void Click_Task_Learn(BaseEventData data)
    {
        ui_Task_Content.SetActive(false);
        for (int i = 0; i < 7; i++)
        {
            Text_Task[i].text = "";
        }
        choose_s = "learn";
        ok.Play();
        Task_Class[] learn_temp = new Task_Class[7];
        for (int i = 0; i < 7; i++)
        {
            learn_temp[i] = Task_Data.Learn_Get(i);
            Text_Task[i].text = learn_temp[i].GetTitle();
            switch (learn_temp[i].GetStatus())
            {
                case 0: //未接 未達門檻
                    Text_Task[i].color = Color.black;
                    Text_Task[i].fontStyle = FontStyle.Normal;
                    break;
                case 1: //未接 已達門檻
                    Text_Task[i].color = Color.black;
                    Text_Task[i].fontStyle = FontStyle.Bold;
                    break;
                case 2: //接下
                    Text_Task[i].color = Color.blue;
                    Text_Task[i].fontStyle = FontStyle.Bold;
                    break;
                case 3: //完成
                    Text_Task[i].color = Color.gray;
                    Text_Task[i].fontStyle = FontStyle.Italic;
                    break;
                default:
                    break;
            }
        }
    }
    void Click_Task_Battle(BaseEventData data)
    {
        ui_Task_Content.SetActive(false);
        for (int i = 0; i < 7; i++)
        {
            Text_Task[i].text = "";
        }
        choose_s = "battle";
        ok.Play();
        Task_Class[] battle_temp = new Task_Class[3];
        for (int i = 0; i < 3; i++)
        {
            battle_temp[i] = Task_Data.Battle_Get(i);
            Text_Task[i].text = battle_temp[i].GetTitle();
            switch (battle_temp[i].GetStatus())
            {
                case 0: //未接 未達門檻
                    Text_Task[i].color = Color.black;
                    Text_Task[i].fontStyle = FontStyle.Normal;
                    break;
                case 1: //未接 已達門檻
                    Text_Task[i].color = Color.black;
                    Text_Task[i].fontStyle = FontStyle.Bold;
                    break;
                case 2: //接下
                    Text_Task[i].color = Color.blue;
                    Text_Task[i].fontStyle = FontStyle.Bold;
                    break;
                case 3: //完成
                    Text_Task[i].color = Color.gray;
                    Text_Task[i].fontStyle = FontStyle.Italic;
                    break;
                default:
                    break;
            }
        }
    }
    void Task_0(BaseEventData data)
    {
        if (choose_s != "")
        {
            ok.Play();
            Button_Change(0);
            ShowContent(0);
            choose_n = 0;
            ui_Task_Content.SetActive(true);
        }

    }
    void Task_1(BaseEventData data)
    {
        if (choose_s != "")
        {
            ok.Play();
            Button_Change(1);
            ShowContent(1);
            choose_n = 1;
            ui_Task_Content.SetActive(true);
        }
    }
    void Task_2(BaseEventData data)
    {
        if (choose_s != "")
        {
            ok.Play();
            Button_Change(2);
            ShowContent(2);
            choose_n = 2;
            ui_Task_Content.SetActive(true);
        }
    }
    void Task_3(BaseEventData data)
    {
        if (choose_s != "")
        {
            ok.Play();
            Button_Change(3);
            ShowContent(3);
            choose_n = 3;
            ui_Task_Content.SetActive(true);
        }
    }
    void Task_4(BaseEventData data)
    {
        if (choose_s != "")
        {
            ok.Play();
            Button_Change(4);
            ShowContent(4);
            choose_n = 4;
            ui_Task_Content.SetActive(true);
        }
    }
    void Task_5(BaseEventData data)
    {
        if (choose_s != "")
        {
            ok.Play();
            Button_Change(5);
            ShowContent(5);
            choose_n = 5;
            ui_Task_Content.SetActive(true);
        }
    }
    void Task_6(BaseEventData data)
    {
        if (choose_s != "")
        {
            ok.Play();
            Button_Change(6);
            ShowContent(6);
            choose_n = 6;
            ui_Task_Content.SetActive(true);
        }
    }
    #endregion


    #region Task Cancel
    void Task_Cancel()
    {
        cancel.Play();
        ui_Task.SetActive(false);
        ui_Task_Content.SetActive(false);
        ui_Home.SetActive(true);
        ui_Task_Goal.SetActive(true);
        Text_Info.text = "這邊是資訊欄\n移至圖像可得知相關資訊";
    }
    void Task_Content_Cancel()
    {
        cancel.Play();
        ui_Task_Content.SetActive(false);
    }
    #endregion

    void Button_Change(int n)
    {
        int status;
        Task_Class task_temp = new Task_Class();
        if (choose_s == "learn")
            task_temp = Task_Data.Learn_Get(n);
        else if (choose_s == "battle")
            task_temp = Task_Data.Battle_Get(n);

        status = task_temp.GetStatus();

        switch (status)
        {
            case 0: //未接 但未達門檻
                Button_Take.interactable = false;
                break;
            case 1: //未接 但已達門檻
                Button_Take.interactable = true;
                break;
            case 2: //接下
                Button_Take.interactable = false;
                break;
            case 3: //已完成
                Button_Take.interactable = false;
                break;
            default:
                break;
        }
    }
    void ShowContent(int n)
    {
        Task_Class task_temp = new Task_Class();
        if (choose_s == "learn")
            task_temp = Task_Data.Learn_Get(n);
        else if (choose_s == "battle")
            task_temp = Task_Data.Battle_Get(n);

        Text_Threshold_Content.text = task_temp.GetThreshold();
        Text_Request_Content.text = task_temp.GetRequest();
        Text_Reward_Content.text = task_temp.GetReward();
        Text_Punishment_Content.text = task_temp.GetPunishment();
    }
    void Take()
    {
        ok.Play();
        //改變狀態
        Task_Data.ChangeStatus(choose_s, choose_n, 2);
        Task_Class task_temp = new Task_Class();

        if (choose_s == "learn")
            task_temp = Task_Data.Learn_Get(choose_n);
        else if (choose_s == "battle")
            task_temp = Task_Data.Battle_Get(choose_n);

        Button_Take.interactable = false;

        Text_Task[choose_n].text = task_temp.GetTitle();
        Text_Task[choose_n].color = Color.blue;
    }
}
