using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnermyMove : MonoBehaviour
{
    public float rot_angle = 15.0f;
    public UnityEngine.AI.NavMeshAgent nav;
    public GameObject target;
   
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {

        MoveToTarget();
        
    }
    void MoveToTarget()
    {
        nav.SetDestination(target.transform.position);
    }
}
