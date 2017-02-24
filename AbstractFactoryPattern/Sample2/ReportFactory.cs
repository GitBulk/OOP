using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Sample2
{
    class ReportFactory
    {
        public static Report Create(string type)
        {
            Report report;
            if (type == "MonthlyCompany")
            {
                report = new CompanyMonthlyReport(new CompanyMonthlyModel
                {
                    Month = "Jan", Revenue = 1
                });
            }
            else
            {
                report = new EmployeeSummaryReport(new EmployeeModel
                {
                    Age = 20,
                    Name = "toan"
                });
            }
            return report;
        }
    }
}
