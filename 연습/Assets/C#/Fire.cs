using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Bullet;
    public Transform FirePos;
    public Animation ani;


     bool shootlife = true; // 총알을 쓸 수 있는 상태다


    void Start()
    {
        ani = GetComponent<Animation>();  
    }

    // Update is called once per frame
    void Update()
    {
     
         if (shootlife &&Input.GetMouseButton(0))
        {
            
                ani.CrossFade("MachineGin_shoot",-1,0);
                

                Instantiate(Bullet, FirePos.transform.position, FirePos.transform.rotation);
               
                
               


                // 잠깐 쉰다
                shootlife = false;
                Invoke("Sleep", 0.05f);
            
                
         }
        if (Input.GetMouseButtonUp(0))
        {
            ani.CrossFade("defualt", -1, 0);
        }

    }
    void Sleep()
    {
       
      
        shootlife = true;
    }
}
