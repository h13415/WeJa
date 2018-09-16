using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stageSelect : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Transform transform = GetComponent<Transform>();
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.S)) {
			
			transform.RotateAround(Vector3.zero, Vector3.up, -90);
		}
	}
}
