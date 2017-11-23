// File to be deleted.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundInput : MonoBehaviour {
    public AudioManager audio;
    private int frame_count = 0;

	void Awake () {
        audio.playSound();
    }

	void Update (){
	}

}