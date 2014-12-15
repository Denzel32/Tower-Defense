using UnityEngine;
using System.Collections;

public class Despawner : MonoBehaviour {

	private int timer;

	void Update () 
	{
		timer++;
		if (timer >= 100)
			Destroy (this.gameObject);
	}
}
