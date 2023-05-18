using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class StartManager : MonoBehaviour
{
    public  Slider slider;
   public Button startButton;
   public AudioSource startAS;
    // Start is called before the first frame update
    void Start()
    {
        startAS=gameObject.GetComponent<AudioSource>();
      
    }

    // Update is called once per frame
    void Update()
    {
        startAS.volume=slider.value;
    }
    public void buttonMethod(){
       SceneManager.LoadScene(1,LoadSceneMode.Single);
    }
}
