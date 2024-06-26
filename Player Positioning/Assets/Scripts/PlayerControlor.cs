using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerControlor : MonoBehaviour
{
    // Public variables that can be set in the Unity Editor
    public float HorizontalInput; // Variable to store horizontal input (A/D or Left/Right arrow keys)
    public float speed = 10.0f; // Movement speed of the player
    public float xRange = 10; // Limit for the player's movement on the x-axis
    public GameObject projectilePrefab; // Prefab for the projectile to be instantiated

    // Start is called before the first frame update
    void Start()
    {
        // Initialization code can be added here if needed
    }

    // Update is called once per frame
    void Update()
    {
        // Prevent the player from moving beyond the left boundary
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        // Prevent the player from moving beyond the right boundary
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Get the player's horizontal input (left/right movement)
        HorizontalInput = Input.GetAxis("Horizontal");

        // Move the player left or right based on the horizontal input
        // Vector3.right represents the right direction relative to the player
        // Time.deltaTime ensures the movement is frame rate independent
        transform.Translate(Vector3.right * HorizontalInput * Time.deltaTime * speed);

        // Check if the space key is pressed to shoot a projectile
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Instantiate a projectile at the player's position with the projectile's rotation
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
