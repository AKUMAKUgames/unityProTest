using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnermyMove : MonoBehaviour
{
    GameObject Player;
    Vector3 dir;
   
    // Start is called before the first frame update
    void Start()
    {
       
        Player = GameObject.Find("Player");
         dir = Player.transform.position - this.transform.position;
       
    }

    // Update is called once per frame
    void Update()
    {
       
        dir = Player.transform.position - this.transform.position;
        transform.position += dir * 0.50f * Time.deltaTime;
        
    }
}
