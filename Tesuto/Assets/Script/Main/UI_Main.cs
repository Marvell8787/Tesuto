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
    public GameObject GameObject_Task, GameObject_Learn, GameObject_Battle, GameObject_Guide, GameObject_Profile, GameObject_Deck, GameObject_Badges, GameObject_Rank, GameObject_Shop;
    public GameObject GameObject_Task_Goal;
    public AudioSource ok, cancel,choose;
    public Text Text_Info;
    #endregion

    #region Task 
    public GameObject ui_Task, ui_Task_Content;
    #endregion

    #region Learn 
    public GameObject ui_Learn;
    public Button Button_Material,Button_Level,Button_Cancel;
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
    public GameObject ui_Guide;

    // Use this for initialization
    void Start () {
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
    }

    #region Home PointerEnter Function
    void Enter_Task(BaseEventData data)
    {
        choose.Play();
        Text_Info.text = "這是任務\n是本遊戲中要完成的目標\n點擊可開啟任務清單";
    }
    void Enter_Learn(BaseEventData data)
    {
        choose.Play();
        Text_Info.text = "這是學習\n含有教材和關卡\n點擊即可進入";
    }
    void Enter_Battle(BaseEventData data)
    {
        choose.Play();
        Text_Info.text = "這是戰鬥\n能以手中持有的卡牌與電腦進行對戰\n點擊即可進入";
    }
    void Enter_Guide(BaseEventData data)
    {
        choose.Play();
        Text_Info.text = "這是導覽\n可得知本遊戲的相關資訊\n點擊即可進入";
    }
    void Enter_Profile(BaseEventData data)
    {
        choose.Play();
        Text_Info.text = "這是狀態\n可得知玩家本身及持有物的狀態\n點擊即可進入";
    }
    void Enter_Shop(BaseEventData data)
    {
        choose.Play();
        Text_Info.text = "這是商店\n能以分數、金幣、水晶購買相關物品\n點擊即可進入";
    }
    void Enter_Deck(BaseEventData data)
    {
        choose.Play();
        Text_Info.text = "這是牌組\n可得知目前持有的卡牌資訊\n點擊即可進入";
    }
    void Enter_Badges(BaseEventData data)
    {
        choose.Play();
        Text_Info.text = "這是獎章\n可得知獎章資訊\n點擊即可進入";
    }
    void Enter_Rank(BaseEventData data)
    {
        choose.Play();
        Text_Info.text = "這是排行榜\n可得知玩家的排名狀況\n點擊即可進入";
    }
    void Enter_Task_Goal(BaseEventData data)
    {
        Text_Info.text = "這是本遊戲目標\n請完成所有任務";
    }
    #endregion

    #region Home PointerExit Function
    void Exit(BaseEventData data)
    {
        Text_Info.text = "這邊是資訊欄\n移至圖像可得知相關資訊";
    }
    #endregion

    #region Home PointerClick Function
    public void Click_Task(BaseEventData data)
    {
        ok.Play();
        Text_Info.text = "點擊文字可觀看任務資訊\n點擊旁邊的圖像可選擇要接的任務類別";
        ui_Task.SetActive(true);
        ui_Home.SetActive(false);
        ui_Task_Goal.SetActive(false);
    }
    public void Click_Learn(BaseEventData data)
    {
        ok.Play();
        Text_Info.text = "點擊教材可瀏覽本遊戲中的目標單字\n點擊關卡即可進入，並選擇要練習或挑戰";
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
        Text_Info.text = "移至圖像可查看資訊/n點擊下方箭頭可換頁";
        ui_Badges.SetActive(true);
        ui_Home.SetActive(false);
        ui_Task_Goal.SetActive(false);
    }
    public void Click_Rank(BaseEventData data)
    {
        ok.Play();
        Text_Info.text = "移至圖像可查看資訊/n點擊圖像可顯示該類前五名";
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
        Text_Info.text = "這邊是資訊欄\n移至圖像可得知相關資訊";
    }
    #endregion

    #region Rank
    void Rank_Cancel()
    {
        cancel.Play();
        ui_Rank.SetActive(false);
        ui_Home.SetActive(true);
        ui_Task_Goal.SetActive(true);
        Text_Info.text = "這邊是資訊欄\n移至圖像可得知相關資訊";
    }
    #endregion
}
