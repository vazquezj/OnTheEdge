﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareUnit : BaseAI {

	//Attacks target
	public override void Attack(BaseAI enemy) {
		if (atkTar != null) {
			enemy.TakeDamage (this.GetAtkDmg());
			if (enemy.GetHealth() <= 0)
				atkTar = null;
			this.SetCooldown(this.GetAtkCld());
			Debug.Log (enemy.GetHealth());
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
	}
}
