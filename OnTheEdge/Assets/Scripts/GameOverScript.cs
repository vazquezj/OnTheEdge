using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour {

	SpriteRenderer gameOverSprite;

	void Start ()
	{
		//Reference to the gameObjectSprite for GameOver
		gameOverSprite = this.gameObject.GetComponent <SpriteRenderer> ();
	}

	void Update ()
	{
		//Instead of a key press, when the losing condition occurs
		if (Input.GetKeyDown (KeyCode.T))
		{
			//This will need to be where the losing condition is
			//Flips the bool for gameOverSprite visibility
			//This will need to change so GameOver can only be turned off upon losing
			gameOverSprite.enabled = !gameOverSprite.enabled;
		}
	}
}