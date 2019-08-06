using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapController : MonoBehaviour
{
    public float velocidad = 3f;
    public GameObject character;

    private Rigidbody2D characterBody;

    // Start is called before the first frame update
    void Start()
    {
        characterBody = character.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        int i = 0;
        while (i < Input.touchCount)
        {
            RunCharacter(1.0f);
        }
        
    }

    private void RunCharacter (float horizontalInput)
    {
        characterBody.AddForce(new Vector2(horizontalInput * velocidad* Time.deltaTime,0));
    }
}
