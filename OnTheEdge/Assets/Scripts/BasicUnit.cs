using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicUnit : BaseAI {

	// Use this for initialization
	void Start () {
		this.SetMovSpd (.4f);
		this.SetAtkDis (.5f);
		this.SetMaxHealth (10f);
		this.SetHealth (10f);
		this.SetAtkDmg (5f);
		this.SetAtkCld (2f);
		this.SetPriority (1);
	}
}
