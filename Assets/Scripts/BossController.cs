using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour {

	public int health;
	public int damage2Player; 
	private float timeBtwDamage = 1.5f;
	private Player player;
	private Transform target; //Tillfälligt för att få rörelse
	float movementSpeed = 1f;

	void Start()
	{
		target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>(); //Tillfällig för att få rörelse
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
	}

	// Update is called once per frame
	void Update () 
	{
		//Tillfällig if-sats för att få rörelse
		if (Vector2.Distance(transform.position, target.position) > 3f)
		{
			transform.position = Vector2.MoveTowards(transform.position, target.position, movementSpeed * Time.deltaTime); //Move the enemies position towards the player position at a certain speed (from, to, speed). Time.deltaTime makes sure that the enemies won't run faster on a fast computer comparing to a slow
		}

		//give the player some time to recover before taking anymore damage
		if (timeBtwDamage > 0) 
		{
			timeBtwDamage -= Time.deltaTime;
		}
		//if boss take healt is zero
		if (health <= 0)
		{
			//Death effect when enemy die
			//Instantiate(deathEffect, transform.position, Quaternion.identity);
			//ScoreManager.scoreValue += scorePoint;
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.CompareTag("Player"))
		{
			if (timeBtwDamage <= 0) 
			{
				player.playerTakeDamage(1);
			}
		}

	}

	//Health decrease system
	public void bossTakeDamage(int damage)
	{
		health -= damage;
	}
}
