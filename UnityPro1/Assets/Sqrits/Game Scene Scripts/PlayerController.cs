using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PlayerController : MonoBehaviour
{
     
    public int inputId;
    [SerializeField]float horizontalInput,verticalInput;
    [SerializeField] float horsePower=0; 
    [SerializeField] float turnSpeed;
    [SerializeField] TextMeshProUGUI  speedText;
    [SerializeField] List<WheelCollider> allWheels;
    int speed=0;
    public ParticleSystem []snow;
   
    Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb=GetComponent<Rigidbody>();
        
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(isOnGround())
        {
            horizontalInput=Input.GetAxis("Horizontal"+inputId);
        verticalInput=Input.GetAxis("Vertical"+inputId);
       if(speed<90)
       { playerRb.AddRelativeForce(Vector3.forward*horsePower*verticalInput,ForceMode.Impulse);}
        transform.Rotate(Vector3.up*turnSpeed*Time.fixedDeltaTime*horizontalInput);
        speed= Mathf.RoundToInt(playerRb.velocity.magnitude*3.6f);
        speedText.SetText("Speed: "+speed+ "km/h");
        }
        if(inputId==1 && !Destroy1.isplayer1gameover)
        {
            particleMethod();
        }
        else if(inputId==2 && !Destroy1.isplayer2gameover)
        {
            particleMethod();
        }
        
        

    }
    bool isOnGround(){
      int  countWhile=0;
      foreach(WheelCollider wheel in allWheels)
      {
        if(wheel.isGrounded)
        {
            countWhile++;
        }
      }
        if(countWhile==4)
        {
            return true;
        }
        else
        return false;
    }
    void particleMethod(){
        
        snow[inputId-1].transform.position=gameObject.transform.position+new Vector3(0,10,0);
    }
}
