using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//총알을 발사하는 함수
public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * 1f);
        Destroy(this.gameObject,10.0f);

    }

}
