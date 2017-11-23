using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class GameNavigation : MonoBehaviour {

	private AssetBundle importedScenes;
	//private ArrayList scenes;
    public static int current_song = AudioManager.borns;

    public const int START = 0, GAME = 1, SUMMARY = 2;

    public static int hits, misses;

	void Start() {
        //importedScenes = AssetBundle.LoadFromFile("Assets/AssetBundles/scenes");
        /*scenes = new ArrayList(3);
        for(int i = 1; i < 3; i++)
        {
            SceneManager.LoadSceneAsync(i);
            scenes.Add(SceneManager.GetSceneByBuildIndex(i));
        }
        foreach (Scene s in scenes)
        {
            Debug.Log(s.name);
        }*/

        // Don't destroy this object because it is used in all scenes
        DontDestroyOnLoad(this);
	}

    private void loadScene(int s)
    {
        SceneManager.LoadScene(s, LoadSceneMode.Single);
    }

    public void songSelected(int i)
    {
        current_song = i;
        loadScene(GAME);
    }

    public void endGame(int h, int m)
    {
        hits = h;
        misses = m;
        loadScene(SUMMARY);
    }

    public void restartGame()
    {
        loadScene(START);
    }

	
	// Update is called once per frame
	void Update () {
		
	}
}
