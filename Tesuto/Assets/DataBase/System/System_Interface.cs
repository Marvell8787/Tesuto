using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

static class System_Interface{
    
    #region Login_Interface (Language)
    #region ui_Main
    public static string Start_Text, Setting_Text, Thank_Text;
    #endregion
    #region ui_Start
    public static string Username_Placeholder, Password_Placeholder, Login_Text, Login_Message;
    #endregion
    #region ui_Setting
    public static string Language_Text, Version_Text;
    #endregion
    #region ui_Thanks
    public static string Resources_Text;
    #endregion
    #endregion
    
    #region Main_Interface (Language)
    public static string Info_Text, Info_Task_Text, Info_Learn_Text, Info_Battle_Text, Info_Guide_Text, Info_Profile_Text, Info_Shop_Text, Info_Deck_Text, Info_Badges_Text, Info_Rank_Text, Info_Task_Goal_Text;
    #endregion
    
    #region Task
    public static string Task_Info_Text,Task_Info_Learn_Text, Task_Info_Battle_Text;
    public static string Task_Button_Take_Text;
    public static string Task_Threshold_Text, Task_Request_Text, Task_Reward_Text, Task_Punishment_Text;
    #endregion

    #region Learn
    public static string Learn_Info_Text;
    public static string Learn_Button_Material_Text, Learn_Button_Level_Text;
    #endregion

    #region Select Learn
    public static string SelectLearn_Info_Text, SelectLearn_Info_Practice_Text, SelectLearn_Info_Challenge_Text;
    public static string SelectLearn_Button_Practice_Text, SelectLearn_Button_Challenge_Text, SelectLearn_Button_Back_Text, SelectLearn_Button_Start_Text;
    public static string SelectLearn_Practice_QuestionType_Text, SelectLearn_Practice_Range_Text, SelectLearn_Practice_Reward_Text, SelectLearn_Practice_Punishment_Text, SelectLearn_Practice_HighestScore_Text;  //Practice
    public static string SelectLearn_Challenge_Threshold_Text, SelectLearn_Challenge_Request_Text, SelectLearn_Challenge_Reward_Text, SelectLearn_Challenge_Punishment_Text;  //Challenge
    #endregion
    
    #region Level
    public static string Level_QuestionType_Text, Level_Level_Text, Level_Answer_Text, Level_Score_Text;
    public static string Level_ListeningDescription_Text, Level_SpellingDescription_Text, Level_ENDContent_Text, Level_Next_Text, Level_Settlement_Text;
    public static string Level_Submit_Text;
    public static string Level_SettlementQuestionNum_Text, Level_SettlementQuestion_Text, Level_SettlementAnswer_Text, Level_SettlementChoose_Text, Level_SettlementFeedback_Text;
    public static string Level_PracticeFlag_Success, Level_PracticeFlag_Failed, Level_ChallengeFlag_Success, Level_ChallengeFlag_Failed;
    #endregion
    
    #region Material
    public static string Material_Button_Back_Text, Material_Info_Text, Material_Info_PageUp_Text, Material_Info_PageDown_Text, Material_Info_PageRight_Text, Material_Info_PageLeft_Text, Material_Info_Voice_Text;
    #endregion

    #region Select Battle
    public static string SelectBattle_Info_Text, SelectBattle_Info_Practice_Text, SelectBattle_Info_Challenge_Text;
    public static string SelectBattle_Button_Practice_Text, SelectBattle_Button_Challenge_Text, SelectBattle_Button_Back_Text, SelectBattle_Button_Start_Text;
    public static string SelectBattle_Practice_QuestionType_Text, SelectBattle_Practice_Range_Text, SelectBattle_Practice_Reward_Text, SelectBattle_Practice_Punishment_Text;  //Practice
    public static string SelectBattle_Practice_Time_Text, SelectBattle_Practice_LP_Text, SelectBattle_Practice_Deck_Text;  //Practice Enemy
    public static string SelectBattle_Challenge_Threshold_Text, SelectBattle_Challenge_Request_Text, SelectBattle_Challenge_Reward_Text, SelectBattle_Challenge_Punishment_Text;  //Challenge
    public static string SelectBattle_Learner_LP_Text, SelectBattle_Learner_Deck_Text;
    #endregion

