using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<EnemyBullet>())
        {
            Destroy(collision.gameObject);
            gameObject.SetActive(false);

        }
    }
}
