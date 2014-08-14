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
	bool openOnce = false;
	int arrayIndex = 0;
	string textScreen;

	void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit rayHit =  new RaycastHit();
		
		if (Physics.Raycast (ray, out rayHit, 1000f) && Input.GetMouseButtonDown(0)) {
			if (rayHit.collider == switchOne) {
				rayHit.collider.gameObject.transform.Rotate(Vector3.up, 180f);
				switchAttempt[arrayIndex] = rayHit.collider;
				arrayIndex++;
			} else if (rayHit.collider == switchTwo) {
				rayHit.collider.gameObject.transform.Rotate(Vector3.up, 180f);
				switchAttempt[arrayIndex] = rayHit.collider;
				arrayIndex++;
			} else if (rayHit.collider == switchThree) {
				rayHit.collider.gameObject.transform.Rotate(Vector3.up, 180f);
				switchAttempt[arrayIndex] = rayHit.collider;
				arrayIndex++;
			} else if (rayHit.collider == switchFour) {
				rayHit.collider.gameObject.transform.Rotate(Vector3.up, 180f);
				switchAttempt[arrayIndex] = rayHit.collider;
				arrayIndex++;
			} else if (rayHit.collider == switchFive) {
				rayHit.collider.gameObject.transform.Rotate(Vector3.up, 180f);
				switchAttempt[arrayIndex] = rayHit.collider;
				arrayIndex++;
			} else if (rayHit.collider == switchSix) {
				rayHit.collider.gameObject.transform.Rotate(Vector3.up, 180f);
				switchAttempt[arrayIndex] = rayHit.collider;
				arrayIndex++;
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

		if (correctSwitches == true && openOnce == false) {
			doorTop.gameObject.transform.Translate (0f, 50f, 0f);
			doorLeft.gameObject.transform.Translate (0f, 0f, 100f);
			doorRight.gameObject.transform.Translate (0f, 0f, 100f);
			openOnce = true;
		}

		if (arrayIndex == 6) {
			arrayIndex = 0;
		}
	}
}
