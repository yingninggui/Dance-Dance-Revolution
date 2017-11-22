using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundInput : MonoBehaviour {
	public AudioSource soundtrack;
    private int frame_count = 0;

	void Awake () {
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