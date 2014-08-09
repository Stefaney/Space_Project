using UnityEngine;
using System.Collections;

public class PressurePlates : MonoBehaviour {
	bool grantAccess = false;
	Color original;
	public Collider doorTop;
	public Collider doorLeft;
	public Collider doorRight;
	public Collider red;
	public Collider orange;
	public Collider yellow;
	public Collider green;
	public Collider blue;
	public Collider purple;
	Collider[] userInput = new Collider[6];
	int index = 0;

	void Start() {
		original = red.gameObject.renderer.material.color;
	}

	void OnTriggerEnter(Collider plate) {
		// this allows the user to retry their guess by changing colors of plates + clearing array
		if (userInput[5] != null) { // if array is not full
			red.gameObject.renderer.material.color = original;
			orange.gameObject.renderer.material.color = original;
			yellow.gameObject.renderer.material.color = original;
			green.gameObject.renderer.material.color = original;
			blue.gameObject.renderer.material.color = original;
			purple.gameObject.renderer.material.color = original;

			index = 0;

			// clearing userInput array
			for (int i = 0; i <= 5; i++) {
				userInput[i] = null;
			}
		}
		Debug.Log ("collided.");
		// Otherwise, store the selected plate into array + change color
		if (plate == red) {
			Debug.Log ("got red");
			red.gameObject.renderer.material.color = Color.red;
			userInput[index] = red;
			index++;
		} else if (plate == orange) {
			orange.gameObject.renderer.material.color = new Color(255f,153f,0f,1f);
			userInput[index] = orange;
			index++;
		} else if (plate == yellow) {
			yellow.gameObject.renderer.material.color = Color.yellow;
			userInput[index] = yellow;
			index++;
		} else if (plate == green) {
			green.gameObject.renderer.material.color = Color.green;
			userInput[index] = green;
			index++;
		} else if (plate == blue) {
			blue.gameObject.renderer.material.color = Color.blue;
			userInput[index] = blue;
			index++;
		} else if (plate == purple) {
			purple.gameObject.renderer.material.color = new Color(140f, 72f, 159f, 1f);
			userInput[index] = purple;
			index++;
		}
	}

	void Update() {
		if (userInput[0] = red) {
			if (userInput[1] = orange) {
				if (userInput[2] = yellow) {
					if (userInput[3] = green) {
						if (userInput[4] = blue) {
							if (userInput[5] = purple) { grantAccess = true; }
						}
					}
				}
			}
		}

		if (grantAccess == true) {
			doorTop.gameObject.transform.Translate (0f, 2f, 0f);
			doorLeft.gameObject.transform.Translate (0f, 0f, 2f);
			doorRight.gameObject.transform.Translate (0f, 0f, 2f);
		}
	}
}
