using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dedoColor : MonoBehaviour {

	public GameObject pai;

	// Use this for initialization
	void Start () {

		GetComponent<MeshRenderer> ().material.color = pai.GetComponent<MeshRenderer> ().material.color;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
