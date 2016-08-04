using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Sample1
{
    public class SmartCompany
    {
        private static Dictionary<Roles, IRole> Strategies = new Dictionary<Roles, IRole>();

        static SmartCompany()
        {
            Strategies.Add(Roles.Dev, new DevRole());
            Strategies.Add(Roles.Director, new DirectorRole());
            Strategies.Add(Roles.PM, new PMRole());
            Strategies.Add(Roles.QC, new QCRole());
        }

        public static void DoTask(Roles roles)
        {
            Strategies[roles].DoTask();
        }
    }
}
