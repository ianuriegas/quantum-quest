using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GoToEntryScene();
        }
    }

    public void GoToEntryScene()
    {
        SceneManager.LoadScene("EntryScene");
    }
}
