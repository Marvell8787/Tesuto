using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class UI_Level : MonoBehaviour {

    #region Variable
    private int Level = 10;
    private int Challenge = 10;
    private int Score = 0;
    private int Question_Num = 0;
    private int Question_total = 10;

    private string choose_Ans = "";
    private string choose_Ans_Content = "";


    private int PageUP = 1;
    private int PageDown = 4;
    private int Page = 0; //0 5 10 15
    #endregion

    #region Variable Events
    EventTriggerType EPClick = EventTriggerType.PointerClick;
    #endregion

    #region Level
    public GameObject ui_Title,ui_Level,ui_Overall,ui_Settlement;
    public Text Text_QuestionType, Text_Level, Text_Answer, Text_Score, Text_Next, Text_QuestionNum, Text_description, Text_Input;
    public Text Text_QuestionTypeContent, Text_LevelContent, Text_AnswerContent, Text_ScoreContent, Text_FeedBack, Text_Question, Text_ENDContent;
    public Text[] Text_Ans = new Text[3];
    public Button Button_Submit,Button_Next;
    public Button[] Button_Ans = new Button[3];
    public GameObject Question;
    public Image Image_Question;
    public AudioSource access; //access
    public AudioSource ashamed; //ashamed
    public AudioSource authority; //authority
    public AudioSource bare; //bare
    public AudioSource behavior; //behavior
    public AudioSource citizen; //citizen
    public AudioSource clash; //clash
    public AudioSource destroy; //destroy
    public AudioSource exhaust; //exhaust
    public AudioSource fort; //fort

    public AudioSource graceful; //graceful
    public AudioSource invade; //invade
    public AudioSource mystery; //mystery
    public AudioSource occupy; //occupy
    public AudioSource restrict; //restrict
    public AudioSource security; //security
    public AudioSource toss; //toss
    public AudioSource troop; //troop
    public AudioSource vary; //vary
    public AudioSource wicked; //wicked
    #endregion

    #region Settlement
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

    // Use this for initialization
    void Start () {

        #region Level PointerClick
        AddEvents.AddTriggersListener(Question, EPClick, Voice);
        AddEvents.AddTriggersListener(Right, EPClick, F_Right);
        AddEvents.AddTriggersListener(Left, EPClick, F_Left);
        #endregion

        ui_Title.SetActive(true);

        Text_ENDContent.text = "";
        Text_FeedBack.text = "";
        Text_AnswerContent.text = "";

        Level_Class[] level_temp = new Level_Class[7];
        Question_Class question_temp = new Question_Class();
        for (int i = 0; i < 7; i++)
        {
            level_temp[i] = Level_Data.Level_Get(i);
        }
        question_temp = Question_Data.Question_Get(0);
        Level = Question_Data.GetLevel();
        Challenge = Question_Data.GetChallenge();
        Question_total = Question_Data.GetQtotal();
        Text_QuestionTypeContent.text = level_temp[Level].GetQuestionType();
        Text_LevelContent.text = level_temp[Level].GetTitle();
        if (Level < 6)
        {
            Button_Ans[0].onClick.AddListener(Choose_A);
            Button_Ans[1].onClick.AddListener(Choose_B);
            Button_Ans[2].onClick.AddListener(Choose_C);
        }
        else
        {
            Button_Submit.onClick.AddListener(Submit);
        }
        Button_Back.onClick.AddListener(Back);
        Button_Next.onClick.AddListener(Next);
        Button_Next.interactable = false;
        switch (Level)
        {
            case 0: //Level-1 聽力
            case 1: //Level-2 聽力
            case 2: //Level-3 聽力
                Text_Question.text = "請點選左邊的圖示，並選出聽到的答案。";
                Image_Question.sprite = Resources.Load("Image/Voice", typeof(Sprite)) as Sprite;
                Question_Data.Button_Ans_Set(Level, Question_Num);
                for (int i = 0; i < 3; i++)
                    Text_Ans[i].text=Question_Data.GetButton_Ans(i);
                ui_Level.SetActive(true);
                break;
            case 3: //Level-4 中文
            case 4: //Level-5 中文
            case 5: //Level-6 中文
                Text_Question.text = question_temp.GetQuestion();
                Image_Question.sprite = Resources.Load("", typeof(Sprite)) as Sprite;
                Question_Data.Button_Ans_Set(Level, Question_Num);
                for (int i = 0; i < 3; i++)
                    Text_Ans[i].text = Question_Data.GetButton_Ans(i);
                ui_Level.SetActive(true);
                break;
            case 6:
                Text_description.text = "請拼出正確的單字：";
                Text_Question.text = question_temp.GetQuestion();
                Image_Question.sprite = Resources.Load("Image/Voice", typeof(Sprite)) as Sprite;
                ui_Overall.SetActive(true);
                break;
            default:
                break;
        }
        Text_QuestionNum.text = "1.";

    }

    #region Button_Ans
    void Choose_A()
    {
        choose_Ans = "A";
        choose_Ans_Content = Question_Data.GetButton_Ans(0);
        CheckAns();
    }
    void Choose_B()
    {
        choose_Ans = "B";
        choose_Ans_Content = Question_Data.GetButton_Ans(1);
        CheckAns();
    }
    public void Choose_C()
    {
        choose_Ans = "C";
        choose_Ans_Content = Question_Data.GetButton_Ans(2);
        CheckAns();
    }
    #endregion

    void CheckAns(string s = "")
    {
        Question_Class question_temp = new Question_Class();
        Question_Data.ChangeAnswer_c(choose_Ans, Question_Num);
        Question_Data.ChangeAnswer_c_Content(choose_Ans_Content, Question_Num);

        question_temp = Question_Data.Question_Get(Question_Num);

        if (Level < 6)
            s = question_temp.GetAnswer_c_Content();
        

        if (question_temp.GetAnswer_r_Content() == s)
        {
            Question_Data.ChangeFeedBack("O", Question_Num);
            Text_FeedBack.text = "O";
            Score += (100 / Question_total);
        }
        else
        {
            Question_Data.ChangeFeedBack("X", Question_Num);
            Text_FeedBack.text = "X";
        }
        Text_ScoreContent.text = Score.ToString();

        if (Level < 6)
        {
            Text_AnswerContent.text = question_temp.GetAnswer_r();
            Button_Ans[0].interactable = false;
            Button_Ans[1].interactable = false;
            Button_Ans[2].interactable = false;
        }
        else
        {
            Text_AnswerContent.text = question_temp.GetAnswer_r_Content();
            Button_Submit.interactable = false;
        }

        Button_Next.interactable = true;


        if (Question_Num == Question_total - 1)
        {
            Text_ENDContent.text = "結束";
            Text_Next.text = "結算";
        }
    }
    public void Next()
    {
        Question_Class question_temp = new Question_Class();

        Button_Next.interactable = false;

        if(Level < 6)
        {
            Button_Ans[0].interactable = true;
            Button_Ans[1].interactable = true;
            Button_Ans[2].interactable = true;
        }
        else
            Button_Submit.interactable = true;

        if (Question_Num == Question_total - 1)
        {
            ui_Title.SetActive(false);
            ui_Level.SetActive(false);
            ui_Overall.SetActive(false);
            ui_Settlement.SetActive(true);

            if (Score > Level_Data.GetHighestScore(Level))
                Level_Data.ChangeHighestScore(Score.ToString(), Level);

            if (Challenge == 1)
            {
                Task_Class task_temp = new Task_Class();
                task_temp = Task_Data.Learn_Get(Level);
                if (Score >= Task_Bank.Learn_Request_Score[Level])//成功
                {
                    Image_Item.sprite = Resources.Load("Image/Main/Item_Icon/Score", typeof(Sprite)) as Sprite;
                    task_temp.ChangeStatus(3);
                    Text_ItemContent.text = Learner_Data.Learner_GetData("Score").ToString() + " -> ";
                    Flag.text = "挑戰成功!";
                    Mechanism_Data.Reward("Task", Level);
                    Text_ItemContent.text += Learner_Data.Learner_GetData("Score").ToString();
                    Learner_Data.Learner_Add("Task_Succes", 1);
                    Learner_Data.Learner_Add("Task_Finish", 1);
                }
                else if (Score < Task_Bank.Learn_Request_Score[Level]) //失敗
                {
                    Image_Item.sprite = Resources.Load("Image/Main/Item_Icon/Score", typeof(Sprite)) as Sprite;
                    task_temp.ChangeStatus(3);
                    Text_ItemContent.text = Learner_Data.Learner_GetData("Score").ToString() + " -> ";
                    Flag.text = "挑戰失敗!";
                    Mechanism_Data.Punishment("Task", Level);
                    Text_ItemContent.text += Learner_Data.Learner_GetData("Score").ToString();
                    Learner_Data.Learner_Add("Task_Fail", 1);
                    Learner_Data.Learner_Add("Task_Finish", 1);
                }

            }
            else if (Challenge == 0)
            {
                if (Score > 59)//成功
                {
                    Text_ItemContent.text = Learner_Data.Learner_GetData("Coin").ToString() + " -> ";
                    Flag.text = "練習成功!";
                    Mechanism_Data.Punishment("Learn", Level);
                    Text_ItemContent.text += Learner_Data.Learner_GetData("Coin").ToString();

                    if (Learner_Data.Learner_GetLearn_Status(Level) == 0)
                    {
                        Learner_Data.Learner_ChangeLearn_Status(Level);
                        Learner_Data.Learner_Add("Learn_Finish", 1);
                    }
                    Learner_Data.Learner_Add("Learn_Succes", 1);
                }
                else if (Score < 60) //失敗
                {
                    Text_ItemContent.text = Learner_Data.Learner_GetData("Coin").ToString() + " -> ";
                    Flag.text = "練習失敗!";
                    Mechanism_Data.Punishment("Learn", Level);
                    Text_ItemContent.text += Learner_Data.Learner_GetData("Coin").ToString();
                    Learner_Data.Learner_Add("Learn_Fail", 1);
                }

            }
            //開始結算
            //頁面初始化
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
        else //繼續作答
        {
            Question_Num++;
            question_temp = Question_Data.Question_Get(Question_Num);
            if (Level < 6)
            {
                Question_Data.Button_Ans_Set(Level, Question_Num);
                for (int i = 0; i < 3; i++)
                    Text_Ans[i].text = Question_Data.GetButton_Ans(i);
            }
            Text_QuestionNum.text = (Question_Num + 1).ToString() + ".";
            Text_AnswerContent.text = "";
            Text_FeedBack.text = "";

            switch (Level)
            {
                case 0: //Level-1 聽力
                case 1: //Level-2 聽力
                case 2: //Level-3 聽力
                    break;
                case 3: //Level-4 中文
                case 4: //Level-5 中文
                case 5: //Level-6 中文
                case 6: //Overall
                    Text_Question.text = question_temp.GetQuestion();
                    break;
                default:
                    break;
            }
        }
    }
    void Submit()
    {
        string s;
        s = Text_Input.text;
        CheckAns(s);
    }
    void Back()
    {
        SceneManager.LoadScene("Main");
    }
    void Voice(BaseEventData data)
    {
        if (Level < 3)
            Play();
    }
    void Play()
    {
        Question_Class[] question_temp = new Question_Class[Question_total];
        for (int i = 0; i < Question_total; i++)
        {
            question_temp[i] = Question_Data.Question_Get(i);
        }
        question_temp[Question_Num].GetQuestion();

        switch (question_temp[Question_Num].GetQuestion())
        {
            case "access":
                access.Play();
                break;
            case "ashamed":
                ashamed.Play();
                break;
            case "authority":
                authority.Play();
                break;
            case "bare":
                bare.Play();
                break;
            case "behavior":
                behavior.Play();
                break;
            case "citizen":
                citizen.Play();
                break;
            case "clash":
                clash.Play();
                break;
            case "destroy":
                destroy.Play();
                break;
            case "exhaust":
                exhaust.Play();
                break;
            case "fort":
                fort.Play();
                break;
            case "graceful":
                graceful.Play();
                break;
            case "invade":
                invade.Play();
                break;
            case "mystery":
                mystery.Play();
                break;
            case "occupy":
                occupy.Play();
                break;
            case "restrict":
                restrict.Play();
                break;
            case "security":
                security.Play();
                break;
            case "toss":
                toss.Play();
                break;
            case "troop":
                troop.Play();
                break;
            case "vary":
                vary.Play();
                break;
            case "wicked":
                wicked.Play();
                break;
            default:
                break;
        }
    }

    #region Settlement
    void F_Left(BaseEventData data)
    {
        if (PageUP > 1)
        {
            PageUP--;
            PageChage();
        }
    }
    void F_Right(BaseEventData data)
    {
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
    #endregion
}