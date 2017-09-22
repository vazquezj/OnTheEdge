using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This Script handles all the spawning for the player who is Defending
//Alex Bowling
//9/22/17


public class SpawnerForDefender : MonoBehaviour {

	public GameObject[] whatToSpawnPrefab;
	public GameObject[] spawnLocations;


	void Update(){

		//checks if keypade 1 is pressed
		if (Input.GetKeyDown (KeyCode.Keypad1)) {

			//Instantiates and object from whatToSpawnPrefabs array list at the position from SpawnLocations array
			Instantiate (whatToSpawnPrefab [0], spawnLocations[0].transform.position, Quaternion.identity);

			//when resources are added remove comment to have them spent for spawning.
			//resources --;

		}// if keypade 1 down end


		//checks if keypade 2 is pressed
		if (Input.GetKeyDown (KeyCode.Keypad2)) {

			//Instantiates and object from whatToSpawnPrefabs array list at the position from SpawnLocations array
			Instantiate (whatToSpawnPrefab [0], spawnLocations[0].transform.position, Quaternion.identity);

			//when resources are added remove comment to have them spent for spawning.
			//resources --;

		}// if keypade 2 down end


		//checks if keypade 3 is pressed
		if (Input.GetKeyDown (KeyCode.Keypad3)) {

			//Instantiates and object from whatToSpawnPrefabs array list at the position from SpawnLocations array
			Instantiate (whatToSpawnPrefab [0], spawnLocations[0].transform.position, Quaternion.identity);

			//when resources are added remove comment to have them spent for spawning.
			//resources --;

		}// if keypade 3 down end

	}//update end
}