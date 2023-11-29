using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject pauseButton; // GameObject for the Pause sprite
    public GameObject continueButton; // GameObject for the Continue sprite

    void Start()
    {
        // Initially set the Continue button to be inactive
        continueButton.SetActive(false);
    }

    public void Pause()
    {
        pausePanel.SetActive(true);
        pauseButton.SetActive(false); // Hide Pause button
        continueButton.SetActive(true); // Show Continue button
        Time.timeScale = 0; // Pause the game
    }

    public void Continue()
    {
        pausePanel.SetActive(false);
        pauseButton.SetActive(true); // Show Pause button
        continueButton.SetActive(false); // Hide Continue button
        Time.timeScale = 1; // Resume the game
    }
}
