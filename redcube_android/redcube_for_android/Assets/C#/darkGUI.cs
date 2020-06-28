using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class darkGUI : MonoBehaviour
{
    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2 - 30, 25, Screen.width * 0.2f, Screen.height * 0.2f), "주어진 빛을 이용하여 모든적 섬멸");
    }
}
