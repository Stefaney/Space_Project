using UnityEngine;
using System.Collections;

public class SceneChangeToPrison : MonoBehaviour {


	void OnTriggerEnter() {
		Application.LoadLevel (9);
	}

}
