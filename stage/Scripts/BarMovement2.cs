using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarMovement2 : MonoBehaviour {

	private Rigidbody rb;
	private Vector3 defaultPos;

	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody>();
		defaultPos = transform.position;
	}
	
	void FixedUpdate () {

		rb.MovePosition(new Vector3(defaultPos.x + 7 * Mathf.Sin(Time.time), defaultPos.y, defaultPos.z));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}