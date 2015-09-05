using UnityEngine;
using System.Collections;

public class Huntsmantext : MonoBehaviour {
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
			GUI.Box(new Rect(Screen.width / 2 - 250, Screen.height / 2 - 40, 500, 22), "Here Lies Harry the Huntsman, who was mauled by a bear in his tent");
		}
	}
}