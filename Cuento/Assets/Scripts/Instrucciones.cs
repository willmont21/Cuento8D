using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Instrucciones : MonoBehaviour
{
    // Start is called before the first frame update
    public int sceneNumber;
    void Start()
    {
        if(sceneNumber==8){
        StartCoroutine(ToLobitos());
        }
        
        
         if(sceneNumber==14){
        StartCoroutine(ToSNakeDuck());
        }
        
          if(sceneNumber==17){
        StartCoroutine(ToMonito());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
     IEnumerator ToLobitos() {
        yield return new WaitForSeconds (10);
 
        SceneManager.LoadScene(9);
    }
    
    
     IEnumerator ToSNakeDuck() {
        yield return new WaitForSeconds (12);
    
        SceneManager.LoadScene(15);
    }
    
    
    
     IEnumerator ToMonito() {
        yield return new WaitForSeconds (10);
    
        SceneManager.LoadScene(18);
    }
    
    
}
