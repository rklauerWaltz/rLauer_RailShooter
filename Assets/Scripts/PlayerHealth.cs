using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public bool isAlive = true;
    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<EnemyBullet>() || collision.gameObject.GetComponent<EnemyHealth>() && isAlive == true)
        {
            if(GetComponentInChildren<Animator>() != null)
            {
                GetComponentInChildren<Animator>().SetBool("isAlive", false);
                isAlive = false;
                GameManager.Instance.playerLives--;
                GameManager.Instance.GameOverCheck();
            }
        }
    }

}
