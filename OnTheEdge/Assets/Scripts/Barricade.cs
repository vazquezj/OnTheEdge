using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barricade : BaseAI {

	//Attacks target
	public override void Attack(BaseAI enemy) {}

	// Barricade unit, high health, no movement or attack
	void Start () {
		this.SetMovSpd (0);
		this.SetMaxHealth (5f);
		this.SetAtkDis (0);
		this.SetHealth (5f);
		this.SetAtkDmg (0);
		this.SetAtkCld (10000f);
		this.SetPriority (1);
		this.SetSource (gameObject.GetComponent<AudioSource> ());
		//this.manager = GameObject.Find ("GUI").GetComponent<ScoreManager>();
	}
}