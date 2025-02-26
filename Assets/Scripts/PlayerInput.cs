using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private float hInput;

    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private PlayerShooting playerShoot;


    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.gameActive == true)
        {
            hInput = Input.GetAxisRaw("Horizontal");
            playerMovement.Movement(hInput);

            if (Input.GetButtonDown("Jump"))
            {
                playerShoot.FireBullet();
            }
        }
        

        


    }

}
