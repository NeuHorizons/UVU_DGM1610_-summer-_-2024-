using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Public variable to set movement speed from the Inspector
    public float moveSpeed = 5f;

    // Private variables to hold the Rigidbody2D component and movement vectors
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Vector2 moveVelocity;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Rigidbody2D component attached to the player GameObject
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get input from horizontal axis (A/D or Left/Right arrows) and vertical axis (W/S or Up/Down arrows)
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // Create a Vector2 based on the input
        moveInput = new Vector2(moveX, moveY);

        // Normalize the movement vector to ensure consistent speed in all directions
        moveVelocity = moveInput.normalized * moveSpeed;
    }

    // FixedUpdate is called at a fixed interval and is used for physics updates
    void FixedUpdate()
    {
        // Move the player by changing its position based on the movement vector
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
}
