using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
static class Task_PointerExit{

    public static void Exit(BaseEventData data)
    {
        Text t_temp;
        t_temp = GameObject.Find("Text_Info").GetComponent<Text>();
        t_temp.text = "點擊文字可觀看任務資訊\n點擊旁邊的圖像可選擇要接的任務類別";
    }

}
