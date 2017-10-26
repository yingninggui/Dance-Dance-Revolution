﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundInput : MonoBehaviour {
	public AudioClip soundBackground; 
	private AudioSource soundtrack; 
	// Use this for initialization
	void Awake () {
		soundtrack = GetComponent<AudioSource>();  
	}
	void playSound ()
	{
		soundtrack.PlayOneShot (soundBackground, 1F);
	}

	void Update ()
	{
		playSound ();
	}

}