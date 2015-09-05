using UnityEngine;
using System.Collections;

public class GetTorch : MonoBehaviour {

	private bool DrawGUI = false;
	public GameObject TForTorch;
	
	void Update()
	{
		if (DrawGUI && Input.GetKeyDown(KeyCode.E))
		{
			GameObject.Find ("Player").GetComponent<PlayerStats> ().HaveTorch = true;
			TForTorch.SetActive(true);
			Destroy (gameObject);
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
			GUI.Box(new Rect(Screen.width / 2 - 200, Screen.height / 2 - 40, 400, 50), "Its getting dark, this torch will come in handy\nPress E to Pick Up Torch");
		}
	}
			        }

