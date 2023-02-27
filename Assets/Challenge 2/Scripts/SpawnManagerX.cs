using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 25;
    private Vector3 spawnPos;
    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Спавн случайного шара на рандомной позиции
    void SpawnRandomBall ()
    {
        // Генерация рандомного индекса и случайной позиции 
        spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int randPos = Random.Range(0, ballPrefabs.Length);

        // Создание шара
        Instantiate(ballPrefabs[randPos], spawnPos, ballPrefabs[randPos].transform.rotation);
    }

}
