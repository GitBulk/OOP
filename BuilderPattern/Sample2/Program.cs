using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Sample2
{
    class Program
    {
        public static void Excute()
        {
            var vehicleCreator = new VehicleCreator(new HondaBuilder());
            vehicleCreator.CreateVehicle();
            var hondaVehicle = vehicleCreator.GetVehicle();
            hondaVehicle.ShowInfo();
            Console.ReadLine();
        }
    }
}
