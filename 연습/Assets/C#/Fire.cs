using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Bullet;
    public Transform FirePos;
    Animator ani;
     bool shootlife = true; // 총알을 쓸 수 있는 상태다


    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        ani = this.GetComponent<Animator>();

        if (shootlife && Input.GetMouseButton(0))
        {
            ani.enabled = true;
            Instantiate(Bullet, FirePos.transform.position, FirePos.transform.rotation);

            ani.Play("MachineGin_shoot");

            // 잠깐 쉰다
            shootlife = false;
            Invoke("Sleep", 0.05f);

        }
        else
        { ani.enabled = false; }

    }
    void Sleep()
    {
        shootlife = true;
    }
}
