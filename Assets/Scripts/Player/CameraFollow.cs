using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform playerr;
	public bool RTSMode = false;

	private RTSGui rtsGui;
	private RTSBuild rtsBuild;
	private ReticleScript ret;
	private Building build;

	private MouseLook looking;

	public int GoldAmmount = 0;

	void Start()
	{
		looking = GetComponent<MouseLook> ();
		build = GetComponent<Building> ();
		ret = GetComponent<ReticleScript> ();
		rtsGui = GetComponent<RTSGui> ();
		rtsBuild = GetComponent<RTSBuild> ();
	}

	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.G))
		{
			RTSMode = RTSMode == false ? true : false;
		}

		if(RTSMode == false)
		{
			looking.enabled = true;
			ret.enabled = true;
			rtsGui.enabled = false;
			rtsBuild.enabled = false;
			build.enabled = false;
			Screen.lockCursor = true;
			this.transform.position = new Vector3 (playerr.position.x, playerr.position.y + 1,playerr.position.z);
			this.transform.localEulerAngles = new Vector3(0,0,0);
		}

		if(RTSMode == true)
		{
			looking.enabled = false;
			ret.enabled = false;
			rtsGui.enabled = true;
			rtsBuild.enabled = true;
			build.enabled = true;
			Screen.lockCursor = false;
			Screen.showCursor = false;
			this.transform.position = new Vector3 (playerr.position.x, playerr.position.y + 25,playerr.position.z);
			this.transform.localEulerAngles = new Vector3(90,0,0);
		}
	}

	void OnGUI()
	{
		GUI.Label(new Rect (10, 420, 80, 50), "Gold : " + GoldAmmount);
	}
}
