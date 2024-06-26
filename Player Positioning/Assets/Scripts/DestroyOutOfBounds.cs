using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float topBound = 30f; // Upper boundary for the projectile's position on the Z axis
    public float lowerBound = -10f; // Lower boundary for the projectile's position on the Z axis

    // Start is called before the first frame update
    void Start()
    {
        // Initialization code can be added here if needed
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the projectile has gone beyond the upper boundary
        if (transform.position.z > topBound)
        {
            // Destroy the projectile GameObject
            Destroy(gameObject);
        }
        // Check if the projectile has gone below the lower boundary
        else if (transform.position.z < lowerBound)
        {
            // Destroy the projectile GameObject
            Destroy(gameObject);
        }
    }
}
