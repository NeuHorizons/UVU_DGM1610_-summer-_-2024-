using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 15.0f; // Movement speed of the player
    private float turnSpeed = 25.0f ; // Turning speed of the player
    public float horizontalInput; // Horizontal input value (A/D or Left/Right arrow keys)
    public float forwardInput; // Forward input value (W/S or Up/Down arrow keys)

    // Start is called before the first frame update
    void Start()
    {
        // Initialization code can be added here if needed
    }

    // Update is called once per frame
    void Update()
    {
        // Get the player's horizontal input (left/right movement)
        horizontalInput = Input.GetAxis("Horizontal");
        // Get the player's forward input (forward/backward movement)
        forwardInput = Input.GetAxis("Vertical");

        // Move the player forward or backward based on the forward input
        // Vector3.forward represents the forward direction relative to the player
        // Time.deltaTime ensures the movement is frame rate independent
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Rotate the player left or right based on the horizontal input
        // Vector3.up represents the up direction relative to the player
        // Time.deltaTime ensures the rotation is frame rate independent
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
