using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    public GameObject playerBullet;
    public Transform bulletSpawn;

    private float shootTimer;
    [SerializeField] float shootDelay = 1.5f;
    private bool canShoot = true;


    private void Update()
    {
        if(canShoot == false)
        {
            shootTimer += Time.deltaTime;
            if(shootTimer >= shootDelay)
            {
                ResetBullet();
            }
        }
    }





    public void FireBullet()
    {
        if(canShoot == true)
        {
            GameObject bullet = Instantiate(playerBullet, bulletSpawn.position, Quaternion.identity);
            bullet.GetComponent<PlayerBullet>().PlayerSet(this);
            canShoot = false;
        }

    }

    public void ResetBullet()
    {
        shootTimer = 0f;
        canShoot = true;
    }
    
}
