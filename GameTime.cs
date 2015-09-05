using UnityEngine;
using System.Collections;

public class GameTime : MonoBehaviour {

	public Transform[] sun;
	public int delay = 1;

	void start ()
	    {

		}
	void Update ()
		{
		if (delay == 5) 
			{
						sun [0].Rotate (Vector3.right * Time.deltaTime);
						delay = 1;
			}
		else
			{
				delay+=1;
			}
		}
}