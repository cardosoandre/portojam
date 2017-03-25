using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forceTest : MonoBehaviour {

	private Rigidbody rb; 
	public KeyCode id;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (id)) {
			rb.AddForce (Vector3.up * 1100);	
		}
		
	}

	public void FireSpring()
	{
		rb.AddForce (Vector3.up * 1100);
	}

	void OnTriggerStay(Collider other){
		
	}
}
