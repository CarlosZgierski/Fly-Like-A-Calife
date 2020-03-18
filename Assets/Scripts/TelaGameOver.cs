using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TelaGameOver : MonoBehaviour {

	// Use this for initialization

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
	
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
}
