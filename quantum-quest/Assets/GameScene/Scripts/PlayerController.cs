using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Include this if you're using SceneManager to restart or stop the game.

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public Rigidbody2D rb;
    private float moveX;
    private float maxHeight; // Variable to store the maximum height.

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        maxHeight = transform.position.y; // Initialize the maxHeight with the starting y position.
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * moveSpeed;

        // Check if the current height is greater than the maxHeight.
        if (transform.position.y > maxHeight)
        {
            maxHeight = transform.position.y; // Update the maxHeight.
        }

        // Check if the player dips more than 15 units below the maxHeight.
        if (maxHeight - transform.position.y > 15)
        {
            // Stop the game. Here you can call a method to handle the game over scenario.
            GameOver();
        }
    }

    private void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = moveX;
        rb.velocity = velocity;
    }

    private void GameOver()
    {
        // Load the "EntryScene".
        SceneManager.LoadScene("EntryScene");
    }
}
