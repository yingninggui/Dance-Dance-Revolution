using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class GameNavigation : MonoBehaviour {

	public GameObject musicSelected;
	public GameObject gameSummarySelected; 
	public GameObject startSelected; 

	public Texture play; 

	public class ExampleClass : MonoBehaviour {
		public Texture btnTexture;
		void OnGUI() {
			if (!btnTexture) {
				Debug.LogError("Please assign a texture on the inspector");
				return;
			}
			if (GUI.Button(new Rect(10, 10, 50, 50), btnTexture))
				Debug.Log("Clicked the button with an image");

			if (GUI.Button(new Rect(10, 70, 50, 30), "Click"))
				Debug.Log("Clicked the button with text");

		}
	}

	void OnGUI() {
		if (GUI.Button (new Rect (10, 10, 5, 5), "Play")) {
			SceneManager.LoadScene ("GameScreen");
		}
		if (GUI.Button (new Rect (10, 10, 5, 5), "Play Again")) {
			SceneManager.LoadScene  ("Start");
		}
		if (gameEnd(1)) {
			SceneManager.LoadScene ("GameSummary");
		}
	}
	bool gameEnd(int end) {
		if (end == 1) {
			return true; 
		} else {
			return false; 
		}
	}

//	public void LoadScene(int scene) {
//
//		if (scene == 1) {
//			musicSelected.SetActive (true); 
//			gameSummarySelected.SetActive (false); 
//			startSelected.SetActive (false);
//		} else if (scene == 2) {
//			gameSummarySelected.SetActive (true); 
//			musicSelected.SetActive (false); 
//			startSelected.SetActive (false);
//		}
//		else {
//			startSelected.SetActive (true);
//			gameSummarySelected.SetActive (false); 
//			musicSelected.SetActive (false); 
//		}
//
//		Application.LoadLevel(scene);
//	}
//
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
