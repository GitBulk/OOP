using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Sample2
{
    class EmployeeSummaryReport : Report
    {
        EmployeeModel model;

        public EmployeeSummaryReport(EmployeeModel model)
        {
            this.model = model;
        }

        public override void Print()
        {
            PrintReportHeader();

            Console.WriteLine("Employee {0}-{1} years old", model.Name, model.Age);

            PrintReportFooter();
        }
    }
}
