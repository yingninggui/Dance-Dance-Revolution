// File to be deleted.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundInput : MonoBehaviour {
	private AudioSource soundtrack;
    public AudioManager audio;
    private int frame_count = 0;

	void Awake () {
        //soundtrack = GetComponent<AudioSource>();
        audio.playSound(AudioManager.tShirtWeather);
    }

    void stopSound()
    {
        soundtrack.Stop();
    }

	void Update ()
	{
	}

}