using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    public const string HITS_TAG = "Hits: ", MISSES_TAG = "Misses: ";
	public int hitsCount = 0;
	public int missesCount = 0;

    public Text HitsText, MissesText;

	void Start () {
		UpdateScore (); 
	}

	public void SetScore (int hitsNumber, int missesNumber){
		hitsCount = hitsNumber;
		missesCount = missesNumber; 
		UpdateScore ();
	}

	void UpdateScore () {
		HitsText.text = HITS_TAG + hitsCount;
		MissesText.text = MISSES_TAG + missesCount;
	}
		
}	
	