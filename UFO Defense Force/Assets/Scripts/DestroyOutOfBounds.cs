using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // The z-axis threshold for destroying the GameObject
    public float zThreshold = 40.0f;

    void Update()
    {
        // Check if the GameObject's z position is less than the threshold
        if (transform.position.z > zThreshold)
        {
            // Destroy the GameObject
            Destroy(gameObject);
        }
    }
}