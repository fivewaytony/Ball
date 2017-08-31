using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWork : MonoBehaviour {

     GameObject ball;
	void Start () {
		ball = GameObject.Find("Ball");
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(0
										,ball.transform.position.y + 3
										,ball.transform.position.z - 14);
	}
}
