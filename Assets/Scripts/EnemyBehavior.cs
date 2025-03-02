using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float moveSpeed;

    [SerializeField] private float maxSpeed;
    public float speedIncrease = 1.5f;
    public float shiftHeight = 1f;

    private BoxCollider2D boxCollider;

    private void Start()
    {
        GameManager.Instance.enemies = this;

        boxCollider = GetComponent<BoxCollider2D>();
        AdjustColliderSize();
    }

    private void Update()
    {
        if(GameManager.Instance.gameActive == true)
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Boundry")
        {
            GameManager.Instance.TriggerChange();
        }
    }

    public void ChangeDirection()
    {
        if(Mathf.Abs(moveSpeed) <= maxSpeed)
        {
            moveSpeed *= -speedIncrease;
        }
        else
        {
            moveSpeed *= -1f;
        }
        MoveIn();
    }

    void MoveIn()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - shiftHeight, transform.position.z);
    }

    public void AdjustColliderSize()
    {
        if (transform.childCount == 0) return;

        Bounds bounds = new Bounds(transform.GetChild(0).position, Vector3.zero);

        foreach (Transform child in transform)
        {
            bounds.Encapsulate(child.position);
        }

        boxCollider.offset = bounds.center - (Vector3)transform.position;
        boxCollider.size = bounds.size;

        if (boxCollider.size.x <= 0.1f || boxCollider.size.y <= 0.1f)
        {
            boxCollider.size = new Vector2(1f, 1f);
        }
        
    }
}
