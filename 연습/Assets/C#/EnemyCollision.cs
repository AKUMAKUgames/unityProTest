using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    
    Animation ani;
    int health = 30;
    
    // Start is called before the first frame update
    void Start()
    {
      
        ani = GetComponent<Animation>();
    }
 
    // Update is called once per frame
   void Update()
    {
       
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Respawn")//간단하게 게임오브젝트를 판정
        {
            //player 태그로 가서 데미지 받아옴
            int bulletPower = GameObject.FindWithTag("Player").GetComponent<PlayerStat>().damage;

            Destroy(col.gameObject);
            health -= bulletPower;
            
            if (health <= 0)
            {
                Destroy(this.gameObject, 0.5f);
                ani.Play("Anim_Death");
            }

            


        }
        
    }

}
