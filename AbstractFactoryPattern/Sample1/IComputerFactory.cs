using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Sample1
{
    public interface IComputerFactory
    {
        Laptop GetLaptop(ComputerType type);
        Desktop GetDesktop(ComputerType type);
    }
}
