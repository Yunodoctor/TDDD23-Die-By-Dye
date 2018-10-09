using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 2f;
    private ScoreManager theScoreManager;

    [SerializeField]
    private GameObject GameOverUI;
    [SerializeField]
    private GameObject RestartUI;

    private void Start()
    {
        theScoreManager = FindObjectOfType<ScoreManager>();
    }

    public void EndGame()
    {
        GameOverUI.SetActive(true);
    }

    public void Restart()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            //Invoke("Restart", restartDelay);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            FindObjectOfType<ScoreManager>().StartScore();

            RestartUI.SetActive(true);
            GameOverUI.SetActive(false);
        }
    }

    public void Quit()
    {
        Debug.Log("APPLICATION QUIT!");
        Application.Quit();
    }
}
