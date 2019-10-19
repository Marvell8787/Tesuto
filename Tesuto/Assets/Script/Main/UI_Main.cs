using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class UI_Main : MonoBehaviour {
    
    #region Variable Events
    EventTriggerType EPEnter = EventTriggerType.PointerEnter;
    EventTriggerType EPExit = EventTriggerType.PointerExit;
    EventTriggerType EPClick = EventTriggerType.PointerClick;
    #endregion

    #region Home
    public GameObject ui_Home, ui_Task_Goal;
    public GameObject GameObject_Task, GameObject_Learn, GameObject_Battle, GameObject_Guide, GameObject_Profile, GameObject_Deck, GameObject_Badges, GameObject_Rank, GameObject_Shop;
    public GameObject GameObject_Task_Goal;
    public AudioSource ok, cancel,choose;
    public Text Text_Info, Text_Task_Content;
    #endregion

    #region Task 
    public GameObject ui_Task, ui_Task_Content;
    #endregion

    #region Learn 
    public GameObject ui_Learn;
    public Button Button_Material,Button_Level,Button_Cancel;
    public Text Button_Material_Text, Button_Level_Text;
    #endregion

    #region Rank
    public GameObject ui_Rank;
    public Text Text_No_Tile, Text_Num_Tile, Text_NickName_Tile;
    public Text[] Text_No = new Text[6];
    public Text[] Text_Num = new Text[6];
    public Text[] Text_NickName = new Text[6];
    public Button Button_Rank_Cancel;
    #endregion

    public GameObject ui_Badges;

    // Use this for initialization
    void Start () {
        Text_Info.text = System_Interface.Info_Text;
        Button_Material_Text.text = System_Interface.Lean_Button_Material_Text;
        Button_Level_Text.text = System_Interface.Lean_Button_Level_Text;

        #region Home PointerEnter
        AddEvents.AddTriggersListener(GameObject_Task, EPEnter, Enter_Task);
        AddEvents.AddTriggersListener(GameObject_Learn, EPEnter, Enter_Learn);
        AddEvents.AddTriggersListener(GameObject_Battle, EPEnter, Enter_Battle);
        AddEvents.AddTriggersListener(GameObject_Guide, EPEnter, Enter_Guide);
        AddEvents.AddTriggersListener(GameObject_Profile, EPEnter, Enter_Profile);
        AddEvents.AddTriggersListener(GameObject_Shop, EPEnter, Enter_Shop);
        AddEvents.AddTriggersListener(GameObject_Deck, EPEnter, Enter_Deck);
        AddEvents.AddTriggersListener(GameObject_Badges, EPEnter, Enter_Badges);
        AddEvents.AddTriggersListener(GameObject_Rank, EPEnter, Enter_Rank);
        AddEvents.AddTriggersListener(GameObject_Task_Goal, EPEnter, Enter_Task_Goal);
        #endregion

        #region Home PointerExit
        AddEvents.AddTriggersListener(GameObject_Task, EPExit, Exit);
        AddEvents.AddTriggersListener(GameObject_Learn, EPExit, Exit);
        AddEvents.AddTriggersListener(GameObject_Battle, EPExit, Exit);
        AddEvents.AddTriggersListener(GameObject_Guide,EPExit, Exit);
        AddEvents.AddTriggersListener(GameObject_Profile, EPExit, Exit);
        AddEvents.AddTriggersListener(GameObject_Shop, EPExit, Exit);
        AddEvents.AddTriggersListener(GameObject_Deck, EPExit, Exit);
        AddEvents.AddTriggersListener(GameObject_Badges, EPExit, Exit);
        AddEvents.AddTriggersListener(GameObject_Rank, EPExit, Exit);
        AddEvents.AddTriggersListener(GameObject_Task_Goal, EPExit, Exit);
        #endregion

        #region Home PointerClick
        AddEvents.AddTriggersListener(GameObject_Task, EPClick, Click_Task);
        AddEvents.AddTriggersListener(GameObject_Learn, EPClick, Click_Learn);
        AddEvents.AddTriggersListener(GameObject_Battle, EPClick, Click_Battle);
        AddEvents.AddTriggersListener(GameObject_Guide, EPClick, Click_Guide);
        AddEvents.AddTriggersListener(GameObject_Profile, EPClick, Click_Profile);
        AddEvents.AddTriggersListener(GameObject_Shop, EPClick, Click_Shop);
        AddEvents.AddTriggersListener(GameObject_Deck, EPClick, Click_Deck);
        AddEvents.AddTriggersListener(GameObject_Badges, EPClick, Click_Badges);
        AddEvents.AddTriggersListener(GameObject_Rank, EPClick, Click_Rank);
        #endregion                    

        #region Learn
        Button_Material.onClick.AddListener(Material);
        Button_Level.onClick.AddListener(Level);
        Button_Cancel.onClick.AddListener(Learn_Cancel);
        #endregion

        #region Rank
        Button_Rank_Cancel.onClick.AddListener(Rank_Cancel);
        #endregion

        Text_Task_Content.text = Learner_Data.Learner_GetData("Task_Finish").ToString() + " / 10";
    }

    #region Home PointerEnter Function
    void Enter_Task(BaseEventData data)
    {
        choose.Play();
        Text_Info.text = System_Interface.Info_Task_Text;
    }
    void Enter_Learn(BaseEventData data)
    {
        choose.Play();
        Text_Info.text = System_Interface.Info_Learn_Text;
    }
    void Enter_Battle(BaseEventData data)
    {
        choose.Play();
        Text_Info.text = System_Interface.Info_Battle_Text;
    }
    void Enter_Guide(BaseEventData data)
    {
        choose.Play();
        Text_Info.text = System_Interface.Info_Guide_Text;
    }
    void Enter_Profile(BaseEventData data)
    {
        choose.Play();
        Text_Info.text = System_Interface.Info_Profile_Text;
    }
    void Enter_Shop(BaseEventData data)
    {
        choose.Play();
        Text_Info.text = System_Interface.Info_Shop_Text; ;
    }
    void Enter_Deck(BaseEventData data)
    {
        choose.Play();
        Text_Info.text = System_Interface.Info_Deck_Text; ;
    }
    void Enter_Badges(BaseEventData data)
    {
        choose.Play();
        Text_Info.text = System_Interface.Info_Badges_Text; ;
    }
    void Enter_Rank(BaseEventData data)
    {
        choose.Play();
        Text_Info.text = System_Interface.Info_Rank_Text; ;
    }
    void Enter_Task_Goal(BaseEventData data)
    {
        Text_Info.text = System_Interface.Info_Task_Goal_Text; ;
    }
    #endregion

    #region Home PointerExit Function
    void Exit(BaseEventData data)
    {
        Text_Info.text = System_Interface.Info_Text;
    }
    #endregion

    #region Home PointerClick Function
    public void Click_Task(BaseEventData data)
    {
        ok.Play();
        Text_Info.text = System_Interface.Task_Info_Text;
        ui_Task.SetActive(true);
        ui_Home.SetActive(false);
        ui_Task_Goal.SetActive(false);
    }
    public void Click_Learn(BaseEventData data)
    {
        ok.Play();
        Text_Info.text = System_Interface.Learn_Info_Text;
        ui_Learn.SetActive(true);
        ui_Home.SetActive(false);
        ui_Task_Goal.SetActive(false);
    }
    public void Click_Battle(BaseEventData data)
    {
        ok.Play();
        SceneManager.LoadScene("Select_Battle");
    }
    public void Click_Guide(BaseEventData data)
    {
        ok.Play();
        SceneManager.LoadScene("Guide");
    }
    public void Click_Profile(BaseEventData data)
    {
        ok.Play();
        SceneManager.LoadScene("Profile");
    }
    public void Click_Shop(BaseEventData data)
    {
        ok.Play();
        SceneManager.LoadScene("Shop"); 
    }
    public void Click_Deck(BaseEventData data)
    {
        ok.Play();
        SceneManager.LoadScene("Deck");
    }
    public void Click_Badges(BaseEventData data)
    {
        ok.Play();
        Text_Info.text = System_Interface.Badges_Info_Text;
        ui_Badges.SetActive(true);
        ui_Home.SetActive(false);
        ui_Task_Goal.SetActive(false);
    }
    public void Click_Rank(BaseEventData data)
    {
        ok.Play();
        Text_Info.text = System_Interface.Rank_Info_Text;
        ui_Rank.SetActive(true);
        ui_Home.SetActive(false);
        ui_Task_Goal.SetActive(false);
    }
    #endregion

    #region Learn
    public void Material()
    {
        ok.Play();
        SceneManager.LoadScene("Material");
    }
    public void Level()
    {
        ok.Play();
        SceneManager.LoadScene("Select_Learn");
    }
    void Learn_Cancel()
    {
        cancel.Play();
        ui_Learn.SetActive(false);
        ui_Home.SetActive(true);
        ui_Task_Goal.SetActive(true);
        Text_Info.text = System_Interface.Info_Text;
    }
    #endregion

    #region Rank
    void Rank_Cancel()
    {
        cancel.Play();
        ui_Rank.SetActive(false);
        ui_Home.SetActive(true);
        ui_Task_Goal.SetActive(true);
        Text_Info.text = System_Interface.Info_Text;
    }
    #endregion
}
