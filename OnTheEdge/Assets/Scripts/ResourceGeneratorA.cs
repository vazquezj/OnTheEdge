using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceGeneratorA : MonoBehaviour {

	public ScoreManager scoreManager;

	void Awake ()
	{
		scoreManager = GetComponent <ScoreManager> ();
	}

	void Start ()
	{
		ScoreManager.attackerLinesPerSec += 1;
	}
}
