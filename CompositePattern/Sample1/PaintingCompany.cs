using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Sample1
{
    class PaintingCompany : IPainter
    {
        private readonly IEnumerable<IPainter> painters;

        public PaintingCompany(IEnumerable<IPainter> painters)
        {
            this.painters = painters;
        }

        private double GetVelocity(Painter painter)
        {
            return painter.EstimateDaysToPaint(1);
        }

        private double GetTotalVelocity()
        {
            return this.painters.Sum(p => GetVelocity((Painter)p));
        }

        public double EstimateDaysToPaint(int houses)
        {
            return GetTotalVelocity() * houses;
        }
    }
}
