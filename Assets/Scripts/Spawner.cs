using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemyPattern;

    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;

    // Update is called once per frame
    private void Update()
    {
        if (timeBtwSpawn <= 0)
        {

            int rand = Random.Range(0, enemyPattern.Length);
            Instantiate(enemyPattern[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn; //Wait x amount of seconds before another enemy spawn in game

            if (startTimeBtwSpawn > minTime)
            {
                startTimeBtwSpawn -= decreaseTime;//Time between spawns will be a little bit smaller next time an enemy spawns
            }
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
