using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 10f;
	public float smooth = 5f;
	private Vector3 derection;
	private Vector3 force;

	void Start () {

		Transform transform = GetComponent<Transform>();
	}


	void Update () {

		derection = Input.GetAxis("Horizontal") * Vector3.forward;
		force = derection * speed;
	}

	void FixedUpdate () {

		Rigidbody rigidbody = GetComponent<Rigidbody>();
		rigidbody.AddForce(force);
		
		if (derection.magnitude > 0.1) {

			Quaternion rotation = Quaternion.LookRotation(-derection);
        	transform.rotation = Quaternion.Lerp(transform.rotation, rotation,  Time.deltaTime * smooth);
		}
	}
}
