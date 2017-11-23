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

    public static int current_song = AudioManager.borns;

    /*
     * Constants representing build order of respective Scene in AssetBundle
     */
    public const int START = 0, GAME = 1, SUMMARY = 2;

    public static int hits, misses;

	void Start() {
        // Allows GameNavigation to exists and not be reloaded as the game 
        // progresses though each scene
        DontDestroyOnLoad(this);
	}

    /*
     * Load Scene in single mode, which deletes objects from current scene, 
     * then loads the next scene
     */
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
