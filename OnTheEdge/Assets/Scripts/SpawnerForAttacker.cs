using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This Script handles all the spawning for the player who is Attacking
//Alex Bowling
//9/22/17


public class SpawnerForAttacker : MonoBehaviour {

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
		if (Input.GetKeyDown (KeyCode.Keypad1) && ScoreManager.attackerLines >= 10) {

			//gets the mouse position for 2d
			Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			//sets the z position to 0
			mousePos.z = 0;
			//sets the y position to the bottom of the screen
			mousePos.y = -4;
			//Debug.Log (mousePos.x);
			//Debug.Log (mousePos.y);

			//Instantiates and object from whatToSpawnPrefabs array list at (mouse's x , -4.5, 0)
			Instantiate (whatToSpawnPrefab [0], mousePos, Quaternion.identity);

			//when resources are added remove comment to have them spent for spawning.
			ScoreManager.attackerLines -= 10;

		}// if keypade 1 down end


		//checks if keypade 2 is pressed
		if (Input.GetKeyDown (KeyCode.Keypad2) && ScoreManager.attackerLines >= 20) {

			//gets the mouse position for 2d
			Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			//sets the z position to 0
			mousePos.z = 0;
			//sets the y position to the bottom of the screen
			mousePos.y = -4;
			//Debug.Log (mousePos.x);
			//Debug.Log (mousePos.y);

			//Instantiates and object from whatToSpawnPrefabs array list at (mouse's x , -4.5, 0)
			Instantiate (whatToSpawnPrefab [1], mousePos, Quaternion.identity);

			//when resources are added remove comment to have them spent for spawning.
			ScoreManager.attackerLines -= 20;

		}// if keypade 2 down end


		//checks if keypade 3 is pressed
		if (Input.GetKeyDown (KeyCode.Keypad3) && ScoreManager.attackerLines >= 5) {

			//gets the mouse position for 2d
			Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			//sets the z position to 0
			mousePos.z = 0;
			//sets the y position to the bottom of the screen
			mousePos.y = -4;

			//Instantiates and object from whatToSpawnPrefabs array list at (mouse's x , -4.5, 0)
			Instantiate (whatToSpawnPrefab [2], mousePos, Quaternion.identity);

			//when resources are added remove comment to have them spent for spawning.
			ScoreManager.attackerLines -= 5;

		}// if keypade 3 down end

		//checks if keypade 4 is pressed
		if (Input.GetKeyDown (KeyCode.Keypad4) && ScoreManager.attackerLines >= 30) {

			//gets the mouse position for 2d
			Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			//sets the z position to 0
			mousePos.z = 0;
			//sets the y position to the bottom of the screen
			mousePos.y = -3;
			mousePos.x = -8 + nextXval;
			nextXval++;

			//Instantiates and object from whatToSpawnPrefabs array list at (-10 ,-3 , 0)
			Instantiate (whatToSpawnPrefab [3], mousePos, Quaternion.identity);

			//when resources are added remove comment to have them spent for spawning.
			//ScoreManager.attackerLines -= 30;

		}// if keypade 4 down end

		//checks if keypade 5 is pressed
		if (Input.GetKeyDown (KeyCode.Keypad5) && ScoreManager.attackerLines >= 10) {

			//gets the mouse position for 2d
			Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			//sets the z position to 0
			mousePos.z = 0;

			//Instantiates and object from whatToSpawnPrefabs array list at (mouse's x , mouse's y, 0)
			Instantiate (whatToSpawnPrefab [4], mousePos, Quaternion.identity);

			//when resources are added remove comment to have them spent for spawning.
			ScoreManager.attackerLines -= 10;

		}// if keypade 5 down end

		//checks if keypade 6 is pressed
		if (Input.GetKeyDown (KeyCode.Keypad6) && ScoreManager.attackerLines >= 5) {

			//gets the mouse position for 2d
			Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			//sets the z position to 0
			mousePos.z = 0;

			//Instantiates and object from whatToSpawnPrefabs array list at (mouse's x , mouse's y, 0)
			Instantiate (whatToSpawnPrefab [5], mousePos, Quaternion.identity);

			//when resources are added remove comment to have them spent for spawning.
			ScoreManager.attackerLines -= 5;

		}// if keypade 6 down end

	}// update end
}