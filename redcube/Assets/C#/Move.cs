using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody myRigidbody;

    public float rotationSpeed = 180f;
    
    public float speed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float inputRot = Input.GetAxis("Horizontal");
        float inputSPD = Input.GetAxis("Vertical");

        this.transform.Rotate(0, rotationSpeed * inputRot * Time.deltaTime, 0);
        Vector3 moveDistance = transform.forward * speed * inputSPD * Time.deltaTime;

        myRigidbody.MovePosition(myRigidbody.position + moveDistance);
       /* this.transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime * speed) ;
        this.transform.Translate(Vector3.right* Input.GetAxis("Horizontal") * Time.deltaTime * speed);*/
 
    }

}
  
