using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
    public string targetTag; // The tag of the objects that should be destroyed

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collided object has the specified tag
        if (collision.gameObject.CompareTag(targetTag))
        {
            Debug.Log("Trigger with target tag");
            Destroy(collision.gameObject); // Destroy the collided object if it has the correct tag
        }
    }
}