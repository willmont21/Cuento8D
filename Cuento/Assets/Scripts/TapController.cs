using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TapController : MonoBehaviour
{
    public Rigidbody2D body;
    public float walkingSpeed;
    public Button buttons;
    public GameObject character;

    void Start()
    {
        body = character.GetComponent<Rigidbody2D>();
        Button btns = buttons.GetComponent<Button>();
        btns.onClick.AddListener(TaskOnClick);
    }
    

    void Update()
    {
        
    }

    public void TaskOnClick()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(walkingSpeed, GetComponent<Rigidbody2D>().velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        //var t = collision.gameObject.tag;
        var otherObject = collision.collider.gameObject;
        if (otherObject.tag == "loba")
        {

            SceneManager.LoadScene(8);
        }






    }
}
