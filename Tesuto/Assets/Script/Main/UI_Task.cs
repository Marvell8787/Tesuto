using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
public class UI_Task : MonoBehaviour {

    #region Variable Events
    EventTriggerType EPEnter = EventTriggerType.PointerEnter;
    EventTriggerType EPExit = EventTriggerType.PointerExit;
    EventTriggerType EPClick = EventTriggerType.PointerClick;
    #endregion

    #region Home
    public GameObject ui_Home, ui_Task_Goal;
    public AudioSource ok, cancel;
    public Text text_Info;
    #endregion

    #region Task 
    public GameObject ui_Task, ui_Task_Content;
    public GameObject  Image_Task_Learn, Image_Task_Battle; //Image
    public Button Button_Task_Cancel, Button_Task_Content_Cancel;
    public GameObject Image_Task_Memo, Image_Task_Content; //Image
    public GameObject[] GameObject_Task = new GameObject[7];
    public Text[] Text_Task = new Text[7];
    #endregion

    // Use this for initialization
    void Start () {

        #region Task PointerEnter
        AddEvents.AddTriggersListener(Image_Task_Learn, EPEnter, Task_PointerEnter.Task_Learn);
        AddEvents.AddTriggersListener(Image_Task_Battle, EPEnter, Task_PointerEnter.Task_Battle);
        #endregion

        #region Task PointerExit
        AddEvents.AddTriggersListener(Image_Task_Learn, EPExit, Task_PointerExit.Exit);
        AddEvents.AddTriggersListener(Image_Task_Battle, EPExit, Task_PointerExit.Exit);
        #endregion

        #region Task PointerClick
        AddEvents.AddTriggersListener(Image_Task_Learn, EPClick, Task_Learn);
        AddEvents.AddTriggersListener(Image_Task_Battle, EPClick, Task_Battle);
        AddEvents.AddTriggersListener(GameObject_Task[0], EPClick, Task_0);
        AddEvents.AddTriggersListener(GameObject_Task[1], EPClick, Task_1);
        AddEvents.AddTriggersListener(GameObject_Task[2], EPClick, Task_2);
        AddEvents.AddTriggersListener(GameObject_Task[3], EPClick, Task_3);
        AddEvents.AddTriggersListener(GameObject_Task[4], EPClick, Task_4);
        AddEvents.AddTriggersListener(GameObject_Task[5], EPClick, Task_5);
        AddEvents.AddTriggersListener(GameObject_Task[6], EPClick, Task_6);

        #endregion

        #region Task Cancel
        Button_Task_Cancel.onClick.AddListener(Task_Cancel);
        Button_Task_Content_Cancel.onClick.AddListener(Task_Content_Cancel);
        #endregion
    }

    #region Task PointerClick Function
    public void Task_Learn(BaseEventData data)
    {
        ok.Play();
    }
    public void Task_Battle(BaseEventData data)
    {
        ok.Play();
    }
    public void Task_0(BaseEventData data)
    {
        ok.Play();
        ui_Task_Content.SetActive(true);
    }
    public void Task_1(BaseEventData data)
    {
        ok.Play();
        ui_Task_Content.SetActive(true);
    }
    public void Task_2(BaseEventData data)
    {
        ok.Play();
        ui_Task_Content.SetActive(true);
    }
    public void Task_3(BaseEventData data)
    {
        ok.Play();
        ui_Task_Content.SetActive(true);
    }
    public void Task_4(BaseEventData data)
    {
        ok.Play();
        ui_Task_Content.SetActive(true);
    }
    public void Task_5(BaseEventData data)
    {
        ok.Play();
        ui_Task_Content.SetActive(true);
    }
    public void Task_6(BaseEventData data)
    {
        ok.Play();
        ui_Task_Content.SetActive(true);
    }
    #endregion


    #region Task Cancel
    void Task_Cancel()
    {
        cancel.Play();
        ui_Task.SetActive(false);
        ui_Task_Content.SetActive(false);
        ui_Home.SetActive(true);
        ui_Task_Goal.SetActive(true);
        text_Info.text = "這邊是資訊欄\n移至圖像可得知相關資訊";
    }
    void Task_Content_Cancel()
    {
        cancel.Play();
        ui_Task_Content.SetActive(false);
    }
    #endregion
}
