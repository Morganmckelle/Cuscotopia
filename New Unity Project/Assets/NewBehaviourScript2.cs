using UnityEngine;
using System.Collections;

public class NewBehaviourScript2: MonoBehaviour 
{
	float coffeeTemperature= 85.0f;
	float hotLimitTemperature=70.0f;
	float coldLimitTemperature=40.0f;
	
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Space))
			TemperatureTest ();
		
		coffeeTemperature -= Time.deltaTime * 5f;
	}
	
	
	
	void TemperatureTest () 
	{
		//... if the coffee temperature is greater than the hot limit temperature....
		if (coffeeTemperature > hotLimitTemperature)
		{
			//... then it will do this 
			print ("coffee is too hot.");
		}
		// .. if it isn't but the coffee temperature is less than cold limit temperature....
		else if (coffeeTemperature < coldLimitTemperature)
		{
			//... then do this
			print ("coffee is too cold.");
		}
		// .... if neither of these , then
		else
		{
			//.. then this
			print ("coffee is just right.");
		}
	}
}