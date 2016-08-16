using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Sample1
{
    abstract class Approver
    {
        protected Approver Successor;

        public abstract void ExcuteRequest(int money);
        public void Next(Approver nextApprover)
        {
            this.Successor = nextApprover;
        }
    }
}
