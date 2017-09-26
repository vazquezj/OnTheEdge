using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtkBooster : MonoBehaviour {

	//Timer to refresh atk boost to
	float boostTime = 10f;
	float timeLapsed = 0.0f;
	public ScoreManager scoreManager;

	void Awake ()
	{
		scoreManager = GetComponent <ScoreManager> ();
	}

	//Refreshes damage boost timer on all allies in the collider
	void OnTriggerStay2D(Collider2D other) {
		BaseAI unit = other.gameObject.GetComponent<BaseAI> ();
		if (other.tag == this.tag && unit != null) {
			unit.SetBoost (true);
			unit.SetBoostTime (boostTime);
			Debug.Log ("Boosted");
		}
	}

	void Update ()
	{
		timeLapsed += Time.deltaTime;
		if (timeLapsed >= 10.0f)
		{
			Destroy (this.gameObject);
		}
	}
}