using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private float hInput;

    public float xRange = 10;

  
    private void Update()
    {
        hInput = Input.GetAxisRaw("Horizontal");

        transform.Translate(Vector2.right * hInput * moveSpeed * Time.deltaTime); 
   

        //Keep the player from moving beyond the xRange
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector2(-xRange, transform.position.y);
            Debug.Log(xRange);
        }
        if(transform.position.x > xRange)
        {
            transform.position = new Vector2(xRange, transform.position.y);
        }

    }


    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Boundry")
        {
            Debug.Log("I'm hitting the left boundry");
            transform.position = new Vector2(transform.position.x, transform.position.y);
        }
           
    }*/

    

}
