using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This attribute ensures that the GameObject this script is attached to also has a CharacterController component.
[RequireComponent(typeof(CharacterController))]
public class FPSController : MonoBehaviour
{
    // Public variables that can be set in the Unity Editor
    public Camera playerCamera; // Reference to the player's camera
    public float walkSpeed = 6f; // Walking speed of the player
    public float runSpeed = 12f; // Running speed of the player
    public float jumpPower = 7f; // The force applied when the player jumps
    public float gravity = 10f; // Gravity force applied when the player is in the air

    public float lookSpeed = 2f; // Speed of camera rotation
    public float lookXLimit = 45f; // Limit of how much the player can look up or down

    // Crouching variables
    public float crouchSpeed = 3f; // Speed when the player is crouching
    public float crouchHeight = 1f; // Height of the player when crouching
    private float originalHeight; // Original height of the player

    // Wall-running variables
    public float wallRunSpeed = 8f; // Speed when the player is wall-running
    public float wallRunDuration = 1.5f; // Duration for which the player can wall-run
    public LayerMask wallRunLayerMask; // Layer mask to identify walls
    private bool isWallRunning = false; // Flag to check if the player is wall-running
    private float wallRunTimer = 0f; // Timer to track the wall-run duration

    // Private variables
    Vector3 moveDirection = Vector3.zero; // Direction in which the player is moving
    float rotationX = 0; // X-axis rotation for looking up and down

    public bool canMove = true; // Flag to enable or disable player movement
    private bool isCrouching = false; // Flag to check if the player is crouching

    // Reference to the CharacterController component
    CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {
        // Get the CharacterController component attached to the GameObject
        characterController = GetComponent<CharacterController>();
        // Lock the cursor to the center of the screen and make it invisible
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        // Store the original height of the CharacterController
        originalHeight = characterController.height;
    }

    // Update is called once per frame
    void Update()
    {
        #region Handles Movement
        // Calculate the forward and right vectors relative to the player's orientation
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        // Check if the player is holding the Left Shift key to run
        bool isRunning = Input.GetKey(KeyCode.LeftShift);
        // Determine the current speed based on whether the player is running or walking and moving forward or backward
        float curSpeedX = canMove ? (isRunning ? runSpeed : (isCrouching ? crouchSpeed : walkSpeed)) * Input.GetAxis("Vertical") : 0;
        // Determine the current speed based on whether the player is running or walking and moving left or right
        float curSpeedY = canMove ? (isRunning ? runSpeed : (isCrouching ? crouchSpeed : walkSpeed)) * Input.GetAxis("Horizontal") : 0;
        // Store the current vertical movement direction
        float movementDirectionY = moveDirection.y;
        // Calculate the new movement direction
        moveDirection = (forward * curSpeedX) + (right * curSpeedY);
        #endregion

        #region Handles Jumping
        // Check if the player pressed the Jump button, can move, and is on the ground
        if (Input.GetButton("Jump") && canMove && characterController.isGrounded && !isCrouching && !isWallRunning)
        {
            moveDirection.y = jumpPower; // Apply jump power
        }
        else
        {
            moveDirection.y = movementDirectionY; // Maintain current vertical movement direction
        }

        // Apply gravity when the player is not on the ground and not wall-running
        if (!characterController.isGrounded && !isWallRunning)
        {
            moveDirection.y -= gravity * Time.deltaTime;
        }
        #endregion

        #region Handles Crouching
        // Check if the 'C' key is pressed to toggle crouch state
        if (Input.GetKeyDown(KeyCode.C))
        {
            isCrouching = !isCrouching; // Toggle crouch state
            if (isCrouching)
            {
                characterController.height = crouchHeight; // Set height to crouch height
            }
            else
            {
                characterController.height = originalHeight; // Reset to original height
            }
        }
        #endregion

        #region Handles Wall Running
        // Check if the player can wall-run (not grounded and not already wall-running)
        if (canMove && !characterController.isGrounded && !isWallRunning)
        {
            RaycastHit hit;
            // Check for walls on the right or left side of the player using raycasting
            if (Physics.Raycast(transform.position, right, out hit, 1f, wallRunLayerMask) ||
                Physics.Raycast(transform.position, -right, out hit, 1f, wallRunLayerMask))
            {
                // Start wall running if a wall is detected
                isWallRunning = true;
                wallRunTimer = wallRunDuration; // Reset the wall run timer
            }
        }

        if (isWallRunning)
        {
            // Decrease the wall run timer while wall running
            wallRunTimer -= Time.deltaTime;
            if (wallRunTimer <= 0 || characterController.isGrounded)
            {
                // Stop wall running when the timer runs out or the player lands on the ground
                isWallRunning = false;
            }
            else
            {
                // Adjust movement direction for wall running
                moveDirection.y = 0; // Maintain the same height
                moveDirection = transform.forward * wallRunSpeed; // Move forward along the wall
            }
        }
        #endregion

        #region Handles Rotation
        // Move the player based on the calculated moveDirection
        characterController.Move(moveDirection * Time.deltaTime);

        if (canMove)
        {
            // Rotate the camera up and down
            rotationX += -Input.GetAxis("Mouse Y") * lookSpeed;
            rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit); // Clamp the vertical rotation
            playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
            // Rotate the player left and right
            transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeed, 0);
        }
        #endregion
    }
}
