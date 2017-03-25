using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerScript : MonoBehaviour {

	public GameObject ball;

	// Use this for initialization
	void Start () {

		Ball ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Ball (){
		Instantiate (ball, transform.position, Quaternion.identity);
	}
}
