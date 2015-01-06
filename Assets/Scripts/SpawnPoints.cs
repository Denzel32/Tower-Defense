using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnPoints : MonoBehaviour 
{	public Transform [] spawnPoints;	// the spawnpoints for where the enemies will be spawning
	public GameObject  enemy;			//the gameobject that contains the enemy.
	public  List<GameObject> enemies;
	private int maxEnemies = 3;
	public float spawnTime = 5f;
	public GameObject [] targetPoints ;

	// Use this for initialization
	void Start () 
	{	
		InvokeRepeating("Spawn",spawnTime,spawnTime);
		enemies = new List<GameObject>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(maxEnemies < 3)
		{
			Spawn();
		}
	}

	void Spawn()
	{
		for(int i = 0; i < maxEnemies; i++)
		{
			//instantiates the enemy gameobject and puts it into the position of the spawnpoints.
			//random.range picks one of the spawnpoints at random and that is where the enemy is spawned.
			GameObject newEnemy = Instantiate(enemy,spawnPoints[Random.Range(0,spawnPoints.Length)].position, transform.rotation) as GameObject;
			newEnemy.GetComponent<EnemyDestination>().targets = targetPoints;
			enemies.Add (newEnemy);
		}
		maxEnemies++;
	}


}
