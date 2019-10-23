using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
public class UI_Deck : MonoBehaviour {

    #region Variable 
    #endregion

    #region Variable Events
    EventTriggerType EPClick = EventTriggerType.PointerClick;
    #endregion

    #region Deck
    public GameObject ui_Vanguard, ui_Center, ui_Support;
    public GameObject[] GameObject_Card = new GameObject[22];
    public Image[] Image_Card = new Image[22];
    public Image Image_Show;

    //按鈕
    public GameObject[] GameObject_VCSA = new GameObject[4];
    public Button[] Button_VCSA = new Button[4];
    public Text[] Text_VCSA = new Text[4]; //按鈕的文字
    public Button Button_Back;
   
    //文字
    public Text Text_No, Text_Type, Text_Name, Text_Rarity, Text_ATK, Text_Effect,Text_Info;
    public Text Text_No_Content,Text_Type_Content, Text_Name_Content, Text_Rarity_Content, Text_ATK_Content, Text_Effect_Content;
    public Text Button_Vanguard_Text, Button_Center_Text, Button_Support_Text, Button_All_Text, Button_Back_Text;


    public AudioSource ok;
    #endregion

    // Use this for initialization
    void Start () {
        Button_Vanguard_Text.text = System_Interface.Deck_Button_Vanguard_Text;
        Button_Center_Text.text = System_Interface.Deck_Button_Center_Text;
        Button_Support_Text.text = System_Interface.Deck_Button_Support_Text;
        Button_All_Text.text = System_Interface.Deck_Button_All_Text;
        Button_Back_Text.text = System_Interface.Deck_Button_Back_Text;

        Text_No.text = System_Interface.Deck_No_Text;
        Text_Type.text = System_Interface.Deck_Type_Text;
        Text_Name.text = System_Interface.Deck_Name_Text;
        Text_Rarity.text = System_Interface.Deck_Rarity_Text;
        Text_ATK.text = System_Interface.Deck_ATK_Text;
        Text_Effect.text = System_Interface.Deck_Effect_Text;
        Text_Info.text = System_Interface.Deck_Info_Text;

        Button_VCSA[0].onClick.AddListener(VCSA_V);
        Button_VCSA[1].onClick.AddListener(VCSA_C);
        Button_VCSA[2].onClick.AddListener(VCSA_S);
        Button_VCSA[3].onClick.AddListener(VCSA_A);
        Button_Back.onClick.AddListener(Back);
        
        #region Deck PointerClick
        AddEvents.AddTriggersListener(GameObject_Card[0], EPClick, Card_0);
        AddEvents.AddTriggersListener(GameObject_Card[1], EPClick, Card_1);
        AddEvents.AddTriggersListener(GameObject_Card[2], EPClick, Card_2);
        AddEvents.AddTriggersListener(GameObject_Card[3], EPClick, Card_3);
        AddEvents.AddTriggersListener(GameObject_Card[4], EPClick, Card_4);
        AddEvents.AddTriggersListener(GameObject_Card[5], EPClick, Card_5);
        AddEvents.AddTriggersListener(GameObject_Card[6], EPClick, Card_6);
        AddEvents.AddTriggersListener(GameObject_Card[7], EPClick, Card_7);
        AddEvents.AddTriggersListener(GameObject_Card[8], EPClick, Card_8);
        AddEvents.AddTriggersListener(GameObject_Card[9], EPClick, Card_9);
        AddEvents.AddTriggersListener(GameObject_Card[10], EPClick, Card_10);
        AddEvents.AddTriggersListener(GameObject_Card[11], EPClick, Card_11);
        AddEvents.AddTriggersListener(GameObject_Card[12], EPClick, Card_12);
        AddEvents.AddTriggersListener(GameObject_Card[13], EPClick, Card_13);
        AddEvents.AddTriggersListener(GameObject_Card[14], EPClick, Card_14);
        AddEvents.AddTriggersListener(GameObject_Card[15], EPClick, Card_15);
        AddEvents.AddTriggersListener(GameObject_Card[16], EPClick, Card_16);
        AddEvents.AddTriggersListener(GameObject_Card[17], EPClick, Card_17);
        AddEvents.AddTriggersListener(GameObject_Card[18], EPClick, Card_18);
        AddEvents.AddTriggersListener(GameObject_Card[19], EPClick, Card_19);
        AddEvents.AddTriggersListener(GameObject_Card[20], EPClick, Card_20);
        AddEvents.AddTriggersListener(GameObject_Card[21], EPClick, Card_21);
        #endregion

        Card_Class[] card_temp = new Card_Class[22];
        int[] card_status = new int[22];

        for (int i = 0; i < 22; i++)
        {
            card_temp[i] = Card_Data.Card_Get(i);
            card_status[i] = Learner_Data.Learner_GetCard_Status(i);
        }

        for (int i = 0; i < 22; i++)
        {
            if (card_status[i] >= 1)
                Image_Card[i].sprite = Resources.Load("Image/Card/" + card_temp[i].GetPicture(), typeof(Sprite)) as Sprite;
        }
        Image_Show.sprite = Resources.Load("Image/Card/CardBack", typeof(Sprite)) as Sprite;
        Text_No_Content.text = "???";
        Text_Type_Content.text = "???";
        Text_Name_Content.text = "???";
        Text_Rarity_Content.text = "???";
        Text_ATK_Content.text = "???";
        Text_Effect_Content.text = "???";
    }
    #region VCSA
    void VCSA_V()
    {
        ok.Play();
        ui_Vanguard.SetActive(true);
        ui_Center.SetActive(false);
        ui_Support.SetActive(false);
    }
    void VCSA_C()
    {
        ok.Play();
        ui_Vanguard.SetActive(false);
        ui_Center.SetActive(true);
        ui_Support.SetActive(false);
    }
    void VCSA_S()
    {
        ok.Play();
        ui_Vanguard.SetActive(false);
        ui_Center.SetActive(false);
        ui_Support.SetActive(true);
    }
    void VCSA_A()
    {
        ok.Play();
        ui_Vanguard.SetActive(true);
        ui_Center.SetActive(true);
        ui_Support.SetActive(true);
    }
    #endregion

