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
   // private GameObject clipIz, clipDown, clipDer, clipUp;
    int randomFil;
    int posi;
   private AudioSource sonido,instruccion;
   public AudioClip WolfDerecha, WolfDown, WolfIzquierda, WolfUp, EncuentraMamiLoba;


    void Start()
    {
         randomFil=Random.Range(0,3);
         instruccion=GetComponent<AudioSource>();
         sonido=GetComponent<AudioSource>();
         instruccion.clip = EncuentraMamiLoba;
           instruccion.Play();
              StartCoroutine(ToEsperar());  
        
         for (int i = 0; i < buttons.Length; i++)
         {
          Debug.Log("hay estos" + buttons.Length);
             Button btns = buttons[i].GetComponent<Button>();
               Debug.Log("hay" +randomFil);
               
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
           sonido.clip = WolfUp;
           
              }
          if( randomFil==1) {
             sonido.clip = WolfDown;
              }
         
          if( randomFil== 2) {
           sonido.clip = WolfIzquierda;   
              }
              
          if( randomFil== 3) {
             sonido.clip = WolfDerecha;
              }
         
      
    }
    
    public void SubirVolumen()
     {
     sonido.volume = 1.0F;
     sonido.Play();
        /* if( randomFil== 0) {
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
              }*/
     }
     
      public void BajarVolumen()
     {
       /* if( randomFil== 0) {
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
              }*/
               sonido.volume = 0.2F;
               sonido.Play();
     }
     
    
    public void TaskOnClick()
     {
     sonido.Stop();
      /*clipIz.GetComponent<AudioSource>().Stop();
      clipDown.GetComponent<AudioSource>().Stop();
       clipDer.GetComponent<AudioSource>().Stop();
       clipUp.GetComponent<AudioSource>().Stop();*/
      
       Debug.Log("you have clicked this button");   
        SceneManager.LoadScene(6);
     }
}
