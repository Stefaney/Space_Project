using UnityEngine;
using System.Collections;

public class TitleScreen : MonoBehaviour {
	public Texture background;
	
	void OnGUI (){
		
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height), background);
		GUI.Box (new Rect(730, 350, 300, 280), "Main Menu");
		
		if (GUI.Button (new Rect (800, 400, 150, 30), "Play Game")) {
			Application.LoadLevel (1);
		}
		
		if (GUI.Button (new Rect (800, 450, 150, 30), "Story")) {
			Application.LoadLevel (2);
		}
		
		if(GUI.Button (new Rect(800,500,150,30), "How To Play")){
			Application.LoadLevel (3);			
		}
		
		if(GUI.Button (new Rect(800,550,150,30), "Credits")){
			Application.LoadLevel (4);			
		}
	}
}