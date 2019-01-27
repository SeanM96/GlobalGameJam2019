using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour {

	// Use this for initialization
	public void LoadMainScene()
	{
		SceneManager.LoadScene("SampleScene");
	}

	public void QuitGame()
	{
		Application.Quit();
	}
}
