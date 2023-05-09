using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float spawnInterval = 1f;
    private float lastSpawnTime; 

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnDog();
        }
    }

    public bool CanSpawn(){
        if(Time.time - lastSpawnTime < spawnInterval){
            return false;
        }

        return true;
    }

    public void SpawnDog(){
        if(CanSpawn()){
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            lastSpawnTime = Time.time;
        }
        
    }
}
