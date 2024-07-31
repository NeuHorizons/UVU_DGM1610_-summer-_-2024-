using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    // Speed at which the player will move
    public float speed = 5.0f;

    // Minimum x-axis position (left boundary)
    public float xMin = -10.0f;

    // Maximum x-axis position (right boundary)
    public float xMax = 10.0f;

    // Reference to the prefab to instantiate
    public GameObject prefab;

    // Position where the prefab will be instantiated
    public Transform instantiatePosition;

    // Time interval between spawns
    public float spawnInterval = 0.5f;

    // Coroutine reference
    private Coroutine spawnCoroutine;


    void Update()
    {
        // Get input from Horizontal axis (A/D keys or Left/Right arrow keys)
        float move = Input.GetAxis("Horizontal");

        // Calculate the new position based on input, speed, and time between frames
        Vector3 newPosition = transform.position + new Vector3(move, 0, 0) * speed * Time.deltaTime;

        // Clamp the new position's x value to stay within the xMin and xMax bounds
        newPosition.x = Mathf.Clamp(newPosition.x, xMin, xMax);

        // Update the player's position to the new clamped position
        transform.position = newPosition;

        // Start spawning objects when the Space key is held down
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spawnCoroutine = StartCoroutine(SpawnPrefab());
        }

        // Stop spawning objects when the Space key is released
        if (Input.GetKeyUp(KeyCode.Space))
        {
            StopCoroutine(spawnCoroutine);
        }
    }

    IEnumerator SpawnPrefab()
    {
        while (true)
        {
            // Instantiate the prefab at the specified position and rotation
            Instantiate(prefab, instantiatePosition.position, instantiatePosition.rotation);
            // Wait for the specified interval before spawning again
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}