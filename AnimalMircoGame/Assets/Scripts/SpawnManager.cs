using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    public float spawnRangeX = 20.0f;
    public float spawnPosZ = 20.0f;

    private void Start()
    {
       StartCoroutine(SpawnRandomAnimal());
    }      

    IEnumerator SpawnRandomAnimal()
    {
        while (true){
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0 , spawnPosZ);
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
            yield return new WaitForSeconds(.4f);
        }
        
    }

}
