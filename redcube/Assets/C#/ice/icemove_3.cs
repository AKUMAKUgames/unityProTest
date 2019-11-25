using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icemove_3 : MonoBehaviour
{
    Vector3 velocity;
    Rigidbody rigd;
    // Start is called before the first frame update
    void Start()
    {
        rigd = GetComponent<Rigidbody>();
    }
    public void Move(Vector3 velocity)
    {
       this.velocity = velocity;
    }

    // Update is called once per frame
    void Update()
    {
        rigd.AddForce(this.velocity * Time.deltaTime);
    }
    public void rolling(Vector3 point)
    {
        Vector3 hold = new Vector3(point.x, this.transform.position.y, point.z);
        transform.LookAt(hold);
    }
}
