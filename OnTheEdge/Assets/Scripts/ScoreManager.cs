using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

	public static int score;
	public static int resource;
	public GUISkin myGUISkin;

	void Awake ()
	{
		//Score = 0 on awake
		score = 0;
	}

	void Update ()
	{
		//Updates Score and Resource
		if (Input.GetKeyDown (KeyCode.KeypadEnter))
		{
			//Add this to where an enemy unit dies
			score += 1;
			resource += 1;
		}
		//Updates Resource when the player buys a unit
		if (Input.GetKeyDown (KeyCode.KeypadMinus))
		{
			//Add this to where the player buys a unit
			resource -= 1;
		}
		if (resource < 0)
		{
			//Prevents the resource from going below 0
			resource = 0;
		}
	}

	void OnGUI ()
	{
		//Custom skin for GUI components
		GUI.skin = myGUISkin;
		//Text Labels for Score and Resource
		GUI.Label (new Rect (50, 50, 300, 100), "SCORE: " + score);
		GUI.Label (new Rect (50, 150, 400, 100), "RESOURCE: " + resource);
	}
}