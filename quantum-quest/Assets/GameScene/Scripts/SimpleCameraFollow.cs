using UnityEngine;

public class SimpleCameraFollow : MonoBehaviour
{
    public Transform quester; // Drag your Quester prefab here in the inspector
    public float followSpeed = 5f; // Adjust this value to change how fast the camera follows
    public Vector3 offset; // Adjust this if you want some offset from the Quester

    private void Update()
    {
        if (quester != null)
        {
            // Calculate the new position the camera should be in
            Vector3 desiredPosition = new Vector3(transform.position.x, quester.position.y, transform.position.z) + offset;

            // Smoothly interpolate between the camera's current position and the desired position
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, followSpeed * Time.deltaTime);

            // Set the camera's position to the new smoothed position
            transform.position = smoothedPosition;
        }
    }
}
