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

	public void GameOver ()
	{
		gameOverSprite.enabled = true;
	}
}