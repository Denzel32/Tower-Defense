using UnityEngine;
using System.Collections;

public class Projectile_Arrow : MonoBehaviour {

	private float mySpeed = 1.0f;
	private float myRange = 1.5f;
	
	private float myDist;

	void Update () 
	{
		myDist += Time.deltaTime * mySpeed;
		if (myDist>=myRange)
			Destroy (gameObject);

		this.transform.Translate (Vector3.forward * mySpeed);
	}
}