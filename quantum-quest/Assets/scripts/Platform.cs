using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float jumpForce = 10f;
    public AudioSource audioSource; // Add this
    public AudioClip jumpSound; // And this

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;

                // Play the jump sound effect
                audioSource.PlayOneShot(jumpSound);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
