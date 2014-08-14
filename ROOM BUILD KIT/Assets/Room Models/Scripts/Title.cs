using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnGUI (){
	

		GUI.Box(new Rect (300, 100, 300, 280), "Main Menu");
		
		if (GUI.Button (new Rect (380, 150, 150, 30), "Play Game")) {
		Application.LoadLevel (1);
		}

		if (GUI.Button (new Rect (380, 200, 150, 30), "Story")) {
		Application.LoadLevel (2);
		}

		if(GUI.Button (new Rect(380,250,150,30), "Controls")){
		Application.LoadLevel (3);			
		}

		if(GUI.Button (new Rect(380,300,150,30), "Credits")){
			Application.LoadLevel (4);			
		}


		




	}
}


	

