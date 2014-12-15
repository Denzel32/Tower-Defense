using UnityEngine;
using System.Collections;

public class EnemyStats : MonoBehaviour {

	CameraFollow goldAdding;

	public GameObject deathParticles;

	public float health = 100.0f;
	public float speed;
	private bool turn = false;
	private int goldValue = 15;

	void Start () 
	{
		goldAdding = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<CameraFollow> ();
		speed = Random.Range (0.02f, 0.1f);
	}

	void Update () 
	{
		if(turn == false)
			this.transform.Translate (Vector3.right * speed);
		else
			this.transform.Translate (Vector3.forward * speed);

		if (this.transform.position.x >= 110)
			turn = true;

		if (health <= 0)
		{
			addGold();
			Destroy (this.gameObject);
			Instantiate(deathParticles, this.transform.position, this.transform.rotation);
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Projectile_ArrowT")
			health -= 15;
		if (other.gameObject.tag == "Player_Arrow")
			health -= 20;
		if (other.gameObject.tag == "Projectile_BoulderT")
			health -= 80;
		if (other.gameObject.name == "Sword")
			health -= 100;
	}

	void addGold()
	{
		goldAdding.GoldAmmount += goldValue;
	}
}
