using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public BoxCollider2D collider;
    public Rigidbody2D rb;
    public float width; // Specify the type of this variable (float)
    public float scrollSpeed = -2.0f; // Specify the type of this variable (float)

    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        width = collider.size.x;
        collider.enabled = false;
        rb.velocity = new Vector2(scrollSpeed, 0);
    }

    void Update()
    {
        if (transform.position.x < -width)
        {
            Vector2 resetPosition = new Vector2(width * 2f, 0);
            transform.position = (Vector2)transform.position + resetPosition; // Correct the assignment operator here
        }
    }
}
