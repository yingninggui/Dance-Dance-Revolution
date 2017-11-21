using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {
	public GameObject scoreKeeper; 
	public string hits = "hits: "; 
	public string misses = ""; 
	void Start () {

	}

	void Update (){
		Text text = scoreKeeper.GetComponent<Text> ();
		text.text = hits; 
	}
		
	void displayResults (string hitsNumber, string missesNumber){
		Text text = scoreKeeper.GetComponent<Text> ();
		hits = hitsNumber; 
		text.text = hits; 
		misses = missesNumber; 
		text.text = misses; 
		scoreKeeper.AddComponent<Text> ();
		GUI.Label(new Rect(4,-3,1,1), scoreKeeper);
	}
		
}	

