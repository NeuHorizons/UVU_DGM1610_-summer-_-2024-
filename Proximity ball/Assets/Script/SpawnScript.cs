using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject objectToSpawn; // The object to be spawned
    public float spawnRange = 5f; // Range on the x-axis for random spawning

    void Start()
    {
        SpawnObject();
    }

    void SpawnObject()
    {
        // Get the spawn point position
        Vector3 spawnPoint = transform.position;

        // Generate a random x position within the spawn range
        float randomX = Random.Range(-spawnRange, spawnRange);

        // Create the spawn position
        Vector3 spawnPosition = new Vector3(spawnPoint.x + randomX, spawnPoint.y, spawnPoint.z);

        // Instantiate the object at the spawn position
        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    }
}
