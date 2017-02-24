using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Sample2
{
    abstract class Report
    {
        public abstract void Print();
        
        protected virtual void PrintReportHeader()
        {
            Console.WriteLine("Company XXX report");
        }

        protected virtual void PrintReportFooter()
        {
            Console.WriteLine("Report Date: {0}", DateTime.Now);
        }
    }
}
