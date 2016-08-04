using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Sample1
{
    public class AppleFactory : IComputerFactory
    {
        public Desktop GetDesktop(ComputerType type)
        {
            switch (type)
            {
                case ComputerType.Gaming:
                    return new GamingDesktop() { Model = "Game Desktop Apple 1" };
                case ComputerType.Normal:
                    return new NormalDesktop() { Model = "Normal Desktop Apple 1" };
                default:
                    throw new Exception("Unsupported type");
            }
        }

        public Laptop GetLaptop(ComputerType type)
        {
            switch (type)
            {
                case ComputerType.Gaming:
                    return new GamingLaptop() { Model = "Game Laptop Apple 1" };
                case ComputerType.Normal:
                    return new GamingLaptop() { Model = "Game Desktop Apple 1" };
                default:
                    throw new Exception("Unsupported type");
            }
        }
    }
}
