using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FoundMonkey : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource sonido;
    public AudioClip duck, monkey, snake, wolf;
    public Button bduck;
    public Button bmonkey;
    public Button bsnake;
    public Button bwolf;
    void Start()
    {
         sonido=GetComponent<AudioSource>();
         Button b1 =  bduck.GetComponent<Button>();
         b1.onClick.AddListener(TaskDuck);
         Button b2 =  bmonkey.GetComponent<Button>();
         b2.onClick.AddListener(TaskMonkey);
         Button b3 =  bsnake.GetComponent<Button>();
         b3.onClick.AddListener(TaskSnake);
         Button b4 =  bwolf.GetComponent<Button>();
         b4.onClick.AddListener(TaskWolf);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    
    public void TaskDuck()
     {
         sonido.clip = duck;
         sonido.Play();
     
     }
     
     
      public void TaskWolf()
     {
     sonido.clip = wolf;
         sonido.Play();
     }
     
      public void TaskSnake()
     {
         sonido.clip = snake;
         sonido.Play();
     }
     
      public void TaskMonkey()
     {
      sonido.clip = monkey;
      StartCoroutine(ToEsperar()); 
     }
     
      IEnumerator ToEsperar() {
        sonido.Play();
        yield return new WaitForSeconds (4);
          SceneManager.LoadScene("21LianasInstruccionMono");
        
          }
}
