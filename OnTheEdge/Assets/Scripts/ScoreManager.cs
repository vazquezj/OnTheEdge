using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

	public static int score;
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
		}
	}

	void OnGUI ()
	{
		GUI.skin = myGUISkin;
		GUI.Label (new Rect (50, 50, 300, 100), "SCORE: " + score);
	}
}