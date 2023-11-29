using UnityEngine;

public class MusicPlayerMenu : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play(); // Start playing the music when the scene loads
    }
}
