using UnityEngine;
using System.Collections;

public class Credit : MonoBehaviour {
	public TextMesh toView;
	string textScreen;
	
	void OnGUI (){
		textScreen = "";
		textScreen = "" +
			"Crystal  | girl model, keypad puzzle room, girl's room,\n" +
			"          main menu\n\n" +
			"Kristin   | switch model + code, keypad model + code,\n" +
			"          door model, keycard model + code, main menu,\n" +
			"          main menu bg\n\n" +
			"Stefaney | reset button model, player controller code,\n" +
			"          boo code, health bar code, first aid kit +\n" +
			"          code, keycard puzzle room, keycard code\n\n" +
			"Larry    | eyeball model, boo code, boo + evil boo" +
			"          \nmodel, switch puzzle room, enemy code";
		
		toView.text = textScreen;
		if(GUI.Button (new Rect(400,500,150,30), "Main Menu")){
			Application.LoadLevel (0);			
		}

	}
}