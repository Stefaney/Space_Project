using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {

	void OnGUI (){

		
		if(GUI.Button (new Rect(380,300,150,30), "Main Menu")){
			Application.LoadLevel (0);			
		}
		
		
		
		
		
		
		
	}
}