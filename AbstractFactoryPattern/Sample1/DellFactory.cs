using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Sample1
{
    public class DellFactory : IComputerFactory
    {
        public Desktop GetDesktop(ComputerType type)
        {
            switch (type)
            {
                case ComputerType.Gaming:
                    return new GamingDesktop() { Model = "Game Desktop Dell 2" };
                case ComputerType.Normal:
                    return new NormalDesktop() { Model = "Normal Desktop Dell 2" };
                default:
                    throw new Exception("Unsupported type");
            }
        }

        public Laptop GetLaptop(ComputerType type)
        {
            switch (type)
            {
                case ComputerType.Gaming:
                    return new GamingLaptop() { Model = "Game Laptop Dell 2" };
                case ComputerType.Normal:
                    return new GamingLaptop() { Model = "Game Desktop Dell 2" };
                default:
                    throw new Exception("Unsupported type");
            }
        }
    }
}
