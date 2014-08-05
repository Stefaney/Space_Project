using UnityEngine;
using System.Collections;

public class Switches : MonoBehaviour {
	public Collider doorTop;
	public Collider doorRight;
	public Collider doorLeft;
	public Collider switchOne;
	public Collider switchTwo;
	public Collider switchThree;
	public Collider switchFour;
	public Collider switchFive;
	public Collider switchSix;
	public Collider[] switchOrder = new Collider[6];
	Collider[] switchAttempt = new Collider[6];
	bool correctSwitches = false;
	bool correctOne = false;
	bool correctTwo = false;
	bool correctThree = false;
	bool correctFour = false;
	int arrayIndex = 0;
	string textScreen;
	
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit rayHit =  new RaycastHit();
		
		if (Physics.Raycast (ray, out rayHit, 1000f) && Input.GetMouseButtonDown(0)) {
			if (rayHit.collider == switchOne) {
				switchAttempt[arrayIndex] = rayHit.collider;
				arrayIndex++;
			} else if (rayHit.collider == switchTwo) {
				switchAttempt[arrayIndex] = rayHit.collider;
				arrayIndex++;
			} else if (rayHit.collider == switchThree) {
				switchAttempt[arrayIndex] = rayHit.collider;
				arrayIndex++;
			} else if (rayHit.collider == switchFour) {
				switchAttempt[arrayIndex] = rayHit.collider;
				arrayIndex++;
			} else if (rayHit.collider == switchFive) {
				switchAttempt[arrayIndex] = rayHit.collider;
				arrayIndex++;
			} else if (rayHit.collider == switchSix) {
				switchAttempt[arrayIndex] = rayHit.collider;
				arrayIndex++;
			} else if (rayHit.collider == doorTop || rayHit.collider == doorLeft || rayHit.collider == doorRight) {
				if (correctSwitches == false) {
					textScreen = "";
					textScreen += "You need an access code first.";
				} else if (correctSwitches == true) {
					doorTop.gameObject.transform.Translate (0f, 2f, 0f);
					doorLeft.gameObject.transform.Translate (0f, 0f, 2f);
					doorRight.gameObject.transform.Translate (0f, 0f, 2f);
				}	
			}
		}

		if (arrayIndex == 5) {
			arrayIndex = 0;
		}


		if (switchOrder[0] == switchAttempt[0]) {
			correctOne = true;
			if (switchOrder[1] == switchAttempt[1]) {
				correctTwo = true;
				if (switchOrder[3] == switchAttempt[3]) {
					correctThree = true;
					if (switchOrder[4] == switchAttempt[4]) {
						correctFour = true;
					}
				}
			}
		}

		if (correctOne == true && correctTwo == true && correctThree == true && correctFour == true) {
			correctSwitches = true;
		}
	}
}
