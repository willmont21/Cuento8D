using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Swipe : MonoBehaviour
{

  
    private Vector2 startTouchPosition, endTouchPosition;
    public string nombre;

    // Start is called before the first frame update
    
    void Start()
    {
        
    }


    // Update is called once per frame
    private void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            startTouchPosition = Input.GetTouch(0).position;

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouchPosition = Input.GetTouch(0).position;

            /*if ((endTouchPosition.x < startTouchPosition.x))
                //transform.position = new Vector2(transform.position.x - 1.75f, transform.position.y);
                 SceneManager.LoadScene("Wolf_Found", LoadSceneMode.Additive);*/

            if ((endTouchPosition.x > startTouchPosition.x))
               // transform.position = new Vector2(transform.position.x + 1.75f, transform.position.y);
                SceneManager.LoadScene(nombre);
        }
    }  
}
