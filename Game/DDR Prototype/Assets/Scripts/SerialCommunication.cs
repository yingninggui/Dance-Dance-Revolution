
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
using System;
using System.IO.Ports;

public class SerialCommunication : MonoBehaviour {

    public GameObject GameScreen;
    private const string PORT = "\\\\.\\COM8";
    private SerialPort serial = new SerialPort(PORT, 9600);

    // Use this for initialization
    void Start () {
        Debug.Log("Launched Start Method");

        Debug.Log(SerialPort.GetPortNames());

        serial.Open();

        Debug.Log("Initialized Port " + PORT);
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
