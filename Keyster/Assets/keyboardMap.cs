using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct input
{
	KeyCode key;
	int playerID;
}

public class keyboardMap : MonoBehaviour {

	public List<KeyCode> pressedKeys;

	// Use this for initialization
	void Start () {
		pressedKeys = new List<KeyCode>();
	}

	List<KeyCode> getPressedKeys()
	{
		var buffer = pressedKeys;
		pressedKeys.Clear ();

		return buffer;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			if(!pressedKeys.Contains(KeyCode.Alpha1))
			{
				pressedKeys.Add(KeyCode.Alpha1);
			}
		}

		if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			if(!pressedKeys.Contains(KeyCode.Alpha2))
			{
				pressedKeys.Add(KeyCode.Alpha2);
			}
		}

		if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			if(!pressedKeys.Contains(KeyCode.Alpha3))
			{
				pressedKeys.Add(KeyCode.Alpha3);
			}
		}

		if (Input.GetKeyDown(KeyCode.Alpha4))
		{
			if(!pressedKeys.Contains(KeyCode.Alpha4))
			{
				pressedKeys.Add(KeyCode.Alpha4);
			}
		}
	}
}
