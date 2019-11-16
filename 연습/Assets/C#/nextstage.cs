using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class nextstage : MonoBehaviour
{
    float timer;
    int waitingTime;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
        waitingTime = 2;
    }

    // Update is called once per frame
    void Update()
    {

 //       timer += Time.deltaTime;

//        if (timer > waitingTime)
//        {
            if (null == GameObject.FindWithTag("monster"))
            {
                SceneManager.LoadScene(1);
            }

   //         timer = 0;
    //    }
       
    
    }
}
