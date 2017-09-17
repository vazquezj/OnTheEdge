using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float translationSpeed;
	public float rotationSpeed;
	PlayerHealth playerHealth;

	void Awake ()
	{
		playerHealth = GetComponent <PlayerHealth> ();
	}

	/*void Start ()
	{
			Cursor.lockState = CursorLockMode.Locked;
	}*/

	void Update ()
	{
		float translation = Input.GetAxis ("Vertical") * translationSpeed;
		float rotation = Input.GetAxis ("Horizontal") * rotationSpeed;
		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;
		transform.Translate (rotation, translation, 0);

		/*if (Input.GetKeyDown ("escape"))
		{
				Cursor.lockState = CursorLockMode.None;
		}*/
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Player")
		{
			playerHealth.currentHealth -= 5;
		}
	}
}