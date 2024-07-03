using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -30f; // The left boundary limit for the x-axis
    private float bottomLimit = -5f; // The bottom boundary limit for the y-axis

    // Update is called once per frame
    void Update()
    {
        // Destroy game objects if their x position is less than the left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        }
        // Destroy game objects if their y position is less than the bottom limit
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }
    }
}
