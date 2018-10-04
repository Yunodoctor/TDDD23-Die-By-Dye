using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossController : MonoBehaviour {

	public int curHealth;
	public int damage2Player; 
	private float timeBtwDamage = 1.5f;
	private Player player;

	public Transform endPoint;
	public float speed;
	private int current;

	public Slider healthBar;

	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
	}

	// Update is called once per frame
	void Update () 
	{
		if(transform.position != endPoint.position)
		{
			Vector2 pos = Vector2.MoveTowards(transform.position, endPoint.position, speed* Time.deltaTime);
			GetComponent<Rigidbody2D>().MovePosition(pos);
		}

		if (transform.position == endPoint.position) 
		{
			Destroy(gameObject);
		}

		//give the player some time to recover before taking anymore damage
		if (timeBtwDamage > 0) 
		{
			timeBtwDamage -= Time.deltaTime;
		}
		healthBar.value = curHealth;
		//if boss take healt is zero
		if (curHealth <= 0)
		{
			//Instantiate(deathEffect, transform.position, Quaternion.identity);
			//ScoreManager.scoreValue += scorePoint;
			Destroy(gameObject);
			FindObjectOfType<WeaponSwitching>().rainbowWeapon();
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
		curHealth -= damage;
	}


}
