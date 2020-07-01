using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Androidfire : MonoBehaviour, IPointerDownHandler,IPointerUpHandler
{
    bool ShootMGtf;
    // Start is called before the first frame update
    void Start()
    {
        ShootMGtf = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ShootMGtf)
        { GameObject.FindWithTag("Shootable").GetComponent<Fire>().Shootmg(); }
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        if (GameObject.FindWithTag("Player").GetComponent<PlayerStat>().pistol)
        { GameObject.FindWithTag("Shootable").GetComponent<pistolfire>().Shoot(); }
       else if (GameObject.FindWithTag("Player").GetComponent<PlayerStat>().MG)
        { ShootMGtf = true;
            GameObject.FindWithTag("Shootable").GetComponent<Fire>().ani.enabled = true;
        }
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        ShootMGtf = false;
        if (GameObject.FindWithTag("Player").GetComponent<PlayerStat>().MG)
        {
            GameObject.FindWithTag("Shootable").GetComponent<Fire>().ani.enabled=false;
        }
           
        Debug.LogError("이게 아닌데");
    }
}
