using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using System.IO.Ports;

public class SerialCommunication : MonoBehaviour {

    public GameObject GameScreen;
    public glowBox[] glowBoxes;
    public Scoring score;

    int frame = 0;
   
    private const string PORT = "\\\\.\\COM8";
    private SerialPort serial = new SerialPort(PORT, 9600);

    public const int UP = 0, DOWN = 1, LEFT = 2, RIGHT = 3, CONST = 4;

    // Use this for initialization
    void Start () {
        /*thread = new Thread(StartSerialCommunication);
        thread.Start();*/
        //DontDestroyOnLoad(this);
        StartSerialCommunication();
    }

    void StartSerialCommunication()
    {
        Debug.Log("Launched Start Method");

        Debug.Log(SerialPort.GetPortNames());
        serial.ReadTimeout = 5;
        try
        {
            serial.Open();
        } catch (Exception e) {
            Debug.LogError(e.Message);
        }

        Debug.Log("Initialized Port " + PORT);

    }

    void checkSerialStream()
    {
        try
        {
            string s = serial.ReadLine();
            char[] c = s.ToCharArray();

            // Don't proceed if glow boxes aren't loaded
            if (c.Length <= 0 || glowBoxes.Length < 4)
                return;

            //Test code to simulate game pad presses through Arduino
            //char[] c = new char[1];
            //c[0] = (char)(UnityEngine.Random.Range(0, 4) + (int)'0') ; 
            
            // Pressed appropriate box based on which pad is pressed
            switch(((int)(c[0] - '0')) % 4)
            {
                case UP:
                    glowBoxes[0].changeGlow();
                    score.pressedKey(UP);
                    break;
                case DOWN:
                    glowBoxes[1].changeGlow();
                    score.pressedKey(DOWN);
                    break;
                case LEFT:
                    glowBoxes[2].changeGlow();
                    score.pressedKey(LEFT);
                    break;
                case RIGHT:
                    glowBoxes[3].changeGlow();
                    score.pressedKey(RIGHT);
                    break;
            }

        }
        catch (Exception e)
        {
            Debug.LogError(e.Message);
        }
    }

    void OnDisable()
    {
    }

    // Update is called once per frame
    void Update () {
        frame++;
        // Check stream every other frame
        if (frame > 1)
        {
            checkSerialStream();
            frame = 0;
        }
    }
}
