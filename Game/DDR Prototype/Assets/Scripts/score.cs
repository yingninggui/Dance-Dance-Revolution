using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {
	public GameObject scoreKeeper; 
	public int hits; 
	public int misses; 

	void Start () {
		hits = 0;
		misses = 0; 
		SetScoreText ();
		//hits.text = "";
	}

	void Update (){
		
	}

	void OnTriggerEnter(Collider arrowTapped) {
		if (arrowTapped) {
			//SetscoreCountText (); 
			//scoreCount++; 
		} else {
			
		}
	}
	void SetScoreText (){
		//hits.Text = hits.ToString ();
	}

}

