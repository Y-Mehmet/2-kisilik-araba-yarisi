using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusInstantiate : MonoBehaviour
{
    int x,y=0,z=235;
    int index;
    public GameObject[] busPrefabs;
    float startDelay=2,repeatTime=5;
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("BusInstantiate1",startDelay,repeatTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void BusInstantiate1(){
        index=Random.Range(0,4);
        x=Random.Range(-122,-111);
        Instantiate(busPrefabs[index],new Vector3(x,y,z),gameObject.transform.rotation);
    }
}
