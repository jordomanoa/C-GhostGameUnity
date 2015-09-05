using UnityEngine;
using System.Collections;

public class WellHealth : MonoBehaviour {

	private bool DrawGUI = false;
	
	void Update()
	{
		if (DrawGUI && Input.GetKeyDown(KeyCode.E))
		{
			GameObject.Find ("Player").GetComponent<PlayerStats> ().health = 100;
			GameObject.Find ("Player").GetComponent<PlayerStats> ().FullHealth.SetActive(true);
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			DrawGUI = true;
		}
	}
	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			DrawGUI = false;
		}
	}
	void OnGUI()
	{
		if (DrawGUI)
		{
			GUI.Box(new Rect(Screen.width / 2 - 51, Screen.height / 2 - 40, 109, 22), "Press 'E' to drink.");
		}
	}
}
