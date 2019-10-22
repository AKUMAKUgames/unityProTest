using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float speed = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime * speed) ;
        this.transform.Translate(Vector3.right* Input.GetAxis("Horizontal") * Time.deltaTime * speed);
    }
}
  
