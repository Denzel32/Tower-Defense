using UnityEngine;
using System.Collections;

public class Projectile_Boulder : MonoBehaviour {

	private float mySpeed = 0.3f;

	public GameObject explosion;

	private float myDist;
	
	void Update () 
	{
		mySpeed -=0.005f;
		if (mySpeed <= 0.0f)
		{
			Destroy (gameObject);
			Instantiate (explosion, gameObject.transform.position, Quaternion.identity);
		}
		this.transform.Translate (Vector3.forward * mySpeed);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Enemy")
		{
			Instantiate (explosion, other.gameObject.transform.position, Quaternion.identity);
			Destroy (gameObject);
			Destroy(other.gameObject);
		}
	}
}