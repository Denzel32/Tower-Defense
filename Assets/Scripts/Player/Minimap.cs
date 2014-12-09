using UnityEngine;
using System.Collections;

public class Minimap : MonoBehaviour {

	public Transform playerr;

	void Update () 
	{
		this.transform.position = new Vector3(playerr.position.x, playerr.position.y + 16,playerr.position.z);
	}
}
