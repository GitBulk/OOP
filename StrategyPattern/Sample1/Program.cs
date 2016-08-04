using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Sample1
{
    public static class Program
    {
        public static void Excute()
        {
            //Company company = new Company(new PMRole());
            //Console.WriteLine("Role of PM");
            //company.DefineResponsibility();
            //Console.WriteLine("Role of Dev");
            //company = new Company(new DevRole());
            //company.DefineResponsibility();


            SmartCompany.DoTask(Roles.Dev);
            Console.ReadLine();
        }
    }
}
