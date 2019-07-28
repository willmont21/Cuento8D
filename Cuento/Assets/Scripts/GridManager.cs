using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridManager : MonoBehaviour
{
  
  
   //public Sprite loba;

   
   void Start()
    {
      int ancho=Screen.width;
      int anchoCol=ancho/5;
       
      int longi=Screen.height;
       int anchoFil=longi/7;
       int cont = 2;
       int numCol=0;
       bool asignado= false;
        int randomCol=Random.Range(0,4);
        int randomFil=Random.Range(0,4);
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
             
              
                            
                  if (asignado)//si ya asigne la imagen Random
                    {
                     GameObject g = new GameObject("x: "  + "y: " );
                      g.transform.position = new Vector3(numCol, anchoFil * j );
                    }
                  else 
                    {
                     GameObject g = new GameObject("SpriteRenderer" );
                            g.transform.position = new Vector3(numCol, anchoFil * j );
                        if (randomCol == i && randomFil==j )//cuando coincida la fila y la columna random
                         {
                          GameObject c = new GameObject("Aqui" );
                            c.transform.position = new Vector3(numCol, anchoFil * j );
                            
                            Sprite loba = Resources.Load("loba", typeof(Sprite)) as Sprite;
                            
                          //loba = Resources.Load<Sprite>("Sprites/loba");
                         
                        //  SpriteRenderer spriteRenderer = c.AddComponent<SpriteRenderer>();
                           //     spriteRenderer.sprite = loba;
                                
                                c.AddComponent<SpriteRenderer>().sprite =loba;
                                //c.GetComponent<SpriteRenderer>().sprite =loba;
                                asignado = true;
                            
                           
                        }
                    }
                     
                     
               
               
            
            }
            numCol =  numCol + anchoCol;
           
          
        }
       
    }
    
}
