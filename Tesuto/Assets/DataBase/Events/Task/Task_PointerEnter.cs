using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

static class Task_PointerEnter{

    public static void Task_Learn(BaseEventData data)
    {
        Text t_temp;
        AudioSource Task_choose = GameObject.Find("Main_Choose").GetComponent<AudioSource>();
        Task_choose.Play();
        t_temp = GameObject.Find("Text_Info").GetComponent<Text>();
        t_temp.text = "這是任務中的學習分類\n點擊可觀看學習任務";
    }
    public static void Task_Battle(BaseEventData data)
    {
        Text t_temp;
        AudioSource Task_choose = GameObject.Find("Main_Choose").GetComponent<AudioSource>();
        Task_choose.Play();
        t_temp = GameObject.Find("Text_Info").GetComponent<Text>();
        t_temp.text = "這是任務中的戰鬥分類\n點擊可觀看戰鬥任務";
    }
}
