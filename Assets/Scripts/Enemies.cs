using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour {

    public float movementSpeed; //To control how fast the enemie chases the player
	public int health; //Enemy total health
    private Transform target; //Holds the gameObject the enemies are chasing
    private Player player;

    //Drop
    public bool HealthDrop;
    public GameObject HealthDropObject;
    private float dropRate = 0.5f;

    public GameObject deathEffect; //Ifall vi vill ha det

    //Enemy following player
    void Start () {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }
	
	// Update is called once per frame
	void Update () {
		//Enemy moving towards player
        transform.position = Vector2.MoveTowards(transform.position, target.position, movementSpeed*Time.deltaTime); //Move the enemies position towards the player position at a certain speed (from, to, speed). Time.deltaTime makes sure that the enemies won't run faster on a fast computer comparing to a slow

		//If the enemy takes damage, destroy object
		if(health <= 0){
			//Instantiate (deathEffect, transform.position, Quaternion.identity); //Ifall vi vill ha en cool effekt när fienden dör
			Destroy(gameObject);

            if(Random.Range(0f, 1f) <= dropRate)
            {
                Instantiate(HealthDropObject, transform.position, transform.rotation);
            }
		}
	}

	//Health decrease system
	public void enemyTakeDamage(int damage){
		health -= damage;
	}

    //Collider enters the trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            player.playerTakeDamage(1);
        }
    }
}
