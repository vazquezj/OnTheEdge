using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour {

	SpriteRenderer gameOverSprite;

	void Start ()
	{
		gameOverSprite = this.gameObject.GetComponent <SpriteRenderer> ();
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.T))
		{
			gameOverSprite.enabled = !gameOverSprite.enabled;
		}
	}
}