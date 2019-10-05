using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

static class Select_Learn_PointerEnter{

    public static void Practice(BaseEventData data)
    {
        Text t_temp;
        AudioSource Select_choose = GameObject.Find("Select_Choose").GetComponent<AudioSource>();
        Select_choose.Play();
        t_temp = GameObject.Find("Text_Info").GetComponent<Text>();
        t_temp.text = "這是練習\n點擊可開啟所有關卡來練習";
    }
    public static void Challenge(BaseEventData data)
    {
        Text t_temp;
        AudioSource Select_choose = GameObject.Find("Select_Choose").GetComponent<AudioSource>();
        Select_choose.Play();
        t_temp = GameObject.Find("Text_Info").GetComponent<Text>();
        t_temp.text = "這是挑戰\n點擊可開啟接下的任務來挑戰";
    }
}
