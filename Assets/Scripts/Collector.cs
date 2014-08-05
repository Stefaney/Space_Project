using UnityEngine;
using System.Collections;

public class Collector : MonoBehaviour {
	public Collider pieceOne;
	public Collider pieceTwo;
	public Collider pieceThree;
	public Collider doorTop;
	public Collider doorLeft;
	public Collider doorRight;
	bool hasOne = false;
	bool hasTwo = false;
	bool hasThree = false;
	bool allPieces = false;
	string textScreen = "";

	void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit rayHit =  new RaycastHit();
		
		if (Physics.Raycast (ray, out rayHit, 1000f) && Input.GetMouseButtonDown(0)) {
			if (rayHit.collider == pieceOne) {
				hasOne = true;
			} else if (rayHit.collider == pieceTwo) {
				hasTwo = true;
			} else if (rayHit.collider == pieceThree) {
				hasThree = true;
			} else if (rayHit.collider == doorTop || rayHit.collider == doorLeft || rayHit.collider == doorRight) {
				if (allPieces == false) {
					textScreen = "";
					textScreen += "You need an access code first.";
				} else if (allPieces == true) {
					doorTop.gameObject.transform.Translate (0f, 2f, 0f);
					doorLeft.gameObject.transform.Translate (0f, 0f, 2f);
					doorRight.gameObject.transform.Translate (0f, 0f, 2f);
				}
			}
		}

		if (hasOne == true && hasTwo == true && hasThree == true) {
			allPieces = true;
		}
	}
}
