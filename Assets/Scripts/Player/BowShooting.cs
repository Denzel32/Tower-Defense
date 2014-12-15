using UnityEngine;
using System.Collections;

public class BowShooting : MonoBehaviour {

	public Transform bow;
	public Transform Arrow;

	private Transform myTarget;

	void Update () 
	{
		Ray ray;
		RaycastHit hit;
		ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		if (Input.GetKeyDown (KeyCode.Mouse0))
		{
			Instantiate(Arrow, bow.position, bow.rotation);
		}
	}
}
