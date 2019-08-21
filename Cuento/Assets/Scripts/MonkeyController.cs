using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MonkeyController : MonoBehaviour
{
      // Start is called before the first frame update
    public Button monkey, snake, duck, wolf;
    public int scene;
    private AudioSource sonido;
    private  Button b1, b2, b3, b4;
    public AudioClip sonidoDuck, sonidoWolf, sonidoSnake, sonidoMonkey;
  
    void Start()
    {
              sonido = GetComponent<AudioSource>();
              
              StartCoroutine(ToWaitx2());    
              b1 = monkey.GetComponent<Button>();
              b1.onClick.AddListener(Encontro);
              b2 = snake.GetComponent<Button>();
              b2.onClick.AddListener(snakeSound);
              b3 = duck.GetComponent<Button>();
              b3.onClick.AddListener(duckSound);
              b4 = wolf.GetComponent<Button>();
              b4.onClick.AddListener(WolfSound);
              
              sonido.Play();
         
    }

    // Update is called once per frame
    void Update()
    { 
      
    }
    
      IEnumerator ToWait() {
      sonido.Play();
             yield return new WaitForSeconds (4);
             SceneManager.LoadScene(scene);
        }
        
        IEnumerator ToWaitx2() {
             yield return new WaitForSeconds (10);
      
        }
        
    public void Encontro()
     {
        sonido.clip = sonidoMonkey;
             // sonido.Play();
        StartCoroutine(ToWait());
       
     }
     
     public void WolfSound()
     {
             sonido.clip = sonidoWolf;
              sonido.Play(); 
     }
     
       public void duckSound()
     {
             sonido.clip = sonidoDuck;
              sonido.Play(); 
     }
     
      public void snakeSound()
     {
             sonido.clip = sonidoSnake;
              sonido.Play(); 
     }
    
}
