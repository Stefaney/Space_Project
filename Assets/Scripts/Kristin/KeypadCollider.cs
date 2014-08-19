using UnityEngine;
using System.Collections;

public class KeypadCollider : MonoBehaviour {
	bool onTry = false;
	bool grantAccess = false;
	bool openOnce = false;
	string answer = "";
	public TextMesh keypadInput;
	public string code = "";
	public Collider keypad;
	public Collider doorTop;
	public Collider doorLeft;
	public Collider doorRight;

	AudioSource KeyPad;
	AudioSource Door;

	void Start(){

		AudioSource[] audioList = GetComponents<AudioSource>();
		KeyPad = audioList[0];
		Door = audioList[1];
	}
	
	void OnTriggerEnter (Collider collided) {
		if (collider == keypad) {
			onTry = true;
		}
	}
	
	
	void Update () {
		if (onTry == true) {
			if (Input.GetKeyDown (KeyCode.Alpha1)) {
				answer += "1";
				KeyPad.Play ();
			} else if (Input.GetKeyDown (KeyCode.Alpha2)) {
				answer += "2";
				KeyPad.Play ();
			} else if (Input.GetKeyDown (KeyCode.Alpha3)) {
				answer += "3";
				KeyPad.Play ();
			} else if (Input.GetKeyDown (KeyCode.Alpha4)) {
				answer += "4";
				KeyPad.Play ();
			} else if (Input.GetKeyDown (KeyCode.Alpha5)) {
				answer += "5";
				KeyPad.Play ();
			} else if (Input.GetKeyDown (KeyCode.Alpha6)) {
				answer += "6";
				KeyPad.Play ();
			} else if (Input.GetKeyDown (KeyCode.Alpha7)) {
				answer += "7";
				KeyPad.Play ();
			} else if (Input.GetKeyDown (KeyCode.Alpha8)) {
				answer += "8";
				KeyPad.Play ();
			} else if (Input.GetKeyDown (KeyCode.Alpha0)) {
				answer += "0";
				KeyPad.Play ();
			}
		}
		
		keypadInput.text = "Type Code";
		keypadInput.text = answer;
		
		if (answer.Equals(code)) {
			grantAccess = true;
			onTry = false;
		}
		
		if (grantAccess == true && openOnce == false) {
			Door.Play();
			doorTop.gameObject.transform.Translate (0f, 25f, 0f);
			doorLeft.gameObject.transform.Translate (0f, 0f, 20f);
			doorRight.gameObject.transform.Translate (0f, 0f, 20f);
			openOnce = true;
		}
		
		if (answer.Length == 4) { answer = ""; }
	}
}
