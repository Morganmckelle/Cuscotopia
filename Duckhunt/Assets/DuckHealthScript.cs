﻿using UnityEngine;
using System.Collections;

public class DuckHealthScript : MonoBehaviour 
{
	Animator anim;

	bool isInvincible;

	// Use this for initialization
	void Start () 
	{
		anim= GetComponent<Animator>();
		GameManager.OnDuckMiss += MakeInvincible;
		GameManager.OnDuckShot += MakeInvincible;
	}
	
	// Update is called once per frame
	//void Update () {
	
	//}
	
	
	void OnTriggerEnter(Collider hit)
	{
		if(hit.tag == "Kill Zone")
		{
			Destroy(this.gameObject);
			GameManager.OnDuckDeath();
		}
		if(hit.tag == "FlyZone")
		{
			GameManager.OnDuckFlyAway();
			//destroy the duck here
			Destroy(this.gameObject);
		}

	}
	public void KillDuck()
	{
		if (isInvincible == false) 
		{
			anim.Play ("DuckDead");
			GameManager.OnDuckShot();
		}
	}
	public void MakeInvincible()
	{
		isInvincible = true;
	}
}