using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float moveSpeed;

    public float killLimit = 8.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up *  moveSpeed * Time.deltaTime);

        if(transform.position.y >= killLimit)
        {
            Destroy(this.gameObject);
        }
    }
}
