using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossGUI : MonoBehaviour
{
    public GUISkin gUISkin;
    // Start is called before the first frame update
   void OnGUI() {
        GUI.skin = gUISkin;
        GUI.Label(new Rect(Screen.width / 2 - 30, 25, Screen.width * 0.2f, Screen.height * 0.2f), "보스를 잡아라 boss:"+bossSc.health, "boss"); 
    }
}
