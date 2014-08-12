using UnityEngine;
using System.Collections;

public class Riddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}


	// Update is called once per frame
	void Update () {
		GetComponent <TextMesh> ().text = 
			"Rescue your little sister and \n\n" +
			"leave this spaceship through the exit\n\n" +
			"Your flashlight will stop anything \n\n" +
			"that's trying to hurt you\n\n" +
			"Good luck and be safe.";
	}
}
