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
					textScreen += "The door is locked.";
				} else if (correctSwitches == true) {
					doorTop.gameObject.transform.Translate (0f, 2f, 0f);
					doorLeft.gameObject.transform.Translate (0f, 0f, 2f);
					doorRight.gameObject.transform.Translate (0f, 0f, 2f);
				}	
			}
		}

		if (switchOrder[0] == switchAttempt[0]) {
			if (switchOrder[1] == switchAttempt[1]) {
				if (switchOrder[2] == switchAttempt[2]) {
					if (switchOrder[3] == switchAttempt[3]) {
						if (switchOrder[4] == switchAttempt[4]) {
							if (switchOrder[5] == switchAttempt[5]) { correctSwitches = true; }
						}
					}
				}
			}
		}

		if (arrayIndex == 6) {
			arrayIndex = 0;
		}
	}
}
