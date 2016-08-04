using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Sample2
{
    public class VehicleCreator
    {
        private readonly IVehicleBuilder builder;
        public VehicleCreator(IVehicleBuilder builder)
        {
            this.builder = builder;
        }

        public void CreateVehicle()
        {
            builder.SetModel();
            builder.SetEngine();
            builder.SetBody();
            builder.SetTransmission();
            builder.SetAccessories();
        }

        public Vehicle GetVehicle()
        {
            return builder.GetVehicle();
        }
    }
}
