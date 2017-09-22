using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtkBooster : MonoBehaviour {

	//Variable used for attack boost
	float boost = 5;

	//Adds damage bonus to ally on entering the collider
	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log ("Test");
		BaseAI unit = other.gameObject.GetComponent<BaseAI> ();
		if (other.tag == this.tag && unit != null) {
			Debug.Log ("Boosted");
			unit.SetAtkDmg (unit.GetAtkDmg () + boost);
		}
	}

	//Removes bonus upon leaving the collider
	void OnTriggerExit2D(Collider2D other) {
		Debug.Log ("test");
		BaseAI unit = other.gameObject.GetComponent<BaseAI> ();
		if (other.tag == this.tag && unit != null) {
			unit.SetAtkDmg (unit.GetAtkDmg () - boost);
		}
	}
}
