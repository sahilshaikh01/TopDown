using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SwordAttack : MonoBehaviour,IPointerUpHandler,IPointerDownHandler
{ 
    public static SwordAttack Instance { get; set; }
    int count;
    public bool SpeedControll;
   
   public int i;
    public void OnPointerDown(PointerEventData eventData)
    {
        SpeedControll = true;
        count++;

        Debug.Log(count);

        if (count == 1)
        {
            Player.Instance.anim.SetTrigger("Attack1");
           

        }
      
        if (count == 2)
        {
            Player.Instance.anim.SetTrigger("Attack2");
          
        }
       
        if (count == 3)
        {
          
            Player.Instance.anim.SetTrigger("Attack3");
            count = 0;
        }
       


    }

    public void OnPointerUp(PointerEventData eventData)
    {
        SpeedControll = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        if (SpeedControll == true)
        {
            Player.Instance.Speed = 0.5f;
        }
        if (SpeedControll == false)
        {
            Player.Instance.Speed = 10f;
        }
    }
  


   
}
