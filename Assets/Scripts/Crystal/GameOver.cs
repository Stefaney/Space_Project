using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	void OnGUI (){
		
		
	GUI.Box(new Rect (450, 450, 300, 280), "Game Over");
		
	if (GUI.Button (new Rect (520, 500, 150, 30), "Play again")) {
	Application.LoadLevel (1);
	}

	if (GUI.Button (new Rect (520, 550, 150, 30), "Main Menu")) {
	Application.LoadLevel (0);
	}

}
}