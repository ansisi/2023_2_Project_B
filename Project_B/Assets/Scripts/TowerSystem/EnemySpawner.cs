using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemyController[] enemisRoSpawn;
    public Transform spawnPoint;

    public float timeBtweenSpawns;
    public float spawnCounter;

    public int amountToSpawn = 15;
    // Start is called before the first frame update
    void Start()
    {
        spawnCounter = timeBtweenSpawns;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(amountToSpawn > 0)
        {
            spawnCounter -= Time.deltaTime;
            if(spawnCounter <= 0)
            {
                spawnCounter = timeBtweenSpawns;

                Instantiate(enemisRoSpawn[Random.Range(0, enemisRoSpawn.Length)], spawnPoint.position, spawnPoint.rotation);
                amountToSpawn -= 1;
            }
        }
    }
}