    void Card_Output(int n)
    {
        Card_Class card_temp = new Card_Class();
        for (int i = 0; i < 22; i++)
            Image_Card[i].color = new Color32(255, 255, 255, 255);

        Image_Card[n].color = new Color32(255, 0, 0, 255);

        int card_status = new int();
        card_status = Learner_Data.Learner_GetCard_Status(n);
        if (card_status == 0)
        {
            Image_Show.sprite = Resources.Load("Image/Card/CardBack", typeof(Sprite)) as Sprite;
            Text_No_Content.text = "???";
            Text_Type_Content.text = "???";
            Text_Name_Content.text = "???";
            Text_Rarity_Content.text = "???";
            Text_ATK_Content.text = "???";
            Text_Effect_Content.text = "???";
            return;
        }
        card_temp = Card_Data.Card_Get(n);
        Image_Show.sprite = Resources.Load("Image/Card/" + card_temp.GetPicture(), typeof(Sprite)) as Sprite;

        Text_No_Content.text = card_temp.GetNo();
        Text_Type_Content.text = card_temp.GetCType();
        Text_Name_Content.text = card_temp.GetName();
        Text_Rarity_Content.text = card_temp.GetRarity();
        Text_ATK_Content.text = card_temp.GetATK().ToString();
        Text_Effect_Content.text = card_temp.GetEffect();
    }

    void Back()
    {
        ok.Play();
        SceneManager.LoadScene("Main");
    }

    #region Card
    void Card_0(BaseEventData data)
    {
        Card_Output(0);
    }
    void Card_1(BaseEventData data)
    {
        Card_Output(1);
    }
    void Card_2(BaseEventData data)
    {
        Card_Output(2);
    }
    void Card_3(BaseEventData data)
    {
        Card_Output(3);
    }
    void Card_4(BaseEventData data)
    {
        Card_Output(4);
    }
    void Card_5(BaseEventData data)
    {
        Card_Output(5);
    }
    void Card_6(BaseEventData data)
    {
        Card_Output(6);
    }
    void Card_7(BaseEventData data)
    {
        Card_Output(7);
    }
    void Card_8(BaseEventData data)
    {
        Card_Output(8);
    }
    void Card_9(BaseEventData data)
    {
        Card_Output(9);
    }
    void Card_10(BaseEventData data)
    {
        Card_Output(10);
    }
    void Card_11(BaseEventData data)
    {
        Card_Output(11);
    }
    void Card_12(BaseEventData data)
    {
        Card_Output(12);
    }
    void Card_13(BaseEventData data)
    {
        Card_Output(13);
    }
    void Card_14(BaseEventData data)
    {
        Card_Output(14);
    }
    void Card_15(BaseEventData data)
    {
        Card_Output(15);
    }
    void Card_16(BaseEventData data)
    {
        Card_Output(16);
    }
    void Card_17(BaseEventData data)
    {
        Card_Output(17);
    }
    void Card_18(BaseEventData data)
    {
        Card_Output(18);
    }
    void Card_19(BaseEventData data)
    {
        Card_Output(19);
    }
    void Card_20(BaseEventData data)
    {
        Card_Output(20);
    }
    void Card_21(BaseEventData data)
    {
        Card_Output(21);
    }

    #endregion

}
