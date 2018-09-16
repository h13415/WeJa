using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public float speed = 10;

	void FixedUpdate () {
    
		float x = Input.GetAxis("Horizontal") * speed;

		Rigidbody rigidbody = GetComponent<Rigidbody>();

		rigidbody.AddForce(x, 0, 0);
	}
}
