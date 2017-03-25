using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forceTest : MonoBehaviour {

	private Rigidbody rb; 
	public KeyCode action;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (action)) {
			rb.AddForce (Vector3.up * 800);	
		}
		
	}

	void OnTriggerStay(Collider other){
		
	}
}
