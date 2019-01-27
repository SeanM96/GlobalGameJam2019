using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour {

	// Use this for initialization
	[SerializeField] private float speed;
	[SerializeField] Transform target;
     
	private Vector3 zAxis = new Vector3(0, 0, 1);
 
	void FixedUpdate () {
		transform.RotateAround(target.position, zAxis, speed); 
	}
}
