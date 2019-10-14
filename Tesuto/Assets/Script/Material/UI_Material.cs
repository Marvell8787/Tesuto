using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
public class UI_Material : MonoBehaviour {

    #region Variable 
    private int ten = 0; //0 10
    private int No = 0; //0 1 2 3 4 5 6 7 8 9 10...
    #endregion

    #region Variable Events
    EventTriggerType EPEnter = EventTriggerType.PointerEnter;
    EventTriggerType EPExit = EventTriggerType.PointerExit;
    EventTriggerType EPClick = EventTriggerType.PointerClick;
    #endregion

    #region Material
    public GameObject Voice;
    public Button Button_Back;
    public Button[] Btn = new Button[10];
    public Text[] Btn_text = new Text[10];
    public Text Text_Num, Text_E_Name, Text_C_Name, Text_PartOfSpeech, Text_Sentence, Text_Info, Button_Back_Text;
    public GameObject[] Direction = new GameObject[4]; //up down left right
    public AudioSource[] voice = new AudioSource[20];
    public AudioSource Ok,PageTurning;
    #endregion


    // Use this for initialization
    void Start () {

        #region Material PointerEnter
        AddEvents.AddTriggersListener(Direction[0], EPEnter, Enter_Up);
        AddEvents.AddTriggersListener(Direction[1], EPEnter, Enter_Down);
        AddEvents.AddTriggersListener(Direction[2], EPEnter, Enter_Left);
        AddEvents.AddTriggersListener(Direction[3], EPEnter, Enter_Right);
        AddEvents.AddTriggersListener(Voice, EPEnter, Enter_Voice);
        #endregion

        #region Material PointerExit
        AddEvents.AddTriggersListener(Direction[0], EPExit, Exit);
        AddEvents.AddTriggersListener(Direction[1], EPExit, Exit);
        AddEvents.AddTriggersListener(Direction[2], EPExit, Exit);
        AddEvents.AddTriggersListener(Direction[3], EPExit, Exit);
        AddEvents.AddTriggersListener(Voice, EPExit, Exit);
        #endregion

        #region Material PointerClick
        AddEvents.AddTriggersListener(Direction[0], EPClick, Click_Up);
        AddEvents.AddTriggersListener(Direction[1], EPClick, Click_Down);
        AddEvents.AddTriggersListener(Direction[2], EPClick, Click_Left);
        AddEvents.AddTriggersListener(Direction[3], EPClick, Click_Right);
        AddEvents.AddTriggersListener(Voice, EPClick, Play);
        #endregion

        #region Button
        Button_Back.onClick.AddListener(Back);
        Btn[0].onClick.AddListener(Button_1);
        Btn[1].onClick.AddListener(Button_2);
        Btn[2].onClick.AddListener(Button_3);
        Btn[3].onClick.AddListener(Button_4);
        Btn[4].onClick.AddListener(Button_5);
        Btn[5].onClick.AddListener(Button_6);
        Btn[6].onClick.AddListener(Button_7);
        Btn[7].onClick.AddListener(Button_8);
        Btn[8].onClick.AddListener(Button_9);
        Btn[9].onClick.AddListener(Button_10);
        #endregion

        ChangeButtonText();
        ShowContent(No);
    }

    #region Material PointerEnter
    void Enter_Up(BaseEventData data)
    {
        Text_Info.text = "上一頁";
    }
    void Enter_Down(BaseEventData data)
    {
        Text_Info.text = "下一頁";
    }
    void Enter_Left(BaseEventData data)
    {
        Text_Info.text = "上一個";
    }
    void Enter_Right(BaseEventData data)
    {
        Text_Info.text = "下一個";
    }
    void Enter_Voice(BaseEventData data)
    {
        Text_Info.text = "點擊即可播放音檔";
    }
    #endregion

    #region Material PointerExit
    void Exit(BaseEventData data)
    {
        Text_Info.text = "這邊是資訊欄\n移至圖像可得知相關資訊";
    }
    #endregion

    #region Material PointerClick
    void Click_Right(BaseEventData data)
    {
        PageTurning.Play();
        if (No > 8 && ten == 10)
        {
            No = 0;
            ten = 0;
            ChangeButtonText();
        }
        else
        {
            No++;
            if (No == 10)
            {
                ten = 10;
                No = 0;
                ChangeButtonText();
            }
        }
        ShowContent(No + ten);
    }
    void Click_Left(BaseEventData data)
    {
        PageTurning.Play();
        if (No < 1 && ten == 0)
        {
            No = 9;
            ten = 10;
            ChangeButtonText();
        }
        else
        {
            No--;
            if (No == -1)
            {
                ten = 0;
                No = 9;
                ChangeButtonText();
            }
        }
        ShowContent(No + ten);
    }
    void Click_Up(BaseEventData data)
    {
        PageTurning.Play();
        if (ten == 0)
            ten = 10;
        else
            ten = 0;
        ShowContent(No + ten);
        ChangeButtonText();
    }
    void Click_Down(BaseEventData data)
    {
        PageTurning.Play();
        if (ten == 10)
            ten = 0;
        else
            ten = 10;
        ShowContent(No + ten);
        ChangeButtonText();
    }

    void Play(BaseEventData data)
    {
        voice[No + ten].Play();
    }
    #endregion

    #region Btn
    void Button_1()
    {
        No = 0;
        ShowContent(No + ten);
    }
    void Button_2()
    {
        No = 1;
        ShowContent(No + ten);
    }
    void Button_3()
    {
        No = 2;
        ShowContent(No + ten);
    }
    void Button_4()
    {
        No = 3;
        ShowContent(No + ten);
    }
    void Button_5()
    {
        No = 4;
        ShowContent(No + ten);
    }
    void Button_6()
    {
        No = 5;
        ShowContent(No + ten);
    }
    void Button_7()
    {
        No = 6;
        ShowContent(No + ten);
    }
    void Button_8()
    {
        No = 7;
        ShowContent(No + ten);
    }
    void Button_9()
    {
        No = 8;
        ShowContent(No + ten);
    }
    void Button_10()
    {
        No = 9;
        ShowContent(No + ten);
    }
    #endregion

    void ShowContent(int n)
    {
        Vocabulary_Class vocabulary_temp = new Vocabulary_Class();
        vocabulary_temp = Vocabulary_Data.Vocabulary_Get(n);

        Text_Num.text = (n + 1).ToString() + ".";
        Text_E_Name.text = vocabulary_temp.GetE_Name();
        Text_C_Name.text = vocabulary_temp.GetC_Name();
        Text_PartOfSpeech.text = vocabulary_temp.GetPartOfSpeech();
        Text_Sentence.text = vocabulary_temp.GetSentence();
    }
    void ChangeButtonText()
    {
        Vocabulary_Class vocabulary_temp = new Vocabulary_Class();

        for (int i = 0; i < 10; i++)
        {
            vocabulary_temp = Vocabulary_Data.Vocabulary_Get(ten + i);
            Btn_text[i].text = vocabulary_temp.GetE_Name();
        }
    }
    void Back()
    {
        Ok.Play();
        SceneManager.LoadScene("Main");
    }
}
