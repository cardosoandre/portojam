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

	public enum WinCondition
	{
		time,
		score
	};

	public Team teamONE;
	public Team teamTWO;

	public WinCondition winCond;

	public float time;
	public int winPoints;
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
	void Update () 
	{
		time = time - Time.deltaTime;

		switch (winCond) 
		{
		case WinCondition.score:
			if (winPoints <= teamONE.points) 
			{
				print ("team 1 won!");
			} else if (winPoints <= teamTWO.points) 
			{
				print ("team 2 won!");
			} 
			break;
		case WinCondition.time:
			if (teamONE.points == teamTWO.points) 
			{
				print ("draw!");
			} else if (teamTWO.points < teamONE.points) 
			{
				print ("team 1 won!");
			} else 
			{
				print ("team 2 won!");
			}
			break;
		}
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

//		Reset();
	}
}