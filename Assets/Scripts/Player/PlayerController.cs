using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public Transform cam;
	private float Movespeed = 50.0f;
	public float mouseSensivity = 5.0f;
	private CharacterController cc;
	private bool lockedRot = false;

	void Start () 
	{
		cc = GetComponent<CharacterController> ();
	}

	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.G))
			lockedRot = lockedRot == false ? true : false;

		if(lockedRot == false)
		{
			//Rotation
			float rotLeftRight = Input.GetAxis ("Mouse X") * mouseSensivity;
			//float upDown = Input.GetAxis ("Mouse Y") * mouseSensivity;
			transform.Rotate (0, rotLeftRight, 0);
		}
	
		//Movement
		float horizontal = Input.GetAxis ("Horizontal") * Movespeed;
		float vertical = Input.GetAxis ("Vertical") * Movespeed;
		 
		Vector3 speed = new Vector3 (horizontal, 0, vertical);

		speed = transform.rotation * speed;

		cc.Move (speed * Time.deltaTime);
	}
}
