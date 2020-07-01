using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class androidReload : MonoBehaviour, IPointerDownHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        if (GameObject.FindWithTag("Player").GetComponent<PlayerStat>().pistol)
        { GameObject.FindWithTag("Shootable").GetComponent<pistolfire>().Reload(); }
        else if (GameObject.FindWithTag("Player").GetComponent<PlayerStat>().MG)
        { GameObject.FindWithTag("Shootable").GetComponent<Fire>().ReloadMG(); }
    }
}
