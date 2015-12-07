using UnityEngine;
using System.Collections;

public class DogControl : MonoBehaviour 
{
	Animation anim;

	// Use this for initialization
	void Start () 
	{
		//use getcomponent to get animator
		GameManager.OnDuckDeath += PlayDuck;
		GameManager.OnDuckFlyAway += PlayLaugh;

	}
	
	// Update is called once per frame
	//void Update () 
	//{
	
	//}
	public void SpawnDucks()
	{
		GameManager.OnSpawnDucks ();
	}
	public void PlayLaugh()
	{
		anim.play ("DogLaughAnim");
	}
	public void PlayDuck()
	{
		Anim.play ("DogDuckAnim");
	}

}
