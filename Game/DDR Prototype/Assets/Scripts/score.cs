using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour {
	public GameObject scoreKeeper; 

	private int scoreCount = 0; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	} 

	void onClick() {
		scoreCount++; 
	}
}
