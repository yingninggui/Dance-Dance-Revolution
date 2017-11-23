using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using System.Threading;
using System.IO.Ports;

public class SerialCommunication : MonoBehaviour {

    public GameObject GameScreen;
    public glowBox[] glowBoxes;
    public Scoring score;

    int frame = 0;

    bool running;
    Thread thread;
    private const string PORT = "\\\\.\\COM8";
    private SerialPort serial = new SerialPort(PORT, 9600);

    public const int UP = 0, DOWN = 1, LEFT = 2, RIGHT = 3, CONST = 4;

    // Use this for initialization
    void Start () {
        /*thread = new Thread(StartSerialCommunication);
        thread.Start();*/
        StartSerialCommunication();
    }

    void StartSerialCommunication()
    {
        Debug.Log("Launched Start Method");

        Debug.Log(SerialPort.GetPortNames());
        serial.ReadTimeout = 5;
        running = true;
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
        score.pressedKey(RIGHT);
        score.pressedKey(LEFT);
        score.pressedKey(UP);
        score.pressedKey(DOWN);
        try
        {
            string s = serial.ReadLine();
            char[] c = s.ToCharArray();
            if (c.Length <= 0 || glowBoxes.Length <= 4)
                return;
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
            Debug.Log(c);
        }
        catch (Exception e)
        {
            Debug.LogError(e.Message);
        }
    }

    void OnDisable()
    {
        Debug.Log("Exiting Thread");
        if (running)
        {
            running = false;
            //thread.Join();
        }
    }

    // Update is called once per frame
    void Update () {
        frame++;
        if (frame > 1)
        {
            checkSerialStream();
            frame = 0;
        }
    }
}
