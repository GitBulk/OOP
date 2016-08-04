using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Sample1
{
    public class Company
    {
        IRole role;
        public Company(IRole role)
        {
            this.role = role;
        }

        public void DefineResponsibility()
        {
            this.role.DoTask();
        }
    }
}
