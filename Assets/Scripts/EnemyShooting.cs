using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField] private GameObject enemyBullet;
    [SerializeField] private Transform bulletSpawn;

    public float shootCountdown; // this is the timer that counts up. 
    private float shootTime; //this is the predetermined time what the enemy shoots a bullet. 

    [SerializeField] private float shootTimeMin = 5f;
    [SerializeField] private float shootTimeMax = 15f;

    // Start is called before the first frame update
    void Start()
    {
        shootTime = Random.Range(shootTimeMin, shootTimeMax);
    }

    // Update is called once per frame
    void Update()
    {
        ShootLoop();
    }

    void ShootLoop()
    {
        shootCountdown += Time.deltaTime;
        if(shootCountdown >= shootTime)
        {
            Instantiate(enemyBullet, bulletSpawn.position, Quaternion.identity);
            shootCountdown = 0f;
            shootTime = Random.Range(shootTimeMin, shootTimeMax);
        }
    }
}
