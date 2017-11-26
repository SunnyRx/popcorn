using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager 
{
	int score;

	public int Score {
		get { return score; }
		set { score = value; score = Mathf.Clamp(score, 0, score); }
	}

	// 0 solo 1 milti
	public int playMode = 0;

	private static GameManager instance = new GameManager();

	public static GameManager Instance {
		get {
			return instance;

		}
	}


	private GameManager() { }

}
	    

 

