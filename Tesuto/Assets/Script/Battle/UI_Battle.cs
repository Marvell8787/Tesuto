﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class UI_Battle : MonoBehaviour {

    #region Variable
    private int time_int = 6;
    private Player_Class Player = new Player_Class();
    private Player_Class Enemy = new Player_Class();
    //QurestionPhase
    private int Question_Num = 0;
    private int Question_total = 10;
    private string choose_Ans = "";
    private string choose_Ans_Content = "";
    //BattlePhase
    private Card_Class[] card_temp = new Card_Class[22];
    private int ATK_A = 0;
    private int ATK_B = 0;
    private int HandChooseA = 0; //選擇的手牌
    private int TypeChooseA = 0; //選擇牌的類型 1:前衛 2:中鋒 3:支援
    private int Vanguard_A = 22; //22:沒有 0~21:有
    private int Center_A = 22; //22:沒有 0~21:有
    private int Support_A = 22; //22:沒有 0~21:有
    private int Vanguard_B = 22; //22:沒有 0~21:有
    private int Center_B = 22; //22:沒有 0~21:有
    private int Support_B = 22; //22:沒有 0~21:有
    //B
    public static int HandChoose_B_V = 5; //敵方選擇的手牌 前衛卡
    public static int HandChoose_B_C = 5; //敵方選擇的手牌 中鋒卡
    public static int HandChoose_B_S = 5; //敵方選擇的手牌 支援卡
    //Settlement
    private int PageUP = 1;
    private int PageDown = 4;
    private int Page = 0; //0 5 10 15
    #endregion

    #region Variable Events
    EventTriggerType EPClick = EventTriggerType.PointerClick;
    #endregion

    #region Battle UI
    public GameObject ui_Info, ui_CardPlay, ui_HandPlay, ui_Phase,ui_Question,ui_Settlement;
    #endregion

    #region Battle Info
    public Image Image_Picture;
    public Text Text_Time,Text_Message,Text_LP_A, Text_LP_B, Text_Deck_A, Text_Deck_B, Text_CardType, Text_Effect, Text_ATK_A, Text_ATK_B;
    public Text Text_LP_A_Num, Text_LP_B_Num, Text_Deck_A_Num, Text_Deck_B_Num, Text_ATK_A_Num, Text_ATK_B_Num;
    #endregion

    #region Battle CardPlay
    public GameObject[] GameObject_Show_A = new GameObject[3];
    public GameObject[] GameObject_Show_B = new GameObject[3];
    public Image[] Image_Show_A = new Image[3];
    public Image[] Image_Show_B = new Image[3];
    #endregion

    #region Battle HandPlay
    public GameObject[] GameObject_Hand_A = new GameObject[5];
    public GameObject[] GameObject_Hand_B = new GameObject[5];
    public Image[] Image_Hand_A = new Image[5];
    public Image[] Image_Hand_B = new Image[5];
    #endregion

    #region Battle Phase
    public Button Button_Fight, Button_Summon, Button_Surrender;
    public Text Button_Summon_Text, Button_Fight_Text,  Button_Surrender_Text;
    #endregion

    #region Battle Question
    public Text Text_Question, Text_QuestionNum;
    public Text[] Text_Ans = new Text[3];
    public Button[] Button_Ans = new Button[3];
    public Button Button_Start;
    public Text Text_Answer, Text_ROW, Text_Start;
    #endregion

    #region Battle Settlement
    public Image Image_Item;
    public Text S_QNum, S_Question, S_Choose, S_Answer, S_Feedback, S_PageUp, S_PageDown, Text_ItemContent, Flag;
    public Text[] A_S_QNum = new Text[5];
    public Text[] A_S_Question = new Text[5];
    public Text[] A_S_Answer = new Text[5];
    public Text[] A_S_Choose = new Text[5];
    public Text[] A_S_Feedback = new Text[5];
    public Button Button_Back;
    public GameObject Right, Left;
    #endregion

    public GameObject GameObject_Count;
    public Text Text_Count;

    public GameObject GameObject_Next;
    public Button Button_Next;
    public Text Text_Next;

    public AudioSource ok,PageTurning;

    // Use this for initialization
    void Start () {
        //Init
            //Info Interface
        Text_LP_A.text = System_Interface.Battle_LP_A_Text;
        Text_LP_B.text = System_Interface.Battle_LP_B_Text;
        Text_Deck_A.text = System_Interface.Battle_Deck_A_Text;
        Text_Deck_B.text = System_Interface.Battle_Deck_B_Text;
        Text_CardType.text = System_Interface.Battle_CardType_Text;
        Text_Effect.text = System_Interface.Battle_Effect_Text;
        Text_Message.text = System_Interface.Battle_Message_Text;
            //Question Interface
        Text_Start.text = System_Interface.Battle_Question_Start_Text;
            //Main Interface
        Button_Summon_Text.text = System_Interface.Battle_Main_Button_Summon_Text;
        Button_Fight_Text.text = System_Interface.Battle_Main_Button_Fight_Text;
        Button_Surrender_Text.text = System_Interface.Battle_Main_Button_Surrender_Text;
        Text_Next.text = System_Interface.Battle_Battle_Next_Text;
            //Settlement Interface
        S_QNum.text = System_Interface.Battle_SettlementQuestionNum_Text;
        S_Question.text = System_Interface.Battle_SettlementQuestion_Text;
        S_Choose.text = System_Interface.Battle_SettlementChoose_Text;
        S_Answer.text = System_Interface.Battle_SettlementAnswer_Text;
        S_Feedback.text = System_Interface.Battle_SettlementFeedback_Text;

        Player = Player_Data.Player_Get(0);
        Enemy = Player_Data.Player_Get(1);

        Text_LP_A_Num.text = Player.GetLP().ToString();
        Text_Deck_A_Num.text = (Player.GetDeck_Num() - 5).ToString();
        Player.DecDeck_Num(5);
        Text_LP_B_Num.text = Enemy.GetLP().ToString();
        Text_Deck_B_Num.text = (Enemy.GetDeck_Num() - 5).ToString();
        Enemy.DecDeck_Num(5);
        //QuestionPhase
        Question_total = Question_Data.GetQtotal();
        Text_ATK_A_Num.text = "0";
        Text_ATK_B_Num.text = "0";
        Text_ROW.text = "";
        InvokeRepeating("timer", 1, 1);

        Button_Ans[0].onClick.AddListener(Choose_A);
        Button_Ans[1].onClick.AddListener(Choose_B);
        Button_Ans[2].onClick.AddListener(Choose_C);
        //MainPhase
        for (int i = 0; i < 22; i++)
            card_temp[i] = Card_Data.Card_Get(i);
        Button_Start.onClick.AddListener(BattleStart);
        Button_Summon.onClick.AddListener(Summon);
        AddEvents.AddTriggersListener(GameObject_Hand_A[0], EPClick, HA1);
        AddEvents.AddTriggersListener(GameObject_Hand_A[1], EPClick, HA2);
        AddEvents.AddTriggersListener(GameObject_Hand_A[2], EPClick, HA3);
        AddEvents.AddTriggersListener(GameObject_Hand_A[3], EPClick, HA4);
        AddEvents.AddTriggersListener(GameObject_Hand_A[4], EPClick, HA5);
        //BattlePhase
        Button_Fight.onClick.AddListener(FIGHT);
        Button_Next.onClick.AddListener(NEXT);
        //Settlement Phase
        AddEvents.AddTriggersListener(Right, EPClick, F_Right);
        AddEvents.AddTriggersListener(Left, EPClick, F_Left);
        Button_Back.onClick.AddListener(Back);

    }

    #region Count
    void timer()
    {
        time_int -= 1;
        Text_Count.text = (time_int - 1) + "";
        if (time_int == 1)
            Text_Count.text = "Play!";
        if (time_int == 0)
        {
            CancelInvoke("timer");
            Text_Count.text = "";
            GameObject_Count.SetActive(true);
            Question_Class question_temp = new Question_Class();
            Question_Num = 0; //init
            question_temp = Question_Data.Question_Get(0);
            Text_QuestionNum.text = (Question_Num + 1).ToString() + ".";
            Text_Question.text = question_temp.GetQuestion();
            Question_Data.Button_Ans_Set(Question_Data.GetLevel(), Question_Num);
            Text_Ans[0].text = Question_Data.GetButton_Ans(0);
            Text_Ans[1].text = Question_Data.GetButton_Ans(1);
            Text_Ans[2].text = Question_Data.GetButton_Ans(2);

            ui_Question.SetActive(true);
            Text_ROW.text = System_Interface.Battle_Question_Choose;
        }
    }
    #endregion

    #region Battle QuestionPhase Function
    void Choose_A()
    {
        choose_Ans = "A";
        choose_Ans_Content = Question_Data.GetButton_Ans(0);
        //Debug.Log(Question_Check.Choose_Ans_Content);

        CheckAns();
    }
    void Choose_B()
    {
        choose_Ans = "B";
        choose_Ans_Content = Question_Data.GetButton_Ans(1);
        //Debug.Log(Question_Check.Choose_Ans_Content);
        CheckAns();
    }
    void Choose_C()
    {
        choose_Ans = "C";
        choose_Ans_Content = Question_Data.GetButton_Ans(2);
        //Debug.Log(Question_Check.Choose_Ans_Content);

        CheckAns();
    }
    void CheckAns()
    {
        Button_Ans[0].interactable = false;
        Button_Ans[1].interactable = false;
        Button_Ans[2].interactable = false;

        Question_Class question_temp = new Question_Class();
        Question_Data.ChangeAnswer_c(choose_Ans, Question_Num);
        Question_Data.ChangeAnswer_c_Content(choose_Ans_Content, Question_Num);

        question_temp = Question_Data.Question_Get(Question_Num); ;
        Player = Player_Data.Player_Get(0);
        if (question_temp.GetAnswer_r() == question_temp.GetAnswer_c())
        {
            Question_Data.ChangeFeedBack("O", Question_Num);
            Text_Answer.text = "Ans： " + question_temp.GetAnswer_r_Content();
            Text_ROW.text = System_Interface.Battle_Question_Right;
        }
        else
        {
            Question_Data.ChangeFeedBack("X", Question_Num);
            Text_Answer.text = "Ans： " + question_temp.GetAnswer_r_Content();
            Text_ROW.text = System_Interface.Battle_Question_Wrong;

            Player.ChangeLP(Player.GetLP() - 5);
            Text_LP_A_Num.text = Player.GetLP().ToString();
        }

        if (Player.GetLP() < 1)
        {
            GameObject_Next.SetActive(true);
            Button_Next.interactable = true;
            Text_ROW.text = System_Interface.Battle_Question_GameOver;
            Text_Next.text = System_Interface.Battle_Question_Settlement;
        }
        else
        {
            Button_Start.interactable = true;
            Question_Num++;
        }
    }
    #endregion

    #region Battle MainPhase Function
    void BattleStart()
    {
        ui_Question.SetActive(false);
        Button_Surrender.interactable = true;
        Text_Message.text = System_Interface.Battle_Main_ChooseCard;
        ShowHand(0);
    }
    void Summon()
    {
        int n;

        Button_Summon.interactable = false;

        n = Player.GetHand_Status(HandChooseA);

        if (TypeChooseA == 1)
        {
            Vanguard_A = n;
            Text_ATK_A_Num.text = (card_temp[n].GetATK()) + " ";
            ATK_A = card_temp[n].GetATK();
            if (Center_A < 22)
            {
                int s = Center_A;
                switch (s)
                {
                    case 15:
                        Text_ATK_A_Num.text += "+ " + (card_temp[s].GetATK());
                        ATK_A += 1;
                        break;
                    case 16:
                        Text_ATK_A_Num.text += "+ " + (card_temp[s].GetATK());
                        ATK_A += 2;
                        break;
                    case 17:
                        Text_ATK_A_Num.text = (card_temp[s].GetATK()).ToString();
                        ATK_A += 3;
                        break;
                    case 18:
                        Text_ATK_A_Num.text = (card_temp[s].GetATK()).ToString();
                        ATK_A += 4;
                        break;
                    default:
                        break;
                }
            }
        }
        else if (TypeChooseA == 2)
        {
            Center_A = n;
            switch (n)
            {
                case 15:
                    Text_ATK_A_Num.text += "+ " + (card_temp[n].GetATK());
                    ATK_A += 1;
                    break;
                case 16:
                    Text_ATK_A_Num.text += "+ " + (card_temp[n].GetATK());
                    ATK_A += 2;
                    break;
                case 17:
                    Text_ATK_A_Num.text = (card_temp[n].GetATK()).ToString();
                    ATK_A += 3;
                    break;
                case 18:
                    Text_ATK_A_Num.text = (card_temp[n].GetATK()).ToString();
                    ATK_A += 4;
                    break;
                default:
                    break;
            }
        }
        else if (TypeChooseA == 3)
        {
            Support_A = n;
        }

        //Debug.Log(card_temp[Player.GetHand_Status(BattleCheck.HandChoose)].GetPicture());

        Image_Show_A[TypeChooseA-1].sprite = Resources.Load("Image/Card/" + card_temp[n].GetPicture(), typeof(Sprite)) as Sprite;
        Image_Hand_A[HandChooseA].sprite = Resources.Load("Image/Battle/Hand", typeof(Sprite)) as Sprite;
        Image_Hand_A[HandChooseA].color = new Color32(255, 255, 255, 255);

        Player.ChangeHand_Status(HandChooseA, 22);
        Button_Fight.interactable = true;
    }
    void HA1(BaseEventData data)
    {
        Reset();
        HandChooseA = 0;
        if (Player.GetHand_Status(0) < 22)
        {
            ShowPicture(Player.GetHand_Status(0));
            Image_Hand_A[0].color = new Color32(255, 0, 0, 255);
            CheckUSE(0);
        }
    }
    void HA2(BaseEventData data)
    {
        Reset();
        HandChooseA = 1;
        if (Player.GetHand_Status(1) < 22)
        {
            ShowPicture(Player.GetHand_Status(1));
            Image_Hand_A[1].color = new Color32(255, 0, 0, 255);
            CheckUSE(1);
        }
    }
    void HA3(BaseEventData data)
    {
        Reset();
        HandChooseA = 2;
        if (Player.GetHand_Status(2) < 22)
        {
            ShowPicture(Player.GetHand_Status(2));
            Image_Hand_A[2].color = new Color32(255, 0, 0, 255);
            CheckUSE(2);
        }
    }
    void HA4(BaseEventData data)
    {
        Reset();
        HandChooseA = 3;
        if (Player.GetHand_Status(3) < 22)
        {
            ShowPicture(Player.GetHand_Status(3));
            Image_Hand_A[3].color = new Color32(255, 0, 0, 255);
            CheckUSE(3);
        }
    }
    void HA5(BaseEventData data)
    {
        Reset();
        HandChooseA = 4;
        if (Player.GetHand_Status(4) < 22)
        {
            ShowPicture(Player.GetHand_Status(4));
            Image_Hand_A[4].color = new Color32(255, 0, 0, 255);
            CheckUSE(4);
        }
    }
    void Reset()
    {
        for (int i = 0; i < 5; i++)
            Image_Hand_A[i].color = new Color32(255, 255, 255, 255);
    }
    void CheckUSE(int s)
    {
        int n = Player.GetHand_Status(s);

        if (Player.GetHand_Status(s) > 21)
        {
            Button_Summon.interactable = false;

            return;
        }

        if (Vanguard_A == 22 && (card_temp[n].GetCType() == "Vanguard" || card_temp[n].GetCType() == "前衛"))
        {
            Button_Summon.interactable = true;
            TypeChooseA = 1;
        }
        else if (Center_A == 22 && (card_temp[n].GetCType() == "Center" || card_temp[n].GetCType() == "中鋒"))
        {
            Button_Summon.interactable = true;
            TypeChooseA = 2;
        }
        else if (Support_A == 22 && (card_temp[n].GetCType() == "Support" || card_temp[n].GetCType() == "支援"))
        {
            Button_Summon.interactable = true;
            TypeChooseA = 3;
        }
        else
        {
            Button_Summon.interactable = false;
            TypeChooseA = 0;
        }
    }
    void ShowPicture(int n)
    {
        Image_Picture.color = new Color32(255, 255, 255, 255);
        Image_Picture.sprite = Resources.Load("Image/Card/" + card_temp[n].GetPicture(), typeof(Sprite)) as Sprite;

        Text_CardType.text = card_temp[n].GetCType();
        Text_Effect.text = card_temp[n].GetEffect();
    }
    #endregion

    #region Battle BattlePhase Function
    void FIGHT()
    {
        TypeChooseA = 0;
        HandChooseA = 0;

        Button_Fight.interactable = false;

        ShowHand(0);
        ShowHand(1);
        Button_Summon.interactable = false;

        //描述電腦出牌 先出支援 再出魔法 最後出戰鬥(隨機挑)

        Enemy = Player_Data.Player_Get(1);

        int[] Ehand = new int[5];
        Ehand = GetRandomSequence(5);
        //亂數決定要不要使用支援卡
        for (int i = 0; i < 5; i++)
        {
            int n = Enemy.GetHand_Status(Ehand[i]);
            if (n > 18 && Support_B == 22)
            {
                int r = Random.Range(0, 2);
                if (r == 1)
                {
                    Support_B = Enemy.GetHand_Status(Ehand[i]); //使用了支援卡
                    Enemy.ChangeHand_Status(Ehand[i], 22);
                    HandChoose_B_S = Ehand[i];
                    break;
                }
                else
                    continue;
            }
            else
                continue;
        }
        //亂數決定要不要使用中鋒卡
        for (int i = 0; i < 5; i++)
        {
            int n = Enemy.GetHand_Status(Ehand[i]);
            if (n > 14 && n < 18 && Center_B == 22)
            {
                int r = Random.Range(0, 2);
                if (r == 1)
                {
                    Center_B = Enemy.GetHand_Status(Ehand[i]); //使用了魔法卡
                    Enemy.ChangeHand_Status(Ehand[i], 22);
                    HandChoose_B_C = Ehand[i];
                    break;
                }
                else
                    continue;
            }
            else
                continue;
        }
        //亂數決定使用前鋒卡
        for (int i = 0; i < 5; i++)
        {
            int n = Enemy.GetHand_Status(Ehand[i]);
            if (n < 15 && Vanguard_B == 22)
            {
                Vanguard_B = Enemy.GetHand_Status(Ehand[i]); //使用了前鋒卡
                int a = Enemy.GetHand_Status(Ehand[i]);
                ATK_B = card_temp[a].GetATK();
                Text_ATK_B_Num.text = ATK_B.ToString();
                HandChoose_B_V = Ehand[i];
                Enemy.ChangeHand_Status(Ehand[i], 22);
                break;
            }
            else
                continue;
        }
        /*
        //Debug
        ShowHand(1);
        string ss="";
        for(int i = 0; i < 5; i++)
        {
            ss += Ehand[i] + " ";
        }
        Debug.Log(ss);
        Debug.Log(BattleCheck.Vanguard_B);
        Debug.Log(BattleCheck.Center_B);
        Debug.Log(BattleCheck.Support_B);
        //Debug
        */
        //電腦放置卡牌

        if (Vanguard_B < 15)
        {
            Text_ATK_B_Num.text = (card_temp[Vanguard_B].GetATK()) + " ";

            ATK_B = card_temp[Vanguard_B].GetATK();

            Image_Show_B[0].sprite = Resources.Load("Image/Card/" + card_temp[Vanguard_B].GetPicture(), typeof(Sprite)) as Sprite;
            Image_Hand_B[HandChoose_B_V].sprite = Resources.Load("Image/Battle/Hand", typeof(Sprite)) as Sprite;
        }
        if (Center_B > 14 && Center_B < 19)
        {
            Text_ATK_B_Num.text = Text_ATK_B_Num.text + " + " + (card_temp[Center_B].GetATK());
            switch (Center_B)
            {
                case 15:
                    ATK_B += 1;
                    break;
                case 16:
                    ATK_B += 2;
                    break;
                case 17:
                    ATK_B += 3;
                    break;
                case 18:
                    ATK_B += 4;
                    break;
                default:
                    break;
            }
            Image_Show_B[1].sprite = Resources.Load("Image/Card/" + card_temp[Center_B].GetPicture(), typeof(Sprite)) as Sprite;
            Image_Hand_B[HandChoose_B_C].sprite = Resources.Load("Image/Battle/Hand", typeof(Sprite)) as Sprite;
        }
        if (Support_B < 22)
        {
            Image_Show_B[2].sprite = Resources.Load("Image/Card/" + card_temp[Support_B].GetPicture(), typeof(Sprite)) as Sprite;
            Image_Hand_B[HandChoose_B_S].sprite = Resources.Load("Image/Battle/Hand", typeof(Sprite)) as Sprite;
        }

        //結算 左上角顯示這回合贏還是輸
        //雙方攻擊力
        /*
        Debug.Log("A = " + BattleCheck.A_ATK);
        Debug.Log("B = " + BattleCheck.B_ATK);
        */
        //雙方判斷支援卡
        switch (Support_A)
        {
            case 19:
                Player.ChangeLP(Player.GetLP() + 2);
                Text_Message.text += "\n" + System_Interface.Battle_Battle_PlayerLPAdd + " 2 ";
                break;
            case 20:
                Player.ChangeLP(Player.GetLP() + 3);
                Text_Message.text += "\n" + System_Interface.Battle_Battle_PlayerLPAdd + " 3 ";
                break;
            case 21:
                Player.ChangeLP(Player.GetLP() + 5);
                Text_Message.text += "\n" + System_Interface.Battle_Battle_PlayerLPAdd + " 5 ";
                break;
            default:
                break;
        }
        switch (Support_B)
        {
            case 19:
                Enemy.ChangeLP(Enemy.GetLP() + 2);
                Text_Message.text += "\n" + System_Interface.Battle_Battle_EnemyLPAdd + " 2 ";
                break;
            case 20:
                Enemy.ChangeLP(Enemy.GetLP() + 3);
                Text_Message.text += "\n" + System_Interface.Battle_Battle_EnemyLPAdd + " 3 ";
                break;
            case 21:
                Enemy.ChangeLP(Enemy.GetLP() + 5);
                Text_Message.text += "\n" + System_Interface.Battle_Battle_EnemyLPAdd + " 5 ";
                break;
            default:
                break;
        }
        int aatk, batk;
        aatk = ATK_A;
        batk = ATK_B;
        //判斷攻擊力並分出勝負
        if (aatk > batk)
        {
            Enemy.DecLP((aatk - batk));
            Text_Message.text += "\n" + System_Interface.Battle_Battle_EnemyLPDec + " " + (aatk - batk);
        }
        else if (batk > aatk)
        {
            Player.DecLP((batk - aatk));
            Text_Message.text += "\n" + System_Interface.Battle_Battle_PlayerLPDec + " " + (batk - aatk);
        }
        else
        {
            Text_Message.text += "\n" + System_Interface.Battle_Battle_Tie;
        }
        Text_LP_A_Num.text = Player.GetLP().ToString();
        Text_LP_B_Num.text = Enemy.GetLP().ToString();

        if (Player.GetLP() < 1)
        {
            GameObject_Count.SetActive(true);
            Text_Next.text = System_Interface.Battle_Battle_Settlement_Text;
            Text_Message.text += "\n" + System_Interface.Battle_Battle_GameOver_Text;
            Text_Count.text = System_Interface.Battle_Battle_EnemyWin_Text;
            Text_Count.color = new Color32(255, 0, 0, 255);
        }
        else if (Enemy.GetLP() < 1)
        {
            GameObject_Count.SetActive(true);
            Text_Next.text = System_Interface.Battle_Battle_Settlement_Text;
            Text_Message.text += "\n" + System_Interface.Battle_Battle_GameOver_Text;
            Text_Count.text = System_Interface.Battle_Battle_PlayerWin_Text;
            Text_Count.color = new Color32(255, 0, 0, 255);
        }
        else if (Question_Num == Question_total)
        {
            if (Player.GetLP() >= Enemy.GetLP())
            {
                GameObject_Count.SetActive(true);
                Text_Next.text = System_Interface.Battle_Battle_Settlement_Text;
                Text_Message.text += "\n" + System_Interface.Battle_Battle_GameOver_Text;
                Text_Count.text = System_Interface.Battle_Battle_PlayerWin_Text;
                Text_Count.color = new Color32(255, 0, 0, 255);
            }
            else
            {
                GameObject_Count.SetActive(true);
                Text_Next.text = System_Interface.Battle_Battle_Settlement_Text;
                Text_Message.text += "\n" + System_Interface.Battle_Battle_GameOver_Text;
                Text_Count.text = System_Interface.Battle_Battle_EnemyWin_Text;
                Text_Count.color = new Color32(255, 0, 0, 255);
            }
        }
        else if (Player.GetDeck_Num() == 0)
        {
            GameObject_Count.SetActive(true);
            Text_Next.text = System_Interface.Battle_Battle_Settlement_Text;
            Text_Message.text += "\n" + System_Interface.Battle_Battle_GameOver_Text;
            Text_Count.text = System_Interface.Battle_Battle_EnemyDeckWin_Text;
            Text_Count.color = new Color32(255, 0, 0, 255);
        }
        else if (Enemy.GetDeck_Num() == 0)
        {
            GameObject_Count.SetActive(true);
            Text_Next.text = System_Interface.Battle_Battle_Settlement_Text;
            Text_Message.text += "\n" + System_Interface.Battle_Battle_GameOver_Text;
            Text_Count.text = System_Interface.Battle_Battle_PlayDeckWin_Text;
            Text_Count.color = new Color32(255, 0, 0, 255);
        }

        //開啟 NEXT按鈕
        GameObject_Next.SetActive(true);
        Button_Next.interactable = true;
    }

    public static int[] GetRandomSequence(int total)
    {
        int r;
        int[] output = new int[total];
        for (int i = 0; i < total; i++)
        {
            output[i] = i;
        }
        for (int i = 0; i < total; i++)
        {
            r = Random.Range(0, total);
            int temp = 0;
            temp = output[i];
            output[i] = output[r];
            output[r] = temp;
        }
        return output;
    }
    #endregion

    #region Battle EndPhase Function
    void NEXT()
    {
        GameObject_Next.SetActive(false);
        //先判斷遊戲是否結束 是:進入結算畫面 否:重整盤面 抽牌  進入QP
        if (Player.GetLP() < 1)
        {
            Learner_Data.Learner_Add("Battle_Lose", 1);
            Settlement(0);
        }
        else if (Enemy.GetLP() < 1)
        {
            Learner_Data.Learner_Add("Battle_Win", 1);
            Settlement(1);
        }
        else if (Player.GetDeck_Num() == 0)
        {
            Learner_Data.Learner_Add("Battle_Lose", 1);
            Settlement(0);
        }
        else if (Enemy.GetDeck_Num() == 0)
        {
            Learner_Data.Learner_Add("Battle_Win", 1);
            Settlement(1);
        }
        else if (Question_Num == Question_total)
        {
            if (Player.GetLP() >= Enemy.GetLP())
            {
                Learner_Data.Learner_Add("Battle_Win", 1);
                Settlement(1);
            }
            else
            {
                Learner_Data.Learner_Add("Battle_Lose", 1);
                Settlement(0);
            }
        }
        else
        {
            Button_Next.interactable = false;
            //重整
            ATK_A = 0;
            ATK_B = 0;
            HandChooseA = 0;
            TypeChooseA = 0;
            Vanguard_A = 22; //22:沒有 0~21:有
            Center_A = 22; //22:沒有 0~21:有
            Support_A = 22; //22:沒有 0~21:有
            HandChoose_B_V = 5;
            HandChoose_B_C = 5;
            HandChoose_B_S = 5;
            Vanguard_B = 22; //22:沒有 0~21:有
            Center_B = 22; //22:沒有 0~21:有
            Support_B = 22; //22:沒有 0~21:有
            for(int i = 0; i < 3; i++)
            {
                Image_Show_A[i].sprite = Resources.Load("Image/Battle/Table", typeof(Sprite)) as Sprite;
                Image_Show_B[i].sprite = Resources.Load("Image/Battle/Table", typeof(Sprite)) as Sprite;
            }
            Text_ATK_A_Num.text = "0";
            Text_ATK_B_Num.text = "0";
            //抽牌
            Player_Data.Draw(0, 1); //玩家抽1
            Player_Data.Draw(1, 1); //電腦抽1
            Text_Deck_A_Num.text = (Player.GetDeck_Num()).ToString();
            Text_Deck_B_Num.text = (Enemy.GetDeck_Num()).ToString();
            ShowHand(0);
            ShowHand(1);
            //問題設置
            Question_Class question_temp = new Question_Class();
            question_temp = Question_Data.Question_Get(Question_Num);
            Text_QuestionNum.text = (Question_Num + 1).ToString() + ".";
            Text_Question.text = question_temp.GetQuestion();
            Question_Data.Button_Ans_Set(Question_Data.GetLevel(), Question_Num);
            for(int i = 0; i < 3; i++)
            {
                Button_Ans[i].interactable = true;
                Text_Ans[i].text = Question_Data.GetButton_Ans(i);
            }
            ui_Question.SetActive(true);
            Text_Time.text = (Question_Num+1).ToString();
            Text_ROW.text = System_Interface.Battle_Question_Choose;
            Text_Answer.text = "Ans：";
        }
    }
    #endregion

    #region Battle Settlement Function
    void Settlement(int n)
    {
        int challenge = Question_Data.GetChallenge();
        int hard = Player_Data.hardGet();
        ui_Info.SetActive(false);
        ui_CardPlay.SetActive(false);
        ui_Phase.SetActive(false);
        ui_HandPlay.SetActive(false);
        ui_Settlement.SetActive(true);

        if (challenge == 1)
            Image_Item.sprite = Resources.Load("Image/Main/Item_Icon/Score", typeof(Sprite)) as Sprite;
        else if (challenge == 0)
            Image_Item.sprite = Resources.Load("Image/Main/Item_Icon/Crystal", typeof(Sprite)) as Sprite;

        if (challenge == 1 && n == 0)
        {
            Text_ItemContent.text = Learner_Data.Learner_GetData("Score").ToString() + " -> ";
            Flag.text = System_Interface.Battle_ChallengeFlag_Failed;
            Mechanism_Data.Punishment("Task",6+ hard);
            Text_ItemContent.text += Learner_Data.Learner_GetData("Score").ToString();
            Learner_Data.Learner_Add("Task_Fail", 1);
            Learner_Data.Learner_Add("Task_Finish", 1);
        }
        else if (challenge == 1 && n == 1)
        {
            Text_ItemContent.text = Learner_Data.Learner_GetData("Score").ToString() + " -> ";
            Flag.text = System_Interface.Battle_ChallengeFlag_Success;
            Mechanism_Data.Reward("Task", 6 + hard);
            Text_ItemContent.text += Learner_Data.Learner_GetData("Score").ToString();
            Learner_Data.Learner_Add("Task_Succes", 1);
            Learner_Data.Learner_Add("Task_Finish", 1);
        }
        else if (challenge == 0 && n == 0)
        {
            Text_ItemContent.text = Learner_Data.Learner_GetData("Crystal").ToString() + " -> ";
            Flag.text = System_Interface.Battle_PracticeFlag_Failed ;
            Mechanism_Data.Punishment("Battle", hard);
            Text_ItemContent.text = Learner_Data.Learner_GetData("Crystal").ToString();
            Learner_Data.Learner_Add("Battle_Lose", 1);
        }
        else if (challenge == 0 && n == 1)
        {
            Text_ItemContent.text = Learner_Data.Learner_GetData("Crystal").ToString() + " -> ";
            Flag.text = System_Interface.Battle_ChallengeFlag_Success;
            Mechanism_Data.Reward("Battle", hard);
            Text_ItemContent.text = Learner_Data.Learner_GetData("Crystal").ToString();
            Learner_Data.Learner_Add("Battle_Win", 1);
        }

        if (Question_Num < 6)
            PageDown = 1;
        else if (Question_Num < 11)
            PageDown = 2;
        else if (Question_Num < 16)
            PageDown = 3;
        else
            PageDown = 4;
        Page = 0;
        PageUP = 1;
        S_PageUp.text = PageUP.ToString();
        S_PageDown.text = PageDown.ToString();
        for (int i = 0; i < 5; i++)
        {
            A_S_QNum[i].text = "";
            A_S_Question[i].text = "";
            A_S_Answer[i].text = "";
            A_S_Choose[i].text = "";
            A_S_Feedback[i].text = "";
        }
        ShowContent();
    }
    void F_Left(BaseEventData data)
    {
        PageTurning.Play();
        if (PageUP > 1)
        {
            PageUP--;
            PageChage();
        }
    }
    void F_Right(BaseEventData data)
    {
        PageTurning.Play();
        if (PageUP < PageDown)
        {
            PageUP++;
            PageChage();
        }

    }
    void PageChage()
    {
        S_PageUp.text = PageUP.ToString();
        S_PageDown.text = PageDown.ToString();

        switch (PageUP)
        {
            case 1:
                Page = 0;
                break;
            case 2:
                Page = 5;
                break;
            case 3:
                Page = 10;
                break;
            case 4:
                Page = 15;
                break;
            default:
                break;
        }
        ShowContent();
    }
    void ShowContent()
    {
        Question_Class[] question_temp = new Question_Class[20];
        int n = Page;
        for (int i = 0; i < 20; i++)
            question_temp[i] = new Question_Class(0, "", "", "", "", "", "");

        for (int i = 0; i < Question_total; i++)
            question_temp[i] = Question_Data.Question_Get(i);

        for (int i = 0; i < 5; i++)
        {
            A_S_QNum[i].text = question_temp[i + n].GetQuestionNum().ToString();
            A_S_Question[i].text = question_temp[i + n].GetQuestion();
            A_S_Answer[i].text = question_temp[i + n].GetAnswer_r() + " " + question_temp[i + n].GetAnswer_r_Content();
            A_S_Choose[i].text = question_temp[i + n].GetAnswer_c() + " " + question_temp[i + n].GetAnswer_c_Content();
            A_S_Feedback[i].text = question_temp[i + n].GetFeedBack();
        }
    }
    void Back()
    {
        ok.Play();
        SceneManager.LoadScene("Main");
    }
    #endregion

    void ShowHand(int s)
    {
        for (int i = 0; i < 5; i++)
        {
            int n = 0;
            n = Player.GetHand_Status(i);
            if (s == 0)
            {
                if (n == 22) //22 = 沒牌
                    Image_Hand_A[i].sprite = Resources.Load("Image/Battle/Hand", typeof(Sprite)) as Sprite;
                else
                    Image_Hand_A[i].sprite = Resources.Load("Image/Card/" + card_temp[n].GetPicture(), typeof(Sprite)) as Sprite;
                Image_Hand_A[i].color = new Color32(255, 255, 255, 255);
            }
            else
            {
                if (n == 22) //22 = 沒牌
                {
                    Image_Hand_B[i].sprite = Resources.Load("Image/Battle/Hand", typeof(Sprite)) as Sprite;
                }
                else
                    //i_temp.sprite = Resources.Load("Image/Card/" + card_temp[n].GetPicture(), typeof(Sprite)) as Sprite;
                    Image_Hand_B[i].sprite = Resources.Load("Image/Card/CardBack", typeof(Sprite)) as Sprite;
            }
        }
    }

}
