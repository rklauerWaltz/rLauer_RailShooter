using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject playerBullet;
    [SerializeField] private Transform bulletSpawn;

    [SerializeField] private int activeBullets;
    public int bulletLimit;

    [SerializeField] float shootTime;
    [SerializeField] float shotDelay = 1.5f;
    public bool canShoot = true;
    private bool bulletActive;

    private void Update()
    {
        if(canShoot == false)
        {
            shootTime += Time.deltaTime;
            if(shootTime >= shotDelay)
            {
                shootTime = 0f;
                canShoot = true;
            }
        }
    }

    public void FireBullet()
    {
        if(canShoot == true)
        {
            GameObject bullet = Instantiate(playerBullet, bulletSpawn.position, Quaternion.identity);
            bullet.GetComponent<PlayerBullet>().PlayerSet(this);
            bulletActive = true;
            canShoot = false;

            if (GetComponentInChildren<Animator>() != null)
            {
                GetComponentInChildren<Animator>().SetTrigger("fire");
            }

        }
        
      
    }

    public void ResetBullet()
    {
        shootTime = 0f;
        canShoot = true;
    }
}
