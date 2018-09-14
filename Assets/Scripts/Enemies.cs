﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour {

    public float movementSpeed; //To control how fast the enemie chases the player
	public int health; //Enemy total health
    private Transform target; //Holds the gameObject the enemies are chasing

	public GameObject deathEffect; //Ifall vi vill ha det

    //Enemy following player
    void Start () {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		//Enemy moving towards player
        transform.position = Vector2.MoveTowards(transform.position, target.position, movementSpeed*Time.deltaTime); //Move the enemies position towards the player position at a certain speed (from, to, speed). Time.deltaTime makes sure that the enemies won't run faster on a fast computer comparing to a slow

		//If the enemy takes damage, destroy object
		if(health <= 0){
			//Instantiate (deathEffect, transform.position, Quaternion.identity); //Ifall vi vill ha en cool effekt när fienden dör
			Destroy(gameObject);
		}
	}

	//Health decrease system
	public void TakeDamage(int damage){
		health -= damage;
	}
}
