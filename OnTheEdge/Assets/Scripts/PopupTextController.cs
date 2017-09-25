using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupTextController : MonoBehaviour {

	private static Text popupText;
	private static GameObject canvas;

	public static void Initialize ()
	{
		canvas = GameObject.Find ("Canvas");
		popupText = Resources.Load <Text> ("Prefabs/PopupTextParent");
	}

	public static void CreateFloatingText (string text, Transform location)
	{
		Text instance = Instantiate (popupText);
		instance.transform.SetParent (canvas.transform, false);
		//instance.SetText (text);
	}
}