using UnityEngine;
using System.Collections;

public class Keypad : MonoBehaviour {
	bool onTry = false;
	bool grantAccess = false;
	string textScreen = "";
	string answer = "";
	public string code = "";
	public Collider keypad;
	public Collider doorTop;
	public Collider doorLeft;
	public Collider doorRight;

	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit rayHit =  new RaycastHit();

		if (Physics.Raycast (ray, out rayHit, 1000f) && Input.GetMouseButtonDown(0)) {
			if (rayHit.collider == doorTop || rayHit.collider == doorLeft || rayHit.collider == doorRight) {
				if (grantAccess == false) {
					textScreen = "";
					textScreen += "You need an access code first.";
				} else if (grantAccess == true) {
					doorTop.gameObject.transform.Translate (0f, 2f, 0f);
					doorLeft.gameObject.transform.Translate (0f, 0f, 2f);
					doorRight.gameObject.transform.Translate (0f, 0f, 2f);
				}
			} else if (rayHit.collider == keypad) {
				onTry = true;
			}
		}
	
		if (onTry == true) {
			if (Input.GetKeyDown (KeyCode.Alpha0)) {
				answer += "0";
			} else if (Input.GetKeyDown (KeyCode.Alpha1)) {
				answer += "1";
			} else if (Input.GetKeyDown (KeyCode.Alpha2)) {
				answer += "2";
			} else if (Input.GetKeyDown (KeyCode.Alpha3)) {
				answer += "3";
			} else if (Input.GetKeyDown (KeyCode.Alpha4)) {
				answer += "4";
			} else if (Input.GetKeyDown (KeyCode.Alpha5)) {
				answer += "5";
			} else if (Input.GetKeyDown (KeyCode.Alpha6)) {
				answer += "6";
			} else if (Input.GetKeyDown (KeyCode.Alpha7)) {
				answer += "7";
			} else if (Input.GetKeyDown (KeyCode.Alpha8)) {
				answer += "8";
			} else if (Input.GetKeyDown (KeyCode.Alpha9)) {
				answer += "9";
			}
		}

		if (answer.Equals(code)) {
			grantAccess = true;
			onTry = false;
		}

		if (answer.Length == 4) { answer = ""; }
	}
}
