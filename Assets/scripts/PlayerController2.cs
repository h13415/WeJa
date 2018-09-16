using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour {

	private Animator animator;
	private CharacterController characterController;

	// speed
	private Vector3 velocity;

	// jump force
	[SerializeField]
	private float jumpPower = 0.001f;

	void Start () {
		animator = GetComponent<Animator>();
		characterController = GetComponent<CharacterController>();
		velocity = Vector3.zero;
	}
	
	public float speed = 4;

	void FixedUpdate () {

		if (characterController.isGrounded) {
			velocity = Vector3.zero;
			var input = Vector3.zero;

			if(Input.GetKey(KeyCode.L)) {
				input.x = speed;
			}
			
			else if(Input.GetKey(KeyCode.H)) {
				input.x = -speed;
			}

			transform.LookAt(transform.position + input);
			velocity += input.normalized * 2;

			if(Input.GetKeyDown(KeyCode.K)) {
				velocity.y += jumpPower;
			}	

		}

		velocity.y += Physics.gravity.y * Time.deltaTime;
		characterController.Move(velocity * Time.deltaTime);

	}
}
