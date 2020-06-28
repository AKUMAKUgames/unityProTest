using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class screen : MonoBehaviour
{
    public AspectRatioFitter fit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float ratio = (float)Screen.width / (float)Screen.height;
        fit.aspectRatio = ratio;
    }
}
