using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarMovement : MonoBehaviour {

	private Rigidbody rb;
	private Vector3 defaultPos;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody>();
		defaultPos = transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate () {

		rb.MovePosition(new Vector3(defaultPos.x, defaultPos.y + 15 * Mathf.Sin(Time.time), defaultPos.z));

	}
}
