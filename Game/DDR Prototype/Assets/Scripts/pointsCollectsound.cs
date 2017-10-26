using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointsCollectsound : MonoBehaviour {

	public AudioClip getPoint;
	public AudioClip losePoint;

	private AudioSource source;

	// Use this for initialization
	void Awake () {
		source = GetComponent<AudioSource>();

	}
	
	void GetPointEnter ()
	{
		source.PlayOneShot (getPoint, 1F);
	}

	void Update ()
	{
		GetPointEnter ();
	}
}