    #region Battle
    //Init
    public static string Battle_LP_A_Text, Battle_LP_B_Text, Battle_Deck_A_Text, Battle_Deck_B_Text, Battle_CardType_Text, Battle_Effect_Text, Battle_Message_Text;
    //Question
    public static string Battle_Question_Choose,Battle_Question_Right, Battle_Question_Wrong, Battle_Question_Start_Text, Battle_Question_GameOver, Battle_Question_Settlement;
    //Main
    public static string Battle_Main_ChooseCard;
    public static string Battle_Main_Button_Summon_Text, Battle_Main_Button_Fight_Text, Battle_Main_Button_Surrender_Text;
    //Battle
    public static string Battle_Battle_PlayerLPAdd, Battle_Battle_EnemyLPAdd, Battle_Battle_PlayerLPDec, Battle_Battle_EnemyLPDec, Battle_Battle_Tie;
    //End
    public static string Battle_Battle_Next_Text,Battle_Battle_GameOver_Text, Battle_Battle_Settlement_Text;
    public static string Battle_Battle_PlayerWin_Text, Battle_Battle_EnemyWin_Text, Battle_Battle_PlayDeckWin_Text, Battle_Battle_EnemyDeckWin_Text;
    //Settlement
    public static string Battle_SettlementQuestionNum_Text, Battle_SettlementQuestion_Text, Battle_SettlementAnswer_Text, Battle_SettlementChoose_Text, Battle_SettlementFeedback_Text;
    public static string Battle_PracticeFlag_Success, Battle_PracticeFlag_Failed, Battle_ChallengeFlag_Success, Battle_ChallengeFlag_Failed;
    #endregion

    #region Profile
    public static string Profile_Status_Task_Text, Profile_Status_Learn_Text, Profile_Status_Battle_Text;
    public static string Profile_Status_Success_Text, Profile_Status_Fail_Text, Profile_Status_Num_Text;
    public static string Profile_Item_Score_Text, Profile_Item_Coin_Text, Profile_Item_Crystal_Text, Profile_Item_V_Text, Profile_Item_C_Text, Profile_Item_S_Text, Profile_Item_RTask_Text, Profile_Item_RLearn_Text, Profile_Item_RBattle_Text;
    public static string Profile_Item_WTask_Text, Profile_Item_WLearn_Text, Profile_Item_WBattle_Text, Profile_Item_Warning_Text, Profile_Item_YC_Text, Profile_Item_RC_Text;
    public static string Profile_Button_Back_Text;
    #endregion

    #region Shop
    public static string Shop_Button_Buy_Text, Shop_Button_PickUp_Text, Shop_Button_Back_Text;
    public static string Shop_Buy_Success_Text, Shop_PickUp_Success_Text;
    public static string Shop_Info_Text;
    //Item
    public static string Shop_Item0_Info_Text, Shop_Item1_Info_Text, Shop_Item2_Info_Text, Shop_Item3_Info_Text;
    public static string Shop_Item4_Info_Text, Shop_Item5_Info_Text, Shop_Item6_Info_Text, Shop_Item7_Info_Text;
    public static string Shop_Item8_Info_Text, Shop_Item9_Info_Text, Shop_Item10_Info_Text, Shop_Item11_Info_Text;
    #endregion

    #region Deck
    public static string Deck_Button_Vanguard_Text, Deck_Button_Center_Text, Deck_Button_Support_Text, Deck_Button_All_Text, Deck_Button_Back_Text;
    public static string Deck_No_Text, Deck_Type_Text, Deck_Name_Text, Deck_Rarity_Text, Deck_ATK_Text, Deck_Effect_Text;
    public static string Deck_Info_Text;
    #endregion

