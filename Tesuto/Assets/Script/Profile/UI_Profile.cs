using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class UI_Profile : MonoBehaviour {

    #region Variable Events
    EventTriggerType EPClick = EventTriggerType.PointerClick;
    #endregion

    #region Button
    public Button Button_Back;
    #endregion

    // Use this for initialization
    void Start () {
        Button_Back.onClick.AddListener(Back);
	}
	
	void Back () {
        SceneManager.LoadScene("Main");
	}
}
