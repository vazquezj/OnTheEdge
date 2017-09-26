using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TowerHealth : MonoBehaviour {

	public static float health;
	public SpriteRenderer gameOverSprite;

	void Awake ()
	{
		health = 10;
		gameOverSprite = this.gameObject.GetComponent <SpriteRenderer> ();
	}

	void Update ()
	{
		if (health <= 0)
		{
			Destroy (this.gameObject);
			SceneManager.LoadScene ("Main");
		}
	}

	public void TakeDamage (float amount)
	{
		health -= amount;
	}
}