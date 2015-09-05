using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {
	public int health = 100;
	public GameObject Candle;

	
	void ApplyDamage(int Damage)
	{
		health -= Damage;

		if (health <= 0) 
		{

			Dead();
		}


	}
	
	void Dead()
	{

		GameObject.Find ("Player").GetComponent<RespawnMenu> ().NoOfEnemies -= 1;
		Destroy (gameObject);
		Destroy (Candle);
	}

}