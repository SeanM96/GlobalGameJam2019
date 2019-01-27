using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCamera : MonoBehaviour
{
	[SerializeField] private Transform rocket;
	[SerializeField] private float distance;
	// Update is called once per frame
	void Update ()
	{
		transform.position = new Vector3(rocket.position.x, rocket.position.y, distance);
	}
}
