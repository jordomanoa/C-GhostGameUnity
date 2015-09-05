using UnityEngine;
using System.Collections;
public class RespawnMenu : MonoBehaviour
{
	public MouseLook LookAround01;
	public MouseLook LookAround02;
	public CharacterMotor CharMotor;
	public int NoOfEnemies = 7;
	public GameObject WinnerBanner;
	public GameObject Lives3;
	public GameObject Lives2;
	public GameObject Lives1;
	public GameObject Lives0;
	public GameObject GameOver;

	public static bool PlayerIsDead = false;
	public int LivesUsed = 0;

	public Transform RespawnTransform;

	void Start()
	{
		LookAround01 = (MouseLook)gameObject.GetComponent(typeof(MouseLook));
		LookAround02 = (MouseLook)GameObject.Find("Main Camera").GetComponent(typeof(MouseLook));
		CharMotor = (CharacterMotor)gameObject.GetComponent(typeof(CharacterMotor));
	}
	void Update()
	{
	
		if (NoOfEnemies <= 0) 
		{
		WinnerBanner.SetActive (true);
		LookAround01.enabled = false;
		LookAround02.enabled = false;
		CharMotor.enabled = false;
		}


		else if (PlayerIsDead)
		{
			LookAround01.enabled = false;
			LookAround02.enabled = false;
			CharMotor.enabled = false;


		}
		else if (!PlayerIsDead)
		{
			LookAround01.enabled = true;
			LookAround02.enabled = true;
			CharMotor.enabled = true;
		}
	}
	void OnGUI()
	{
		if (PlayerIsDead)
		{
			Debug.Log ("The player has died");
			if(LivesUsed<2)
			{
				if (GUI.Button(new Rect(Screen.width / 2 - 50, 200 - 20, 100, 40), "Respawn!"))
				{
					RespawnPlayer();
				}
			}
			else
				{
					Lives3.SetActive(false);
					Lives2.SetActive(false);
					Lives1.SetActive(false);
					Lives0.SetActive(true);
					GameOver.SetActive(true);
			}
				
				
		}
	}
	void RespawnPlayer()
	{
		transform.position = RespawnTransform.position;
		transform.rotation = RespawnTransform.rotation;
		gameObject.SendMessage ("RespawnStats");
	    Debug.Log("Respawning Player!");
		PlayerIsDead = false;
		LivesUsed += 1;

		if (LivesUsed  == 0)
		{
			Lives3.SetActive(true);
			Lives1.SetActive(false);
			Lives2.SetActive(false);
			Lives0.SetActive(false);
			
		}
		if (LivesUsed == 1)
		{
			Lives3.SetActive(false);
			Lives2.SetActive(true);
			Lives1.SetActive(false);
			Lives0.SetActive(false);
			
		}
		if (LivesUsed == 2)
		{
			Lives3.SetActive(false);
			Lives2.SetActive(false);
			Lives1.SetActive(true);
			Lives0.SetActive(false);
			
		}
	}

}﻿