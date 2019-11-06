using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    public GameObject gun;
    public GameObject machineGun;
    public int damage = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            damage = 10;
            gun.SetActive(true);
            machineGun.SetActive(false);
            
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            damage = 5;
            gun.SetActive(false);
            machineGun.SetActive(true);
        }
    }
}
