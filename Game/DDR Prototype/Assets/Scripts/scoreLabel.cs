using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreLabel : MonoBehaviour {

	public score scoreTest; 

	void OnGUI() {
		GUI.Label(new Rect(4,-3,1,1), scoreTest.Hits.text);
	}

	void Start () {
		OnGUI ();  
	}
	void update() {
		//scoreTest.AddScore (4,5);
	}

}
