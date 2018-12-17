using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	[Range(0.00001f,3)]
	float speed = 0.5f;

	void Update () {
		Vector3 velocity = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical")) * speed;
		transform.Translate (velocity);
		float rotation = 0;
		if (Input.GetKey (KeyCode.Q)) {
			rotation -= 5;
		}
		if (Input.GetKey (KeyCode.E)) {
			rotation += 5;
		}
		transform.Rotate (0, rotation, 0);
	}
}
