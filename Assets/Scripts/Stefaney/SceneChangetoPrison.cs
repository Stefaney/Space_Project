using UnityEngine;
using System.Collections;

public class SceneChangetoPrison : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter() {
		Application.LoadLevel (9);
	}

}
