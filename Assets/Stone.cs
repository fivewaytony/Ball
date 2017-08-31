using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour {
	Vector3 target;
	// Use this for initialization
	void Start () {
		target = GameObject.Find("Ball").transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position,target,0.1f);	
		transform.Rotate(new Vector3(0,0,5f));
	}
	void OnTriggerEnter(Collider collider)
	{
		if(collider.gameObject.name =="Ball")
		{
			GameObject.Find("GameManager").SendMessage("Restart");
		}
	}
}
