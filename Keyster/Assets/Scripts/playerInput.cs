using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public struct singleInput
//{
//	KeyCode key;
//	int playerID;
//
//	public singleInput(KeyCode input, int player)
//	{
//		this.key = input;
//		this.playerID = player;
//	}
//}

public class playerInput : MonoBehaviour {

//	private Queue<singleInput> pressedKeys;
	public KeyCode[] possibleInputs;

	// Use this for initialization
	void Start () {
//		pressedKeys = new Queue<singleInput>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		GetInput ();
	}

	void GetInput()
	{
		//identify input, add it to pressedKeys;
	}
}
