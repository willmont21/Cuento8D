using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MonkeyLianas : MonoBehaviour
{
 public Button  monkeyController; 
  private int cont=0;
    // Start is called before the first frame update
    void Start()
    {
          Button btn =  monkeyController.GetComponent<Button>();
           btn.onClick.AddListener(caerMono);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void caerMono()
     {
     cont++;
    
     if(cont==7) {
     SceneManager.LoadScene(21);
       }
      }
      
   
}
