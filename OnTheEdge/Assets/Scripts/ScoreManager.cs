using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

	public static int attackerScore;
	public static int attackerLines;
	public static int defenderScore;
	public static int defenderLines;
	public static int attackerLinesPerSec;
	public static int defenderLinesPerSec;
	public GUISkin myGUISkin;
	float timeLapsed = 0.0f;
	bool buttonLeft = false;
	bool buttonRight = false;
	public Texture2D myTexture;

	void Awake ()
	{
		attackerScore = 0;
		attackerLines = 0;
		defenderScore = 0;
		defenderLines = 0;
		attackerLinesPerSec = 0;
		defenderLinesPerSec = 0;
	}

	void OnGUI ()
	{
		GUI.skin = myGUISkin;
		GUI.Label (new Rect (50, 50, 400, 100), "ATTACKER SCORE: " + attackerScore);
		GUI.Label (new Rect (50, 100, 400, 100), "ATTACKER LINES: " + attackerLines);
		GUI.Label (new Rect (50, 150, 400, 100), "ATTACKER L/S: " + attackerLinesPerSec);
		GUI.Label (new Rect (1300, 50, 400, 100), "DEFENDER SCORE: " + defenderScore);
		GUI.Label (new Rect (1300, 100, 400, 100), "DEFENDER LINES: " + defenderLines);
		GUI.Label (new Rect (1300, 150, 400, 100), "DEFENDER L/S: " + defenderLinesPerSec);
		if (GUI.Button (new Rect (50, 900, 300, 50), "CLICK FOR LINES"))
			buttonLeft = true;
		if (GUI.Button (new Rect (350, 900, 300, 50), "CLICK FOR LINES"))
			buttonRight = true;
		GUI.Box (new Rect (1300, 875, 400, 80), myTexture);
	}

	void  Update()
	{
		timeLapsed += Time.deltaTime;
		if (timeLapsed >= 1.0f) {
			attackerLines = attackerLines + attackerLinesPerSec;
			timeLapsed = 0.0f;
		}
		if (buttonLeft == true && buttonRight == true)
		{
			attackerLines++;
			defenderLines++;
			buttonLeft = false;
			buttonRight = false;
		}
	}
}