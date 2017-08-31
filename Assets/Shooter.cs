using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

	public GameObject stone;
	void OnCollisionEnter(Collision collision)
	{
		Vector3 direction = transform.position - collision.gameObject.transform.position;
		direction  = direction.normalized * 1000;
		collision.gameObject.GetComponent<Rigidbody>().AddForce(direction);
	}

	float delta = 0.1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	float timeCount = 0;
	void Update () {
		timeCount += Time.deltaTime;
		if(timeCount > 3){
			Instantiate(stone,transform.position, Quaternion.identity);
			timeCount = 0;
		}

		float newXposition = transform.localPosition.x + delta;
		transform.localPosition = new Vector3(newXposition 
										, transform.localPosition.y
										, transform.localPosition.z);
		if (transform.localPosition.x < -4f)
		{
			delta =  0.1f;
		}
		if (transform.localPosition.x > 4f)
		{
			delta = -0.1f;
		}
		
	}
}
