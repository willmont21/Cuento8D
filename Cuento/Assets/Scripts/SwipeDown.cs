using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwipeDown : MonoBehaviour
{
    private Vector2 fingerDownPosition;
    private AudioSource[] allAudioSources;
    private Vector2 fingerUpPosition;

   private AudioSource instruccion;
   private int vez=0;
   public AudioClip AudioDown;
   private bool pasar=false;

   
    [SerializeField]
    private bool detectSwipeOnlyAfterRelease = false;

    [SerializeField]
    private float minDistanceForSwipe = 20f;

    void Start()
      {
       instruccion=GetComponent<AudioSource>();
       instruccion.clip = AudioDown;
       StartCoroutine(ToWait());
     
      }
 
          IEnumerator ToWait() {
             instruccion.Play();
             yield return new WaitForSeconds (9);
             vez=2;
        }
            
        IEnumerator ToWaitx2() {
          instruccion.Play();
        yield return new WaitForSeconds (9);
         // StopAllAudio();
        
            }

    private void Update()
    {
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
      
       instruccion.Stop();
        if (SwipeDistanceCheckMet())
        {
            if (IsVerticalSwipe())
            {
                  object myObject = new Object();
                  myObject  = fingerDownPosition.y - fingerUpPosition.y > 0 ? SwipeDirection.Up : SwipeDirection.Down;
                  string myObjectString = myObject.ToString();
                 if (myObjectString == "Up"){
             
                    }
                 else {
                StopAllAudio();
                pasar=true;
                     SceneManager.LoadScene(4);
                 }
            }
            else
            {
            object myObject = new Object();

         
             myObject  = fingerDownPosition.x - fingerUpPosition.x > 0 ? SwipeDirection.Right : SwipeDirection.Left;
             string myObjectString = myObject.ToString();
                 if (myObjectString == "Right"){
                
                 }
   
            }
            fingerUpPosition = fingerDownPosition;
            if(pasar==false){
                 StartCoroutine(ToWaitx2());
                  
                 }
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
