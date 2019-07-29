using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public Button[] buttons;
    public GameObject clipIz, clipDown, clipDer, clipUp;
     int randomFil;
    void Start()
    {
         randomFil=Random.Range(0,11);
        
         Debug.Log(randomFil); 
           clipIz = GameObject.FindGameObjectWithTag("AudioIz");
            clipDown = GameObject.FindGameObjectWithTag("AudioAbajo");
            clipDer = GameObject.FindGameObjectWithTag("AudioDer");
            clipUp = GameObject.FindGameObjectWithTag("AudioUp");
               
             if( randomFil== 0 || randomFil== 7 || randomFil== 5 || randomFil== 10) {
              clipIz.GetComponent<AudioSource>().Play();
              }
          if( randomFil== 8 || randomFil== 11) {
              clipDown.GetComponent<AudioSource>().Play();
              }
         
            if( randomFil== 2 || randomFil== 4  || randomFil== 9) {
              clipDer.GetComponent<AudioSource>().Play();
              }
              
               if( randomFil== 1 || randomFil== 3  || randomFil== 5 || randomFil== 6) {
              clipUp.GetComponent<AudioSource>().Play();
              }
         
         
         for (int i = 0; i < buttons.Length; i++)
         {
           Debug.Log(randomFil); 
             Button btns = buttons[i].GetComponent<Button>();
             if( i== randomFil) {
              
             btns.onClick.AddListener(TaskOnClick);
              }
         }
    }

    // Update is called once per frame
    void Update()
    {
        
          
          
    }
    public void TaskOnClick()
     {
      clipIz.GetComponent<AudioSource>().Stop();
      clipDown.GetComponent<AudioSource>().Stop();
       clipDer.GetComponent<AudioSource>().Stop();
       clipUp.GetComponent<AudioSource>().Stop();
      
       Debug.Log("you have clicked this button");   
        SceneManager.LoadScene("Wolf_Found");
     }
}
