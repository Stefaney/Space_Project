using UnityEngine;
using System.Collections;

public class Victory : MonoBehaviour {
	void OnGUI (){
		if (GUI.Button (new Rect (375, 375, 150, 30), "Play again")) {
			Application.LoadLevel (1);
		}
		
		if (GUI.Button (new Rect (375, 425, 150, 30), "Main Menu")) {
			Application.LoadLevel (0);
		}
	}
}
