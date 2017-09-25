using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent (typeof (AudioSource))]

public abstract class BaseAI : MonoBehaviour {

	public ScoreManager scoreManager;

	//Public targets for attacking and general movement, as well as owner tag
	public Vector2 tarPos;
	public GameObject atkTar = null;

	//Public variables for SFX
	public AudioClip hit;
	public AudioClip mov;

	//Private variables
	float movSpd;
	float atkDis;
	float health;
	float maxHealth;
	float atkDmg;
	float atkCld;
	float timeToAttack = 0;
	float boostTime;
	int priority;
	bool boosted;
	AudioSource sfx;

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
		if (h <= maxHealth) {
			health = h;
		} else {
			health = maxHealth;
		}
	}
	public float GetMaxHealth() {
		return maxHealth;
	}
	public void SetMaxHealth(float h) {
		maxHealth = h;
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
	public void SetCooldown(float newCld) {
		timeToAttack = newCld;
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
	public void SetBoost(bool state) {
		boosted = state;
	}
	public bool GetBoosted() {
		return boosted;
	}
	public void SetBoostTime(float newTime) {
		boostTime = newTime;
	}
	public void SetSource(AudioSource source) {
		this.sfx = source;
	}

	void Awake ()
	{
		scoreManager = GetComponent <ScoreManager> ();
	}

	//Attacks target
	public abstract void Attack(BaseAI enemy);
	
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
				if (!sfx.isPlaying && Vector2.Distance (tarPos, gameObject.transform.position) > 0) {
					sfx.clip = mov;
					sfx.loop = true;
					//sfx.Play ();
				} else if (Vector2.Distance (tarPos, gameObject.transform.position) == 0){
					sfx.Stop ();
				}
			} else {
				if (Vector2.Distance (gameObject.transform.position, atkTar.transform.position) >= atkDis) {
					Vector2 enemyPos = atkTar.transform.transform.position;
					Vector2 offset = gameObject.transform.position.normalized * atkDis;
					enemyPos = enemyPos - offset;
					Vector2 newPos = Vector2.MoveTowards (gameObject.transform.position, enemyPos, movSpd * Time.deltaTime);
					gameObject.transform.position = newPos;
					if (!sfx.isPlaying) {
						sfx.clip = mov;
						sfx.loop = true;
						//sfx.Play ();
					}
				}

				//Attacks enemy if able
				if (atkTar != null && timeToAttack <= 0 && atkDis >= Vector2.Distance (gameObject.transform.position, atkTar.transform.position)) {
					BaseAI enemy = atkTar.GetComponent<BaseAI> ();
					Attack (enemy);
					sfx.clip = hit;
					sfx.loop = false;
					sfx.Play ();
				}
			}

			//Changes boost timer, and disables attack boost once it runs out
			boostTime -= Time.deltaTime;
			if (boostTime <= 0) {
				boosted = false;
			}

			//Temporary death effect
		} else {
			GameObject.Destroy (gameObject);
			ScoreManager.score += 1;
			ScoreManager.lines += 1;
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
		} else if (newEnemy != null && other.tag != this.tag && newEnemy.health > 0) {
			atkTar = other.gameObject;
		}
	}
}
