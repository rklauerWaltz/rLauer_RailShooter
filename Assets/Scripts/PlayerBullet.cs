using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{

    public float moveSpeed;

    public float killLimit = 8.5f;

    private PlayerShoot playerShoot;

    public void PlayerSet(PlayerShoot player)
    {
        playerShoot = player;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
        if (transform.position.y >= killLimit)
        {
            BulletDeath();
            Destroy(this.gameObject);
        }
    }

    public void BulletDeath()
    {
        playerShoot.ResetBullet();
    }
}
