using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameaFollowPlayer : MonoBehaviour
{
    public Transform Player;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
     
    }
    private void LateUpdate()
    {
       
        Vector3 follow = Player.position - transform.position;
         transform.Translate(follow+offset);
    }
}
