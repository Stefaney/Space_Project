using UnityEngine;
using System.Collections;

public class characterControl : MonoBehaviour {
	public float rotateSpeed = 3.0F;
	//public Vector3 location = (0,0,10);

	// Update is called once per frame
	void Update () {
		CharacterController controller = GetComponent<CharacterController>();
		if (Input.GetKey(KeyCode.UpArrow)) {
			Vector3 forward = transform.TransformDirection(Vector3.forward);
			controller.SimpleMove(forward * Time.deltaTime * 100f);
		} else if (Input.GetKey(KeyCode.RightArrow)) {
			GetComponent<Transform>().Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
		} else if (Input.GetKeyDown (KeyCode.Space) && controller.isGrounded) {
			controller.SimpleMove(Vector3.up);
		}
	}
}
