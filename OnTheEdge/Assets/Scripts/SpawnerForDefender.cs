using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This Script handles all the spawning for the player who is Defending
//Alex Bowling
//9/22/17


public class SpawnerForDefender : MonoBehaviour {

	public GameObject[] whatToSpawnPrefab;
	public GameObject[] spawnLocations;
	private int nextXval;
	public ScoreManager scoreManager;

	void Awake ()
	{
		scoreManager = GetComponent <ScoreManager> ();
	}

	void Update(){

		//checks if keypade 1 is pressed
		if (Input.GetKeyDown (KeyCode.Alpha1) && ScoreManager.defenderLines >= 10) {

			//Instantiates and object from whatToSpawnPrefabs array list at the position from SpawnLocations array
			Instantiate (whatToSpawnPrefab [0], spawnLocations[0].transform.position, Quaternion.identity);

			//when resources are added remove comment to have them spent for spawning.
			ScoreManager.defenderLines -= 10;

		}// if keypade 1 down end


		//checks if keypade 2 is pressed
		if (Input.GetKeyDown (KeyCode.Alpha2) && ScoreManager.defenderLines >= 20) {

			//Instantiates and object from whatToSpawnPrefabs array list at the position from SpawnLocations array
			Instantiate (whatToSpawnPrefab [1], spawnLocations[0].transform.position, Quaternion.identity);

			//when resources are added remove comment to have them spent for spawning.
			ScoreManager.defenderLines -= 20;

		}// if keypade 2 down end


		//checks if keypade 3 is pressed
		if (Input.GetKeyDown (KeyCode.Alpha3) && ScoreManager.defenderLines >= 5) {

			//Instantiates and object from whatToSpawnPrefabs array list at the position from SpawnLocations array
			Instantiate (whatToSpawnPrefab [2], spawnLocations[0].transform.position, Quaternion.identity);

			//when resources are added remove comment to have them spent for spawning.
			ScoreManager.defenderLines -= 5;

		}// if keypade 3 down end

		//checks if keypade 4 is pressed
		if (Input.GetKeyDown (KeyCode.Alpha4) && ScoreManager.defenderLines >= 30) {

			//gets the mouse position for 2d
			Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			//sets the z position to 0
			mousePos.z = 0;
			//sets the y position to the bottom of the screen
			mousePos.y = 2;
			mousePos.x = 8 + nextXval;
			nextXval--;

			//Instantiates and object from whatToSpawnPrefabs array list at (-10 ,-3 , 0)
			Instantiate (whatToSpawnPrefab [3], mousePos, Quaternion.identity);

			//when resources are added remove comment to have them spent for spawning.
			ScoreManager.defenderLines -= 30;

		}// if keypade 4 down end

		//checks if keypade 5 is pressed
		if (Input.GetKeyDown (KeyCode.Alpha5) && ScoreManager.defenderLines >= 10) {

			//gets the mouse position for 2d
			Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			//sets the z position to 0
			mousePos.z = 0;

			//Instantiates and object from whatToSpawnPrefabs array list at (mouse's x , mouse's y, 0)
			Instantiate (whatToSpawnPrefab [4], mousePos, Quaternion.identity);

			//when resources are added remove comment to have them spent for spawning.
			ScoreManager.defenderLines -= 10;

		}// if keypade 5 down end

		//checks if keypade 6 is pressed
		if (Input.GetKeyDown (KeyCode.Alpha6) && ScoreManager.defenderLines >= 5) {

			//gets the mouse position for 2d
			Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			//sets the z position to 0
			mousePos.z = 0;

			//Instantiates and object from whatToSpawnPrefabs array list at (mouse's x , mouse's y, 0)
			Instantiate (whatToSpawnPrefab [5], mousePos, Quaternion.identity);

			//when resources are added remove comment to have them spent for spawning.
			ScoreManager.defenderLines -= 5;

		}// if keypade 6 down end

		//checks if keypade 7 is pressed
		if (Input.GetKeyDown (KeyCode.Alpha7) && ScoreManager.defenderLines >= 15) {

			//gets the mouse position for 2d
			Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			//sets the z position to 0
			mousePos.z = 0;

			//Instantiates and object from whatToSpawnPrefabs array list at (mouse's x , mouse's y, 0)
			Instantiate (whatToSpawnPrefab [6], mousePos, Quaternion.identity);

			//when resources are added remove comment to have them spent for spawning.
			ScoreManager.defenderLines -= 15;

		}// if keypade 7 down end

	}//update end
}