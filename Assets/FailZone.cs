using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailZone : MonoBehaviour {

	void OnTriggerEnter(Collider collider)
	{
		if(collider.gameObject.name =="Ball")
		{
			GameObject.Find("GameManager").SendMessage("Restart");
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
