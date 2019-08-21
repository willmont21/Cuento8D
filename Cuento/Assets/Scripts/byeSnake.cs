using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class byeSnake : MonoBehaviour
{
 public AudioClip snake;
 private AudioSource sonido;
  private float time=7;
   public Button  byeSnakeController; 
 private int cont=3;
    // Start is called before the first frame update
    void Start()
    {
         sonido=GetComponent<AudioSource>();
         sonido.clip = snake;
          Button btnSnake =  byeSnakeController.GetComponent<Button>();
          btnSnake.onClick.AddListener(byeSerpiente);
    }

    // Update is called once per frame
    void Update()
    {
          time-=Time.deltaTime;
      Debug.Log("hay" +time);
      
        if(time<=0){
         Debug.Log("Soy snake");
           sonido.Play();
           StartCoroutine(ToWait());
           time=4;
       
        }
    }
    
    
     IEnumerator ToWait() {
            cont++;
             yield return new WaitForSeconds (4);
              
           }
           
           
     public void byeSerpiente()
        {
  
           if(cont==7) {
            SceneManager.LoadScene(32);
             }
        }
     }
