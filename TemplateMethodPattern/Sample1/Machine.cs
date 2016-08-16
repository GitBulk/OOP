using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Sample1
{
    class Machine
    {
        public void Excute()
        {
            Start();
            Produce();
            Stop();
        }

        protected virtual void Stop()
        {
            Trace.WriteLine("Machine stop.");
        }

        protected virtual void Produce()
        {
            Trace.WriteLine("Machine produce.");
        }

        protected virtual void Start()
        {
            Trace.WriteLine("Machine start.");
        }
    }
}
