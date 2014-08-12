using UnityEngine;
using System.Collections;

public class Capsule: MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public float turnSpeed = 50f;
	public float moveSpeed =50f;
	public float jumpForce =50f;

	// Update is called once per frame
	void Update () {

	//First make the camera points towards the mouse all the time

	transform.Rotate (0f, Input.GetAxis ("Mouse X") * turnSpeed * Time.deltaTime, 0f);
	//transform.Rotate (Input.GetAxis ("Mouse Y") * turnSpeed * Time.deltaTime, 0f, 0f);
	
	//========================FREEZE ROTAION OF Z IN TRANSFORM==================================

		}
	void FixedUpdate(){

	// Now make the controller to translate (move)
	GetComponent<Rigidbody>().AddForce ( transform.forward * Input.GetAxis ("Vertical") * moveSpeed * Time.deltaTime );

	GetComponent<Rigidbody>().AddForce ( transform.right * Input.GetAxis ("Horizontal") * moveSpeed * Time.deltaTime );

	//***if you use transform position it will pass through walls and climb up any walls with a collider***


	}









}
