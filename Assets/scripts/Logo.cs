using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Logo : MonoBehaviour {

	// Use this for initialization
	void Start () {

		// delay 2f
		StartCoroutine(DelayMethod(2f));
		
	}

	IEnumerator DelayMethod(float waitTime) {

		yield return new WaitForSeconds(waitTime);
		SceneManager.LoadScene ("Title");
	}
	
	// Update is called once per frame
	void Update () {

		
		
	}
}
