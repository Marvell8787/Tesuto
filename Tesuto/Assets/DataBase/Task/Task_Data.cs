using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Task_Data{
    private static string[] Learn_Title = new string[7] { "", "", "", "", "", "", "" };
    private static string[] Learn_Threshold = new string[7] { "", "", "", "", "", "", "" };
    private static string[] Learn_Request = new string[7] { "", "", "", "", "", "", "" };
    private static string[] Learn_Reward = new string[7] { "", "", "", "", "", "", "" };
    private static string[] Learn_Punishment = new string[7] { "", "", "", "", "", "", "" };

    private static int[] Learn_Status = new int[7] { 1, 1, 0, 1, 1, 0, 0 };


    private static string[] Battle_Title = new string[3] { "", "", "" };
    private static string[] Battle_Threshold = new string[3] { "", "", "" };
    private static string[] Battle_Request = new string[3] { "", "", "" };
    private static string[] Battle_Reward = new string[3] { "", "", "" };
    private static string[] Battle_Punishment = new string[3] { "", "", "" };

    private static int[] Battle_Status = new int[3] { 1, 0, 0 };


    private static Task_Class[] learn_temp = new Task_Class[7];
    private static Task_Class[] battle_temp = new Task_Class[3];
    public static void Task_Init()
    {
        switch (System_Setting.Language)
        {
            case 0:
                for (int i = 0; i < 7; i++)
                {
                    Learn_Title[i] = Task_Bank.C_Learn_Title[i];
                    Learn_Threshold[i] = Task_Bank.C_Learn_Threshold[i];
                    Learn_Request[i] = Task_Bank.C_Learn_Request[i];
                }
                for (int i = 0; i < 3; i++)
                {
                    Battle_Title[i] = Task_Bank.C_Battle_Title[i];
                    Battle_Threshold[i] = Task_Bank.C_Battle_Threshold[i];
                    Battle_Request[i] = Task_Bank.C_Battle_Request[i];
                }
                switch (System_Setting.Version)
                {
                    case 0:
                        for (int i = 0; i < 7; i++)
                        {
                            Learn_Reward[i] = Task_Bank.C_Learn_Reward_0[i];
                            Learn_Punishment[i] = Task_Bank.C_Learn_Punishment_0[i];
                        }
                        for (int i = 0; i < 3; i++)
                        {
                            Battle_Reward[i] = Task_Bank.C_Battle_Reward_0[i];
                            Battle_Punishment[i] = Task_Bank.C_Battle_Punishment_0[i];
                        }
                        break;
                    case 1:
                        for (int i = 0; i < 7; i++)
                        {
                            Learn_Reward[i] = Task_Bank.C_Learn_Reward_0[i];
                            Learn_Punishment[i] = Task_Bank.C_Learn_Punishment_1[i];
                        }
                        for (int i = 0; i < 3; i++)
                        {
                            Battle_Reward[i] = Task_Bank.C_Battle_Reward_0[i];
                            Battle_Punishment[i] = Task_Bank.C_Battle_Punishment_1[i];
                        }
                        break;
                    case 2:
                        for (int i = 0; i < 7; i++)
                        {
                            Learn_Reward[i] = Task_Bank.C_Learn_Reward_1[i];
                            Learn_Punishment[i] = Task_Bank.C_Learn_Punishment_0[i];
                        }
                        for (int i = 0; i < 3; i++)
                        {
                            Battle_Reward[i] = Task_Bank.C_Battle_Reward_1[i];
                            Battle_Punishment[i] = Task_Bank.C_Battle_Punishment_0[i];
                        }
                        break;
                    case 3:
                        for (int i = 0; i < 7; i++)
                        {
                            Learn_Reward[i] = Task_Bank.C_Learn_Reward_1[i];
                            Learn_Punishment[i] = Task_Bank.C_Learn_Punishment_1[i];
                        }
                        for (int i = 0; i < 3; i++)
                        {
                            Battle_Reward[i] = Task_Bank.C_Battle_Reward_1[i];
                            Battle_Punishment[i] = Task_Bank.C_Battle_Punishment_1[i];
                        }
                        break;
                    default:
                        break;
                }
                break;
            case 1:
                for (int i = 0; i < 7; i++)
                {
                    Learn_Title[i] = Task_Bank.E_Learn_Title[i];
                    Learn_Threshold[i] = Task_Bank.E_Learn_Threshold[i];
                    Learn_Request[i] = Task_Bank.E_Learn_Request[i];
                }
                for (int i = 0; i < 3; i++)
                {
                    Battle_Title[i] = Task_Bank.E_Battle_Title[i];
                    Battle_Threshold[i] = Task_Bank.E_Battle_Threshold[i];
                    Battle_Request[i] = Task_Bank.E_Battle_Request[i];
                }
                switch (System_Setting.Version)
                {
                    case 0:
                        for (int i = 0; i < 7; i++)
                        {
                            Learn_Reward[i] = Task_Bank.E_Learn_Reward_0[i];
                            Learn_Punishment[i] = Task_Bank.E_Learn_Punishment_0[i];
                        }
                        for (int i = 0; i < 3; i++)
                        {
                            Battle_Reward[i] = Task_Bank.E_Battle_Reward_0[i];
                            Battle_Punishment[i] = Task_Bank.E_Battle_Punishment_0[i];
                        }
                        break;
                    case 1:
                        for (int i = 0; i < 7; i++)
                        {
                            Learn_Reward[i] = Task_Bank.E_Learn_Reward_0[i];
                            Learn_Punishment[i] = Task_Bank.E_Learn_Punishment_1[i];
                        }
                        for (int i = 0; i < 3; i++)
                        {
                            Battle_Reward[i] = Task_Bank.E_Battle_Reward_0[i];
                            Battle_Punishment[i] = Task_Bank.E_Battle_Punishment_1[i];
                        }
                        break;
                    case 2:
                        for (int i = 0; i < 7; i++)
                        {
                            Learn_Reward[i] = Task_Bank.E_Learn_Reward_1[i];
                            Learn_Punishment[i] = Task_Bank.E_Learn_Punishment_0[i];
                        }
                        for (int i = 0; i < 3; i++)
                        {
                            Battle_Reward[i] = Task_Bank.E_Battle_Reward_1[i];
                            Battle_Punishment[i] = Task_Bank.E_Battle_Punishment_0[i];
                        }
                        break;
                    case 3:
                        for (int i = 0; i < 7; i++)
                        {
                            Learn_Reward[i] = Task_Bank.E_Learn_Reward_1[i];
                            Learn_Punishment[i] = Task_Bank.E_Learn_Punishment_1[i];
                        }
                        for (int i = 0; i < 3; i++)
                        {
                            Battle_Reward[i] = Task_Bank.E_Battle_Reward_1[i];
                            Battle_Punishment[i] = Task_Bank.E_Battle_Punishment_1[i];
                        }
                        break;
                    default:
                        break;
                }
                break;
            default:
                break;
        }

        //宣告 learn_temp 陣列並加入資料 Start
        for(int i = 0; i < 7; i++)
        {
            learn_temp[i] = new Task_Class(Learn_Title[i], Learn_Threshold[i], Learn_Request[i], Learn_Reward[i], Learn_Punishment[i], Learn_Status[i]);
        }
        //宣告 learn_temp 陣列並加入資料 End
        //宣告 battle_temp 陣列並加入資料 Start

        for (int i = 0; i < 3; i++)
        {
            battle_temp[i] = new Task_Class(Battle_Title[i], Battle_Threshold[i], Battle_Request[i], Battle_Reward[i], Battle_Punishment[i], Battle_Status[i]);
        }
        //宣告 battle_temp 陣列並加入資料 End
    }
    public static Task_Class Learn_Get(int n)
    {
        return learn_temp[n];
    }
    public static Task_Class Battle_Get(int n)
    {
        return battle_temp[n];
    }
    public static int GetStatus(string s, int c) //learn battle 陣列元素 參數
    {
        if (s == "learn")
        {
            return Learn_Status[c];
        }
        else
        {
            return Battle_Status[c];
        }

    }
    public static void ChangeStatus(string s, int c,int n) //learn battle 陣列元素 參數
    {
        if (s == "learn")
        {
            learn_temp[c].ChangeStatus(n);
        }
        else if (s == "battle")
        {
            battle_temp[c].ChangeStatus(n);
        }
    }
}
