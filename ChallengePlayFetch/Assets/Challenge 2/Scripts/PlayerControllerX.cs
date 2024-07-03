using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab; // Prefab for the dog to be instantiated
    public float spawnCooldown = 2.0f; // Time in seconds between allowed spawns

    private float lastSpawnTime = -Mathf.Infinity; // Time when the last dog was spawned

    // Update is called once per frame
    void Update()
    {
        // Check if the spacebar is pressed and enough time has passed since the last spawn
        if (Input.GetKeyDown(KeyCode.Space) && Time.time - lastSpawnTime >= spawnCooldown)
        {
            // Spawn the dog prefab at the player's position with the dog's rotation
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            // Update the last spawn time to the current time
            lastSpawnTime = Time.time;
        }
    }
}
