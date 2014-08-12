using UnityEngine;
using System.Collections;

public class SwitchesCollider : MonoBehaviour {
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

	void OnTrigerEnter (Collider collided) {
		if (collided == switchOne) {
			collided.gameObject.transform.Rotate(Vector3.forward, 180f);
			switchAttempt[arrayIndex] = collided;
			arrayIndex++;
		} else if (collided == switchTwo) {
			collided.gameObject.transform.Rotate(Vector3.forward, 180f);
			switchAttempt[arrayIndex] = collided;
			arrayIndex++;
		} else if (collided == switchThree) {
			collided.gameObject.transform.Rotate(Vector3.forward, 180f);
			switchAttempt[arrayIndex] = collided;
			arrayIndex++;
		} else if (collided == switchFour) {
			collided.gameObject.transform.Rotate(Vector3.forward, 180f);
			switchAttempt[arrayIndex] = collided;
			arrayIndex++;
		} else if (collided == switchFive) {
			collided.gameObject.transform.Rotate(Vector3.forward, 180f);
			switchAttempt[arrayIndex] = collided;
			arrayIndex++;
		} else if (collided == switchSix) {
			collided.gameObject.transform.Rotate(Vector3.forward, 180f);
			switchAttempt[arrayIndex] = collided;
			arrayIndex++;
		}
	}
	
	void Update () {
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
			doorTop.gameObject.transform.Translate (0f, 25f, 0f);
			doorLeft.gameObject.transform.Translate (0f, 0f, 20f);
			doorRight.gameObject.transform.Translate (0f, 0f, 20f);
			openOnce = true;
		}
		
		if (arrayIndex == 6) {
			arrayIndex = 0;
		}
	}
}
