using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombScript : MonoBehaviour {

	public bool shouldExplode;
	public GameObject explosion;

	private bool grounded;
	private float time;

	// Use this for initialization
	void Start () {
		time = 10;
		shouldExplode = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (0 < time)
		{
			time = time - Time.deltaTime;
		} else 
		{
			shouldExplode = true;
		}	
	}

	void OnCollisionEnter(Collision other)
	{
		if (shouldExplode) 
		{
			if (other.gameObject.CompareTag ("Player")) 
			{
				Instantiate (explosion, gameObject.transform.position, Quaternion.identity);
				Destroy (gameObject);
			}
		}

	}
}
