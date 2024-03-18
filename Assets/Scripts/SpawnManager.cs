using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20f;
    private float spawnPosZ = 20;
    
    private float spawnRangeY = 20f;
    private float spawnPosX = 20;


    private float startDelay = 2;
    private float spawnInterval = 1.5f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        //genera un número aleatorio en un rango (Inicio del rango, tope del rango)
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        //Escoge si spawnea arriba o a los lados
        float selectUpOrNext = Random.value < 0.5f ? 1 : 2;

        if(selectUpOrNext == 1)
        {
            Vector3 spawnPositionX = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            
            //instancia un prefab (nombre del prefab a instanciar, position, rotation)
            Instantiate(animalPrefabs[animalIndex], spawnPositionX, animalPrefabs[animalIndex].transform.rotation);
        }else 
        {            
            //Escoge al azar entre spawnear en X positivo o X negativo
            float selectRightOrLeft = Random.value < 0.5f ? -spawnPosX : spawnPosX;
            Vector3 spawnPositionZ = new Vector3(selectRightOrLeft, 0, Random.Range(-spawnRangeY, spawnRangeY));


            if (selectRightOrLeft > 0)
            {
                Quaternion rotation = Quaternion.Euler(0, -90, 0);
                Instantiate(animalPrefabs[animalIndex], spawnPositionZ, rotation);
            }
            else
            {
                Quaternion rotation = Quaternion.Euler(0, 90, 0);
                Instantiate(animalPrefabs[animalIndex], spawnPositionZ, rotation);
                
            }
        }

    }
}
