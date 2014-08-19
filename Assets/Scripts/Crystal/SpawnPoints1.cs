using UnityEngine;
using System.Collections;

public class SpawnPoints1: MonoBehaviour {


	//First declare monsters and indicate them in inspector
	//CANNOT put them in prefab and delete them from hierarchy. ASK

	//indicate your monsters
	public Transform Monster1, Monster2, Monster3;


	//make an array for the spawnpoints
	public Transform [] SpawnPoints= new Transform [16];


	void Start (){
	


		for (int i = 0; i < 5 ; i++) {

	
		int monsterNumber = Random.Range (0, 3);
		//shoudln't the range be 0,2? monster3 won't show up unless it's 0,3. ASK
	
		Transform monsterToSpawn;
	
		if (monsterNumber == 0) {
			monsterToSpawn = Monster1;
			} 

		else if (monsterNumber == 1) {
			monsterToSpawn = Monster2;
			} 

		else {monsterToSpawn = Monster3;
			}

		//spawn them at the location of random spawn points!!!!!!
		Instantiate (monsterToSpawn, SpawnPoints [Random.Range (0, 15)].transform.position, Quaternion.identity);
		
		// now add a count and a while-loop to spawn two monsters in the room
		

	}//while-loop
	



	
	
	
	
	}//start
	}//Monobehavior
