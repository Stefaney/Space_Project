using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
	
	public GameObject cuteBoo;
	public GameObject terrorBoo;
	
	public float bobSpeed = 2f;
	public float bobHeight = 0.58f;
	
	Vector3 startPosition;
	
	GameObject player;
	float rotationSpeed = 5f;
	float moveSpeed = 8f;
	
	// Use this for initialization
	void Start () {
		
		player = GameObject.FindGameObjectWithTag("Player");
		
		startPosition = transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		Vector3 ray_direction = player.transform.localPosition - transform.localPosition;
		
		
		
		transform.rotation = Quaternion.Slerp(transform.rotation,
		                                      Quaternion.LookRotation
		                                      (player.transform.position - transform.position), rotationSpeed*Time.deltaTime);
		
		transform.position += transform.forward * moveSpeed * Time.deltaTime;
		
		
		
		
		
	}
	void OnTriggerEnter (Collider collide)
	{
		if (collide.tag == "Light")
		{
			Debug.Log ("Collide start" + collide.gameObject.name);
			
			cuteBoo.gameObject.SetActive (true);
			terrorBoo.gameObject.SetActive (false);
			moveSpeed = 0f;
		}	
		
		
	}
	
	
	
	void OnTriggerStay(Collider collide) 
	{
		if (collide.tag == "Light")
		{
			
			//transform.position = startPosition +
			//new Vector3 (startPosition.x, 1f, startPosition.z) * Mathf.Sin (Time.time *bobSpeed) * bobHeight; 
			
		}
		
		
	}
	
	void OnTriggerExit(Collider collide)
	{
		if (collide.tag == "Light")
		{
			
			cuteBoo.gameObject.SetActive (false);
			terrorBoo.gameObject.SetActive (true);
			moveSpeed = 10f;
		}
	}
}
