﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Sample1
{
    class MotherApprover : Approver
    {
        public override void ExcuteRequest(int money)
        {
            if (money < 100)
            {
                Console.WriteLine("{0} handled request {1}k", GetType().Name, money);
            }
            else
            {
                if (this.Successor != null)
                {
                    this.Successor.ExcuteRequest(money);
                }
            }
        }
    }
}
