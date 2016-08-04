using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Sample1
{
    public class QCRole : IRole
    {
        public void DoTask()
        {
            Console.WriteLine("Do QC's tasks");
        }
    }
}
