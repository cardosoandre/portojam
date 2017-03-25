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
	private Transform pos;

	// Use this for initialization
	void Start () {

		GetComponent<MeshRenderer> ().enabled = false;

		action = parent.GetComponent<keyCodeScript> ().action;
		rb = GetComponent<Rigidbody> ();

		gm = GameObject.FindGameObjectWithTag ("GameManager").GetComponent<GameManager>();

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
			GetComponent<MeshRenderer> ().enabled = true;
			rb.AddForce (transform.up * 1600);
			Invoke ("Mesh", 0.2f);
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

	void Mesh(){
		GetComponent<MeshRenderer> ().enabled = false;
	}
}
