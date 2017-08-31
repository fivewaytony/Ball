using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCoin : MonoBehaviour {

	// Use this for initialization

	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.name =="Ball")
		{
			GameObject.Find("GameManager").SendMessage("RedCoinStart");
			Destroy(gameObject);
		}
		
	
	}

	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
