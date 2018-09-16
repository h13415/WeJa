using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarMovement : MonoBehaviour {

	private Rigidbody rb;

	void Start () {

		rb = GetComponent<Rigidbody>();

	}

	void FixedUpdate () {

		rb.velocity = new Vector3(0, 15 * Mathf.Cos(Time.time), 0);

	}
}
