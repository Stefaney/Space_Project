using UnityEngine;
using System.Collections;

public class sceneChangeToOne : MonoBehaviour {


	void OnTriggerEnter() {
		Application.LoadLevel (1);
	}
}
