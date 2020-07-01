using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class mogie2 : MonoBehaviour, IPointerDownHandler
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
        GameObject.FindWithTag("Player").GetComponent<PlayerStat>().setMG();
    }
}
