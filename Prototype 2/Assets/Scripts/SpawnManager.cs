using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private int startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    //Calls the "SpawnRandomAnimal" function with few seconds of delay at start and calls it in every few moments
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Spawns the animals randomly
    void SpawnRandomAnimal()
    {
        //A index which chooses a random animal prefab
        int animalIndex = Random.Range(0, animalPrefabs.Length);  

        //Randomly chooses a position to spawn the animals
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ); 

        //Copies animal prefabs randomly to spawn later
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
