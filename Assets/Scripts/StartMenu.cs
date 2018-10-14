using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class StartMenu : MonoBehaviour {

    public AudioMixer audioMixer;
    public AudioMixer SFX;

	public void PlayGame () {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);		
	}

    public void SetVolume (float Volume)
    {
        audioMixer.SetFloat("Volume", Volume);
    }

    public void SetSFX(float SFXvolume)
    {
        SFX.SetFloat("SFX", SFXvolume);
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
