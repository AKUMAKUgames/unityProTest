using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawnEnermy : MonoBehaviour
{
    public GameObject enermy;
    public float intervar = 1.0f;
    public float limit = 0.0f;
    // Start is called before the first frame update
    IEnumerator Start()
    {   //16초동안 반복
        while (limit < 16.0f)
        {
            limit = limit + 1.0f;
            //10초가 지난후 몹생성 중지
            if (limit < 5.0f)
            {
                Instantiate(enermy, transform.position, transform.rotation);
            }
            Debug.Log(limit);
            //15초가 지난후 맵안쪽에 몹을 판정
            if (limit >= 15.0f)
            {   //남아있으면 게임오버
                if (null != GameObject.FindWithTag("monster"))
                {
                    SceneManager.LoadScene("GameOver");
                }
                else
                {
                    Debug.Log("성공");
                }
            }
            yield return new WaitForSeconds(intervar);
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}
