using UnityEngine;
using System.Collections;

public class GetSword : MonoBehaviour {

	private bool DrawGUI = false;
	public GameObject QToChange;
	
	void Update()
	{
		if (DrawGUI && Input.GetKeyDown(KeyCode.E))
		{
			GameObject.Find ("Player").GetComponent<PlayerStats> ().HaveSword = true;
			QToChange.SetActive(true);
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
			GUI.Box(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 40, 200, 22), "Press E to pick up sword");
		}
	}
}
