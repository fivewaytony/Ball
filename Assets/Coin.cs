using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.name =="Ball")
		{
			GameObject.Find("GameManager").SendMessage("GetCoin");
			Destroy(gameObject);
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
