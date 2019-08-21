using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SnakeController : MonoBehaviour
{
    // Start is called before the first frame update
 private float speed = 200f;
 private Rigidbody2D myBody; 
 private Vector2 vel;
 public Vector2 Hrange = Vector2.zero;
 public Vector2 Vrange = Vector2.zero;
 public Button  snakeController; 
 public AudioClip snake;
 private bool action= false;
 private int cont=0;
  public AudioSource ticky;
  private AudioSource instruccion;
  
      
     void Start () {
     myBody = GetComponent<Rigidbody2D> ();
      vel =myBody.velocity;
          vel.x =  speed;
          myBody.velocity = vel;
        Button btnSnake =  snakeController.GetComponent<Button>();
        instruccion=GetComponent<AudioSource>();
       instruccion.clip = snake;
      // StartCoroutine(ToWait());
         btnSnake.onClick.AddListener(AlejarSerpiente);
	}
	
	// Update is called once per frame
	void Update () {
      if(transform.position.x >= 650 && action== false){
             transform.position = new Vector3 (
              Mathf.Clamp(transform.position.x, Vrange.x,Vrange.y ),
              Mathf.Clamp(transform.position.y, Hrange.x,Hrange.y ),
              transform.position.z
             );
            
      }
	}
    
      IEnumerator ToWait() {
            instruccion.volume = 1.0F;
             instruccion.Play();
             yield return new WaitForSeconds (9);
    
        }
            
    
    public void AlejarSerpiente()
     {
          ticky.Play();
     cont++;
     instruccion.volume = instruccion.volume-0.1F;
     instruccion.Play();
     if(cont==7) {
      action=true;
      StartCoroutine(retiradaSerpiente());  
       }
      }
      
    IEnumerator retiradaSerpiente() {  
        yield return new WaitForSeconds (5);
        SceneManager.LoadScene(18);
     }
    
   
}
