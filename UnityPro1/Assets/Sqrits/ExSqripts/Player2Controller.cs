using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{   public float speed2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        move();
    }
    void move(){
        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position+=new Vector3(0,0,1)*Time.fixedDeltaTime*speed2;
        }
          if(Input.GetKey(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position-=new Vector3(0,0,1)*Time.fixedDeltaTime*speed2;
        }
          if(Input.GetKey(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.right);
        }
         if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.left);
        }
        
    }
}
