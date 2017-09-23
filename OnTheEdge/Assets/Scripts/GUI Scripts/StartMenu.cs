using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour {

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
		GUI.Box (new Rect (50, 50, 1516, 810), "ON THE EDGE");
		//Start Menu Button and Text
		if (GUI.Button (new Rect (708, 600, 200, 100), "START!"))
		{
			Destroy (this);
		}
	}
}