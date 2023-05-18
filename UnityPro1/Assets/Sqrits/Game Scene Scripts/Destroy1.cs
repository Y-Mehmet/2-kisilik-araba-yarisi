using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy1 : MonoBehaviour
{
   public static int gameoverCount=0;
   public static bool isplayer1gameover=false;
   public static bool isplayer2gameover=false;
    
    private void OnCollisionEnter(Collision col){
       if(gameObject.CompareTag("enemy")) 
       {
        if(col.gameObject.tag=="Player2")
         {
          Debug.Log("Game Over!");
          gameoverCount++;
          isplayer2gameover=true;
         }
         else if(col.gameObject.tag=="Player1")
         {
            Debug.Log("Game Over!");
            gameoverCount++;
            isplayer1gameover=true;
         }
         Destroy(col.gameObject);
       }
       



    }
    
}
