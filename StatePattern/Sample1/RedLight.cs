using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Sample1
{
    public class RedLight : ITrafficLightState
    {
        public void Change(TrafficLight light)
        {
            light.State = new GreenLight();
        }

        public void ReportState()
        {
            Console.WriteLine("Red light");
        }
    }
}
