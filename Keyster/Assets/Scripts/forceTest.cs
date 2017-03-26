using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forceTest : MonoBehaviour {

	private Rigidbody rb; 
	private KeyCode action;
	private Team team;
	private Team enemy;
	private GameManager gm;
	private Transform pos;
	public GameObject finger, text; 

	public bool ready;
	public GameObject parent;
	// Use this for initialization
	void Start () {

		ready = true;

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
		if (Input.GetKeyDown (action) && ready) {
			text.GetComponent<Animator> ().SetTrigger ("action");
			finger.GetComponent<Animator> ().SetTrigger ("action");
			rb.AddForce (transform.up * 1600);
			gameObject.GetComponentInParent<keyCodeScript> ().Blink ();
		}
	}
		
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag ("ball")) {
			ready = false;
		}
		if (other.gameObject.CompareTag ("playerBase")) {
			ready = true;
		}
	}

	public void Disable()
	{
		gm.Score (enemy.id);
		this.enabled = false;
	}

	void OnCollision(Collision other){
		other.gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.right * 20);
	}

	void Mesh(){
	}
}
