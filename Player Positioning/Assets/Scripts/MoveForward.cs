using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveForward : MonoBehaviour
{
    public float speed = 50f; // Speed at which the GameObject moves forward

    // Start is called before the first frame update
    void Start()
    {
        // Initialization code can be added here if needed
    }

    // Update is called once per frame
    void Update()
    {
        // Move the GameObject forward at a constant speed
        // Vector3.forward represents the forward direction relative to the GameObject
        // Time.deltaTime ensures the movement is frame rate independent
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
