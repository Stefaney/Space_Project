using UnityEngine;
using System.Collections;

public class SceneChangeToZeros : MonoBehaviour {


	void OnTriggerEnter() {
		Application.LoadLevel (0);
	}

}
