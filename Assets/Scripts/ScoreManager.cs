using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public static int scoreValue = 0;
	Text score;


	// Use this for initialization
	void Start () {
		score = GetComponent<Text>();
		//score = 0;
	}

	// Update is called once per frame
	void Update () {
		Debug.Log ("TEN  POINTS");
		score.text = "Score: " + scoreValue;
	}
}
