using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	public Transform enemy;
	public Transform spawnpos;

	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.M))
		{
			Instantiate(enemy, spawnpos.position, spawnpos.rotation);
		}
	}
}
