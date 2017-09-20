using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barricade : BaseAI {

	// Barricade unit, high health, no movement or attack
	void Start () {
		this.SetMovSpd (0);
		this.SetMaxHealth (50f);
		this.SetAtkDis (0);
		this.SetHealth (50f);
		this.SetAtkDmg (0);
		this.SetAtkCld (10000f);
		this.SetPriority (1);
	}
}