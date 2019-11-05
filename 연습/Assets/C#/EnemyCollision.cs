using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    
    Animation ani;
    GameObject mon;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animation>();
    }

    // Update is called once per frame
   
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Respawn")//간단하게 게임오브젝트를 판정
        {
            Destroy(this.gameObject, 0.5f);
            ani.Play("Anim_Death");
            Destroy(col.gameObject);
            Debug.Log("맞음");
        }
    }

}
