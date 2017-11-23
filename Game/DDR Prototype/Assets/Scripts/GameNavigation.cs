using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class GameNavigation : MonoBehaviour {

	private AssetBundle importedScenes;
	private string[] scenes;
    public static int current_song = AudioManager.borns;

    public const int START = 0, GAME = 1, SUMMARY = 2; 

	void Start() {
        importedScenes = AssetBundle.LoadFromFile("Assets/AssetBundles/scenes");
        scenes = importedScenes .GetAllScenePaths();
        DontDestroyOnLoad(this);
        //SceneManager.LoadScene("Start", LoadSceneMode.Single);
	}

	public Texture play; 

	void OnGUI() {
<<<<<<< HEAD
		if (GUI.Button (new Rect (1, 1, 4, 4), "Play")) {
=======
        Debug.Log("ABOUT TO DO SOMETHING LMAO");
		if (GUI.Button (new Rect (1, 1, 0, 0), "Play")) {
>>>>>>> a045635ef47ff2415e521545aeb8e5ac54219b99
			SceneManager.LoadScene (scenes[0], LoadSceneMode.Single);
			Debug.Log ("awake");
		}
		if (GUI.Button (new Rect (1, 1, 4, 4), "Play Again")) {
		//	SceneManager.LoadScene  ("Start");
			SceneManager.LoadScene (scenes[2], LoadSceneMode.Single);
		}
		if (gameEnd(1)) {
		//	SceneManager.LoadScene ("GameSummary");
			SceneManager.LoadScene (scenes[1], LoadSceneMode.Single);
		}
	}

	public bool gameEnd(int end) {
		if (end == 1) {
			return true; 
		} else {
			return false; 
		}
	}

    private void loadScene(int s)
    {
        SceneManager.LoadScene(s, LoadSceneMode.Single);
    }

    public void SongSelected(int i)
    {
        current_song = i;
        loadScene(GAME);
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

	
	// Update is called once per frame
	void Update () {
		
	}
}
