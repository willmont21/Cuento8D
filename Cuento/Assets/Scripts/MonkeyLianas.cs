using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MonkeyLianas : MonoBehaviour
{
  public Button  monkeyController; 
  private int cont=0;
  private AudioSource sonido;
  public AudioClip liana;
   public AudioSource ticky;
    // Start is called before the first frame update
    void Start()
    {
          Button btn =  monkeyController.GetComponent<Button>();
           btn.onClick.AddListener(caerMono);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void caerMono()
     {
     ticky.Play();
     cont++;
     if(cont==7) {
     sonido=GetComponent<AudioSource>();
     sonido.clip = liana;
     StartCoroutine(ToWait());
       }
      }
      
        IEnumerator ToWait() {
            sonido.volume = 1.0F;
             sonido.Play();
             yield return new WaitForSeconds (4);
               SceneManager.LoadScene(26);
    
        }
           
      
   
}
