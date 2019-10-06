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
    #endregion

    #region Variable Events
    EventTriggerType EPClick = EventTriggerType.PointerClick;
    #endregion

    #region Level
    public GameObject ui_Level,ui_Overall;
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
    // Use this for initialization
    void Start () {

        #region Level PointerClick
        AddEvents.AddTriggersListener(Question, EPClick, Voice);
        #endregion

        Button_Ans[0].onClick.AddListener(Choose_A);
        Button_Ans[1].onClick.AddListener(Choose_B);
        Button_Ans[2].onClick.AddListener(Choose_C);
        Button_Next.onClick.AddListener(Next);

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
                ui_Overall.SetActive(true);
                break;
            default:
                break;
        }
        Text_QuestionNum.text = "1";

    }
    void CheckAns()
    {
        Question_Class question_temp = new Question_Class();
        Question_Data.ChangeAnswer_c(choose_Ans, Question_Num);
        Question_Data.ChangeAnswer_c_Content(choose_Ans_Content, Question_Num);

        question_temp = Question_Data.Question_Get(Question_Num);

        if (question_temp.GetAnswer_r() == question_temp.GetAnswer_c())
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
        Text_AnswerContent.text = question_temp.GetAnswer_r();
        Text_ScoreContent.text = Score.ToString();

        Button_Next.interactable = true;
        Button_Ans[0].interactable = false;
        Button_Ans[1].interactable = false;
        Button_Ans[2].interactable = false;

        if (Question_Num == Question_total - 1)
        {
            Text_ENDContent.text = "結束";
            Text_Next.text = "結算";
        }
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
    public void Next()
    {
        Question_Class question_temp = new Question_Class();

        Button_Next.interactable = false;
        Button_Ans[0].interactable = true;
        Button_Ans[1].interactable = true;
        Button_Ans[2].interactable = true;

        if (Question_Num == Question_total - 1)
        {
            if (Score > Level_Data.GetHighestScore(Level))
            {
                Level_Data.ChangeHighestScore(Score.ToString(), Level);
            }
            if (Challenge == 1)
            {
                Task_Class task_temp = new Task_Class();
                task_temp = Task_Data.Learn_Get(Level);
                if (Score >= Task_Bank.Learn_Request_Score[Level])//成功
                {
                    task_temp.ChangeStatus(4);
                }
                else if (Score < Task_Bank.Learn_Request_Score[Level]) //失敗
                {
                    task_temp.ChangeStatus(3);
                }

                if (Score > 59)
                {
                    //Settlement_LearnCheck.Flag = 1;
                    if (Learner_Data.Learner_GetLearn_Status(Level) == 0)
                    {
                        Learner_Data.Learner_ChangeLearn_Status(Level);
                        Learner_Data.Learner_Add("Learn_Finish", 1);
                    }
                    Learner_Data.Learner_Add("Learn_Succes", 1);
                }

               Challenge = 0;
            }
            else if (Score > 59 && Challenge == 0)
            {
                //Settlement_LearnCheck.Flag = 1;
                if (Learner_Data.Learner_GetLearn_Status(Level) == 0)
                {
                    Learner_Data.Learner_ChangeLearn_Status(Level);
                    Learner_Data.Learner_Add("Learn_Finish", 1);
                }
                Learner_Data.Learner_Add("Learn_Succes", 1);
            }
            //SceneManager.LoadScene("Settlement_Learn");
            Debug.Log("END");
        }
        else
        {
            Question_Num++;
            question_temp = Question_Data.Question_Get(Question_Num);
            Question_Data.Button_Ans_Set(Level,Question_Num);
            for (int i = 0; i < 3; i++)
                Text_Ans[i].text = Question_Data.GetButton_Ans(i);
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
                    Text_Question.text = question_temp.GetQuestion();
                    break;
                case 6: //Overall
                    break;
                default:
                    break;
            }
        }
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
}
