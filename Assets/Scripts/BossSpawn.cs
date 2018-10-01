using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawn : MonoBehaviour {

	public GameObject[] bossSpawn;

	private float timeBtwSpawn;
	public float startTimeBtwSpawn;
	public float decreaseTime;
	public float minTime = 3f;

	// Update is called once per frame
	private void Update()
	{
		if (timeBtwSpawn <= 0)
		{
			int rand = Random.Range(0, bossSpawn.Length);
			Instantiate(bossSpawn[rand], transform.position, Quaternion.identity);
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
