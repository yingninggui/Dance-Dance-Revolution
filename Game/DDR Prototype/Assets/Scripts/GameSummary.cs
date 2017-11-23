using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameSummary : MonoBehaviour {

    public const string HITS_TAG = "# Hits: ", MISSES_TAG = "# Misses: ";

    public Text HitsText, MissesText;
    public GameNavigation game;

    void Start(){
        UpdateScore();
    }

    private bool UpdateScore(){
        HitsText.text = HITS_TAG + GameNavigation.hits;
        MissesText.text = MISSES_TAG + GameNavigation.misses;
        return true;
    }

    public void playAgain(){
        Debug.Log("Play again called");
        game.restartGame();
    }
}
