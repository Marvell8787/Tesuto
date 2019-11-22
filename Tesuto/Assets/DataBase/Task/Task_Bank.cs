using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Task_Bank
{
    public static int[] Learn_Request_Score = new int[7] {90, 90, 80, 90, 90, 80, 80 };

    public static string[] Learn_Title = new string[7] { "Level-1", "Level-2", "Level-3", "Level-4", "Level-5", "Level-6", "Fin" };
    public static string[] Learn_Threshold = new string[7] { "無", "無", "完成Level-1 & Level-2", "無", "無", "完成Level-4 & Level-5", "完成Level-1~6" };
    public static string[] Learn_Request = new string[7] { "Level-1 90分以上！", "Level-2 90分以上！", "Level-3 80分以上！", "Level-4 90分以上！", "Level-5 90分以上！", "Level-6 80分以上！", "Overall 80分以上！" };
    public static string[] Learn_Reward = new string[7] { "分數 +10", "分數 +10", "分數 +30", "分數 +10", "分數 +10、No.14", "分數 +30", "分數 +50" };
    public static string[] Learn_Punishment = new string[7] { "分數 -10", "分數 -10", "分數 -30", "分數 -10", "分數 -10", "分數 -30", "分數 -50" };

    public static string[] Battle_Title = new string[3] { "Battle 1", "Battle 2", "Battle 3" };
    public static string[] Battle_Threshold = new string[3] { "無", "完成Battle 1", "完成Battle 2" };
    public static string[] Battle_Request = new string[3] { "在Battle 1取得勝利", "在Battle 2取得勝利", "在Battle 3取得勝利" };
    public static string[] Battle_Reward = new string[3] { "分數 +10", "分數 +20", "分數 +50" };
    public static string[] Battle_Punishment = new string[3] { "分數 -10", "分數 -20", "分數 -50" };

    //獎懲數字
    public static int[] Task_Reward = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public static int[] Task_Punishment = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    //狀態
    public static int[] Learn_Status = new int[7] { 1, 1, 0, 1, 1, 0, 0 };
    public static int[] Battle_Status = new int[3] { 1, 0, 0 };
}
