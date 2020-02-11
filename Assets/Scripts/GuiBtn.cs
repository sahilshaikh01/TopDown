using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuiBtn : MonoBehaviour
{
    public int Count;
    private void OnGUI()
    {
        if(GUI.Button(new Rect(1500, 800, 200, 100), "Click"))
        {
            Count++;
            Debug.Log(Count);
            if(Count == 1)
            {
                Player.Instance.anim.SetTrigger("Attack1");

            }
            if(Count== 2)
            {
                Player.Instance.anim.SetTrigger("Attack2");
            }
            if(Count == 3)
            {
                Player.Instance.anim.SetTrigger("Attack3");
                Count = 0;
            }
            if (Count == 4)
            {
                Player.Instance.anim.SetTrigger("Kick1");
               
            }
           
        }
    }
    private void Update()
    {
        


    }
}
