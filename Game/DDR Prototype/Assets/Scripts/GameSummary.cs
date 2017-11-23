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

    /*
     * Called to update displayed game statistics in game summary
     */
    private bool UpdateScore(){
        HitsText.text = HITS_TAG + GameNavigation.hits;
        MissesText.text = MISSES_TAG + GameNavigation.misses;
        return true;
    }

    /**
     * Called by play again button on click
     */
    public void playAgain(){
        Debug.Log("Play again called");
        game.restartGame();
    }
}
