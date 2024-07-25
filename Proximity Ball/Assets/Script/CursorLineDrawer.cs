using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorLineDrawer : MonoBehaviour
{
    public GameObject ball; // Assign the ball GameObject in the Inspector
    public LineRenderer lineRenderer; // Assign a LineRenderer in the Inspector
    public float maxDistance = 5f; // Maximum distance at which the line appears

    void Start()
    {
        // Ensure the LineRenderer is assigned
        if (lineRenderer == null)
        {
            Debug.LogError("LineRenderer not assigned!");
            return;
        }

        lineRenderer.positionCount = 2;
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;
        lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
    }

    void Update()
    {
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        cursorPosition.z = 0; // Ensure the cursor position is on the same plane as the ball

        float distance = Vector3.Distance(ball.transform.position, cursorPosition);

        if (distance <= maxDistance)
        {
            lineRenderer.enabled = true;
            lineRenderer.SetPosition(0, ball.transform.position);
            lineRenderer.SetPosition(1, cursorPosition);

            float lineThickness = Mathf.Lerp(0, 0.1f, 1 - (distance / maxDistance));
            lineRenderer.startWidth = lineThickness;
            lineRenderer.endWidth = lineThickness;
        }
        else
        {
            lineRenderer.enabled = false;
        }
    }
}
