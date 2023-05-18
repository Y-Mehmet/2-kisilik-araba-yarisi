using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    float x, z;
    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        move();
    }
    
    void move(){
     if(Input.GetKey(KeyCode.W) ||  Input.GetKeyDown(KeyCode.W))
     {
        transform.position+=new Vector3(0,0,1)*speed*Time.fixedDeltaTime;
     }
     if(Input.GetKey(KeyCode.S) || Input.GetKeyDown(KeyCode.S))
     {
        transform.position-=new Vector3(0,0,1)*speed*Time.fixedDeltaTime;
     }
     if(Input.GetKey(KeyCode.D) || Input.GetKeyDown(KeyCode.D))
     {
        transform.Rotate(Vector3.up);
        transform.position+=new Vector3(1,0,0)*speed*Time.fixedDeltaTime;
     }
     if(Input.GetKey(KeyCode.A)|| Input.GetKeyDown(KeyCode.A))
     {
        transform.Rotate(Vector3.down);
        transform.position-=new Vector3(1,0,0)*speed*Time.fixedDeltaTime;
     }
    }
    
}
