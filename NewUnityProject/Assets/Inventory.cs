using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour
{
	public class Games
	{
		public int Risk;
		public int Spades;
		public int COD;
		
		public Games(int ri, int spa, int cod)
		{
			Risk=ri;
			Spades=spa;
			COD=cod;
		}
		public Games()
			{
				Risk=3;
				Spades=9;
				COD=12;
			}
	
	}
	public Games myGame = new Games(4,8,13);
}