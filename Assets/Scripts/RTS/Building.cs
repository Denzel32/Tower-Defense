using UnityEngine;
using System.Collections;

public class Building : MonoBehaviour {
	
	public GameObject Arrow_Tower;
	public GameObject Arrow_Tower_Build;

	public GameObject Boulder_Tower;
	public GameObject Boulder_Tower_Build;

	public GameObject toBuild;
	public GameObject buildSchematic;

	private GameObject[] Schematics;

	private RaycastHit hit;

	private bool ReadytoBuild = false;

	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Alpha1) && buildSchematic == null)
		{
			ReadytoBuild = ReadytoBuild == false ? true : false;
			toBuild = Arrow_Tower;
			buildSchematic = Arrow_Tower_Build;
			Instantiate (buildSchematic);
		}
		if (Input.GetKeyDown (KeyCode.Alpha2) && buildSchematic == null)
		{
			ReadytoBuild = ReadytoBuild == false ? true : false;
			toBuild = Boulder_Tower;
			buildSchematic = Boulder_Tower_Build;
			Instantiate(buildSchematic);
		}

		Ray ray;
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		if(ReadytoBuild == true)
		{
			if(Input.GetKeyDown (KeyCode.Mouse0))
			{
				if (Physics.Raycast(ray, out hit, 100))
				{
					ReadytoBuild = false;
					Instantiate (toBuild, hit.point, Quaternion.identity);
					buildSchematic = null;
					DestroyAllObjects();
				}
			}
			if(Input.GetKeyDown(KeyCode.Mouse1))
			{
				ReadytoBuild = false;
				buildSchematic = null;
				DestroyAllObjects();
			}
		}
	}

	void DestroyAllObjects()
	{
		Schematics = GameObject.FindGameObjectsWithTag("Schematic");

		for(int i = 0 ; i < Schematics.Length ; i++)
		{
			Destroy(Schematics[i]);
		}
	}
}
