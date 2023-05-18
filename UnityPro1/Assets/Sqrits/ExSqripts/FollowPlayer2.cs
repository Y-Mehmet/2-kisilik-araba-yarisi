using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer2 : MonoBehaviour
{   Vector3 offset2_1,offset2_0;
int sayac2=1;
    public GameObject[] cams2;
    // Start is called before the first frame update
    void Start()
    {
        cams2[0].SetActive(false);
        cams2[1].SetActive(true);
        offset2_1=transform.position-cams2 [1].transform.position;
        offset2_0=transform.position-cams2 [0].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.L))
        {
            cams2 [sayac2%2].SetActive(false);     
            sayac2++;
            cams2 [sayac2%2].SetActive(true);
            


        }
         cams2 [1].transform.position=transform.position-offset2_1;
      cams2 [0].transform.position=transform.position-offset2_0;
    }
}
