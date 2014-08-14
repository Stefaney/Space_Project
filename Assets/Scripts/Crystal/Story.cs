using UnityEngine;
using System.Collections;

public class Story : MonoBehaviour {
	public TextMesh toView;
	string textScreen;
	
	void OnGUI (){
		textScreen = "";
		textScreen = "In the year 2200 AD, the Earth experienced an alien invasion like no other.\n" +
			"People lost their ability to reason and assumed monstrous forms. Those\n" +
			"who survived fled into the galaxy.\n\n" +
			"Having lost your parents in the chaos, you and your little sister boarded\n" +
			"a refugee craft destined to cruise aimlessly in the galaxy, searching for\n" +
			"contact with other refugee crafts. While volunteering for crew duty in the\n" +
			"middle of the night, your refugee craft came under attack by the same\n" +
			"aggressors that attacked your planet. Once again, your fellow crew and\n" +
			"passengers assumed monstrous forms.\n\n" +
			"You've told your little sister to lock the door and stay in her room.\n" +
			"Between you and her are four rooms, each ocked with different contraptions.\n" +
			"Your objective is to get your sister and escape to the escape pod. Both of\n" +
			"you must get to the escape pod.\n\nGood luck.";

		toView.text = textScreen;
		if(GUI.Button (new Rect(500,650,150,30), "Main Menu")){
			Application.LoadLevel (0);			
		}
		
		
	}
}
