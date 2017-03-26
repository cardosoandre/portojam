using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyCodeScript : MonoBehaviour {

	public KeyCode action;
	private Color originalColor;
	private Color targetColor;
	private bool broken;


	// Use this for initialization
	void Start () {
		originalColor = gameObject.GetComponent<MeshRenderer> ().material.color;
		targetColor = originalColor;
		broken = false;
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<MeshRenderer> ().material.color = targetColor;
	}

	public void Disable()
	{
		broken = true;
		targetColor = Color.gray;
		gameObject.GetComponentInChildren<forceTest> ().Disable ();
	}

	public void Blink()
	{
		gameObject.GetComponent<MeshRenderer> ().material.color = Color.white;
		Invoke ("ReturnToNormalColor", 0.3f);
	}

	void ReturnToNormalColor()
	{
		gameObject.GetComponent<MeshRenderer> ().material.color = originalColor;
	}

	void OnCollisionEnter(Collision other)
	{
		
	}

	void OnTriggerStay(Collider other)
	{
		if (other.gameObject.CompareTag ("ball")) {

			if (broken) 
			{
				Blink ();
				other.GetComponent<Rigidbody>().AddForce (transform.up * 300);
				other.GetComponent<Rigidbody>().AddForce (transform.forward * 80);
			}
		}
	}
}
