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
        // looking at the player's position every frame. If it is less than or greater than the xRange we freeze the player by forcing a new position. 
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector2(-xRange, transform.position.y);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector2(xRange, transform.position.y);
        }
    }

}
