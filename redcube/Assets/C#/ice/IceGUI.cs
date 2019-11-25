using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceGUI : MonoBehaviour
{
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
        GUI.Label(new Rect(Screen.width / 2 - 30, 25, Screen.width * 0.2f, Screen.height * 0.2f), "모든적 섬멸" );
    }
}
