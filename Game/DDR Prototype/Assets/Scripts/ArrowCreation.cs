using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Add arrows to game based on music frequency
 */
public class ArrowCreation : MonoBehaviour {

    public AudioManager audio;
    public Scoring score;
    public createArrows create;

    private int frame_count = 0;
    
    public int channel;
    public FFTWindow _fftWindow;
    private float[] _samples = new float[1024];
    float total_freq = 0;

    /*
     * All arrows currently visible to the user, seperated into 4 arrays, 
     * one for each direction 
     * Array indices are mappepd to constants in AudioManager class
     */
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

            // Uses a Fast Fourier Transform algorithm to generate strength at different frequencies
            source.GetSpectrumData(_samples, channel, _fftWindow);

            // Sum all of these strengths at each frequency
            for (int i = 0; i < 1024; i++)
            {
                total_freq += _samples[i];
                //Debug.Log("Freq: " + _samples[i]);
            }

            // Don't create an arrow if there's no audible sound
            if (total_freq < 0.001)
                return;

            //Debug.Log("Total Freq: " + ((int)(total_freq * 1000000) % 4) + 1);
            //create.Commission(((int)(total_freq * 1000000) % 4) + 1);
            //int position = Random.Range(0, 4);

            // Map different total frequency strength values to number in range 0 to 3
            // mapping to one of the contstants in SerialCommunication (UP, DOWN, LEFT, RIGHT)
            int position = ((int)(total_freq * 1000000)) % 4;
            Debug.Log(position);
            active_arrows[position].Enqueue(create.Commission(position));
            total_active_arrows++;
            
            frame_count = 0;
        } else
            frame_count++;
    }

    /*
     * Remove arrows from scene and decrement total arrow count
     */
    public void removeArrow(GameObject o)
    {
        create.Decommision(o);
        total_active_arrows--;

        /* End the game provided there are no arrows on the screen left 
        (allows dynamic song ending based on length of song and also 
        ignores empty space at end of song */
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
