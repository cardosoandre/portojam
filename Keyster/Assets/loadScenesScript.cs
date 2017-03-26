using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScenesScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LoadGame(){
		SceneManager.LoadScene ("GameScene");
	}

	public void LoadCredits(){
		SceneManager.LoadScene ("Credits");
		
	}

	public void LoadStart(){
		SceneManager.LoadScene ("Start Screen");
	}
}
