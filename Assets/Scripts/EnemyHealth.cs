using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int pointvalue;

    [SerializeField] private GameObject deathSprite;

    private void Start()
    {
        GameManager.Instance.enemyList.Add(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<PlayerBullet>())
        {
            gameObject.SetActive(false);
            Destroy(collision.gameObject);
            GameManager.Instance.UpdateEnemies();
            UserInterfaceManager.Instance.UpdateScore(pointvalue);
            collision.gameObject.GetComponent<PlayerBullet>().BulletDeath();
            Instantiate(deathSprite, transform.position, Quaternion.identity);
            gameObject.SetActive(false);
        }
    }
}
