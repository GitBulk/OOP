using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Sample1
{
    public static class Program
    {
        public static void Excute()
        {
            TrafficLight light = new TrafficLight();
            light.State = new RedLight();
            for (int i = 0; i < 9; i++)
            {
                light.Change();
                light.ReportState();
            }
            Console.ReadLine();
        }
    }
}
