﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Sample1
{
    public class GamingDesktop : Desktop
    {
        public override string Name
        {
            get
            {
                return "Gaming desktop";
            }
        }
    }
}
