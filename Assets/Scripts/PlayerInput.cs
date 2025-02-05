using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    private float hInput;

    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private PlayerShoot playerShoot;


    // Update is called once per frame
    private void Update()
    {
        //axis movement
        hInput = Input.GetAxisRaw("Horizontal");
        playerMovement.Movement(hInput);

        //shoot projectiles
        if(Input.GetButtonDown("Fire1"))
        {
            playerShoot.FireBullet();
        }

    }
}
