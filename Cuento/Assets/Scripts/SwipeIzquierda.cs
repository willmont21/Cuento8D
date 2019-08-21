using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SwipeIzquierda : MonoBehaviour
{
 private Vector2 fingerDownPosition;
    private AudioSource[] allAudioSources;
    private Vector2 fingerUpPosition;
    private bool pasar=false;
    private AudioSource instruccion;
    private int vez=0;
    public AudioClip AudioLeft;
    public AudioClip bien;
    private float time=15;
    public AudioSource ticky;
   
    [SerializeField]
    private bool detectSwipeOnlyAfterRelease = false;

    [SerializeField]
    private float minDistanceForSwipe = 20f;

    void Start()
      {
      instruccion=GetComponent<AudioSource>();
       instruccion.clip = AudioLeft;
       StartCoroutine(ToWait());
     
      }
      
        IEnumerator ToWait() {

             instruccion.Play();
             yield return new WaitForSeconds (9);
             vez=2;
        }
            
        IEnumerator ToWaitx2() {
          instruccion.clip = bien;
          instruccion.Play();
        yield return new WaitForSeconds (3);
          SceneManager.LoadScene(5);
         // StopAllAudio();
        
            }

    private void Update()
    {
    
      time-=Time.deltaTime;
      Debug.Log("hay" +time);
      
        if(time<=0){
         Debug.Log("Soy cero");
           instruccion.Play();
           StartCoroutine(ToWait());
           time=15;
       
        }
        
      if(vez==2){
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                fingerUpPosition = touch.position;
                fingerDownPosition = touch.position;
            }

            if (!detectSwipeOnlyAfterRelease && touch.phase == TouchPhase.Moved)
            {
                fingerDownPosition = touch.position;
                DetectSwipe();
            }

            if (touch.phase == TouchPhase.Ended)
            {
                fingerDownPosition = touch.position;
                DetectSwipe();
            }
        }
        }
    }
    
    void StopAllAudio() {
     allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
     foreach( AudioSource audioS in allAudioSources) {
         audioS.Stop();
     }
 }

    private void DetectSwipe()
    {

        if (SwipeDistanceCheckMet())
        {
            if (IsVerticalSwipe())
            {
                  object myObject = new Object();
                  myObject  = fingerDownPosition.y - fingerUpPosition.y > 0 ? SwipeDirection.Up : SwipeDirection.Down;
                  string myObjectString = myObject.ToString();
                 if (myObjectString == "Up"){
                  ticky.Play();
                    }
                 else {
                 ticky.Play();
                 }
 
            }
            else
            {
            object myObject = new Object();
             myObject  = fingerDownPosition.x - fingerUpPosition.x > 0 ? SwipeDirection.Right : SwipeDirection.Left;  
             string myObjectString = myObject.ToString();
                 if (myObjectString == "Right"){
                         ticky.Play();
                 }
                 else  {
                    StartCoroutine(ToWaitx2());
      
                 }
               
               
               
            }
            fingerUpPosition = fingerDownPosition;
        
        }
    }

    private bool IsVerticalSwipe()
    {
        return VerticalMovementDistance() > HorizontalMovementDistance();
    }

    private bool SwipeDistanceCheckMet()
    {
        return VerticalMovementDistance() > minDistanceForSwipe || HorizontalMovementDistance() > minDistanceForSwipe;
    }

    private float VerticalMovementDistance()
    {
        return Mathf.Abs(fingerDownPosition.y - fingerUpPosition.y);
    }

    private float HorizontalMovementDistance()
    {
        return Mathf.Abs(fingerDownPosition.x - fingerUpPosition.x);
    }

    public enum SwipeDirection
{
    Up,
    Down,
    Left,
    Right
}
    
  
}
