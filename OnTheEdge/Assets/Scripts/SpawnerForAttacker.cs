using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This Script handles all the spawning for the player who is Attacking
//Alex Bowling
//9/22/17


public class SpawnerForAttacker : MonoBehaviour {

	public GameObject[] whatToSpawnPrefab;
	public GameObject[] spawnLocations;


	void Update(){

		//checks if keypade 1 is pressed
		if (Input.GetKeyDown (KeyCode.Keypad1)) {

			//gets the mouse position for 2d
			Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			//sets the z position to 0
			mousePos.z = 0;
			//sets the y position to the bottom of the screen
			mousePos.y = -4;
			Debug.Log (mousePos.x);
			Debug.Log (mousePos.y);

			//Instantiates and object from whatToSpawnPrefabs array list at (mouse's x , -4.5, 0)
			Instantiate (whatToSpawnPrefab [0], mousePos, Quaternion.identity);

			//when resources are added remove comment to have them spent for spawning.
			//resources --;

		}// if keypade 1 down end


		//checks if keypade 2 is pressed
		if (Input.GetKeyDown (KeyCode.Keypad2)) {

			//gets the mouse position for 2d
			Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			//sets the z position to 0
			mousePos.z = 0;
			//sets the y position to the bottom of the screen
			mousePos.y = -4;
			Debug.Log (mousePos.x);
			Debug.Log (mousePos.y);

			//Instantiates and object from whatToSpawnPrefabs array list at (mouse's x , -4.5, 0)
			Instantiate (whatToSpawnPrefab [0], mousePos, Quaternion.identity);

			//when resources are added remove comment to have them spent for spawning.
			//resources --;

		}// if keypade 2 down end


		//checks if keypade 3 is pressed
		if (Input.GetKeyDown (KeyCode.Keypad3)) {

			//gets the mouse position for 2d
			Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			//sets the z position to 0
			mousePos.z = 0;
			//sets the y position to the bottom of the screen
			mousePos.y = -4;

			//Instantiates and object from whatToSpawnPrefabs array list at (mouse's x , -4.5, 0)
			Instantiate (whatToSpawnPrefab [0], mousePos, Quaternion.identity);

			//when resources are added remove comment to have them spent for spawning.
			//resources --;

		}// if keypade 3 down end

	}// update end
}