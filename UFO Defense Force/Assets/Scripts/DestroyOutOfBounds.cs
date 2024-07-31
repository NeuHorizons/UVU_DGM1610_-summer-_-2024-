using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    // The z-axis thresholds for destroying the GameObject
    public float zUpperThreshold = 40.0f;
    public float zLowerThreshold = -10.0f;

    void Update()
    {
        // Check if the GameObject's z position is out of the specified range
        if (transform.position.z > zUpperThreshold || transform.position.z < zLowerThreshold)
        {
            // Destroy the GameObject
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Log the collision for debugging purposes
        Debug.Log("Collision detected with: " + collision.gameObject.name);

        // Destroy the GameObject when it collides with another object
        Destroy(gameObject);
    }


}
