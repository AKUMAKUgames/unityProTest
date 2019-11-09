using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pistolfire : MonoBehaviour
{
    public GameObject Bullet;
    public Transform FirePos;
    public ParticleSystem muzzle;
    public AudioClip shot;
    public AudioClip rel;

    AudioSource  pistol_Sound;
    bool shootlife = true; // 총알을 쓸 수 있는 상태다
    int bulletNumber = 6; // 1탄창에 들어있는 총알 수 (나중에 바꾸든가)
    int bulletToT = 36; // 남은 탄약
    bool loadTIme = true;
    void Start()
    {
        pistol_Sound = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       
        int reloadBullet = 6 - bulletNumber;//재장전하면 채워질 탄약 수 



        if (Input.GetKeyDown(KeyCode.R))// R로 재장전
        {
            pistol_Sound.clip = rel;
            if (bulletNumber < 6 && bulletToT > 0) // 탄창이 풀이 아니고 잔탄있을 경우
            {
                pistol_Sound.Play();
                loadTIme = false;

                if (bulletToT - reloadBullet >= 0) // 잔탄이 여유로울떄 
                {
                    
                    /* 입력을 2초간 받지 못하게 해야함 장전 모션 씹힘*/
                    Invoke("SleepLoad", 0.5f);
                    
                    bulletToT = bulletToT - reloadBullet;//재장전한 만큼 잔탄 감소
                    bulletNumber = bulletNumber + reloadBullet;// 탄창 채워짐
                    Debug.Log("장전완료:" + bulletNumber + " / " + bulletToT); 

                }
                else // 잔탄이 부족할때 
                {


                    /* 입력을 2초간 받지 못하게 해야함 장전 모션 씹힘 */
                    Invoke("SleepLoad", 0.5f);
                    bulletNumber += bulletToT;
                    bulletToT = 0;
                    Debug.Log("장전완료 풀충 ㄴㄴ:" + bulletNumber + " / " + bulletToT);

                }

            }
            else { Debug.Log("총알 없어"); } //탄창이 풀이거나 잔탄이 없을 경우 
        }

        if (shootlife && Input.GetMouseButtonDown(0) && bulletNumber > 0 && loadTIme)
        {
            pistol_Sound.clip = shot;
          
            GameObject go = Instantiate(Bullet, FirePos.transform.position, FirePos.transform.rotation) as GameObject;
            pistol_Sound.Play();
            bulletNumber = bulletNumber - 1;
            muzzle.Play();
            Debug.Log("히힛 총알 발싸:" + bulletNumber + " / " + bulletToT);
          

            // 잠깐 쉰다
            shootlife = false;
            Invoke("Sleep", 0.05f);

        }
     

    }
    void Sleep()
    {
        shootlife = true;
    }
    void SleepLoad()
    {
        loadTIme = true;
    }
}
