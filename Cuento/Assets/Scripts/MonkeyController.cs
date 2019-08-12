using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MonkeyController : MonoBehaviour
{
    // Start is called before the first frame update
    public Button  monkeyController; 
    private int cont=0;
    void Start()
    {
         Button btnMonkey =  monkeyController.GetComponent<Button>();
         btnMonkey.onClick.AddListener(romperLiandas);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
     public void romperLiandas()
     {
     cont++;
     if(cont==7) {
       SceneManager.LoadScene(12); 
       }
      }
}
