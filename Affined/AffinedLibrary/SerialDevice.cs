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
            // obdDevice.DataReceived += ObdDeviceDataReceived;
            OpenSerial();

            Console.Write("Initializing complete.");
        }

        /// <summary>
        /// Called when serial device gets a new response from vechicle
        /// </summary>
        private void ObdDeviceDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort info = (SerialPort)sender;
            string data = info.ReadExisting();
            data = data.Replace("\r", " ");
            Console.WriteLine(data);
        }

        /// <summary>
        /// Sends data to the vehicle
        /// </summary>
        /// <param name="mode">Mode type</param>
        /// <param name="pid">PID type</param>
        public void SendData(Mode mode, PID pid)
        {
            // now lets convert these so they will send correctly
            string code = Convert.ToUInt32(mode).ToString("X2") + Convert.ToUInt32(pid).ToString("X2") + "\r";
            

            // now lets write it out
            obdDevice.Write(code);
        }

        /// <summary>
        /// Grabs a list of all com ports
        /// </summary>
        /// <returns>List of Connected com ports</returns>
        public string[] GetSerialPorts()
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

        public int GetSpeed()
        {
            // now lets convert these so they will send correctly
            string code = Convert.ToUInt32(Mode.CurrentData).ToString("X2") + Convert.ToUInt32(PID.RPM).ToString("X2") + "\r";


            // now lets write it out
            obdDevice.Write(code);

            // lets get the info back

            string data = obdDevice.ReadExisting();
            data = data.Replace("\r", " ");
            Console.Write(data);

            return 0;
        }

        public int GetRPMs()
        {
            // now lets convert these so they will send correctly
            string code = Convert.ToUInt32(Mode.CurrentData).ToString("X2") + Convert.ToUInt32(PID.RPM).ToString("X2") + "\r";


            // now lets write it out
            obdDevice.Write(code);

            // lets get the info back

            string data = obdDevice.ReadExisting();
            data = data.Replace("\r", " ");
            Console.Write(data);

            return 0;
        }

        public int GetIntakeTemp()
        {
            // now lets convert these so they will send correctly
            string code = Convert.ToUInt32(Mode.CurrentData).ToString("X2") + Convert.ToUInt32(PID.IntakeTemp).ToString("X2") + "\r";


            // now lets write it out
            obdDevice.Write(code);

            // lets get the info back

            string data = obdDevice.ReadExisting();
            data = data.Replace("\r", " ");
            Console.Write(data);

            return 0;
        }

        public int GetOilTemp()
        {
            // now lets convert these so they will send correctly
            string code = Convert.ToUInt32(Mode.CurrentData).ToString("X2") + Convert.ToUInt32(PID.OilTemp).ToString("X2") + "\r";


            // now lets write it out
            obdDevice.Write(code);

            // lets get the info back

            string data = obdDevice.ReadExisting();
            data = data.Replace("\r", " ");
            Console.Write(data);

            return 0;
        }

        public int GetCoolentTemp()
        {
            // now lets convert these so they will send correctly
            string code = Convert.ToUInt32(Mode.CurrentData).ToString("X2") + Convert.ToUInt32(PID.CoolentTemp).ToString("X2") + "\r";


            // now lets write it out
            obdDevice.Write(code);

            // lets get the info back

            string data = obdDevice.ReadExisting();
            data = data.Replace("\r", " ");
            Console.Write(data);

            return 0;
        }

        public int GetEngineLoad()
        {
            // now lets convert these so they will send correctly
            string code = Convert.ToUInt32(Mode.CurrentData).ToString("X2") + Convert.ToUInt32(PID.EngineLoad).ToString("X2") + "\r";


            // now lets write it out
            obdDevice.Write(code);

            // lets get the info back

            string data = obdDevice.ReadExisting();
            data = data.Replace("\r", " ");
            Console.Write(data);

            return 0;
        }

        public int GetAirFlowRate()
        {
            // now lets convert these so they will send correctly
            string code = Convert.ToUInt32(Mode.CurrentData).ToString("X2") + Convert.ToUInt32(PID.AirFlowRate).ToString("X2") + "\r";


            // now lets write it out
            obdDevice.Write(code);

            // lets get the info back

            string data = obdDevice.ReadExisting();
            data = data.Replace("\r", " ");
            Console.Write(data);

            return 0;
        }

        public int GetMPG()
        {
            return 0;
        }
    }
}
