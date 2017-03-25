using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringManager : MonoBehaviour {

	public Queue<singleInput> inputQueue;

	// Use this for initialization
	void Start () {
		inputQueue = new Queue<singleInput>();
	}

	void addInputToQueue(singleInput key)
	{
		inputQueue.Enqueue(key);
	}

	// Update is called once per frame
	void Update () 
	{
		for (int i = 0; i < inputQueue.Count; i++) 
		{
			var input = inputQueue.Dequeue ();
			print (input);	//make spring that matches key fire
		}
	}
}