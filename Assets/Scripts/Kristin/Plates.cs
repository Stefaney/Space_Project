using UnityEngine;
using System.Collections;

public class Plates: MonoBehaviour {
	bool grantAccess = false;
	public Collider doorTop;
	public Collider doorLeft;
	public Collider doorRight;
	public Collider red;
	public Collider orange;
	public Collider yellow;
	public Collider green;
	public Collider blue;
	public Collider purple;
	bool redChecked = false;
	bool orangeChecked = false;
	bool yellowChecked = false;
	bool greenChecked = false;
	bool blueChecked = false;
	bool purpleChecked = false;
	bool openOnce = false;

	AudioSource Plate;
	AudioSource Door;

	void Start(){

		AudioSource[] audioList = GetComponents<AudioSource>();
		Plate = audioList[2];
		Door = audioList[1];
	}

	void OnTriggerEnter(Collider plate) {
		if (plate == red && redChecked == false) {
			Plate.Play();
			redChecked = true;
			red.gameObject.renderer.material.color = Color.red;
		} else if (plate == orange && orangeChecked == false) {
			orangeChecked = true;
			orange.gameObject.renderer.material.color = new Color(1f,0.505f,0f,1f);
			Plate.Play();
		} else if (plate == yellow && yellowChecked == false) {
			yellowChecked = true;
			yellow.gameObject.renderer.material.color = Color.yellow;
			Plate.Play();
		} else if (plate == green && greenChecked == false) {
			greenChecked = true;
			green.gameObject.renderer.material.color = Color.green;
			Plate.Play();
		} else if (plate == blue && blueChecked == false) {
			blueChecked = true;
			blue.gameObject.renderer.material.color = Color.blue;
			Plate.Play();
		} else if (plate == purple && purpleChecked == false) {
			purpleChecked = true;
			purple.gameObject.renderer.material.color = new Color(0.501f, 0.295f, 0.51f, 1f);
			Plate.Play();
		}
	}
	
	void Update() {
		if (redChecked == true && yellowChecked == true && orangeChecked == true &&
		    greenChecked == true && blueChecked == true && purpleChecked == true) {
			grantAccess = true; 
		}
		
		if (grantAccess == true && openOnce == false) {
			Door.Play ();
			doorTop.gameObject.transform.Translate (0f, 100f, 0f);
			doorLeft.gameObject.transform.Translate (0f, 0f, 100f);
			doorRight.gameObject.transform.Translate (0f, 0f, 100f);
			openOnce = true;
		}
	}
}