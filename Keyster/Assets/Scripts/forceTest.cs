using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forceTest : MonoBehaviour {

	private Rigidbody rb; 
	private KeyCode action;
	public GameObject parent;
	private Team team;
	private Team enemy;
	private GameManager gm;

	// Use this for initialization
	void Start () {

		action = parent.GetComponent<keyCodeScript> ().action;
		rb = GetComponent<Rigidbody> ();

		gm = GameObject.FindGameObjectWithTag ("GameManager").GetComponent<GameManager>();

		while (gm.teamONE == null);

		if (gm.teamONE.keys.Contains (action))
		{
			team = gm.teamONE;
			enemy = gm.teamTWO;
		} else 
		{
			team = gm.teamTWO;
			enemy = gm.teamONE;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (action)) {
			rb.AddForce (transform.up * 1500);
		}
	}
		
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag ("ball")) {
			team.numberOfTouches++;
			enemy.numberOfTouches = 0;

			if (gm.maxNumOfTouches < team.numberOfTouches)
			{
				gm.Score (enemy.id);
			}
		}
	}

	void OnCollision(Collision other){
		other.gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.right * 20);
	}
}
