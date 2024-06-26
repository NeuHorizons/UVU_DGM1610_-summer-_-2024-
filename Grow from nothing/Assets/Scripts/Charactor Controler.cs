using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerGrowth : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float growthFactor = 0.1f; // Amount by which the player grows each time

    private Rigidbody2D rb2d;
    private Vector2 movement;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        // Ensure the Rigidbody2D is set to Kinematic
        rb2d.bodyType = RigidbodyType2D.Kinematic;
    }

    void Update()
    {
        // Get input from WASD keys
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calculate movement vector
        movement = new Vector2(moveHorizontal, moveVertical).normalized * moveSpeed;
    }

    void FixedUpdate()
    {
        // Apply movement to the character using Rigidbody2D
        rb2d.MovePosition(rb2d.position + movement * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("GrowCircle"))
        {
            // Increase the size of the player
            transform.localScale += new Vector3(growthFactor, growthFactor, 0);

            // Optionally, destroy the other circle
            Destroy(other.gameObject);
        }
    }
}
