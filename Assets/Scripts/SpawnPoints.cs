using UnityEngine;
using System.Collections;

public class SpawnPoints : MonoBehaviour 
{	public Transform [] spawnPoints;	// the spawnpoints for where the enemies will be spawning
	public GameObject enemy;			//the gameobject that contains the enemy.
	private int maxEnemies = 0;
	// Use this for initialization
	void Start () 
	{	
		
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(maxEnemies < 3)
		{
			Spawn();
		}

		if(Input.GetKeyDown(KeyCode.Space))
		{
			maxEnemies--;
		}
	}

	void Spawn()
	{
		for(int i = 0; i < maxEnemies; i++)
		{
			//instantiates the enemy gameobject and puts it into the position of the spawnpoints.
			//random.range picks one of the spawnpoints at random and that is where the enemy is spawned.
			Instantiate(enemy,spawnPoints[Random.Range(0,5)].position, transform.rotation);

		}
		maxEnemies++;
	}


}
