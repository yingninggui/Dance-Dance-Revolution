﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowCreation : MonoBehaviour {

    public AudioSource audio;
    public createArrows create;
    public const int bpm = 10;
    private int frame_count = 0;
    
    public int channel;
    public FFTWindow _fftWindow;
    private float[] _samples = new float[1024];
    float total_freq = 0;

    void Start()
    {
        Debug.Log("Initializing Arrow Generation Class");
        //channel to sample from, stereo music has 2 channels
        channel = 1;
    }

    // Update is called once per frame
    void Update()
    {
        // TODO Relate this to frame delta time
        if (frame_count > 2)
        {
            total_freq = 0;
            audio.GetSpectrumData(_samples, channel, _fftWindow);
            for (int i = 0; i < 1024; i++)
            {
                total_freq += _samples[i];
                //Debug.Log("Freq: " + _samples[i]);
            }

            //Debug.Log("Total Freq: " + ((int)(total_freq * 1000000) % 4) + 1);
            //create.Commission(((int)(total_freq * 1000000) % 4) + 1);
            create.Commission(Random.Range(0, 4) + 1);
            frame_count = 0;
        }

        frame_count++;
    }
}
