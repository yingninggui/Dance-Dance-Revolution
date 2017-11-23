using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour {

	public Sound[] sounds;

    private int current_song = 0;

    /*
     * DON'T CHANGE THESE VALUES --> They are hardcoded into the song selection menu without reference to these constants
     */
	//making constants for each song, so we can refer to it in the array.
	public const int win_points = 0, lose_point = 1, borns = 2, tShirtWeather = 3, Animal = 4, Palmer = 5, SunShine = 6;

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
        playSound();
	}

    public AudioSource getAudioSource()
    {
        Debug.Log(sounds.Length);
        if (sounds.Length == 0)
            return null;
        return sounds[current_song].source;
    }

	void Start ()
	{
		
	}
	//plays the song here.
	public void playSound ()
	{
        int song = GameNavigation.current_song;
        if (sounds.Length <= song)
            return;
		sounds [song].source.Play ();
        current_song = song;
	}
}





