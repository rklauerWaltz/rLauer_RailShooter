using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    [SerializeField] private GameObject playerBullet;
    [SerializeField] private Transform bulletSpawn;

    [SerializeField] private int activeBullets;
    public int bulletLimit;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {

    }

    public void FireBullet()
    {
        if(activeBullets <= bulletLimit)
        {
           GameObject bullet = Instantiate(playerBullet, bulletSpawn.position, Quaternion.identity);
           bullet.GetComponent<PlayerBullet>().PlayerSet(this);
        }
    }
    
}
