using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowCreation : MonoBehaviour {

    //audio
    public AudioSource audio;

    //settings
    public int channel;
    public FFTWindow _fftWindow;
    private float[] _samples = new float[1024];


    void Start()
    {

        //channel to sample from, stereo music has 2 channels
        channel = 0;

    }

    // Update is called once per frame
    void Update()
    {
        audio.GetSpectrumData(_samples, channel, _fftWindow);
        for(int i = 0; i < 1024; i++)
        {
            Debug.Log(_samples[i]);
        }
    }
}
