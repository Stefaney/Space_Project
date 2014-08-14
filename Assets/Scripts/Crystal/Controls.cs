using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {
	public TextMesh toView;
	string textScreen;
	
	void OnGUI (){
		textScreen = "";
		textScreen = "- Use arrow keys to move the player\n" +
			"- Use your mouse to rotate the camera view\n" +
			"- Use keys to type numbers\n" +
			"- Use your flashlight to stop enemies\n" +
			"- Avoid monsters to survive";
		
		toView.text = textScreen;
		if(GUI.Button (new Rect(500,650,150,30), "Main Menu")){
			Application.LoadLevel (0);			
		}

	}
}