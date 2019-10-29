using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public GameObject floor;
    Animation ani;
    
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animation>();
    }

    // Update is called once per frame
   
    void OnCollisionEnter(Collision col)
    {
       
        if (col.gameObject != floor)
        {
            Destroy(this.gameObject,0.5f);
            ani.Play("Anim_Death");
            Destroy(col.gameObject);
        }
    }

}
