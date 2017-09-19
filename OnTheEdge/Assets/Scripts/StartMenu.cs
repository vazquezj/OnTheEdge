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
		GUI.Box (new Rect (240, 80, 500, 400), "");
		GUI.Label (new Rect (450, 100, 100, 30), "ON THE EDGE", myFont);
	}
}