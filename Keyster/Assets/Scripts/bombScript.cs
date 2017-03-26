using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombScript : MonoBehaviour {

	public bool shouldExplode;
	public GameObject explosion;

	private bool grounded;
	private float timer;
	private Color originalColor;

	// Use this for initialization
	void Start () {
		timer = 15;
		shouldExplode = false;
		originalColor = gameObject.GetComponent<MeshRenderer> ().material.color;
		Invoke ("Blink", 1f);
	}
	
	// Update is called once per frame
	void Update () {

		if (0 < timer)
		{
			timer = timer - Time.deltaTime;
		} else 
		{
			shouldExplode = true;
		}	
	}

	void Blink()
	{
		gameObject.GetComponent<MeshRenderer> ().material.color = Color.white;
		Invoke ("BlinkBack", 0.1f);

		if (8 < timer) 
		{
			Invoke ("Blink", 1f);
		} else if (3 < timer) 
		{
			Invoke ("Blink", 0.5f);
		} else if (0 < timer) 
		{
			Invoke ("Blink", 0.25f);
		} else
		{
			Invoke ("Red", 0.2f);
		}
	}

	void Red()
	{
		gameObject.GetComponent<MeshRenderer> ().material.color = Color.red;
	}

	void BlinkBack()
	{
		gameObject.GetComponent<MeshRenderer> ().material.color = originalColor;
	}

	void OnCollisionEnter(Collision other)
	{

	}

	void OnTriggerStay(Collider other)
	{
		if (other.gameObject.CompareTag ("ground")) {
			if (shouldExplode) {
				Instantiate (explosion, gameObject.transform.position, Quaternion.identity);
				other.gameObject.GetComponentInParent<keyCodeScript> ().Disable ();
				Destroy (gameObject);
			}

			timer = timer - 0.005f;
		} 
	}
}
