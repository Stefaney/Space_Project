using UnityEngine;
using System.Collections;

public class hoverbox : MonoBehaviour {

	// Use this for initialization
	public float hoverForce;

	void OnTriggerStay (Collider Other) {

		Other.rigidbody.AddForce (Vector3.up * hoverForce, ForceMode.Acceleration);
	}
}
