using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Sample1
{
    public class GreenLight : ITrafficLightState
    {
        public void Change(TrafficLight light)
        {
            light.State = new YellowLight();
        }

        public void ReportState()
        {
            Console.WriteLine("Green Light");
        }
    }
}
