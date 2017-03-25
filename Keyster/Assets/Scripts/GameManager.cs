using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team
{
	public int id;
	public int numberOfTouches;
	public int points;
	public List<KeyCode> keys;

	public Team(int tid, KeyCode[] teamKeys)
	{
		this.id = tid;
		this.numberOfTouches = 0;
		this.points = 0;
		this.keys = new List<KeyCode>();

		foreach (KeyCode key in teamKeys)
		{
			this.keys.Add(key);
		}
	}
}

public class GameManager : MonoBehaviour {

	public Team teamONE;
	public Team teamTWO;

	public int maxNumOfTouches;
	public KeyCode[] teamOneKeys;
	public KeyCode[] teamTwoKeys;

	void Awake()
	{
		teamONE = new Team (1, teamOneKeys);
		teamTWO = new Team (2, teamTwoKeys);
	}


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Reset ()
	{
		
	}

	public void Score(int tid)
	{
		if (tid == 1) {
			teamONE.points++;
		} else if (tid == 2) {
			teamTWO.points++;
		}

		Reset();
	}
}