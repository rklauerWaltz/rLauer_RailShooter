using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<PlayerBullet>())
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }





}
