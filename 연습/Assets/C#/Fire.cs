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
    int bulletNumber = 30; // 1탄창에 들어있는 총알 수 (나중에 바꾸든가)
    int bulletToT = 120; // 남은 탄약


    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        ani = this.GetComponent<Animator>();
        int reloadBullet = 30 - bulletNumber;//재장전하면 채워질 탄약 수 
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (bulletNumber < 30 && bulletToT > 0) // 탄창이 풀이 아니고 잔탄있을 경우
            {
                if (bulletToT - reloadBullet >= 0) // 잔탄이 여유로울떄 
                {
                    bulletToT = bulletToT - reloadBullet;//재장전한 만큼 잔탄 감소
                    bulletNumber = bulletNumber + reloadBullet;// 탄창 채워짐 
                    Debug.Log("장전완료:" +bulletNumber+ " / "+ bulletToT);
                }
                else // 잔탄이 부족할때 
                {
                    bulletNumber += bulletToT;
                    bulletToT = 0;
                    Debug.Log("장전완료 풀충 ㄴㄴ:" +bulletNumber+ " / "+ bulletToT);
                }
            }
            else { Debug.Log("총알 없어"); } //탄창이 풀이거나 잔탄이 없을 경우 
        }
        if (shootlife && Input.GetMouseButton(0) && bulletNumber>0) 
        {
           
            ani.enabled = true;
            Instantiate(Bullet, FirePos.transform.position, FirePos.transform.rotation);
            bulletNumber = bulletNumber-1;
            Debug.Log("히힛 총알 발싸:"+bulletNumber+ " / "+ bulletToT );
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
