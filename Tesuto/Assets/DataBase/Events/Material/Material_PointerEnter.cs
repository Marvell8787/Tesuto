using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

static class Material_PointerEnter{

    public static void Up(BaseEventData data)
    {
        Text t_temp;
        t_temp = GameObject.Find("Text_Info").GetComponent<Text>();
        t_temp.text = "上一頁";
    }
    public static void Down(BaseEventData data)
    {
        Text t_temp;
        t_temp = GameObject.Find("Text_Info").GetComponent<Text>();
        t_temp.text = "下一頁";
    }
    public static void Left(BaseEventData data)
    {
        Text t_temp;
        t_temp = GameObject.Find("Text_Info").GetComponent<Text>();
        t_temp.text = "上一個";
    }
    public static void Right(BaseEventData data)
    {
        Text t_temp;
        t_temp = GameObject.Find("Text_Info").GetComponent<Text>();
        t_temp.text = "下一個";
    }
    public static void Voice(BaseEventData data)
    {
        Text t_temp;
        t_temp = GameObject.Find("Text_Info").GetComponent<Text>();
        t_temp.text = "點擊即可播放音檔";
    }
}
