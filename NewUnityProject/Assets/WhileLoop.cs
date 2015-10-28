using UnityEngine;
using System.Collections;

public class SingleCharacterScript : MonoBehaviour
{
	public class Stuff
	{
		public int bullets;
		public int grenades;
		public int rockets;
		
		public Stuff(int bul, int gre, int roc)
		{
			bullets = bul;
			grenades = gre;
			rockets = roc;
		}
		
		// Constructor
		public Stuff ()
		{
			bullets = 1;
			grenades = 1;
			rockets = 1;
		}
	}
	
	
	
	
	public Stuff myStuff = new Stuff(10, 7, 25);
	
	
}	