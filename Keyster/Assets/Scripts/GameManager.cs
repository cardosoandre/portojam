using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public struct Team
	{
		public int numberOfTouches;
		public int points;
		public List<KeyCode> keys;

		public Team(KeyCode[] teamKeys)
		{
			this.numberOfTouches = 0;
			this.points = 0;
			this.keys = new List<KeyCode>();

			foreach (KeyCode key in teamKeys)
			{
				this.keys.Add(key);
			}
		}
	}

	public Team teamONE;
	public Team teamTWO;

	public int maxNumOfTouches;
	public KeyCode[] teamOneKeys;
	public KeyCode[] teamTwoKeys;

	// Use this for initialization
	void Start () {
		teamONE = new Team (teamOneKeys);
		teamTWO = new Team (teamTwoKeys);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
