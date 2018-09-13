using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPoint : MonoBehaviour {

	public GameObject Enemy;
	
	// Update is called once per frame
	void Start () {
		Instantiate(Enemy, transform.position, Quaternion.identity);
	}
}
