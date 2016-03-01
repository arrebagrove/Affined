using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AffinedLibrary;

namespace AffinedTest
{
    class Program
    {
        static SerialDevice sd;
        static void Main(string[] args)
        {
            sd = new SerialDevice();
            string[] ports = sd.GetSerialPorts();

            foreach(String s in ports)
            {
                Console.WriteLine(s);
            }

            string comPort = Console.ReadLine();

            sd.InitializePort(comPort, 38400);

            Console.WriteLine("\nSending value of rpm!");

            sd.GetRPMs();

            Console.ReadLine();
        }
    }
}
