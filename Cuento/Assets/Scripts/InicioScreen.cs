using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioScreen : MonoBehaviour
{
    // Start is called before the first frame update
    public static int sceneNumber;
    void Start()
    {
       if(sceneNumber==0){
        StartCoroutine(ToInstrucciones());
        }   
        if(sceneNumber==1){
        StartCoroutine(ToBienvenidos());
        } 
        
        if(sceneNumber==2){
        StartCoroutine(ToEmpezar());
        } 
        
        
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    IEnumerator ToInstrucciones() {
        yield return new WaitForSeconds (3);
        sceneNumber=1;
        SceneManager.LoadScene(1);
    }
    
      IEnumerator ToBienvenidos() {
        yield return new WaitForSeconds (11);
        sceneNumber=2;
        SceneManager.LoadScene(2);
    }
    
      IEnumerator ToEmpezar() {
        yield return new WaitForSeconds (3);
        sceneNumber=3;
        SceneManager.LoadScene(3);
    }
    
    
     
    
}
