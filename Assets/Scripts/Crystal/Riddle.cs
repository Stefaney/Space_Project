using UnityEngine;
using System.Collections;

public class Riddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}


	// Update is called once per frame
	void Update () {
		GetComponent <TextMesh> ().text = 
			"Man walks on _ _ legs in the morning\n" +
			"Man walks on _ _ legs at noon\n" +
			"Man walks on _ _ legs in the evening\n" +
			"Man walks on _ _ legs at midnight";
	}
}
