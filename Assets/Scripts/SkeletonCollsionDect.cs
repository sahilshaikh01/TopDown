using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonCollsionDect : MonoBehaviour
{
    public int Health = 25;
  public   Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerSword")
        {
            Health -= 1;
            anim.SetTrigger("Hit");
        }
    }
    private void Update()
    {
        if(Health == 0)
        {
            Destroy(gameObject);
        }
    }
}
