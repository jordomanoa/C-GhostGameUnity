using UnityEngine;
using System.Collections;

public class Torch : MonoBehaviour {
	public GameObject TorchLight;


	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.T)) {
			if (GameObject.Find ("Player").GetComponent<PlayerStats> ().HaveTorch == true) {
				TurnOn ();
			}
		}
	}
	
	void TurnOn()

	{
		if (TorchLight.active == false)
		{
			TorchLight.SetActive(true);
		}
		else
		{
			TorchLight.SetActive(false);
		}
	}
}
		
