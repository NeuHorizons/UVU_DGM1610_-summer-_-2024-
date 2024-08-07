using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnmanager : MonoBehaviour
{
    public GameObject objectToSpawn;  // The prefab to spawn
    public float width = 10f;         // Width of the spawning area
    public float height = 10f;        // Height of the spawning area
    public float spawnInterval = 1f;  // Time interval between spawns

    private float timer;

    void Start()
    {
        timer = spawnInterval; // Initialize timer
    }

    void Update()
    {
        timer -= Time.deltaTime; // Decrease timer by the time elapsed since the last frame

        if (timer <= 0)
        {
            SpawnObject();   // Spawn an object
            timer = spawnInterval; // Reset timer
        }
    }

    void SpawnObject()
    {
        Vector2 spawnPosition = GetRandomPosition();
        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    }

    Vector2 GetRandomPosition()
    {
        float x = Random.Range(-width / 2, width / 2);
        float y = Random.Range(-height / 2, height / 2);
        return new Vector2(x, y);
    }
}
