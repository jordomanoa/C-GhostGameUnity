using UnityEngine;
using System.Collections;

public class MeleeSystem : MonoBehaviour {
	public int damage = 50;
	public float distance;
	public float maxDistance = 1.5f;


	
	RaycastHit hit;
	
	void Update()
	{
		if (Input.GetButtonDown ("Fire1"))
		{
			animation.Play("Attack");
			animation.Play("SwordAttack");
		}
		
		if (animation.isPlaying == false)
		{
			animation.CrossFade("Idle1");      
		}
		
		if (Input.GetKey (KeyCode.LeftShift))
		{
			animation.CrossFade("Sprint");
		}
		
		if (Input.GetKeyUp (KeyCode.LeftShift))
		{
			animation.CrossFade("Idle1");
		}

	}
	
	public void Attack()
	{
		// Attack Function
		if (Physics.Raycast (transform.parent.position, transform.parent.TransformDirection (Vector3.forward), out hit))
		{
			distance = hit.distance;
			if (distance < maxDistance)
			{
				hit.transform.SendMessage ("ApplyDamage", damage, SendMessageOptions.DontRequireReceiver);
			}
		}
	

	if (animation.isPlaying == false)
	{
		animation.CrossFade("Idle1");      
	}
	
	if (Input.GetKey (KeyCode.LeftShift))
	{
		animation.CrossFade("Sprint");
	}
	
	if (Input.GetKeyUp (KeyCode.LeftShift))
	{
		animation.CrossFade("Idle1");
	}

}
}