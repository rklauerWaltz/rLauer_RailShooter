using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] private GameObject enemyBullet;
    [SerializeField] private Transform bulletSpawn;

    public float shootCountdown;
    private float shootTime;

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
        if(GameManager.Instance.gameActive == true)
        {
            ShootLoop();
        }
    }



    void ShootLoop()
    {
        shootCountdown += Time.deltaTime;
        if (shootCountdown >= shootTime)
        {
            Shoot();
            shootTime = Random.Range(shootTimeMin, shootTimeMax);
            shootCountdown = 0f;
        }

    }

    void Shoot()
    {
        Instantiate(enemyBullet, bulletSpawn.position, Quaternion.identity);
    }

}
