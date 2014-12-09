using UnityEngine;
using System.Collections;

public class BoulderTower : MonoBehaviour {

	private SphereCollider coll;

	public Transform BarrelEnd;
	public GameObject Boulder_Projectile;
	public float reloadTime = 3f;
	public float firePauseTime = .25f;	
	
	public Transform myTarget = null;
	private float nextFireTime;
	private float nextMoveTime;
	private Quaternion desiredRotation;
	
	void Start ()
	{
		coll = GetComponent<SphereCollider> ();
	}
	
	void Update () 
	{		
		this.transform.LookAt (myTarget);
		coll.radius = 7.0f + this.transform.position.y;
		if (myTarget!=null)
		{
			if(Time.time >= nextMoveTime)
			{
				CalculateAimPosition(myTarget.position);
			}
			
			if(Time.time >= nextFireTime)
			{
				FireProjectile ();				
			}
		}
	}
	
	void OnTriggerEnter(Collider other)
	{		
		if (other.gameObject.tag == "Enemy")
		{
			nextFireTime = Time.deltaTime + (reloadTime*0.75f);
			myTarget = other.gameObject.transform;			
		}
		if(other.gameObject.tag == "Projectile_Boulder")
			Physics.IgnoreCollision(this.gameObject.collider, other.gameObject.collider);
	}
	
	void OnTriggerExit(Collider other)
	{		
		if (other.gameObject.transform == myTarget)
		{
			myTarget = null;
		}		
	}
	
	void CalculateAimPosition(Vector3 targetPos)
	{		
		Vector3 aimPoint = new Vector3(targetPos.x, targetPos.y, targetPos.z);
		desiredRotation = Quaternion.LookRotation (aimPoint);
	}
	
	void FireProjectile()
	{
		audio.Play();
		nextFireTime = Time.time+reloadTime;
		nextMoveTime = Time.time+firePauseTime;
		
		Instantiate (Boulder_Projectile, transform.position, BarrelEnd.rotation);
		
		Boulder_Projectile.transform.LookAt (myTarget.transform.position);
	}	
}