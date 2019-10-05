using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Vocabulary_Data{
    private static string[] Vocabulary_E_Name = new string[20]; 
    private static string[] Vocabulary_C_Name = new string[20];
    private static string[] Vocabulary_Voice = new string[20];
    private static string[] Vocabulary_PartOfSpeech = new string[20];
    private static string[] Vocabulary_Sentence = new string[20];
    
    public static Vocabulary_Class[] vocabulary_temp = new Vocabulary_Class[20];

    public static void Vocabulary_Init()
    {
        Vocabulary_bankGet();
        for (int i = 0; i < 20; i++)
        {
            vocabulary_temp[i] = new Vocabulary_Class(Vocabulary_E_Name[i], Vocabulary_C_Name[i], Vocabulary_Voice[i], Vocabulary_PartOfSpeech[i], Vocabulary_Sentence[i]);
        }
    }
    public static Vocabulary_Class Vocabulary_Get(int n)
    {
        return vocabulary_temp[n];
    }
    public static void Vocabulary_bankGet()
    {
        for (int i = 0; i < 20; i++)
        {
            Vocabulary_E_Name[i] = Vocabulary_Bank.Vocabulary_E_Name[i]; 
            Vocabulary_C_Name[i] = Vocabulary_Bank.Vocabulary_C_Name[i];
            Vocabulary_Voice[i] = Vocabulary_Bank.Vocabulary_Voice[i];
            Vocabulary_PartOfSpeech[i] = Vocabulary_Bank.Vocabulary_PartOfSpeech[i];
            Vocabulary_Sentence[i] = Vocabulary_Bank.Vocabulary_Sentence[i];
        }
    }

}
