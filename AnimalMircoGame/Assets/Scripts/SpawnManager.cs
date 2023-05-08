using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs; 
    public float spawnRangeX = 20.0f; //The possible range where animals can be spawned
    public float spawnPosZ = 20.0f; // The z position that animals are spawned at
    public float startDelay = 2.0f;
    public float spawnInterval = .5f;

    void Start() {
       InvokeRepeating("SpawnAnimal", startDelay, spawnInterval);
    }

    public void SpawnAnimal()
    {
        //Generate a random location to spawn the animal at
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        // Choose a random animal from the list to spawn
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        //Spawn that aninmal 
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
   
}
