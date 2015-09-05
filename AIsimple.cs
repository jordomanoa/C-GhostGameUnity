using UnityEngine;
using System.Collections;

public class AIsimple : MonoBehaviour
{
	public float damping = 6.0f;
	public float lookAtDistance = 25.0f;
	public float distance;
	public float attackRange = 15.0f;
	public float moveSpeed = 5.0f;


	public Transform target;
	
	void Update()
	{
		distance = Vector3.Distance(target.position, transform.position);
		
		if(distance < lookAtDistance)
		{
			renderer.material.color = Color.yellow;
			LookAt();
		}
		
		if(distance > lookAtDistance)
		{
			renderer.material.color = Color.green;
		}
		
		if (distance < attackRange)
		{
			renderer.material.color = Color.red;
			AttackPlayer();
		}
	}
	
	void LookAt()
	{
		Quaternion rotation = Quaternion.LookRotation(target.position - transform.position);
		transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
	}
	
	void AttackPlayer()
	{
		transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
	}
}