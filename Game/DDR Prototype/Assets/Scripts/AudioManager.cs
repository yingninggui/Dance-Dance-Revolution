using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour {

	public Sound[] sounds;
	public const int win_points = 0, lose_point = 1;
	public const int borns = 2, tShirtWeather = 3, Animal = 4, Palmer = 5, SunShine = 6;

	// Use this for initialization
	void Awake () {
		foreach (Sound s in sounds) {
			s.source = gameObject.AddComponent<AudioSource> ();
			s.source.clip = s.clip;
			s.source.volume = s.volume;
			s.source.pitch = s.pitch;
			s.source.loop = s.loop;

		}
	}

	void Start ()
	{
		
	}

	public void playSound (int song)
	{
		sounds [song].source.Play ();

	}
}





