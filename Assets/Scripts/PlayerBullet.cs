using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{

    public float moveSpeed;

    public float killLimit = 8.5f;

    public void PlayerSet(PlayerShoot player)
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
        if (transform.position.y >= killLimit)
        {
            Destroy(this.gameObject);
        }
    }
}
