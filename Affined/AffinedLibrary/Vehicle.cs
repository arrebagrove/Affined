using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffinedLibrary
{
    public class Vehicle
    {
        public int speed { get; set; }
        public int rpm { get; set; }
        public int intakeTemp { get; set; }
        public int oilTemp { get; set; }
        public int coolentTemp { get; set; }
        public int engineLoad { get; set; }
        public int airFlowRate { get; set; }
        public int mpg { get; set; }


        /// <summary>
        /// Sets all values to 0 as defualt when creating a new instance.
        /// </summary>
        public Vehicle()
        {
            speed = 0;
            rpm = 0;
            intakeTemp = 0;
            oilTemp = 0;
            coolentTemp = 0;
            engineLoad = 0;
            airFlowRate = 0;
            mpg = 0;
        }
    }
}
