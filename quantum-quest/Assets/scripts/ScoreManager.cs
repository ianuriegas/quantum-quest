using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Camera mainCamera; // Drag your Main Camera here
    public Text scoreText;    // Drag your UI Text here

    private float initialYPosition;
    private float maxScore;

    private void Start()
    {
        if (mainCamera != null)
        {
            initialYPosition = mainCamera.transform.position.y;
            maxScore = 0; // Initial score
        }
    }

    private void Update()
    {
        if (mainCamera != null)
        {
            // Calculate the score based on how much the camera has moved upwards
            float currentScore = mainCamera.transform.position.y - initialYPosition;

            // Update maxScore if the current score is higher
            if (currentScore > maxScore)
            {
                maxScore = currentScore;
            }

            // Update the UI Text with the max score
            scoreText.text = "Score: " + Mathf.FloorToInt(maxScore).ToString();
        }
    }
}
