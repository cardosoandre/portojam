using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerScript : MonoBehaviour {

	public GameObject ball;
	public float delta = 1.5f;  // Amount to move left and right from the start point
	public float speed = 2.0f; 

	private Vector3 pos;
	private float timer;

	// Use this for initialization
	void Start () {
		timer = 0;
		pos = gameObject.transform.position;
		Ball ();
		
	}
	
	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;
		Vector3 v = pos;
		v.x += delta * Mathf.Sin (Time.time * speed);
		v.z += (delta /2) * Mathf.Sin (Time.time * speed/2);
		transform.position = v;

		if (12 < timer) 
		{
			Ball ();
			timer = 0;
		}
			
	}

	public void Ball (){
		Instantiate (ball, transform.position, Quaternion.identity);
	}
}
