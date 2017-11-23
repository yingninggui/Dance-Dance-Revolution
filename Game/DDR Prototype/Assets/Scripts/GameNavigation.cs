using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

/*
 * Remains in existence throughout all scenes (uses DontDestroyOnLoad)
 * in order to switch between game scenes on certain events
 */
public class GameNavigation : MonoBehaviour {

	private AssetBundle importedScenes;
    public static int current_song = AudioManager.borns;

    public const int START = 0, GAME = 1, SUMMARY = 2;

    public static int hits, misses;

	void Start() {
        DontDestroyOnLoad(this);
	}

    private void loadScene(int s){
        SceneManager.LoadScene(s, LoadSceneMode.Single);
    }

    public void songSelected(int i) {
        current_song = i;
        loadScene(GAME);
    }

    public void endGame(int h, int m){
        hits = h;
        misses = m;
        loadScene(SUMMARY);
    }

    public void restartGame() {
        loadScene(START);
    }

	void Update () {
	}
}
