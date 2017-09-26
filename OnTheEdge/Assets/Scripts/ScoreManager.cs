using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

	public static int attackerScore;
	public static int attackerLines;
	public static int defenderScore;
	public static int defenderLines;
	public GUISkin myGUISkin;

	void Awake ()
	{
		attackerScore = 0;
		attackerLines = 0;
		defenderScore = 0;
		defenderLines = 0;
	}

	void OnGUI ()
	{
		GUI.skin = myGUISkin;
		GUI.Label (new Rect (50, 50, 400, 100), "ATTACKER SCORE: " + attackerScore);
		GUI.Label (new Rect (50, 150, 400, 100), "ATTACKER LINES: " + attackerLines);
		GUI.Label (new Rect (1300, 50, 400, 100), "DEFENDER SCORE: " + defenderScore);
		GUI.Label (new Rect (1300, 150, 400, 100), "DEFENDER LINES: " + defenderLines);

	}
}