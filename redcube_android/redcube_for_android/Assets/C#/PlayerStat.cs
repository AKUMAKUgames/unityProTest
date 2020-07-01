using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    public GameObject gun;
    public GameObject machineGun;
    public int damage;
    public bool pistol;//안드로이드 버전에서 수정됨
    public bool MG;//안드로이드 버전에서 수정됨

    // Start is called before the first frame update
    void Start()
    {
        gun.SetActive(false);
        machineGun.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    
    }
    public void setPistol()
    {
        damage = 15;
        gun.SetActive(true);
        machineGun.SetActive(false);
        MG = false; pistol = true;
    }
    public void setMG()
    {
        damage = 5;
        gun.SetActive(false);
        machineGun.SetActive(true);
        MG = true; pistol = false;
    }
}
