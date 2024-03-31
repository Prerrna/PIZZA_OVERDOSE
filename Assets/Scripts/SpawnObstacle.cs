using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject obstacle;
    public float timeBetweenSpawn;
    private float spawnTime;

    void Update()
    {
        if (Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        // Get a random position within the camera's viewport
        Vector3 randomViewportPosition = new Vector3(Random.value, 1, Camera.main.nearClipPlane);
        Vector3 spawnPosition = Camera.main.ViewportToWorldPoint(randomViewportPosition);

        // Spawn obstacle at the calculated position
        GameObject newObstacle = Instantiate(obstacle, spawnPosition, Quaternion.identity);

        // Make obstacle a child of the SpawnObstacles object to move with the camera
        newObstacle.transform.SetParent(transform);
    }
}
