﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public Camera[] cam;
    public ParticleSystem snow;
    
    Vector3 offset1,offset2, snowoffset;
    // Start is called before the first frame update
    void Start()
    { 
        cam[0].enabled= false;
        cam[1].enabled= true;
        offset1= transform.position -cam[0].transform.position;
        offset2= transform.position-cam[1].transform.position;
        snowoffset=new Vector3(0,5,10);
    }

    // Update is called once per frame
    void LateUpdate()
    {   
        if(Input.GetKeyDown(KeyCode.L))
        {
            cam[0].enabled= !cam[0].enabled;
            cam[1].enabled= !cam[1].enabled;
        }
        cam [1].transform.position=transform.position-offset2;
      cam [0].transform.position=transform.position-offset1;
      snow.transform.position=cam[1].transform.position+ snowoffset;
     

    }
}
