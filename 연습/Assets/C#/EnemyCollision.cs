using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyCollision : MonoBehaviour
{
    
    Animation ani;
   float health = 30.0f;
    public GameObject hpBar;
    const float health_fixed = 30.0f;
    float full;
    public ParticleSystem par;
   

    
    
    // Start is called before the first frame update
    void Start()
    {
      
        ani = GetComponent<Animation>();
        full = hpBar.transform.localScale.x;
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
          
            hpBar.transform.localScale = new Vector3(health/health_fixed * full, 0.1f, 0.5f);
            
            if (health <= 0)
            {
                hpBar.SetActive(false);
                Destroy(this.gameObject, 0.5f);
                
                ani.Play("Anim_Death");
            }
            par.Play();

        }
        if (col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);
            SceneManager.LoadScene(4);
        }

    }

}
