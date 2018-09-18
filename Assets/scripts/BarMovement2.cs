using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarMovement2 : MonoBehaviour {

	private Rigidbody rb;

	void Start () {
		
		rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () {

		rb.velocity = new Vector3(0, 0, 7 * Mathf.Cos(Time.time));
	}
	
}