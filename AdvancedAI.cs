using UnityEngine;
using System.Collections;

public class AdvancedAI : MonoBehaviour
{

//Variables for enemy which gives values to enemy 
	public Transform Target;
	public CharacterController Controller;
	public int Damage = 20;
	public float Distance;
	public float LookAtDistance = 25.0f;
	public float AttackRange = 2.0f;
	public float ChaseRange = 15.0f;
	public float MoveSpeed = 5.0f;
	public float Damping = 6.0f;
	public float Gravity = 20.0f;
	public int AttackRepeatTime = 3;
	//public GameObject x;

	private float AttackTime;
	private Vector3 MoveDirection = Vector3.zero;
	//public floats can be changed in the console
	
	void Start()
	{

		AttackTime = Time.time;//this gives a counting value for attack intervals
	}
	void Update()
	{
				if (RespawnMenu.PlayerIsDead == false) {
	

						Distance = Vector3.Distance (Target.position, transform.position); //enemy moves to look at player if within the distance given
						//Debug.Log ("Distance=" + Distance + "AttackRange=" + AttackRange);
						if (Distance < LookAtDistance) {
								LookAt ();
						}
						if (Distance > LookAtDistance) { //if the enemy is not looking at the player because the player is too far away the colour stays green
								renderer.material.color = Color.green;
						}
						if (Distance < AttackRange) { //if the enemy is able to attack then is should attack and stop chasing
								Attack ();
						} else if (Distance < ChaseRange) { //if the previous requirements are not met then it should chase
								Chase ();
						}
				}
		}
	void LookAt() //when closer to the enemy the enemy will move to look at player and also turn yellow
	{
		renderer.material.color = Color.yellow;
		Quaternion rotation = Quaternion.LookRotation(Target.position - transform.position);
		transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * Damping);
	}
	void Chase() //if the enemy is chasing the player due to him being too close the colour will be red and locks on to player 
	{
		renderer.material.color = Color.red;
		MoveDirection = transform.forward;
		MoveDirection *= MoveSpeed;
		MoveDirection.y -= Gravity * Time.deltaTime;
		Controller.Move(MoveDirection * Time.deltaTime);
	}
	void Attack()//the enemy attacks the player at intervals with AttackRepeatTime giving the time between attacks 
	{ 
		//Debug.Log ("Time=" + Time.time + "Attacktime=" + AttackTime);
		//x = GameObject.Find ("Player 1");
		if (Time.time > AttackTime)
		{	
			Target.SendMessage("theDamage",Damage, SendMessageOptions.DontRequireReceiver);
			Debug.Log("TheEnemyHasAttacked"); //shows when the player is attacked in console
			AttackTime = Time.time + AttackRepeatTime;
		}
	}
	void ApplyDamage() //this gives the enemy a more realistic AI so that when its attacking you it wants to chase you more and look seek you out and the movement speed also increases 
	{
		ChaseRange += 30.0f;
		MoveSpeed += 2.0f;
		LookAtDistance += 40.0f;
	}
}