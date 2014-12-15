using UnityEngine;
using System.Collections;

public class PlayerArrow : MonoBehaviour {

	private float speed = 0.5f;
	private int timer;

	void Update()
	{
		timer ++;
		if(timer >= 300)
			Destroy(this.gameObject);
		this.transform.Translate (Vector3.down * speed);
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag.Contains("Enemy"))
		{
			Destroy(this.gameObject);
		}
	}
}
