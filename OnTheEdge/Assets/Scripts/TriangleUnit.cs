using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleUnit : BaseAI {

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
		this.SetMovSpd (1f);
		this.SetAtkDis (.5f);
		this.SetMaxHealth (2f);
		this.SetHealth (2f);
		this.SetAtkDmg (1f);
		this.SetAtkCld (2f);
		this.SetPriority (1);
	}
}

