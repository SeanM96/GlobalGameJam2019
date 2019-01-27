using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextModifier : MonoBehaviour {

	// Use this for initialization
	private TextMeshProUGUI text;
	[SerializeField] private GameObject menuEntity;
	private Quaternion basePos;

	private void Start()
	{
		text = GetComponent<TextMeshProUGUI>();
		basePos = menuEntity.transform.rotation;

	}
	private void OnMouseOver()
	{
		text.color = Color.white;
		menuEntity.transform.rotation = new Quaternion(Input.mousePosition.x - 90,-Input.mousePosition.y, transform.rotation.z,transform.rotation.w);	
	}

	private void OnMouseExit()
	{
		text.color = Color.black;
		//menuEntity.transform.rotation = new Quaternion(basePos.x,basePos.y,basePos.z,basePos.w);
	}

}
