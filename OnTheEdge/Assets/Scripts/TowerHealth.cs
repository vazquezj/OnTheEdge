using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TowerHealth : MonoBehaviour {

	public static float health;

	void Awake ()
	{
		health = 10;
	}

	void Update ()
	{
		if (health <= 0)
		{
			Destroy (this.gameObject);
		}
	}

	public void TakeDamage (float amount)
	{
		health -= amount;
	}
}