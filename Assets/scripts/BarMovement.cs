using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarMovement : MonoBehaviour {

	public float stroke = 15;
	
	private Rigidbody rb;

	void Start () {

		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate () {

		rb.velocity = new Vector3(0, stroke * Mathf.Cos(Time.time), 0);
	}
}
