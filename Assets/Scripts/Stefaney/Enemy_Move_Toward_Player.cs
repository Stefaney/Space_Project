using UnityEngine;
using System.Collections;

public class Enemy_Move_Toward_Player : MonoBehaviour {

	float max_distance_from_player =40f; 
	float distance_from_player_squared = 1600f;
	GameObject player;
	float rotationSpeed = 5f;
	float moveSpeed = 7f;
	// Use this for initialization
	void Start () {

		 player = GameObject.FindGameObjectWithTag("Player");
	
	}
	
	// Update is called once per frame
	void Update () {


		Vector3 ray_direction = player.transform.localPosition - transform.localPosition;

		if ( ray_direction.sqrMagnitude < distance_from_player_squared)
		{

			RaycastHit hit;
			if (Physics.Raycast(transform.position, ray_direction, out hit, max_distance_from_player) && (hit.collider.gameObject==player) )
			{

				transform.rotation = Quaternion.Slerp(transform.rotation,
				Quaternion.LookRotation(player.transform.position - transform.position), rotationSpeed*Time.deltaTime);

				transform.position += transform.forward * moveSpeed * Time.deltaTime;

			}
		}
	
	}

	void OnTriggerEnter(Collider collide) {
		if (collide.tag == "Light")
		{

			moveSpeed = 0f;
		}

	
	}

	void OnTriggerExit(Collider collide)
	{
		if (collide.tag == "Light")
		{
		 moveSpeed = 4f;
		}
	}
}
