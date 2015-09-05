using UnityEngine;
using System.Collections;

public class BackgroundAudio : MonoBehaviour {

	private string theCollider;

	void onTriggerEnter(Collider other)
	{
		theCollider = other.tag;
		if(theCollider == "Player")
		{
			audio.Play();
			audio.loop = true;


		}
	}

	void OnTriggerExit(Collider other)
	{
		theCollider = other.tag;
		if(theCollider == "Player")
		{
			audio.Stop();
			audio.loop = false;
		}
	}
}
