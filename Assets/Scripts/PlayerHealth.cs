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
            GameManager.Instance.GameOver();
            GetComponent<AudioSource>().Play();
            gameObject.SetActive(false);

        }

        if(collision.gameObject.GetComponent<EnemyHealth>())
        {
            gameObject.SetActive(false);
        }

        
    }
}
