using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class GameManager : MonoBehaviour
{
       GameObject destroyScript;
       AudioSource audioSource;
       
        
        [SerializeField] GameObject plane1; 
        [SerializeField] GameObject plane2; 

        [SerializeField] TextMeshProUGUI [] gameOverText;
        
    
        // Start is called before the first frame update
    void Start()
    {
      audioSource=GetComponent<AudioSource>();
        destroyScript=GameObject.Find("DestroyColider");
    panleCloseMethod();
        }

    // Update is called once per frame
    void Update()
    {
        if(Destroy1.gameoverCount==0){
            panleCloseMethod();
        }
     
        if(Destroy1.gameoverCount==2)
        {   
            Destroy1.gameoverCount=0;
            Destroy1.isplayer1gameover=false;
            Destroy1.isplayer2gameover=false;
        
            SceneManager.LoadScene(0,LoadSceneMode.Single);
        }
        
        if(Destroy1.isplayer1gameover)
        {
           plane1.gameObject.SetActive(true);
        }
          if(Destroy1.isplayer2gameover)
        {
             plane2.gameObject.SetActive(true);

        }
         if(Input.GetKey(KeyCode.Q))
         {
            print("Application quit");
            Application.Quit();

         }
    }
    public  void panleCloseMethod(){
  
       plane1.gameObject.SetActive(false);
       plane2.gameObject.SetActive(false);
       
      
       
    }
}
