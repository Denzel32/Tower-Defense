using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EntranceScript : MonoBehaviour {

	public Text shopText;
	public float fadeSpeed = 5f;
	public bool entrance;
	public GameObject EntranceOpen;

	void Awake()
	{
		shopText = EntranceOpen.GetComponentInChildren<Text> ();
		shopText.color = Color.clear;
	}

	void Update()
	{
		ColorChange ();
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
			entrance = true;
	}
	void OnTriggerExit (Collider other)
	{
		if(other.gameObject.tag == "Player")
			entrance = false;
	}

	void ColorChange()
	{
		if (entrance)
			shopText.color = Color.Lerp (shopText.color, Color.white, fadeSpeed * Time.deltaTime);
		if(!entrance)
			shopText.color = Color.Lerp(shopText.color, Color.clear, fadeSpeed * Time.deltaTime);
	}
}
