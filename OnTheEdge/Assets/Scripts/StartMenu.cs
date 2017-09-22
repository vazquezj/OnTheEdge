using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour {

	public GUIStyle myFont;
	public Texture2D myTexture;

	void Awake ()
	{
		Time.timeScale = 0.0f;
	}

	void OnGUI ()
	{
		//Start Menu Box and Text
		GUI.Box (new Rect (280, 80, 500, 400), "");
		GUI.Label (new Rect (480, 100, 100, 30), "ON THE EDGE", myFont);
		//Start Menu Button and Text
		GUI.Label (new Rect (480, 430, 100, 50), "START!", myFont);
		if (GUI.Button (new Rect (455, 430, 150, 50), ""))
		{
			Destroy (this);
		}
	}
}