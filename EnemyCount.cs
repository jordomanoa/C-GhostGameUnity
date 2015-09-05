using UnityEngine;
using System.Collections;

public class EnemyCount : MonoBehaviour {
	public int NoOfEnemies = 1;
	public GameObject WinnerBanner;

	// Use this for initialization
	void Update()
	{
		if (NoOfEnemies <= 0) 
		{
			WinnerBanner.SetActive(true);
		}
	}
}
