using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
public class bossSc : MonoBehaviour
{
    private Animator ani;
    public GameObject player;
    public GameObject boss;
    public GameObject enermy;
    GameObject bossNav;
    public NavMeshAgent nav;

   public static float health = 600.0f;
    float timer;
    int waitingTime;
    float pattern = 0.0f;
    float distance = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
        waitingTime = 7;
        health = 600.0f;
        nav = GetComponent<NavMeshAgent>();
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        

        distance = Vector3.Distance(player.transform.position, boss.transform.position);
        
        if (distance < 10.0f)
        {
            pattern=Random.Range(0.0f, 4.0f);
            
            if (pattern >= 2.0f)
            {
                ani.SetBool("isAttack1", true);
                nav.isStopped = true;
                StartCoroutine(test());
                IEnumerator test()
                {
                    yield return new WaitForSeconds(1.6f);
                    ani.SetBool("isAttack1", false);
                    nav.isStopped = false;
                    
                }
                
            }
            else
            {
                ani.SetBool("isAttack2", true);
                nav.isStopped = true;
                StartCoroutine(test());
                IEnumerator test()
                {
                    yield return new WaitForSeconds(1.0f);
                    ani.SetBool("isAttack2", false);
                    nav.isStopped = false;
                   
                }
                
            }
        }
        else
        {
            timer += Time.deltaTime;
            Debug.Log("소환!");
            if (timer > waitingTime)
            {

                nav.isStopped = true;
                Debug.Log(nav.isStopped);
                ani.SetBool("isSummon", true);

                StartCoroutine(test());
                IEnumerator test()
                {
                    yield return new WaitForSeconds(2.5f);
                    nav.isStopped = false;
                    Instantiate(enermy, transform.position, transform.rotation);
                    Debug.Log(nav.isStopped);

                }
                timer = 0;
            }
            else
            {
                ani.SetBool("isSummon", false);
            }
        }
        
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
            }
        }
        if (col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);
            SceneManager.LoadScene(7);
        }
        
    }
}
