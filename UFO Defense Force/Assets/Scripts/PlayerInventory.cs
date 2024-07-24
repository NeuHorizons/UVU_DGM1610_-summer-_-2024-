using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    // Variable to keep track of the number of collected pickups
    private int inventoryCount = 0;

    // Method to handle the collection of a pickup
    public void CollectPickup()
    {
        // Increment the inventory count by 1
        inventoryCount++;

        // Log the updated inventory count to the console
        Debug.Log("Pickup collected! Current inventory: " + inventoryCount);
    }
}
