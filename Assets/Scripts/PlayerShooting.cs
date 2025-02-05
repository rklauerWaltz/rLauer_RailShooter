using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    public GameObject playerBullet;
    public Transform bulletSpawn;

    public void FireBullet()
    {
       Instantiate(playerBullet, bulletSpawn.position, Quaternion.identity);
    }
}
