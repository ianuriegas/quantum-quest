using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject platformPrefab;
    public int platformCount = 100;
    public Transform spriteTransform; // Reference to the sprite's transform

    private List<GameObject> platforms = new List<GameObject>(); // Store all platforms

    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < platformCount; i++)
        {
            spawnPosition.y += Random.Range(.5f, 2f);
            spawnPosition.x = Random.Range(-5f, 5f);
            GameObject platform = Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            platforms.Add(platform); // Add platform to the list
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject platform in platforms)
        {
            if (platform != null && platform.transform.position.y < spriteTransform.position.y - 10)
            {
                // Instead of destroying, consider deactivating and reusing the platform
                Destroy(platform);
            }
        }
    }
}
