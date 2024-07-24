using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    // Speed at which the pickup moves down the screen
    public float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        // Move the pickup item down the screen along the z-axis
        // Vector3.back is shorthand for (0, 0, -1)
        // Time.deltaTime is used to make the movement frame rate independent
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }

    // This method is called when another collider enters the trigger collider attached to the pickup
    private void OnTriggerEnter(Collider other)
    {
        // Check if the other collider has the tag "Player"
        if (other.CompareTag("Player"))
        {
            // Attempt to get the PlayerInventory component from the player object
            PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

            // If the player object has a PlayerInventory component
            if (playerInventory != null)
            {
                // Call the CollectPickup method on the PlayerInventory component
                playerInventory.CollectPickup();

                // Destroy the pickup item
                Destroy(gameObject);
            }
        }
    }
}
