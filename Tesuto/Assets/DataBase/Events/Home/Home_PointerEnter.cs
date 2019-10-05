using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

//弄好mysql後 將text字串連上db
static class Home_PointerEnter{
    public static AudioSource choose = GameObject.Find("Choose").GetComponent<AudioSource>();

    public static void Task(BaseEventData data)
    {
        Text t_temp;
        choose.Play();
        t_temp = GameObject.Find("Text_Info").GetComponent<Text>();
        t_temp.text = "這是任務\n是本遊戲中要完成的目標\n點擊可開啟任務清單";
    }
    public static void Learn(BaseEventData data)
    {
        Text t_temp;
        choose.Play();
        t_temp = GameObject.Find("Text_Info").GetComponent<Text>();
        t_temp.text = "這是學習\n含有教材和關卡\n點擊即可進入";
    }
    public static void Battle(BaseEventData data)
    {
        Text t_temp;
        choose.Play();
        t_temp = GameObject.Find("Text_Info").GetComponent<Text>();
        t_temp.text = "這是戰鬥\n能以手中持有的卡牌與電腦進行對戰\n點擊即可進入";
    }
    public static void Guide(BaseEventData data)
    {
        Text t_temp;
        choose.Play();
        t_temp = GameObject.Find("Text_Info").GetComponent<Text>();
        t_temp.text = "這是導覽\n可得知本遊戲的相關資訊\n點擊即可進入";
    }
    public static void Profile(BaseEventData data)
    {
        Text t_temp;
        choose.Play();
        t_temp = GameObject.Find("Text_Info").GetComponent<Text>();
        t_temp.text = "這是狀態\n可得知玩家本身及持有物的狀態\n點擊即可進入";
    }
    public static void Shop(BaseEventData data)
    {
        Text t_temp;
        choose.Play();
        t_temp = GameObject.Find("Text_Info").GetComponent<Text>();
        t_temp.text = "這是商店\n能以分數、金幣、水晶購買相關物品\n點擊即可進入";
    }
    public static void Deck(BaseEventData data)
    {
        Text t_temp;
        choose.Play();
        t_temp = GameObject.Find("Text_Info").GetComponent<Text>();
        t_temp.text = "這是牌組\n可得知目前持有的卡牌資訊\n點擊即可進入";
    }
    public static void Badges(BaseEventData data)
    {
        Text t_temp;
        choose.Play();
        t_temp = GameObject.Find("Text_Info").GetComponent<Text>();
        t_temp.text = "這是獎章\n可得知獎章資訊\n點擊即可進入";
    }
    public static void Rank(BaseEventData data)
    {
        Text t_temp;
        choose.Play();
        t_temp = GameObject.Find("Text_Info").GetComponent<Text>();
        t_temp.text = "這是排行榜\n可得知玩家的排名狀況\n點擊即可進入";
    }
    public static void Task_Goal(BaseEventData data)
    {
        Text t_temp;
        t_temp = GameObject.Find("Text_Info").GetComponent<Text>();
        t_temp.text = "這是本遊戲目標\n請完成所有任務";
    }
}
