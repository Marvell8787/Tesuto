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
    public static string Username_Placeholder, Password_Placeholder, NickName_Placeholder, Login_Text, Login_Message;
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

    #region Leaarn
    public static string Learn_Info_Text;
    public static string Lean_Button_Material_Text, Lean_Button_Level_Text;
    #endregion

    #region Select Learn
    public static string SelectLearn_Info_Text, SelectLearn_Info_Practice_Text, SelectLearn_Info_Challenge_Text;
    public static string SelectLean_Button_Practice_Text, SelectLean_Button_Challenge_Text, SelectLean_Button_Back_Text, SelectLearn_Button_Start_Text;
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
            case "NickName_Placeholder":
                NickName_Placeholder = s;
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
            case "Lean_Button_Material_Text":
                Lean_Button_Material_Text = s;
                break;
            case "Lean_Button_Level_Text":
                Lean_Button_Level_Text = s;
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
            case "SelectLean_Button_Practice_Text":
                SelectLean_Button_Practice_Text = s;
                break;
            case "SelectLean_Button_Challenge_Text":
                SelectLean_Button_Challenge_Text = s;
                break;
            case "SelectLean_Button_Back_Text":
                SelectLean_Button_Back_Text = s;
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
