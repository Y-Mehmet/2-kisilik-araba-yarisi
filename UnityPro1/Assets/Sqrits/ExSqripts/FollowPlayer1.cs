using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer1 : MonoBehaviour
{
    [Header("kameralar")]
    public GameObject[] cams;
    
    // Start is called before the first frame update
    Vector3 offset1,offset0;
    
    
    int sayac1=1;
    void Start()
    {
         
            cams[0].SetActive(false);
            cams[1].SetActive(true);
            
        offset1=transform.position-cams [1].transform.position;
        offset0=transform.position-cams [0].transform.position;
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
            
        if(Input.GetKeyDown(KeyCode.F))
        {
            cams [sayac1%2].SetActive(false);     
            sayac1++;
            cams [sayac1%2].SetActive(true);
            


        }
       
      cams [1].transform.position=transform.position-offset1;
      cams [0].transform.position=transform.position-offset0;
      
        }
       
    }
    

