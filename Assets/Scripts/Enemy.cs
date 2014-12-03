using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		Color newColor = new Color(Random.value, Random.value, Random.value);
		renderer.material.color = newColor;
	}
	
	// Update is called once per frame
	void Update () 
	{

	
	}
}
