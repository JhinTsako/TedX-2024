using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject prefabToSpawn; // Reference to the prefab you want to spawn
    public float minSpawnInterval = 4f; // Minimum time interval between spawns
    public float maxSpawnInterval = 5f; // Maximum time interval between spawns

    void Start()
    {
        // Call the function to spawn the prefab randomly
        SpawnRandomPrefab();
    }

    void SpawnRandomPrefab()
    {
      
        float randomX = Random.Range(-17f, 22f);
        float randomY = Random.Range(20f, 25f);
        float randomZ = Random.Range(-14f, 15f);

        // Create a Vector3 with the random position
        Vector3 randomPosition = new Vector3(randomX, randomY, randomZ);

        // Instantiate the prefab at the random position
        GameObject newBrick=Instantiate(prefabToSpawn, randomPosition, Quaternion.Euler(new Vector3 (0, 90, 0)));
        newBrick.tag="Brick";

        // Generate a random time interval for the next spawn
        float randomSpawnInterval = Random.Range(minSpawnInterval , maxSpawnInterval);

        // Call the SpawnRandomPrefab function again after the random time interval
        Invoke("SpawnRandomPrefab", randomSpawnInterval);
    }
}