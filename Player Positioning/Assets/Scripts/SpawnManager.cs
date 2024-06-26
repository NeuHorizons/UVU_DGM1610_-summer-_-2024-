using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Public variables that can be set in the Unity Editor
    public GameObject[] animalPrefabs; // Array to store animal prefab GameObjects
    public float startDelay = 2f; // Delay before the first animal spawns
    public float spawnInterval = 1.5f; // Interval between animal spawns

    // Private variables
    private float spawnRangeX = 20f; // Range for random X position for spawning
    private float spawnPosZ = 20f; // Fixed Z position for spawning

    // Start is called before the first frame update
    void Start()
    {
        // Call the SpawnRandomAnimal method repeatedly after a delay
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        // Code to update each frame can be added here if needed
    }

    // Method to spawn a random animal at a random X position
    void SpawnRandomAnimal()
    {
        // Generate a random index to select an animal prefab
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        // Generate a random X position within the specified range
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        // Instantiate the selected animal prefab at the generated position with its original rotation
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
