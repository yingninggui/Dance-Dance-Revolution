using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameNavigation : MonoBehaviour {

	public GameObject musicSelected;
	public GameObject gameSummarySelected; 
	public GameObject startSelected; 

	public void LoadScene(int scene) {

		if (scene == 1) {
			musicSelected.SetActive (true); 
			gameSummarySelected.SetActive (false); 
			startSelected.SetActive (false);
		} else if (scene == 2) {
			gameSummarySelected.SetActive (true); 
			musicSelected.SetActive (false); 
			startSelected.SetActive (false);
		}
		else {
			startSelected.SetActive (true);
			gameSummarySelected.SetActive (false); 
			musicSelected.SetActive (false); 
		}

		Application.LoadLevel(scene);
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
