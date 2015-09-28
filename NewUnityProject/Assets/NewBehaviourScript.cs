using UnityEngine;
using System.Collections;

public class NewBehaviourScript: MonoBehaviour 
{
	private float heightTest = 3f;
	void Start ()
	{ // i can type whatever I want right here :) 
		/*
		 * ***
		 */

		Debug.Log (transform);
		if(transform.position.y <= heightTest)
		{
			Debug.Log("I'm about to hit the ground!");
			FlyAway();
		}
		else if(transform.position.y >= heightTest)
		{
			Debug.Log("I'm flying!");
		}
	}
	private void FlyAway()
	{
		Debug.Log ("Fly Away!");
		Vector3 newPosition = new Vector3(0,7,0);
		transform.position = newPosition;
	}
}