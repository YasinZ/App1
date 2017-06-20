using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartMainMenu()
    {
        SceneManager.LoadScene("Scenes/HomeScene");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Scenes/Main");
    }

    public void StartTutorial()
    {
        SceneManager.LoadScene("Scenes/Tutorial");
    }

    public void StartTD()
    {
        SceneManager.LoadScene("Scenes/MainMap");
    }
}
