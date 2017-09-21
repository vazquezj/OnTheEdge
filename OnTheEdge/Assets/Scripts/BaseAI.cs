﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseAI : MonoBehaviour {

	//Public targets for attacking and general movement, as well as owner tag
	public Vector2 tarPos;
	public GameObject atkTar;

	//Private variables
	float movSpd;
	float atkDis;
	float health;
	float atkDmg;
	float atkCld;
	float timeToAttack = 0;
	int priority;

	//Getter/setter functions
	public float GetMovSpd() {
		return movSpd;
	}
	public void SetMovSpd(float newSpd) {
		movSpd = newSpd;
	}
	public float GetAtkDis() {
		return atkDis;
	}
	public void SetAtkDis(float newDis) {
		atkDis = newDis;
	}
	public float GetHealth() {
		return health;
	}
	public void SetHealth(float h) {
		health = h;
	}
	public float GetAtkDmg() {
		return atkDmg;
	}
	public void SetAtkDmg(float newDmg) {
		atkDmg = newDmg;
	}
	public float GetAtkCld() {
		return atkCld;
	}
	public void SetAtkCld(float newCld) {
		atkCld = newCld;
	}
	public void TakeDamage(float dmg) {
		health -= dmg;
	}
	public int GetPriority() {
		return priority;
	}
	public void SetPriority(int nP) {
		priority = nP;
	}

	//Attacks target
	public void Attack(BaseAI enemy) {
		enemy.TakeDamage (this.atkDmg);
		if (enemy.health <= 0)
			atkTar = null;
		timeToAttack = atkCld;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//Makes sure ai does not do anything when dead (for death animations etc)
		if (health > 0) {

			//Reduces attack cooldown
			if (timeToAttack > 0)
				timeToAttack -= Time.deltaTime;

			//Checks if this unit has a target, makes it move towards it if it does, else towards point
			if (atkTar == null) {
				//Moves towards the target point
				Vector2 newPos = Vector2.MoveTowards (gameObject.transform.position, tarPos, movSpd * Time.deltaTime);
				gameObject.transform.position = newPos;
			} else {
				if (Vector2.Distance (gameObject.transform.position, atkTar.transform.position) >= atkDis) {
					Vector2 enemyPos = atkTar.transform.transform.position;
					Vector2 offset = gameObject.transform.position.normalized * atkDis;
					enemyPos = enemyPos - offset;
					Vector2 newPos = Vector2.MoveTowards (gameObject.transform.position, enemyPos, movSpd * Time.deltaTime);
					gameObject.transform.position = newPos;
				}

				//Attacks enemy if able
				if (timeToAttack <= 0 && atkDis >= Vector2.Distance (gameObject.transform.position, atkTar.transform.position)) {
					BaseAI enemy = atkTar.GetComponent<BaseAI> ();
					Attack (enemy);
				}
			}
		}
	}

	//Changes target if a new enemy enters the trigger
	void OnTriggerStay2D(Collider2D other) {
		BaseAI newEnemy = other.gameObject.GetComponent<BaseAI> ();
		if (atkTar != null) {
			BaseAI enemy = atkTar.GetComponent<BaseAI> ();
			if (newEnemy != null && other.tag != this.tag && newEnemy.GetPriority () > enemy.GetPriority ()) {
				atkTar = other.gameObject;
			} 
		} else {
			atkTar = other.gameObject;
		}
	}
}