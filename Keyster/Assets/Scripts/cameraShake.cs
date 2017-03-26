using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraShake : MonoBehaviour {
	
	public float shakeAmount = 2f;
	public float shakeTime = 0.2f;

	bool isShaking = false;
	bool goalShake = false;
	private Vector3 originallocation;

	// Use this for initialization
	void Start () {

		originallocation = gameObject.transform.position;

	}

	// Update is called once per frame
	void FixedUpdate () {
	
		// BOMB SHAKE

		if (Input.GetKeyDown (KeyCode.Tab)) {
			shakeScreen ();
		}

		if (isShaking) {
			transform.position = originallocation + Random.insideUnitSphere * shakeAmount * Time.deltaTime;
		} else {
			transform.position = originallocation;
		}

	}

	public void shakeScreen() {
		isShaking = true;
		originallocation = transform.position;
		Invoke ("stopShake", shakeTime);

	}

	public void stopShake(){
		isShaking = false;
		goalShake = false;
	}

}

