using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Declare variables to store rotation values
    float xRotation;  // Stores the rotation around the x-axis (up and down rotation)
    float yRotation;  // Stores the rotation around the y-axis (left and right rotation)

    // Sensitivity settings for mouse input
    public float sensX = 200f;  // Sensitivity for horizontal mouse movement
    public float sensY = 200f;  // Sensitivity for vertical mouse movement

    // Reference to the orientation object
    public Transform orientation;  // Orientation object for player rotation

    private void Start()
    {
        // Lock the cursor to the center of the screen and make it invisible
        Cursor.lockState = CursorLockMode.Locked;  // Keeps the cursor in the middle of the screen
        Cursor.visible = false;  // Hides the cursor
    }

    private void Update()
    {
        // Get mouse input and multiply by deltaTime and sensitivity
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;  // Horizontal mouse movement
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;  // Vertical mouse movement

        // Update rotation values based on mouse input
        yRotation += mouseX;  // Increase yRotation based on horizontal mouse movement
        xRotation -= mouseY;  // Decrease xRotation based on vertical mouse movement

        // Clamp the xRotation value to prevent over-rotation
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);  // Limits up and down rotation to 90 degrees

        // Rotate the camera based on the calculated rotation values
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);  // Applies rotation to the camera

        // Rotate an orientation object based on the yRotation (used for player orientation)
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);  // Applies left and right rotation to the orientation object
    }
}
