using UnityEngine;
using System.Collections;

public class Gravediggertext : MonoBehaviour {
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
			GUI.Box(new Rect(Screen.width / 2 - 300, Screen.height / 2 - 40, 600, 22), "Rest In Peace Garry The Gravedigger who buried many of the souls in this graveyard");
		}
	}
}