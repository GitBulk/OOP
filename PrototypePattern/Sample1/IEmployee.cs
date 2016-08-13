using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Sample1
{
    interface IEmployee
    {
        IEmployee Clone();
        string GetDetails();
    }
}
