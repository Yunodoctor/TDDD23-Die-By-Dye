using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public float movementSpeed;

	public Transform player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector2.MoveTowards (transform.position, player.position, movementSpeed*Time.deltaTime);
	}
}
