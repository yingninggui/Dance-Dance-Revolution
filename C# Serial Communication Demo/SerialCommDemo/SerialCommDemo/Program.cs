using System;
using System.IO.Ports;

namespace SerialCommDemo
{
    class Program
    {
        SerialPort serial;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }            

        // Use this for initialization
        void Start()
        {
            serial = new SerialPort("COM8", 9600);
            if (!serial.IsOpen)
                serial.Open();
        }

        // Update is called once per frame
        void Update()
        {
            try
            {
                string message = serial.ReadLine();
                Console.WriteLine(message);
            }
            catch (TimeoutException e) { }
        }

    }
}