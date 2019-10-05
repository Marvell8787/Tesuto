using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
public class UI_Material : MonoBehaviour {

    #region Variable Events
    EventTriggerType EPEnter = EventTriggerType.PointerEnter;
    EventTriggerType EPExit = EventTriggerType.PointerExit;
    EventTriggerType EPClick = EventTriggerType.PointerClick;
    #endregion

    #region Material
    public GameObject Voice;
    public Button[] Btn = new Button[10];
    public Text[] Btn_text = new Text[10];
    public Text Text_Num, Text_E_Name, Text_C_Name, Text_PartOfSpeech, Text_Sentenc, Text_Info;
    public GameObject[] Direction = new GameObject[4]; //up down left right
    #endregion

    // Use this for initialization
    void Start () {
		
	}
	
}
