using UnityEngine;
using System.Collections;

public class weaponswitch : MonoBehaviour {
		public GameObject weapon01;
		public GameObject weapon02;
		public GameObject MaceStats;
		public GameObject SwordStats;

	void Update ()
	{
				if (Input.GetKeyDown (KeyCode.Q)) {
						if (GameObject.Find ("Player").GetComponent<PlayerStats> ().HaveSword == true) {
								SwapWeapons ();
						}
				}
		}

	void SwapWeapons()

	{
		if (weapon01.active == true) 
		{
			weapon01.SetActive(false);
			weapon02.SetActive(true);
			MaceStats.SetActive(false);
			SwordStats.SetActive(true);
		}
		else
		{
			weapon01.SetActive(true);
			weapon02.SetActive(false);
			MaceStats.SetActive(true);
			SwordStats.SetActive(false);
		}
		
	}
}