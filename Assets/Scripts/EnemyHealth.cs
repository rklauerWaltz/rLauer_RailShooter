using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<PlayerBullet>())
        {
            gameObject.SetActive(false);
            Destroy(collision.gameObject);
            GameManager.Instance.UpdateEnemies();
            Destroy(this.gameObject);

        }
    }
}
