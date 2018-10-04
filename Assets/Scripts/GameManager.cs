using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 2f;

    [SerializeField]
    private GameObject GameOverUI;

    public void EndGame()
    {
        GameOverUI.SetActive(true);
        //Time.timeScale = 0f;
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
        }
    }

    public void Quit()
    {
        Debug.Log("APPLICATION QUIT!");
        Application.Quit();
    }
}
