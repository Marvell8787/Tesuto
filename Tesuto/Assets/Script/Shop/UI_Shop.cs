using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class UI_Shop : MonoBehaviour {

    #region Variable
    private int choose_n = 10;
    #endregion

    #region Variable Events
    EventTriggerType EPClick = EventTriggerType.PointerClick;
    #endregion

    #region Shop
    public GameObject[] GameObject_Item = new GameObject[6];
    public Image[] Image_Item = new Image[6];
    public Text Text_Shop_Info;
    public Button Button_Buy, Button_Back;
    #endregion

    // Use this for initialization
    void Start () {
        for (int i = 0; i < 4; i++)
        {
            switch (i)
            {
                case 1:
                    if (Learner_Data.Learner_GetCard_Status(9) == 1)
                        Image_Item[i].color = new Color(66,66,66);
                    break;
                case 2:
                    if (Learner_Data.Learner_GetCard_Status(10) == 1)
                        Image_Item[i].color = new Color(66, 66, 66);
                    break;
                case 3:
                    if (Learner_Data.Learner_GetCard_Status(11) == 1)
                        Image_Item[i].color = new Color(66, 66, 66);
                    break;
                case 4:
                    if (Learner_Data.Learner_GetCard_Status(16) == 1)
                        Image_Item[i].color = new Color(66, 66, 66);
                    break;
                default:
                    break;
            }
        }
        AddEvents.AddTriggersListener(GameObject_Item[0], EPClick, Card1);
        AddEvents.AddTriggersListener(GameObject_Item[1], EPClick, Card2);
        AddEvents.AddTriggersListener(GameObject_Item[2], EPClick, Card3);
        AddEvents.AddTriggersListener(GameObject_Item[3], EPClick, Card4);
        AddEvents.AddTriggersListener(GameObject_Item[4], EPClick, Point1);
        AddEvents.AddTriggersListener(GameObject_Item[5], EPClick, Mistake1);
        Button_Buy.onClick.AddListener(Buy);
        Button_Back.onClick.AddListener(Back);
    }
    #region Shop
    void Buy()
    {
        if (Learner_Data.Learner_GetData("Coin") >= 150 && choose_n < 4)
        {
            Learner_Data.Learner_Add("Card_Num", 1);
            switch (choose_n)
            {
                case 0:
                    Learner_Data.Learner_ChangeCard_Status(9);
                    break;
                case 1:
                    Learner_Data.Learner_ChangeCard_Status(10);
                    break;
                case 2:
                    Learner_Data.Learner_ChangeCard_Status(11);
                    break;
                case 3:
                    Learner_Data.Learner_ChangeCard_Status(16);
                    break;
            }
            //Learner_Data.Learner_ChangeCard_Status(16);
            Learner_Data.Learner_Add("Coin", -150);
            switch (System_Setting.Language)
            {
                case 0:
                    Text_Shop_Info.text = "購買成功";
                    break;
                default:
                    Text_Shop_Info.text = "Success";
                    break;
            }
        }
        else
        {
            switch (System_Setting.Language)
            {
                case 0:
                    Text_Shop_Info.text = "金幣不足";
                    break;
                default:
                    Text_Shop_Info.text = "Your coin are insufficient";
                    break;
            }
        }
    }
    void Card1(BaseEventData data)
    {
        choose_n = 0;
        for(int i =0; i<6;i++)
            Image_Item[i].color = new Color32(255, 255, 255, 255);
        Image_Item[0].color = new Color32(255,0,0,255);
        Text_Shop_Info.text = "No.9 號卡,需150金幣";
        Button_Buy.interactable = true;
    }
    void Card2(BaseEventData data)
    {
        choose_n = 1;
        for (int i = 0; i < 6; i++)
            Image_Item[i].color = new Color32(255, 255, 255, 255);
        Image_Item[1].color = new Color32(255, 0, 0, 255);
        Text_Shop_Info.text = "No.10 號卡,需150金幣";
        Button_Buy.interactable = true;
    }
    void Card3(BaseEventData data)
    {
        choose_n = 2;
        for (int i = 0; i < 6; i++)
            Image_Item[i].color = new Color32(255, 255, 255, 255);
        Image_Item[2].color = new Color32(255, 0, 0, 255);
        Text_Shop_Info.text = "No.11 號卡,需150金幣";
        Button_Buy.interactable = true;
    }
    void Card4(BaseEventData data)
    {
        choose_n = 3;
        for (int i = 0; i < 6; i++)
            Image_Item[i].color = new Color32(255, 255, 255, 255);
        Image_Item[3].color = new Color32(255, 0, 0, 255);
        Text_Shop_Info.text = "No.16 號卡,需150金幣";
        Button_Buy.interactable = true;
    }
    void Point1(BaseEventData data)
    {
        choose_n = 4;
        for (int i = 0; i < 6; i++)
            Image_Item[i].color = new Color32(255, 255, 255, 255);
        Image_Item[4].color = new Color32(255, 0, 0, 255);
        Text_Shop_Info.text = "點數補充 ,需500金幣";
        Button_Buy.interactable = true;
    }
    void Mistake1(BaseEventData data)
    {
        choose_n = 5;
        for (int i = 0; i < 6; i++)
            Image_Item[i].color = new Color32(255, 255, 255, 255);
        Image_Item[5].color = new Color32(255, 0, 0, 255);
        Text_Shop_Info.text = "免死金牌 ,需1000金幣";
        Button_Buy.interactable = true;
    }
    #endregion

    // Update is called once per frame
    void Back () {
        SceneManager.LoadScene("Main");
	}
}
