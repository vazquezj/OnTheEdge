using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject[] whatToSpawnPrefab;
	public GameObject[] spawnLocations;

	void Update(){
		
		//checks if keypade 1 is pressed
		if (Input.GetKeyDown (KeyCode.Keypad1)) {

			//gets the mouse position
			Vector2 mousePos = Input.mousePosition;
			Debug.Log (mousePos.x);
			Debug.Log (mousePos.y);

			//Instantiates and object from whatToSpawnPrefabs array list at the position from SpawnLocations array
			Instantiate (whatToSpawnPrefab [0], spawnLocations[0].transform.position, Quaternion.identity);

			//resources --;

		}

	}
}
