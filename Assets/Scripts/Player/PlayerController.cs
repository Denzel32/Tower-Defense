using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	private float Movespeed = 0.1f;
	private float jumpSpeed = 10.0f;

	private bool canJump = false;

	public float mouseSensivity = 5.0f;
	private bool lockedRot = false;
	MouseLook looking;

	void Start () 
	{
		looking = GetComponent<MouseLook> ();
	}

	void Update () 
	{
		Debug.Log (Movespeed);

		if(Input.GetKey (KeyCode.LeftShift))
			Movespeed = 0.2f;

		if (!Input.GetKey (KeyCode.LeftShift))
			Movespeed = 0.1f;

		if (Input.GetKeyDown (KeyCode.G))
			lockedRot = lockedRot == false ? true : false;

		if (lockedRot == false)
			looking.enabled = true;
		 else
			looking.enabled = false;
	
		//Movement
		if (Input.GetKey (KeyCode.W))
			this.transform.Translate (Vector3.forward * Movespeed);
		if (Input.GetKey (KeyCode.A))
			this.transform.Translate (Vector3.left * Movespeed);
		if (Input.GetKey (KeyCode.S))
			this.transform.Translate (Vector3.back * Movespeed);
		if (Input.GetKey (KeyCode.D))
			this.transform.Translate (Vector3.right * Movespeed);

		if (Input.GetKeyDown (KeyCode.Space) && canJump == true)
		{
			rigidbody.AddForce (0,200,0);
			canJump = false;
		}
	}

	void OnCollisionEnter(Collision other)
	{
		canJump = true;
	}
}
