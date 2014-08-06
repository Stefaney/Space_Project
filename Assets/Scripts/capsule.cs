using UnityEngine;
using System.Collections;

public class capsule : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	public float turnSpeed;
	public float moveSpeed;

	void Update () {
		// turning, does NOT use physics system (torque)
		transform.Rotate ( 0f, Input.GetAxis ("Mouse X") * turnSpeed * Time.deltaTime, 0f );
		
	}
	
	// all Physics rigidbody calls should be made in FixedUpdate
	void FixedUpdate () {
		// movement forward and backward
		GetComponent<Rigidbody>().AddForce ( transform.forward * Input.GetAxis ("Vertical") * moveSpeed * Time.deltaTime );
		// movement sideways
		GetComponent<Rigidbody>().AddForce ( transform.right * Input.GetAxis ("Horizontal") * moveSpeed * Time.deltaTime );

}
}
