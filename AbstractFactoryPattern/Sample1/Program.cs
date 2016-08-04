using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Sample1
{
    public static class Program
    {
        public static void Excute()
        {
            IComputerFactory dellFactory = new DellFactory();
            IComputerFactory appleFactory = new AppleFactory();

            var dellClient = new ComputerClient(dellFactory, ComputerType.Gaming);
            Console.WriteLine("Dell Products");
            dellClient.PrintDesktopInformation();
            dellClient.PrintLaptopInformation();
            Console.ReadLine();
        }
    }
}
