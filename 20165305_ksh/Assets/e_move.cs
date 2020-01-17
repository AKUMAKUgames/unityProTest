using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class e_move : MonoBehaviour
{
    public float rot_angle = 15.0f;
    public UnityEngine.AI.NavMeshAgent agent;
    public GameObject target;
    public AudioSource As;
    public AudioClip ac;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveToTarget();
        agent.speed += 0.01f * Time.deltaTime;
        
    }
    void MoveToTarget()
    {
        agent.SetDestination(target.transform.position);
    }
    void OnGUI()
    {
        GUI.Label(new Rect(10, 50, 120, 120), "Enemy speed : " + agent.speed);
    }
}
