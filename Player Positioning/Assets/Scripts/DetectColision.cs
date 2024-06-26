using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Initialization code can be added here if needed
    }

    // Update is called once per frame
    void Update()
    {
        // Code to update each frame can be added here if needed
    }

    // This method is called when the collider attached to the GameObject this script is attached to
    // enters a trigger collider
    private void OnTriggerEnter(Collider other)
    {
        // Destroy the GameObject this script is attached to
        Destroy(gameObject);

        // Destroy the other GameObject that triggered the collider
        Destroy(other.gameObject);
    }
}
