using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Sample1
{
    public class ComputerClient
    {
        Laptop laptop;
        Desktop desktop;
        public ComputerClient(IComputerFactory computerFactory, ComputerType type)
        {
            laptop = computerFactory.GetLaptop(type);
            desktop = computerFactory.GetDesktop(type);
        }

        public void PrintLaptopInformation()
        {
            Console.WriteLine("Name: {0}, Model: {1}", laptop.Name, laptop.Model);
        }

        public void PrintDesktopInformation()
        {
            Console.WriteLine("Name: {0}, Model: {1}", desktop.Name, desktop.Model);
        }
    }
}
