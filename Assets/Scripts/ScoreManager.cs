using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text score;
    public Text highScore;
    public static int scoreValue = 0;
    public int highScoreValue = 0;
    private int scorePoint = 10;

    // Use this for initialization
    void Start()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScoreValue = PlayerPrefs.GetInt("HighScore");
        }
    }

    public void StartScore()
    {
        scoreValue = 0;
    }

    // Update is called once per frame
    void Update()
    { 
        if (scoreValue > highScoreValue)
        {
            highScoreValue = scoreValue;
            PlayerPrefs.SetInt("HighScore", highScoreValue);
        }
    
        score.text = "Score: " + scoreValue;
        highScore.text = "High Score: " + highScoreValue;
    }
}
