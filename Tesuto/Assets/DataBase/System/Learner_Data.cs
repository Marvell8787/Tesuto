using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Learner_Data{
    //Task
    private static int Task_Finish = 0; //完成數量
    private static int Task_Succes = 0; //成功數量
    private static int Task_Fail = 0; //失敗數量
    //Learn
    private static int Learn_Finish = 0; //完成數量
    private static int Learn_Succes = 0; //成功數量
    private static int[] Learn_Status = new int[7] { 0, 0, 0, 0, 0, 0, 0}; //0:無 1:有

    //Battle
    private static int Battle_Num = 0; //戰鬥次數
    private static int Battle_Win = 0; //勝利次數
    private static int Battle_Lose = 0; //失敗次數
    private static int Battle_Question_Succes_Num = 0; //戰鬥回答成功次數
    private static int Battle_Question_Fail_Num = 0; //戰鬥回答失敗次數
    //Reward and Punishment
    private static int Score = 100; //分數
    private static int Score_Highest = 100; //分數高點
    private static int Coin = 200; //金幣持有
    private static int Coin_Total = 200; //金幣總數
    private static int Crystal = 10; //水晶
    private static int Crystal_Highest = 10; //水晶高數
    //Reward
    //Badges
    private static int[] Badges_Status = new int[18] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; //獎章持有狀態 0:無 1:有
    //test private static int[] Badges_Status = new int[18] { 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; //獎章持有狀態 0:無 1:有

    private static int Badges_Num = 0; //獎章數量

    //Card
    private static int Cards_Num = 10; //卡片數量
    private static int[] Card_Status = new int[22] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 }; //卡片持有狀態 0:無 1~22:有
    //Punishment
    //Point
    private static int[] Points_Status = new int[3] { 3, 3, 3}; //點數持有狀態 Task Learn Battle
    private static int Points_Num = 9; //點數
    //Mistakes
    private static int[] Mistakes_Status = new int[3] { 0, 0, 0 }; //失誤持有狀態 warn YC RC
    private static int Mistakes_Num = 0; //失誤

    public static void Learner_Add(string s,int n) // s=想要加的東西  n=數字(可+ -)   
    {
        switch (s)
        {
            //Task
            case "Task_Finish":Task_Finish+=n;break;
            case "Task_Succes":Task_Succes += n;break;
            case "Task_Fail": Task_Fail += n; break;
            //Learn
            case "Learn_Finish": Learn_Finish += n; break;
            //Battle
            case "Battle_Num": Battle_Num += n; break;
            case "Battle_Win": Battle_Win += n; break;
            case "Battle_Lose": Battle_Lose += n; break;
            case "Battle_Question_Succes_Num": Battle_Question_Succes_Num += n; break;
            case "Battle_Question_Fail_Num": Battle_Question_Fail_Num += n; break;
            //Reward and Punishment
            case "Score": Score += n; if (Score > Score_Highest) Score_Highest = Score; break;
            case "Coin": Coin += n; break;
            case "Crystal": Crystal += n; if (Crystal > Crystal_Highest) Crystal_Highest = Crystal; break;
            //Score_Highest Crystal_Highest 是指定
            case "Score_Highest": Score_Highest = n; break;
            case "Coin_Total": Coin_Total += n; break;
            case "Crystal_Highest": Crystal_Highest = n; break;
            //Reward
            case "Badges_Num": Badges_Num += n; break;
            case "Card_Num": Cards_Num += n; break;
            //Punishment
            case "Points_Num": Points_Num += n; break;
            case "Mistakes_Num": Mistakes_Num += n; break;
            default: break;
        }
        CheckBase(s);
        CheckBadges(s);
        CheckPoints(s);
        CheckMistakes(s);
    }
    public static int Learner_GetData(string s) // s=想要讀取的東西    
    {
        int n;
        switch (s)
        {
            //Task
            case "Task_Finish": n= Task_Finish; break;
            case "Task_Succes": n= Task_Succes; break;
            case "Task_Fail": n= Task_Fail; break;
            //Learn
            case "Learn_Finish": n= Learn_Finish; break;
            //Battle
            case "Battle_Num":  n= Battle_Num; break;
            case "Battle_Win": n= Battle_Win; break;
            case "Battle_Lose": n= Battle_Lose; break;
            case "Battle_Question_Succes_Num": n= Battle_Question_Succes_Num; break;
            case "Battle_Question_Fail_Num": n= Battle_Question_Fail_Num; break;
            //Reward and Punishment
            case "Score": n= Score; break;
            case "Coin": n= Coin; break;
            case "Crystal": n= Crystal; break;
            //Reward
            case "Badges_Num": n= Badges_Num; break;
            case "Cards_Num": n= Cards_Num; break;
            //Punishment
            case "Points_Num": n= Points_Num; break;
            case "Mistakes_Num": n= Mistakes_Num; break;

            default: n = 0; break;
        }
        return n;
    }
    private static void CheckBase(string s)
    {
        switch (s)
        {
            //Task
            case "Score":
                if (Score <= 0)
                    Points_Status[0] -= 1;
                break;
            //Learn
            case "Coin":
                if (Coin <= 0)
                    Points_Status[1] -= 1;
                break;
            //Battle
            case "Crystal":
                if (Crystal <= 0)
                    Points_Status[2] -= 1;
                break;
            default:
                break;
        }
    }

    public static int Learner_GetLearn_Status(int n)
    {
        return Learn_Status[n];
    }
    public static void Learner_ChangeLearn_Status(int n) //Cards
    {
        Learn_Status[n] = 1;
    }

    public static int Learner_GetCard_Status(int n)
    {
            return Card_Status[n];
    }
    public static void Learner_ChangeCard_Status(int n) //Cards
    {
        Card_Status[n] = 1;
    }

    //Badges
    public static int Learner_GetBadges_Status(int n)
    {
        return Badges_Status[n];
    }
    public static void Learner_ChangeBadges_Status(int n) //Badges
    {
        Badges_Status[n] = 1;
    }
    private static void CheckBadges(string s)
    {
        switch (s)
        {
            //Task
            case "Task_Succes":
                if(Task_Succes>2 && Task_Succes < 5)
                    Badges_Status[0] = 1;
                else if(Task_Succes > 4 && Task_Succes < 8)
                    Badges_Status[1] = 1;
                else if (Task_Succes > 7)
                    Badges_Status[2] = 1;
                break;
            //Learn
            case "Learn_Succes":
                if (Learn_Succes > 4 && Learn_Succes < 10)
                    Badges_Status[3] = 1;
                else if (Learn_Succes > 9 && Learn_Succes < 20)
                    Badges_Status[4] = 1;
                else if (Learn_Succes > 19)
                    Badges_Status[5] = 1;
                break;
            //Battle
            case "Battle_Win":
                if (Battle_Win > 2 && Battle_Win < 5)
                    Badges_Status[6] = 1;
                else if (Battle_Win > 4 && Battle_Win < 10)
                    Badges_Status[7] = 1;
                else if (Battle_Win > 9)
                    Badges_Status[8] = 1;
                break;
            //Score_Highest Crystal_Highest 是指定
            case "Score":
                if (Score_Highest > 149 && Score_Highest < 200)
                    Badges_Status[9] = 1;
                else if (Score_Highest > 199 && Score_Highest < 250)
                    Badges_Status[10] = 1;
                else if (Score_Highest > 249)
                    Badges_Status[11] = 1;
                break;
            case "Coin_Total":
                if (Coin_Total > 199 && Coin_Total < 400)
                    Badges_Status[12] = 1;
                else if (Coin_Total > 399 && Coin_Total < 600)
                    Badges_Status[13] = 1;
                else if (Coin_Total > 599)
                    Badges_Status[14] = 1;
                break;
            case "Crystal":
                if (Crystal_Highest > 149 && Crystal_Highest < 250)
                    Badges_Status[15] = 1;
                else if (Crystal_Highest > 249 && Crystal_Highest < 400)
                    Badges_Status[16] = 1;
                else if (Crystal_Highest > 399)
                    Badges_Status[17] = 1;
                break;
            default:
                break;
        }
    }

    //Points
    public static int Learner_GetPoints_Status(int n)
    {
        return Points_Status[n];
    }
    public static void Learner_ChangePoints_Status(int n) //Points
    {
        Points_Status[n] -= 1;
        CheckPoints("Points_Num");
    }
    private static void CheckPoints(string s)
    {
        switch (s)
        {
            case "Points_Num":
                if (Points_Status[0] == 0)
                {
                    //關閉任務功能
                }
                else if (Points_Status[1]== 0)
                {
                    //關閉學習功能
                }
                else if (Points_Status[2] == 0)
                {
                    //關閉戰鬥功能
                }
                break;
            default:
                break;
        }
    }
    //Mistakes
    public static int Learner_GetMistakes_Status(int n)
    {
        return Mistakes_Status[n];
    }
    public static void Learner_ChangeMistakes_Status(int n) //Mistakes
    {
        Mistakes_Status[n] += 1;
        CheckMistakes("Mistakes_Num");
    }
    private static void CheckMistakes(string s)
    {
        switch (s)
        {
            case "Mistakes_Num":
                if ((Mistakes_Status[0] % 3) == 0 && Mistakes_Status[0] > 0)
                {
                    Mistakes_Status[1] += 1;
                }
                if ((Mistakes_Status[1] % 3) == 0 && Mistakes_Status[1] > 0)
                {
                    Mistakes_Status[2] += 1;
                }
                if (Mistakes_Status[2] > 0)
                {
                    //關閉所有輔助工具
                }
                break;
            default:
                break;
        }
    }
}
