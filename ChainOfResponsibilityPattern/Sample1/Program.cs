using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Sample1
{
    class Program
    {
        public static void Excute()
        {
            // http://nhatkyhoctap.blogspot.com/2014/05/design-pattern-chain-of-responsibility.html
            var money = new List<int> { 3, 30, 60, 100, 200, 500 };
            Approver brotherApprover = new BrotherApprover();
            Approver motherApprover = new MotherApprover();
            Approver fatherApprover = new FatherApprover();
            brotherApprover.Next(motherApprover);
            motherApprover.Next(fatherApprover);
            foreach (var item in money)
            {
                Console.WriteLine("Request {0}k", item);
                brotherApprover.ExcuteRequest(item);
            }
            Console.ReadLine();
        }
    }
}
