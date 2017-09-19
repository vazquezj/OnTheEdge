using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour {

	public GUIStyle myFont;

	void Awake ()
	{
		Time.timeScale = 0.0f;
	}

	void OnGUI ()
	{
		GUI.Box (new Rect (156, 25, 500, 400), "");
		GUI.Label (new Rect (406, 50, 100, 50), "ON THE EDGE", myFont);
	}
}