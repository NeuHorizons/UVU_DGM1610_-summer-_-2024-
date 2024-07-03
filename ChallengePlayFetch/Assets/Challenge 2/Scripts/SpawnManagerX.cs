using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs; // Array to store ball prefab GameObjects

    private float spawnLimitXLeft = -22; // Left boundary for random X position for spawning
    private float spawnLimitXRight = 7; // Right boundary for random X position for spawning
    private float spawnPosY = 30; // Fixed Y position for spawning

    private float startDelay = 1.0f; // Initial delay before the first spawn

    // Start is called before the first frame update
    void Start()
    {
        // Start the spawning coroutine
        StartCoroutine(SpawnRandomBallWithRandomInterval());
    }

    // Coroutine to spawn random balls at random intervals
    private IEnumerator SpawnRandomBallWithRandomInterval()
    {
        // Wait for the initial start delay
        yield return new WaitForSeconds(startDelay);

        while (true)
        {
            // Generate a random spawn interval between 3 and 5 seconds
            float spawnInterval = Random.Range(3.0f, 5.0f);

            // Call the method to spawn a random ball
            SpawnRandomBall();

            // Wait for the random spawn interval before spawning the next ball
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    // Method to spawn a random ball at a random X position at the top of the play area
    private void SpawnRandomBall()
    {
        // Generate a random ball index to select a ball prefab
        int ballIndex = Random.Range(0, ballPrefabs.Length);

        // Generate a random X position within the specified range
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // Instantiate the selected ball prefab at the generated position with its original rotation
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }
}
