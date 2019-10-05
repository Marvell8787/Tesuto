using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Level_Bank
{
    public static string[] C_Level_Title = new string[7] { "Level-1", "Level-2", "Level-3", "Level-4", "Level-5", "Level-6", "Overall" };
    public static string[] C_Level_QuestionType = new string[7] { "聽力", "聽力", "聽力", "字彙", "字彙", "字彙", "拼字" };
    public static string[] C_Level_Range = new string[7] { "1-10", "11-20", "1-20", "1-10", "11-20", "1-20", "1-20" };

    public static string[] E_Level_Title = new string[7] { "Level-1", "Level-2", "Level-3", "Level-4", "Level-5", "Level-6", "Overall" };
    public static string[] E_Level_QuestionType = new string[7] { "Listening", "Listening", "Listening", "Vocabulary", "Vocabulary", "Vocabulary", "Spelling" };
    public static string[] E_Level_Range = new string[7] { "1-10", "11-20", "1-20", "1-10", "11-20", "1-20", "1-20" };

    //獎
    public static string[] C_Level_Reward_0 = new string[7] { "金幣 +10", "金幣 +10", "金幣 +50、No.12", "金幣 +10", "金幣 +10", "金幣 +50、No.13", "金幣 +100、No.14" };
    public static string[] C_Level_Reward_1 = new string[7] { "無", "無", "無", "無", "無", "無", "無" };
    public static string[] E_Level_Reward_0 = new string[7] { "Coin +10", "Coin +10", "Coin +50、No.12", "Coin +10", "Coin +10", "Coin +50、No.13", "Coin +100、No.14" };
    public static string[] E_Level_Reward_1 = new string[7] { "None", "None", "None", "None", "None", "None", "None" };
    //懲
    public static string[] C_Level_Punishment_0 = new string[7] { "金幣 -50", "金幣 -50", "金幣 -100", "金幣 -50", "金幣 -50", "金幣 -100", "金幣 -200" };
    public static string[] C_Level_Punishment_1 = new string[7] { "無", "無", "無", "無", "無", "無", "無" };
    public static string[] E_Level_Punishment_0 = new string[7] { "Coin -50", "Coin -50", "Coin -100", "Coin -50", "Coin -50", "Coin -100", "Coin -200" };
    public static string[] E_Level_Punishment_1 = new string[7] { "None", "None", "None", "None", "None", "None", "None" };
}
