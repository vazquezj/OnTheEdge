using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour {

	public GUIStyle myFont;
	public GUISkin myGUISkin;

	void Awake ()
	{
		Time.timeScale = 0.0f;
	}

	void OnGUI ()
	{
		//Changes the GUI Skin
		GUI.skin = myGUISkin;
		//Start Menu Box and Text
		GUI.Box (new Rect (0, 0, 1920, 1080), "");
		GUI.Label (new Rect (560, 100, 300, 150 ), "ON THE EDGE", myFont);
		//Start Menu Button and Text
		GUI.Label (new Rect (660, 600, 300, 150), "START!", myFont);
		if (GUI.Button (new Rect (650, 600, 330, 110), ""))
		{
			Destroy (this);
		}
	}
}