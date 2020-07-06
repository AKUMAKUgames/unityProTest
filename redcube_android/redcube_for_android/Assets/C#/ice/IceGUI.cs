using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IceGUI : MonoBehaviour
{
    public GUISkin gUISkin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnGUI()
    {
        GUI.skin = gUISkin;
        GUI.Label(new Rect(Screen.width / 2 - 50, 25, Screen.width * 0.2f, Screen.height * 0.2f), "미끄러지는 얼음 맵", "boss");
    }
}
