using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance { get; set; }
    public float Speed = 2;
    public Animator anim;
    private CharacterController Controller;
   public FixedJoystick joy;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        joy = FindObjectOfType<FixedJoystick>();
        Controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if(Instance == null)
        {
            Instance = this;
        }


        Movement();



        //  transform.Translate(ovement);

        //Controller.Move(ovement *  Time.deltaTime*Speed );
       
    }

    public void Movement()
    {
        var H = joy.Horizontal;
        var V = joy.Vertical;
        var ovement = new Vector3(H, 0, V);
        Controller.SimpleMove(ovement * Speed);
        if (ovement.magnitude < 0 || ovement.magnitude > 0)
        {
            // anim.SetFloat("isWalking", ovement.magnitude);
            anim.SetBool("Walking", true);
        }
        if (ovement.magnitude == 0)
        {
            anim.SetBool("Walking", false);
        }
        //  transform.LookAt(transform.position + new Vector3(H, 0, V));
        if (ovement.magnitude > 0)
        {
            Quaternion newDirection = Quaternion.LookRotation(ovement);
            transform.rotation = newDirection;
        }

    }
}
