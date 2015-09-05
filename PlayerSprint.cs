using UnityEngine;
using System.Collections;

public class PlayerSprint : MonoBehaviour {
	public CharacterMotor CharMotor;
	float walkSpeed;
	float sprintSpeed;

	void Start () 
	{
		CharMotor = (CharacterMotor)GetComponent<CharacterMotor>();
		walkSpeed = CharMotor.movement.maxForwardSpeed;
		sprintSpeed = walkSpeed * 2;
	}

	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.LeftShift))
			CharMotor .movement.maxForwardSpeed = sprintSpeed;
		if (Input.GetKeyDown (KeyCode.LeftShift))
			CharMotor.movement.maxForwardSpeed = walkSpeed;
		
	}
}