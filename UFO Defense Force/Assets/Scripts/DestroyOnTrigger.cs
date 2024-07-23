using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTrigger : MonoBehaviour
{
    // This method is called when another collider enters the trigger collider attached to the GameObject
    void OnTriggerEnter(Collider other)
    {
        // Destroy the GameObject that enters the trigger
        Destroy(other.gameObject);
    }
}
