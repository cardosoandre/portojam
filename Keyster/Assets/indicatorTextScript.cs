using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class indicatorTextScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

		GetComponent<TextMesh>().text = GetComponentInParent<keyCodeScript> ().action.ToString ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
