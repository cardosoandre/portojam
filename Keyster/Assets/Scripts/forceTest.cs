using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forceTest : MonoBehaviour {

	private Rigidbody rb; 
	private KeyCode action;
	public GameObject parent;

	// Use this for initialization
	void Start () {

		action = parent.GetComponent<keyCodeScript> ().action;
		rb = GetComponent<Rigidbody> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (action)) {
			var gameM = GameObject.FindGameObjectWithTag ("GameManager");
			if (gameM.GetComponent<GameManager> ().teamONE.keys.Contains (action)) {
				if (gameM.GetComponent<GameManager> ().teamONE.numberOfTouches < gameM.GetComponent<GameManager> ().maxNumOfTouches)
				{
					rb.AddForce (transform.up * 1500);

					gameM.GetComponent<GameManager> ().teamONE.numberOfTouches++;
					gameM.GetComponent<GameManager> ().teamTWO.numberOfTouches = 0;
				}
			} else 
			{
				if (gameM.GetComponent<GameManager> ().teamTWO.numberOfTouches < gameM.GetComponent<GameManager> ().maxNumOfTouches) 
				{
					rb.AddForce (transform.up * 1500);

					gameM.GetComponent<GameManager> ().teamTWO.numberOfTouches++;
					gameM.GetComponent<GameManager> ().teamONE.numberOfTouches = 0;
				}
			}
		}
		
	}

	void OnTriggerStay(Collider other){
		
	}

	void OnCollision(Collision other){
		other.gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.right * 20);
	}
}
