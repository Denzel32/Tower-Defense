using UnityEngine;
using System.Collections;

public class RTSGui : MonoBehaviour {

	//Custom Cursor
	public Texture2D cursorNormal;
	public Texture2D cursorClick;

	private int cursorWidth = 32;
	private int cursorHeight = 32;

	void OnGUI()
	{
		GUI.depth = 0;
		if(Input.GetKey(KeyCode.Mouse0))
			GUI.DrawTexture (new Rect (Input.mousePosition.x, Screen.height - Input.mousePosition.y, cursorWidth, cursorHeight), cursorClick);
		else
			GUI.DrawTexture (new Rect (Input.mousePosition.x, Screen.height - Input.mousePosition.y, cursorWidth, cursorHeight), cursorNormal);
	}

	void Update()
	{
		Screen.showCursor = false;
	}
}
