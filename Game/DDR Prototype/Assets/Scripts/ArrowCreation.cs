﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowCreation : MonoBehaviour {

    public AudioManager audio;
    public Scoring score;
    public createArrows create;
    public const int bpm = 10;
    private int frame_count = 0;
    
    public int channel;
    public FFTWindow _fftWindow;
    private float[] _samples = new float[1024];
    float total_freq = 0;

    public Queue<GameObject>[] active_arrows;
    private int total_active_arrows = 0;

    void Start()
    {
        Debug.Log("Initializing Arrow Generation Class");
        channel = 0;

        active_arrows = new Queue<GameObject>[4];
        for (int i = 0; i < 4; i++)
        {
            active_arrows[i] = new Queue<GameObject>();
        }
    }
		
    void Update() {
        if (frame_count > 1/Time.deltaTime)
        {
            total_freq = 0;
            AudioSource source = audio.getAudioSource();
            if (source == null)
                return;

            source.GetSpectrumData(_samples, channel, _fftWindow);
            for (int i = 0; i < 1024; i++)
            {
                total_freq += _samples[i];
                //Debug.Log("Freq: " + _samples[i]);
            }

            if (total_freq < 0.001)
                return;

            //Debug.Log("Total Freq: " + ((int)(total_freq * 1000000) % 4) + 1);
            //create.Commission(((int)(total_freq * 1000000) % 4) + 1);
            //int position = Random.Range(0, 4);
            int position = ((int)(total_freq * 1000000)) % 4;
            Debug.Log(position);
            active_arrows[position].Enqueue(create.Commission(position));
            total_active_arrows++;
            
            frame_count = 0;
        } else
            frame_count++;
    }

    public void removeArrow(GameObject o)
    {
        create.Decommision(o);
        total_active_arrows--;
        
        if (total_active_arrows == 0)
        {
            score.endGame();
        }
    }

    public Queue<GameObject>[] getActiveArrows()
    {
        return active_arrows;
    }
}
