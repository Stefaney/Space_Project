using UnityEngine;
using System.Collections;

public class Bouncy : MonoBehaviour {

	Vector3 startPosition;
	// Use this for initialization
	void Start () {
		startPosition = transform.position; 
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = startPosition + transform.up * Mathf.Sin(Time.time ) * 40f;
	
	}
}
