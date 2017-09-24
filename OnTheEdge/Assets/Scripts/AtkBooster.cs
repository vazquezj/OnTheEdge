using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtkBooster : MonoBehaviour {

	//Timer to refresh atk boost to
	float boostTime = 10f;

	//Refreshes damage boost timer on all allies in the collider
	void OnTriggerStay2D(Collider2D other) {
		BaseAI unit = other.gameObject.GetComponent<BaseAI> ();
		if (other.tag == this.tag && unit != null) {
			unit.SetBoost (true);
			unit.SetBoostTime (boostTime);
			Debug.Log ("Boosted");
		}
	}
}
