using UnityEngine;
using System.Collections;

public class Arsonisttext : MonoBehaviour {
	private bool DrawGUI = false;
	
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
			GUI.Box(new Rect(Screen.width / 2 - 250, Screen.height / 2 - 40, 500, 22), "RIP Andrew the Arsonist who died in his sleep at the age of 83");
		}
	}
}