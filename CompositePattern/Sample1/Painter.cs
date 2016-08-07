using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Sample1
{
    class Painter : IPainter
    {
        private readonly double daysPerHouse;
        public Painter(double daysPerHouse)
        {
            this.daysPerHouse = daysPerHouse;
        }
        public double EstimateDaysToPaint(int houses)
        {
            return houses * this.daysPerHouse;
        }
    }
}
