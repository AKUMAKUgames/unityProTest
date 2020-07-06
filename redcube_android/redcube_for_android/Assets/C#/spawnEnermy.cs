using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawnEnermy : MonoBehaviour
{
    public GUISkin newskin;
    public GameObject enermy;
    public float intervar = 1.0f;
     float limit = 0.0f;
    // Start is called before the first frame update
    IEnumerator Start()
    {   //16초동안 반복
        while (limit < 181.0f)
        {
            limit += 1.0f;
            //10초가 지난후 몹생성 중지
            if (limit < 10.0f)
            {
                Instantiate(enermy, transform.position, transform.rotation);
            }
            Debug.Log(limit);
            //180초가 지난후 맵안쪽에 몹을 판정
            if (limit >= 180.0f)
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
       
       
    }
    void Update()
        {
        
    }
    void OnGUI()
    {
        GUI.skin = newskin;
        GUI.Label(new Rect(Screen.width/2 - 40,90, Screen.width * 0.2f, Screen.height * 0.2f),"시간내 모든적 처치"+"/"+(181-(int)limit).ToString(),"timer");
    }
}
