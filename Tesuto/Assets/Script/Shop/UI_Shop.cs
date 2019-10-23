using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class UI_Shop : MonoBehaviour {

    #region Variable
    private int choose_n = 10;
    private int[] check_n = new int[15];
    #endregion

    #region Variable Events
    EventTriggerType EPClick = EventTriggerType.PointerClick;
    #endregion

    #region Shop
    public GameObject[] GameObject_Item = new GameObject[12];
    public Image[] Image_Item = new Image[12];
    public Text[] Text_Have = new Text[3];
    public Text Text_Shop_Info,Text_Buy;
    public Button Button_Buy, Button_Back;
    public Text Button_Buy_Text, Button_Back_Text;
    public AudioSource ok, choose;
    #endregion

    // Use this for initialization
    void Start () {
        Text_Shop_Info.text = System_Interface.Shop_Info_Text;
        Button_Buy_Text.text = System_Interface.Shop_Button_Buy_Text;
        Button_Back_Text.text = System_Interface.Shop_Button_Back_Text;

        for (int i = 0; i < 15; i++)
            check_n[i] = 0;
        Check();

        Text_Have[0].text = Learner_Data.Learner_GetData("Score").ToString();
        Text_Have[1].text = Learner_Data.Learner_GetData("Coin").ToString();
        Text_Have[2].text = Learner_Data.Learner_GetData("Crystal").ToString();

        #region Item
        AddEvents.AddTriggersListener(GameObject_Item[0], EPClick, Item1);
        AddEvents.AddTriggersListener(GameObject_Item[1], EPClick, Item2);
        AddEvents.AddTriggersListener(GameObject_Item[2], EPClick, Item3);
        AddEvents.AddTriggersListener(GameObject_Item[3], EPClick, Item4);
        AddEvents.AddTriggersListener(GameObject_Item[4], EPClick, Item5);
        AddEvents.AddTriggersListener(GameObject_Item[5], EPClick, Item6);
        AddEvents.AddTriggersListener(GameObject_Item[6], EPClick, Item7);
        AddEvents.AddTriggersListener(GameObject_Item[7], EPClick, Item8);
        AddEvents.AddTriggersListener(GameObject_Item[8], EPClick, Item9);
        AddEvents.AddTriggersListener(GameObject_Item[9], EPClick, Item10);
        AddEvents.AddTriggersListener(GameObject_Item[10], EPClick, Item11);
        AddEvents.AddTriggersListener(GameObject_Item[11], EPClick, Item12);
        #endregion

        Button_Buy.onClick.AddListener(Buy);
        Button_Back.onClick.AddListener(Back);
    }

    #region Shop Item

    void Item1(BaseEventData data)
    {
        choose.Play();
        choose_n = 0;
        Check();
        Image_Item[0].color = new Color32(255,0,0,255);
        Text_Shop_Info.text = System_Interface.Shop_Item0_Info_Text;
        if(check_n[0]==1 || Learner_Data.Learner_GetData("Score") < 150)
            Button_Buy.interactable = false;
        else if (check_n[0] == 0 && Learner_Data.Learner_GetData("Score")>150 )
            Button_Buy.interactable = true;
        Text_Buy.text = System_Interface.Shop_Button_PickUp_Text;
    }
    void Item2(BaseEventData data)
    {
        choose.Play();
        choose_n = 1;
        Check();
        Image_Item[1].color = new Color32(255, 0, 0, 255);
        Text_Shop_Info.text = System_Interface.Shop_Item1_Info_Text;
        if (check_n[1] == 1 || Learner_Data.Learner_GetData("Score") < 150)
            Button_Buy.interactable = false;
        else if (check_n[1] == 0 && Learner_Data.Learner_GetData("Score") > 150)
            Button_Buy.interactable = true;
        Text_Buy.text = System_Interface.Shop_Button_PickUp_Text;
    }
    void Item3(BaseEventData data)
    {
        choose.Play();
        choose_n = 2;
        Check();
        Image_Item[2].color = new Color32(255, 0, 0, 255);
        Text_Shop_Info.text = System_Interface.Shop_Item2_Info_Text;
        if (check_n[2] == 1 || Learner_Data.Learner_GetData("Score") < 150)
            Button_Buy.interactable = false;
        else if (check_n[2] == 0 && Learner_Data.Learner_GetData("Score") > 150)
            Button_Buy.interactable = true;
        Text_Buy.text = System_Interface.Shop_Button_PickUp_Text;
    }
    void Item4(BaseEventData data)
    {
        choose.Play();
        choose_n = 3;
        Check();
        Image_Item[3].color = new Color32(255, 0, 0, 255);
        Text_Shop_Info.text = System_Interface.Shop_Item3_Info_Text;
        if (check_n[3] == 1 || Learner_Data.Learner_GetData("Coin") < 150)
            Button_Buy.interactable = false;
        else if (check_n[3] == 0 && Learner_Data.Learner_GetData("Coin") > 150)
            Button_Buy.interactable = true;
        Text_Buy.text = System_Interface.Shop_Button_Buy_Text;
    }
    void Item5(BaseEventData data)
    {
        choose.Play();
        choose_n = 4;
        Check();
        Image_Item[4].color = new Color32(255, 0, 0, 255);
        Text_Shop_Info.text = System_Interface.Shop_Item4_Info_Text;
        if (check_n[4] == 1 || Learner_Data.Learner_GetData("Coin") < 150)
            Button_Buy.interactable = false;
        else if (check_n[4] == 0 && Learner_Data.Learner_GetData("Coin") > 150)
            Button_Buy.interactable = true;
        Text_Buy.text = System_Interface.Shop_Button_Buy_Text;
    }
    void Item6(BaseEventData data)
    {
        choose.Play();
        choose_n = 5;
        Check();
        Image_Item[5].color = new Color32(255, 0, 0, 255);
        Text_Shop_Info.text = System_Interface.Shop_Item5_Info_Text;
        if (check_n[5] == 1 || Learner_Data.Learner_GetData("Coin") < 150)
            Button_Buy.interactable = false;
        else if (check_n[5] == 0 && Learner_Data.Learner_GetData("Coin") > 150)
            Button_Buy.interactable = true;
        Text_Buy.text = System_Interface.Shop_Button_Buy_Text;
    }
    void Item7(BaseEventData data)
    {
        choose.Play();
        choose_n = 6;
        Check();
        Image_Item[6].color = new Color32(255, 0, 0, 255);
        Text_Shop_Info.text = System_Interface.Shop_Item6_Info_Text;
        if (check_n[6] == 1 || Learner_Data.Learner_GetData("Coin") < 150)
            Button_Buy.interactable = false;
        else if (check_n[6] == 0 && Learner_Data.Learner_GetData("Coin") > 150)
            Button_Buy.interactable = true;
        Text_Buy.text = System_Interface.Shop_Button_Buy_Text;
    }
    void Item8(BaseEventData data)
    {
        choose.Play();
        choose_n = 7;
        Check();
        Image_Item[7].color = new Color32(255, 0, 0, 255);
        Text_Shop_Info.text = System_Interface.Shop_Item7_Info_Text;
        if (check_n[7] == 1 || Learner_Data.Learner_GetData("Coin") < 150)
            Button_Buy.interactable = false;
        else if (check_n[7] == 0 && Learner_Data.Learner_GetData("Coin") > 150)
            Button_Buy.interactable = true;
        Text_Buy.text = System_Interface.Shop_Button_Buy_Text;
    }
    void Item9(BaseEventData data)
    {
        choose.Play();
        choose_n = 8;
        Check();
        Image_Item[8].color = new Color32(255, 0, 0, 255);
        Text_Shop_Info.text = System_Interface.Shop_Item8_Info_Text;
        if (check_n[8] == 1 || Learner_Data.Learner_GetData("Coin") < 150)
            Button_Buy.interactable = false;
        else if (check_n[8] == 0 && Learner_Data.Learner_GetData("Coin") > 150)
            Button_Buy.interactable = true;
        Text_Buy.text = System_Interface.Shop_Button_Buy_Text;
    }
    void Item10(BaseEventData data)
    {
        choose.Play();
        choose_n = 9;
        Check();
        Image_Item[9].color = new Color32(255, 0, 0, 255);
        Text_Shop_Info.text = System_Interface.Shop_Item9_Info_Text;
        if (check_n[9] == 1 || Learner_Data.Learner_GetData("Crystal") < 150)
            Button_Buy.interactable = false;
        else if (check_n[9] == 0 && Learner_Data.Learner_GetData("Crystal") > 150)
            Button_Buy.interactable = true;
        Text_Buy.text = System_Interface.Shop_Button_Buy_Text;
    }
    void Item11(BaseEventData data)
    {
        choose.Play();
        choose_n = 10;
        Check();
        Image_Item[10].color = new Color32(255, 0, 0, 255);
        Text_Shop_Info.text = System_Interface.Shop_Item10_Info_Text;
        if (check_n[10] == 1 || Learner_Data.Learner_GetData("Crystal") < 150)
            Button_Buy.interactable = false;
        else if (check_n[10] == 0 && Learner_Data.Learner_GetData("Crystal") > 150)
            Button_Buy.interactable = true;
        Text_Buy.text = System_Interface.Shop_Button_Buy_Text;
    }
    void Item12(BaseEventData data)
    {
        choose.Play();
        choose_n = 11;
        Check();
        Image_Item[11].color = new Color32(255, 0, 0, 255);
        Text_Shop_Info.text = System_Interface.Shop_Item11_Info_Text;
        if (check_n[11] == 1 || Learner_Data.Learner_GetData("Crystal") < 150)
            Button_Buy.interactable = false;
        else if (check_n[11] == 0 && Learner_Data.Learner_GetData("Crystal") > 150)
            Button_Buy.interactable = true;
        Text_Buy.text = System_Interface.Shop_Button_Buy_Text;
    }
    #endregion
    void Buy()
    {
        ok.Play();
        switch (choose_n)
        {
            case 0:
                Learner_Data.Learner_ChangeCard_Status(16);
                Learner_Data.Learner_ChangeCardsGet_Status(1);
                Text_Shop_Info.text = System_Interface.Shop_PickUp_Success_Text;
                break;
            case 1:
                Learner_Data.Learner_ChangeCard_Status(17);
                Learner_Data.Learner_ChangeCardsGet_Status(1);
                Text_Shop_Info.text = System_Interface.Shop_PickUp_Success_Text;
                break;
            case 2:
                Learner_Data.Learner_ChangeCard_Status(18);
                Learner_Data.Learner_ChangeCardsGet_Status(1);
                Text_Shop_Info.text = System_Interface.Shop_PickUp_Success_Text;
                break;
            case 3:
                Learner_Data.Learner_ChangeCard_Status(9);
                Learner_Data.Learner_ChangeCardsGet_Status(0);
                Text_Shop_Info.text = System_Interface.Shop_Buy_Success_Text;
                break;
            case 4:
                Learner_Data.Learner_ChangeCard_Status(10);
                Learner_Data.Learner_ChangeCardsGet_Status(0);
                Text_Shop_Info.text = System_Interface.Shop_Buy_Success_Text;
                break;
            case 5:
                Learner_Data.Learner_ChangeCard_Status(11);
                Learner_Data.Learner_ChangeCardsGet_Status(0);
                Text_Shop_Info.text = System_Interface.Shop_Buy_Success_Text;
                break;
            case 6:
                Learner_Data.Learner_ChangeCard_Status(12);
                Learner_Data.Learner_ChangeCardsGet_Status(0);
                Text_Shop_Info.text = System_Interface.Shop_Buy_Success_Text;
                break;
            case 7:
                Learner_Data.Learner_ChangeCard_Status(13);
                Learner_Data.Learner_ChangeCardsGet_Status(0);
                Text_Shop_Info.text = System_Interface.Shop_Buy_Success_Text;
                break;
            case 8:
                Learner_Data.Learner_ChangeCard_Status(14);
                Learner_Data.Learner_ChangeCardsGet_Status(0);
                Text_Shop_Info.text = System_Interface.Shop_Buy_Success_Text;
                break;
            case 9:
                Learner_Data.Learner_ChangeCard_Status(19);
                Learner_Data.Learner_ChangeCardsGet_Status(2);
                Text_Shop_Info.text = System_Interface.Shop_Buy_Success_Text;
                break;
            case 10:
                Learner_Data.Learner_ChangeCard_Status(20);
                Learner_Data.Learner_ChangeCardsGet_Status(2);
                Text_Shop_Info.text = System_Interface.Shop_Buy_Success_Text;
                break;
            case 11:
                Learner_Data.Learner_ChangeCard_Status(21);
                Learner_Data.Learner_ChangeCardsGet_Status(2);
                Text_Shop_Info.text = System_Interface.Shop_Buy_Success_Text;
                break;
            default:
                break;
        }
        Check();
        Text_Have[0].text = Learner_Data.Learner_GetData("Score").ToString();
        Text_Have[1].text = Learner_Data.Learner_GetData("Coin").ToString();
        Text_Have[2].text = Learner_Data.Learner_GetData("Crystal").ToString();
        Button_Buy.interactable = false;
    }
    void Check()
    {
        for (int i = 16; i < 19; i++)
        {
            if (Learner_Data.Learner_GetCard_Status(i) == 1)
            {
                check_n[i-16] = 1;
                Image_Item[i-16].color = new Color32(66, 66, 66, 255); //6-11
            }
            else
                Image_Item[i-16].color = new Color(255, 255, 255, 255);  //0-5
        }
        for (int i = 9; i < 15; i++)
        {
            if (Learner_Data.Learner_GetCard_Status(i) == 1)
            {
                check_n[i-6] = 1;
                Image_Item[i-6].color = new Color32(66, 66, 66, 255);  //0-5
            }
            else
                Image_Item[i-6].color = new Color32(255, 255, 255,255);  //0-5
        }
        for (int i = 19; i < 22; i++)
        {
            if (Learner_Data.Learner_GetCard_Status(i) == 1)
            {
                check_n[i - 10] = 1;
                Image_Item[i - 10].color = new Color32(66, 66, 66, 255);  //0-5
            }
            else
                Image_Item[i - 10].color = new Color32(255, 255, 255, 255);  //0-5
        }
    }
    // Update is called once per frame
    void Back () {
        ok.Play();
        SceneManager.LoadScene("Main");
	}
}
