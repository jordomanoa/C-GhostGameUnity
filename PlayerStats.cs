using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {
	public int maxhealth = 100;
	public int health;
	public string HealthString;
	public GameObject FullHealth;
	public GameObject MedHealth;
	public GameObject LowHealth;
	public GameObject DeadHealth;
	public bool HaveSword = false;
	public bool HaveTorch = false;



	void start ()
	{
		health = maxhealth;
	}
	
	void theDamage(int damage)
	{

		health -= damage;
		if (health >= 70)
		{
			FullHealth.SetActive(true);
			MedHealth.SetActive(false);
			LowHealth.SetActive(false);
			DeadHealth.SetActive(false);

		}
		if (health <= 50)
		{
			FullHealth.SetActive(false);
			MedHealth.SetActive(true);
			LowHealth.SetActive(false);
			DeadHealth.SetActive(false);

		}
		if (health <= 20)
		{
			FullHealth.SetActive(false);
			MedHealth.SetActive(false);
			LowHealth.SetActive(true);
			DeadHealth.SetActive(false);

		}
		
		if (health <= 0)
		{
			FullHealth.SetActive(false);
			MedHealth.SetActive(false);
			LowHealth.SetActive(false);
			DeadHealth.SetActive(true);
			Dead();
		}
	}

	void OnGUI()
	{
		HealthString = health.ToString ("#");
		if (health > 0) 
		{
		GUI.TextArea (new Rect (265, Screen.height - 40, 30, 20), HealthString);
		}
	}
	
	void Dead()
	{
		RespawnMenu.PlayerIsDead = true;
		Debug.Log("PlayerIsDead");
	}

	void RespawnStats ()
	{
		health = maxhealth;
		FullHealth.SetActive(true);
	}
	}
