using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public GameObject floor;
    Animation anim;
    public const string DEATH = "Anim_Death";
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
       
        if (col.gameObject != floor)
        {
            Destroy(this.gameObject,0.5f);
            DeathAni();
            Destroy(col.gameObject);
        }
    }
    public void DeathAni()
    {
        anim.CrossFade(DEATH);
    }
}
