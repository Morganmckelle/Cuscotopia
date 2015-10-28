using UnityEngine;
using System.Collections;

public class EnumScript : MonoBehaviour 
{
	enum Speed {Slug, Turtle, Rabbit, Cheetah};
	
	
	void Start()
	{
		Speed mySpeed;
		
		mySpeed = Speed.Turtle;
	}
		Speed ReverseSpeed (Speed spd)
		{
			return spd;
		}
}