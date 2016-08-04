using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Sample2
{
    class HondaBuilder : IVehicleBuilder
    {
        Vehicle vehicle = new Vehicle();
        public Vehicle GetVehicle()
        {
            return vehicle;
        }

        public void SetAccessories()
        {
            vehicle.Accessories.Add("Seat Cover");
            vehicle.Accessories.Add("Rear Mirror");
            vehicle.Accessories.Add("Helmet");
        }

        public void SetBody()
        {
            vehicle.Body = "Plastic";
        }

        public void SetEngine()
        {
            vehicle.Engine = "4 Stroke";
        }

        public void SetModel()
        {
            vehicle.Model = "Honda";
        }

        public void SetTransmission()
        {
            vehicle.Transmission = "125 km/hr";
        }
    }
}
