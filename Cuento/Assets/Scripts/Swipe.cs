using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Swipe : MonoBehaviour
{
    private Vector2 fingerDownPosition;
    private AudioSource[] allAudioSources;
    private Vector2 fingerUpPosition;
   public int siguiente,anterior,arriba,abajo;
   private AudioSource instruccion;
   public AudioClip AudioDes;
   public AudioSource ticky;
   
    [SerializeField]
    private bool detectSwipeOnlyAfterRelease = false;

    [SerializeField]
    private float minDistanceForSwipe = 20f;

    void Start()
      {
      instruccion=GetComponent<AudioSource>();
       instruccion.clip = AudioDes;
     
      }

    private void Update()
    {
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
                      if (arriba != 0){
                        SceneManager.LoadScene(arriba);
                    }
                    
                    }
                 else {
                StopAllAudio();
                  instruccion.Play();
                     //SceneManager.LoadScene(anterior);
                 }
               
               
               
               
               
               
            }
            else
            {
            object myObject = new Object();

         
             myObject  = fingerDownPosition.x - fingerUpPosition.x > 0 ? SwipeDirection.Right : SwipeDirection.Left;
  
            // string dir = System.Enum.Parse(typeof(direction.Right), direction);
            //  string description =  System.Enum.GetName(typeof(direction), 3);
          
            
             string myObjectString = myObject.ToString();
                 if (myObjectString == "Right"){
                     if (siguiente != 0){
                    ticky.Play();
                     SceneManager.LoadScene(siguiente);
                     }
           
                 }
                 else  if (anterior != 0){
                  
                     SceneManager.LoadScene(anterior);
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

