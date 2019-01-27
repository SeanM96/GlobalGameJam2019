using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour {

	// Use this for initialization
	[SerializeField] private GameObject InstructionMenu;
	[SerializeField] private GameObject MainMenu;

	public void OpenInstructions()
	{
		Debug.Log("Opened Instructions");
		MainMenu.SetActive(false);
		InstructionMenu.SetActive(true);
	}

	public void CloseInstructions()
	{
		MainMenu.SetActive(true);
		InstructionMenu.SetActive(false);
	}
	
}
