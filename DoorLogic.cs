using UnityEngine;
using System.Collections;
public class DoorLogic : MonoBehaviour
{
	public Transform Door;
	private bool DrawGUI = false;
	private bool DoorIsClosed = true;
	protected Animator doorAnimator;

	void Update()
	{
		if (DrawGUI && Input.GetKeyDown(KeyCode.E))
		{
			DrawGUI = false;
			StartCoroutine("ChangeDoorState");
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
			GUI.Box(new Rect(Screen.width / 2 - 51, Screen.height / 2 - 40, 109, 22), "Press 'E' to open.");
		}
	}
	IEnumerator ChangeDoorState()
	{
		if (DoorIsClosed)
		{
			Door.animation.CrossFade("Open");
			DoorIsClosed = false;
			yield return new WaitForSeconds(3.0f);
			Door.animation.CrossFade("Close");
			DoorIsClosed = true;
		}
	}
}﻿