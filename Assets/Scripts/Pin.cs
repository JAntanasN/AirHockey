using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer), typeof(Rigidbody2D))]
public class Pin : MonoBehaviour
{
    AudioSource audioSource;
    // Get the pin back to the center after scoring goal
    SpriteRenderer renderer;
    Rigidbody2D rb;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        // Get the pin back to the center after scoring goal
        renderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Get the pin back to the center after scoring goal
        if (!renderer.isVisible)
        {
            rb.velocity = Vector2.zero;
            transform.position = Vector3.zero;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(audioSource != null)
        {
            var volume = collision.relativeVelocity.magnitude / 50;
            audioSource.volume = volume;
            audioSource.Play();
        }
    }
}
