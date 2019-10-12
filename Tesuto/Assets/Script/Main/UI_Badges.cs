using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class UI_Badges : MonoBehaviour {

    #region Variable
    private int PageUp = 1;

    private int No = 0;
    private int Item = 0; //0 3
    private int Page = 0; //0 9
    #endregion

    #region Variable Events
    EventTriggerType EPClick = EventTriggerType.PointerClick;
    #endregion

    #region Home
    public GameObject ui_Home, ui_Task_Goal;
    public AudioSource ok, cancel, choose;
    public Text Text_Info;
    #endregion

    #region Badges
    public GameObject ui_Badges;
    public GameObject[] GameObject_Badges = new GameObject[9]; //Image
    public Image[] Image_Badges = new Image[9]; //Image
    public Button Button_Badges_Cancel;
    public GameObject[] GameObject_Item = new GameObject[3];
    public Text[] Text_Item = new Text[3];
    public Text Text_PageUp;
    public GameObject Right, Left;
    #endregion

    // Use this for initialization
    void Start () {

        #region Badges PointerClick
        AddEvents.AddTriggersListener(GameObject_Badges[0], EPClick, Badges_0);
        AddEvents.AddTriggersListener(GameObject_Badges[1], EPClick, Badges_1);
        AddEvents.AddTriggersListener(GameObject_Badges[2], EPClick, Badges_2);
        AddEvents.AddTriggersListener(GameObject_Badges[3], EPClick, Badges_3);
        AddEvents.AddTriggersListener(GameObject_Badges[4], EPClick, Badges_4);
        AddEvents.AddTriggersListener(GameObject_Badges[5], EPClick, Badges_5);
        AddEvents.AddTriggersListener(GameObject_Badges[6], EPClick, Badges_6);
        AddEvents.AddTriggersListener(GameObject_Badges[7], EPClick, Badges_7);
        AddEvents.AddTriggersListener(GameObject_Badges[8], EPClick, Badges_8);

        AddEvents.AddTriggersListener(Right, EPClick, Next);
        AddEvents.AddTriggersListener(Left, EPClick, Previous);

        Button_Badges_Cancel.onClick.AddListener(Badges_Cancel);
        #endregion

        for (int i = 0; i < 3; i++)
        {
            switch (System_Setting.Language)
            {
                case 0:
                    Text_Item[i].text = Badges_Bank.C_Badges_Name[i + Item];
                    break;
                case 1:
                    Text_Item[i].text = Badges_Bank.E_Badges_Name[i + Item];
                    break;
                default:
                    break;
            }
        }
    }
    void Previous(BaseEventData data)
    {
        if (PageUp > 1)
        {
            PageUp--;
            Item = 0;
            Page = 0;
            PageChage();
        }

    }
    void Next(BaseEventData data)
    {
        if (PageUp < 2)
        {
            PageUp++;
            Item = 3;
            Page = 9;
            PageChage();
        }

    }
    void PageChage()
    {
        Text_PageUp.text = PageUp.ToString();
        for (int i = 0; i < 3; i++)
        {
            switch (System_Setting.Language)
            {
                case 0:
                    Text_Item[i].text = Badges_Bank.C_Badges_Name[i + Item];
                    break;
                case 1:
                    Text_Item[i].text = Badges_Bank.E_Badges_Name[i + Item];
                    break;
                default:
                    break;
            }
        }
        ShowPicture();
    }
    void ShowPicture()
    {
        int[] badges_temp = new int[9];

        for (int i = 0; i < 9; i++)
            badges_temp[i] = Learner_Data.Learner_GetBadges_Status(i+ Page);

        for (int i = 0; i < 9; i++)
        {
            if (badges_temp[i] == 1)
                Image_Badges[i].color = new Color32(255, 255, 255, 255);
            else
                Image_Badges[i].color = new Color32(60, 60, 60, 255);
        }
    }

    void Badges_Cancel()
    {
        cancel.Play();
        ui_Badges.SetActive(false);
        ui_Home.SetActive(true);
        ui_Task_Goal.SetActive(true);
        Text_Info.text = "這邊是資訊欄\n移至圖像可得知相關資訊";
    }

    #region Badges Image
    void Badges_Output(int n)
    {
        switch (System_Setting.Language)
        {
            case 0:
                Text_Info.text = Badges_Bank.C_Badges_Description[n];
                break;
            case 1:
                Text_Info.text = Badges_Bank.E_Badges_Description[n];
                break;
            default:
                break;
        }
    }
    void Badges_0(BaseEventData data)
    {
        No = 0 + Page;
        Badges_Output(No);
    }
    void Badges_1(BaseEventData data)
    {
        No = 1 + Page;
        Badges_Output(No);
    }
    void Badges_2(BaseEventData data)
    {
        No = 2 + Page;
        Badges_Output(No);
    }
    void Badges_3(BaseEventData data)
    {
        No = 3 + Page;
        Badges_Output(No);
    }
    void Badges_4(BaseEventData data)
    {
        No = 4 + Page;
        Badges_Output(No);
    }
    void Badges_5(BaseEventData data)
    {
        No = 5 + Page;
        Badges_Output(No);
    }
    void Badges_6(BaseEventData data)
    {
        No = 6 + Page;
        Badges_Output(No);
    }
    void Badges_7(BaseEventData data)
    {
        No = 7 + Page;
        Badges_Output(No);
    }
    void Badges_8(BaseEventData data)
    {
        No = 8 + Page;
        Badges_Output(No);
    }
    #endregion
}
