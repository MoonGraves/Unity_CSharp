using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject EnemyGo; //tähän tulee kansion prefabs toi enemyGO
    public GameObject EnemyGo2;

    // Start is called before the first frame update

    float maxSpawnRateInSeconds = 0.5f; //saappuu peli ruutuun missä ajassa esim x-sekunnissa
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        Vector2 min = Camera.main.ViewportToWorldPoint ( new Vector2 (0,0));

        Vector2 max = Camera.main.ViewportToWorldPoint ( new Vector2 (1,1));

        GameObject anEnemey = (GameObject)Instantiate(EnemyGo);
        GameObject anEnemey2 = (GameObject)Instantiate(EnemyGo2);
        
        anEnemey.transform.position = new Vector2(Random.Range (min.x, max.x), max.y);
        anEnemey2.transform.position = new Vector2(Random.Range (min.x, max.x), max.y);

        //schedule next enemy
        ScheduleNextEnemySpawn();
    }

    //enemy saappuvat ihan randomeina 
    void ScheduleNextEnemySpawn()
    {
        float spawnInSeconds;
        
        if(maxSpawnRateInSeconds > 1f)
        {
            spawnInSeconds = Random.Range(1f, maxSpawnRateInSeconds);
        }

        else 
            spawnInSeconds = 1f;
        
        Invoke ("SpawnEnemy", spawnInSeconds);
    }

    void IncreaseSpawnRate()
    {
        if(maxSpawnRateInSeconds > 1f)
            maxSpawnRateInSeconds--;
        
        if(maxSpawnRateInSeconds == 1f)
            CancelInvoke("IncreaseSpawnRate");
    }

    //start enemy sapwner
    public void ScheduleENemySpawner()
    {
        //reset max spawn rate 
        maxSpawnRateInSeconds = 2.5f;

        Invoke("SpawnEnemy", maxSpawnRateInSeconds);

        //increase sapwn rate every 30s
        InvokeRepeating ("IncreaseSpawn", 0f, 30f);
    }

    //stop spawner
    public void UnscheduleEnemySpawner()
    {
        CancelInvoke("SpawnEnemy");
        CancelInvoke("IncreaseSpawnRate");
    }
}
