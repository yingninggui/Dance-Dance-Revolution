<<<<<<< HEAD

//﻿//using System.Collections;
////using System.Collections.Generic;
////using UnityEngine;
////using System.IO.Ports;
////
//public class SerialCommunication : MonoBehaviour {
//
//    public GameObject GameScreen;
//    private SerialPort serial;
//
//	// Use this for initialization
//	void Start () {
//        Debug.Log("Launched Start Method");
//
//        string port = "COM8";
//        serial = new SerialPort(port, 9600);
//        if (!serial.IsOpen)
//            serial.Open();
//
//        Debug.Log("Initialized Port " + port);
//    }
//	
//	// Update is called once per frame
//	void Update () {
//        try
//        {
//            string message = serial.ReadLine();
//            Debug.Log("Received Message: " + message);
//        }
//        catch (TimeoutException e) { }
//    }
//}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

﻿using UnityEngine;

using System;
using System.Threading;
using System.IO.Ports;

public class SerialCommunication : MonoBehaviour {

    public GameObject GameScreen;
    bool running;
    Thread thread;
    private const string PORT = "\\\\.\\COM8";
    private SerialPort serial = new SerialPort(PORT, 9600);

    // Use this for initialization
    void Start () {
        thread = new Thread(StartSerialCommunication);
        thread.Start();
    }

    void StartSerialCommunication()
    {
        Debug.Log("Launched Start Method");

        Debug.Log(SerialPort.GetPortNames());
        running = true;
        try
        {
            serial.Open();
        } catch (Exception e) {
            Debug.LogError(e.Message);
        }

        Debug.Log("Initialized Port " + PORT);

        while (running)
        {
            try
            {
                Debug.Log(serial.ReadLine());
            } catch (Exception e)
            {
                Debug.LogError(e.Message);
            }
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
        /*
        try {
            string message = serial.ReadLine();
            Debug.Log("Received Message: " + message);
        }
        catch (TimeoutException e) {
            Debug.LogError(e.Message);
        }*/
    }
}
