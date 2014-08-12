using UnityEngine;
using System.Collections;

public class ControlsInstruction : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		GetComponent <TextMesh> ().text = 
			"Use your mouse to pan the camera\n" +
						"Move the player with the arrow keys or WASD buttons\n" +
						"use keypad when you need to input numers";
	}
}
