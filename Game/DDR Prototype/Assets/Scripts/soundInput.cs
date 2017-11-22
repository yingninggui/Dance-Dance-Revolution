// File to be deleted.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundInput : MonoBehaviour {
	private AudioSource soundtrack;
    private int frame_count = 0;

	void Awake () {
		soundtrack = GetComponent<AudioSource>();
        playSound();
    }
		
	void playSound ()
	{
		soundtrack.Play();
	}

    void stopSound()
    {
        soundtrack.Stop();
    }

	void Update ()
	{
	}

}