using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Reference to the pickup prefab to be spawned
    public GameObject pickupPrefab;

    // Interval in seconds between spawns
    public float spawnInterval = 5f;

    // Distance along the z-axis where the pickup will be spawned
    public float spawnDistance = 10f;

    // Time at which the next spawn should occur
    private float nextSpawnTime;

    // Update is called once per frame
    void Update()
    {
        // Check if the current time has reached or passed the next spawn time
        if (Time.time >= nextSpawnTime)
        {
            // Spawn a new pickup
            SpawnPickup();

            // Calculate the time for the next spawn
            nextSpawnTime = Time.time + spawnInterval;
        }
    }

    // Method to spawn a pickup
    void SpawnPickup()
    {
        // Calculate a random spawn position within the specified range on the x-axis
        // y is set to -2 to be on ground level or slightly above it
        // z is calculated by adding spawnDistance to the current z position of the spawner
        Vector3 spawnPosition = new Vector3(Random.Range(-5f, 5f), -2f, transform.position.z + spawnDistance);

        // Instantiate the pickup prefab at the calculated spawn position with no rotation (Quaternion.identity)
        Instantiate(pickupPrefab, spawnPosition, Quaternion.identity);
    }
}
