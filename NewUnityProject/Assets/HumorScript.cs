using UnityEngine;
using System.Collections;

public class HumorScript : MonoBehaviour 
{
	public int Humor = 5;
	
	void Start()
	{
	
		switch (Humor)
		{
			case 5:
			print ("there was a molisk and sea cucumber");
			break;
			case 4:
			print ("why did the monkey cross the road?");
			break;
			default:
			print ("I am funny. See?");
			break;
		}
	}
}