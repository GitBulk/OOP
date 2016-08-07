using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Sample1
{
    class LandOwner
    {
        private readonly IPainter painter;
        private readonly int housesCount;

        public LandOwner(IPainter painter, int housesCount)
        {
            this.painter = painter;
            this.housesCount = housesCount;
        }

        public void ManageHouses()
        {
            double daysToPaint = this.painter.EstimateDaysToPaint(this.housesCount);
            Console.WriteLine("Painting houses for {0} day(s).", daysToPaint );
        }
    }
}
