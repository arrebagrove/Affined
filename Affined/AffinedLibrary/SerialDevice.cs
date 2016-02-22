using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace AffinedLibrary
{
    /// <summary>
    /// Handles the serial device from connecting to sending and receiving data.
    /// </summary>
    public class SerialDevice
    {
        private SerialPort obdDevice { get; set; }
        
        public SerialDevice()
        {
            
        }

        public void InitializePort(string portName, int baudRate)
        {
            obdDevice = new SerialPort();
            obdDevice.PortName = portName;
            obdDevice.BaudRate = baudRate;
            obdDevice.DataReceived += ObdDeviceDataReceived;
        }

        /// <summary>
        /// Called when serial device gets a new response from vechicle
        /// </summary>
        private void ObdDeviceDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort info = (SerialPort)sender;
            string data = info.ReadExisting();
            Console.WriteLine(data);
        }

        /// <summary>
        /// Grabs a list of all com ports
        /// </summary>
        /// <returns>List of Connected com ports</returns>
        public string[] SerialPorts()
        {
            string[] availablePorts = SerialPort.GetPortNames();

            return availablePorts;
        }

        public void OpenSerial()
        {
            if(!obdDevice.IsOpen)
            {
                obdDevice.Open();
            }
        }

        public void CloseSerial()
        {
            if(obdDevice.IsOpen)
            {
                obdDevice.Close();
            }
        }
    }
}
