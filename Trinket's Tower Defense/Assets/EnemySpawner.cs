using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [Header("References")]
    [SerializeField] private GameObject[] enemyPrefabs;


    [Header("Attributes")]
    [SerializeField] private int baseEnemies = 8;
    [SerializeField] private float enemiesPerSecond = 0.5f;
    [SerializeField] private float timeBetweenWaves = 5f;



    private int currentWave = 1;
    private float timeSinceLastSpawn;
    private int enemiesAlive;
    private int enemiesLeftToSpawn;
    private bool isSpawning = false;

    private void Start() {
        StartWave();
    }

    private void Update(){
        if (!isSpawning)
        return;

        timeSinceLastSpawn += Time.deltaTime;

        if(timeSinceLastSpawn >= (1f / enemiesPerSecond)){
            Debug.Log("Spawn Enemy");
            timeSinceLastSpawn = 0f;
        }
    }

    private void StartWave() {
        isSpawning = true;
        enemiesLeftToSpawn = baseEnemies;
    }

    private GameObject[] getRound(int roundNumber) {
        
        return null;
    }
}
