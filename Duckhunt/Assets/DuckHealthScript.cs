using UnityEngine;
using System.Collections;

public class DuckHealthScript : MonoBehaviour {

	// Use this for initialization
	//void Start () {
	
	//}
	
	// Update is called once per frame
	//void Update () {
	
	//}
	
	
	void OnTriggerEnter(Collider hit)
	{
		if(hit.tag == "Kill Zone")
		{
			Destroy(this.gameObject);
			}
	}
}