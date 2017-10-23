using UnityEngine;
using System.Collections;
using System.IO.Ports;
using System;

public class SerialCommunication : MonoBehaviour {

	SerialPort serial;

	// Use this for initialization
	void Start () {
		serial = new SerialPort ("COM8", 9600);
        if (!serial.IsOpen)
            serial.Open();
	}
	
	// Update is called once per frame
	void Update () {
        try {
            string message = serial.ReadLine();
            Console.WriteLine(message);
        } catch (TimeoutException e) { }
	}
}
