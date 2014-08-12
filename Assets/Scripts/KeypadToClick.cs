using UnityEngine;
using System.Collections;

public class KeypadToClick : MonoBehaviour {
	bool grantAccess = false;
	string textScreen = "";
	string answer = "";
	public TextMesh keypadInput;
	public string code = "";
	public Collider doorTop;
	public Collider doorLeft;
	public Collider doorRight;
	public Collider numberOne;
	public Collider numberTwo;
	public Collider numberThree;
	public Collider numberFour;
	public Collider numberFive;
	public Collider numberSix;
	public Collider numberSeven;
	public Collider numberEight;
	public Collider numberNine;

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
					doorTop.gameObject.transform.Translate (0f, 4f, 0f);
					doorLeft.gameObject.transform.Translate (0f, 0f, 2f);
					doorRight.gameObject.transform.Translate (0f, 0f, 2f);
				}
			} else if (rayHit.collider == numberOne) {
				answer += "1";
				audio.Play ();
			} else if (rayHit.collider == numberTwo) {
				answer += "2";
				audio.Play ();
			} else if (rayHit.collider == numberThree) {
				answer += "3";
				audio.Play ();
			} else if (rayHit.collider == numberFour) {
				answer += "4";
				audio.Play ();
			} else if (rayHit.collider == numberFive) {
				answer += "5";
				audio.Play ();
			} else if (rayHit.collider == numberSix) {
				answer += "6";
				audio.Play ();
			} else if (rayHit.collider == numberSeven) {
				answer += "7";
				audio.Play ();
			} else if (rayHit.collider == numberEight) {
				answer += "8";
				audio.Play ();
			} else if (rayHit.collider == numberNine) {
				answer += "9";
				audio.Play ();
			}
		}

		keypadInput.text = "";
		keypadInput.text = answer;

		if (answer.Equals(code)) {
			grantAccess = true;
		}

		if (answer.Length == 4) { answer = ""; }
	}
}
