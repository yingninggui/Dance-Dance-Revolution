using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {
//	public GameObject scoreKeeper; 
//	public const string hits ="hits: "; 
//	public const string misses = "misses: "; 

	//public GUIText scoreText;
	public GUIText Hits; 
	public GUIText Misses; 
	private int scoreCount; 
	public int hitsCount =0;
	public int missesCount =0;

	void Start () {
		scoreCount = 0;
		UpdateScore (); 
	}

	public void SetScore (int hitsNumber, int missesNumber){

		hitsCount = hitsNumber;
		missesCount = missesNumber; 
		UpdateScore ();

		//text = scoreKeeper.GetComponent<Text> ();
		//text.text = hits + hitsNumber; 
		//text.text = misses + missesNumber; 
		// scoreKeeper.AddComponent<Text> ();
		//GUI.Label(new Rect(4,-3,1,1), scoreKeeper);
	}

	void UpdateScore () {
		Hits.text = "Hits: " + hitsCount;
		Misses.text = "Misess: " + missesCount;
	}
		
}	
	