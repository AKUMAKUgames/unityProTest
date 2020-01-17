using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int win = 0;
    public static int lose = 0;
    // Start is called before the first frame update
    void Start()
    {
        win = 0;
        lose = 0;
    }

    // Update is called once per frame
    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 120, 120), "win : " + win);
        GUI.Label(new Rect(10, 30, 120, 120), "lose : " + lose);
       
    }
}
