using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	public float startingHealth;
	public float currentHealth;
	//public Slider healthSlider;                    
	PlayerController playerController;

	void Awake ()
	{
		//anim = GetComponent <Animator> ();
		playerController = GetComponent <PlayerController> ();
		currentHealth = startingHealth;
	}

	/*public void TakeDamage (float amount)
	{
		currentHealth -= amount;
		//healthSlider.value = currentHealth;
	}*/
}
