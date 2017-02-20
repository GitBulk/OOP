using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Sample2
{
    class CompanyMonthlyReport : Report
    {
        CompanyMonthlyModel model;
        public CompanyMonthlyReport(CompanyMonthlyModel model)
        {
            this.model = model;
        }

        public override void Print()
        {
            PrintReportHeader();
            Console.WriteLine("Company Monthly {0}-{1}", model.Month, model.Revenue);
            PrintReportFooter();
        }
    }
}
