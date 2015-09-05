using UnityEngine;
using System.Collections;

public class Intro : MonoBehaviour {
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
			GUI.Box(new Rect(Screen.width / 2 - 200, Screen.height / 2 - 40, 400, 95), "You awake from a deep sleep to find the graveyard \nyou are guarding has been ransacked\nby graverobbers but now the resting souls\n have been disturbed and want revenge.\nCheck the graveyard to see whos graves have been disturbed.\n Be careful as the sun is about to set");
		}
	}
}