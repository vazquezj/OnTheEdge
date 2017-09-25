using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

	public static int score;
	public static int lines;
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
			lines += 1;
		}
		if (Input.GetKeyDown (KeyCode.KeypadMinus))
		{
			lines -= 1;
		}
	}

	void OnGUI ()
	{
		GUI.skin = myGUISkin;
		GUI.Label (new Rect (50, 50, 300, 100), "SCORE: " + score);
		GUI.Label (new Rect (50, 150, 400, 100), "LINES: " + lines);
	}
}