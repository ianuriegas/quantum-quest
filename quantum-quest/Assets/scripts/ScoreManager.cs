using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Camera mainCamera;
    public Text scoreText;

    private float initialYPosition;
    private float maxScore;
    private bool scoreChanged = true;

    private void Start()
    {
        if (mainCamera != null)
        {
            initialYPosition = mainCamera.transform.position.y;
            maxScore = 0;
        }
    }

    private void Update()
    {
        if (mainCamera != null)
        {
            float currentScore = mainCamera.transform.position.y - initialYPosition;

            // Dirty Flag HERE
            if (currentScore > maxScore)
            {
                maxScore = currentScore;
                scoreChanged = true; // Update score when a new max score is reached
            }

            if (currentScore < maxScore && scoreChanged)
            {
                scoreChanged = false; // Reset flag if camera moves down
            }

            // Update the UI Text with the max score if changed
            if (scoreChanged)
            {
                scoreText.text = "Score: " + Mathf.FloorToInt(maxScore).ToString();
                scoreChanged = false; // Reset the flag after updating the score
            }
        }
    }
}
