using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class UI_Main : MonoBehaviour {
    
    #region Variable Events
    EventTriggerType EPEnter = EventTriggerType.PointerEnter;
    EventTriggerType EPExit = EventTriggerType.PointerExit;
    EventTriggerType EPClick = EventTriggerType.PointerClick;
    #endregion

    #region Home
    public GameObject ui_Home, ui_Task_Goal;
    public GameObject Task, Learn, Battle, Guide, Profile, Deck, Badges, Rank, Shop;
    public GameObject Task_Goal;
    public AudioSource ok, cancel;
    public Text text_Info;
    #endregion

    #region Task 
    public GameObject ui_Task, ui_Task_Content;
    #endregion

    #region Learn 
    public GameObject ui_Learn;
    public Button Button_Material,Button_Level,Button_Cancel;
    #endregion

    // Use this for initialization
    void Start () {
        #region Home PointerEnter
        AddEvents.AddTriggersListener(Task, EPEnter, Home_PointerEnter.Task);
        AddEvents.AddTriggersListener(Learn, EPEnter, Home_PointerEnter.Learn);
        AddEvents.AddTriggersListener(Battle, EPEnter, Home_PointerEnter.Battle);
        AddEvents.AddTriggersListener(Guide, EPEnter, Home_PointerEnter.Guide);
        AddEvents.AddTriggersListener(Profile, EPEnter, Home_PointerEnter.Profile);
        AddEvents.AddTriggersListener(Shop, EPEnter, Home_PointerEnter.Shop);
        AddEvents.AddTriggersListener(Deck, EPEnter, Home_PointerEnter.Deck);
        AddEvents.AddTriggersListener(Badges, EPEnter, Home_PointerEnter.Badges);
        AddEvents.AddTriggersListener(Rank, EPEnter, Home_PointerEnter.Rank);
        AddEvents.AddTriggersListener(Task_Goal, EPEnter, Home_PointerEnter.Task_Goal);

        #endregion

        #region Home PointerExit
        AddEvents.AddTriggersListener(Task, EPExit, Home_PointerExit.Exit);
        AddEvents.AddTriggersListener(Learn, EPExit, Home_PointerExit.Exit);
        AddEvents.AddTriggersListener(Battle, EPExit, Home_PointerExit.Exit);
        AddEvents.AddTriggersListener(Guide,EPExit, Home_PointerExit.Exit);
        AddEvents.AddTriggersListener(Profile, EPExit, Home_PointerExit.Exit);
        AddEvents.AddTriggersListener(Shop, EPExit, Home_PointerExit.Exit);
        AddEvents.AddTriggersListener(Deck, EPExit, Home_PointerExit.Exit);
        AddEvents.AddTriggersListener(Badges, EPExit, Home_PointerExit.Exit);
        AddEvents.AddTriggersListener(Rank, EPExit, Home_PointerExit.Exit);
        AddEvents.AddTriggersListener(Task_Goal, EPExit, Home_PointerExit.Exit);
        #endregion

        #region Home PointerClick
        AddEvents.AddTriggersListener(Task, EPClick, Enter_Task);
        AddEvents.AddTriggersListener(Learn, EPClick, Enter_Learn);
        AddEvents.AddTriggersListener(Battle, EPClick, Enter_Battle);
        AddEvents.AddTriggersListener(Guide, EPClick, Enter_Guide);
        AddEvents.AddTriggersListener(Profile, EPClick, Enter_Profile);
        AddEvents.AddTriggersListener(Shop, EPClick, Enter_Shop);
        AddEvents.AddTriggersListener(Deck, EPClick, Enter_Deck);
        AddEvents.AddTriggersListener(Badges, EPClick, Enter_Badges);
        AddEvents.AddTriggersListener(Rank, EPClick, Enter_Rank);
        #endregion

        #region Learn
        Button_Material.onClick.AddListener(Material);
        Button_Level.onClick.AddListener(Level);
        Button_Cancel.onClick.AddListener(Learn_Cancel);
        #endregion
    }

    #region Home PointerClick Function
    public void Enter_Task(BaseEventData data)
    {
        ok.Play();
        text_Info.text = "點擊文字可觀看任務資訊\n點擊旁邊的圖像可選擇要接的任務類別";
        ui_Task.SetActive(true);
        ui_Home.SetActive(false);
        ui_Task_Goal.SetActive(false);
    }
    public void Enter_Learn(BaseEventData data)
    {
        ok.Play();
        text_Info.text = "點擊教材可瀏覽本遊戲中的目標單字\n點擊關卡即可進入，並選擇要練習或挑戰";
        ui_Learn.SetActive(true);
        ui_Home.SetActive(false);
        ui_Task_Goal.SetActive(false);
    }
    public void Enter_Battle(BaseEventData data)
    {
        ok.Play();
    }
    public void Enter_Guide(BaseEventData data)
    {
        ok.Play();
    }
    public void Enter_Profile(BaseEventData data)
    {
        ok.Play();
    }
    public void Enter_Shop(BaseEventData data)
    {
        ok.Play();
    }
    public void Enter_Deck(BaseEventData data)
    {
        ok.Play();
    }
    public void Enter_Badges(BaseEventData data)
    {
        ok.Play();
    }
    public void Enter_Rank(BaseEventData data)
    {
        ok.Play();
    }
    #endregion

    #region Learn
    public void Material()
    {
        ok.Play();
    }
    public void Level()
    {
        ok.Play();
    }
    void Learn_Cancel()
    {
        cancel.Play();
        ui_Learn.SetActive(false);
        ui_Home.SetActive(true);
        ui_Task_Goal.SetActive(true);
        text_Info.text = "這邊是資訊欄\n移至圖像可得知相關資訊";
    }
    #endregion

}
