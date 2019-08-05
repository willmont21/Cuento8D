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
string nameArea;



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
             if( i== randomFil) {
               
             btns.onClick.AddListener(TaskOnClick);
             
             Button btnArea =  buttonsArea[i].GetComponent<Button>();
             buttonsArea[i].onClick.AddListener(AjustarVolumen);
              
               switch (i)
                 {
                    case 0:
                    nameArea="Arriba";
                      break;
                    case 1:
                      nameArea="Abajo";
                      break;                
                    case 2:
                      break;
                        nameArea="Izquierda";
                     default:
                        nameArea="Derecha";
                     break;
                      }
      
      
      
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
              clipUp.GetComponent<AudioSource>().volume = 0.8F;
           
              }
          if( randomFil==1) {
              clipDown.GetComponent<AudioSource>().Play();
              clipDown.GetComponent<AudioSource>().volume = 0.8F;
              }
         
            if( randomFil== 2) {
              clipDer.GetComponent<AudioSource>().Play();
              clipDer.GetComponent<AudioSource>().volume = 0.8F;
              }
              
               if( randomFil== 3) {
                clipIz.GetComponent<AudioSource>().Play();
                clipIz.GetComponent<AudioSource>().volume = 0.8F;
              }
         
      
    }
    
    public void AjustarVolumen()
     {
     float ajuste= 1.0F;
          if( randomFil== 0) {
              clipUp.GetComponent<AudioSource>().volume = ajuste;
           
              }
            if( randomFil==1) {
              clipDown.GetComponent<AudioSource>().volume = ajuste;
              }
         
            if( randomFil== 2) {
              clipDer.GetComponent<AudioSource>().volume = ajuste;
              }
              
               if( randomFil== 3) {
                clipIz.GetComponent<AudioSource>().volume = ajuste;
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
