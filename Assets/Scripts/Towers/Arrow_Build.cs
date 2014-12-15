using UnityEngine;
using System.Collections;

public class Arrow_Build : MonoBehaviour {

	private GameObject[] objects;

	private RaycastHit hit;

	//private Color newColor;

	void Start () 
	{
		//newColor = new Color (0, 1, 0, 0.5f);
	}

	void Update () 
	{
		Ray ray;
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		objects = GameObject.FindGameObjectsWithTag("Schematic");

		for(int i = 0 ; i < objects.Length ; i++)
		{
			//objects[i].renderer.material.color = newColor;
			if (Physics.Raycast(ray, out hit, 100))
			{
				objects[i].transform.position = new Vector3(hit.point.x, hit.point.y, hit.point.z);
			}
		}

		Collider[] hitColliders = Physics.OverlapSphere(this.transform.position, 2f);

		for (int i = 0; i < hitColliders.Length; i++) 
		{
			//
		}
		//Debug.Log (toChangeColor.Length);
	}
}
