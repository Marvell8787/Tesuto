using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
public class UI_Select_Battle : MonoBehaviour {

    #region Variable
    private string choose_s = "";
    private int choose_n = 0;
    private int n1 = 0, n2 = 0;
    #endregion

    #region Variable Events
    EventTriggerType EPEnter = EventTriggerType.PointerEnter;
    EventTriggerType EPExit = EventTriggerType.PointerExit;
    EventTriggerType EPClick = EventTriggerType.PointerClick;
    #endregion
    
    #region Select
    public GameObject ui_Select, ui_Content, ui_ChallengeContent;
    public GameObject[] GameObject_Battle = new GameObject[3];
    public Text[] Text_Battle = new Text[3];
    public Text Text_Info;
    public GameObject GameObject_Practice, GameObject_Challenge, GameObject_Start;
    public Text Button_Practice_Text, Button_Challenge_Text, Button_Start_Text,Button_Back_Text;
    public Button Button_Select_Cancel;
    #endregion

    #region Content
    public Button Button_Content_Cancel;
    public Text Text_QuestionType, Text_Range, Text_Reward, Text_Punishment, Text_Time, Text_LP, Text_Deck;
    public Text Text_QuestionType_Content, Text_Range_Content, Text_Reward_Content, Text_Punishment_Content, Text_Time_Content, Text_LP_Content, Text_Deck_Content;
    #endregion

    #region ChallengeContent
    public Button Button_Challenge_Content_Cancel;
    public Text Text_Challenge_Threshold, Text_Challenge_Request, Text_Challenge_Reward, Text_Challenge_Punishment;
    public Text Text_Challenge_Threshold_Content, Text_Challenge_Request_Content, Text_Challenge_Reward_Content, Text_Challenge_Punishment_Content;
    #endregion

    #region Button
    public Button Button_Back, Button_Practice, Button_Challenge, Button_Start;
    #endregion

    #region AudioSource
    public AudioSource ok, cancel, choose;
    #endregion

    #region Learner
    public Text Text_Learner_LP;
    public Text Text_Learner_Deck;
    public Text Text_Learner_Deck_Num;
    #endregion

    void Start()
    {
        Button_Practice_Text.text = System_Interface.SelectBattle_Button_Practice_Text;
        Button_Challenge_Text.text = System_Interface.SelectBattle_Button_Challenge_Text;
        Button_Back_Text.text = System_Interface.SelectBattle_Button_Back_Text;
        Text_Info.text = System_Interface.SelectBattle_Info_Text;

        Text_QuestionType.text = System_Interface.SelectBattle_Practice_QuestionType_Text;
        Text_Range.text = System_Interface.SelectBattle_Practice_Range_Text;
        Text_Reward.text = System_Interface.SelectBattle_Practice_Reward_Text;
        Text_Punishment.text = System_Interface.SelectBattle_Practice_Punishment_Text;
        Text_Time.text = System_Interface.SelectBattle_Practice_Time_Text;
        Text_LP.text = System_Interface.SelectBattle_Practice_LP_Text;
        Text_Deck.text = System_Interface.SelectBattle_Practice_Deck_Text;
        Button_Start_Text.text = System_Interface.SelectBattle_Button_Start_Text;

        Text_Challenge_Threshold.text = System_Interface.SelectBattle_Challenge_Threshold_Text;
        Text_Challenge_Request.text = System_Interface.SelectBattle_Challenge_Request_Text;
        Text_Challenge_Reward.text = System_Interface.SelectBattle_Challenge_Reward_Text;
        Text_Challenge_Punishment.text = System_Interface.SelectBattle_Challenge_Punishment_Text;

        Text_Learner_LP.text = System_Interface.SelectBattle_Learner_LP_Text;
        Text_Learner_Deck.text = System_Interface.SelectBattle_Learner_Deck_Text;

        Battle_Data.Battle_Init();
        Battle_Class[] battle_temp = new Battle_Class[3];
        for (int i = 0; i < 3; i++)
        {
            battle_temp[i]=Battle_Data.Battle_Get(i);
            Text_Battle[i].text = "";
        }

        #region Select_Learn PointerEnter
        AddEvents.AddTriggersListener(GameObject_Practice, EPEnter, Enter_Practice);
        AddEvents.AddTriggersListener(GameObject_Challenge, EPEnter, Enter_Challenge);
        #endregion

        #region Select_Learn PointerExit
        AddEvents.AddTriggersListener(GameObject_Practice, EPExit, Exit);
        AddEvents.AddTriggersListener(GameObject_Challenge, EPExit, Exit);
        #endregion

        #region Select_Learn PointerClick
        AddEvents.AddTriggersListener(GameObject_Battle[0], EPClick, Battle_0);
        AddEvents.AddTriggersListener(GameObject_Battle[1], EPClick, Battle_1);
        AddEvents.AddTriggersListener(GameObject_Battle[2], EPClick, Battle_2);
        #endregion

        Button_Practice.onClick.AddListener(Click_Practice);
        Button_Challenge.onClick.AddListener(Click_Challenge);

        Button_Back.onClick.AddListener(Back);
        Button_Start.onClick.AddListener(Play);

        Button_Select_Cancel.onClick.AddListener(Select_Cancel);
        Button_Content_Cancel.onClick.AddListener(Content_Cancel);
        Button_Challenge_Content_Cancel.onClick.AddListener(Content_Cancel);

        Text_Learner_Deck_Num.text = Learner_Data.Learner_GetData("Cards_Num").ToString();
    }

