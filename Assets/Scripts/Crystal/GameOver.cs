using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	void OnGUI (){
		
		
	GUI.Box(new Rect (300, 100, 300, 280), "Game Over");
		
	if (GUI.Button (new Rect (380, 150, 150, 30), "Play again")) {
	Application.LoadLevel (1);
	}

	if (GUI.Button (new Rect (380, 200, 150, 30), "Main Menu")) {
	Application.LoadLevel (0);
	}

}
}