using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;


    public float xRange = 10;

  
   

    public void Movement(float hInput)
    {
        transform.Translate(Vector2.right * hInput * moveSpeed * Time.deltaTime);


        //Keep the player from moving beyond the xRange
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector2(-xRange, transform.position.y);
            Debug.Log(xRange);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector2(xRange, transform.position.y);
        }
    }


    

}
