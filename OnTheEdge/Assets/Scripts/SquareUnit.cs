using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareUnit : BaseAI {

	//Attacks target
	public override void Attack(BaseAI enemy) {
		if (atkTar != null) {
			if (this.GetBoosted ()) {
				enemy.TakeDamage (this.GetAtkDmg () + 1);
			} else {
				enemy.TakeDamage (this.GetAtkDmg ());
			}
			if (enemy.GetHealth() <= 0)
				atkTar = null;
			this.SetCooldown(this.GetAtkCld());
		}
	}

	// Use this for initialization
	void Start () {
		this.SetMovSpd (.5f);
		this.SetAtkDis (.5f);
		this.SetMaxHealth (4f);
		this.SetHealth (4f);
		this.SetAtkDmg (2f);
		this.SetAtkCld (2f);
		this.SetPriority (1);
		this.SetSource (gameObject.GetComponent<AudioSource> ());
		this.manager = GameObject.Find ("GUI").GetComponent<ScoreManager>();
	}
}

