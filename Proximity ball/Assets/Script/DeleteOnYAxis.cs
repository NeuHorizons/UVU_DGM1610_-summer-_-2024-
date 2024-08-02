using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOnYAxis : MonoBehaviour
{
    public float yThreshold = -10f; // The y-axis threshold for deletion

    void Update()
    {
        // Check if the object's y position is less than the threshold
        if (transform.position.y < yThreshold)
        {
            // Destroy the game object
            Destroy(gameObject);
        }
    }
}
