using UnityEngine;
using System.Collections;

public class RTSBuild : MonoBehaviour {
	
	//HUD
	public Texture RTSUI;
	private float guiPlacementX1 = 0;
	private float guiPlacementY1 = 0;

	void OnGUI()
	{
		GUI.DrawTexture (new Rect (Screen.width * guiPlacementX1, Screen.height * guiPlacementY1, Screen.width * 1.0f, Screen.height * 1.0f), RTSUI);
		GUI.depth = 5;
	}
}
