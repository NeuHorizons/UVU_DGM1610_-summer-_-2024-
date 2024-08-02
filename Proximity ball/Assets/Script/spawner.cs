using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject objectToSpawn; // The object to be spawned
    public float spawnRange = 5f; // Range on the x-axis for random spawning
    public float spawnInterval = 2f; // Interval in seconds between spawns

    void Start()
    {
        // Start the spawning coroutine
        StartCoroutine(SpawnObjectRoutine());
    }

    IEnumerator SpawnObjectRoutine()
    {
        while (true)
        {
            // Wait for the specified interval
            yield return new WaitForSeconds(spawnInterval);

            // Spawn the object
            SpawnObject();
        }
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
