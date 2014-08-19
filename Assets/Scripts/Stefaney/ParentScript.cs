using UnityEngine;
using System.Collections;

public class ParentScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collider){

		transform.parent = collider.transform;
		Debug.Log("Triggered");
	}
}
