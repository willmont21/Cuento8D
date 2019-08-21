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
         if(sceneNumber==6){
           StartCoroutine(ToCapsula1());
        }
        
    
         if(sceneNumber==9){
        StartCoroutine(ToLobitos());
        }
        
         if(sceneNumber==13){
        StartCoroutine(ToDuckIntroduction());
        } 
       
       if(sceneNumber==14){
        StartCoroutine(ToSNakeDuck());
        }
        
          if(sceneNumber==17){
        StartCoroutine(ToMonito());
        }
        
        
        if(sceneNumber==19){
           StartCoroutine(ToMonitoLianas());
        }
        
        
         if(sceneNumber==21){
           StartCoroutine(ToMonitoIntro());
        }
        
        
         if(sceneNumber==22){
           StartCoroutine(ToMonitoIntrox2());
        }
        
        
          if(sceneNumber==24){
           StartCoroutine(ToMonitoLianas());
        }
        
          if(sceneNumber==29){
           StartCoroutine(ToCapsula4());
        }
        
        if(sceneNumber==30){
           StartCoroutine(ToSerpiente());
        }
        
        if(sceneNumber==32){
           StartCoroutine(ToJingle());
        }
     
     
      if(sceneNumber==33){
           StartCoroutine(ToEmpezarAgain());
        }
     
     
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    
     IEnumerator ToEmpezarAgain() {
        yield return new WaitForSeconds (45);
 
        SceneManager.LoadScene(1);
    }
    
    
     IEnumerator ToLobitos() {
        yield return new WaitForSeconds (10);
 
        SceneManager.LoadScene(10);
    }
    
    
     IEnumerator ToSNakeDuck() {
        yield return new WaitForSeconds (12);
    
        SceneManager.LoadScene(15);
    }
    
    IEnumerator ToDuckIntroduction() {
        yield return new WaitForSeconds (122);
    
        SceneManager.LoadScene(14);
    }
    
      IEnumerator ToMonitoIntro() {
        yield return new WaitForSeconds (72);
    
        SceneManager.LoadScene(22);
    }
    
    
    IEnumerator ToMonitoIntrox2() {
        yield return new WaitForSeconds (8);
    
        SceneManager.LoadScene(23);
    }
    
    
    
     IEnumerator ToMonito() {
        yield return new WaitForSeconds (10);
    
        SceneManager.LoadScene(18);
    }
    
    
     IEnumerator ToMonitoLianas() {
        yield return new WaitForSeconds (9);
    
        SceneManager.LoadScene(25);
    }
    
    
    IEnumerator ToCapsula1() {
        yield return new WaitForSeconds (270);
    
        SceneManager.LoadScene(11);
    }
    
     IEnumerator ToCapsula4() {
        yield return new WaitForSeconds (100);
    
        SceneManager.LoadScene(30);
    }
    
    IEnumerator ToSerpiente() {
        yield return new WaitForSeconds (13);
    
        SceneManager.LoadScene(31);
    }
    
    IEnumerator ToJingle() {
        yield return new WaitForSeconds (47);
    
        SceneManager.LoadScene(33);
    }
    
    
}
