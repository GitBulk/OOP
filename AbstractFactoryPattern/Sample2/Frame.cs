using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Sample2
{
    class Frame
    {
        public static void Run()
        {
            string type = "Employee";
            Report report = ReportFactory.Create(type);
            report.Print();
        }
    }
}
