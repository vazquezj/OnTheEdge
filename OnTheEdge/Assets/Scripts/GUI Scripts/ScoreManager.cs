using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

	public static int score;
	public int resource;
	public GUISkin myGUISkin;

	void Awake ()
	{
		score = 0;
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.KeypadEnter))
		{
			score += 1;
			resource += 1;
		}
		if (Input.GetKeyDown (KeyCode.KeypadMinus))
		{
			resource -= 1;
		}
	}

	void OnGUI ()
	{
		GUI.skin = myGUISkin;
		GUI.Label (new Rect (50, 50, 300, 100), "SCORE: " + score);
		GUI.Label (new Rect (50, 150, 400, 100), "RESOURCE: " + resource);
	}
}