using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class UI_Profile : MonoBehaviour {

    #region Variable
    private int Status_Page = 1; //1 2 3
    private int Item_Page = 1; //1 2 3
    #endregion

    #region Variable Events
    EventTriggerType EPClick = EventTriggerType.PointerClick;
    #endregion

    public GameObject ui_RW, ui_R, ui_W;
    public Button Button_Back;
    public Text Button_Back_Text;
    public AudioSource ok, PageTurning;
    //遊玩紀錄UI
    #region Status
    public GameObject Image_Status_Left, Image_Status_Right;
    public Image Image_Status;
    public Text Text_Status,Text_Status_PageUp;
    public Text Text_Succes, Text_Fail, Text_Num;
    public Text Text_SuccesContent, Text_FailContent, Text_NumContent;
    #endregion

    //持有物UI
    public Text Text_Item_PageUp;
    public GameObject Image_Item_Left, Image_Item_Right;
    #region RW
    public Text Text_Score, Text_Coin, Text_Crystal;
    public Text Text_ScoreContent, Text_CoinContent, Text_CrystalContent;
    #endregion

    #region R
    public Text Text_V, Text_C, Text_S;
    public Text Text_RTask, Text_RLearn, Text_RBattle;
    public Text Text_VContent, Text_CContent, Text_SContent;
    public Text Text_RTaskContent, Text_RLearnContent, Text_RBattleContent;
    #endregion

    #region W
    public Text Text_WTask, Text_WLearn, Text_WBattle;
    public Text Text_Warning, Text_YC, Text_RC;
    public Text Text_WTaskContent, Text_WLearnContent, Text_WBattleContent;
    public Text Text_WarningContent, Text_YCContent, Text_RCContent;
    #endregion


    // Use this for initialization
    void Start () {
        Text_Status.text = System_Interface.Profile_Status_Task_Text;
        Text_Succes.text = System_Interface.Profile_Status_Success_Text;
        Text_Fail.text = System_Interface.Profile_Status_Fail_Text;
        Text_Num.text = System_Interface.Profile_Status_Num_Text;
        Text_Score.text = System_Interface.Profile_Item_Score_Text;
        Text_Coin.text = System_Interface.Profile_Item_Coin_Text;
        Text_Crystal.text = System_Interface.Profile_Item_Crystal_Text;
        Text_V.text = System_Interface.Profile_Item_V_Text;
        Text_C.text = System_Interface.Profile_Item_C_Text;
        Text_S.text = System_Interface.Profile_Item_S_Text;
        Text_RTask.text = System_Interface.Profile_Item_RTask_Text;
        Text_RLearn.text = System_Interface.Profile_Item_RLearn_Text;
        Text_RBattle.text = System_Interface.Profile_Item_RBattle_Text;
        Text_WTask.text = System_Interface.Profile_Item_WTask_Text;
        Text_WLearn.text = System_Interface.Profile_Item_WLearn_Text;
        Text_WBattle.text = System_Interface.Profile_Item_WBattle_Text;
        Text_Warning.text = System_Interface.Profile_Item_Warning_Text;
        Text_YC.text = System_Interface.Profile_Item_YC_Text;
        Text_RC.text = System_Interface.Profile_Item_RC_Text;
        Button_Back_Text.text = System_Interface.Profile_Button_Back_Text;

        AddEvents.AddTriggersListener(Image_Status_Left,EPClick, Status_PageDown);
        AddEvents.AddTriggersListener(Image_Status_Right, EPClick, Status_PageUp);
        AddEvents.AddTriggersListener(Image_Item_Left, EPClick, Item_PageDown);
        AddEvents.AddTriggersListener(Image_Item_Right, EPClick, Item_PageUp);

        Button_Back.onClick.AddListener(Back);

        StatusShowContent(1);
        ItemShowContent(1);

        #region RW R W
        //RW
        Text_ScoreContent.text = Learner_Data.Learner_GetData("Score").ToString();
        Text_CoinContent.text = Learner_Data.Learner_GetData("Coin").ToString();
        Text_CrystalContent.text = Learner_Data.Learner_GetData("Crystal").ToString();
        //R
        Text_VContent.text = Learner_Data.Learner_GetCardsGet_Status(0).ToString();
        Text_CContent.text = Learner_Data.Learner_GetCardsGet_Status(1).ToString();
        Text_SContent.text = Learner_Data.Learner_GetCardsGet_Status(2).ToString();
        Text_RTaskContent.text = Learner_Data.Learner_GetBadges_GetStatus(0).ToString();
        Text_RLearnContent.text = Learner_Data.Learner_GetBadges_GetStatus(1).ToString();
        Text_RBattleContent.text = Learner_Data.Learner_GetBadges_GetStatus(2).ToString();
        //W
        Text_WTaskContent.text = Learner_Data.Learner_GetPoints_Status(0).ToString();
        Text_WLearnContent.text = Learner_Data.Learner_GetPoints_Status(1).ToString();
        Text_WBattleContent.text = Learner_Data.Learner_GetPoints_Status(2).ToString();
        Text_WarningContent.text = Learner_Data.Learner_GetMistakes_Status(0).ToString();
        Text_YCContent.text = Learner_Data.Learner_GetMistakes_Status(1).ToString();
        Text_RCContent.text = Learner_Data.Learner_GetMistakes_Status(2).ToString();
        #endregion
    }
    #region Status Function
    void Status_PageUp(BaseEventData data)
    {
        PageTurning.Play();
        Status_Page++;
        if (Status_Page == 4)
            Status_Page = 1;
        StatusShowContent(Status_Page);
    }
    void Status_PageDown(BaseEventData data)
    {
        PageTurning.Play();
        Status_Page--;
        if(Status_Page == 0)
            Status_Page = 3;
        StatusShowContent(Status_Page);
    }
    void StatusShowContent(int n)
    {
        Text_Status_PageUp.text = Status_Page.ToString();
        switch (n)
        {
            case 1:
                Image_Status.sprite = Resources.Load("Image/Main/Task_Item", typeof(Sprite)) as Sprite;
                Text_Status.text = System_Interface.Profile_Status_Task_Text;
                Text_SuccesContent.text = Learner_Data.Learner_GetData("Task_Succes").ToString();
                Text_FailContent.text = Learner_Data.Learner_GetData("Task_Fail").ToString();
                Text_NumContent.text = Learner_Data.Learner_GetData("Task_Finish").ToString();
                break;
            case 2:
                Image_Status.sprite = Resources.Load("Image/Main/Learn_Item", typeof(Sprite)) as Sprite;
                Text_Status.text = System_Interface.Profile_Status_Learn_Text;
                Text_SuccesContent.text = Learner_Data.Learner_GetData("Learn_Succes").ToString();
                Text_FailContent.text = Learner_Data.Learner_GetData("Learn_Fail").ToString();
                Text_NumContent.text = Learner_Data.Learner_GetData("Learn_Num").ToString();
                break;
            case 3:
                Image_Status.sprite = Resources.Load("Image/Main/Battle_Item", typeof(Sprite)) as Sprite;
                Text_Status.text = System_Interface.Profile_Status_Battle_Text;
                Text_SuccesContent.text = Learner_Data.Learner_GetData("Battle_Win").ToString();
                Text_FailContent.text = Learner_Data.Learner_GetData("Battle_Lose").ToString();
                Text_NumContent.text = Learner_Data.Learner_GetData("Battle_Num").ToString();
                break;
            default:
                break;
        }
    }
    #endregion

    #region Item Function
    void Item_PageUp(BaseEventData data)
    {
        PageTurning.Play();
        Item_Page++;
        if (Item_Page == 4)
            Item_Page = 1;
        ItemShowContent(Item_Page);
    }
    void Item_PageDown(BaseEventData data)
    {
        PageTurning.Play();
        Item_Page--;
        if (Item_Page == 0)
            Item_Page = 3;
        ItemShowContent(Item_Page);
    }
    void ItemShowContent(int n)
    {
        Text_Item_PageUp.text = Item_Page.ToString();
        switch (n)
        {
            case 1:
                ui_RW.SetActive(true);
                ui_R.SetActive(false);
                ui_W.SetActive(false);
                break;
            case 2:
                ui_RW.SetActive(false);
                ui_R.SetActive(true);
                ui_W.SetActive(false);
                break;
            case 3:
                ui_RW.SetActive(false);
                ui_R.SetActive(false);
                ui_W.SetActive(true);
                break;
            default:
                break;
        }
    }
    #endregion

    void Back () {
        ok.Play();
        SceneManager.LoadScene("Main");
	}
}
