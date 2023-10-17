using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class SwitchScene : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
        // If we are in the editor, stop play mode
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        // If we are in a built game, quit the application
        Application.Quit();
        #endif
    }
}
