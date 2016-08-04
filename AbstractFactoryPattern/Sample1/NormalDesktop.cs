using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Sample1
{
    public class NormalDesktop : Desktop
    {
        public override string Name
        {
            get
            {
                return "Normal desktop";
            }
        }
    }
}
