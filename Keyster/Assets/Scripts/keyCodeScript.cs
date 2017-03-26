using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyCodeScript : MonoBehaviour {

	public KeyCode action;
	private Color originalColor;

	// Use this for initialization
	void Start () {
		originalColor = gameObject.GetComponent<MeshRenderer> ().material.color;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Blink()
	{
		gameObject.GetComponent<MeshRenderer> ().material.color = Color.white;
		Invoke ("ReturnToNormalColor", 0.2f);
	}

	void ReturnToNormalColor()
	{
		gameObject.GetComponent<MeshRenderer> ().material.color = originalColor;
	}
}
