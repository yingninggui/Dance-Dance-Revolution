using System.Collections;
using System.Collections.Generic;
using UnityEngine;

﻿using UnityEngine;

using System;
using System.Threading;
using System.IO.Ports;

public class SerialCommunication : MonoBehaviour {

    public GameObject GameScreen;
    public glowBox GlowBox;
    int frame = 0;

    bool running;
    Thread thread;
    private const string PORT = "\\\\.\\COM8";
    private SerialPort serial = new SerialPort(PORT, 9600);

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
        GlowBox.doesGlow('1');
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
        try
        {
            string s = serial.ReadLine();
            GlowBox.doesGlow(s[0]);
            Debug.Log(s);
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
            thread.Join();
        }
    }

    // Update is called once per frame
    void Update () {
        frame++;
        if (frame % 2 == 0)
        {
            checkSerialStream();
            frame = 0;
        }
    }
}
