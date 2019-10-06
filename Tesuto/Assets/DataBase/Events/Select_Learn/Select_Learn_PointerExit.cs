using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
static class Select_Learn_PointerExit{

    public static void Exit(BaseEventData data)
    {
        Text t_temp;
        t_temp = GameObject.Find("Text_Info").GetComponent<Text>();
        t_temp.text = "請選擇要練習或挑戰\n";
    }
}
