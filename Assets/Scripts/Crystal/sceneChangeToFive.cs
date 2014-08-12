using UnityEngine;
using System.Collections;

public class sceneChangeToFive : MonoBehaviour {

	void OnTriggerEnter() {
		Application.LoadLevel (5);
	}
}