    #region Badges
    public static string Badges_Info_Text;
    #endregion
    
    #region Rank
    public static string Rank_Info_Text;
    #endregion

    public static void InterfaceChange(string index,string s)
    {
        switch (index)
        {
            
            #region Login
            case "Start_Text":
                Start_Text = s;
                break;
            case "Setting_Text":
                Setting_Text = s;
                break;
            case "Thank_Text":
                Thank_Text = s;
                break;
            case "Username_Placeholder":
                Username_Placeholder = s;
                break;
            case "Password_Placeholder":
                Password_Placeholder = s;
                break;
            case "Login_Text":
                Login_Text = s;
                break;
            case "Login_Message":
                Login_Message = s;
                break;
            case "Language_Text":
                Language_Text = s;
                break;
            case "Version_Text":
                Version_Text = s;
                break;
            case "Resources_Text":
                Resources_Text = s;
                break;
            #endregion
            
            #region Main
            case "Info_Text":
                Info_Text = s;
                break;
            case "Info_Task_Text":
                Info_Task_Text = s;
                break;
            case "Info_Learn_Text":
                Info_Learn_Text = s;
                break;
            case "Info_Battle_Text":
                Info_Battle_Text = s;
                break;
            case "Info_Guide_Text":
                Info_Guide_Text = s;
                break;
            case "Info_Profile_Text":
                Info_Profile_Text = s;
                break;
            case "Info_Shop_Text":
                Info_Shop_Text = s;
                break;
            case "Info_Deck_Text":
                Info_Deck_Text = s;
                break;
            case "Info_Badges_Text":
                Info_Badges_Text = s;
                break;
            case "Info_Rank_Text":
                Info_Rank_Text = s;
                break;
            case "Info_Task_Goal_Text":
                Info_Task_Goal_Text = s;
                break;
            #endregion
            
            #region Task
            case "Task_Info_Text":
                Task_Info_Text = s;
                break;
            case "Task_Info_Learn_Text":
                Task_Info_Learn_Text = s;
                break;
            case "Task_Info_Battle_Text":
                Task_Info_Battle_Text = s;
                break;
            case "Task_Button_Take_Text":
                Task_Button_Take_Text = s;
                break;
            case "Task_Threshold_Text":
                Task_Threshold_Text = s;
                break;
            case "Task_Request_Text":
                Task_Request_Text = s;
                break;
            case "Task_Reward_Text":
                Task_Reward_Text = s;
                break;
            case "Task_Punishment_Text":
                Task_Punishment_Text = s;
                break;
            #endregion
            
            #region Learn
            case "Learn_Info_Text":
                Learn_Info_Text = s;
                break;
            case "Learn_Button_Material_Text":
                Learn_Button_Material_Text = s;
                break;
            case "Learn_Button_Level_Text":
                Learn_Button_Level_Text = s;
                break;
            #endregion
            
            #region SelectLearn
            case "SelectLearn_Info_Text":
                SelectLearn_Info_Text = s;
                break;
            case "SelectLearn_Info_Practice_Text":
                SelectLearn_Info_Practice_Text = s;
                break;
            case "SelectLearn_Info_Challenge_Text":
                SelectLearn_Info_Challenge_Text = s;
                break;
            case "SelectLearn_Button_Practice_Text":
                SelectLearn_Button_Practice_Text = s;
                break;
            case "SelectLearn_Button_Challenge_Text":
                SelectLearn_Button_Challenge_Text = s;
                break;
            case "SelectLearn_Button_Back_Text":
                SelectLearn_Button_Back_Text = s;
                break;
            case "SelectLearn_Practice_QuestionType_Text":
                SelectLearn_Practice_QuestionType_Text = s;
                break;
            case "SelectLearn_Practice_Range_Text":
                SelectLearn_Practice_Range_Text = s;
                break;
            case "SelectLearn_Practice_Reward_Text":
                SelectLearn_Practice_Reward_Text = s;
                break;
            case "SelectLearn_Practice_Punishment_Text":
                SelectLearn_Practice_Punishment_Text = s;
                break;
            case "SelectLearn_Practice_HighestScore_Text":
                SelectLearn_Practice_HighestScore_Text = s;
                break;
            case "SelectLearn_Challenge_Threshold_Text":
                SelectLearn_Challenge_Threshold_Text = s;
                break;
            case "SelectLearn_Challenge_Request_Text":
                SelectLearn_Challenge_Request_Text = s;
                break;
            case "SelectLearn_Challenge_Reward_Text":
                SelectLearn_Challenge_Reward_Text = s;
                break;
            case "SelectLearn_Challenge_Punishment_Text":
                SelectLearn_Challenge_Punishment_Text = s;
                break;
            case "SelectLearn_Button_Start_Text":
                SelectLearn_Button_Start_Text = s;
                break;
            #endregion
            
            #region Level
            case "Level_QuestionType_Text":
                Level_QuestionType_Text = s;
                break;
            case "Level_Level_Text":
                Level_Level_Text = s;
                break;
            case "Level_Answer_Text":
                Level_Answer_Text = s;
                break;
            case "Level_Score_Text":
                Level_Score_Text = s;
                break;
            case "Level_ListeningDescription_Text":
                Level_ListeningDescription_Text = s;
                break;
            case "Level_SpellingDescription_Text":
                Level_SpellingDescription_Text = s;
                break;
            case "Level_ENDContent_Text":
                Level_ENDContent_Text = s;
                break;
            case "Level_Next_Text":
                Level_Next_Text = s;
                break;
            case "Level_Settlement_Text":
                Level_Settlement_Text = s;
                break;
            case "Level_Submit_Text":
                Level_Submit_Text = s;
                break;
            case "Level_SettlementQuestionNum_Text":
                Level_SettlementQuestionNum_Text = s;
                break;
            case "Level_SettlementQuestion_Text":
                Level_SettlementQuestion_Text = s;
                break;
            case "Level_SettlementAnswer_Text":
                Level_SettlementAnswer_Text = s;
                break;
            case "Level_SettlementChoose_Text":
                Level_SettlementChoose_Text = s;
                break;
            case "Level_SettlementFeedback_Text":
                Level_SettlementFeedback_Text = s;
                break;
            case "Level_PracticeFlag_Success":
                Level_PracticeFlag_Success = s;
                break;
            case "Level_PracticeFlag_Failed":
                Level_PracticeFlag_Failed = s;
                break;
            case "Level_ChallengeFlag_Success":
                Level_ChallengeFlag_Success = s;
                break;
            case "Level_ChallengeFlag_Failed":
                Level_ChallengeFlag_Failed = s;
                break;
            #endregion
            
            #region Material
            case "Material_Info_Text":
                Material_Info_Text = s;
                break;
            case "Material_Info_PageUp_Text":
                Material_Info_PageUp_Text = s;
                break;
            case "Material_Info_PageDown_Text":
                Material_Info_PageDown_Text = s;
                break;
            case "Material_Info_PageRight_Text":
                Material_Info_PageRight_Text = s;
                break;
            case "Material_Info_PageLeft_Text":
                Material_Info_PageLeft_Text = s;
                break;
            case "Material_Button_Back_Text":
                Material_Button_Back_Text = s;
                break;
            case "Material_Info_Voice_Text":
                Material_Info_Voice_Text = s;
                break;
            #endregion

            #region SelectBattle
            case "SelectBattle_Info_Text":
                SelectBattle_Info_Text = s;
                break;
            case "SelectBattle_Info_Practice_Text":
                SelectBattle_Info_Practice_Text = s;
                break;
            case "SelectBattle_Info_Challenge_Text":
                SelectBattle_Info_Challenge_Text = s;
                break;
            case "SelectBattle_Button_Practice_Text":
                SelectBattle_Button_Practice_Text = s;
                break;
            case "SelectBattle_Button_Challenge_Text":
                SelectBattle_Button_Challenge_Text = s;
                break;
            case "SelectBattle_Button_Back_Text":
                SelectBattle_Button_Back_Text = s;
                break;
            case "SelectBattle_Practice_QuestionType_Text":
                SelectBattle_Practice_QuestionType_Text = s;
                break;
            case "SelectBattle_Practice_Range_Text":
                SelectBattle_Practice_Range_Text = s;
                break;
            case "SelectBattle_Practice_Reward_Text":
                SelectBattle_Practice_Reward_Text = s;
                break;
            case "SelectBattle_Practice_Punishment_Text":
                SelectBattle_Practice_Punishment_Text = s;
                break;
            case "SelectBattle_Practice_Time_Text":
                SelectBattle_Practice_Time_Text = s;
                break;
            case "SelectBattle_Practice_LP_Text":
                SelectBattle_Practice_LP_Text = s;
                break;
            case "SelectBattle_Practice_Deck_Text":
                SelectBattle_Practice_Deck_Text = s;
                break;
            case "SelectBattle_Challenge_Threshold_Text":
                SelectBattle_Challenge_Threshold_Text = s;
                break;
            case "SelectBattle_Challenge_Request_Text":
                SelectBattle_Challenge_Request_Text = s;
                break;
            case "SelectBattle_Challenge_Reward_Text":
                SelectBattle_Challenge_Reward_Text = s;
                break;
            case "SelectBattle_Challenge_Punishment_Text":
                SelectBattle_Challenge_Punishment_Text = s;
                break;
            case "SelectBattle_Button_Start_Text":
                SelectBattle_Button_Start_Text = s;
                break;
            case "SelectBattle_Learner_LP_Text":
                SelectBattle_Learner_LP_Text = s;
                break;
            case "SelectBattle_Learner_Deck_Text":
                SelectBattle_Learner_Deck_Text = s;
                break;
            #endregion

            #region Battle
                //First
            case "Battle_LP_A_Text":
                Battle_LP_A_Text = s;
                break;
            case "Battle_LP_B_Text":
                Battle_LP_B_Text = s;
                break;
            case "Battle_Deck_A_Text":
                Battle_Deck_A_Text = s;
                break;
            case "Battle_Deck_B_Text":
                Battle_Deck_B_Text = s;
                break;
            case "Battle_CardType_Text":
                Battle_CardType_Text = s;
                break;
            case "Battle_Effect_Text":
                Battle_Effect_Text = s;
                break;
            case "Battle_Message_Text":
                Battle_Message_Text = s;
                break;
            //Question Phase
            case "Battle_Question_Choose":
                Battle_Question_Choose = s;
                break;
            case "Battle_Question_Right":
                Battle_Question_Right = s;
                break;
            case "Battle_Question_Wrong":
                Battle_Question_Wrong = s;
                break;
            case "Battle_Question_Start_Text":
                Battle_Question_Start_Text = s;
                break;
            case "Battle_Question_GameOver":
                Battle_Question_GameOver = s;
                break;
            case "Battle_Question_Settlement":
                Battle_Question_Settlement = s;
                break;
            //Main Phase
            case "Battle_Main_ChooseCard":
                Battle_Main_ChooseCard = s;
                break;
            case "Battle_Main_Button_Summon_Text":
                Battle_Main_Button_Summon_Text = s;
                break;
            case "Battle_Main_Button_Fight_Text":
                Battle_Main_Button_Fight_Text = s;
                break;
            case "Battle_Main_Button_Surrender_Text":
                Battle_Main_Button_Surrender_Text = s;
                break;
            //Battle Phase
            case "Battle_Battle_PlayerLPAdd":
                Battle_Battle_PlayerLPAdd = s;
                break;
            case "Battle_Battle_EnemyLPAdd":
                Battle_Battle_EnemyLPAdd = s;
                break;
            case "Battle_Battle_PlayerLPDec":
                Battle_Battle_PlayerLPDec = s;
                break;
            case "Battle_Battle_EnemyLPDec":
                Battle_Battle_EnemyLPDec = s;
                break;
            case "Battle_Battle_Tie":
                Battle_Battle_Tie = s;
                break;
            //End
            case "Battle_Battle_Next_Text":
                Battle_Battle_Next_Text = s;
                break;
            case "Battle_Battle_GameOver_Text":
                Battle_Battle_GameOver_Text = s;
                break;
            case "Battle_Battle_Settlement_Text":
                Battle_Battle_Settlement_Text = s;
                break;
            case "Battle_Battle_PlayerWin_Text":
                Battle_Battle_PlayerWin_Text = s;
                break;
            case "Battle_Battle_EnemyWin_Text":
                Battle_Battle_EnemyWin_Text = s;
                break;
            case "Battle_Battle_PlayDeckWin_Text":
                Battle_Battle_PlayDeckWin_Text = s;
                break;
            case "Battle_Battle_EnemyDeckWin_Text":
                Battle_Battle_EnemyDeckWin_Text = s;
                break;
            //Settlement
            case "Battle_SettlementQuestionNum_Text":
                Battle_SettlementQuestionNum_Text = s;
                break;
            case "Battle_SettlementQuestion_Text":
                Battle_SettlementQuestion_Text = s;
                break;
            case "Battle_SettlementAnswer_Text":
                Battle_SettlementAnswer_Text = s;
                break;
            case "Battle_SettlementChoose_Text":
                Battle_SettlementChoose_Text = s;
                break;
            case "Battle_SettlementFeedback_Text":
                Battle_SettlementFeedback_Text = s;
                break;
            case "Battle_PracticeFlag_Success":
                Battle_PracticeFlag_Success = s;
                break;
            case "Battle_PracticeFlag_Failed":
                Battle_PracticeFlag_Failed = s;
                break;
            case "Battle_ChallengeFlag_Success":
                Battle_ChallengeFlag_Success = s;
                break;
            case "Battle_ChallengeFlag_Failed":
                Battle_ChallengeFlag_Failed = s;
                break;
            #endregion

            #region Profile
            case "Profile_Status_Task_Text":
                Profile_Status_Task_Text = s;
                break;
            case "Profile_Status_Learn_Text":
                Profile_Status_Learn_Text = s;
                break;
            case "Profile_Status_Battle_Text":
                Profile_Status_Battle_Text = s;
                break;
            case "Profile_Status_Success_Text":
                Profile_Status_Success_Text = s;
                break;
            case "Profile_Status_Fail_Text":
                Profile_Status_Fail_Text = s;
                break;
            case "Profile_Status_Num_Text":
                Profile_Status_Num_Text = s;
                break;
            case "Profile_Item_Score_Text":
                Profile_Item_Score_Text = s;
                break;
            case "Profile_Item_Coin_Text":
                Profile_Item_Coin_Text = s;
                break;
            case "Profile_Item_Crystal_Text":
                Profile_Item_Crystal_Text = s;
                break;
            case "Profile_Item_V_Text":
                Profile_Item_V_Text = s;
                break;
            case "Profile_Item_C_Text":
                Profile_Item_C_Text = s;
                break;
            case "Profile_Item_S_Text":
                Profile_Item_S_Text = s;
                break;
            case "Profile_Item_RTask_Text":
                Profile_Item_RTask_Text = s;
                break;
            case "Profile_Item_RLearn_Text":
                Profile_Item_RLearn_Text = s;
                break;
            case "Profile_Item_RBattle_Text":
                Profile_Item_RBattle_Text = s;
                break;
            case "Profile_Item_WTask_Text":
                Profile_Item_WTask_Text = s;
                break;
            case "Profile_Item_WLearn_Text":
                Profile_Item_WLearn_Text = s;
                break;
            case "Profile_Item_WBattle_Text":
                Profile_Item_WBattle_Text = s;
                break;
            case "Profile_Item_Warning_Text":
                Profile_Item_Warning_Text = s;
                break;
            case "Profile_Item_YC_Text":
                Profile_Item_YC_Text = s;
                break;
            case "Profile_Item_RC_Text":
                Profile_Item_RC_Text = s;
                break;
            case "Profile_Button_Back_Text":
                Profile_Button_Back_Text = s;
                break;
            #endregion

            #region Shop
            case "Shop_Button_Buy_Text":
                Shop_Button_Buy_Text = s;
                break;
            case "Shop_Button_PickUp_Text":
                Shop_Button_PickUp_Text = s;
                break;
            case "Shop_Button_Back_Text":
                Shop_Button_Back_Text = s;
                break;
            case "Shop_Buy_Success_Text":
                Shop_Buy_Success_Text = s;
                break;
            case "Shop_PickUp_Success_Text":
                Shop_PickUp_Success_Text = s;
                break;
            case "Shop_Info_Text":
                Shop_Info_Text = s;
                break;
            case "Shop_Item0_Info_Text":
                Shop_Item0_Info_Text = s;
                break;
            case "Shop_Item1_Info_Text":
                Shop_Item1_Info_Text = s;
                break;
            case "Shop_Item2_Info_Text":
                Shop_Item2_Info_Text = s;
                break;
            case "Shop_Item3_Info_Text":
                Shop_Item3_Info_Text = s;
                break;
            case "Shop_Item4_Info_Text":
                Shop_Item4_Info_Text = s;
                break;
            case "Shop_Item5_Info_Text":
                Shop_Item5_Info_Text = s;
                break;
            case "Shop_Item6_Info_Text":
                Shop_Item6_Info_Text = s;
                break;
            case "Shop_Item7_Info_Text":
                Shop_Item7_Info_Text = s;
                break;
            case "Shop_Item8_Info_Text":
                Shop_Item8_Info_Text = s;
                break;
            case "Shop_Item9_Info_Text":
                Shop_Item9_Info_Text = s;
                break;
            case "Shop_Item10_Info_Text":
                Shop_Item10_Info_Text = s;
                break;
            case "Shop_Item11_Info_Text":
                Shop_Item11_Info_Text = s;
                break;
            #endregion

            #region Deck
            case "Deck_Button_Vanguard_Text":
                Deck_Button_Vanguard_Text = s;
                break;
            case "Deck_Button_Center_Text":
                Deck_Button_Center_Text = s;
                break;
            case "Deck_Button_Support_Text":
                Deck_Button_Support_Text = s;
                break;
            case "Deck_Button_All_Text":
                Deck_Button_All_Text = s;
                break;
            case "Deck_Button_Back_Text":
                Deck_Button_Back_Text = s;
                break;
            case "Deck_No_Text":
                Deck_No_Text = s;
                break;
            case "Deck_Type_Text":
                Deck_Type_Text = s;
                break;
            case "Deck_Name_Text":
                Deck_Name_Text = s;
                break;
            case "Deck_Rarity_Text":
                Deck_Rarity_Text = s;
                break;
            case "Deck_ATK_Text":
                Deck_ATK_Text = s;
                break;
            case "Deck_Effect_Text":
                Deck_Effect_Text = s;
                break;
            case "Deck_Info_Text":
                Deck_Info_Text = s;
                break;
            #endregion

            #region Badges
            case "Badges_Info_Text":
                Badges_Info_Text = s;
                break;
            #endregion

            #region Rank
            case "Rank_Info_Text":
                Rank_Info_Text = s;
                break;
            #endregion

            default:
                break;
        }
    }
}
