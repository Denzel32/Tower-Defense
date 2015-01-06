using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ArrowT_Upgrades : MonoBehaviour {

	public Text ArrowTowerUpgradeText;
	public float fadeSpeed = 5f;
	public bool Entered;
	public GameObject Canvas;
	
	void Awake()
	{
		ArrowTowerUpgradeText = Canvas.GetComponentInChildren<Text> ();
		ArrowTowerUpgradeText.color = Color.clear;
	}
	
	void Update()
	{
		ColorChange ();
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
			Entered = true;
	}
	void OnTriggerExit (Collider other)
	{
		if(other.gameObject.tag == "Player")
			Entered = false;
	}
	
	void ColorChange()
	{
		if (Entered)
			ArrowTowerUpgradeText.color = Color.Lerp (ArrowTowerUpgradeText.color, Color.white, fadeSpeed * Time.deltaTime);
		if(!Entered)
			ArrowTowerUpgradeText.color = Color.Lerp(ArrowTowerUpgradeText.color, Color.clear, fadeSpeed * Time.deltaTime);
	}
}