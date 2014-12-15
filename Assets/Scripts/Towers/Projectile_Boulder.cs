using UnityEngine;
using System.Collections;

public class Projectile_Boulder : MonoBehaviour {

	private float mySpeed = 0.3f;

	public GameObject explosion;

	private float myDist;
	
	void Update () 
	{
		this.transform.Translate (Vector3.forward * mySpeed);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag.Contains("Enemy"))
		{
			Instantiate (explosion, other.gameObject.transform.position, Quaternion.identity);
			Destroy (this.gameObject);
		}
		else
			Destroy(this.gameObject);
	}
}