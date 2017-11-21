using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreLabel : MonoBehaviour {

	void onGUI() {
		GUI.Label(new Rect(4,-3,1,1), score.hits);
	}

	void Start () {
		onGUI (); 
	}
	void update() {
		
	}

}
