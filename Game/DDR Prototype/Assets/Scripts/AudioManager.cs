using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour {

	public Sound[] sounds;
	public const int win_points = 0, lose_point = 1;
	public const int borns = 2, tShirtWeather = 3, Animal = 4, Palmer = 5, SunShine = 6;

    ArrowCreation initializer;

	// Use this for initialization
	void Awake () { 
		foreach (Sound s in sounds) {
			s.source = gameObject.AddComponent<AudioSource> ();
			s.source.clip = s.clip;
			s.source.volume = s.volume;
			s.source.pitch = s.pitch;
			s.source.loop = s.loop;
            Debug.Log(sounds.Length + ":" + s.name);
		}
	}

	void Start ()
	{
		
	}

	public void playSound (int song)
	{
        if (sounds.Length == 0)
            Awake();
        Debug.Log("LENGTH OF ARRAY: " + sounds.Length);
		sounds [song].source.Play ();
        initializer.setAudio(sounds[song].source);
	}
}





