using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Sample1
{
    public class TrafficLight
    {
        public ITrafficLightState State { get; set; }

        public void Change()
        {
            this.State.Change(this);
        }

        public void ReportState()
        {
            this.State.ReportState();
        }
    }
}
