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
	public Collider reset;
	public Collider[] switchOrder = new Collider[6];
	Collider[] switchAttempt = new Collider[6];
	bool correctSwitches = false;
	bool openOnce = false;
	bool isHitOne = false;
	bool isHitTwo = false;
	bool isHitThree = false;
	bool isHitFour = false;
	bool isHitFive = false;
	bool isHitSix = false;
	int arrayIndex = 0;
	string textScreen;

	void OnTriggerEnter (Collider collided) {
		Debug.Log("collided.");
		if (collided == switchOne && isHitOne == false) {
			collided.gameObject.transform.Rotate(Vector3.up, 180f);
			switchAttempt[arrayIndex] = collided;
			arrayIndex++;
			isHitOne = true;
		} else if (collided == switchTwo && isHitTwo == false) {
			collided.gameObject.transform.Rotate(Vector3.up, 180f);
			switchAttempt[arrayIndex] = collided;
			arrayIndex++;
			isHitTwo = true;
		} else if (collided == switchThree && isHitThree == false) {
			collided.gameObject.transform.Rotate(Vector3.up, 180f);
			switchAttempt[arrayIndex] = collided;
			arrayIndex++;
			isHitThree = true;
		} else if (collided == switchFour && isHitFour == false) {
			collided.gameObject.transform.Rotate(Vector3.up, 180f);
			switchAttempt[arrayIndex] = collided;
			arrayIndex++;
			isHitFour = true;
		} else if (collided == switchFive && isHitFive == false) {
			collided.gameObject.transform.Rotate(Vector3.up, 180f);
			switchAttempt[arrayIndex] = collided;
			arrayIndex++;
			isHitFive = true;
		} else if (collided == switchSix && isHitSix == false) {
			collided.gameObject.transform.Rotate(Vector3.up, 180f);
			switchAttempt[arrayIndex] = collided;
			arrayIndex++;
			isHitSix = true;
		} else if (collided == reset && arrayIndex == 6) {
			arrayIndex = 0;
			switchOne.gameObject.transform.Rotate (Vector3.up, 180f);
			switchTwo.gameObject.transform.Rotate (Vector3.up, 180f);
			switchThree.gameObject.transform.Rotate (Vector3.up, 180f);
			switchFour.gameObject.transform.Rotate (Vector3.up, 180f);
			switchFive.gameObject.transform.Rotate (Vector3.up, 180f);
			switchSix.gameObject.transform.Rotate (Vector3.up, 180f);
			isHitOne = false;
			isHitTwo = false;
			isHitThree = false;
			isHitFour = false;
			isHitFive = false;
			isHitSix = false;
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
			doorTop.gameObject.transform.Translate (0f, 100f, 0f);
			doorLeft.gameObject.transform.Translate (0f, 0f, 50f);
			doorRight.gameObject.transform.Translate (0f, 0f, 50f);
			openOnce = true;
		}
	}
}
