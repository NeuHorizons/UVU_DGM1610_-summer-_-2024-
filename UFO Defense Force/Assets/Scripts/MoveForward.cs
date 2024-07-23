using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Speed at which the object will move forward
    public float speed = 5.0f;

    void Update()
    {
        // Move the object forward based on its forward direction, speed, and time between frames
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}