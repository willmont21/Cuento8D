using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public Button[] buttons;
      public Button[] buttonsArea;
    private GameObject clipIz, clipDown, clipDer, clipUp;
   int randomFil;
int posi;



    void Start()
    {
         randomFil=Random.Range(0,3);

           clipIz = GameObject.FindGameObjectWithTag("AudioIz");
            clipDown = GameObject.FindGameObjectWithTag("AudioAbajo");
            clipDer = GameObject.FindGameObjectWithTag("AudioDer");
            clipUp = GameObject.FindGameObjectWithTag("AudioUp");
           
              StartCoroutine(ToEsperar());  
             
            Debug.Log(buttons.Length);
            
            
            
         for (int i = 0; i < buttons.Length; i++)
         {
         
             Button btns = buttons[i].GetComponent<Button>();
               Debug.Log(i);
               Debug.Log(randomFil);
             Button btnArea =  buttonsArea[i].GetComponent<Button>();
         
             if( i== randomFil) {
             btns.onClick.AddListener(TaskOnClick);
              buttonsArea[i].onClick.AddListener(SubirVolumen);
              }
              
            else
              {
                buttonsArea[i].onClick.AddListener(BajarVolumen);
              }
         }
         
              
       
                
       
         
         
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }
    
      IEnumerator ToEsperar() {
        yield return new WaitForSeconds (13);
        if( randomFil== 0) {
              clipUp.GetComponent<AudioSource>().Play();
              clipUp.GetComponent<AudioSource>().volume = 0.7F;
           
              }
          if( randomFil==1) {
              clipDown.GetComponent<AudioSource>().Play();
              clipDown.GetComponent<AudioSource>().volume = 0.7F;
              }
         
            if( randomFil== 2) {
              clipDer.GetComponent<AudioSource>().Play();
              clipDer.GetComponent<AudioSource>().volume = 0.7F;
              }
              
               if( randomFil== 3) {
                clipIz.GetComponent<AudioSource>().Play();
                clipIz.GetComponent<AudioSource>().volume = 0.7F;
              }
         
      
    }
    
    public void SubirVolumen()
     {
         if( randomFil== 0) {
              clipUp.GetComponent<AudioSource>().Play();
              clipUp.GetComponent<AudioSource>().volume = 1.0F;
           
              }
          if( randomFil==1) {
              clipDown.GetComponent<AudioSource>().Play();
              clipDown.GetComponent<AudioSource>().volume = 1.0F;
              }
         
            if( randomFil== 2) {
              clipDer.GetComponent<AudioSource>().Play();
              clipDer.GetComponent<AudioSource>().volume = 1.0F;
              }
              
               if( randomFil== 3) {
                clipIz.GetComponent<AudioSource>().Play();
                clipIz.GetComponent<AudioSource>().volume = 1.0F;
              }
     }
     
      public void BajarVolumen()
     {
        if( randomFil== 0) {
              clipUp.GetComponent<AudioSource>().Play();
              clipUp.GetComponent<AudioSource>().volume = 0.2F;
           
              }
          if( randomFil==1) {
              clipDown.GetComponent<AudioSource>().Play();
              clipDown.GetComponent<AudioSource>().volume = 0.2F;
              }
         
            if( randomFil== 2) {
              clipDer.GetComponent<AudioSource>().Play();
              clipDer.GetComponent<AudioSource>().volume = 0.2F;
              }
              
               if( randomFil== 3) {
                clipIz.GetComponent<AudioSource>().Play();
                clipIz.GetComponent<AudioSource>().volume = 0.2F;
              }
     }
     
    
    public void TaskOnClick()
     {
      clipIz.GetComponent<AudioSource>().Stop();
      clipDown.GetComponent<AudioSource>().Stop();
       clipDer.GetComponent<AudioSource>().Stop();
       clipUp.GetComponent<AudioSource>().Stop();
      
       Debug.Log("you have clicked this button");   
        SceneManager.LoadScene(6);
     }
}
