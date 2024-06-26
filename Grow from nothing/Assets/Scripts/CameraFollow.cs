using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraSizeChanger : MonoBehaviour
{
    public float newSize = 5.0f; // Set the desired camera size here

    private Camera cameraComponent;

    public Transform targetObject; // The object whose size we're checking

    public float maxSizeThreshold = 5f; // The size threshold

    public float maxSizeThreshold2 = 10f; // The size threshold


    private Camera mainCamera;

    private bool conditionSatisfied1 = false;
    private bool conditionSatisfied2 = false;


    private void Start()
    {
        cameraComponent = GetComponent<Camera>(); // Get the Camera component attached to the GameObject
        UpdateCameraSize();
        mainCamera = Camera.main;
    }

    private void Update()
    {



        if (!conditionSatisfied1)
        {
            // Your condition here
            if (targetObject.localScale.magnitude > maxSizeThreshold)
            {
                Debug.Log("Condition satisfied!");
                // Perform actions that should only happen once

                newSize += 4.0f; // Increase size by 1 unit
                UpdateCameraSize();

                // Set the flag to true so the condition won't trigger again
                conditionSatisfied1 = true;
            }
        }



        if (!conditionSatisfied2)
        {
            // Your condition here
            if (targetObject.localScale.magnitude > maxSizeThreshold2)
            {
                Debug.Log("Condition satisfied!");
                // Perform actions that should only happen once

                newSize += 4.0f; // Increase size by 1 unit
                UpdateCameraSize();

                // Set the flag to true so the condition won't trigger again
                conditionSatisfied2 = true;
            }
        }






    }

    private void UpdateCameraSize()
    {
        cameraComponent.orthographicSize = newSize;
    }
}