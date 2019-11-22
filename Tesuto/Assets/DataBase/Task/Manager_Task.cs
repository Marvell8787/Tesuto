using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_Task{

    private string serverlink = System_Setting.serverlink;
    private string[] items;
    int LearnPoint = 0;
    int BattlePoint = 0;
    public IEnumerator DownloadTask(string fileName)
    {
        WWW reg = new WWW(serverlink + fileName);
        yield return reg;
        string itemDatastring = reg.text;
        items = itemDatastring.Split(';');
        foreach(string str in items)
        {
            string Task_Title, Task_Classification, Task_Threshold, Task_Request,Task_Reward_O, Task_Reward_X, Task_Punishment_O, Task_Punishment_X;
            int Task_Request_Score, Task_Reward_O_Num, Task_Reward_X_Num, Task_Punishment_O_Num, Task_Punishment_X_Num,Task_Status;
            if (str != ""){
                Task_Title = GetDataValue(str, "Task_Title:");
                Task_Classification = GetDataValue(str, "Task_Classification:");
                Task_Threshold = GetDataValue(str, "Task_Threshold:");
                Task_Request = GetDataValue(str, "Task_Request:");
                Task_Request_Score = int.Parse(GetDataValue(str, "Task_Request_Score:"));
                Task_Reward_O = GetDataValue(str, "Task_Reward_O:");
                Task_Reward_O_Num = int.Parse(GetDataValue(str, "Task_Reward_O_Num:"));
                Task_Reward_X = GetDataValue(str, "Task_Reward_X:");
                Task_Reward_X_Num = int.Parse(GetDataValue(str, "Task_Reward_X_Num:"));
                Task_Punishment_O = GetDataValue(str, "Task_Reward_O:");
                Task_Punishment_O_Num = int.Parse(GetDataValue(str, "Task_Reward_O_Num:"));
                Task_Punishment_X = GetDataValue(str, "Task_Reward_X:");
                Task_Punishment_X_Num = int.Parse(GetDataValue(str, "Task_Reward_X_Num:"));
                Task_Status = int.Parse(GetDataValue(str, "Task_Status:"));

                if(Task_Classification == "Learn")
                {
                    Task_Bank.Learn_Title[LearnPoint] = Task_Title;
                    Task_Bank.Learn_Threshold[LearnPoint] = Task_Threshold;
                    Task_Bank.Learn_Request[LearnPoint] = Task_Request;
                    Task_Bank.Learn_Request_Score[LearnPoint] = Task_Request_Score;
                    Task_Bank.Learn_Status[LearnPoint] = Task_Status;
                    switch (System_Setting.Version)
                    {
                        case 0:
                            Task_Bank.Learn_Reward[LearnPoint] = Task_Reward_O;
                            Task_Bank.Learn_Punishment[LearnPoint] = Task_Punishment_O;
                            Task_Bank.Task_Reward[LearnPoint] = Task_Reward_O_Num;
                            Task_Bank.Task_Punishment[LearnPoint] = Task_Punishment_O_Num;
                            break;
                        case 1:
                            Task_Bank.Learn_Reward[LearnPoint] = Task_Reward_O;
                            Task_Bank.Learn_Punishment[LearnPoint] = Task_Punishment_X;
                            Task_Bank.Task_Reward[LearnPoint] = Task_Reward_O_Num;
                            Task_Bank.Task_Punishment[LearnPoint] = Task_Punishment_X_Num;
                            break;
                        case 2:
                            Task_Bank.Learn_Reward[LearnPoint] = Task_Reward_X;
                            Task_Bank.Learn_Punishment[LearnPoint] = Task_Punishment_O;
                            Task_Bank.Task_Reward[LearnPoint] = Task_Reward_X_Num;
                            Task_Bank.Task_Punishment[LearnPoint] = Task_Punishment_O_Num;
                            break;
                        case 3:
                            Task_Bank.Learn_Reward[LearnPoint] = Task_Reward_X;
                            Task_Bank.Learn_Punishment[LearnPoint] = Task_Punishment_X;
                            Task_Bank.Task_Reward[LearnPoint] = Task_Reward_X_Num;
                            Task_Bank.Task_Punishment[LearnPoint] = Task_Punishment_X_Num;
                            break;
                        default:
                            break;
                    }
                    LearnPoint++;
                }
                else if (Task_Classification == "Battle")
                {
                    Task_Bank.Battle_Title[BattlePoint] = Task_Title;
                    Task_Bank.Battle_Threshold[BattlePoint] = Task_Threshold;
                    Task_Bank.Battle_Request[BattlePoint] = Task_Request;
                    Task_Bank.Battle_Status[BattlePoint] = Task_Status;

                    switch (System_Setting.Version)
                    {
                        case 0:
                            Task_Bank.Battle_Reward[BattlePoint] = Task_Reward_O;
                            Task_Bank.Battle_Punishment[BattlePoint] = Task_Punishment_O;
                            Task_Bank.Task_Reward[LearnPoint+BattlePoint] = Task_Reward_O_Num;
                            Task_Bank.Task_Punishment[LearnPoint+BattlePoint] = Task_Punishment_O_Num;
                            break;
                        case 1:
                            Task_Bank.Battle_Reward[BattlePoint] = Task_Reward_O;
                            Task_Bank.Battle_Punishment[BattlePoint] = Task_Punishment_X;
                            Task_Bank.Task_Reward[LearnPoint + BattlePoint] = Task_Reward_O_Num;
                            Task_Bank.Task_Punishment[LearnPoint + BattlePoint] = Task_Punishment_X_Num;
                            break;
                        case 2:
                            Task_Bank.Battle_Reward[BattlePoint] = Task_Reward_X;
                            Task_Bank.Battle_Punishment[BattlePoint] = Task_Punishment_O;
                            Task_Bank.Task_Reward[LearnPoint + BattlePoint] = Task_Reward_X_Num;
                            Task_Bank.Task_Punishment[LearnPoint + BattlePoint] = Task_Punishment_O_Num;
                            break;
                        case 3:
                            Task_Bank.Battle_Reward[BattlePoint] = Task_Reward_X;
                            Task_Bank.Battle_Punishment[BattlePoint] = Task_Punishment_X;
                            Task_Bank.Task_Reward[LearnPoint + BattlePoint] = Task_Reward_X_Num;
                            Task_Bank.Task_Punishment[LearnPoint + BattlePoint] = Task_Punishment_X_Num;
                            break;
                        default:
                            break;
                    }
                    BattlePoint++;
                }
            }
        }
    }

    public string GetDataValue(string data,string index)
    {
        string value = data.Substring(data.IndexOf(index) + index.Length);
        if(value.Contains("|"))value=value.Remove(value.IndexOf("|"));
        return value;
    }

    
}
