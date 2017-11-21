using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {
	public GameObject scoreKeeper = new GameObject("Score"); 
	public string hits; 
	public string misses; 
	void Start () {

	}

	void Update (){
		Text text = scoreKeeper.GetComponent<Text> ();
		text.text = hits;
	}
		
	void PrintResults (string hitsNumber, string missesNumber){
		Text text = scoreKeeper.GetComponent<Text> ();
		hits = "hits: "; 
		hits += hitsNumber; 
		text.text = hits; 
		misses = ""; 
		misses += missesNumber; 
		text.text = misses; 
		scoreKeeper.AddComponent<Text> ();
	}

	void OnGUI() {
		GUI.Label(new Rect(10, 10, 100, 20), hits);
	}


}	

