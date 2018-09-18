using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stageSelect : MonoBehaviour {

	private Vector3 derection;
	public float smooth = 1f;

	public float timeOut = 1f;
	private float timeElapsed;

	void Start () {

		Transform transform = GetComponent<Transform>();
		Debug.Log(transform.rotation);
	}

	void Update () {

		timeElapsed += Time.deltaTime;

		if(timeElapsed >= timeOut && Input.GetKeyDown(KeyCode.S)) {
			
			derection = Quaternion.Euler(0f, -90f, 0f) * transform.forward;

			Debug.Log(derection);
			
			timeElapsed = 0f;
		}

		Quaternion rotation = Quaternion.LookRotation(derection);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation,  Time.deltaTime * smooth);

		Debug.Log(timeElapsed);
	}
	
	
}
