﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float translationSpeed;
	public float rotationSpeed;

	/*void Start ()
		{
			Cursor.lockState = CursorLockMode.Locked;
		}*/

	void Update ()
	{
		float translation = Input.GetAxis ("Vertical") * translationSpeed;
		float rotation = Input.GetAxis ("Horizontal") * rotationSpeed;
		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;
		transform.Translate (rotation, 0, translation);

		/*if (Input.GetKeyDown ("escape"))
		{
				Cursor.lockState = CursorLockMode.None;
		}*/
	}
}
