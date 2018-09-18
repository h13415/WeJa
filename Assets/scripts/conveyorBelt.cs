using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conveyorBelt : MonoBehaviour {

	// On or Off
	public bool IsOn = false;

	// Consttant Velocity
	public float TargetDriveSpeed = 3.0f;

	// Current Velocity
	public float CurrentSpeed { get { return _currentSpeed; } }

	// Derection
	public Vector3 DriveDerection = Vector3.back;

	// Force
	[SerializeField] private float _forcePower = 50f;

	private float _currentSpeed = 0;
	private List<Rigidbody> _rigidbodies = new List<Rigidbody>();

	// Material Velocity
	[SerializeField]
	public float scrollSpeed = 0.5f;
	private Renderer rend;


	void Start () {

		rend = GetComponent<Renderer>();

	}
	
	void Update () {

		float offset = Time.time * scrollSpeed;
		rend.material.mainTextureOffset = new Vector2(offset, 0);
		
	}

	void FixedUpdate () {

		_currentSpeed = IsOn ? TargetDriveSpeed : 0;

		_rigidbodies.RemoveAll(r => r == null);

		foreach (var r in _rigidbodies) {
			
			var objectSpeed = Vector3.Dot(r.velocity, DriveDerection);

			if (objectSpeed < Mathf.Abs(TargetDriveSpeed)) {

				r.AddForce(DriveDerection * _forcePower, ForceMode.Acceleration);
			}
			
		}

	}

	void OnCollisionEnter(Collision collision) {

		var rigidBody = collision.gameObject.GetComponent<Rigidbody>();
		_rigidbodies.Add(rigidBody);

	}

	void OnCollisionExit(Collision collision) {

		var rigidBody = collision.gameObject.GetComponent<Rigidbody>();
		_rigidbodies.Remove(rigidBody);
	}

}
