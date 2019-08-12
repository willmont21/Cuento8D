using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using Firebase.Storage;
using System.Threading;
using System.Threading.Tasks;

public class ControllerDescription : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StorageReference descrip = 
        FirebaseStorage.DefaultInstance.GetReferenceFromUrl("gs://doyecuentos.appspot.com/DescripcionLobo.mp4");
        
        descrip.GetDownloadUrlAsync().ContinueWith((Task<Uri> task1) =>
            {
             if (!task1.IsFaulted && !task1.IsCanceled)
               {
                  string url = task1.Result.ToString();
                  Debug.Log(url);
                     StartCoroutine(LoadURL(url)); 
                }
                  
            });
    }


   IEnumerator LoadURL(string url)
    {
       WWW www = new WWW(url);
      Debug.Log("holi");
            yield return www;
            Renderer renderer = GetComponent<Renderer>();
            renderer.material.mainTexture = www.texture;
            renderer.material.mainTexture.filterMode = FilterMode.Point;
          
          
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
