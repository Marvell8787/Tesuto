using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class UI_Main : MonoBehaviour {

    #region Home ui
    public GameObject ui_Home, ui_Task_Goal;
    #endregion

    #region Home icon
    public GameObject Task,Learn,Battle,Guide,Profile,Deck,Badges,Rank,Shop;
    #endregion

    #region Home Goal
    public GameObject Task_Goal;
    #endregion

    #region Home Audio
    public AudioSource ok;
    #endregion

    #region Home Text
    public Text text_Info,text_Task_Content;
    #endregion

    #region variable Events
    EventTriggerType EPEnter = EventTriggerType.PointerEnter;
    EventTriggerType EPExit = EventTriggerType.PointerExit;
    EventTriggerType EPClick = EventTriggerType.PointerClick;
    #endregion

    // Use this for initialization
    void Start () {
        #region PointerEnter
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

        #region PointerExit
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

        #region PointerClick
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

    }

    #region PointerClick
    public void Enter_Task(BaseEventData data)
    {
        ok.Play();
        text_Info.text = "請選擇要接的任務";
        ui_Home.SetActive(false);
        ui_Task_Goal.SetActive(false);
    }
    public void Enter_Learn(BaseEventData data)
    {
        ok.Play();
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


}
