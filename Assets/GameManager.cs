using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	int coinCount = 0;
	public Text coinText;
	void GetCoin()
	{
		coinCount++;
		coinText.text = coinCount +"개";
	}
	void Restart()
	{
		Application.LoadLevel("Game");
	}
	void RedCoinStart()
	{
		DestroyObstacles();
	}

	
	void DestroyObstacles(){
		GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");	
		for(int i=0; i<obstacles.Length;i++)
		{
			Destroy(obstacles[i]);
		}
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
