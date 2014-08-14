using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	void OnGUI (){
		if (GUI.Button (new Rect (400, 375, 150, 30), "Play again")) {
			Application.LoadLevel (1);
		}

		if (GUI.Button (new Rect (400, 425, 150, 30), "Main Menu")) {
			Application.LoadLevel (0);
		}
	}
}