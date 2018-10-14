using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class moviePlay : MonoBehaviour {

    public MovieTexture movie;
    
	// Use this for initialization
	void Start () {
        GetComponent<RawImage>().texture = movie as MovieTexture;
        movie.Play();
    }
	
	// Update is called once per frame
	void Update () {
            //Renderer r = GetComponent<Renderer>();
            //MovieTexture movie = (MovieTexture)r.material.mainTexture;

              //  movie.Play();
        }
    }