using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[]animalPrefabs; // [] is an array to store multiple objects/variables, animalPrefabs is the name given to the array
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    public float sideSpawnMinZ = 3;
    public float sideSpawnMaxZ = 15;
    public float sideSpawnX = 20;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnAnimalLeft", startDelay, spawnInterval);
        InvokeRepeating("SpawnAnimalRight", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        {
          
        }
    }

    void SpawnRandomAnimal() //randomly generate animal spawn position
    {
        int animalIndex = Random.Range(0,animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos,animalPrefabs[animalIndex].transform.rotation);
    }
    void SpawnAnimalLeft() //spawn an animal from the left
    {
        int animalIndex = Random.Range(0,animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-sideSpawnX, 0, Random.Range(sideSpawnMinZ,sideSpawnMaxZ));
            Vector3 rotation = new Vector3(0,90,0);
            Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }
    void SpawnAnimalRight() //spawn an animal from the right
    {
        int animalIndex = Random.Range(0,animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(sideSpawnX, 0, Random.Range(sideSpawnMinZ,sideSpawnMaxZ));
            Vector3 rotation = new Vector3(0,-90,0);
            Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }
}
