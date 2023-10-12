using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBoundsChecker : MonoBehaviour
{
    SpriteRenderer renderer;
    Rigidbody2D rb;
    Vector3 startPos;
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        startPos = transform.position;
    }

   
    void Update()
    {
        if (!renderer.isVisible)
        {
            rb.velocity = Vector2.zero;
            transform.position = startPos;
        }
    }
}
