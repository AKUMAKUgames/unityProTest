using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraMoving : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        this.transform.position = new Vector3(player.transform.position.x,50, player.transform.position.z);
       
    }
}
