using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public GameObject player; // The player object that the Enemy will chase
    public float speed; // The speed at which the Enemy will move towards the player
    public float distanceBetween; // The distance threshold for the Enemy to start moving towards the player

    private float distance; // The current distance between the Enemy and the player

    // Start is called before the first frame update
    void Start()
    {
        // Initialization code can go here if needed
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the distance between the Enemy and the player
        distance = Vector2.Distance(transform.position, player.transform.position);

        // Calculate the direction vector from the Enemy to the player
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize(); // Normalize the direction vector to get the direction without the magnitude

        // Calculate the angle in degrees between the direction vector and the x-axis
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // If the distance is less than the specified threshold, move towards the player
        if (distance < distanceBetween)
        {
            // Move the Enemy towards the player's position at the specified speed
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);

            // Rotate the Enemy to face the player
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }
    }
}
