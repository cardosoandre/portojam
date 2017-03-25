using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalScript : MonoBehaviour {

	public int score;
	public GameObject spawner;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		if(other.CompareTag("ball")){
			Destroy (other.gameObject);
			score++;
			spawner.GetComponent<spawnerScript> ().Ball ();
		}
	}
}
