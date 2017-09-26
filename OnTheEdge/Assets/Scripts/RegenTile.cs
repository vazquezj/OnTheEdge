using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegenTile : MonoBehaviour {

	//Variable to set heal rate per second
	float hPS = 10f;
	float timeLapsed = 0.0f;
	public ScoreManager scoreManager;

	void Awake ()
	{
		scoreManager = GetComponent <ScoreManager> ();
	}

	//Heals allies in the area each frame
	void OnTriggerStay2D(Collider2D other) {
		BaseAI unit = other.gameObject.GetComponent<BaseAI> ();
		Barricade barricade = other.gameObject.GetComponent<Barricade> ();
		if (unit != null && other.tag == this.tag && barricade == null && unit.GetHealth() > 0) {
			unit.SetHealth (unit.GetHealth () + (hPS * Time.deltaTime));
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
