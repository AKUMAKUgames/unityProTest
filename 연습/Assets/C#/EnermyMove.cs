using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnermyMove : MonoBehaviour
{
    GameObject Player;
    Vector3 dir;
    public GameObject enermy;
    // Start is called before the first frame update
    void Start()
    {
       
        Player = GameObject.Find("Player");
         dir = Player.transform.position - this.transform.position;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
           enermy.gameObject.SetActive(true);
            Debug.Log("활성화");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {

            enermy.gameObject.SetActive(false);
            Debug.Log("비활성화");
        }
        dir = Player.transform.position - this.transform.position;
        transform.position += dir * 0.50f * Time.deltaTime;
        
    }
}
