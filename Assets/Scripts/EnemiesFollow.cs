using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesFollow : MonoBehaviour {

    public float movementSpeed; //To control how fast the enemie chases the player

    private Transform target; //Holds the gameObject the enemies are chasing

	// Use this for initialization
	void Start () {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector2.MoveTowards(transform.position, target.position, movementSpeed*Time.deltaTime); //Move the enemies position towards the player position at a certain speed (from, to, speed). Time.deltaTime makes sure that the enemies won't run faster on a fast computer comparing to a slow
	}
}
