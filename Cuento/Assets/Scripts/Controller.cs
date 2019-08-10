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
   private AudioSource sonido;
   public AudioClip sonidoDerecha, sonidoDown, sonidoIzquierda, sonidoUp, Encuentra;


    void Start()
    {
         sonido=GetComponent<AudioSource>();
         sonido.clip = Encuentra;
         sonido.Play();  
         randomFil=Random.Range(0,3);
         StartCoroutine(ToEsperar());  
         
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }
    
      IEnumerator ToEsperar() {
  
        yield return new WaitForSeconds (13);
           if( randomFil== 0) {
           sonido.clip = sonidoUp;
            sonido.Play();
           
              }
          if( randomFil==1) {
             sonido.clip = sonidoDown;
              sonido.Play();
              }
         
          if( randomFil== 2) {
           sonido.clip = sonidoIzquierda;
            sonido.Play();
              }
              
          if( randomFil== 3) {
             sonido.clip = sonidoDerecha;
              sonido.Play();
              }
              
              
               
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
    
    public void SubirVolumen()
     {
     sonido.volume = 1.0F;
     sonido.Play();

     }
     
      public void BajarVolumen()
     {
      sonido.volume = 0.2F;
      sonido.Play();
     }
     
    
    public void TaskOnClick()
     {
     sonido.Stop();
       Debug.Log("you have clicked this button");   
        SceneManager.LoadScene(6);
     }
}
