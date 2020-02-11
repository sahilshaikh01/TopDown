using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Special1 : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{


    public void OnPointerDown(PointerEventData eventData)
    {
        Player.Instance.anim.SetTrigger("Special1");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
       
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
