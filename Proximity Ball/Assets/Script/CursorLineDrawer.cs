using UnityEngine;

public class CursorLineDrawer : MonoBehaviour
{
    public GameObject ball; // Assign the ball GameObject in the Inspector
    public LineRenderer lineRenderer; // Assign a LineRenderer in the Inspector
    public float maxDistance = 5f; // Maximum distance at which the line appears
    public float baseLineWidth = 0.1f; // Base line width before scaling

    void Start()
    {
        if (lineRenderer == null)
        {
            Debug.LogError("LineRenderer not assigned!");
            return;
        }

        lineRenderer.positionCount = 2;
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

            float lineThickness = Mathf.Lerp(0, baseLineWidth, 1 - (distance / maxDistance));
            float scaledLineThickness = lineThickness * ball.transform.localScale.x; // Adjust line thickness based on ball's scale
            lineRenderer.startWidth = scaledLineThickness;
            lineRenderer.endWidth = scaledLineThickness;
        }
        else
        {
            lineRenderer.enabled = false;
        }
    }
}
