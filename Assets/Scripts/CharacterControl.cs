using UnityEngine;
using System.Collections;

public class CharacterControl : MonoBehaviour {
	
	public float mouseSpeed = 50f;
	public float walkingSpeed = 20f;
	public float visionRange = 30f;
	
	public Transform HealthBar;
	int totalHealth = 100;
	float maxHealth = 100f;
	Vector3 originalHealthTransform ;
	public Transform Haze;
	int puzzleCounter = 0;
	//float enemy_distance = Vector3.Distance()
	//float HealthBarValue = 100f;
	// Use this for initialization
	void Start () 
	{
		//originalHealthTransform = HealthBar.transform.localScale;
		
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
	
	/* void OnTriggerEnter (Collider collide) {
		
		
		if ((collide.tag == "Enemy"))
		{
			//Vector3 cameraStartPosition = Camera.main.transform.position;
			if (totalHealth > 20 ){
				
				totalHealth -= 10;
				HealthBar.transform.localScale = new Vector3(HealthBar.transform.localScale.x, HealthBar.transform.localScale.y, 
				                                             Mathf.Lerp(1,totalHealth/maxHealth,totalHealth/maxHealth*10f));
				float t  = 3f;
				Vector3 camerStartPosition = Camera.main.transform.position;
				while ( t > 0f)
				{
					t -= Time.deltaTime/ 3f;
					Camera.main.transform.position = camerStartPosition + Camera.main.transform.right * Mathf.Sin(Time.time * 20f) * t;
				}
				
				
				
			}
			else if (totalHealth == 20 | totalHealth == 10){
				
				totalHealth -= 10;
				HealthBar.transform.renderer.material.color = Color.red;
			}
			else {
				HealthBar.gameObject.SetActive(false);
				Debug.Log("You died");
			}
			
			//Vector3 scale = HealthBar.transform.localScale;
			//HealthBar.transform.localScale = 
			//HealthBarValue = HealthBarValue - 10f;
			
		}
		else if (collide.tag == "Medikit"){
			
			HealthBar.transform.localScale = originalHealthTransform;
			totalHealth = 100;
			Destroy(collide.gameObject);
			
		}
		else if ( collide.tag == "PuzzlePiece"){
			
			Destroy(collide.gameObject);
			puzzleCounter++;
			
		}
		
	} */
}