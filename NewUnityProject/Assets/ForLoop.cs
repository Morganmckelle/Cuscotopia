using UnityEngine;
using System.Collections;

public class ForLoop : MonoBehaviour
{
	int numEnemies = 3;
	
	
	void Start ()
	{
		for (int i=0; i < numEnemies; i++) 
		{
			Debug.Log ("number of enemies:" + i);
		}

	}
}