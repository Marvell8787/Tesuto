using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Battle_Bank{

    public static string[] C_Battle_Title = new string[3] { "Battle-1", "Battle-2", "Battle-3" };
    public static string[] C_Battle_QuestionType = new string[3] {  "字彙", "字彙", "字彙" };
    public static string[] C_Battle_Range = new string[3] { "1-5", "1-15", "1-20" };
    
    public static string[] E_Battle_Title = new string[3] { "Battle-1", "Battle-2", "Battle-3" };
    public static string[] E_Battle_QuestionType = new string[3] { "Vocabulary", "Vocabulary", "Vocabulary" };
    public static string[] E_Battle_Range = new string[3] { "1-5", "1-15", "1-20" };

    public static string[] Battle_Time = new string[3] { "5", "10", "15" };
    public static string[] Battle_LP = new string[3] { "10", "15", "20" };
    public static string[] Battle_Deck = new string[3] { "14", "17", "20" };

    //獎
    public static string[] C_Battle_Reward_0 = new string[3] { "水晶 +10", "水晶 +50", "水晶 +200" };
    public static string[] C_Battle_Reward_1 = new string[3] { "無", "無", "無" };
    public static string[] E_Battle_Reward_0 = new string[3] { "Crystal +10", "Crystal +50", "Crystal +200" };
    public static string[] E_Battle_Reward_1 = new string[3] { "None", "None", "None" };
    //懲
    public static string[] C_Battle_Punishment_0 = new string[3] { "水晶 -10", "水晶 -50", "水晶 -200" };
    public static string[] C_Battle_Punishment_1 = new string[3] { "無", "無", "無" };
    public static string[] E_Battle_Punishment_0 = new string[3] { "Crystal -10", "Crystal -50", "Crystal -200" };
    public static string[] E_Battle_Punishment_1 = new string[3] { "None", "None", "None" };

    //獎懲 int
    public static int[] Battle_Reward = new int[3] { 10, 50, 200 };
    public static int[] Battle_Punishment = new int[3] { -10, -50, -200 };
}
