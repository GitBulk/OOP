using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPattern.Sample1
{
    interface ICriteria
    {
        IEnumerable<Person> Filter(IEnumerable<Person> people);
    }
}
