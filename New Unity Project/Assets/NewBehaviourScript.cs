using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	int newInt =8;
	void Start () {
		newInt = DividebyTwo (newInt);
		Debug.Log (newInt);
	}
	int DividebyTwo (int number){

	int ret;

		ret = number / 2;

		return ret;
	
	
	}
}
