using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

static class Material_PointerExit{

    public static void Exit(BaseEventData data)
    {
        Text t_temp;
        t_temp = GameObject.Find("Text_Info").GetComponent<Text>();
        t_temp.text = "這邊是資訊欄\n移至圖像可得知相關資訊";
    }

}
