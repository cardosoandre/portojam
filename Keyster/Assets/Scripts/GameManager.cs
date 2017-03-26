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
	public GameObject endGameText;

	public float time;
	public int winPoints;
	public int maxNumOfTouches;
	public KeyCode[] teamOneKeys;
	public KeyCode[] teamTwoKeys;

	void Awake()
	{
		teamONE = new Team (1, teamOneKeys);
		teamTWO = new Team (2, teamTwoKeys);
		endGameText.GetComponent<TextMesh>().text = "";
	}


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () 
	{
		time = time - Time.deltaTime;

		var timerLabel = GameObject.FindGameObjectWithTag ("timer");
		int seconds = (int)time;
		if (seconds < 0) 
		{
			seconds = 0;
		}

		timerLabel.GetComponent<TextMesh> ().text = seconds.ToString ();

		switch (winCond) 
		{
		case WinCondition.score:
			if (winPoints <= teamONE.points) 
			{
				endGameText.GetComponent<TextMesh>().text = "Team orange won!";
			} else if (winPoints <= teamTWO.points) 
			{
				endGameText.GetComponent<TextMesh>().text = "Team blue won!";
			} 
			break;
		case WinCondition.time:
			if (time < 0)
			{
				if (teamONE.points == teamTWO.points) 
				{
					endGameText.GetComponent<TextMesh>().text = "Draw!";
				} else if (teamTWO.points < teamONE.points) 
				{
					endGameText.GetComponent<TextMesh>().text = "Team orange won!";
				} else 
				{
					endGameText.GetComponent<TextMesh>().text = "Team blue won!";
				}
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