using UnityEngine;
using System.Collections;
public class Move_Controller : MonoBehaviour 
{
	float mouseSpeed = 75f;
	float walkingSpeed = 30f;
	float visionRange = 30f;
	public Transform HealthBar;
	float totalHealth = 100f;
	float maxHealth = 100f;
	Vector3 originalHealthTransform;
	int puzzleCounter = 0;
	public Collider doorTop;
	public Collider doorLeft;
	public Collider doorRight;
	/// 
	float bar = 100f;
	Vector2 pos = new Vector2(20,40);
	Vector2 size = new Vector2(60,20);
	Texture2D emptyTex;
	Texture2D fullTex;
	float barPercent = 1f;
	
	
	// Use this for initialization
	void Start () 
	{
		//originalHealthTransform = HealthBar.transform.localScale;
		
	}
	
	void OnGUI(){
		GUI.backgroundColor = new Color (1f, 1f, 1f, 0.5f);
		GUI.BeginGroup(new Rect (pos.x, pos.y, size.x, size.y));
		GUI.Box(new Rect(0,0, size.x, size.y), emptyTex);
		GUI.BeginGroup(new Rect(0,0, size.x *(bar/maxHealth), size.y));
		GUI.Box(new Rect(0,0, size.x, size.y), fullTex);
		GUI.EndGroup();
		GUI.EndGroup();

		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		//Mouse Controls, that allow fo rthe player to look up and down but not spin all around 
		float XView = mouseSpeed * Input.GetAxis("Mouse X") * Time.deltaTime;
		float YView = -mouseSpeed * Input.GetAxis("Mouse Y") * Time.deltaTime;
		
		
		transform.Rotate(YView, XView, 0);
		
		float xRotation = transform.eulerAngles.x;
		if ( xRotation < 180f &&  xRotation > visionRange)
		{
			xRotation = visionRange;
		}
		else if ( xRotation > 180f && xRotation < (360f - visionRange))
		{
			xRotation = 360f - visionRange;
		}
		
		transform.eulerAngles = new Vector3(xRotation, transform.eulerAngles.y, 0f);
		
		
		//creates a controller
		CharacterController controller = GetComponent<CharacterController>();
		
		//Character controller moves forward and back
		Vector3 forward = transform.TransformDirection(Vector3.forward);
		float forwardSpeed = walkingSpeed * Input.GetAxis("Vertical");
		controller.SimpleMove(forward * forwardSpeed);
		
		//Character controller that moves sideways
		Vector3 sideways = transform.TransformDirection (Vector3.right);
		float sidewaysSpeed = walkingSpeed * Input.GetAxis ("Horizontal");
		controller.SimpleMove(sideways * sidewaysSpeed);
		
	}
	
	void OnTriggerEnter (Collider collide) {
		
		
		if ((collide.tag == "Enemy"))
		{
			//Vector3 cameraStartPosition = Camera.main.transform.position;
			if (totalHealth > 20 ){
				
				totalHealth -= 10;
				//HealthBar.transform.localScale = new Vector3(HealthBar.transform.localScale.x, HealthBar.transform.localScale.y, 
				//Mathf.Lerp(1,totalHealth/maxHealth,totalHealth/maxHealth*10f));
				bar = totalHealth;
				
				
			}
			//20 is a critical health level, you are two run overs by a ghost away from dying, so this handles the color change
			else if (totalHealth == 20 || totalHealth == 10){
				
				totalHealth -= 10;
				//HealthBar.transform.renderer.material.color = Color.red;
				bar = totalHealth;
			}
			else {
				//HealthBar.gameObject.SetActive(false);
				Application.LoadLevel(0);
				Debug.Log ("You died");
				
			}
			
		}
		else if (collide.tag == "Medikit"){
			
			//HealthBar.transform.localScale = originalHealthTransform;
			totalHealth = 100;
			bar = totalHealth;
			Destroy(collide.gameObject);
			
		}
		else if ( collide.tag == "PuzzlePiece"){
			
			Destroy(collide.gameObject);
			puzzleCounter++;
			
		}
		else if (collide.tag == "Box" && puzzleCounter == 3){
			Debug.Log("in the collider if ");
			doorTop.gameObject.transform.Translate (0f, 8f, 0f);
			doorLeft.gameObject.transform.Translate (0f, 0f, 4f);
			doorRight.gameObject.transform.Translate (0f, 0f, 4f);
			
		}
		
	}
}