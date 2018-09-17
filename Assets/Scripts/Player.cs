using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	//Initialization
	public float movementSpeed; //Players movement speed
	private Rigidbody2D rb2d; 
	private Vector2 moveVelocity;

    //Stats
    public int curHealth;
    public int maxHealth = 5;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();

        //Full health at the start of the game
        curHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {

		float moveHorizontal = Input.GetAxisRaw("Horizontal"); //Using GetAxisRaW to get a more robotic movement, no acceleration
		float moveVertical = Input.GetAxisRaw ("Vertical");

		//Use the two floats to create a new Vector2 variable movement
		Vector2 movementInput = new Vector2(moveHorizontal, moveVertical);

		//Call the AddForce function of our rigid body supplying movement multiplied by speed to move our player
		//rb2d.AddForce (movementInput*movementSpeed)
		//kommentera bort
		moveVelocity = movementInput.normalized*movementSpeed;
		
        if(curHealth > maxHealth)
        {
            curHealth = maxHealth;
        }

        //if(curHealth <= 0)
        //{
        //    Die();
        //}
	}

	//Another case: if we want the character to be kinetic
	void FixedUpdate()
	{
		rb2d.MovePosition (rb2d.position + moveVelocity * Time.fixedDeltaTime);
	}

    //void Die()
    //{
    //    //Restart
    //    Application.LoadLevel(Application.loadedLevel);
    //}

    public void playerTakeDamage(int dmg)
    {
        curHealth -= dmg;
    }

    public void playerTakeHealth(int hp)
    {
        curHealth += hp;
    }
}