    #region Select_Battle PointerEnter
    void Enter_Practice(BaseEventData data)
    {
        choose.Play();
        Text_Info.text = System_Interface.SelectBattle_Info_Practice_Text;
    }
    void Enter_Challenge(BaseEventData data)
    {
        choose.Play();
        Text_Info.text = System_Interface.SelectBattle_Info_Challenge_Text;
    }
    #endregion

    #region Select_Battle PointerExit
    void Exit(BaseEventData data)
    {
        Text_Info.text = System_Interface.SelectBattle_Info_Text;
    }
    #endregion

    #region Select_Battle PointerClick Function
    void Battle_0(BaseEventData data)
    {
        if (choose_s != "" && Text_Battle[0].text != "")
        {
            ok.Play();
            choose_n = 0;
            ShowContent(0);
            n1 = 1; n2 = 5;
        }

    }
    void Battle_1(BaseEventData data)
    {
        if (choose_s != "" && Text_Battle[1].text != "")
        {
            ok.Play();
            choose_n = 1;
            ShowContent(1);
            n1 = 1; n2 = 15;
        }
    }
    void Battle_2(BaseEventData data)
    {
        if (choose_s != "" && Text_Battle[2].text != "")
        {
            ok.Play();
            choose_n = 2;
            ShowContent(2);
            n1 = 1; n2 = 20;
        }
    }
    #endregion

    void Select_Cancel()
    {
        cancel.Play();
        ui_Select.SetActive(false);
        ui_Content.SetActive(false);
        ui_ChallengeContent.SetActive(false);
        GameObject_Start.SetActive(false);
    }
    void Content_Cancel()
    {
        cancel.Play();
        ui_Content.SetActive(false);
        ui_ChallengeContent.SetActive(false);
        GameObject_Start.SetActive(false);
    }
    void Back()
    {
        ok.Play();
        SceneManager.LoadScene("Main");
    }
    void Play() //開始關卡
    {

        Battle_Class battle_temp = new Battle_Class();
        battle_temp=Battle_Data.Battle_Get(choose_n);
        int n3 = int.Parse(battle_temp.GetTime());
        ok.Play();
        if (choose_s == "challenge")
            Question_Data.Question_Init(7, n1, n2, n3, 1); // Question_Data 7指向戰鬥用的問題
        else
            Question_Data.Question_Init(7, n1, n2, n3,0);
        Player_Data.Player_Init(choose_n);
        Player_Data.Shuffle(0);
        Player_Data.Shuffle(1);
        Player_Data.Deal();
        SceneManager.LoadScene("Battle");

    }
    void Click_Practice()
    {
        Battle_Class[] battle_temp = new Battle_Class[3];
        ui_Content.SetActive(false);
        ui_ChallengeContent.SetActive(false);
        GameObject_Start.SetActive(false);
        ok.Play();
        ui_Select.SetActive(true);
        choose_s = "practice";
        for (int i = 0; i < 3; i++)
        {
            battle_temp[i] = Battle_Data.Battle_Get(i);
            Text_Battle[i].text = battle_temp[i].GetTitle();
        }
    }

    void Click_Challenge()
    {
        Battle_Class[] battle_temp = new Battle_Class[3];
        ui_Content.SetActive(false);
        ui_ChallengeContent.SetActive(false);
        GameObject_Start.SetActive(false);
        ok.Play();
        Task_Class task_temp = new Task_Class();
        ui_Select.SetActive(true);
        choose_s = "challenge";
        for (int i = 0; i < 3; i++)
        {
            battle_temp[i] = Battle_Data.Battle_Get(i);
            task_temp = Task_Data.Battle_Get(i);
            if (task_temp.GetStatus() == 2 && choose_s == "challenge")
                Text_Battle[i].text = battle_temp[i].GetTitle();
            else
                Text_Battle[i].text = "";
        }
    }
    void ShowContent(int n)
    {
        Battle_Class battle_temp = new Battle_Class();
        battle_temp = Battle_Data.Battle_Get(n);

        Task_Class task_temp = new Task_Class();
        task_temp = Task_Data.Battle_Get(n);

        if (choose_s == "practice")
        {
            ui_Content.SetActive(true);
            Text_QuestionType_Content.text = battle_temp.GetQuestionType();
            Text_Range_Content.text = battle_temp.GetRange();
            Text_Reward_Content.text = battle_temp.GetReward();
            Text_Punishment_Content.text = battle_temp.GetPunishment();
            Text_Time_Content.text = battle_temp.GetTime();
            Text_LP_Content.text = battle_temp.GetLP();
            Text_Deck_Content.text = battle_temp.GetDeck();
        }
        else if (choose_s == "challenge")
        {
            ui_ChallengeContent.SetActive(true);
            Text_Challenge_Threshold_Content.text = task_temp.GetThreshold();
            Text_Challenge_Request_Content.text = task_temp.GetRequest();
            Text_Challenge_Reward_Content.text = task_temp.GetReward();
            Text_Challenge_Punishment_Content.text = task_temp.GetPunishment();
        }

        GameObject_Start.SetActive(true);

        if (task_temp.GetStatus() == 2 && choose_s == "challenge")
            Button_Start.interactable = true;
        else if (choose_s == "practice")
            Button_Start.interactable = true;
        else
            Button_Start.interactable = false;

    }
}
