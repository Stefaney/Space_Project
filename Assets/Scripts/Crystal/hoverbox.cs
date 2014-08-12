using UnityEngine;
using System.Collections;

public class hoverbox : MonoBehaviour {

	Vector3 startPosition;

	void Start (){
	startPosition = transform.position;
	}

	void Update (){
		transform.position = startPosition + transform.up * Mathf.Sin (Time.time) * 4f;

}
}