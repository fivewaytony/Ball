using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	int startingPostion;
	SphereCollider myCollider;
	// Use this for initialization
	void Start () {
		myCollider = GetComponent<SphereCollider>(); 
		Rigidbody myRigidbody = GetComponent<Rigidbody>();
		Debug.Log("UseGravity ? : " + myRigidbody.useGravity);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
		{
			GetComponent<Rigidbody>().AddForce(Vector3.up*300);
		}
	}
}
