using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Sample1
{
    class BurgerMachine : Machine
    {
        protected override void Produce()
        {
            Trace.WriteLine("BurgerMachine.Producing");
        }
    }
}
