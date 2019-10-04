using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Task_Bank
{
    public static int[] Learn_Request_Score = new int[7] {80, 80, 60, 80, 80, 60, 60 };

    public static string[] C_Learn_Title = new string[7] { "Level-1", "Level-2", "Level-3", "Level-4", "Level-5", "Level-6", "Overall" };
    public static string[] C_Learn_Threshold = new string[7] { "無", "無", "完成Level-1 & Level-2", "無", "無", "完成Level-4 & Level-5", "完成Level-1~6" };
    public static string[] C_Learn_Request = new string[7] { "Level-1 80分以上！", "Level-2 80分以上！", "Level-3 60分以上！", "Level-4 80分以上！", "Level-5 80分以上！", "Level-6 60分以上！", "Overall 60分以上！" };

    public static string[] C_Battle_Title = new string[3] { "Battle 1", "Battle 2", "Battle 3" };
    public static string[] C_Battle_Threshold = new string[3] { "無", "完成Battle 1", "完成Battle 2" };
    public static string[] C_Battle_Request = new string[3] { "在Battle 1取得勝利", "在Battle 2取得勝利", "在Battle 3取得勝利" };

    public static string[] E_Learn_Title = new string[7] { "Level-1", "Level-2", "Level-3", "Level-4", "Level-5", "Level-6", "Overall" };
    public static string[] E_Learn_Threshold = new string[7] { "None", "None", "Level-1 and Level-2're Over", "None", "None", "Level-4 and Level-5're Over", "Level-1~6're Over" };
    public static string[] E_Learn_Request = new string[7] { "Complete the Level-1(80)！", "Complete the Level-2(80)！", "Complete the Level-3(60)！", "Complete the Level-4(80)！", "Complete the Level-5(80)！", "Complete the Level-6(60)！", "Complete the Overall(60)！" };

    public static string[] E_Battle_Title = new string[3] { "Battle 1", "Battle 2", "Battle 3" };
    public static string[] E_Battle_Threshold = new string[3] { "None", "Battle 1's Over", "Battle 2's Over" };
    public static string[] E_Battle_Request = new string[3] { "Get a win in Battle 1", "Get a win in Battle 2", "Get a win in Battle 3" };

    //獎懲
    public static string[] C_Learn_Reward_0 = new string[7] { "分數 +10", "分數 +10", "分數 +30、No.19", "分數 +10", "分數 +10", "分數 +30、No.20", "分數 +50、No.21" };
    public static string[] C_Learn_Punishment_0 = new string[7] { "分數 -10", "分數 -10", "分數 -20", "分數 -10", "分數 -10", "分數 -20", "分數 -30" };
    public static string[] C_Battle_Reward_0 = new string[3] { "分數 +10", "分數 +20、No.17", "分數 +20、No.18" };
    public static string[] C_Battle_Punishment_0 = new string[3] { "分數 -10", "分數 -10", "分數 -10" };

    public static string[] E_Learn_Reward_0 = new string[7] { "Score +10", "Score +10", "Score +30、No.19", "Score +10", "Score +10", "Score +30、No.20", "Score +50、No.21" };
    public static string[] E_Learn_Punishment_0 = new string[7] { "Score -10", "Score -10", "Score -20", "Score -10", "Score -10", "Score -20", "Score -30" };
    public static string[] E_Battle_Reward_0 = new string[3] { "Score +10", "Score +20、No.17", "Score +20、No.18" };
    public static string[] E_Battle_Punishment_0 = new string[3] { "Score -10", "Score -10", "Score -10" };

    public static string[] C_Learn_Reward_1 = new string[7] { "無", "無", "無", "無", "無", "無", "無", };
    public static string[] C_Learn_Punishment_1 = new string[7] { "無", "無", "無", "無", "無", "無", "無" };
    public static string[] C_Battle_Reward_1 = new string[3] { "無", "無", "無", };
    public static string[] C_Battle_Punishment_1 = new string[3] { "無", "無", "無", };

    public static string[] E_Learn_Reward_1 = new string[7] { "None", "None", "None", "None", "None", "None", "None" };
    public static string[] E_Learn_Punishment_1 = new string[7] { "None", "None", "None", "None", "None", "None", "None" };
    public static string[] E_Battle_Reward_1 = new string[3] { "None", "None", "None" };
    public static string[] E_Battle_Punishment_1 = new string[3] { "None", "None", "None" };


}
